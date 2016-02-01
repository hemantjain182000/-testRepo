using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace DataModel
{
    public class PartModel
    {
        [Key]
        public int PartId { get; set; }
        public string PartDescription { get; set; }
        public string UOM { get; set; }
        public string Location { get; set; }
    }
}
