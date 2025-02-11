using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using webapp.Models;
using webapp.Models.ViewModel;

namespace webapp.Controllers
{
    public class HomeController : Controller
    {
        private readonly IMapper _mapper;
        private readonly ILogger<HomeController> _logger;

        public HomeController(IMapper mapper, ILogger<HomeController> logger)
        {
            _mapper = mapper;
            _logger = logger;
        }

        public IActionResult Index()
        {
            var property = new Property
            {
                IsHomeOwner = true,
                Adress = "mårvænget",
                ZipCode=2860,
                City="søborg",
                Bought=DateTime.Now,
                Hasloan=true,
                LoanType="huslån",
                InterestRate=2.6,
              
            };
           
            var viewModel = _mapper.Map<PropertyViewModel>(property);

            return View(viewModel);
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
    }
}
