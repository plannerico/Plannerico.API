using Plannerico.Data.Contracts;

namespace Plannerico.Data.Models
{
    public class Employee : AuditableEntity
    {
        public Guid UserId { get; set; }

        public ICollection<Appointment> Appointments { get; set; }
    }
}
