using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using MehanikASP.Data;
using MehanikASP.Models;

namespace MehanikASP.Controllers
{
    public class CarsController : Controller
    {
        private readonly ApplicationDbContext _context;

        public CarsController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: Cars
        public async Task<IActionResult> Index()
        {
            var applicationDbContext = _context.Cars.Include(c => c.Stranka);
            return View(await applicationDbContext.ToListAsync());
        }

        // GET: Cars/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var car = await _context.Cars
                .Include(c => c.Stranka)
                    .Include(e => e.Servisi)
                    .AsNoTracking()
                .FirstOrDefaultAsync(m => m.Id == id);
            if (car == null)
            {
                return NotFound();
            }

            return View(car);
        }

        // GET: Cars/Create
        public IActionResult Create()
        {

            ViewData["StrankaIme"] = new SelectList(_context.Customers, "Id", "Id");
            return View();
        }


        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> CreateService([Bind("Id,Datum,Kilometri,OljniFilter,ZracniFilter,FilterGoriva,FilterKabine,ZobatiJermen,MikroJermen,Opombe,CarId")] Service service)
        {
            if (ModelState.IsValid)
            {

                _context.Services.Add(service);
                await _context.SaveChangesAsync();
                return RedirectToAction("Details/"+service.CarId);
            }
            ViewData["CarId"] = new SelectList(_context.Cars, "Id", "Id", service.CarId);
            return View(service);
        }


        // POST: Cars/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,Znamka,Model,Letnik,VIN,kW,TipMotorja,RegOzn,StrankaId")] Car car)
        {
            if (ModelState.IsValid)
            {
                _context.Add(car);
               
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["StrankaId"] = new SelectList(_context.Customers, "Id", "Id", car.StrankaId);
            return View(car);
        }

        // GET: Cars/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var car = await _context.Cars.FindAsync(id);
            if (car == null)
            {
                return NotFound();
            }
            ViewData["StrankaId"] = new SelectList(_context.Customers, "Id", "Id", car.StrankaId);
            return View(car);
        }
        public IActionResult AddServiceToCar(int? id)
        {
            var service = _context.Services
                .Where(c => c.CarId == id)
                .Include(c => c.Car)
                .FirstOrDefault();
            
            if (service == null)
            {
                service = new Service { CarId = (int)id, Car = _context.Cars.Where(c => c.Id == id).FirstOrDefault() };
            } else
            {
                service.OljniFilter = false;
                service.ZracniFilter = false;
                service.FilterGoriva = false;
                service.FilterKabine = false;
            }

            return View(service);
        }
        // POST: Cars/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,Znamka,Model,Letnik,VIN,kW,TipMotorja,RegOzn,StrankaId")] Car car)
        {
            if (id != car.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    
                    _context.Update(car);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!CarExists(car.Id))
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
            ViewData["StrankaId"] = new SelectList(_context.Customers, "Id", "Id", car.StrankaId);
            return View(car);
        }

        // GET: Cars/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var car = await _context.Cars
                .Include(c => c.Stranka)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (car == null)
            {
                return NotFound();
            }

            return View(car);
        }

        // POST: Cars/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var car = await _context.Cars.FindAsync(id);
            _context.Cars.Remove(car);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool CarExists(int id)
        {
            return _context.Cars.Any(e => e.Id == id);
        }
    }
}
