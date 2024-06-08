using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirmaDB.Models
{
    public class AccessLevel
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string PermissionList { get; set; }

        public ICollection<Employee> Employees { get; set; }
    }
}
