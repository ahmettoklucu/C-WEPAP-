using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;
using System.Web.Mvc;
using WebApplication1.Models;

namespace WebApplication1.Controllers
{
    
    public class ProductController : ApiController
    {
        // GET: Product
        DataContext db = new DataContext();

        public IEnumerable<Product> Get()// Api/Product sayfası açıldığında bütün ürünler listelenecek
        {
            var product = db.Product.ToList();
            return product;
        }
        public IHttpActionResult Get(int id)
        {
            var product = db.Product.Find(id);
            if (product == null)
            {
                return NotFound();//404 kodu döndürecek(Bulunamadı hatası)
            }
            else
            {
                return Ok(product);//200 kodu döndürecek(işlem başarılı)
            }
        }
        public IHttpActionResult Delete(int id)
        {
            var product = db.Product.Find(id);
            if (product == null)
            {
                return NotFound();
            }
            else
            {

                db.Product.Remove(product);
                //product.IsDelete = true;
                db.SaveChanges();
                return Ok("Web Apiden Ürün Silme Bşarılı");
            }
        }
        public IHttpActionResult Post([FromBody]Product product)
        {
            db.Product.Add(product);
            db.SaveChanges();
            return Ok();
        }
        public IHttpActionResult Put([FromBody]Product product)
        {
            var editproduct = db.Product.Find(product.Id);
            if (editproduct != null)
            {
                editproduct.Name = product.Name;
                editproduct.Description = product.Description;
                editproduct.Price = product.Price;
                editproduct.Status = product.Status;
                db.SaveChanges();
                return Ok();
            }
            else
            {
                return NotFound();
            }
            
        }
    }
}