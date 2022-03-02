using Core.Dtos;
using SchoolLayeredDemo.Business.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolLayeredDemo.Business.Interfaces
{
    public interface IManagerService
    {
        public Response<List<ManagerDto>> GetAllManagerList();
        public Response<ManagerDto> GetManagerById(int managerId);
        public Response<bool> AddManager(ManagerInputDto inputModel);
        public Response<bool> DeleteManager(int managerId);
    }
}
