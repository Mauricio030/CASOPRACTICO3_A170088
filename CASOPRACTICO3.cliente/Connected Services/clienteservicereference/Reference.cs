﻿//------------------------------------------------------------------------------
// <auto-generated>
//     Este código fue generado por una herramienta.
//     Versión de runtime:4.0.30319.42000
//
//     Los cambios en este archivo podrían causar un comportamiento incorrecto y se perderán si
//     se vuelve a generar el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace CASOPRACTICO3.cliente.clienteservicereference {
    using System.Runtime.Serialization;
    using System;
    
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="Caso3", Namespace="http://tempuri.org/")]
    [System.SerializableAttribute()]
    public partial class Caso3 : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        private int idField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string nombreField;
        
        private System.Nullable<System.DateTime> fecha_emisionField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string descripcionField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string comentarioField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string urlField;
        
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
        public int id {
            get {
                return this.idField;
            }
            set {
                if ((this.idField.Equals(value) != true)) {
                    this.idField = value;
                    this.RaisePropertyChanged("id");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false)]
        public string nombre {
            get {
                return this.nombreField;
            }
            set {
                if ((object.ReferenceEquals(this.nombreField, value) != true)) {
                    this.nombreField = value;
                    this.RaisePropertyChanged("nombre");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(IsRequired=true, Order=2)]
        public System.Nullable<System.DateTime> fecha_emision {
            get {
                return this.fecha_emisionField;
            }
            set {
                if ((this.fecha_emisionField.Equals(value) != true)) {
                    this.fecha_emisionField = value;
                    this.RaisePropertyChanged("fecha_emision");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=3)]
        public string descripcion {
            get {
                return this.descripcionField;
            }
            set {
                if ((object.ReferenceEquals(this.descripcionField, value) != true)) {
                    this.descripcionField = value;
                    this.RaisePropertyChanged("descripcion");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=4)]
        public string comentario {
            get {
                return this.comentarioField;
            }
            set {
                if ((object.ReferenceEquals(this.comentarioField, value) != true)) {
                    this.comentarioField = value;
                    this.RaisePropertyChanged("comentario");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=5)]
        public string url {
            get {
                return this.urlField;
            }
            set {
                if ((object.ReferenceEquals(this.urlField, value) != true)) {
                    this.urlField = value;
                    this.RaisePropertyChanged("url");
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
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="clienteservicereference.webservSoap")]
    public interface webservSoap {
        
        // CODEGEN: Se está generando un contrato de mensaje, ya que el nombre de elemento PeliculasResult del espacio de nombres http://tempuri.org/ no está marcado para aceptar valores nil.
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/Peliculas", ReplyAction="*")]
        CASOPRACTICO3.cliente.clienteservicereference.PeliculasResponse Peliculas(CASOPRACTICO3.cliente.clienteservicereference.PeliculasRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/Peliculas", ReplyAction="*")]
        System.Threading.Tasks.Task<CASOPRACTICO3.cliente.clienteservicereference.PeliculasResponse> PeliculasAsync(CASOPRACTICO3.cliente.clienteservicereference.PeliculasRequest request);
        
        // CODEGEN: Se está generando un contrato de mensaje, ya que el nombre de elemento nombre del espacio de nombres http://tempuri.org/ no está marcado para aceptar valores nil.
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/InsertarPelicula", ReplyAction="*")]
        CASOPRACTICO3.cliente.clienteservicereference.InsertarPeliculaResponse InsertarPelicula(CASOPRACTICO3.cliente.clienteservicereference.InsertarPeliculaRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/InsertarPelicula", ReplyAction="*")]
        System.Threading.Tasks.Task<CASOPRACTICO3.cliente.clienteservicereference.InsertarPeliculaResponse> InsertarPeliculaAsync(CASOPRACTICO3.cliente.clienteservicereference.InsertarPeliculaRequest request);
        
        // CODEGEN: Se está generando un contrato de mensaje, ya que el nombre de elemento nombre del espacio de nombres http://tempuri.org/ no está marcado para aceptar valores nil.
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ModificarPelicula", ReplyAction="*")]
        CASOPRACTICO3.cliente.clienteservicereference.ModificarPeliculaResponse ModificarPelicula(CASOPRACTICO3.cliente.clienteservicereference.ModificarPeliculaRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ModificarPelicula", ReplyAction="*")]
        System.Threading.Tasks.Task<CASOPRACTICO3.cliente.clienteservicereference.ModificarPeliculaResponse> ModificarPeliculaAsync(CASOPRACTICO3.cliente.clienteservicereference.ModificarPeliculaRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/EliminarPelicula", ReplyAction="*")]
        bool EliminarPelicula(int id);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/EliminarPelicula", ReplyAction="*")]
        System.Threading.Tasks.Task<bool> EliminarPeliculaAsync(int id);
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class PeliculasRequest {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="Peliculas", Namespace="http://tempuri.org/", Order=0)]
        public CASOPRACTICO3.cliente.clienteservicereference.PeliculasRequestBody Body;
        
        public PeliculasRequest() {
        }
        
        public PeliculasRequest(CASOPRACTICO3.cliente.clienteservicereference.PeliculasRequestBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute()]
    public partial class PeliculasRequestBody {
        
        public PeliculasRequestBody() {
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class PeliculasResponse {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="PeliculasResponse", Namespace="http://tempuri.org/", Order=0)]
        public CASOPRACTICO3.cliente.clienteservicereference.PeliculasResponseBody Body;
        
        public PeliculasResponse() {
        }
        
        public PeliculasResponse(CASOPRACTICO3.cliente.clienteservicereference.PeliculasResponseBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://tempuri.org/")]
    public partial class PeliculasResponseBody {
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=0)]
        public CASOPRACTICO3.cliente.clienteservicereference.Caso3[] PeliculasResult;
        
        public PeliculasResponseBody() {
        }
        
        public PeliculasResponseBody(CASOPRACTICO3.cliente.clienteservicereference.Caso3[] PeliculasResult) {
            this.PeliculasResult = PeliculasResult;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class InsertarPeliculaRequest {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="InsertarPelicula", Namespace="http://tempuri.org/", Order=0)]
        public CASOPRACTICO3.cliente.clienteservicereference.InsertarPeliculaRequestBody Body;
        
        public InsertarPeliculaRequest() {
        }
        
        public InsertarPeliculaRequest(CASOPRACTICO3.cliente.clienteservicereference.InsertarPeliculaRequestBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://tempuri.org/")]
    public partial class InsertarPeliculaRequestBody {
        
        [System.Runtime.Serialization.DataMemberAttribute(Order=0)]
        public int id;
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=1)]
        public string nombre;
        
        [System.Runtime.Serialization.DataMemberAttribute(Order=2)]
        public System.DateTime fecha_emision;
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=3)]
        public string descripcion;
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=4)]
        public string comentario;
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=5)]
        public string url;
        
        public InsertarPeliculaRequestBody() {
        }
        
        public InsertarPeliculaRequestBody(int id, string nombre, System.DateTime fecha_emision, string descripcion, string comentario, string url) {
            this.id = id;
            this.nombre = nombre;
            this.fecha_emision = fecha_emision;
            this.descripcion = descripcion;
            this.comentario = comentario;
            this.url = url;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class InsertarPeliculaResponse {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="InsertarPeliculaResponse", Namespace="http://tempuri.org/", Order=0)]
        public CASOPRACTICO3.cliente.clienteservicereference.InsertarPeliculaResponseBody Body;
        
        public InsertarPeliculaResponse() {
        }
        
        public InsertarPeliculaResponse(CASOPRACTICO3.cliente.clienteservicereference.InsertarPeliculaResponseBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://tempuri.org/")]
    public partial class InsertarPeliculaResponseBody {
        
        [System.Runtime.Serialization.DataMemberAttribute(Order=0)]
        public bool InsertarPeliculaResult;
        
        public InsertarPeliculaResponseBody() {
        }
        
        public InsertarPeliculaResponseBody(bool InsertarPeliculaResult) {
            this.InsertarPeliculaResult = InsertarPeliculaResult;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class ModificarPeliculaRequest {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="ModificarPelicula", Namespace="http://tempuri.org/", Order=0)]
        public CASOPRACTICO3.cliente.clienteservicereference.ModificarPeliculaRequestBody Body;
        
        public ModificarPeliculaRequest() {
        }
        
        public ModificarPeliculaRequest(CASOPRACTICO3.cliente.clienteservicereference.ModificarPeliculaRequestBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://tempuri.org/")]
    public partial class ModificarPeliculaRequestBody {
        
        [System.Runtime.Serialization.DataMemberAttribute(Order=0)]
        public int id;
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=1)]
        public string nombre;
        
        [System.Runtime.Serialization.DataMemberAttribute(Order=2)]
        public System.DateTime fecha_emision;
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=3)]
        public string descripcion;
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=4)]
        public string comentario;
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=5)]
        public string url;
        
        public ModificarPeliculaRequestBody() {
        }
        
        public ModificarPeliculaRequestBody(int id, string nombre, System.DateTime fecha_emision, string descripcion, string comentario, string url) {
            this.id = id;
            this.nombre = nombre;
            this.fecha_emision = fecha_emision;
            this.descripcion = descripcion;
            this.comentario = comentario;
            this.url = url;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class ModificarPeliculaResponse {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="ModificarPeliculaResponse", Namespace="http://tempuri.org/", Order=0)]
        public CASOPRACTICO3.cliente.clienteservicereference.ModificarPeliculaResponseBody Body;
        
        public ModificarPeliculaResponse() {
        }
        
        public ModificarPeliculaResponse(CASOPRACTICO3.cliente.clienteservicereference.ModificarPeliculaResponseBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://tempuri.org/")]
    public partial class ModificarPeliculaResponseBody {
        
        [System.Runtime.Serialization.DataMemberAttribute(Order=0)]
        public bool ModificarPeliculaResult;
        
        public ModificarPeliculaResponseBody() {
        }
        
        public ModificarPeliculaResponseBody(bool ModificarPeliculaResult) {
            this.ModificarPeliculaResult = ModificarPeliculaResult;
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface webservSoapChannel : CASOPRACTICO3.cliente.clienteservicereference.webservSoap, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class webservSoapClient : System.ServiceModel.ClientBase<CASOPRACTICO3.cliente.clienteservicereference.webservSoap>, CASOPRACTICO3.cliente.clienteservicereference.webservSoap {
        
        public webservSoapClient() {
        }
        
        public webservSoapClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public webservSoapClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public webservSoapClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public webservSoapClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        CASOPRACTICO3.cliente.clienteservicereference.PeliculasResponse CASOPRACTICO3.cliente.clienteservicereference.webservSoap.Peliculas(CASOPRACTICO3.cliente.clienteservicereference.PeliculasRequest request) {
            return base.Channel.Peliculas(request);
        }
        
        public CASOPRACTICO3.cliente.clienteservicereference.Caso3[] Peliculas() {
            CASOPRACTICO3.cliente.clienteservicereference.PeliculasRequest inValue = new CASOPRACTICO3.cliente.clienteservicereference.PeliculasRequest();
            inValue.Body = new CASOPRACTICO3.cliente.clienteservicereference.PeliculasRequestBody();
            CASOPRACTICO3.cliente.clienteservicereference.PeliculasResponse retVal = ((CASOPRACTICO3.cliente.clienteservicereference.webservSoap)(this)).Peliculas(inValue);
            return retVal.Body.PeliculasResult;
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<CASOPRACTICO3.cliente.clienteservicereference.PeliculasResponse> CASOPRACTICO3.cliente.clienteservicereference.webservSoap.PeliculasAsync(CASOPRACTICO3.cliente.clienteservicereference.PeliculasRequest request) {
            return base.Channel.PeliculasAsync(request);
        }
        
        public System.Threading.Tasks.Task<CASOPRACTICO3.cliente.clienteservicereference.PeliculasResponse> PeliculasAsync() {
            CASOPRACTICO3.cliente.clienteservicereference.PeliculasRequest inValue = new CASOPRACTICO3.cliente.clienteservicereference.PeliculasRequest();
            inValue.Body = new CASOPRACTICO3.cliente.clienteservicereference.PeliculasRequestBody();
            return ((CASOPRACTICO3.cliente.clienteservicereference.webservSoap)(this)).PeliculasAsync(inValue);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        CASOPRACTICO3.cliente.clienteservicereference.InsertarPeliculaResponse CASOPRACTICO3.cliente.clienteservicereference.webservSoap.InsertarPelicula(CASOPRACTICO3.cliente.clienteservicereference.InsertarPeliculaRequest request) {
            return base.Channel.InsertarPelicula(request);
        }
        
        public bool InsertarPelicula(int id, string nombre, System.DateTime fecha_emision, string descripcion, string comentario, string url) {
            CASOPRACTICO3.cliente.clienteservicereference.InsertarPeliculaRequest inValue = new CASOPRACTICO3.cliente.clienteservicereference.InsertarPeliculaRequest();
            inValue.Body = new CASOPRACTICO3.cliente.clienteservicereference.InsertarPeliculaRequestBody();
            inValue.Body.id = id;
            inValue.Body.nombre = nombre;
            inValue.Body.fecha_emision = fecha_emision;
            inValue.Body.descripcion = descripcion;
            inValue.Body.comentario = comentario;
            inValue.Body.url = url;
            CASOPRACTICO3.cliente.clienteservicereference.InsertarPeliculaResponse retVal = ((CASOPRACTICO3.cliente.clienteservicereference.webservSoap)(this)).InsertarPelicula(inValue);
            return retVal.Body.InsertarPeliculaResult;
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<CASOPRACTICO3.cliente.clienteservicereference.InsertarPeliculaResponse> CASOPRACTICO3.cliente.clienteservicereference.webservSoap.InsertarPeliculaAsync(CASOPRACTICO3.cliente.clienteservicereference.InsertarPeliculaRequest request) {
            return base.Channel.InsertarPeliculaAsync(request);
        }
        
        public System.Threading.Tasks.Task<CASOPRACTICO3.cliente.clienteservicereference.InsertarPeliculaResponse> InsertarPeliculaAsync(int id, string nombre, System.DateTime fecha_emision, string descripcion, string comentario, string url) {
            CASOPRACTICO3.cliente.clienteservicereference.InsertarPeliculaRequest inValue = new CASOPRACTICO3.cliente.clienteservicereference.InsertarPeliculaRequest();
            inValue.Body = new CASOPRACTICO3.cliente.clienteservicereference.InsertarPeliculaRequestBody();
            inValue.Body.id = id;
            inValue.Body.nombre = nombre;
            inValue.Body.fecha_emision = fecha_emision;
            inValue.Body.descripcion = descripcion;
            inValue.Body.comentario = comentario;
            inValue.Body.url = url;
            return ((CASOPRACTICO3.cliente.clienteservicereference.webservSoap)(this)).InsertarPeliculaAsync(inValue);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        CASOPRACTICO3.cliente.clienteservicereference.ModificarPeliculaResponse CASOPRACTICO3.cliente.clienteservicereference.webservSoap.ModificarPelicula(CASOPRACTICO3.cliente.clienteservicereference.ModificarPeliculaRequest request) {
            return base.Channel.ModificarPelicula(request);
        }
        
        public bool ModificarPelicula(int id, string nombre, System.DateTime fecha_emision, string descripcion, string comentario, string url) {
            CASOPRACTICO3.cliente.clienteservicereference.ModificarPeliculaRequest inValue = new CASOPRACTICO3.cliente.clienteservicereference.ModificarPeliculaRequest();
            inValue.Body = new CASOPRACTICO3.cliente.clienteservicereference.ModificarPeliculaRequestBody();
            inValue.Body.id = id;
            inValue.Body.nombre = nombre;
            inValue.Body.fecha_emision = fecha_emision;
            inValue.Body.descripcion = descripcion;
            inValue.Body.comentario = comentario;
            inValue.Body.url = url;
            CASOPRACTICO3.cliente.clienteservicereference.ModificarPeliculaResponse retVal = ((CASOPRACTICO3.cliente.clienteservicereference.webservSoap)(this)).ModificarPelicula(inValue);
            return retVal.Body.ModificarPeliculaResult;
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<CASOPRACTICO3.cliente.clienteservicereference.ModificarPeliculaResponse> CASOPRACTICO3.cliente.clienteservicereference.webservSoap.ModificarPeliculaAsync(CASOPRACTICO3.cliente.clienteservicereference.ModificarPeliculaRequest request) {
            return base.Channel.ModificarPeliculaAsync(request);
        }
        
        public System.Threading.Tasks.Task<CASOPRACTICO3.cliente.clienteservicereference.ModificarPeliculaResponse> ModificarPeliculaAsync(int id, string nombre, System.DateTime fecha_emision, string descripcion, string comentario, string url) {
            CASOPRACTICO3.cliente.clienteservicereference.ModificarPeliculaRequest inValue = new CASOPRACTICO3.cliente.clienteservicereference.ModificarPeliculaRequest();
            inValue.Body = new CASOPRACTICO3.cliente.clienteservicereference.ModificarPeliculaRequestBody();
            inValue.Body.id = id;
            inValue.Body.nombre = nombre;
            inValue.Body.fecha_emision = fecha_emision;
            inValue.Body.descripcion = descripcion;
            inValue.Body.comentario = comentario;
            inValue.Body.url = url;
            return ((CASOPRACTICO3.cliente.clienteservicereference.webservSoap)(this)).ModificarPeliculaAsync(inValue);
        }
        
        public bool EliminarPelicula(int id) {
            return base.Channel.EliminarPelicula(id);
        }
        
        public System.Threading.Tasks.Task<bool> EliminarPeliculaAsync(int id) {
            return base.Channel.EliminarPeliculaAsync(id);
        }
    }
}