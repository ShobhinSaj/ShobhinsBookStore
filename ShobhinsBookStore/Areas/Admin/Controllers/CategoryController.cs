﻿using Microsoft.AspNetCore.Mvc;
using ShobhinsBooks.DataAccess.Repository.IRepository;

namespace ShobhinsBookStore.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class CategoryController : Controller
    {
        private readonly IUnitOfWork _unitOfWork;
        public CategoryController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }
        public IActionResult Index()
        {
            return View();
        }
        //API Calls here
    }
}