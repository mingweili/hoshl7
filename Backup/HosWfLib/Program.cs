using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Workflow.Runtime;
using System.Workflow.Runtime.Hosting;
using System.Workflow.Activities;

using Hos.WorkFlow.LocalServices;

namespace Hos.WorkFlow
{
    class Program
    {
        static void Main(string[] args)
        {
            using(WorkflowRuntime workflowRuntime = new WorkflowRuntime())
            {
                AutoResetEvent waitHandle = new AutoResetEvent(false);

//                 workflowRuntime.WorkflowCompleted += delegate(object sender, WorkflowCompletedEventArgs e) {waitHandle.Set();};
//                 workflowRuntime.WorkflowTerminated += delegate(object sender, WorkflowTerminatedEventArgs e)
//                 {
//                     Console.WriteLine(e.Exception.Message);
//                     waitHandle.Set();
//                 };

                WorkflowInstance instance = workflowRuntime.CreateWorkflow(typeof(Hos.WorkFlow.WfMain));

                ExternalDataExchangeService externalDataExchangeService
                = new ExternalDataExchangeService();

                workflowRuntime.AddService(externalDataExchangeService);

                WfLocalServices wfLocalServices = new WfLocalServices();

                externalDataExchangeService.AddService(wfLocalServices);

                instance.Start();

                //StateMachineWorkflowInstance inst = new StateMachineWorkflowInstance(workflowRuntime, instance.InstanceId);
                //Thread.Sleep(5000);


                //Console.Write(inst.CurrentStateName);

                ChargeCompletedEventArgs argsCharge = new ChargeCompletedEventArgs(instance.InstanceId);
                argsCharge.WaitForIdle = true;

                argsCharge.NextDirection = CharegeDirection.MIDICIAN;


                wfLocalServices.OnChargeCompleted(argsCharge);

                waitHandle.WaitOne();

            }
        }
    }
}
