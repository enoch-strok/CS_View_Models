using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using CS_View_Models_B.Models;

namespace CS_View_Models_B.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
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

 //_____________________________________/Index\___________________________________________________//
        [HttpGet("/")]
        public IActionResult Index()
        {
        string[] message = new string[]
        {
            "All this talk of Models for classes and models for ViewModels can get a little confusing. Just to be clear: do not think of a model for creating a class the same way you think of using a ViewModel. Many students get tripped up on the idea that you can only pass a model from a class along as a ViewModel, but as the example above shows this is not the case. A ViewModel denotes that some sort of information has been passed along using the return statement. See how in the above example a string[] called 'names' was passed along by putting it in as an argument in return View(names)? That string[] did not come from a model class. It was created within the controller and passed along from there. ",
            "Message 2"
        };
            return View(message);
        }
//-----------------------------------------------------------------------------------------------//


 //_____________________________________/User\___________________________________________________//
            [HttpGet("/user")]
            public IActionResult UserDetails()
        {
            // While being hard-coded here, this user instance will eventually come from our DB
            User someUser1 = new User()
            {
                FirstName = "Sally",
                LastName = "Sanderson"
            };

            List<User> viewModel = new List<User>()
            {
                someUser1
            };

            // Here we pass this instance to our View
            return View(viewModel);
            // If we also need to include the name of our View, we pass our instance as a second argument
            // return View("OtherView", someUser);
        }
//-----------------------------------------------------------------------------------------------//


//_____________________________________/Users\___________________________________________________//

        [HttpGet("/users")]
            public IActionResult Users()
        {
            // While being hard-coded here, this user instance will eventually come from our DB
            User someUser1 = new User()
            {
                FirstName = "Moose",
                LastName = "Phillips"
            };
            User someUser2 = new User()
            {
                FirstName = "Sarah",
                LastName = ""
            };
            User someUser3 = new User()
            {
                FirstName = "Jerry",
                LastName = ""
            };
            User someUser4 = new User()
            {
                FirstName = "Rane",
                LastName = "Ricky"
            };
            User someUser5 = new User()
            {
                FirstName = "Barbarah",
                LastName = ""
            };

            List<User> viewModel = new List<User>()
            {
                someUser1, someUser2, someUser3, someUser4, someUser5
            };

            // Here we pass this instance to our View
            return View(viewModel);
            // If we also need to include the name of our View, we pass our instance as a second argument
            // return View("OtherView", someUser);
        }
//-----------------------------------------------------------------------------------------------//

 //_____________________________________/Numbers\___________________________________________________//
            [HttpGet("/numbers")]
            public IActionResult Numbers()
        {
            // While being hard-coded here, this user instance will eventually come from our DB
        int[] numbersData = new int[]
        {
           1,
           2,
           3,
           10,
           43,
           5
        };
            return View(numbersData);
        }
        
//-----------------------------------------------------------------------------------------------//
    }
}
