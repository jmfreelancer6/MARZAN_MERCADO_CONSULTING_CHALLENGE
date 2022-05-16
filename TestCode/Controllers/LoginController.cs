using AutoMapper;
using Domain.Core.Agregados;
using Domain.Core.Models;
using Infraestructure.Data.AccessData;
using Infraestructure.Data.Persistent;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Security.Claims;
using System.Threading.Tasks;

namespace TestCode.Controllers
{
    public class LoginController : Controller
    {
        private IGet<tbl_Users> _user = new RepositoryUsers();
        private readonly IMapper _mapper;
        public LoginController(IMapper mapper)
        {
            _mapper = mapper;
        }
        // GET: LoginController
        public ActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> IndexAsync(UsersDTO user)
        {
            if (ModelState.IsValid)
            {
                var _User = _user.ObtenerOneByExpression(a => a.usuario == user.usuario && a.Contrasena == user.Contrasena);
                if (user == null)
                {
                    //Add logic here to display some message to user    
                    ViewBag.Message = "Invalid Credential";
                    return View(user);
                }
                else
                {
                    //A claim is a statement about a subject by an issuer and    
                    //represent attributes of the subject that are useful in the context of authentication and authorization operations.    
                    var claims = new List<Claim>() {
                    new Claim(ClaimTypes.NameIdentifier, Convert.ToString(user.ID)),
                        new Claim(ClaimTypes.Name, user.usuario),
                        new Claim(ClaimTypes.Role, "admin"),
                        new Claim("FavoriteDrink", "Tea")
                };
                    //Initialize a new instance of the ClaimsIdentity with the claims and authentication scheme    
                    var identity = new ClaimsIdentity(claims, CookieAuthenticationDefaults.AuthenticationScheme);
                    //Initialize a new instance of the ClaimsPrincipal with ClaimsIdentity    
                    var principal = new ClaimsPrincipal(identity);
                    //SignInAsync is a Extension method for Sign in a principal for the specified scheme.    
                    await HttpContext.SignInAsync(CookieAuthenticationDefaults.AuthenticationScheme, principal, new AuthenticationProperties()
                    {
                        IsPersistent = true
                    });
                    return RedirectToAction("Index", "Clientes");
                }
            }
            return View(user);
        }
        [Authorize]
        public async Task<IActionResult> Logout()
        {
            await HttpContext.SignOutAsync();
            return RedirectToAction(nameof(Index));
        }

    }
}
