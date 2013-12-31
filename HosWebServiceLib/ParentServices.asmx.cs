using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;

using System.Workflow.Activities;
using System.Workflow.ComponentModel;
using System.Workflow.Runtime;

using Hos.WorkFlow;
using Hos.WorkFlow.LocalServices;
using Hos.WebService;

using System.Collections;

namespace HosWebServiceLib
{
    /// <summary>
    /// Service1 的摘要说明
    /// </summary>
    [WebService(Namespace = "http://hl7.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // 若要允许使用 ASP.NET AJAX 从脚本中调用此 Web 服务，请取消对下行的注释。
    // [System.Web.Script.Services.ScriptService]
    public class Service1 : System.Web.Services.WebService
    {
        private Guid patientGuidID;
        private Guid? wfGuidID;

        [WebMethod]
        public ArrayList getAllPatientID()
        {
            return Global.patientCollection.getAllPatientStrID();
        }

        [WebMethod]
        public string startMainWf()
        {
            //Guid WfID = Guid.NewGuid();
            
            this.patientGuidID = Guid.NewGuid();
            

            Dictionary<String, Object> wfArguments = new Dictionary<String, Object>();
            //wfArguments.Add("WfID", WfID);

            wfArguments.Add("patientStrID", Convert.ToString(this.patientGuidID));

            WorkflowInstance wfInstantce = Global.wfRuntime.CreateWorkflow(typeof(Hos.WorkFlow.WfMain), wfArguments);

            wfInstantce.Start();

            //在工作流的管理端保存的病人的集合
            Global.patientCollection.Add(patientGuidID, wfInstantce.InstanceId, WorkflowType.PARENT);

            return "主工作流已启动";
        }

        [WebMethod]
        public string OnChargeCompleted(string patientStrID)
        {
            patientGuidID = new Guid(patientStrID);
            wfGuidID = Global.patientCollection.GetWorkFlowFromPatient(patientGuidID, WorkflowType.PARENT);
            if (wfGuidID.HasValue)
            {
                ChargeCompletedEventArgs args = new ChargeCompletedEventArgs(wfGuidID.Value);
                args.NextDirection = CharegeDirection.REGISTER;
                args.WaitForIdle = true;

                Global.wfLocalServices.OnChargeCompleted(args);
                return "收费完成";
            }
            else
            {
                return "病人ID错误";
            }

        }

        [WebMethod]
        public string OnRegisterCompleted(string patientStrID)
        {
            patientGuidID = new Guid(patientStrID);
            wfGuidID = Global.patientCollection.GetWorkFlowFromPatient(patientGuidID, WorkflowType.PARENT);
            if (wfGuidID.HasValue)
            {
                RegisterCompletedEventArgs args = new RegisterCompletedEventArgs(wfGuidID.Value);
                args.WaitForIdle = true;

                Global.wfLocalServices.OnRegisterCompleted(args);
                return "注册完成";
            }
            else
            {
                return "病人ID错误";
            }

        }

        [WebMethod]
        public string OnDiagnoseCompleted(string patientStrID, DiagnoseDirection direction)
        {
            patientGuidID = new Guid(patientStrID);
            wfGuidID = Global.patientCollection.GetWorkFlowFromPatient(patientGuidID, WorkflowType.PARENT);
            if (wfGuidID.HasValue)
            {
                DiagnoseCompletedEventArgs args = new DiagnoseCompletedEventArgs(wfGuidID.Value);
                args.NextDirection = direction;

                Global.wfLocalServices.OnDiagnoseCompleted(args);
                return "就诊完成";
            }
            else
            {
                return "病人ID错误";
            }
        }

        [WebMethod]
        public string OnMedicalAdviceCompleted(string patientStrID)
        {
            patientGuidID = new Guid(patientStrID);
            wfGuidID = Global.patientCollection.GetWorkFlowFromPatient(patientGuidID, WorkflowType.PARENT);
            if (wfGuidID.HasValue)
            {
                MedicalAdviceCompletedEventArgs args = new MedicalAdviceCompletedEventArgs(wfGuidID.Value);
                args.WaitForIdle = true;

                Global.wfLocalServices.OnMedicalAdviceCompleted(args);
                 return "医嘱完成";
            }
            else
            {
                return "病人ID错误";
            }
        }
    }
}
