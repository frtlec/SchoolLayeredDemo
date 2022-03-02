using Microsoft.AspNetCore.Mvc;
using SchoolLayeredDemo.Business.Dtos;
using SchoolLayeredDemo.Business.Interfaces;

namespace SchoolLayeredDemo.WEBUI.Controllers
{
    public class ManagersController : Controller
    {
        private readonly IManagerService _managerService;

        public ManagersController(IManagerService managerService)
        {
            _managerService = managerService;
        }

        public IActionResult List()
        {
            var getAllManagerList = _managerService.GetAllManagerList();



            if (getAllManagerList.IsSuccessful==false)
            {
                TempData["Error"] = getAllManagerList.Errors;
                return View();
            }




            return View(getAllManagerList.Data);
        }
    }
}
