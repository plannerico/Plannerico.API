using Plannerico.Data.Contracts;

namespace Plannerico.Data.Models
{
    public class Client : AuditableEntity
    {
        public Guid? UserId { get; set; }

        public string FirstName { get; set; }

        public string LastName { get; set; }

        public ICollection<Appointment> Appointments { get; set; }
    }
}
