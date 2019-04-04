using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace MVC_CRUDE_API_TASK2.Models
{
    public class Store
    {
        [Key]

        public int StoreId { get; set; }

        [Required (ErrorMessage = "Please Enter Store Name")]
        public string Name { get; set; }

        [Required(ErrorMessage = "Please Enter Valid Store Address")]

        public string Address { get; set; }

        //Relationship

        public ICollection<Sales> Sales { get; set; }

    }
}