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
            var db = new DataEntities();
            return db.Products.ToArray();
        }
        public void AddProduct(string name, string size, int price)
        {
            var addProduct = new Product();
            addProduct.Name = name;
            addProduct.Size = size;
            addProduct.Price = price;

            var db = new DataEntities();
            db.Products.Add(addProduct);
            db.SaveChanges();
        }
        public void EditProduct(int id, string name, string size, int price)
        {
            var db = new DataEntities();
            var editProduct = db.Products.Find(id);
            editProduct.Name = name;
            editProduct.Size = size;
            editProduct.Price = price;
            db.Entry(editProduct).State = System.Data.Entity.EntityState.Modified;
            db.SaveChanges();
        }
        public void DeleteProduct(int id)
        {
            var db = new DataEntities();
            var deleteProduct = db.Products.Find(id);
            db.Products.Remove(deleteProduct);
            db.SaveChanges();
        }
        public Product GetProduct(int id)
        {
            var db = new DataEntities();
            return db.Products.Find(id);
        }
        public order[] GetOrders()
        {
            var db = new DataEntities();
            return db.orders.ToArray();
        }
        public order GetOrder(int id)
        {
            var db = new DataEntities();
            return db.orders.Find(id);
        }
        public void AddOrder(string name, string size, int price, int quantity)
        {
            var addOrder = new order();
            addOrder.name = name;
            addOrder.size = size;
            addOrder.price = price;
            addOrder.quantity = quantity;

            var db = new DataEntities();
            db.orders.Add(addOrder);
            db.SaveChanges();
        }
        public void DeleteProductsOrder(int id)
        {
            var db = new DataEntities();
            var deleteOrder = db.orders.Find(id);
            db.orders.Remove(deleteOrder);
            db.SaveChanges();
        }
        public history[] GetHistories()
        {
            var db = new DataEntities();
            return db.histories.ToArray();
        }
        public int AddHistory(int total)
        {
            var addHistory = new history();
            DateTime now = DateTime.Now;            
            addHistory.dateofsales = now;
            addHistory.total = total;

            var db = new DataEntities();
            db.histories.Add(addHistory);
            db.SaveChanges();
            return addHistory.id;
        }
        public int AddHistory()
        {
            var addHistory = new history();
            DateTime now = DateTime.Now;
            addHistory.dateofsales = now;
            var db = new DataEntities();
            db.histories.Add(addHistory);
            db.SaveChanges();
            return addHistory.id;
        }
        public int index()
        {
            var db = new DataEntities();
            return db.histories.Count();
        }
        public void DeleteHistory(int id)
        {
            var db = new DataEntities();
            var deleteHistory = db.histories.Find(id);
            db.histories.Remove(deleteHistory);
            db.SaveChanges();
        }
        public bill[] GetBills()
        {
            var db = new DataEntities();
            return db.bills.ToArray();
        }       
        public void AddBills(string name, string size, int price, int quantity)
        {           
            var addBills = new bill();
            addBills.bill_id = index();
            addBills.name = name;
            addBills.size = size;
            addBills.price = price;
            addBills.quantity = quantity;

            var db = new DataEntities();
            db.bills.Add(addBills);
            db.SaveChanges();
        }      
    }
}
