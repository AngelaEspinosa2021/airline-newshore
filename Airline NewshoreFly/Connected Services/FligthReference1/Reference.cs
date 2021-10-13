﻿//------------------------------------------------------------------------------
// <auto-generated>
//     Este código fue generado por una herramienta.
//     Versión de runtime:4.0.30319.42000
//
//     Los cambios en este archivo podrían causar un comportamiento incorrecto y se perderán si
//     se vuelve a generar el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Airline_NewshoreFly.FligthReference1 {
    using System.Runtime.Serialization;
    using System;
    
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="FligthDTO", Namespace="http://schemas.datacontract.org/2004/07/Airline_NewshoreFly.Models")]
    [System.SerializableAttribute()]
    public partial class FligthDTO : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string ArrivalStationField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string CurrencyField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private System.DateTime DepartureDateField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string DepartureStationField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string FligthTimeField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private long IdField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private decimal PriceField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string TransportField;
        
        [global::System.ComponentModel.BrowsableAttribute(false)]
        public System.Runtime.Serialization.ExtensionDataObject ExtensionData {
            get {
                return this.extensionDataField;
            }
            set {
                this.extensionDataField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string ArrivalStation {
            get {
                return this.ArrivalStationField;
            }
            set {
                if ((object.ReferenceEquals(this.ArrivalStationField, value) != true)) {
                    this.ArrivalStationField = value;
                    this.RaisePropertyChanged("ArrivalStation");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Currency {
            get {
                return this.CurrencyField;
            }
            set {
                if ((object.ReferenceEquals(this.CurrencyField, value) != true)) {
                    this.CurrencyField = value;
                    this.RaisePropertyChanged("Currency");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public System.DateTime DepartureDate {
            get {
                return this.DepartureDateField;
            }
            set {
                if ((this.DepartureDateField.Equals(value) != true)) {
                    this.DepartureDateField = value;
                    this.RaisePropertyChanged("DepartureDate");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string DepartureStation {
            get {
                return this.DepartureStationField;
            }
            set {
                if ((object.ReferenceEquals(this.DepartureStationField, value) != true)) {
                    this.DepartureStationField = value;
                    this.RaisePropertyChanged("DepartureStation");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string FligthTime {
            get {
                return this.FligthTimeField;
            }
            set {
                if ((object.ReferenceEquals(this.FligthTimeField, value) != true)) {
                    this.FligthTimeField = value;
                    this.RaisePropertyChanged("FligthTime");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public long Id {
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
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public decimal Price {
            get {
                return this.PriceField;
            }
            set {
                if ((this.PriceField.Equals(value) != true)) {
                    this.PriceField = value;
                    this.RaisePropertyChanged("Price");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Transport {
            get {
                return this.TransportField;
            }
            set {
                if ((object.ReferenceEquals(this.TransportField, value) != true)) {
                    this.TransportField = value;
                    this.RaisePropertyChanged("Transport");
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
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="FligthReference1.IFligthService")]
    public interface IFligthService {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IFligthService/FindFligths", ReplyAction="http://tempuri.org/IFligthService/FindFligthsResponse")]
        Airline_NewshoreFly.FligthReference1.FligthDTO[] FindFligths(string origen, string destino, System.DateTime fechaLlegada);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IFligthService/FindFligths", ReplyAction="http://tempuri.org/IFligthService/FindFligthsResponse")]
        System.Threading.Tasks.Task<Airline_NewshoreFly.FligthReference1.FligthDTO[]> FindFligthsAsync(string origen, string destino, System.DateTime fechaLlegada);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IFligthServiceChannel : Airline_NewshoreFly.FligthReference1.IFligthService, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class FligthServiceClient : System.ServiceModel.ClientBase<Airline_NewshoreFly.FligthReference1.IFligthService>, Airline_NewshoreFly.FligthReference1.IFligthService {
        
        public FligthServiceClient() {
        }
        
        public FligthServiceClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public FligthServiceClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public FligthServiceClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public FligthServiceClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public Airline_NewshoreFly.FligthReference1.FligthDTO[] FindFligths(string origen, string destino, System.DateTime fechaLlegada) {
            return base.Channel.FindFligths(origen, destino, fechaLlegada);
        }
        
        public System.Threading.Tasks.Task<Airline_NewshoreFly.FligthReference1.FligthDTO[]> FindFligthsAsync(string origen, string destino, System.DateTime fechaLlegada) {
            return base.Channel.FindFligthsAsync(origen, destino, fechaLlegada);
        }
    }
}