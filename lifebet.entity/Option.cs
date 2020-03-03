using System;
namespace lifebet.entity
{
    public class Option : IEntity<int>
    {
        public int Id { get; set; }

        public int EventId { get; set; }

        public int Name { get; set; }
    }
}
