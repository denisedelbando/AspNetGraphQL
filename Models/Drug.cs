using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    public class Drug
    {
        public int id{ get; set; }
        public string CreateDate { get; set; }
        public int CompanyID { get; set; }
        public string GenericName { get; set; }
    }
}
