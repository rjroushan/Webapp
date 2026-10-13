using Microsoft.AspNetCore.Mvc;
using Webapp.Models;

namespace Webapp.Controllers
{
    [Route("Product")]
    public class ProductController : Controller
    {
      static  List<ProductViewModel> products = new List<ProductViewModel>()
        {
            new ProductViewModel(){ProductId=1,ProductCode="P0001",ProductName="Monitor",Price=110},
           
        };

        [Route("Details")]
        [HttpGet]
        public IActionResult GetProductInfo()
        {

            ProductViewModel productVM = new ProductViewModel()
            {
                ProductId = 1,
                ProductCode = "P0001",
                ProductName = "Monitor",
                Price = 110
            };
           // ViewData["product"] = productVM;
            return View("GetProductInfo", productVM);
        }
        [Route("Add")]

        [HttpGet]
        public IActionResult Create()
        { 
        
            return View("CreateV1");
        }

        [HttpPost]
        [Route("Save")]
        public IActionResult SaveProduct(ProductViewModel productVM)
        {
            products.Add(productVM);
           return RedirectToAction("GetProductList", "Product");
        }
        [HttpGet]
        [Route("product-list")]
        public IActionResult GetProductList()
        {
            return View("ProductList",products);
        }
    }
}


