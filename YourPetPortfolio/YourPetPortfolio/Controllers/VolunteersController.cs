﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using YourPetPortfolio.Models;

namespace YourPetPortfolio.Controllers
{
    public class VolunteersController : Controller
    {
        private readonly AnimalRescueContext _context;

        public VolunteersController(AnimalRescueContext context)
        {
            _context = context;
        }

        // GET: Volunteers
        public async Task<IActionResult> Index()
        {
            var animalRescueContext = _context.Volunteers.Include(v => v.Animal);
            return View(await animalRescueContext.ToListAsync());
        }

        // GET: Volunteers/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var volunteers = await _context.Volunteers
                .Include(v => v.Animal)
                .FirstOrDefaultAsync(m => m.VolunteerId == id);
            if (volunteers == null)
            {
                return NotFound();
            }

            return View(volunteers);
        }

        // GET: Volunteers/Create
        public IActionResult Create()
        {
            ViewData["AnimalId"] = new SelectList(_context.Animals, "AnimalId", "AnimalId");
            return View();
        }

        // POST: Volunteers/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("VolunteerId,FirstName,LastName,Position,Age,StartDate,AnimalId")] Volunteers volunteers)
        {
            if (ModelState.IsValid)
            {
                _context.Add(volunteers);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["AnimalId"] = new SelectList(_context.Animals, "AnimalId", "AnimalId", volunteers.AnimalId);
            return View(volunteers);
        }

        // GET: Volunteers/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var volunteers = await _context.Volunteers.FindAsync(id);
            if (volunteers == null)
            {
                return NotFound();
            }
            ViewData["AnimalId"] = new SelectList(_context.Animals, "AnimalId", "AnimalId", volunteers.AnimalId);
            return View(volunteers);
        }

        // POST: Volunteers/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("VolunteerId,FirstName,LastName,Position,Age,StartDate,AnimalId")] Volunteers volunteers)
        {
            if (id != volunteers.VolunteerId)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(volunteers);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!VolunteersExists(volunteers.VolunteerId))
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
            ViewData["AnimalId"] = new SelectList(_context.Animals, "AnimalId", "AnimalId", volunteers.AnimalId);
            return View(volunteers);
        }

        // GET: Volunteers/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var volunteers = await _context.Volunteers
                .Include(v => v.Animal)
                .FirstOrDefaultAsync(m => m.VolunteerId == id);
            if (volunteers == null)
            {
                return NotFound();
            }

            return View(volunteers);
        }

        // POST: Volunteers/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var volunteers = await _context.Volunteers.FindAsync(id);
            _context.Volunteers.Remove(volunteers);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool VolunteersExists(int id)
        {
            return _context.Volunteers.Any(e => e.VolunteerId == id);
        }
    }
}
