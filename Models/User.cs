using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace ITCraft_backend.Models
{
    public class User
    {
        [Key]
        public int Id { get; set; }

        [Column(TypeName ="nvarchar(500)")]
        public string Name { get; set; }

        [Column(TypeName = "bit")]
        public bool Active { get; set; }

    }
}
