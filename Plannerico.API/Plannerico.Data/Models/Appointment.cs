using Plannerico.Data.Contracts;
using System.ComponentModel.DataAnnotations.Schema;

namespace Plannerico.Data.Models
{
    public class Appointment : AuditableEntity
    {
        [ForeignKey("Employee")]
        public Guid EmployeeId { get; set; }
        public Employee Employee { get; set; }

        [ForeignKey("Client")]
        public Guid ClientId { get; set; }
        public Client Client { get; set; }

        public DateTime AppointmentDate { get; set; }

        public TimeSpan Duration { get; set; }

        public string Description { get; set; }

        public ICollection<Attachment> Attachments { get; set; }

        public ICollection<Requirement> Requirements { get; set; }
    }
}
