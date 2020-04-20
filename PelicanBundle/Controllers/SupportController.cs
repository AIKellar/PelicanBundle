using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using PelicanBundle.Models;
using PelicanBundle.Models.ViewModels;
using Microsoft.AspNetCore.Authorization;

namespace PelicanBundle.Controllers
{
    public class SupportController : Controller
    {
        private ISupportTicketRepository repository;
        public SupportController(ISupportTicketRepository repo)
        {
            repository = repo;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Create(SupportTicket Ticket)
        {
            repository.saveTicket(Ticket);
            TempData["Email"] = Ticket.Email.ToString();
            return RedirectToAction("Submitted");
        }

        public IActionResult Submitted()
        {

            return View();
        }
    }
}
