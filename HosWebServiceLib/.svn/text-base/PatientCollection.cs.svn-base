using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

using System.Workflow.Runtime;
using System.Collections;

namespace Hos.WebService
{
    public enum WorkflowType { PARENT = 0, TREAT_CHILD = 1, TypeAmount = 2}
    /// <summary>
    /// 病人集合，用于将病人ID和工作流关联
    /// </summary>
    public class PatientCollection
    {
        private Dictionary<Guid, ArrayList> dicPntToWf = new Dictionary<Guid, ArrayList>();

        /// <summary>
        /// 通过工作流ID查询病人ID
        /// </summary>
        /// <param name="guid">工作流ID</param>
        /// <returns>病人ID</returns>
        public Guid? GetPatientFromWorkFlow(Guid guid)
        {
            foreach (KeyValuePair<Guid, ArrayList> pair in dicPntToWf)
            {
                if (pair.Value.Contains(guid))
                    return pair.Key;
            }
            return null;
        }

        /// <summary>
        /// 通过病人ID查询工作流ID
        /// </summary>
        /// <param name="guid">病人ID</param>
        /// <returns>工作流ID</returns>
        public Guid? GetWorkFlowFromPatient(Guid guid, WorkflowType WfType)
        {
            if (dicPntToWf.ContainsKey(guid))
            {
                return (Guid)dicPntToWf[guid][(int)WfType];
            }
            return null;
        }

        /// <summary>
        /// 添加病人ID和工作流ID
        /// </summary>
        /// <param name="guidPatient">病人ID</param>
        /// <param name="guidWfInst">工作流ID</param>
        public void Add(Guid guidPatient, Guid guidWfInst, WorkflowType WfType)
        {
            if (dicPntToWf.ContainsKey(guidPatient))
            {
                dicPntToWf[guidPatient][(int)WfType] = guidWfInst;                
            }
            else
            {
                ArrayList WfList = new ArrayList();

                for (int i = 0; i < (int)WorkflowType.TypeAmount;  WfList.Add(new Guid()),i++);

                WfList[(int)WfType] = guidWfInst;

                dicPntToWf.Add(guidPatient, WfList);
            }
        }

        /// <summary>
        /// 删除病人
        /// </summary>
        /// <param name="guidPatient">病人ID</param>
        public void Remove(Guid guidPatient)
        {
            if (dicPntToWf.ContainsKey(guidPatient))
            {
                dicPntToWf.Remove(guidPatient);
            }
        }

        /// <summary>
        /// 清空病人集合
        /// </summary>
        public void Clear()
        {
            dicPntToWf.Clear();
        }


        public ArrayList getAllPatientStrID()
        {
            ArrayList allPatientStrID = new ArrayList();
            foreach (KeyValuePair<Guid, ArrayList> pair in dicPntToWf)
            {
                allPatientStrID.Add(Convert.ToString(pair.Key));
            }

            return allPatientStrID;
        }
    }
}
