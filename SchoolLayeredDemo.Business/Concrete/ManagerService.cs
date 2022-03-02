using Core.Dtos;
using SchoolLayeredDemo.Business.Dtos;
using SchoolLayeredDemo.Business.Interfaces;
using SchoolLayeredDemo.DataAccess.Interfaces;
using SchoolLayeredDemo.Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolLayeredDemo.Business.Concrete
{
    public class ManagerService : IManagerService
    {
        private readonly IManagerDal _managerDal;
        private readonly ITeacherDal _teacherDal;

        public ManagerService(IManagerDal managerDal, ITeacherDal teacherDal)
        {
            _managerDal = managerDal;
            _teacherDal = teacherDal;
        }

        public Response<bool> AddManager(ManagerInputDto inputModel)
        {
            #region Validator
                if (inputModel.FullName == null)
                {
                    return Response<bool>.Fail("FullName parametresi gönderilmek zorundadır", 400);
                }
            #endregion

            Manager model = new Manager()
            {
                FullName = inputModel.FullName
            };
            _managerDal.Add(model);



            return Response<bool>.Success(true, 200);
        }

        public Response<bool> DeleteManager(int managerId)
        {
            #region Validator
                if (managerId>0)
                {
                    return Response<bool>.Fail("Manager ID 0 dan büyük olmalı", 400);
                }
            #endregion


            try
            {
                Manager deleteManager = _managerDal.Get(f => f.Id == managerId);

                if (deleteManager == null)
                {
                    return Response<bool>.Fail("Silinmek istenen manager bulunamadı", 400);
                }
                _managerDal.Delete(deleteManager);
                return Response<bool>.Success(true, 200);
            }
            catch (Exception ex)
            {
                string errorId = Guid.NewGuid().ToString();
                //logger(ex.message,errorId);

                return Response<bool>.Fail($"Servis hatası {errorId}", 400);
            }
        }
        public Response<List<ManagerDto>> GetAllManagerList()
        {
            try
            {
                List<Manager> managers = _managerDal.GetList();//dbden gelen 

                List<ManagerDto> result = new List<ManagerDto>();//benim döneceğim

                foreach (var manager in managers)
                {
                    ManagerDto managerDto = new ManagerDto();

                    
                    managerDto.Id = manager.Id;
                    managerDto.FullName = manager.FullName;
                    managerDto.CreatedDate = manager.CreatedDate?.ToString("dd.MM.yyyy HH:mm:ss");//20.03.2022 20:27
                    managerDto.UpdatedDate = manager.UpdatedDate?.ToString("dd.MM.yyyy HH:mm:ss");//20.03.2022 20:27


                    //teacherları al managerla ilgili olanları

                    List<Teacher> teachers = _teacherDal.GetList(f=>f.ManagerId==manager.Id);

                    managerDto.TeacherList = teachers.Select(
                                t=>new TeacherDto { 
                                    Id=t.Id,
                                    Name=t.FullName.Split(' ')[0],
                                    SurName=t.FullName.Split(' ')[1],
                                    Skill = "Branş: " + t.Skill,
                                    UpdatedDate =  t.UpdatedDate,
                                    CreatedDate =  t.CreatedDate}).ToList();

                    result.Add(managerDto);
                }

                
                return Response<List<ManagerDto>>.Success(result, 200);
            }
            catch (Exception ex)
            {
                string errorId = Guid.NewGuid().ToString();
                //logger(ex.message,errorId);
                return Response<List<ManagerDto>>.Fail($"Servis hatası {errorId}", 400);
            }
        }


        public Response<ManagerDto> GetManagerById(int managerId)
        {
            throw new NotImplementedException();
        }
    }
}
