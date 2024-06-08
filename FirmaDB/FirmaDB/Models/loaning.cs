using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirmaDB.Models
{
    public class Loaning
    {
        public int Id { get; set; }
        public int EmployeeId { get; set; }
        public int LoanableItemsId { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }

        public Employee Employee { get; set; }
        public LoanableItems LoanableItems { get; set; }
    }
}
