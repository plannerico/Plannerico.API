using Plannerico.Data.Contracts;

namespace Plannerico.Data.Models
{
    public class Requirement : AuditableEntity
    {
        public string Title { get; set; }

        public string Description { get; set; }

        public ICollection<Attachment> Attachments { get; set; }
    }
}
