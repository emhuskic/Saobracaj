﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

// 
// This source code was auto-generated by Microsoft.VSDesigner, Version 4.0.30319.42000.
// 
#pragma warning disable 1591

namespace Saobracaj.vozila {
    using System;
    using System.Web.Services;
    using System.Diagnostics;
    using System.Web.Services.Protocols;
    using System.Xml.Serialization;
    using System.ComponentModel;
    
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.6.1586.0")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Web.Services.WebServiceBindingAttribute(Name="kazneSoap", Namespace="http://tempuri.org/")]
    public partial class kazne : System.Web.Services.Protocols.SoapHttpClientProtocol {
        
        private System.Threading.SendOrPostCallback HelloWorldOperationCompleted;
        
        private System.Threading.SendOrPostCallback getVozilaOperationCompleted;
        
        private System.Threading.SendOrPostCallback getKazneOperationCompleted;
        
        private bool useDefaultCredentialsSetExplicitly;
        
        /// <remarks/>
        public kazne() {
            this.Url = global::Saobracaj.Properties.Settings.Default.Saobracaj_vozila_kazne;
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
        public event HelloWorldCompletedEventHandler HelloWorldCompleted;
        
        /// <remarks/>
        public event getVozilaCompletedEventHandler getVozilaCompleted;
        
        /// <remarks/>
        public event getKazneCompletedEventHandler getKazneCompleted;
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://tempuri.org/HelloWorld", RequestNamespace="http://tempuri.org/", ResponseNamespace="http://tempuri.org/", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        public string HelloWorld() {
            object[] results = this.Invoke("HelloWorld", new object[0]);
            return ((string)(results[0]));
        }
        
        /// <remarks/>
        public void HelloWorldAsync() {
            this.HelloWorldAsync(null);
        }
        
        /// <remarks/>
        public void HelloWorldAsync(object userState) {
            if ((this.HelloWorldOperationCompleted == null)) {
                this.HelloWorldOperationCompleted = new System.Threading.SendOrPostCallback(this.OnHelloWorldOperationCompleted);
            }
            this.InvokeAsync("HelloWorld", new object[0], this.HelloWorldOperationCompleted, userState);
        }
        
        private void OnHelloWorldOperationCompleted(object arg) {
            if ((this.HelloWorldCompleted != null)) {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.HelloWorldCompleted(this, new HelloWorldCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://tempuri.org/getVozila", RequestNamespace="http://tempuri.org/", ResponseNamespace="http://tempuri.org/", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        public Vozilo[] getVozila() {
            object[] results = this.Invoke("getVozila", new object[0]);
            return ((Vozilo[])(results[0]));
        }
        
        /// <remarks/>
        public void getVozilaAsync() {
            this.getVozilaAsync(null);
        }
        
        /// <remarks/>
        public void getVozilaAsync(object userState) {
            if ((this.getVozilaOperationCompleted == null)) {
                this.getVozilaOperationCompleted = new System.Threading.SendOrPostCallback(this.OngetVozilaOperationCompleted);
            }
            this.InvokeAsync("getVozila", new object[0], this.getVozilaOperationCompleted, userState);
        }
        
        private void OngetVozilaOperationCompleted(object arg) {
            if ((this.getVozilaCompleted != null)) {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.getVozilaCompleted(this, new getVozilaCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://tempuri.org/getKazne", RequestNamespace="http://tempuri.org/", ResponseNamespace="http://tempuri.org/", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        public Kazna[] getKazne() {
            object[] results = this.Invoke("getKazne", new object[0]);
            return ((Kazna[])(results[0]));
        }
        
        /// <remarks/>
        public void getKazneAsync() {
            this.getKazneAsync(null);
        }
        
        /// <remarks/>
        public void getKazneAsync(object userState) {
            if ((this.getKazneOperationCompleted == null)) {
                this.getKazneOperationCompleted = new System.Threading.SendOrPostCallback(this.OngetKazneOperationCompleted);
            }
            this.InvokeAsync("getKazne", new object[0], this.getKazneOperationCompleted, userState);
        }
        
        private void OngetKazneOperationCompleted(object arg) {
            if ((this.getKazneCompleted != null)) {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.getKazneCompleted(this, new getKazneCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
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
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.6.1586.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://tempuri.org/")]
    public partial class Vozilo {
        
        private int voziloIdField;
        
        private string brojTabliceField;
        
        private string brojSasijeField;
        
        private string odgovornaOsobaField;
        
        private string datumUnosaField;
        
        /// <remarks/>
        public int VoziloId {
            get {
                return this.voziloIdField;
            }
            set {
                this.voziloIdField = value;
            }
        }
        
        /// <remarks/>
        public string BrojTablice {
            get {
                return this.brojTabliceField;
            }
            set {
                this.brojTabliceField = value;
            }
        }
        
        /// <remarks/>
        public string BrojSasije {
            get {
                return this.brojSasijeField;
            }
            set {
                this.brojSasijeField = value;
            }
        }
        
        /// <remarks/>
        public string OdgovornaOsoba {
            get {
                return this.odgovornaOsobaField;
            }
            set {
                this.odgovornaOsobaField = value;
            }
        }
        
        /// <remarks/>
        public string DatumUnosa {
            get {
                return this.datumUnosaField;
            }
            set {
                this.datumUnosaField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.6.1586.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://tempuri.org/")]
    public partial class Vlasnik {
        
        private int vlasnikIdField;
        
        private string jMBGField;
        
        private string imeField;
        
        private string prezimeField;
        
        private string odgovornaOsobaField;
        
        private string datumUnosaField;
        
        /// <remarks/>
        public int VlasnikId {
            get {
                return this.vlasnikIdField;
            }
            set {
                this.vlasnikIdField = value;
            }
        }
        
        /// <remarks/>
        public string JMBG {
            get {
                return this.jMBGField;
            }
            set {
                this.jMBGField = value;
            }
        }
        
        /// <remarks/>
        public string Ime {
            get {
                return this.imeField;
            }
            set {
                this.imeField = value;
            }
        }
        
        /// <remarks/>
        public string Prezime {
            get {
                return this.prezimeField;
            }
            set {
                this.prezimeField = value;
            }
        }
        
        /// <remarks/>
        public string OdgovornaOsoba {
            get {
                return this.odgovornaOsobaField;
            }
            set {
                this.odgovornaOsobaField = value;
            }
        }
        
        /// <remarks/>
        public string DatumUnosa {
            get {
                return this.datumUnosaField;
            }
            set {
                this.datumUnosaField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.6.1586.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://tempuri.org/")]
    public partial class Kazna {
        
        private int kaznaIdField;
        
        private int vlasnikIdField;
        
        private int voziloIdField;
        
        private double iznosField;
        
        private string opisField;
        
        private System.DateTime datumField;
        
        private Vlasnik naLiceField;
        
        private Vozilo naVoziloField;
        
        private string odgovornaOsobaField;
        
        /// <remarks/>
        public int KaznaId {
            get {
                return this.kaznaIdField;
            }
            set {
                this.kaznaIdField = value;
            }
        }
        
        /// <remarks/>
        public int VlasnikId {
            get {
                return this.vlasnikIdField;
            }
            set {
                this.vlasnikIdField = value;
            }
        }
        
        /// <remarks/>
        public int VoziloId {
            get {
                return this.voziloIdField;
            }
            set {
                this.voziloIdField = value;
            }
        }
        
        /// <remarks/>
        public double Iznos {
            get {
                return this.iznosField;
            }
            set {
                this.iznosField = value;
            }
        }
        
        /// <remarks/>
        public string Opis {
            get {
                return this.opisField;
            }
            set {
                this.opisField = value;
            }
        }
        
        /// <remarks/>
        public System.DateTime Datum {
            get {
                return this.datumField;
            }
            set {
                this.datumField = value;
            }
        }
        
        /// <remarks/>
        public Vlasnik naLice {
            get {
                return this.naLiceField;
            }
            set {
                this.naLiceField = value;
            }
        }
        
        /// <remarks/>
        public Vozilo naVozilo {
            get {
                return this.naVoziloField;
            }
            set {
                this.naVoziloField = value;
            }
        }
        
        /// <remarks/>
        public string OdgovornaOsoba {
            get {
                return this.odgovornaOsobaField;
            }
            set {
                this.odgovornaOsobaField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.6.1586.0")]
    public delegate void HelloWorldCompletedEventHandler(object sender, HelloWorldCompletedEventArgs e);
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.6.1586.0")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class HelloWorldCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
        
        private object[] results;
        
        internal HelloWorldCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
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
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.6.1586.0")]
    public delegate void getVozilaCompletedEventHandler(object sender, getVozilaCompletedEventArgs e);
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.6.1586.0")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class getVozilaCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
        
        private object[] results;
        
        internal getVozilaCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
                base(exception, cancelled, userState) {
            this.results = results;
        }
        
        /// <remarks/>
        public Vozilo[] Result {
            get {
                this.RaiseExceptionIfNecessary();
                return ((Vozilo[])(this.results[0]));
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.6.1586.0")]
    public delegate void getKazneCompletedEventHandler(object sender, getKazneCompletedEventArgs e);
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.6.1586.0")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class getKazneCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
        
        private object[] results;
        
        internal getKazneCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
                base(exception, cancelled, userState) {
            this.results = results;
        }
        
        /// <remarks/>
        public Kazna[] Result {
            get {
                this.RaiseExceptionIfNecessary();
                return ((Kazna[])(this.results[0]));
            }
        }
    }
}

#pragma warning restore 1591