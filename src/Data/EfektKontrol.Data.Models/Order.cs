namespace EfektKontrol.Data.Models
{
    using System;
    using System.Collections.Generic;
    using System.Text;

    using EfektKontrol.Data.Common.Models;
    using EfektKontrol.Data.Models.Enumerations;

    public class Order : BaseDeletableModel<int>
    {
        public Order()
        {
            this.Replies = new HashSet<Reply>();
            this.Services = new HashSet<Service>();
        }

        public string CreatorId { get; set; }

        public virtual ApplicationUser Creator { get; set; }

        public string Adress { get; set; }

        public PaymentMethod PaymentMethod { get; set; }

        public string Description { get; set; }

        public Status Status { get; set; }

        public string DocumentUrl { get; set; }

        public virtual ICollection<Service> Services { get; set; }

        public virtual ICollection<Reply> Replies { get; set; }
    }
}
