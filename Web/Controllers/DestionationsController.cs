using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Domain.Models;
using Repository;
using Service.Interface;

namespace Web.Controllers
{
    public class DestionationsController : Controller
    {
        private readonly IDestinationService _destinationService;

        public DestionationsController(IDestinationService destinationService)
        {
            _destinationService = destinationService;
        }


        // GET: Destionations
        public IActionResult Index()
        {
            return View(_destinationService.GetAllDestinations());
        }

        // GET: Destionations/Details/5
        public IActionResult Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var destionation = _destinationService.GetDestination(id);
            if (destionation == null)
            {
                return NotFound();
            }

            return View(destionation);
        }

        // GET: Destionations/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Destionations/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create([Bind("Name,ImageUrl,Id")] Destination destionation)
        {
            if (ModelState.IsValid)
            {
               _destinationService.InsertDestination(destionation);
                
                return RedirectToAction(nameof(Index));
            }
            return View(destionation);
        }

        // GET: Destionations/Edit/5
        public IActionResult Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var destionation = _destinationService.GetDestination(id);
            if (destionation == null)
            {
                return NotFound();
            }
            return View(destionation);
        }

        // POST: Destionations/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Edit(int id, [Bind("Name,ImageUrl,Id")] Destination destionation)
        {
            if (id != destionation.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _destinationService.UpdateDestination(destionation);
                    
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!DestionationExists(destionation.Id))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction(nameof(Index));
            }
            return View(destionation);
        }

        // GET: Destionations/Delete/5
        public IActionResult Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var destionation = _destinationService.GetDestination(id);
            if (destionation == null)
            {
                return NotFound();
            }

            return View(destionation);
        }

        // POST: Destionations/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public IActionResult DeleteConfirmed(int id)
        {
            var destionation = _destinationService.GetDestination(id);
            if (destionation != null)
            {
               _destinationService.DeleteDestination(destionation);
            }

            
            return RedirectToAction(nameof(Index));
        }

        private bool DestionationExists(int id)
        {
            return _destinationService.GetAllDestinations() != null;
        }
    }
}
