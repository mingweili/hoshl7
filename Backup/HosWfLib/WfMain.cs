using System;
using System.ComponentModel;
using System.ComponentModel.Design;
using System.Collections;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Workflow.ComponentModel.Compiler;
using System.Workflow.ComponentModel.Serialization;
using System.Workflow.ComponentModel;
using System.Workflow.ComponentModel.Design;
using System.Workflow.Runtime;
using System.Workflow.Activities;
using System.Workflow.Activities.Rules;
using Hos.WorkFlow.LocalServices;



namespace Hos.WorkFlow
{
    public sealed partial class WfMain : StateMachineWorkflowActivity
    {
        //private PatientState patientState;
        public string patientStrID { get; set; }

        //public Guid WfID { get; set; }

        public State state { get; set; }

        private CharegeDirection chargeDirection;



        public WfMain()
        {
            InitializeComponent();
        }

        private void 处理挂号收费完成_Invoked(object sender, ExternalDataEventArgs e)
        {
            Console.WriteLine("收费完成。");
        }

        private void 处理就诊完成_Invoked(object sender, ExternalDataEventArgs e)
        {
            Console.WriteLine("就诊完成。");
        }

        private void 拿药分支_ExecuteCode(object sender, EventArgs e)
        {
            Console.WriteLine("拿药完成。");
        }

        private void IfHospitaledCondition(object sender, ConditionalEventArgs e)
        {
            e.Result = (chargeDirection == CharegeDirection.HOSPITALED);
        }

        private void 处理收费完成_Invoked(object sender, ExternalDataEventArgs e)
        {
            Console.WriteLine("收费已完成。");
            chargeDirection = ((ChargeCompletedEventArgs)e).NextDirection;
        }

        private void IfChargedCondition(object sender, ConditionalEventArgs e)
        {
            e.Result = (eventChargeCompletedArgs.NextDirection == CharegeDirection.MIDICIAN);
        }

        private void IfOperatedCondition(object sender, ConditionalEventArgs e)
        {
            e.Result = (chargeDirection == CharegeDirection.OPERATED);
        }

        //绑定收费完成事件
        public ChargeCompletedEventArgs eventChargeCompletedArgs = default(ChargeCompletedEventArgs);

        //绑定挂号完成事件
        public RegisterCompletedEventArgs eventRegisterCompletedArgs = default(RegisterCompletedEventArgs);

        //绑定医嘱状态完成
        public MedicalAdviceCompletedEventArgs eventMedicalAdiceArgs = default(MedicalAdviceCompletedEventArgs);

        private void 处理就诊完成_ExecuteCode(object sender, EventArgs e)
        {
            Console.WriteLine("已进入就诊状态");

            //             //生成一个子工作流，生成就诊子工作流
            //             Dictionary<String, Object> wfArguments
            //                 = new Dictionary<String, Object>();
            //             wfArguments.Add("PatientID", patientGuidID);
            //             WorkflowInstance diagnoseWf = Global.wfRuntime.CreateWorkflow(typeof(DiagnoseWf));
            //             diagnoseWf.Start();
            // 
            //             //将新加的工作流加入到patientCollection中
            //             Guid? PatientID = Global.patientCollection.GetPatientFromWorkFlow(this.WorkflowInstanceId);
            //             Global.patientCollection.Add(PatientID.Value, diagnoseWf.InstanceId, WorkflowType.DIAGNOSE_CHILD);

            //触发子工作流，让其正常运行
            //Global.wfLocalServices.OnInvokeChildWf(new ExternalDataEventArgs(diagnoseWf.InstanceId));
        }

        private void 处理挂号完成_Invoked(object sender, ExternalDataEventArgs e)
        {
            Console.WriteLine("挂号完成。");
        }

        private void 处理开医嘱完成_Invoked(object sender, ExternalDataEventArgs e)
        {
            Console.WriteLine("开医嘱完成。");
        }

        private void IfLeaveHospital(object sender, ConditionalEventArgs e)
        {
            e.Result = true;//(eventMedicalOrder.TheState == State.LEAVE);
        }

        private void IfNotLeaveHospital(object sender, ConditionalEventArgs e)
        {
            e.Result = false;// (eventMedicalOrder.TheState != State.LEAVE);
        }

        private void 处理就诊完成_Invoked_1(object sender, ExternalDataEventArgs e)
        {
            Console.WriteLine("就诊已完成。");
        }

        private void 工作流析构处理_ExecuteCode(object sender, EventArgs e)
        {
            Console.WriteLine("工作流完成。已离开医院。");
        }

        private void 初始化代码_ExecuteCode(object sender, EventArgs e)
        {
            state = State.REGISTER;
            Console.WriteLine("挂号初始化");
        }

        public static DependencyProperty 设置病人状态_MethodInvoking1Event = DependencyProperty.Register("设置病人状态_MethodInvoking1", typeof(System.EventHandler), typeof(Hos.WorkFlow.WfMain));

        [DesignerSerializationVisibilityAttribute(DesignerSerializationVisibility.Visible)]
        [BrowsableAttribute(true)]
        [CategoryAttribute("处理程序")]
        public event EventHandler 设置病人状态_MethodInvoking1
        {
            add
            {
                base.AddHandler(设置病人状态_MethodInvoking1Event, value);
            }
            remove
            {
                base.RemoveHandler(设置病人状态_MethodInvoking1Event, value);
            }
        }

        public static DependencyProperty 设置病人状态_state1Property = DependencyProperty.Register("设置病人状态_state1", typeof(State), typeof(Hos.WorkFlow.WfMain));

        [DesignerSerializationVisibilityAttribute(DesignerSerializationVisibility.Visible)]
        [BrowsableAttribute(true)]
        [CategoryAttribute("参数")]
        public State 设置病人状态_state1
        {
            get
            {
                return ((State)(base.GetValue(Hos.WorkFlow.WfMain.设置病人状态_state1Property)));
            }
            set
            {
                base.SetValue(Hos.WorkFlow.WfMain.设置病人状态_state1Property, value);
            }
        }

        public static DependencyProperty 设置病人的状态_MethodInvoking1Event = DependencyProperty.Register("设置病人的状态_MethodInvoking1", typeof(System.EventHandler), typeof(Hos.WorkFlow.WfMain));

        [DesignerSerializationVisibilityAttribute(DesignerSerializationVisibility.Visible)]
        [BrowsableAttribute(true)]
        [CategoryAttribute("处理程序")]
        public event EventHandler 设置病人的状态_MethodInvoking1
        {
            add
            {
                base.AddHandler(设置病人的状态_MethodInvoking1Event, value);
            }
            remove
            {
                base.RemoveHandler(设置病人的状态_MethodInvoking1Event, value);
            }
        }

        public static DependencyProperty 设置病人的状态_state1Property = DependencyProperty.Register("设置病人的状态_state1", typeof(State), typeof(Hos.WorkFlow.WfMain));

        [DesignerSerializationVisibilityAttribute(DesignerSerializationVisibility.Visible)]
        [BrowsableAttribute(true)]
        [CategoryAttribute("参数")]
        public State 设置病人的状态_state1
        {
            get
            {
                return ((State)(base.GetValue(Hos.WorkFlow.WfMain.设置病人的状态_state1Property)));
            }
            set
            {
                base.SetValue(Hos.WorkFlow.WfMain.设置病人的状态_state1Property, value);
            }
        }

        private void 处理初始化_ExecuteCode(object sender, EventArgs e)
        {
            Console.WriteLine("收费状态");
        }

        public static DependencyProperty 调用宿主程序设置病人状态_MethodInvoking1Event = DependencyProperty.Register("调用宿主程序设置病人状态_MethodInvoking1", typeof(System.EventHandler), typeof(Hos.WorkFlow.WfMain));

        [DesignerSerializationVisibilityAttribute(DesignerSerializationVisibility.Visible)]
        [BrowsableAttribute(true)]
        [CategoryAttribute("处理程序")]
        public event EventHandler 调用宿主程序设置病人状态_MethodInvoking1
        {
            add
            {
                base.AddHandler(调用宿主程序设置病人状态_MethodInvoking1Event, value);
            }
            remove
            {
                base.RemoveHandler(调用宿主程序设置病人状态_MethodInvoking1Event, value);
            }
        }

        public static DependencyProperty 调用宿主程序设置病人状态_state1Property = DependencyProperty.Register("调用宿主程序设置病人状态_state1", typeof(State), typeof(Hos.WorkFlow.WfMain));

        [DesignerSerializationVisibilityAttribute(DesignerSerializationVisibility.Visible)]
        [BrowsableAttribute(true)]
        [CategoryAttribute("参数")]
        public State 调用宿主程序设置病人状态_state1
        {
            get
            {
                return ((State)(base.GetValue(Hos.WorkFlow.WfMain.调用宿主程序设置病人状态_state1Property)));
            }
            set
            {
                base.SetValue(Hos.WorkFlow.WfMain.调用宿主程序设置病人状态_state1Property, value);
            }
        }

        private void 初始化_ExecuteCode(object sender, EventArgs e)
        {
            Console.WriteLine("已进入医嘱状态。");
        }

        public static DependencyProperty 调用宿主设置病人状态_MethodInvoking1Event = DependencyProperty.Register("调用宿主设置病人状态_MethodInvoking1", typeof(System.EventHandler), typeof(Hos.WorkFlow.WfMain));

        [DesignerSerializationVisibilityAttribute(DesignerSerializationVisibility.Visible)]
        [BrowsableAttribute(true)]
        [CategoryAttribute("处理程序")]
        public event EventHandler 调用宿主设置病人状态_MethodInvoking1
        {
            add
            {
                base.AddHandler(调用宿主设置病人状态_MethodInvoking1Event, value);
            }
            remove
            {
                base.RemoveHandler(调用宿主设置病人状态_MethodInvoking1Event, value);
            }
        }

        public static DependencyProperty 调用宿主设置病人状态_state1Property = DependencyProperty.Register("调用宿主设置病人状态_state1", typeof(State), typeof(Hos.WorkFlow.WfMain));

        [DesignerSerializationVisibilityAttribute(DesignerSerializationVisibility.Visible)]
        [BrowsableAttribute(true)]
        [CategoryAttribute("参数")]
        public State 调用宿主设置病人状态_state1
        {
            get
            {
                return ((State)(base.GetValue(Hos.WorkFlow.WfMain.调用宿主设置病人状态_state1Property)));
            }
            set
            {
                base.SetValue(Hos.WorkFlow.WfMain.调用宿主设置病人状态_state1Property, value);
            }
        }

        private void 设置病人状态_MethodInvoking(object sender, EventArgs e)
        {

        }

        private void IfMedicineCondition(object sender, ConditionalEventArgs e)
        {
            e.Result = (chargeDirection == CharegeDirection.MIDICIAN);
        }

        private void IfRegisterCondition(object sender, ConditionalEventArgs e)
        {
            e.Result = (chargeDirection == CharegeDirection.REGISTER);
        }

        private void 进入挂号状态_ExecuteCode(object sender, EventArgs e)
        {
            Console.WriteLine("已进入挂号状态。");
        }

        private void codeActivity6_ExecuteCode(object sender, EventArgs e)
        {
            Console.WriteLine("跳转到离开医院1。");
        }

        private void codeActivity7_ExecuteCode(object sender, EventArgs e)
        {
            Console.WriteLine("跳转到离开医院2。");
        }

        private void codeActivity8_ExecuteCode(object sender, EventArgs e)
        {
            Console.WriteLine("离开医院");
        }

        public static DependencyProperty diagnoseCompletedArgsProperty = DependencyProperty.Register("diagnoseCompletedArgs", typeof(Hos.WorkFlow.LocalServices.DiagnoseCompletedEventArgs), typeof(Hos.WorkFlow.WfMain));

        [DesignerSerializationVisibilityAttribute(DesignerSerializationVisibility.Visible)]
        [BrowsableAttribute(true)]
        [CategoryAttribute("参数")]
        public DiagnoseCompletedEventArgs diagnoseCompletedArgs
        {
            get
            {
                return ((Hos.WorkFlow.LocalServices.DiagnoseCompletedEventArgs)(base.GetValue(Hos.WorkFlow.WfMain.diagnoseCompletedArgsProperty)));
            }
            set
            {
                base.SetValue(Hos.WorkFlow.WfMain.diagnoseCompletedArgsProperty, value);
            }
        }

        private void 发送消息_ExecuteCode(object sender, EventArgs e)
        {

        }

    }

}
