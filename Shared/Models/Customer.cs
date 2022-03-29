using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlazorCRUD.Shared.Models
{
    public class Customer
    {
        public int Id { get; set; }

        [Display(Name="Customer Name")]
        public string Name { get; set; }

        [Display(Name = "Customer Category")]
        public string Category { get; set; }

        [Display(Name = "Customer Email")]
        public string EmailAddress { get; set; }

        [Display(Name = "Customer Address")]
        public string Address { get; set; }
    }
}
