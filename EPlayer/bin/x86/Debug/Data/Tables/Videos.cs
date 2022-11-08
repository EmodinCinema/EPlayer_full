using SQLite.CodeFirst;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EPlayer.bin.x86.Debug.Data.Tables
{
    [Table("Videos")]
    public class Person
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public long Id { get; set; }

        [Unique]
        [Required]
        public string Name { get; set; }
        public string Path { get; set; }
        public string Data { get; set; }

        /* [ForeignKey("VideosRole")]
         public long? RoleId { get; set; }

         public Role PersonRole { get; set; }

         public ICollection<Order> Orders { get; set; }*/
        public override string ToString()
        {
            return $"{Id}--{Name}--{Path}--{Data}";
        }
    }
}
