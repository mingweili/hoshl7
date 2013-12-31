using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Workflow.Activities;

public enum State { REGISTER, MIDICIAN, HOSPITALED, OPERATED, LEAVE, TREAT, MEDICIAN_ORDER};

namespace Hos.WorkFlow
{
    [Serializable]
    public class PatientState : ExternalDataEventArgs
	{
        public PatientState(Guid id) : base(id) { }
        public State TheState{set; get;}
	}
}
