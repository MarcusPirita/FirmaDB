using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirmaDB.Models
{
    public class LoanableItems
    {
        public int Id { get; set; }
        public string ItemName { get; set; }
        public string LoanStatus { get; set; }

        public ICollection<Loaning> Loanings { get; set; }
    }
}
