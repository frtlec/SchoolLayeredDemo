using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolLayeredDemo.Business.Dtos
{
    public class ManagerDto
    {
        public int Id { get; set; }
        public string FullName { get; set; }
        public List<TeacherDto> TeacherList { get; set; }
        public string CreatedDate { get; set; }
        public string UpdatedDate { get; set; }
    }
}
