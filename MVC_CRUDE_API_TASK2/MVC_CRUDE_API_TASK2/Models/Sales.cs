using System;
using System.ComponentModel.DataAnnotations;

namespace MVC_CRUDE_API_TASK2.Models
{
    public class Sales
    {

        [Key]
        public int SaleId { get; set; }

        //Relationship 

        public Customer Customer { get; set; }

        public int CustomerId { get; set; }

        public Product Product { get; set; }

        public int ProductId { get; set; }

        public Store Store { get; set; }

        public int StoreId { get; set; }


        [DataType(DataType.Date)]
        public DateTime Date { get; set; }
        


    }
}