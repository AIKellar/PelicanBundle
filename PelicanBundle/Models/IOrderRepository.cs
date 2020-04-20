using System.Collections.Generic;
namespace PelicanBundle.Models
{
    public interface IOrderRepository
    {
        IEnumerable<Order> Orders { get; }
        void SaveOrder(Order order);
    }
}
