using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using Project.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;

namespace Project.Controllers
{
    public class ProductPageController : Controller
    {

        [HttpGet]
        public IActionResult Index()
        {
            var TempDateVeri = TempData["Veri"];

            using (var client = new HttpClient())
            {
                client.DefaultRequestHeaders.Add("GUID", "0739-E657-C4F4-98B4");

                client.DefaultRequestHeaders.Add("Authorization", $"Bearer { TempDateVeri }");
                var endpoit = new Uri("https://api.akilliticaretim.com/api/Product/ListProducts/0");

                var result = client.GetAsync(endpoit).Result;
                var json = result.Content.ReadAsStringAsync().Result;

                StatusProduct statusProcut = JsonConvert.DeserializeObject<StatusProduct>(json);

                List<Product> listProductData = statusProcut.data;

                return View(listProductData);

            }
        }

        [HttpGet]
        public IActionResult UpdateProductPage(int id)
        {
            var TempDateVeri = TempData["Veri"];

            using (var client = new HttpClient())
            {
                client.DefaultRequestHeaders.Add("GUID", "0739-E657-C4F4-98B4");

                client.DefaultRequestHeaders.Add("Authorization", $"Bearer { TempDateVeri }");
                var endpoit = new Uri($"https://api.akilliticaretim.com/api/Product/ProductDetails/{id}");

                var result = client.GetAsync(endpoit).Result;
                var json = result.Content.ReadAsStringAsync().Result;

                StatusProductDetailData statusProduct = JsonConvert.DeserializeObject<StatusProductDetailData>(json);

                ProductDetailData listProductData = statusProduct.data;

                return View(listProductData);

            }

        }
    } 
}
