using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace MyWCFLib
{
    // REMARQUE : vous pouvez utiliser la commande Renommer du menu Refactoriser pour changer le nom d'interface "IService1" à la fois dans le code et le fichier de configuration.
    [ServiceContract]
    public interface IService1
    {
        [OperationContract]
        List<Category> GetAllCategory();

        [OperationContract]
        ProductModel GetProduct(int id);

        [OperationContract]
        int CreateProduct(ProductModel model);

        [OperationContract]
        int CreateCategory(CategoryModel model);

        // TODO: ajoutez vos opérations de service ici
    }

    // Utilisez un contrat de données comme indiqué dans l'exemple ci-après pour ajouter les types composites aux opérations de service.
    // Vous pouvez ajouter des fichiers XSD au projet. Une fois le projet généré, vous pouvez utiliser directement les types de données qui y sont définis, avec l'espace de noms "MyWCFLib.ContractType".

    [DataContract]
    public class CategoryModel
    {
        string _name;

        [DataMember]
        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }
    }
        [DataContract]
    public class ProductModel
    {
        string _name;
        string _detail;
        int _price;
        int _stock;
        int _sold;
        int _restock;
        int _categoryCategoryId;


        [DataMember]
        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }

        [DataMember]
        public string Detail
        {
            get { return _detail; }
            set { _detail = value; }
        }


        [DataMember]
        public int Price
        {
            get { return _price; }
            set { _price = value; }
        }


        [DataMember]
        public int Stock
        {
            get { return _stock; }
            set { _stock = value; }
        }


        [DataMember]
        public int Sold
        {
            get { return _sold; }
            set { _sold = value; }
        }


        [DataMember]
        public int Restock
        {
            get { return _restock; }
            set { _restock = value; }
        }

        [DataMember]
        public int CategoryCategoryId
        {
            get { return _categoryCategoryId; }
            set { _categoryCategoryId = value; }
        }
    }
}
