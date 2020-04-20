using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PelicanBundle.Models
{
    public class EFSupportTicketRepository : ISupportTicketRepository
    {
        private ApplicationDbContext context;
        public EFSupportTicketRepository(ApplicationDbContext ctx)
        {
            context = ctx;
        }

        public void saveTicket(SupportTicket Ticket)
        {
            if (Ticket.TicketID == 0)
            {
                context.Tickets.Add(Ticket);
            }
            else
            {
                SupportTicket dbEntry = context.Tickets
                .FirstOrDefault(p => p.TicketID == Ticket.TicketID);
                if (dbEntry != null)
                {
                    dbEntry.ReasonCode = Ticket.ReasonCode;
                    dbEntry.ProblemDescription = Ticket.ProblemDescription;
                    dbEntry.Email = Ticket.Email;
                }
            }
            context.SaveChanges();
        }

        public IEnumerable<SupportTicket> Tickets => context.Tickets;
    }
}
