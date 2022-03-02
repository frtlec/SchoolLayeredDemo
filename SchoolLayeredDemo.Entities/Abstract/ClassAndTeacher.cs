using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolLayeredDemo.Entities.Abstract
{
    public class ClassAndTeacher
    {
        public int Id { get; set; }
        public int ClassId { get; set; }
        public int TeacherId { get; set; }
    }
}
