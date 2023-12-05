using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using ShobhinsBooks.DataAccess.Repository;
using ShobhinsBooks.DataAccess.Repository.IRepository;
using ShobhinsBooks.Models;
using ShobhinsBookStore.Models;
using ShobhinsBookStore.Models.ViewModels;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace ShobhinsBookStore.Areas.Customer.Controllers
{
    [Area("Customer")]
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly IUnitOfWork _unitOfWork;

        public HomeController(ILogger<HomeController> logger, IUnitOfWork unifOfWork)
        {
            _logger = logger;
            _unitOfWork = unifOfWork;
        }

        public IActionResult Index()
        {
            IEnumerable<Product> productList = _unitOfWork.Product.GetAll(includeProperties: "Category,CoverType");
            return View(productList);
        }

        public IActionResult Privacy()
        {
            return View();
        }
        public IActionResult Details(int id)
        {
            // Fetch product details based on the provided ID
            Product product = _unitOfWork.Product.GetFirstOrDefault(filter: p => p.Id == id, includeProperties: "Category,CoverType");

            if (product == null)
            {
                return NotFound(); // Or any other appropriate action for not found
            }

            return View(product);
        }
        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
