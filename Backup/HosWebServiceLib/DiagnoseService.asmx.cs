using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.Services;
using System.Web.Services.Protocols;
using System.Xml.Linq;

using System.Workflow.Activities;
using System.Workflow.Runtime;

using Hos.WorkFlow.LocalServices;

namespace Hos.WebService
{
    /// <summary>
    /// DiagnoseService 的摘要说明
    /// </summary>
    [WebService(Namespace = "http://hl7.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [ToolboxItem(false)]
    // 若要允许使用 ASP.NET AJAX 从脚本中调用此 Web 服务，请取消对下行的注释。
    // [System.Web.Script.Services.ScriptService]
    public class DiagnoseService : System.Web.Services.WebService
    {
        [WebMethod]
        public string stratTreatWf(string patientStrID)
        {
            Guid patientGuidID = new Guid(patientStrID);

            Dictionary<String, Object> wfArguments = new Dictionary<String, Object>();
            //wfArguments.Add("parentWfID", parentWfID);
            wfArguments.Add("patientStrID", patientStrID);

            WorkflowInstance wfInstantce = Global.wfRuntime.CreateWorkflow(typeof(Hos.WorkFlow.WfTreat), wfArguments);

            wfInstantce.Start();

            //在工作流的管理端保存的病人的集合
            Global.patientCollection.Add(patientGuidID, wfInstantce.InstanceId, WorkflowType.TREAT_CHILD);

            return "Treat工作流已启动";
        }

        //负责触发子工作流中等待分诊结果的状态
        [WebMethod]
        public string OnTriage(string patientStrID)
        {
            Guid patientGuid = new Guid(patientStrID);
            Guid? WfGuid = Global.patientCollection.GetWorkFlowFromPatient(patientGuid, WorkflowType.TREAT_CHILD);

            if (WfGuid.HasValue)
            {
                TriageCompletedEventArgs args = new TriageCompletedEventArgs(WfGuid.Value);
                args.DepartmentID = "肠胃科";
                args.WaitForIdle = true;

                Global.wfLocalServices.OnTriageCompleted(args);

                return "分诊到肠胃科";
            }
            else
            {
                return "失败鸟";
            }


        }

        [WebMethod]
        public string OnDianoseCompleted(string patientStrID)
        {
            Guid patientGuidID = new Guid(patientStrID);
            Guid? childWfID = Global.patientCollection.GetWorkFlowFromPatient(patientGuidID, WorkflowType.TREAT_CHILD);

            if (childWfID.HasValue)
            {
                //暂时将子工作流的的完成状态设为nothing，直接离开
                DiagnoseCompletedEventArgs args = new DiagnoseCompletedEventArgs(childWfID.Value);
                args.NeedChanged = false;
                args.NextDirection = DiagnoseDirection.Examination;
                args.WaitForIdle = true;
        
                Global.wfLocalServices.OnDiagnoseCompleted(args);

                return "诊断完成";
            } 
            else
            {
                return "失败鸟";
            }

        }

//         [WebMethod]
//         public void OnParentDianoseCompleted(Guid patientGuidID)
//         {
//             //Guid patientGuidID = new Guid(patientStrID);
//             Guid? parentWfID = Global.patientCollection.GetWorkFlowFromPatient(patientGuidID, WorkflowType.PARENT);
// 
//             if (parentWfID.HasValue)
//             {
//                 //直接将主工作流承接的病人状态设为nothing，直接离开
//                 DiagnoseCompletedEventArgs args = new DiagnoseCompletedEventArgs(parentWfID.Value);
//                 args.NeedChanged = false;
//                 args.NextDirection = DiagnoseDirection.Complete;
//                 args.WaitForIdle = true;
//                 Global.wfLocalServices.OnDiagnoseCompleted(args);
//             } 
//             else
//             {
//             }
// 
//         }
    }
}
