using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace MyWCFLib
{
    // REMARQUE : vous pouvez utiliser la commande Renommer du menu Refactoriser pour changer le nom de classe "Service1" à la fois dans le code et le fichier de configuration.
    public class Service1 : IService1
    {
        public int CreateCategory(CategoryModel model)
        {
            Category category = new Category();
            using (ModelContainer context = new ModelContainer())
            {
                category.Name = model.Name;

                context.CategorySet.Add(category);
                context.SaveChanges();

            }
            return category.CategoryId;
        }

        public List<Category> GetAllCategory()
        {

            List<Category> _categories = new List<Category>();
            using (ModelContainer context = new ModelContainer())
            {
                List<Category> categories = context.CategorySet.ToList<Category>();
                foreach (Category category in categories)
                {
                    Category tmp = new Category();
                    tmp.Name = category.Name;
                    _categories.Add(tmp);
                }                
            }
            return _categories;
        }
    

        public int CreateProduct(ProductModel model)
        {
            Product product = new Product();
            using (ModelContainer context = new ModelContainer())
            {
                product.Name = model.Name;
                product.Detail = model.Detail;
                product.Price = model.Price;
                product.Stock = model.Stock;
                product.Sold = model.Sold;
                product.Restock = model.Restock;
                product.CategoryCategoryId = model.CategoryCategoryId;

                context.ProductSet.Add(product);
                context.SaveChanges();
            }
            return product.ProductId;
        }

        public ProductModel GetProduct(int id)
        {
            ProductModel product = new ProductModel();
            using (ModelContainer context = new ModelContainer())
            {
                var tmp = context.ProductSet.Where(p => p.ProductId == id).First();

                product.Name = tmp.Name;
                product.Detail = tmp.Detail;
                product.Price = tmp.Price;
                product.Stock = tmp.Stock;
                product.Sold = tmp.Sold;
                product.Restock = tmp.Restock;
                product.CategoryCategoryId = tmp.CategoryCategoryId;
            }
            return product;
        }

    }
}
