using Plannerico.Data.Contracts;

namespace Plannerico.Data.Models
{
    public class Company : AuditableEntity
    {
        public string Name { get; set; }

        public string Address { get; set; }

        public ICollection<Employee> Employees { get; set; }
    }
}
