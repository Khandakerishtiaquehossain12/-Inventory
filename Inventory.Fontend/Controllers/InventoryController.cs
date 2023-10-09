using Inventory.Fontend.Models;
using Microsoft.AspNetCore.Mvc;

using Microsoft.EntityFrameworkCore.Metadata.Internal;

namespace Inventory.Frontend.Controllers;

public class InventoryController : Controller
{
    private readonly HttpClient _httpClient;
    public InventoryController(IHttpClientFactory httpClientFactory)
    {
        _httpClient = httpClientFactory.CreateClient("TaskApi");
    }
    // public async Task<IActionResult> Index()=> View(await GetAllStudent());
    public async Task<IActionResult> Index()
    {
        return View(await GetAllInventory());
    }

    public async Task<List<InventoryForntend>> GetAllInventory()
    {
        var response = await _httpClient.GetAsync("Inventory");
        var data = await response.Content.ReadFromJsonAsync<List<InventoryForntend>>();
        return data ?? new List<InventoryForntend>();
    }
    [HttpGet]
    public async Task<IActionResult> AddorEdit(int Id)
    {
        if (Id == 0)
        {
            return View(new InventoryForntend());
        }
        else
        {
            var response = await _httpClient.GetAsync($"Inventory/{Id}");
            var data = await response.Content.ReadFromJsonAsync<InventoryForntend>();
            return View(data);
        }

    }
    [HttpPost]
    public async Task<IActionResult> AddorEdit(int Id, InventoryForntend inventory)
    {
        if (ModelState.IsValid)
        {
            if (Id == 0)
            {
                //insert data
                var result = await _httpClient.PostAsJsonAsync("Inventory", inventory);
                if (result.IsSuccessStatusCode)
                {
                    return RedirectToAction("Index");
                }
            }
            else
            {
                //update data
                var result = await _httpClient.PutAsJsonAsync($"Inventory/{Id}", inventory);
                if (result.IsSuccessStatusCode)
                {
                    return RedirectToAction("Index");
                }
            }
        }        return View(new InventoryForntend());
    }

    public async Task<IActionResult> Delete(int Id)
    {
        var response = await _httpClient.DeleteAsync($"Inventory/{Id}");
        return RedirectToAction("Index");

    }



}

