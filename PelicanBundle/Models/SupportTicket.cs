using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Mvc.ModelBinding;

namespace PelicanBundle.Models
{
    public class SupportTicket
    {
        [Key]
        public int TicketID { get; set; }

        public string ReasonCode { get; set; }

        public string ProblemDescription { get; set; }

        public string Email { get; set; }
    }
}
