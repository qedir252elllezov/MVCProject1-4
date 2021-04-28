using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete
{
   public class Catagory
    {
        [Key]
        public int CatagoryID { get; set; }

        [StringLength(50)]
        public string CatagoryName { get; set; }

       [StringLength(200)]
        public string CatagoryDescription{ get; set; }


        public bool CatagoryStatus { get; set; }
        
        public ICollection<Heading> Headings { get; set; }
    }
}
