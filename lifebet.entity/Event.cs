using System;
namespace lifebet.entity
{
    public class Event: IEntity<int>
    {
        public int Id { get; set; }
        public string Name { get; set;  }
    }
}
