using businness.concrate;
using data_access.Abstract;
using Entity;
using final_project.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace final_project.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly IProduct_repo _productService;
        private readonly ICategory_repo _categoryService;
        private readonly ITag_repo _tagService;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
            _productService = new product_MAN();
            _categoryService = new category_MAN();
            _tagService = new tag_MAN();

        }

        public IActionResult Index()
        {
            return View();
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


        //Product
        public IActionResult Products()
        {
            var products = _productService.GetAllProducts();
            return View(products);
        }

        public IActionResult AddProduct(products product)
        {
            _productService.CreateProduct(product);

            return RedirectToAction(nameof(Products));
        }
        public IActionResult RemoveProduct(int id)
        {
            _productService.DeleteProduct(id);
            return RedirectToAction(nameof(Products));
        }
        public IActionResult UpdateProduct(products products)
        {
            _productService.UpdateProduct(products);
            return RedirectToAction(nameof(products));
        }

        //Category

        public IActionResult Categories()
        {
            var categories = _categoryService.GetAllCategories();
            return View(categories);
        }

        public IActionResult AddCategories(categories category)
        {
            _categoryService.CreateCategory(category);

            return RedirectToAction(nameof(Categories));
        }
        public IActionResult RemoveCategories(int id)
        {
            _categoryService.DeleteCategories(id);
            return RedirectToAction(nameof(Categories));
        }
        public IActionResult UpdateCategories(categories categories)
        {
            _categoryService.UpdateCategories(categories);
            return RedirectToAction(nameof(categories));
        }

        //Tag
        public IActionResult Tags()
        {
            var tags = _tagService.GetAllTags();
            return View(tags);
        }

        public IActionResult AddTags(tags tag)
        {
            _tagService.CreateTags(tag);

            return RedirectToAction(nameof(Tags));
        }
        public IActionResult RemoveTags(int id)
        {
            _tagService.DeleteTags(id);
            return RedirectToAction(nameof(Tags));
        }
        public IActionResult UpdateTags(tags tags)
        {
            _tagService.UpdateTags(tags);
            return RedirectToAction(nameof(tags));
        }
    }
}
