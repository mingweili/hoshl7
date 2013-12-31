using System;
using System.ComponentModel;
using System.Workflow.ComponentModel;
using System.Workflow.Activities;
using Hos.WorkFlow.LocalServices;
using Hos.WebService;

namespace Hos.WorkFlow
{
    public sealed partial class WfTreat : StateMachineWorkflowActivity
    {
        public TriageCompletedEventArgs triageCompletedEventArgs = default(TriageCompletedEventArgs);
        public DiagnoseCompletedEventArgs diagnoseCompletedEventArgs = default(DiagnoseCompletedEventArgs);
        public DiagnoseDirection Direction { set; get; }

        public string patientStrID { get; set; }

        public WfTreat()
        {
            InitializeComponent();
        }

        public static DependencyProperty 接收就诊结果_sender1Property = DependencyProperty.Register("接收就诊结果_sender1", typeof(System.Object), typeof(Hos.WorkFlow.WfTreat));

        [DesignerSerializationVisibilityAttribute(DesignerSerializationVisibility.Visible)]
        [BrowsableAttribute(true)]
        [CategoryAttribute("参数")]
        public Object 接收就诊结果_sender1
        {
            get
            {
                return ((object)(base.GetValue(Hos.WorkFlow.WfTreat.接收就诊结果_sender1Property)));
            }
            set
            {
                base.SetValue(Hos.WorkFlow.WfTreat.接收就诊结果_sender1Property, value);
            }
        }

        public static DependencyProperty 接收就诊结果_Roles1Property = DependencyProperty.Register("接收就诊结果_Roles1", typeof(System.Workflow.Activities.WorkflowRoleCollection), typeof(Hos.WorkFlow.WfTreat));

        [DesignerSerializationVisibilityAttribute(DesignerSerializationVisibility.Visible)]
        [BrowsableAttribute(true)]
        [CategoryAttribute("活动")]
        public WorkflowRoleCollection 接收就诊结果_Roles1
        {
            get
            {
                return ((System.Workflow.Activities.WorkflowRoleCollection)(base.GetValue(Hos.WorkFlow.WfTreat.接收就诊结果_Roles1Property)));
            }
            set
            {
                base.SetValue(Hos.WorkFlow.WfTreat.接收就诊结果_Roles1Property, value);
            }
        }

        public static DependencyProperty 接收就诊结果_Invoked1Event = DependencyProperty.Register("接收就诊结果_Invoked1", typeof(System.EventHandler<System.Workflow.Activities.ExternalDataEventArgs>), typeof(Hos.WorkFlow.WfTreat));

        [DesignerSerializationVisibilityAttribute(DesignerSerializationVisibility.Visible)]
        [BrowsableAttribute(true)]
        [CategoryAttribute("处理程序")]
        public event EventHandler<ExternalDataEventArgs> 接收就诊结果_Invoked1
        {
            add
            {
                base.AddHandler(接收就诊结果_Invoked1Event, value);
            }
            remove
            {
                base.RemoveHandler(接收就诊结果_Invoked1Event, value);
            }
        }

        private void 通知转到检查状态_ExecuteCode(object sender, EventArgs e)
        {
            Direction = DiagnoseDirection.Examination;
        }

        private void 通知主工作流就诊结束_ExecuteCode(object sender, EventArgs e)
        {
            //             Guid? ParentWfID =
            //                 Global.patientCollection.GetWorkFlowFromPatient(patientGuidID, WorkflowType.PARENT);
            //             if (ParentWfID.HasValue)
            //             {
            //                 TreatCompletedEventArgs args = new TreatCompletedEventArgs(ParentWfID.Value);
            //                 args.WaitForIdle = true;
            // 
            //                 Global.wfLocalServices.OnTreatCompleted(args);
            //             }
        }

        private void 接收就诊结果_Invoked(object sender, ExternalDataEventArgs e)
        {

        }

        private void 让主工作流跳转_Invoking(object sender, InvokeWebServiceEventArgs e)
        {
            Direction = this.diagnoseCompletedEventArgs.NextDirection;
        }

        private void 通知主工作流结束_ExecuteCode(object sender, EventArgs e)
        {
            //暂时向主工作流直接发送
            DiagnoseCompletedEventArgs args = new DiagnoseCompletedEventArgs(this.WorkflowInstanceId);
            args.NextDirection = Direction;
            args.NeedChanged = false;
            args.WaitForIdle = true;
            Global.wfLocalServices.OnDiagnoseCompleted(args);
        }

        private void 转到住院_ExecuteCode(object sender, EventArgs e)
        {
            Direction = DiagnoseDirection.Hospitalization;
        }

        private void 无需住院_ExecuteCode(object sender, EventArgs e)
        {
            Direction = DiagnoseDirection.Complete;
        }


    }

}
