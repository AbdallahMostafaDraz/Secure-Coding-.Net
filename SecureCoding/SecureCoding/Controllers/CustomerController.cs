using Microsoft.AspNetCore.Mvc;
using SecureCoding.Models;

namespace SecureCoding.Controllers
{
    public class CustomerController : Controller
    {
        private static List<Customer> customers = new();
        public IActionResult Index()
        {
            return View(customers);
        }
        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(Customer customer)
        {
            if (!ModelState.IsValid)
            {
                return View(customer);
            }
            customers.Add(customer);
            return RedirectToAction(nameof(Index));
        }
    }
}
