using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirmaDB.Models
{
    public class Suggestions
    {
        public int Id { get; set; }
        public string Topic { get; set; }
        public string Content { get; set; }
        public int EmployeeId { get; set; }
        public string Status { get; set; }

        public Employee Employee { get; set; }
    }
}
