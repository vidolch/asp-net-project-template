﻿namespace DataAccess.Models
{
    using System;

    public class BaseEntity : IAuditInfo
    {
        public int Id { get; set; }
        public DateTime CreatedOn { get; set; }
        public DateTime? UpdatedOn { get; set; }
    }
}
