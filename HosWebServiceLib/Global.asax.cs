using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Security;
using System.Web.SessionState;
using System.Web.Configuration;

using System.Workflow.Activities;
using System.Workflow.ComponentModel;
using System.Workflow.Runtime;
using System.Workflow.Runtime.Hosting;
using System.IO;


using Hos.WorkFlow.LocalServices;

namespace Hos.WebService
{
    public class Global : System.Web.HttpApplication
    {
        public static WorkflowRuntime wfRuntime;
        private static ExternalDataExchangeService externalDataExchangeService;
        public static WfLocalServices wfLocalServices;
        private static WorkflowPersistenceService persistenceService;

        //public static WorkflowInstance wfInstantce;

        public static PatientCollection patientCollection = new PatientCollection();

        static Global()
        {
            //实例化工作流运行时
            wfRuntime = new WorkflowRuntime();

            externalDataExchangeService = new ExternalDataExchangeService();

            //添加事件驱动服务
            externalDataExchangeService = new ExternalDataExchangeService();
            wfRuntime.AddService(externalDataExchangeService);

            //添加事件驱动本地服务
            wfLocalServices = new WfLocalServices();
            externalDataExchangeService.AddService(wfLocalServices);

            //添加持久化服务
            string ConnDBString = "Data Source=172.29.132.248;Initial Catalog=WfPersistenceDBTest;Persist Security Info=True;User ID=werun;Password=werun";
            persistenceService = new SqlWorkflowPersistenceService(ConnDBString);
            wfRuntime.AddService(persistenceService);

            wfRuntime.ServicesExceptionNotHandled += new EventHandler<ServicesExceptionNotHandledEventArgs>(wfRuntime_OnServicesExceptionNotHandled);
        }


        private static void wfRuntime_OnServicesExceptionNotHandled(object sender, ServicesExceptionNotHandledEventArgs e)
        {
            File.AppendAllText(@"D:\Log.txt", e.Exception.Message + e.Exception.Source + e.Exception.StackTrace);
        }


        protected void Application_Start(object sender, EventArgs e)
        {

            //运行工作流运行时
            wfRuntime.StartRuntime();
        }

        protected void Session_Start(object sender, EventArgs e)
        {

        }

        protected void Application_BeginRequest(object sender, EventArgs e)
        {

        }

        protected void Application_AuthenticateRequest(object sender, EventArgs e)
        {

        }

        protected void Application_Error(object sender, EventArgs e)
        {

        }

        protected void Session_End(object sender, EventArgs e)
        {

        }

        protected void Application_End(object sender, EventArgs e)
        {
            wfRuntime.StopRuntime();
        }


    }
}