﻿//------------------------------------------------------------------------------
// <auto-generated>
//     此代码由工具生成。
//     运行时版本:4.0.30319.42000
//
//     对此文件的更改可能会导致不正确的行为，并且如果
//     重新生成代码，这些更改将会丢失。
// </auto-generated>
//------------------------------------------------------------------------------

namespace AWSassignment2.Alg2Reference {
    using System.Runtime.Serialization;
    using System;
    using ClassLibrary;

    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="CompositeType", Namespace="http://schemas.datacontract.org/2004/07/")]
    [System.SerializableAttribute()]
    public partial class CompositeType : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private bool BoolValueField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string StringValueField;
        
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
        public bool BoolValue {
            get {
                return this.BoolValueField;
            }
            set {
                if ((this.BoolValueField.Equals(value) != true)) {
                    this.BoolValueField = value;
                    this.RaisePropertyChanged("BoolValue");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string StringValue {
            get {
                return this.StringValueField;
            }
            set {
                if ((object.ReferenceEquals(this.StringValueField, value) != true)) {
                    this.StringValueField = value;
                    this.RaisePropertyChanged("StringValue");
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
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="Allocation", Namespace="http://schemas.datacontract.org/2004/07/AWS_ClassLibrary")]
    [System.SerializableAttribute()]
    public partial class Allocation : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private double EnergyField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int IDField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int ProNoField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private double[] ProcessorFrequencyField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private double RuntimeField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int[][] TableField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int TaskNoField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private double[] pro_runField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private double program_max_durationField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private AWSassignment2.Alg2Reference.Task[] taskField;
        
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
        public double Energy {
            get {
                return this.EnergyField;
            }
            set {
                if ((this.EnergyField.Equals(value) != true)) {
                    this.EnergyField = value;
                    this.RaisePropertyChanged("Energy");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int ID {
            get {
                return this.IDField;
            }
            set {
                if ((this.IDField.Equals(value) != true)) {
                    this.IDField = value;
                    this.RaisePropertyChanged("ID");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int ProNo {
            get {
                return this.ProNoField;
            }
            set {
                if ((this.ProNoField.Equals(value) != true)) {
                    this.ProNoField = value;
                    this.RaisePropertyChanged("ProNo");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public double[] ProcessorFrequency {
            get {
                return this.ProcessorFrequencyField;
            }
            set {
                if ((object.ReferenceEquals(this.ProcessorFrequencyField, value) != true)) {
                    this.ProcessorFrequencyField = value;
                    this.RaisePropertyChanged("ProcessorFrequency");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public double Runtime {
            get {
                return this.RuntimeField;
            }
            set {
                if ((this.RuntimeField.Equals(value) != true)) {
                    this.RuntimeField = value;
                    this.RaisePropertyChanged("Runtime");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int[][] Table {
            get {
                return this.TableField;
            }
            set {
                if ((object.ReferenceEquals(this.TableField, value) != true)) {
                    this.TableField = value;
                    this.RaisePropertyChanged("Table");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int TaskNo {
            get {
                return this.TaskNoField;
            }
            set {
                if ((this.TaskNoField.Equals(value) != true)) {
                    this.TaskNoField = value;
                    this.RaisePropertyChanged("TaskNo");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public double[] pro_run {
            get {
                return this.pro_runField;
            }
            set {
                if ((object.ReferenceEquals(this.pro_runField, value) != true)) {
                    this.pro_runField = value;
                    this.RaisePropertyChanged("pro_run");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public double program_max_duration {
            get {
                return this.program_max_durationField;
            }
            set {
                if ((this.program_max_durationField.Equals(value) != true)) {
                    this.program_max_durationField = value;
                    this.RaisePropertyChanged("program_max_duration");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public AWSassignment2.Alg2Reference.Task[] task {
            get {
                return this.taskField;
            }
            set {
                if ((object.ReferenceEquals(this.taskField, value) != true)) {
                    this.taskField = value;
                    this.RaisePropertyChanged("task");
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
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="Task", Namespace="http://schemas.datacontract.org/2004/07/AWS_ClassLibrary")]
    [System.SerializableAttribute()]
    public partial class Task : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int coef0Field;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int coef1Field;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int coef2Field;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private double energyField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int idField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int processorIDField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private double processor_freField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int ref_freField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private double runtimeField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private double runtime_underProcessorField;
        
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
        public int coef0 {
            get {
                return this.coef0Field;
            }
            set {
                if ((this.coef0Field.Equals(value) != true)) {
                    this.coef0Field = value;
                    this.RaisePropertyChanged("coef0");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int coef1 {
            get {
                return this.coef1Field;
            }
            set {
                if ((this.coef1Field.Equals(value) != true)) {
                    this.coef1Field = value;
                    this.RaisePropertyChanged("coef1");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int coef2 {
            get {
                return this.coef2Field;
            }
            set {
                if ((this.coef2Field.Equals(value) != true)) {
                    this.coef2Field = value;
                    this.RaisePropertyChanged("coef2");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public double energy {
            get {
                return this.energyField;
            }
            set {
                if ((this.energyField.Equals(value) != true)) {
                    this.energyField = value;
                    this.RaisePropertyChanged("energy");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
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
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int processorID {
            get {
                return this.processorIDField;
            }
            set {
                if ((this.processorIDField.Equals(value) != true)) {
                    this.processorIDField = value;
                    this.RaisePropertyChanged("processorID");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public double processor_fre {
            get {
                return this.processor_freField;
            }
            set {
                if ((this.processor_freField.Equals(value) != true)) {
                    this.processor_freField = value;
                    this.RaisePropertyChanged("processor_fre");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int ref_fre {
            get {
                return this.ref_freField;
            }
            set {
                if ((this.ref_freField.Equals(value) != true)) {
                    this.ref_freField = value;
                    this.RaisePropertyChanged("ref_fre");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public double runtime {
            get {
                return this.runtimeField;
            }
            set {
                if ((this.runtimeField.Equals(value) != true)) {
                    this.runtimeField = value;
                    this.RaisePropertyChanged("runtime");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public double runtime_underProcessor {
            get {
                return this.runtime_underProcessorField;
            }
            set {
                if ((this.runtime_underProcessorField.Equals(value) != true)) {
                    this.runtime_underProcessorField = value;
                    this.RaisePropertyChanged("runtime_underProcessor");
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
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="Alg2Reference.IService")]
    public interface IService {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService/GetData", ReplyAction="http://tempuri.org/IService/GetDataResponse")]
        string GetData(int value);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService/GetData", ReplyAction="http://tempuri.org/IService/GetDataResponse")]
        System.Threading.Tasks.Task<string> GetDataAsync(int value);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService/GetDataUsingDataContract", ReplyAction="http://tempuri.org/IService/GetDataUsingDataContractResponse")]
        AWSassignment2.Alg2Reference.CompositeType GetDataUsingDataContract(AWSassignment2.Alg2Reference.CompositeType composite);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService/GetDataUsingDataContract", ReplyAction="http://tempuri.org/IService/GetDataUsingDataContractResponse")]
        System.Threading.Tasks.Task<AWSassignment2.Alg2Reference.CompositeType> GetDataUsingDataContractAsync(AWSassignment2.Alg2Reference.CompositeType composite);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService/getAllocation", ReplyAction="http://tempuri.org/IService/getAllocationResponse")]
        AWSassignment2.Alg2Reference.Allocation getAllocation(string TextX, AWSassignment2.Alg2Reference.Allocation allocation, double[][] runtimeTable);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService/getAllocation", ReplyAction="http://tempuri.org/IService/getAllocationResponse")]
        System.Threading.Tasks.Task<AWSassignment2.Alg2Reference.Allocation> getAllocationAsync(string TextX, AWSassignment2.Alg2Reference.Allocation allocation, double[][] runtimeTable);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IServiceChannel : AWSassignment2.Alg2Reference.IService, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class ServiceClient : System.ServiceModel.ClientBase<AWSassignment2.Alg2Reference.IService>, AWSassignment2.Alg2Reference.IService {
        
        public ServiceClient() {
        }
        
        public ServiceClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public ServiceClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public ServiceClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public ServiceClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public string GetData(int value) {
            return base.Channel.GetData(value);
        }
        
        public System.Threading.Tasks.Task<string> GetDataAsync(int value) {
            return base.Channel.GetDataAsync(value);
        }
        
        public AWSassignment2.Alg2Reference.CompositeType GetDataUsingDataContract(AWSassignment2.Alg2Reference.CompositeType composite) {
            return base.Channel.GetDataUsingDataContract(composite);
        }
        
        public System.Threading.Tasks.Task<AWSassignment2.Alg2Reference.CompositeType> GetDataUsingDataContractAsync(AWSassignment2.Alg2Reference.CompositeType composite) {
            return base.Channel.GetDataUsingDataContractAsync(composite);
        }
        
        public AWSassignment2.Alg2Reference.Allocation getAllocation(string TextX, AWSassignment2.Alg2Reference.Allocation allocation, double[][] runtimeTable) {
            return base.Channel.getAllocation(TextX, allocation, runtimeTable);
        }
        
        public System.Threading.Tasks.Task<AWSassignment2.Alg2Reference.Allocation> getAllocationAsync(string TextX, AWSassignment2.Alg2Reference.Allocation allocation, double[][] runtimeTable) {
            return base.Channel.getAllocationAsync(TextX, allocation, runtimeTable);
        }

        internal ClassLibrary.Allocation getAllocation(string source, ClassLibrary.Allocation allocation, double[][] runtimetable)
        {
            throw new NotImplementedException();
        }
    }
}
