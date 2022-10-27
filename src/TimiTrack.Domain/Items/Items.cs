using System;

namespace TimiTrack.Items;
using Volo.Abp.Domain.Entities.Auditing;

public class Items
{
    public class Item : AuditedAggregateRoot<Guid>
    {
        public string Name { get; set; }

        public ItemType Type { get; set; }

        public DateTime ScrapeDate { get; set; }

        public float Price { get; set; }
    }
}