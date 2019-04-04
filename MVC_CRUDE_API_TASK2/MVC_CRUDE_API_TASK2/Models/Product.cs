using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace MVC_CRUDE_API_TASK2.Models
{
    public class Product

    {
        [Key]

        public int ProductId { get; set; }

        [Required (ErrorMessage = "Please Enter Your Product Name")]

        public string Name { get; set; }



        public float Price { get; set; }

        //Relationship

        public ICollection<Sales> Sales { get; set; }
    }
}