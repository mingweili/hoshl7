using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Workflow.Runtime;
using System.Workflow.Activities;
using System.Workflow.Runtime.Hosting;

using Hos.WorkFlow;
using Hos.WorkFlow.LocalServices;

namespace PatientWfTestForm
{
    public partial class Form1 : Form
    {
        private WorkflowRuntime wfRuntime = null;
        private WorkflowInstance wfInstantce = null;
        private ExternalDataExchangeService dataExchangeService = null;
        private WorkflowPersistenceService persistenceService = null;

        private WfLocalServices wfLocalServices = null;
        public Form1()
        {
            InitializeComponent();
            
            //实例化工作流运行时
            wfRuntime = new WorkflowRuntime();

            //添加事件驱动服务
            dataExchangeService = new ExternalDataExchangeService();
            wfRuntime.AddService(dataExchangeService);

            //添加事件驱动本地服务
            wfLocalServices = new WfLocalServices();
            dataExchangeService.AddService(wfLocalServices);

            //添加持久化服务
            string ConnDBString = "Data Source=172.29.132.248;Initial Catalog=WfPersistenceDBTest;Persist Security Info=True;User ID=werun;Password=werun";
            persistenceService = new SqlWorkflowPersistenceService(ConnDBString);
            wfRuntime.AddService(persistenceService);

            //运行工作流运行时
            wfRuntime.StartRuntime();
        }

        //开启工作流
        private void button1_Click(object sender, EventArgs e)
        {
            wfInstantce = wfRuntime.CreateWorkflow(typeof(Hos.WorkFlow.WfMain));
            wfInstantce.Start();
        }

        //收费完成
        private void button2_Click(object sender, EventArgs e)
        {
            ChargeCompletedEventArgs args = new ChargeCompletedEventArgs(wfInstantce.InstanceId);
            args.NextDirection = CharegeDirection.REGISTER;
            args.WaitForIdle = true;

            wfLocalServices.OnChargeCompleted(args);
        }


        //挂号完成
        private void button3_Click(object sender, EventArgs e)
        {
            RegisterCompletedEventArgs args = new RegisterCompletedEventArgs(wfInstantce.InstanceId);
            args.WaitForIdle = true;

            wfLocalServices.OnRegisterCompleted(args);
        }

        //治疗完成
        private void button4_Click(object sender, EventArgs e)
        {
            TreatCompletedEventArgs args = new TreatCompletedEventArgs(wfInstantce.InstanceId);
            args.WaitForIdle = true;

            wfLocalServices.OnTreatCompleted(args);
        }

        //医嘱完成
        private void button5_Click(object sender, EventArgs e)
        {
            MedicalAdviceCompletedEventArgs args = new MedicalAdviceCompletedEventArgs(wfInstantce.InstanceId);

            args.WaitForIdle = true;
            wfLocalServices.OnMedicalAdviceCompleted(args);
        }
    }
}
