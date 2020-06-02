using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp3.Model
{
    [Table("Blogs")]
    public class Blog
    {

        [Key]
        public long BlogId { get; set; }

        [Required]
        [Column(TypeName = "varchar(200)")]
        public string Url { get; set; }

        public List<Post> Posts { get; set; }

        [Timestamp]
        public byte[] Timestamp { get; }// DatumTijd, gebruikt om te zien of vorig record dezelfde is (dus niet gewijzigd is)

        public Blog() { }
        public Blog(long id, string url)
        {
            this.BlogId = id;
            this.Url = url;
        }
    }
}
