using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using System.Linq;
using System.Net;
using System.Web.Http;
using System.Web.Http.Description;
using MVC_CRUDE_API_TASK2.Models;
using MVC_CRUDE_API_TASK2.SalesViewModel;

namespace MVC_CRUDE_API_TASK2.Controllers.API
{
    public class SalesController : ApiController
    {
        private CodeFContext db = new CodeFContext();

        public SaleViewModal NP = new SaleViewModal();

        // GET: api/Sales

        //public IQueryable<Sales> GetSales()
        //{
        //    return db.Sales;
        //}

             public IHttpActionResult GetSales()
        {
            //var productsolds = db.ProductSolds.ToList();

            List<SaleViewModal> List = db.sales.Select(x => new SaleViewModal
            {
                SaleId = x.SaleId,
                CustomerId = x.Customer.CustomerId,
                CustomerName = x.Customer.Name,
                ProductId = x.Product.ProductId,
                ProductName = x.Product.Name,
                StoreId = x.Store.StoreId,
                StoreName = x.Store.Name,
                 Date = x.Date


            }).ToList();
            return Ok(List);
        }


        // GET: api/Sales/5
        [ResponseType(typeof(Sales))]
        public IHttpActionResult GetSales(int id)
        {
            Sales sales = db.sales.Find(id);
            if (sales == null)
            {
                return NotFound();
            }

            return Ok(sales);
        }

        // PUT: api/Sales/5
        [ResponseType(typeof(void))]
        public IHttpActionResult PutSales(int id, Sales sales)
        {

           
            Sales salerecord = sales;

            if (!ModelState.IsValid)

                //throw new HttpResponseException(HttpStatusCode.BadRequest);
                return BadRequest();

            var SaleObj = db.sales.SingleOrDefault(c => c.SaleId == id);
                if (SaleObj == null)
                    throw new HttpResponseException(HttpStatusCode.NotFound);
                SaleObj.CustomerId = salerecord.CustomerId;
                SaleObj.ProductId = salerecord.ProductId;
                SaleObj.StoreId = salerecord.StoreId;
                SaleObj.Date = salerecord.Date;
                db.SaveChanges();

            return Ok();
            

                //}

                //if (id != sales.SaleId)
                //{
                //    return BadRequest();
                //}

                //db.Entry(sales).State = EntityState.Modified;

                //try
                //{
                //    db.SaveChanges();
                //}
                //catch (DbUpdateConcurrencyException)
                //{
                //    if (!SalesExists(id))
                //    {
                //        return NotFound();
                //    }
                //    else
                //    {
                //        throw;
                //    }
            //}

            //return StatusCode(HttpStatusCode.NoContent);
        }

        // POST: api/Sales
        [ResponseType(typeof(Sales))]
        public IHttpActionResult PostSales(Sales sales)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            db.sales.Add(sales);
            db.SaveChanges();

            return CreatedAtRoute("DefaultApi", new { id = sales.SaleId }, sales);
        }

        // DELETE: api/Sales/5
        [ResponseType(typeof(Sales))]
        public IHttpActionResult DeleteSales(int id)
        {
            Sales sales = db.sales.Find(id);
            if (sales == null)
            {
                return NotFound();
            }

            db.sales.Remove(sales);
            db.SaveChanges();

            return Ok(sales);
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }

        private bool SalesExists(int id)
        {
            return db.sales.Count(e => e.SaleId == id) > 0;
        }
    }
}