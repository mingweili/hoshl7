using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Workflow.Activities;

namespace Hos.WorkFlow.LocalServices
{
    [ExternalDataExchange]
    public interface IWfLocalServices
	{

        event EventHandler<ChargeCompletedEventArgs> ChargeCompleted;
        event EventHandler<RegisterCompletedEventArgs> RegisterCompleted;
        event EventHandler<MedicalAdviceCompletedEventArgs> MedicalAdviceCompleted;
        event EventHandler<TreatCompletedEventArgs> TreatCompleted;
        event EventHandler<TriageCompletedEventArgs> TriageCompleted;
        event EventHandler<DiagnoseCompletedEventArgs> DiagnoseCompleted;

        void OnSendMessage(String message);

//         void SetPatientState(State state);
//         void InitData();
//         void destruct();
	}
}
