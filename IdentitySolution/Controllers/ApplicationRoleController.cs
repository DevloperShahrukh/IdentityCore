using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Identity;
using IdentitySolution.Models.View_Models;
using IdentitySolution.Models.Identity;

namespace IdentitySolution.Controllers 
{
    public class ApplicationRoleController : Controller
    {
        private readonly RoleManager<IdentityRole> roleManager;

        public ApplicationRoleController(RoleManager<IdentityRole> roleManager)
        {
            this.roleManager = roleManager;
        }

        [HttpGet]
        public IActionResult Index()
        {
            //List<ApplicationRoleListViewModel> model = new List<ApplicationRoleListViewModel>();
            //model = roleManager.Roles.Select(r => new ApplicationRoleListViewModel
            //{
            //    RoleName = r.Name,
            //    Id = r.Id,
            //    Description = r.Description
            //    //NumberOfUsers = r.Users.Count
            //}).ToList();
            return View();
        }

        //public IActionResult Index()
        //{
        //    return View();
        //}
    }
}