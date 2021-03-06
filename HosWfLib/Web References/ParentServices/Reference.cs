﻿//------------------------------------------------------------------------------
// <auto-generated>
//     此代码由工具生成。
//     运行时版本:4.0.30319.1
//
//     对此文件的更改可能会导致不正确的行为，并且如果
//     重新生成代码，这些更改将会丢失。
// </auto-generated>
//------------------------------------------------------------------------------

// 
// 此源代码是由 Microsoft.VSDesigner 4.0.30319.1 版自动生成。
// 
#pragma warning disable 1591

namespace Hos.WorkFlow.ParentServices {
    using System;
    using System.Web.Services;
    using System.Diagnostics;
    using System.Web.Services.Protocols;
    using System.ComponentModel;
    using System.Xml.Serialization;
    
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.0.30319.1")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Web.Services.WebServiceBindingAttribute(Name="Service1Soap", Namespace="http://hl7.org/")]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(object[]))]
    public partial class Service1 : System.Web.Services.Protocols.SoapHttpClientProtocol {
        
        private System.Threading.SendOrPostCallback getAllPatientIDOperationCompleted;
        
        private System.Threading.SendOrPostCallback startMainWfOperationCompleted;
        
        private System.Threading.SendOrPostCallback OnChargeCompletedOperationCompleted;
        
        private System.Threading.SendOrPostCallback OnRegisterCompletedOperationCompleted;
        
        private System.Threading.SendOrPostCallback OnDiagnoseCompletedOperationCompleted;
        
        private System.Threading.SendOrPostCallback OnMedicalAdviceCompletedOperationCompleted;
        
        private bool useDefaultCredentialsSetExplicitly;
        
        /// <remarks/>
        public Service1() {
            this.Url = global::Hos.WorkFlow.Properties.Settings.Default.HosWfLib_ParentServices_Service1;
            if ((this.IsLocalFileSystemWebService(this.Url) == true)) {
                this.UseDefaultCredentials = true;
                this.useDefaultCredentialsSetExplicitly = false;
            }
            else {
                this.useDefaultCredentialsSetExplicitly = true;
            }
        }
        
        public new string Url {
            get {
                return base.Url;
            }
            set {
                if ((((this.IsLocalFileSystemWebService(base.Url) == true) 
                            && (this.useDefaultCredentialsSetExplicitly == false)) 
                            && (this.IsLocalFileSystemWebService(value) == false))) {
                    base.UseDefaultCredentials = false;
                }
                base.Url = value;
            }
        }
        
        public new bool UseDefaultCredentials {
            get {
                return base.UseDefaultCredentials;
            }
            set {
                base.UseDefaultCredentials = value;
                this.useDefaultCredentialsSetExplicitly = true;
            }
        }
        
        /// <remarks/>
        public event getAllPatientIDCompletedEventHandler getAllPatientIDCompleted;
        
        /// <remarks/>
        public event startMainWfCompletedEventHandler startMainWfCompleted;
        
        /// <remarks/>
        public event OnChargeCompletedCompletedEventHandler OnChargeCompletedCompleted;
        
        /// <remarks/>
        public event OnRegisterCompletedCompletedEventHandler OnRegisterCompletedCompleted;
        
        /// <remarks/>
        public event OnDiagnoseCompletedCompletedEventHandler OnDiagnoseCompletedCompleted;
        
        /// <remarks/>
        public event OnMedicalAdviceCompletedCompletedEventHandler OnMedicalAdviceCompletedCompleted;
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://hl7.org/getAllPatientID", RequestNamespace="http://hl7.org/", ResponseNamespace="http://hl7.org/", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        public object[] getAllPatientID() {
            object[] results = this.Invoke("getAllPatientID", new object[0]);
            return ((object[])(results[0]));
        }
        
        /// <remarks/>
        public void getAllPatientIDAsync() {
            this.getAllPatientIDAsync(null);
        }
        
        /// <remarks/>
        public void getAllPatientIDAsync(object userState) {
            if ((this.getAllPatientIDOperationCompleted == null)) {
                this.getAllPatientIDOperationCompleted = new System.Threading.SendOrPostCallback(this.OngetAllPatientIDOperationCompleted);
            }
            this.InvokeAsync("getAllPatientID", new object[0], this.getAllPatientIDOperationCompleted, userState);
        }
        
        private void OngetAllPatientIDOperationCompleted(object arg) {
            if ((this.getAllPatientIDCompleted != null)) {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.getAllPatientIDCompleted(this, new getAllPatientIDCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://hl7.org/startMainWf", RequestNamespace="http://hl7.org/", ResponseNamespace="http://hl7.org/", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        public string startMainWf() {
            object[] results = this.Invoke("startMainWf", new object[0]);
            return ((string)(results[0]));
        }
        
        /// <remarks/>
        public void startMainWfAsync() {
            this.startMainWfAsync(null);
        }
        
        /// <remarks/>
        public void startMainWfAsync(object userState) {
            if ((this.startMainWfOperationCompleted == null)) {
                this.startMainWfOperationCompleted = new System.Threading.SendOrPostCallback(this.OnstartMainWfOperationCompleted);
            }
            this.InvokeAsync("startMainWf", new object[0], this.startMainWfOperationCompleted, userState);
        }
        
        private void OnstartMainWfOperationCompleted(object arg) {
            if ((this.startMainWfCompleted != null)) {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.startMainWfCompleted(this, new startMainWfCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://hl7.org/OnChargeCompleted", RequestNamespace="http://hl7.org/", ResponseNamespace="http://hl7.org/", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        public string OnChargeCompleted(string patientStrID) {
            object[] results = this.Invoke("OnChargeCompleted", new object[] {
                        patientStrID});
            return ((string)(results[0]));
        }
        
        /// <remarks/>
        public void OnChargeCompletedAsync(string patientStrID) {
            this.OnChargeCompletedAsync(patientStrID, null);
        }
        
        /// <remarks/>
        public void OnChargeCompletedAsync(string patientStrID, object userState) {
            if ((this.OnChargeCompletedOperationCompleted == null)) {
                this.OnChargeCompletedOperationCompleted = new System.Threading.SendOrPostCallback(this.OnOnChargeCompletedOperationCompleted);
            }
            this.InvokeAsync("OnChargeCompleted", new object[] {
                        patientStrID}, this.OnChargeCompletedOperationCompleted, userState);
        }
        
        private void OnOnChargeCompletedOperationCompleted(object arg) {
            if ((this.OnChargeCompletedCompleted != null)) {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.OnChargeCompletedCompleted(this, new OnChargeCompletedCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://hl7.org/OnRegisterCompleted", RequestNamespace="http://hl7.org/", ResponseNamespace="http://hl7.org/", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        public string OnRegisterCompleted(string patientStrID) {
            object[] results = this.Invoke("OnRegisterCompleted", new object[] {
                        patientStrID});
            return ((string)(results[0]));
        }
        
        /// <remarks/>
        public void OnRegisterCompletedAsync(string patientStrID) {
            this.OnRegisterCompletedAsync(patientStrID, null);
        }
        
        /// <remarks/>
        public void OnRegisterCompletedAsync(string patientStrID, object userState) {
            if ((this.OnRegisterCompletedOperationCompleted == null)) {
                this.OnRegisterCompletedOperationCompleted = new System.Threading.SendOrPostCallback(this.OnOnRegisterCompletedOperationCompleted);
            }
            this.InvokeAsync("OnRegisterCompleted", new object[] {
                        patientStrID}, this.OnRegisterCompletedOperationCompleted, userState);
        }
        
        private void OnOnRegisterCompletedOperationCompleted(object arg) {
            if ((this.OnRegisterCompletedCompleted != null)) {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.OnRegisterCompletedCompleted(this, new OnRegisterCompletedCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://hl7.org/OnDiagnoseCompleted", RequestNamespace="http://hl7.org/", ResponseNamespace="http://hl7.org/", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        public string OnDiagnoseCompleted(string patientStrID, DiagnoseDirection direction) {
            object[] results = this.Invoke("OnDiagnoseCompleted", new object[] {
                        patientStrID,
                        direction});
            return ((string)(results[0]));
        }
        
        /// <remarks/>
        public void OnDiagnoseCompletedAsync(string patientStrID, DiagnoseDirection direction) {
            this.OnDiagnoseCompletedAsync(patientStrID, direction, null);
        }
        
        /// <remarks/>
        public void OnDiagnoseCompletedAsync(string patientStrID, DiagnoseDirection direction, object userState) {
            if ((this.OnDiagnoseCompletedOperationCompleted == null)) {
                this.OnDiagnoseCompletedOperationCompleted = new System.Threading.SendOrPostCallback(this.OnOnDiagnoseCompletedOperationCompleted);
            }
            this.InvokeAsync("OnDiagnoseCompleted", new object[] {
                        patientStrID,
                        direction}, this.OnDiagnoseCompletedOperationCompleted, userState);
        }
        
        private void OnOnDiagnoseCompletedOperationCompleted(object arg) {
            if ((this.OnDiagnoseCompletedCompleted != null)) {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.OnDiagnoseCompletedCompleted(this, new OnDiagnoseCompletedCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://hl7.org/OnMedicalAdviceCompleted", RequestNamespace="http://hl7.org/", ResponseNamespace="http://hl7.org/", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        public string OnMedicalAdviceCompleted(string patientStrID) {
            object[] results = this.Invoke("OnMedicalAdviceCompleted", new object[] {
                        patientStrID});
            return ((string)(results[0]));
        }
        
        /// <remarks/>
        public void OnMedicalAdviceCompletedAsync(string patientStrID) {
            this.OnMedicalAdviceCompletedAsync(patientStrID, null);
        }
        
        /// <remarks/>
        public void OnMedicalAdviceCompletedAsync(string patientStrID, object userState) {
            if ((this.OnMedicalAdviceCompletedOperationCompleted == null)) {
                this.OnMedicalAdviceCompletedOperationCompleted = new System.Threading.SendOrPostCallback(this.OnOnMedicalAdviceCompletedOperationCompleted);
            }
            this.InvokeAsync("OnMedicalAdviceCompleted", new object[] {
                        patientStrID}, this.OnMedicalAdviceCompletedOperationCompleted, userState);
        }
        
        private void OnOnMedicalAdviceCompletedOperationCompleted(object arg) {
            if ((this.OnMedicalAdviceCompletedCompleted != null)) {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.OnMedicalAdviceCompletedCompleted(this, new OnMedicalAdviceCompletedCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }
        
        /// <remarks/>
        public new void CancelAsync(object userState) {
            base.CancelAsync(userState);
        }
        
        private bool IsLocalFileSystemWebService(string url) {
            if (((url == null) 
                        || (url == string.Empty))) {
                return false;
            }
            System.Uri wsUri = new System.Uri(url);
            if (((wsUri.Port >= 1024) 
                        && (string.Compare(wsUri.Host, "localHost", System.StringComparison.OrdinalIgnoreCase) == 0))) {
                return true;
            }
            return false;
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.1")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://hl7.org/")]
    public enum DiagnoseDirection {
        
        /// <remarks/>
        Examination,
        
        /// <remarks/>
        Treat,
        
        /// <remarks/>
        Medicine,
        
        /// <remarks/>
        Complete,
        
        /// <remarks/>
        Hospitalization,
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.0.30319.1")]
    public delegate void getAllPatientIDCompletedEventHandler(object sender, getAllPatientIDCompletedEventArgs e);
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.0.30319.1")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class getAllPatientIDCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
        
        private object[] results;
        
        internal getAllPatientIDCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
                base(exception, cancelled, userState) {
            this.results = results;
        }
        
        /// <remarks/>
        public object[] Result {
            get {
                this.RaiseExceptionIfNecessary();
                return ((object[])(this.results[0]));
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.0.30319.1")]
    public delegate void startMainWfCompletedEventHandler(object sender, startMainWfCompletedEventArgs e);
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.0.30319.1")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class startMainWfCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
        
        private object[] results;
        
        internal startMainWfCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
                base(exception, cancelled, userState) {
            this.results = results;
        }
        
        /// <remarks/>
        public string Result {
            get {
                this.RaiseExceptionIfNecessary();
                return ((string)(this.results[0]));
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.0.30319.1")]
    public delegate void OnChargeCompletedCompletedEventHandler(object sender, OnChargeCompletedCompletedEventArgs e);
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.0.30319.1")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class OnChargeCompletedCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
        
        private object[] results;
        
        internal OnChargeCompletedCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
                base(exception, cancelled, userState) {
            this.results = results;
        }
        
        /// <remarks/>
        public string Result {
            get {
                this.RaiseExceptionIfNecessary();
                return ((string)(this.results[0]));
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.0.30319.1")]
    public delegate void OnRegisterCompletedCompletedEventHandler(object sender, OnRegisterCompletedCompletedEventArgs e);
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.0.30319.1")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class OnRegisterCompletedCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
        
        private object[] results;
        
        internal OnRegisterCompletedCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
                base(exception, cancelled, userState) {
            this.results = results;
        }
        
        /// <remarks/>
        public string Result {
            get {
                this.RaiseExceptionIfNecessary();
                return ((string)(this.results[0]));
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.0.30319.1")]
    public delegate void OnDiagnoseCompletedCompletedEventHandler(object sender, OnDiagnoseCompletedCompletedEventArgs e);
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.0.30319.1")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class OnDiagnoseCompletedCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
        
        private object[] results;
        
        internal OnDiagnoseCompletedCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
                base(exception, cancelled, userState) {
            this.results = results;
        }
        
        /// <remarks/>
        public string Result {
            get {
                this.RaiseExceptionIfNecessary();
                return ((string)(this.results[0]));
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.0.30319.1")]
    public delegate void OnMedicalAdviceCompletedCompletedEventHandler(object sender, OnMedicalAdviceCompletedCompletedEventArgs e);
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.0.30319.1")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class OnMedicalAdviceCompletedCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
        
        private object[] results;
        
        internal OnMedicalAdviceCompletedCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
                base(exception, cancelled, userState) {
            this.results = results;
        }
        
        /// <remarks/>
        public string Result {
            get {
                this.RaiseExceptionIfNecessary();
                return ((string)(this.results[0]));
            }
        }
    }
}

#pragma warning restore 1591