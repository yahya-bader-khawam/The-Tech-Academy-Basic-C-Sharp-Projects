using Microsoft.AspNetCore.Mvc;
using CarInsurance.Models;
using System;
using System.Collections.Generic;

namespace CarInsurance.Controllers
{
    public class InsureeController : Controller
    {
        // This acts as a temporary database for now
        private static List<Insuree> _insurees = new List<Insuree>();

        [HttpGet]
        public IActionResult Create() => View();

        [HttpPost]
        public IActionResult Create(Insuree insuree)
        {
            decimal monthlyQuote = 50; // Base price

            // Age Calculation
            int age = DateTime.Now.Year - insuree.DateOfBirth.Year;
            if (DateTime.Now < insuree.DateOfBirth.AddYears(age)) age--;

            if (age <= 18) monthlyQuote += 100;
            else if (age >= 19 && age <= 25) monthlyQuote += 50;
            else monthlyQuote += 25;

            // Car Year
            if (insuree.CarYear < 2000 || insuree.CarYear > 2015) monthlyQuote += 25;

            // Porsche Logic
            if (insuree.CarMake?.ToLower() == "porsche")
            {
                monthlyQuote += 25;
                if (insuree.CarModel?.ToLower() == "911 carrera") monthlyQuote += 25;
            }

            // Tickets, DUI, Coverage
            monthlyQuote += (insuree.SpeedingTickets * 10);
            if (insuree.DUI) monthlyQuote *= 1.25m;
            if (insuree.FullCoverage) monthlyQuote *= 1.50m;

            insuree.Quote = monthlyQuote;
            _insurees.Add(insuree);

            return RedirectToAction("Admin");
        }

        public IActionResult Admin()
        {
            return View(_insurees);
        }
    }
}