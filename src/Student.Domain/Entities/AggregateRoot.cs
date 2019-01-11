using System;
using System.Collections.Generic;
using System.Text;

namespace Student.Domain.Entities
{
    public class AggregateRoot : IAggregateRoot
    {
        public int Id { get; set; }
    }
}
