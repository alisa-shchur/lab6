﻿//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан программой.
//     Исполняемая версия:4.0.30319.42000
//
//     Изменения в этом файле могут привести к неправильной работе и будут потеряны в случае
//     повторной генерации кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace lab6.ServiceReference1 {
    using System.Runtime.Serialization;
    using System;
    
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="Client", Namespace="http://tempuri.org/")]
    [System.SerializableAttribute()]
    public partial class Client : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        private int IdField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string LastNameClientField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string FirstNameClientField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string PhoneField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string EmailField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string AdressField;
        
        [global::System.ComponentModel.BrowsableAttribute(false)]
        public System.Runtime.Serialization.ExtensionDataObject ExtensionData {
            get {
                return this.extensionDataField;
            }
            set {
                this.extensionDataField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(IsRequired=true)]
        public int Id {
            get {
                return this.IdField;
            }
            set {
                if ((this.IdField.Equals(value) != true)) {
                    this.IdField = value;
                    this.RaisePropertyChanged("Id");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false)]
        public string LastNameClient {
            get {
                return this.LastNameClientField;
            }
            set {
                if ((object.ReferenceEquals(this.LastNameClientField, value) != true)) {
                    this.LastNameClientField = value;
                    this.RaisePropertyChanged("LastNameClient");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=2)]
        public string FirstNameClient {
            get {
                return this.FirstNameClientField;
            }
            set {
                if ((object.ReferenceEquals(this.FirstNameClientField, value) != true)) {
                    this.FirstNameClientField = value;
                    this.RaisePropertyChanged("FirstNameClient");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=3)]
        public string Phone {
            get {
                return this.PhoneField;
            }
            set {
                if ((object.ReferenceEquals(this.PhoneField, value) != true)) {
                    this.PhoneField = value;
                    this.RaisePropertyChanged("Phone");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=4)]
        public string Email {
            get {
                return this.EmailField;
            }
            set {
                if ((object.ReferenceEquals(this.EmailField, value) != true)) {
                    this.EmailField = value;
                    this.RaisePropertyChanged("Email");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=5)]
        public string Adress {
            get {
                return this.AdressField;
            }
            set {
                if ((object.ReferenceEquals(this.AdressField, value) != true)) {
                    this.AdressField = value;
                    this.RaisePropertyChanged("Adress");
                }
            }
        }
        
        public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;
        
        protected void RaisePropertyChanged(string propertyName) {
            System.ComponentModel.PropertyChangedEventHandler propertyChanged = this.PropertyChanged;
            if ((propertyChanged != null)) {
                propertyChanged(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
            }
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="ServiceReference1.WebService1Soap")]
    public interface WebService1Soap {
        
        // CODEGEN: Контракт генерации сообщений с именем HelloWorldResult из пространства имен http://tempuri.org/ не отмечен как обнуляемый
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/HelloWorld", ReplyAction="*")]
        lab6.ServiceReference1.HelloWorldResponse HelloWorld(lab6.ServiceReference1.HelloWorldRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/HelloWorld", ReplyAction="*")]
        System.Threading.Tasks.Task<lab6.ServiceReference1.HelloWorldResponse> HelloWorldAsync(lab6.ServiceReference1.HelloWorldRequest request);
        
        // CODEGEN: Контракт генерации сообщений с именем GetClientsResult из пространства имен http://tempuri.org/ не отмечен как обнуляемый
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/GetClients", ReplyAction="*")]
        lab6.ServiceReference1.GetClientsResponse GetClients(lab6.ServiceReference1.GetClientsRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/GetClients", ReplyAction="*")]
        System.Threading.Tasks.Task<lab6.ServiceReference1.GetClientsResponse> GetClientsAsync(lab6.ServiceReference1.GetClientsRequest request);
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class HelloWorldRequest {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="HelloWorld", Namespace="http://tempuri.org/", Order=0)]
        public lab6.ServiceReference1.HelloWorldRequestBody Body;
        
        public HelloWorldRequest() {
        }
        
        public HelloWorldRequest(lab6.ServiceReference1.HelloWorldRequestBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute()]
    public partial class HelloWorldRequestBody {
        
        public HelloWorldRequestBody() {
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class HelloWorldResponse {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="HelloWorldResponse", Namespace="http://tempuri.org/", Order=0)]
        public lab6.ServiceReference1.HelloWorldResponseBody Body;
        
        public HelloWorldResponse() {
        }
        
        public HelloWorldResponse(lab6.ServiceReference1.HelloWorldResponseBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://tempuri.org/")]
    public partial class HelloWorldResponseBody {
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=0)]
        public string HelloWorldResult;
        
        public HelloWorldResponseBody() {
        }
        
        public HelloWorldResponseBody(string HelloWorldResult) {
            this.HelloWorldResult = HelloWorldResult;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class GetClientsRequest {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="GetClients", Namespace="http://tempuri.org/", Order=0)]
        public lab6.ServiceReference1.GetClientsRequestBody Body;
        
        public GetClientsRequest() {
        }
        
        public GetClientsRequest(lab6.ServiceReference1.GetClientsRequestBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute()]
    public partial class GetClientsRequestBody {
        
        public GetClientsRequestBody() {
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class GetClientsResponse {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="GetClientsResponse", Namespace="http://tempuri.org/", Order=0)]
        public lab6.ServiceReference1.GetClientsResponseBody Body;
        
        public GetClientsResponse() {
        }
        
        public GetClientsResponse(lab6.ServiceReference1.GetClientsResponseBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://tempuri.org/")]
    public partial class GetClientsResponseBody {
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=0)]
        public lab6.ServiceReference1.Client[] GetClientsResult;
        
        public GetClientsResponseBody() {
        }
        
        public GetClientsResponseBody(lab6.ServiceReference1.Client[] GetClientsResult) {
            this.GetClientsResult = GetClientsResult;
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface WebService1SoapChannel : lab6.ServiceReference1.WebService1Soap, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class WebService1SoapClient : System.ServiceModel.ClientBase<lab6.ServiceReference1.WebService1Soap>, lab6.ServiceReference1.WebService1Soap {
        
        public WebService1SoapClient() {
        }
        
        public WebService1SoapClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public WebService1SoapClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public WebService1SoapClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public WebService1SoapClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        lab6.ServiceReference1.HelloWorldResponse lab6.ServiceReference1.WebService1Soap.HelloWorld(lab6.ServiceReference1.HelloWorldRequest request) {
            return base.Channel.HelloWorld(request);
        }
        
        public string HelloWorld() {
            lab6.ServiceReference1.HelloWorldRequest inValue = new lab6.ServiceReference1.HelloWorldRequest();
            inValue.Body = new lab6.ServiceReference1.HelloWorldRequestBody();
            lab6.ServiceReference1.HelloWorldResponse retVal = ((lab6.ServiceReference1.WebService1Soap)(this)).HelloWorld(inValue);
            return retVal.Body.HelloWorldResult;
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<lab6.ServiceReference1.HelloWorldResponse> lab6.ServiceReference1.WebService1Soap.HelloWorldAsync(lab6.ServiceReference1.HelloWorldRequest request) {
            return base.Channel.HelloWorldAsync(request);
        }
        
        public System.Threading.Tasks.Task<lab6.ServiceReference1.HelloWorldResponse> HelloWorldAsync() {
            lab6.ServiceReference1.HelloWorldRequest inValue = new lab6.ServiceReference1.HelloWorldRequest();
            inValue.Body = new lab6.ServiceReference1.HelloWorldRequestBody();
            return ((lab6.ServiceReference1.WebService1Soap)(this)).HelloWorldAsync(inValue);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        lab6.ServiceReference1.GetClientsResponse lab6.ServiceReference1.WebService1Soap.GetClients(lab6.ServiceReference1.GetClientsRequest request) {
            return base.Channel.GetClients(request);
        }
        
        public lab6.ServiceReference1.Client[] GetClients() {
            lab6.ServiceReference1.GetClientsRequest inValue = new lab6.ServiceReference1.GetClientsRequest();
            inValue.Body = new lab6.ServiceReference1.GetClientsRequestBody();
            lab6.ServiceReference1.GetClientsResponse retVal = ((lab6.ServiceReference1.WebService1Soap)(this)).GetClients(inValue);
            return retVal.Body.GetClientsResult;
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<lab6.ServiceReference1.GetClientsResponse> lab6.ServiceReference1.WebService1Soap.GetClientsAsync(lab6.ServiceReference1.GetClientsRequest request) {
            return base.Channel.GetClientsAsync(request);
        }
        
        public System.Threading.Tasks.Task<lab6.ServiceReference1.GetClientsResponse> GetClientsAsync() {
            lab6.ServiceReference1.GetClientsRequest inValue = new lab6.ServiceReference1.GetClientsRequest();
            inValue.Body = new lab6.ServiceReference1.GetClientsRequestBody();
            return ((lab6.ServiceReference1.WebService1Soap)(this)).GetClientsAsync(inValue);
        }
    }
}
