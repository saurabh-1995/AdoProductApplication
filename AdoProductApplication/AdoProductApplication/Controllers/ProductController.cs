using AdoProductApplication.Models;
using DAL;
using Microsoft.AspNetCore.Mvc;
using Product.Model;
using System.Collections.Generic;
using System.Linq;

namespace AdoProductApplication.Controllers
{
    public class ProductController : Controller
    {
        private readonly DataBaseOperations dataBaseOperations;

        public ProductController()
        {
            dataBaseOperations = DataBaseOperations.Instance();
        }
        public IActionResult Index()
        {
            return View(dataBaseOperations.GetProducts());
        }
        public IActionResult AddProduct()
        {
            
            return View();
        }
        [HttpPost]
        public IActionResult AddProduct(ProductList product)
        {
            dataBaseOperations.AddProduct(product);
            return RedirectToAction("Index");
        }
        public IActionResult EditProduct(int id)
        {
            ProductList product = dataBaseOperations.GetProductsById(id);
            return View(product);
        }
        [HttpPost]
        public IActionResult EditProduct(ProductList product)
        {
            dataBaseOperations.UpdateProduct(product);
            return RedirectToAction("Index");

        }
        public IActionResult ProductDetails(int id)
        {
            ProductList product = dataBaseOperations.GetProductsById(id);
            return View(product);
        }
        public IActionResult Delete(int id)
        {
            dataBaseOperations.DeleteProductId(id);
            return RedirectToAction("Index");
        }
        [HttpPost]
        public IActionResult SearchProduct(SearchViewModel searchViewModel)
        {
            IEnumerable<ProductList> searchList = dataBaseOperations.GetProducts();
            if (searchViewModel.MaxRange == 0)
            {
                searchViewModel.MaxRange = 999999999;
            }
            if (searchViewModel.SearchText == null)
            {
                searchViewModel.SearchText = "";
            }
            if (searchViewModel.ProductCategoryById != 0)
            {
                searchList = (from s in searchList
                              where s.ProductName.ToUpper().Contains(searchViewModel.SearchText.ToUpper())
                               && (s.ProductPrice >= searchViewModel.MinRange && s.ProductPrice <= searchViewModel.MaxRange)
                               && (s.ProductCategoryById.ToString().Contains(searchViewModel.ProductCategoryById.ToString()))
                              select s).ToList();
            }
            else
            {
                searchList = (from s in searchList
                              where s.ProductName.ToUpper().Contains(searchViewModel.SearchText.ToUpper())
                               && (s.ProductPrice >= searchViewModel.MinRange && s.ProductPrice <= searchViewModel.MaxRange)
                              select s).ToList();
            }

            return View(searchList);
        }

    }
}