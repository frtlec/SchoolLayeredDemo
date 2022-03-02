using System;

namespace SchoolLayeredDemo.Business.Dtos
{
    public class TeacherDto
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string SurName { get; set; }
        public string Skill { get; set; }

     
        public int ManagerId { get; set; }
        public DateTime? CreatedDate { get; set; }
        public DateTime? UpdatedDate { get; set; }
    }
}
