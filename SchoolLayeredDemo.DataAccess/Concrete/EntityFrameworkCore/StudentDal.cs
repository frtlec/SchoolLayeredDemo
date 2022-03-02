using Core.DataAccess.EntityFrameworkCore;
using SchoolLayeredDemo.DataAccess.Interfaces;
using SchoolLayeredDemo.Entities.Abstract;

namespace SchoolLayeredDemo.DataAccess.Concrete.EntityFrameworkCore
{
    public class StudentDal : EfEntityRepositoryBase<Student, XSchoolContext>, IStudentDal
    {

    }
}
