using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirmaDB.Models
{
    public class JobTenure
    {
        public int Id { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public string Duration { get; set; }
        public int PositionId { get; set; }
        public int EmployeeId { get; set; }

        public Employee Employee { get; set; }
        public Position Position { get; set; }
    }
}
