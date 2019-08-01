using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Customer_Application.Models
{
    public class Customer
    {
        [Key]
        [Required(ErrorMessage="Customer Id is required !!")]
        public int ? Customer_ID { get; set; } 

        [Required (ErrorMessage="Name is required !!")]
        public string  Name { get; set; }

        [Required(ErrorMessage="Address is required !!")]
        public string Address { get; set; }

        [Required(ErrorMessage ="Mobile no is required !!")]
        public string PhoneNumber { get; set; }

        [DataType(DataType.Date)]
        [Required(ErrorMessage="Date od Birth is required !!")]
        public DateTime ? DOB { get; set; }

        [RegularExpression(@"[a-z0-9!#$%&'*+/=?^_`{|}~-]+(?:\.[a-z0-9!#$%&'*+/=?^_`{|}~-]+)*@(?:[a-z0-9](?:[a-z0-9-]*[a-z0-9])?\.)+[a-z0-9](?:[a-z0-9-]*[a-z0-9])?", ErrorMessage = "Enter a valid email address")]
        public string Email_ID { get; set; }
    }
}