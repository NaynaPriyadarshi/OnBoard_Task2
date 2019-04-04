using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace MVC_CRUDE_API_TASK2.SalesViewModel
{
    public class SaleViewModal
    {
        [Key]
        public int SaleId { get; set; }


        public int CustomerId { get; set; }

        public int ProductId { get; set; }

        public int StoreId { get; set; }


        [DataType(DataType.Date)]
        public DateTime Date { get; set; }

        //Custom Class

        public string CustomerName { get; set; }
        public string ProductName { get; set; }
        public string StoreName { get; set; }




    }
}