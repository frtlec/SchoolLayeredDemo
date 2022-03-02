using Core.Entities;
using System;

namespace SchoolLayeredDemo.Entities.Abstract
{
    public class Class : IEntity
    {
        public int Id { get; set; }
        public string ClassNumber { get; set; }
        public int MaxCapacit { get; set; }
        public string Description { get; set; }
        public DateTime CreatedDate { get; set; }
        public DateTime UpdatedDate { get; set; }
    }
}
