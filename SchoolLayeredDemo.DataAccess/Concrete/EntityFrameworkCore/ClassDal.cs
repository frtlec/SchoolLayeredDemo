using Core.DataAccess.EntityFrameworkCore;
using SchoolLayeredDemo.DataAccess.Interfaces;
using SchoolLayeredDemo.Entities.Abstract;

namespace SchoolLayeredDemo.DataAccess.Concrete.EntityFrameworkCore
{
    public class ClassDal : EfEntityRepositoryBase<Class, XSchoolContext>, IClassDal
    {

    }
}
