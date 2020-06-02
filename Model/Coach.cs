using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp3.Model
{
    public class Coach : Sporter
    {
        [Key]
        public long CoachId { get; set; }
        public Boolean Ehbo { get; set; }

    }
}
