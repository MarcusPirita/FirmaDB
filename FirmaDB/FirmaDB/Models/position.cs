using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirmaDB.Models
{
    public class Position
    {
        public int Id { get; set; }
        public float Salary { get; set; }
        public string PositionTitle { get; set; }
        public string Description { get; set; }

        public ICollection<JobTenure> JobTenures { get; set; }
    }
}
