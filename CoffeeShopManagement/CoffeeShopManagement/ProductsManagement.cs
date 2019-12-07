using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoffeeShopManagement
{
    public class ProductsManagement
    {
        public Product[] GetProducts()
        {
            var db = new MyDatabaseEntities();
            return db.Products.ToArray();
        }
        public void AddProduct(string name, string size, int price)
        {
            var addProduct = new Product();
            addProduct.Name = name;
            addProduct.Size = size;
            addProduct.Price = price;

            var db = new MyDatabaseEntities();
            db.Products.Add(addProduct);
            db.SaveChanges();
        }
        public void EditProduct(int id, string name, string size, int price)
        {
            var db = new MyDatabaseEntities();
            var editProduct = db.Products.Find(id);
            editProduct.Name = name;
            editProduct.Size = size;
            editProduct.Price = price;
            db.Entry(editProduct).State = System.Data.Entity.EntityState.Modified;
            db.SaveChanges();
        }
        public void DeleteProduct(int id)
        {
            var db = new MyDatabaseEntities();
            var deleteProduct = db.Products.Find(id);
            db.Products.Remove(deleteProduct);
            db.SaveChanges();
        }
        public Product GetProduct(int id)
        {
            var db = new MyDatabaseEntities();
            return db.Products.Find(id);
        }
    }
}
