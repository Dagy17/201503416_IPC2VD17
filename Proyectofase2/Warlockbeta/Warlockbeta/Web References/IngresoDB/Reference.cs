﻿//------------------------------------------------------------------------------
// <auto-generated>
//     Este código fue generado por una herramienta.
//     Versión de runtime:4.0.30319.42000
//
//     Los cambios en este archivo podrían causar un comportamiento incorrecto y se perderán si
//     se vuelve a generar el código.
// </auto-generated>
//------------------------------------------------------------------------------

// 
// Microsoft.VSDesigner generó automáticamente este código fuente, versión=4.0.30319.42000.
// 
#pragma warning disable 1591

namespace Warlockbeta.IngresoDB {
    using System;
    using System.Web.Services;
    using System.Diagnostics;
    using System.Web.Services.Protocols;
    using System.Xml.Serialization;
    using System.ComponentModel;
    
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.7.2556.0")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Web.Services.WebServiceBindingAttribute(Name="Agregar_datoPortBinding", Namespace="http://web_services/")]
    public partial class Agregar_dato : System.Web.Services.Protocols.SoapHttpClientProtocol {
        
        private System.Threading.SendOrPostCallback Agregar_UsuarioOperationCompleted;
        
        private System.Threading.SendOrPostCallback Agregar_VehiOperationCompleted;
        
        private bool useDefaultCredentialsSetExplicitly;
        
        /// <remarks/>
        public Agregar_dato() {
            this.Url = global::Warlockbeta.Properties.Settings.Default.Warlockbeta_IngresoDB_Agregar_dato;
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
        public event Agregar_UsuarioCompletedEventHandler Agregar_UsuarioCompleted;
        
        /// <remarks/>
        public event Agregar_VehiCompletedEventHandler Agregar_VehiCompleted;
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("", RequestNamespace="http://web_services/", ResponseNamespace="http://web_services/", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        [return: System.Xml.Serialization.XmlElementAttribute("return", Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public bool Agregar_Usuario([System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)] string nickname, [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)] string nombre, [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)] string correo, [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)] string password) {
            object[] results = this.Invoke("Agregar_Usuario", new object[] {
                        nickname,
                        nombre,
                        correo,
                        password});
            return ((bool)(results[0]));
        }
        
        /// <remarks/>
        public void Agregar_UsuarioAsync(string nickname, string nombre, string correo, string password) {
            this.Agregar_UsuarioAsync(nickname, nombre, correo, password, null);
        }
        
        /// <remarks/>
        public void Agregar_UsuarioAsync(string nickname, string nombre, string correo, string password, object userState) {
            if ((this.Agregar_UsuarioOperationCompleted == null)) {
                this.Agregar_UsuarioOperationCompleted = new System.Threading.SendOrPostCallback(this.OnAgregar_UsuarioOperationCompleted);
            }
            this.InvokeAsync("Agregar_Usuario", new object[] {
                        nickname,
                        nombre,
                        correo,
                        password}, this.Agregar_UsuarioOperationCompleted, userState);
        }
        
        private void OnAgregar_UsuarioOperationCompleted(object arg) {
            if ((this.Agregar_UsuarioCompleted != null)) {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.Agregar_UsuarioCompleted(this, new Agregar_UsuarioCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("", RequestNamespace="http://web_services/", ResponseNamespace="http://web_services/", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        [return: System.Xml.Serialization.XmlElementAttribute("return", Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public bool Agregar_Vehi([System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)] string username, [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)] string placa, [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)] string modelo, [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)] string marca, [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)] string capacidad, [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)] string dpii) {
            object[] results = this.Invoke("Agregar_Vehi", new object[] {
                        username,
                        placa,
                        modelo,
                        marca,
                        capacidad,
                        dpii});
            return ((bool)(results[0]));
        }
        
        /// <remarks/>
        public void Agregar_VehiAsync(string username, string placa, string modelo, string marca, string capacidad, string dpii) {
            this.Agregar_VehiAsync(username, placa, modelo, marca, capacidad, dpii, null);
        }
        
        /// <remarks/>
        public void Agregar_VehiAsync(string username, string placa, string modelo, string marca, string capacidad, string dpii, object userState) {
            if ((this.Agregar_VehiOperationCompleted == null)) {
                this.Agregar_VehiOperationCompleted = new System.Threading.SendOrPostCallback(this.OnAgregar_VehiOperationCompleted);
            }
            this.InvokeAsync("Agregar_Vehi", new object[] {
                        username,
                        placa,
                        modelo,
                        marca,
                        capacidad,
                        dpii}, this.Agregar_VehiOperationCompleted, userState);
        }
        
        private void OnAgregar_VehiOperationCompleted(object arg) {
            if ((this.Agregar_VehiCompleted != null)) {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.Agregar_VehiCompleted(this, new Agregar_VehiCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
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
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.7.2556.0")]
    public delegate void Agregar_UsuarioCompletedEventHandler(object sender, Agregar_UsuarioCompletedEventArgs e);
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.7.2556.0")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class Agregar_UsuarioCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
        
        private object[] results;
        
        internal Agregar_UsuarioCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
                base(exception, cancelled, userState) {
            this.results = results;
        }
        
        /// <remarks/>
        public bool Result {
            get {
                this.RaiseExceptionIfNecessary();
                return ((bool)(this.results[0]));
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.7.2556.0")]
    public delegate void Agregar_VehiCompletedEventHandler(object sender, Agregar_VehiCompletedEventArgs e);
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.7.2556.0")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class Agregar_VehiCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
        
        private object[] results;
        
        internal Agregar_VehiCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
                base(exception, cancelled, userState) {
            this.results = results;
        }
        
        /// <remarks/>
        public bool Result {
            get {
                this.RaiseExceptionIfNecessary();
                return ((bool)(this.results[0]));
            }
        }
    }
}

#pragma warning restore 1591