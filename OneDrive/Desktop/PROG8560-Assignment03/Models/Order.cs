using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace StonesShop.Models
{
    public partial class Order
    {
        public Order()
        {
            OrderProduct = new HashSet<OrderProduct>();
        }

        public int OrderId { get; set; }
        public int CustomerId { get; set; }
        public DateTime DateTimeOrdered { get; set; }
        public bool Pickup { get; set; }
        public string DriverCode { get; set; }
        public string Comments { get; set; }
        public bool OrderComplete { get; set; }

        public virtual Customer Customer { get; set; }
        public virtual Driver DriverCodeNavigation { get; set; }
        public virtual ICollection<OrderProduct> OrderProduct { get; set; }
    }
}
