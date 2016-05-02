using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.EntityFramework;
using TravelAgent.Areas.Admin.Models;
using TravelAgent.Models;


namespace TravelAgent.Areas.Admin.Controllers
{
    [Authorize(Roles="Admin")]
   
    public class IndexController : Controller
    {
        // GET: Admin/Home
       ApplicationDbContext context = new ApplicationDbContext();

       public ActionResult Index()
        {
            var allusers = context.Users.ToList();
            var users = allusers.Where(x => context.Roles.Select(role => role.Name).Contains("User")).ToList();
            var userVM = users.Select(user => new UserViewModel { Username = user.UserName, Roles = string.Join(",", user.Roles.Select(role => role.RoleId)) }).ToList();

            var admins = allusers.Where(x => context.Roles.Select(role => role.Name).Contains("Admin")).ToList();
            var adminsVM = admins.Select(user => new UserViewModel { Username = user.UserName, Roles = string.Join(",", context.Roles.Select(role => role.Name)) }).ToList(); 
            var model = new GroupedUserViewModel{Users = userVM, Admins = adminsVM};

            return View(model);
        }
    }
}