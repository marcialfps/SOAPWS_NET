﻿//------------------------------------------------------------------------------
// <auto-generated>
//     Este código fue generado por una herramienta.
//     Versión de runtime:4.0.30319.42000
//
//     Los cambios en este archivo podrían causar un comportamiento incorrecto y se perderán si
//     se vuelve a generar el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace WS.Unit05.Example2.Application.WSClient.IkeaWS {
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(Namespace="http://webservices.task1.unit03.ws/", ConfigurationName="WSClient.IkeaWS.IIkeaWS")]
    public interface IIkeaWS {
        
        // CODEGEN: El parámetro 'return' requiere información adicional de esquema que no se puede capturar con el modo de parámetros. El atributo específico es 'System.Xml.Serialization.XmlElementAttribute'.
        [System.ServiceModel.OperationContractAttribute(Action="http://webservices.task1.unit03.ws/IIkeaWS/listRequest", ReplyAction="http://webservices.task1.unit03.ws/IIkeaWS/listResponse")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        [return: System.ServiceModel.MessageParameterAttribute(Name="return")]
        WS.Unit05.Example2.Application.WSClient.IkeaWS.listResponse list(WS.Unit05.Example2.Application.WSClient.IkeaWS.listRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://webservices.task1.unit03.ws/IIkeaWS/listRequest", ReplyAction="http://webservices.task1.unit03.ws/IIkeaWS/listResponse")]
        System.Threading.Tasks.Task<WS.Unit05.Example2.Application.WSClient.IkeaWS.listResponse> listAsync(WS.Unit05.Example2.Application.WSClient.IkeaWS.listRequest request);
        
        // CODEGEN: El parámetro 'return' requiere información adicional de esquema que no se puede capturar con el modo de parámetros. El atributo específico es 'System.Xml.Serialization.XmlElementAttribute'.
        [System.ServiceModel.OperationContractAttribute(Action="http://webservices.task1.unit03.ws/IIkeaWS/searchRequest", ReplyAction="http://webservices.task1.unit03.ws/IIkeaWS/searchResponse")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        [return: System.ServiceModel.MessageParameterAttribute(Name="return")]
        WS.Unit05.Example2.Application.WSClient.IkeaWS.searchResponse search(WS.Unit05.Example2.Application.WSClient.IkeaWS.searchRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://webservices.task1.unit03.ws/IIkeaWS/searchRequest", ReplyAction="http://webservices.task1.unit03.ws/IIkeaWS/searchResponse")]
        System.Threading.Tasks.Task<WS.Unit05.Example2.Application.WSClient.IkeaWS.searchResponse> searchAsync(WS.Unit05.Example2.Application.WSClient.IkeaWS.searchRequest request);
        
        // CODEGEN: El parámetro 'return' requiere información adicional de esquema que no se puede capturar con el modo de parámetros. El atributo específico es 'System.Xml.Serialization.XmlElementAttribute'.
        [System.ServiceModel.OperationContractAttribute(Action="http://webservices.task1.unit03.ws/IIkeaWS/piecesRequest", ReplyAction="http://webservices.task1.unit03.ws/IIkeaWS/piecesResponse")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        [return: System.ServiceModel.MessageParameterAttribute(Name="return")]
        WS.Unit05.Example2.Application.WSClient.IkeaWS.piecesResponse pieces(WS.Unit05.Example2.Application.WSClient.IkeaWS.piecesRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://webservices.task1.unit03.ws/IIkeaWS/piecesRequest", ReplyAction="http://webservices.task1.unit03.ws/IIkeaWS/piecesResponse")]
        System.Threading.Tasks.Task<WS.Unit05.Example2.Application.WSClient.IkeaWS.piecesResponse> piecesAsync(WS.Unit05.Example2.Application.WSClient.IkeaWS.piecesRequest request);
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="list", WrapperNamespace="http://webservices.task1.unit03.ws/", IsWrapped=true)]
    public partial class listRequest {
        
        public listRequest() {
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="listResponse", WrapperNamespace="http://webservices.task1.unit03.ws/", IsWrapped=true)]
    public partial class listResponse {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://webservices.task1.unit03.ws/", Order=0)]
        [System.Xml.Serialization.XmlElementAttribute("return", Form=System.Xml.Schema.XmlSchemaForm.Unqualified, IsNullable=true)]
        public string[] @return;
        
        public listResponse() {
        }
        
        public listResponse(string[] @return) {
            this.@return = @return;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="search", WrapperNamespace="http://webservices.task1.unit03.ws/", IsWrapped=true)]
    public partial class searchRequest {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://webservices.task1.unit03.ws/", Order=0)]
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string arg0;
        
        public searchRequest() {
        }
        
        public searchRequest(string arg0) {
            this.arg0 = arg0;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="searchResponse", WrapperNamespace="http://webservices.task1.unit03.ws/", IsWrapped=true)]
    public partial class searchResponse {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://webservices.task1.unit03.ws/", Order=0)]
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public double @return;
        
        public searchResponse() {
        }
        
        public searchResponse(double @return) {
            this.@return = @return;
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.8.3752.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://webservices.task1.unit03.ws/")]
    public partial class explodedPiece : object, System.ComponentModel.INotifyPropertyChanged {
        
        private int amountField;
        
        private string pieceCodeField;
        
        private double volumeField;
        
        private double weightField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=0)]
        public int amount {
            get {
                return this.amountField;
            }
            set {
                this.amountField = value;
                this.RaisePropertyChanged("amount");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=1)]
        public string pieceCode {
            get {
                return this.pieceCodeField;
            }
            set {
                this.pieceCodeField = value;
                this.RaisePropertyChanged("pieceCode");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=2)]
        public double volume {
            get {
                return this.volumeField;
            }
            set {
                this.volumeField = value;
                this.RaisePropertyChanged("volume");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=3)]
        public double weight {
            get {
                return this.weightField;
            }
            set {
                this.weightField = value;
                this.RaisePropertyChanged("weight");
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
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="pieces", WrapperNamespace="http://webservices.task1.unit03.ws/", IsWrapped=true)]
    public partial class piecesRequest {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://webservices.task1.unit03.ws/", Order=0)]
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string arg0;
        
        public piecesRequest() {
        }
        
        public piecesRequest(string arg0) {
            this.arg0 = arg0;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="piecesResponse", WrapperNamespace="http://webservices.task1.unit03.ws/", IsWrapped=true)]
    public partial class piecesResponse {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://webservices.task1.unit03.ws/", Order=0)]
        [System.Xml.Serialization.XmlElementAttribute("return", Form=System.Xml.Schema.XmlSchemaForm.Unqualified, IsNullable=true)]
        public WS.Unit05.Example2.Application.WSClient.IkeaWS.explodedPiece[] @return;
        
        public piecesResponse() {
        }
        
        public piecesResponse(WS.Unit05.Example2.Application.WSClient.IkeaWS.explodedPiece[] @return) {
            this.@return = @return;
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IIkeaWSChannel : WS.Unit05.Example2.Application.WSClient.IkeaWS.IIkeaWS, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class IkeaWSClient : System.ServiceModel.ClientBase<WS.Unit05.Example2.Application.WSClient.IkeaWS.IIkeaWS>, WS.Unit05.Example2.Application.WSClient.IkeaWS.IIkeaWS {
        
        public IkeaWSClient() {
        }
        
        public IkeaWSClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public IkeaWSClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public IkeaWSClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public IkeaWSClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        WS.Unit05.Example2.Application.WSClient.IkeaWS.listResponse WS.Unit05.Example2.Application.WSClient.IkeaWS.IIkeaWS.list(WS.Unit05.Example2.Application.WSClient.IkeaWS.listRequest request) {
            return base.Channel.list(request);
        }
        
        public string[] list() {
            WS.Unit05.Example2.Application.WSClient.IkeaWS.listRequest inValue = new WS.Unit05.Example2.Application.WSClient.IkeaWS.listRequest();
            WS.Unit05.Example2.Application.WSClient.IkeaWS.listResponse retVal = ((WS.Unit05.Example2.Application.WSClient.IkeaWS.IIkeaWS)(this)).list(inValue);
            return retVal.@return;
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<WS.Unit05.Example2.Application.WSClient.IkeaWS.listResponse> WS.Unit05.Example2.Application.WSClient.IkeaWS.IIkeaWS.listAsync(WS.Unit05.Example2.Application.WSClient.IkeaWS.listRequest request) {
            return base.Channel.listAsync(request);
        }
        
        public System.Threading.Tasks.Task<WS.Unit05.Example2.Application.WSClient.IkeaWS.listResponse> listAsync() {
            WS.Unit05.Example2.Application.WSClient.IkeaWS.listRequest inValue = new WS.Unit05.Example2.Application.WSClient.IkeaWS.listRequest();
            return ((WS.Unit05.Example2.Application.WSClient.IkeaWS.IIkeaWS)(this)).listAsync(inValue);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        WS.Unit05.Example2.Application.WSClient.IkeaWS.searchResponse WS.Unit05.Example2.Application.WSClient.IkeaWS.IIkeaWS.search(WS.Unit05.Example2.Application.WSClient.IkeaWS.searchRequest request) {
            return base.Channel.search(request);
        }
        
        public double search(string arg0) {
            WS.Unit05.Example2.Application.WSClient.IkeaWS.searchRequest inValue = new WS.Unit05.Example2.Application.WSClient.IkeaWS.searchRequest();
            inValue.arg0 = arg0;
            WS.Unit05.Example2.Application.WSClient.IkeaWS.searchResponse retVal = ((WS.Unit05.Example2.Application.WSClient.IkeaWS.IIkeaWS)(this)).search(inValue);
            return retVal.@return;
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<WS.Unit05.Example2.Application.WSClient.IkeaWS.searchResponse> WS.Unit05.Example2.Application.WSClient.IkeaWS.IIkeaWS.searchAsync(WS.Unit05.Example2.Application.WSClient.IkeaWS.searchRequest request) {
            return base.Channel.searchAsync(request);
        }
        
        public System.Threading.Tasks.Task<WS.Unit05.Example2.Application.WSClient.IkeaWS.searchResponse> searchAsync(string arg0) {
            WS.Unit05.Example2.Application.WSClient.IkeaWS.searchRequest inValue = new WS.Unit05.Example2.Application.WSClient.IkeaWS.searchRequest();
            inValue.arg0 = arg0;
            return ((WS.Unit05.Example2.Application.WSClient.IkeaWS.IIkeaWS)(this)).searchAsync(inValue);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        WS.Unit05.Example2.Application.WSClient.IkeaWS.piecesResponse WS.Unit05.Example2.Application.WSClient.IkeaWS.IIkeaWS.pieces(WS.Unit05.Example2.Application.WSClient.IkeaWS.piecesRequest request) {
            return base.Channel.pieces(request);
        }
        
        public WS.Unit05.Example2.Application.WSClient.IkeaWS.explodedPiece[] pieces(string arg0) {
            WS.Unit05.Example2.Application.WSClient.IkeaWS.piecesRequest inValue = new WS.Unit05.Example2.Application.WSClient.IkeaWS.piecesRequest();
            inValue.arg0 = arg0;
            WS.Unit05.Example2.Application.WSClient.IkeaWS.piecesResponse retVal = ((WS.Unit05.Example2.Application.WSClient.IkeaWS.IIkeaWS)(this)).pieces(inValue);
            return retVal.@return;
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<WS.Unit05.Example2.Application.WSClient.IkeaWS.piecesResponse> WS.Unit05.Example2.Application.WSClient.IkeaWS.IIkeaWS.piecesAsync(WS.Unit05.Example2.Application.WSClient.IkeaWS.piecesRequest request) {
            return base.Channel.piecesAsync(request);
        }
        
        public System.Threading.Tasks.Task<WS.Unit05.Example2.Application.WSClient.IkeaWS.piecesResponse> piecesAsync(string arg0) {
            WS.Unit05.Example2.Application.WSClient.IkeaWS.piecesRequest inValue = new WS.Unit05.Example2.Application.WSClient.IkeaWS.piecesRequest();
            inValue.arg0 = arg0;
            return ((WS.Unit05.Example2.Application.WSClient.IkeaWS.IIkeaWS)(this)).piecesAsync(inValue);
        }
    }
}
