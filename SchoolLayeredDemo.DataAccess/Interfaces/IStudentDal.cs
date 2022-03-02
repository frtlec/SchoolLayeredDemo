using Core.DataAccess;
using SchoolLayeredDemo.Entities.Abstract;

namespace SchoolLayeredDemo.DataAccess.Interfaces
{
    public interface IStudentDal : IEntityRepository<Student>
    {
    }
}
