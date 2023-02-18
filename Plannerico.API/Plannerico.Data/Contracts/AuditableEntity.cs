﻿namespace Plannerico.Data.Contracts
{
    public class AuditableEntity : Entity<Guid>, IAuditableEntity
    {
        public string? CreatedBy { get; set; }

        public DateTime CreatedOn { get; set; }

        public string? LastModifiedBy { get; set; }

        public DateTime? LastModifiedOn { get; set; }
    }
}
