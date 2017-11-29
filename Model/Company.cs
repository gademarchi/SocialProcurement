using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Common

namespace Model{
    public class Company
    {
        public long Id { get; set; }
        public String Name { get; set; }
        public String Address { get; set; }
        
        public String Email { get; set; }
    }
}
