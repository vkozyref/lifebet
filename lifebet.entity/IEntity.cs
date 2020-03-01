using System;
using System.Collections.Generic;
using System.Text;

namespace lifebet.entity
{
    public interface IEntity<TId>
    {
        TId Id { get; set; }
    }
}
