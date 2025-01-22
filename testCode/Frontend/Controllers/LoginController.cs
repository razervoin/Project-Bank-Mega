using Microsoft.AspNetCore.Mvc;
using Frontend.Models;
using System.Net.Http;
using System.Text;
using System.Text.Json;

namespace Frontend.Controllers
{
    public class LoginController : Controller
    {
        private readonly HttpClient _httpClient;

        public LoginController()
        {
            _httpClient = new HttpClient { BaseAddress = new Uri("http://localhost:5000/api/") }; // Adjust port as needed
        }

        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Login(UserLogin login)
        {
            var json = JsonSerializer.Serialize(login);
            var content = new StringContent(json, Encoding.UTF8, "application/json");

            var response = await _httpClient.PostAsync("Auth/login", content);

            if (response.IsSuccessStatusCode)
            {
                TempData["UserName"] = login.user_name;
                return RedirectToAction("Create", "Bpkb");
            }

            ViewBag.Error = "Invalid login credentials.";
            return View("Index");
        }
    }
}
