using System.Text;
using Microsoft.AspNetCore.Mvc;
using Frontend.Models;
using System.Net.Http;
using System.Text.Json;

namespace Frontend.Controllers
{
    public class BpkbController : Controller
    {
        private readonly HttpClient _httpClient;

        public BpkbController()
        {
            _httpClient = new HttpClient { BaseAddress = new Uri("http://localhost:5000/api/") }; // Adjust port as needed
        }

        public async Task<IActionResult> Create()
        {
            var response = await _httpClient.GetAsync("StorageLocation");
            var locations = JsonSerializer.Deserialize<List<MsStorageLocation>>(await response.Content.ReadAsStringAsync());

            ViewBag.Locations = locations;
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Create(TrBpkb bpkb)
        {
            var json = JsonSerializer.Serialize(bpkb);
            var content = new StringContent(json, Encoding.UTF8, "application/json");

            var response = await _httpClient.PostAsync("Bpkb", content);

            if (response.IsSuccessStatusCode)
            {
                return RedirectToAction("Success");
            }

            ViewBag.Error = "Failed to create BPKB.";
            return View();
        }

        public IActionResult Success()
        {
            return View();
        }
    }
}
