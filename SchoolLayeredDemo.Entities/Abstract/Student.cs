using Core.Entities;
using System;

namespace SchoolLayeredDemo.Entities.Abstract
{
    public class Student : IEntity
    {
        public int Id { get; set; }
        public string FullName { get; set; }
        public string IdentityNumber { get; set; }
        public string Age { get; set; }
        public string Description { get; set; }
        public string PicturePath { get; set; }
        public string ClassId { get; set; }
        public DateTime CreatedDate { get; set; }
        public DateTime UpdatedDate { get; set; }
    }
}
