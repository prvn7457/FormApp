using FormApp.Data;
using FormApp.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Diagnostics;

namespace FormApp.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly ApplicationDbContext _context;
        public HomeController(ILogger<HomeController> logger, ApplicationDbContext context)
        {
            _logger = logger;
            _context = context;
        }

        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> SubmitForm(CMRAFormModel model)
        {
            if (ModelState.IsValid)
            {
                // Handle PhotoID
                if (model.PhotoID != null)
                {
                    using (var memoryStream = new MemoryStream())
                    {
                        await model.PhotoID.CopyToAsync(memoryStream);
                        model.PhotoIDData = memoryStream.ToArray();
                        model.PhotoIDFileName = model.PhotoID.FileName;
                        model.PhotoIDContentType = model.PhotoID.ContentType;
                    }
                }

                // Handle AddressID
                if (model.AddressID != null)
                {
                    using (var memoryStream = new MemoryStream())
                    {
                        await model.AddressID.CopyToAsync(memoryStream);
                        model.AddressIDData = memoryStream.ToArray();
                        model.AddressIDFileName = model.AddressID.FileName;
                        model.AddressIDContentType = model.AddressID.ContentType;
                    }
                }

                // Handle Form1583
                if (model.Form1583 != null)
                {
                    using (var memoryStream = new MemoryStream())
                    {
                        await model.Form1583.CopyToAsync(memoryStream);
                        model.Form1583Data = memoryStream.ToArray();
                        model.Form1583FileName = model.Form1583.FileName;
                        model.Form1583ContentType = model.Form1583.ContentType;
                    }
                }

                // Save all model data including file data to the database
                _context.CMRAFormModels.Add(model);
                await _context.SaveChangesAsync();

                return RedirectToAction("Success");
            }

            return View("Index", model);
        }


        public IActionResult Success()
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
    }
}
