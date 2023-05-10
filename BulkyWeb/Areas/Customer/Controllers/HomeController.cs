using Bulky.DataAccess.Repository;
using Bulky.DataAccess.Repository.IRepository;
using Bulky.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using System.Security.Claims;

namespace BulkyWeb.Areas.Customer.Controllers
{
    [Area("Customer")]
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly IUnitOfWork _uniOfWork;

        public HomeController(ILogger<HomeController> logger,IUnitOfWork unitOfWork)
        {
            _logger = logger;
            _uniOfWork = unitOfWork;
        }

        public IActionResult Index()
        {
            IEnumerable<Product> productList = _uniOfWork.Product.GetAll(includeProperties:"Category").ToList();
            return View(productList);
        }
        public IActionResult Details(int productId)
        {
            ShoppingCart cart = new() {
                Product = _uniOfWork.Product.Get(s => s.Id == productId, "Category"),
                Count = 1,
                ProductId = productId

        };

            //Product product = _uniOfWork.Product.GetAll(includeProperties: "Category").Where(u => u.Id == productId).FirstOrDefault();
            return View(cart);
        }
        [HttpPost]
        [Authorize]
        public IActionResult Details(ShoppingCart shoppingCart)
        {
            
            var claimsIdentity=(ClaimsIdentity)User.Identity;
            var userId = claimsIdentity.FindFirst(ClaimTypes.NameIdentifier).Value;
            shoppingCart.ApplicationUserId=userId;
            ShoppingCart cartFromDb=_uniOfWork.ShoppingCart.Get(u=>u.ApplicationUserId==userId
            &&u.ProductId==shoppingCart.ProductId);
            if(cartFromDb!=null)
            {
                cartFromDb.Count += shoppingCart.Count;
                _uniOfWork.ShoppingCart.Update(cartFromDb);

            }
            else
            {
                _uniOfWork.ShoppingCart.Add(shoppingCart);

            }
            TempData["success"] = "Cart updated successfully";
            _uniOfWork.Save();
            return RedirectToAction(nameof(Index));
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