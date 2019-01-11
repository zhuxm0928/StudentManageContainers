using System;
using System.Collections.Generic;
using System.Text;

namespace Student.Domain
{
    public abstract class BaseEntity<TKey>
    {
        public virtual TKey Id { get; set; }

        public DateTime CreateDate { get; set; } = DateTime.Now;
    }

    public abstract class BaseEntity : BaseEntity<int>
    {

    }
}
