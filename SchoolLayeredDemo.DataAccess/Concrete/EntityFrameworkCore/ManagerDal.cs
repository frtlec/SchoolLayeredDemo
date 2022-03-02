using Core.DataAccess.EntityFrameworkCore;
using SchoolLayeredDemo.DataAccess.Interfaces;
using SchoolLayeredDemo.Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace SchoolLayeredDemo.DataAccess.Concrete.EntityFrameworkCore
{

    public class ManagerDal : EfEntityRepositoryBase<Manager, XSchoolContext>, IManagerDal
    {
    
    }
}
