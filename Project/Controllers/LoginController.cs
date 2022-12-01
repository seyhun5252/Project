using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using Project.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace Project.Controllers
{
    public class LoginController : Controller
    {

        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }


        [HttpPost]
        public IActionResult Index(UserModel userModel)
        {
            Session["asd"] = "asd";
            using (var client = new HttpClient())
            {

                var endpoit = new Uri("https://api.akilliticaretim.com/api/Auth/Login");
                client.DefaultRequestHeaders.Add("GUID", "0739-E657-C4F4-98B4");
                var newPost = new UserModel
                {
                    UserName = userModel.UserName,
                    Password = userModel.Password,
                };

                var newPostJson = JsonConvert.SerializeObject(newPost);

                var payload = new StringContent(newPostJson, Encoding.UTF8, "application/json");
                var result = client.PostAsync(endpoit, payload).Result.Content.ReadAsStringAsync().Result;

                StatusAndData statusAndData = JsonConvert.DeserializeObject<StatusAndData>(result);

                if (statusAndData.Status == true)
                {
                    TempData["Veri"] = statusAndData.Data.Token;

                    return RedirectToAction("Index", "ProductPage");

                }
                else
                {
                    return View();

                }
            }
        }
    }
}
