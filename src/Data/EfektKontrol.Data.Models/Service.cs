namespace EfektKontrol.Data.Models
{
    using System.Collections.Generic;

    using EfektKontrol.Data.Common.Models;

    public class Service : BaseDeletableModel<int>
    {
        public Service()
        {
            this.Orders = new HashSet<Order>();
        }

        public string Description { get; set; }

        public virtual ICollection<Order> Orders { get; set; }
    }
}
