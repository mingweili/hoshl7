using System;
using System.Workflow.Activities;
using System.Workflow.Runtime;

namespace Hos.WorkFlow.LocalServices
{
    public class WfLocalServices : IWfLocalServices//, IInvokeChildWf
	{
        public event EventHandler<ChargeCompletedEventArgs> ChargeCompleted;
        public event EventHandler<RegisterCompletedEventArgs> RegisterCompleted;
        public event EventHandler<MedicalAdviceCompletedEventArgs> MedicalAdviceCompleted;
        public event EventHandler<TreatCompletedEventArgs> TreatCompleted;
        public event EventHandler<TriageCompletedEventArgs> TriageCompleted;
        public event EventHandler<DiagnoseCompletedEventArgs> DiagnoseCompleted;

//         #region IInvokeChildWf 成员
// 
//         public event EventHandler<ExternalDataEventArgs> InvokeChildWf;
// 
//         #endregion

        public void OnSendMessage(string message)
        {
            if (MessageReceived != null)
            {
                MessageReceivedEventArgs args
                    = new MessageReceivedEventArgs(WorkflowEnvironment.WorkflowInstanceId, message);

                MessageReceived(this, args);
            }
        }





        public event EventHandler<MessageReceivedEventArgs> MessageReceived;

        public void OnChargeCompleted(ChargeCompletedEventArgs args)
        {
            ChargeCompleted(null, args);
        }

        public void OnRegisterCompleted(RegisterCompletedEventArgs args)
        {
            RegisterCompleted(null, args);
        }

        public void OnMedicalAdviceCompleted(MedicalAdviceCompletedEventArgs args)
        {
            MedicalAdviceCompleted(null, args);
        }

        public void OnTreatCompleted(TreatCompletedEventArgs args)
        {
            TreatCompleted(null, args);
        }

        public void OnTriageCompleted(TriageCompletedEventArgs args)
        {
            TriageCompleted(null, args);
        }

        public void OnDiagnoseCompleted(DiagnoseCompletedEventArgs args)
        {
            DiagnoseCompleted(null, args);
        }

//         public void OnInvokeChildWf(ExternalDataEventArgs args)
//         {
//             InvokeChildWf(null, args);
//         }
    }
}
