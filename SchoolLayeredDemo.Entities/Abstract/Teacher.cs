using Core.Entities;
using System;

namespace SchoolLayeredDemo.Entities.Abstract
{
    public class Teacher : IEntity
    {
        public int Id { get; set; }
        public string FullName { get; set; }
        public string Skill { get; set; }
        public int ManagerId { get; set; }
        public DateTime? CreatedDate { get; set; }
        public DateTime? UpdatedDate { get; set; }
    }
}
