namespace EfektKontrol.Data.Models
{
    using System;

    using EfektKontrol.Data.Common.Models;

    public class Reply : BaseDeletableModel<int>
    {
        public int OrderId { get; set; }

        public virtual Order Order { get; set; }

        public decimal? Price { get; set; }

        public DateTime? ExecutionDate { get; set; }

        public string ReplyText { get; set; }
    }
}
