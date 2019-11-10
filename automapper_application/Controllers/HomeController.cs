using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using automapper_application.Models;
using AutoMapper;

namespace automapper_application.Controllers
{
    public class HomeController : Controller
    {
        private readonly IMapper _mapper;
        public HomeController(IMapper mapper)
        {
            _mapper = mapper;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
       
        public IActionResult GetUser()
        {
            User user = new User();
            var userDTO = _mapper.Map<UserDTO>(user);
            return View("Detail",userDTO);
        }
    }
}
