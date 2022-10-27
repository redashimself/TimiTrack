using System;

namespace TimiTrack.Products;
using Volo.Abp.Domain.Entities.Auditing;

public class Items
{
    public class Product : AuditedAggregateRoot<Guid>
    {
        public string Name { get; set; }

        public ProductType Type { get; set; }

        public DateTime ScrapeDate { get; set; }

        public float Price { get; set; }
    }
}