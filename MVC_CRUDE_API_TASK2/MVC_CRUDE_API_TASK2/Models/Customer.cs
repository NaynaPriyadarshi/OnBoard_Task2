using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace MVC_CRUDE_API_TASK2.Models
{
    public class Customer
    {
        [Key]

        public int CustomerId { get; set; }

        [Required(ErrorMessage = "Please Enter Your Name")]

        public string Name { get; set; }

        [Required(ErrorMessage = "Please Enter Your Address")]

        public string  Address { get; set; }

        //Relationship

        public ICollection<Sales> Sales { get; set; }
        
    }
}