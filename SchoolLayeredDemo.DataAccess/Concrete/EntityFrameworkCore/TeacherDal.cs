using Core.DataAccess.EntityFrameworkCore;
using SchoolLayeredDemo.DataAccess.Interfaces;
using SchoolLayeredDemo.Entities.Abstract;

namespace SchoolLayeredDemo.DataAccess.Concrete.EntityFrameworkCore
{
    public class TeacherDal : EfEntityRepositoryBase<Teacher, XSchoolContext>, ITeacherDal
    {

    }
}
