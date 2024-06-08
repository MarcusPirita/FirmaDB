using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirmaDB.Models
{
    public class Employee
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime Birthday { get; set; }
        public string Email { get; set; }
        public string PhoneNumber { get; set; }
        public string SocialSecurityNumber { get; set; }
        public int AccessLevelId { get; set; }
        public string Address { get; set; }
        public int ChildrenId { get; set; }

        public AccessLevel AccessLevel { get; set; }
        public ICollection<Children> Childrens { get; set; }
        public ICollection<HealthCheck> HealthChecks { get; set; }
        public ICollection<Loaning> Loanings { get; set; }
        public ICollection<SickLeave> SickLeaves { get; set; }
        public ICollection<JobTenure> JobTenures { get; set; }
        public ICollection<Requests> Requests { get; set; }
        public ICollection<Suggestions> Suggestions { get; set; }
        public ICollection<Vacation> Vacations { get; set; }
    }
}
