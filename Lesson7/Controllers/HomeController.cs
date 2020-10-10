using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Lesson7.Models;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace Lesson7.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        IEnumerable<Company> companies = new List<Company>
        {
            new Company{Id = 1, Name = "Apple"},
            new Company{Id = 2, Name = "Samsung"},
            new Company{Id = 3, Name = "Gooloogoolo"}
        };

        public IActionResult Create()
        {
            ViewBag.Companies = new SelectList(companies, "Id", "Name");
            return View();
        }

        [HttpPost]
        public string Create(Product product)
        {
            Company company = companies.FirstOrDefault(c => c.Id == product.CompanyId);
            return $"Добавлен новый элемент: {product.Name} ({company?.Name})";
        }
    }
}
