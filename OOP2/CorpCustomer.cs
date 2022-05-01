using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP2
{
    //inheritance
    internal class CorpCustomer:Customer
    {
        public string FName { get; set; }
        public string LName { get; set; }
        public string CorpName { get; set; }
        public string TaxNum { get; set; }
    }
}
