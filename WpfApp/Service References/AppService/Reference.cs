﻿//------------------------------------------------------------------------------
// <auto-generated>
//     Ce code a été généré par un outil.
//     Version du runtime :4.0.30319.42000
//
//     Les modifications apportées à ce fichier peuvent provoquer un comportement incorrect et seront perdues si
//     le code est régénéré.
// </auto-generated>
//------------------------------------------------------------------------------

namespace WpfApp.AppService {
    using System.Runtime.Serialization;
    using System;
    
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="ProductModel", Namespace="http://schemas.datacontract.org/2004/07/MyWCFLib")]
    [System.SerializableAttribute()]
    public partial class ProductModel : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int CategoryCategoryIdField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string DetailField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string NameField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int PriceField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int RestockField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int SoldField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int StockField;
        
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
        public int CategoryCategoryId {
            get {
                return this.CategoryCategoryIdField;
            }
            set {
                if ((this.CategoryCategoryIdField.Equals(value) != true)) {
                    this.CategoryCategoryIdField = value;
                    this.RaisePropertyChanged("CategoryCategoryId");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Detail {
            get {
                return this.DetailField;
            }
            set {
                if ((object.ReferenceEquals(this.DetailField, value) != true)) {
                    this.DetailField = value;
                    this.RaisePropertyChanged("Detail");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Name {
            get {
                return this.NameField;
            }
            set {
                if ((object.ReferenceEquals(this.NameField, value) != true)) {
                    this.NameField = value;
                    this.RaisePropertyChanged("Name");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int Price {
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
        public int Restock {
            get {
                return this.RestockField;
            }
            set {
                if ((this.RestockField.Equals(value) != true)) {
                    this.RestockField = value;
                    this.RaisePropertyChanged("Restock");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int Sold {
            get {
                return this.SoldField;
            }
            set {
                if ((this.SoldField.Equals(value) != true)) {
                    this.SoldField = value;
                    this.RaisePropertyChanged("Sold");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int Stock {
            get {
                return this.StockField;
            }
            set {
                if ((this.StockField.Equals(value) != true)) {
                    this.StockField = value;
                    this.RaisePropertyChanged("Stock");
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
    [System.Runtime.Serialization.DataContractAttribute(Name="CategoryModel", Namespace="http://schemas.datacontract.org/2004/07/MyWCFLib")]
    [System.SerializableAttribute()]
    public partial class CategoryModel : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string NameField;
        
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
        public string Name {
            get {
                return this.NameField;
            }
            set {
                if ((object.ReferenceEquals(this.NameField, value) != true)) {
                    this.NameField = value;
                    this.RaisePropertyChanged("Name");
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
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="AppService.IService1")]
    public interface IService1 {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/GetProduct", ReplyAction="http://tempuri.org/IService1/GetProductResponse")]
        WpfApp.AppService.ProductModel GetProduct(int id);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/GetProduct", ReplyAction="http://tempuri.org/IService1/GetProductResponse")]
        System.Threading.Tasks.Task<WpfApp.AppService.ProductModel> GetProductAsync(int id);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/CreateProduct", ReplyAction="http://tempuri.org/IService1/CreateProductResponse")]
        int CreateProduct(WpfApp.AppService.ProductModel model);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/CreateProduct", ReplyAction="http://tempuri.org/IService1/CreateProductResponse")]
        System.Threading.Tasks.Task<int> CreateProductAsync(WpfApp.AppService.ProductModel model);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/CreateCategory", ReplyAction="http://tempuri.org/IService1/CreateCategoryResponse")]
        int CreateCategory(WpfApp.AppService.CategoryModel model);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/CreateCategory", ReplyAction="http://tempuri.org/IService1/CreateCategoryResponse")]
        System.Threading.Tasks.Task<int> CreateCategoryAsync(WpfApp.AppService.CategoryModel model);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IService1Channel : WpfApp.AppService.IService1, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class Service1Client : System.ServiceModel.ClientBase<WpfApp.AppService.IService1>, WpfApp.AppService.IService1 {
        
        public Service1Client() {
        }
        
        public Service1Client(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public Service1Client(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public Service1Client(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public Service1Client(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public WpfApp.AppService.ProductModel GetProduct(int id) {
            return base.Channel.GetProduct(id);
        }
        
        public System.Threading.Tasks.Task<WpfApp.AppService.ProductModel> GetProductAsync(int id) {
            return base.Channel.GetProductAsync(id);
        }
        
        public int CreateProduct(WpfApp.AppService.ProductModel model) {
            return base.Channel.CreateProduct(model);
        }
        
        public System.Threading.Tasks.Task<int> CreateProductAsync(WpfApp.AppService.ProductModel model) {
            return base.Channel.CreateProductAsync(model);
        }
        
        public int CreateCategory(WpfApp.AppService.CategoryModel model) {
            return base.Channel.CreateCategory(model);
        }
        
        public System.Threading.Tasks.Task<int> CreateCategoryAsync(WpfApp.AppService.CategoryModel model) {
            return base.Channel.CreateCategoryAsync(model);
        }
    }
}
