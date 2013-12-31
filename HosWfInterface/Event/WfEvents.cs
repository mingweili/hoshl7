using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using System.Workflow.Activities;
using System.Workflow.ComponentModel;
using System.Workflow.Runtime;

namespace Hos.WorkFlow.LocalServices
{

    /// <summary>
    /// 事件参数的基类，还有当前科室的ID
    /// </summary>
    [Serializable]
    public class BaseEventArgs : ExternalDataEventArgs
    {
        public BaseEventArgs(Guid id) : base(id) { }

        public Guid CurrentDepartmentID { get; set; }
        public Guid NextDepartmentID { get; set; }
    }

    /// <summary>
    /// 挂号完成
    /// </summary>
    [Serializable]
    public class RegisterCompletedEventArgs : BaseEventArgs
    {
        public RegisterCompletedEventArgs(Guid id) : base(id) { }

        /// <summary>
        /// 挂号的科室ID
        /// </summary>
        public Guid DepartmentID { get; set; }

        /// <summary>
        /// 挂号
        /// </summary>
        public string TagNumber { get; set; }

        /// <summary>
        /// 病人名字
        /// </summary>
        public string PatientName { get; set; }
    }

    /// <summary>
    /// 病人的诊断方向
    /// </summary>
    /// <remarks>
    /// 这个用于驱动工作流
    /// </remarks>
    [Serializable]
    public enum DiagnoseDirection
    {
        Examination, Treat, Medicine, Complete, Hospitalization, 
    }

    /// <summary>
    /// 诊断结束
    /// </summary>
    [Serializable]
    public class DiagnoseCompletedEventArgs : BaseEventArgs
    {
        public DiagnoseCompletedEventArgs(Guid id) : base(id) { }

        /// <summary>
        /// 能否在本医院接受治疗
        /// </summary>
        public bool Quit { get; set; }

        /// <summary>
        /// 是否需要换科室
        /// </summary>
        public bool NeedChanged { get; set; }

        /// <summary>
        /// 需要转移到的科室
        /// </summary>
        public Guid OtherDiagnoseDepartment { get; set; }

        /// <summary>
        /// 诊断方向
        /// </summary>
        public DiagnoseDirection NextDirection { get; set; }
    }

    /// <summary>
    /// 检查结束
    /// </summary>
    [Serializable]
    public class ExamineCompletedEventArgs : BaseEventArgs
    {
        public ExamineCompletedEventArgs(Guid id) : base(id) { }

        /// <summary>
        /// 本次检查部门的ID
        /// </summary>
        public Guid DepartmentID { get; set; }
    }

    /// <summary>
    /// 病人的诊断方向
    /// </summary>
    /// <remarks>
    /// 这个用于驱动工作流
    /// </remarks>
    [Serializable]
    public enum CharegeDirection
    {
        REGISTER, MIDICIAN, HOSPITALED, OPERATED, LEAVE, TREAT, MEDICIAN_ADVICE
    }


    /// <summary>
    /// 收费结束
    /// </summary>
    [Serializable]
    public class ChargeCompletedEventArgs : BaseEventArgs
    {
        public ChargeCompletedEventArgs(Guid id) : base(id) { }
        /// <summary>
        /// 诊断方向
        /// </summary>
        public CharegeDirection NextDirection { get; set; }
    }

    /// <summary>
    /// 分诊结束
    /// </summary>
    [Serializable]
    public class TriageCompletedEventArgs : BaseEventArgs
    {
        public TriageCompletedEventArgs(Guid id) : base(id) { }
        ///<summary>
        ///分诊方向，暂时设为string型
        ///</summary>
        public string DepartmentID { set; get; }
    }

    /// <summary>
    /// 拿药结束
    /// </summary>
    [Serializable]
    public class MedicineCompletedEventArgs : BaseEventArgs
    {
        public MedicineCompletedEventArgs(Guid id) : base(id) { }

        /// <summary>
        /// 是否需要接受治疗
        /// </summary>
        public bool NeedTreat { get; set; }
    }

    /// <summary>
    /// 治疗结束
    /// </summary>
    [Serializable]
    public class TreatCompletedEventArgs : BaseEventArgs
    {
        public TreatCompletedEventArgs(Guid id) : base(id) { }

        /// <summary>
        /// 是否需要诊断
        /// </summary>
        public bool NeedDiagnosed { get; set; }
    }


    /// <summary>
    /// 遗嘱结束
    /// </summary>
    [Serializable]
    public class MedicalAdviceCompletedEventArgs : BaseEventArgs
    {
        public MedicalAdviceCompletedEventArgs(Guid id) : base(id) { }

    }






    [Serializable]
    public class MessageReceivedEventArgs : ExternalDataEventArgs
    {
        public String Message { get; set; }

        public MessageReceivedEventArgs(Guid instanceId, String message)
            : base(instanceId)
        {
            Message = message;
        }
    }
}
