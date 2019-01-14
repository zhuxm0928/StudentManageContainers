using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Student.Domain.Entities
{
    [Table(nameof(Role))]
    public class Role : BaseEntity
    {
        [Required]
        [Column(TypeName = "varchar(100)")]
        public string Name { get; set; }

        public bool IsDisabled { get; set; }
    }
}
