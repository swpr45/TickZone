using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using TickZone.Data;
using TickZone.Data.Services;
using TickZone.Models;

namespace TickZone.Controllers
{
    public class ProducersController : Controller
    {
        private readonly IProducerService _service;
        public ProducersController(IProducerService service)
        {
            _service = service;
        }
        //we can also write action method using async and await in follwing way
        public async Task<IActionResult> Index()
        {
            var allProducers = await _service.GetAllAsync();
            return View(allProducers);
        }


        //GET: producers/create
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Create([Bind("FullName,ProfilePicture,Bio")] Producer producer)
        {
            if (!ModelState.IsValid)
            {
                /*foreach (var modelStateKey in ModelState.Keys)
                {
                    var modelStateVal = ModelState[modelStateKey];
                    foreach (var error in modelStateVal.Errors)
                    {
                        Console.WriteLine($"Key: {modelStateKey}, Error: {error.ErrorMessage}");
                    }
                }*/

                return View(producer);
            }
            await _service.AddAsync(producer);
            return RedirectToAction(nameof(Index));
        }
        //Get: Producers/Details/1
        public async Task<IActionResult> Details(int Id)
        {
            var producer = await _service.GetByIdAsync(Id);
            if (producer == null)
                return View("NotFound");
            return View(producer);
        }

        //Get: Producer/Edit/1
        [HttpGet]
        public async Task<IActionResult> Edit(int id)
        {
            var producer = await _service.GetByIdAsync(id);
            if (producer == null) return View("NotFound");
            return View(producer);
        }

        [HttpPost]
        public async Task<IActionResult> Edit(int id, [Bind("Id,FullName,ProfilePicture,Bio")] Producer producer)
        {
            if (!ModelState.IsValid)
            {
             
                return View(producer);
            }
            await _service.UpdateAsync(id, producer);
            return RedirectToAction(nameof(Index));
        }



        //Get: Producer/Delete/1

        public async Task<IActionResult> Delete(int id)
        {
            var producerDetails = await _service.GetByIdAsync(id);
            if (producerDetails == null) return View("NotFound");
            return View(producerDetails);
        }

        [HttpPost, ActionName("Delete")]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var producerDetails = await _service.GetByIdAsync(id);
            if (producerDetails == null) return View("NotFound");

            await _service.DeleteAsync(id);

            return RedirectToAction(nameof(Index));
        }

    }




}
