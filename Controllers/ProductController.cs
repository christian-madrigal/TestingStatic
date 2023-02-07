using Microsoft.AspNetCore.Mvc;
using Assignment_12._1.Models;

namespace Assignment_12._1.Controllers
{
    public class ProductController : Controller
    {
        private IData _tempData;
        public ProductController(IData tempdata)
        {
            _tempData = tempdata;
        }
        public IActionResult Details(int? id)
        {
            var model=_tempData.GetProduct(id);
            if (model == null)
            {
                return NotFound();
            }
            return View(model);
        }
        public IActionResult Index()
        {
            IndexViewModel model = new IndexViewModel();
            model.Products = _tempData.InitializeData();
            return View(model);
        }
    }
}
