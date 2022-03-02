using Core.DataAccess;
using SchoolLayeredDemo.Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolLayeredDemo.DataAccess.Interfaces
{
    public interface IManagerDal: IEntityRepository<Manager>
    {
    }
}
