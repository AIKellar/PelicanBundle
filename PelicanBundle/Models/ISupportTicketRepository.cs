using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PelicanBundle.Models
{
    public interface ISupportTicketRepository
    {
        IEnumerable<SupportTicket> Tickets { get; }

        void saveTicket(SupportTicket Ticket);
    }
}
