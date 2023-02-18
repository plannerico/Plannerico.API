using Plannerico.Data.Contracts;

namespace Plannerico.Data.Models
{
    public class Attachment : AuditableEntity
    {
        public string Name { get; set; }

        public string Content { get; set; }
    }
}
