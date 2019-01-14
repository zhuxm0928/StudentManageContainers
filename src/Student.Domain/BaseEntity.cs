using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Student.Domain
{
    public abstract class BaseEntity<TKey>
    {
        public virtual TKey Id { get; set; }

        [Column(TypeName = "datetime")]
        public DateTime CreateDate { get; set; } = DateTime.Now;
    }

    public abstract class BaseEntity : BaseEntity<int>
    {

    }
}
