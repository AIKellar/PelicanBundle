using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Mvc.ModelBinding;
namespace PelicanBundle.Models
{
    public class Order
    {
        [BindNever]
 public int OrderID { get; set; }
        [BindNever]
        public ICollection<CartLine> Lines { get; set; }

        [BindNever]
        public bool Shipped { get; set; }
        [Required(ErrorMessage = "Please enter a name")]
        public string Name { get; set; }
        [Required(ErrorMessage = "Please enter your billing address")]
        public string Line1 { get; set; }
        [Required(ErrorMessage = "Please enter a city name")]
        public string City { get; set; }
        [Required(ErrorMessage = "Please enter a state name")]
        public string State { get; set; }
        [Required(ErrorMessage = "Please enter your zip code")]
        public string Zip { get; set; }
        [Required(ErrorMessage = "Please enter a card number")]
        [DataType(DataType.CreditCard)]

        public long? CardNumber { get; set; }
        [Required(ErrorMessage = "Please enter the three digit code on your card")]

        public int? SecurityCode { get; set; }
        [Required(ErrorMessage = "Please enter your cards expiration date")]

        public string Expiration { get; set; }
        [Required(ErrorMessage = "Please enter an email to send your keys to")]

        public string Email { get; set; }
    }
}