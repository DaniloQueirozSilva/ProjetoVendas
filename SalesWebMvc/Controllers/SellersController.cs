using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using SalesWebMvc.Controllers.Services;

namespace SalesWebMvc.Controllers
{
    public class SellersController : Controller
    {
        private readonly SellerService _sellerSerivce;

        public SellersController(SellerService sellerService) {

            _sellerSerivce = sellerService;
        }
        public IActionResult Index()
        {
            var list = _sellerSerivce.FindAll();
            return View(list);
        }
    }
}