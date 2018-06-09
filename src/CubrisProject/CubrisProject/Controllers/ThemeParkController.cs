using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using CubrisProject.Models;

namespace CubrisProject.Controllers
{
    [Produces("application/json")]
    [Route("api/ThemeParks")]
    public class ThemeParkController : ControllerBase
    {
        private readonly ThemeParkContext _context;

        public ThemeParkController(ThemeParkContext context)
        {
            _context = context;
        }

        [HttpGet("{id}", Name = "GetThemePark")]
        public ThemePark GetById(int id)
        {
            var themePark = _context.ThemeParks.Find(id);
            if (themePark == null)
            {
                return null;
            }
            return themePark;
        }

        [HttpGet("[action]")]
        public IEnumerable<ThemePark> GetAll()
        {
            return _context.ThemeParks.ToList();
        }

        [HttpPost]
        public IActionResult Create([FromBody] ThemePark themePark)
        {
            _context.ThemeParks.Add(themePark);

            _context.SaveChanges();

            return CreatedAtRoute("GetThemePark", new { id = themePark.ThemeParkId }, themePark);
        }

        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            var themePark = _context.ThemeParks.Find(id);
            if (themePark == null)
            {
                return NotFound();
            }

            _context.ThemeParks.Remove(themePark);
            _context.SaveChanges();
            return NoContent();
        }

        [HttpPut("{id}")]
        public IActionResult Update(int id, [FromBody] ThemePark item)
        {
            var themePark = _context.ThemeParks.Find(id);
            if (themePark == null)
            {
                return NotFound();
            }

            themePark.ThemeParkName = item.ThemeParkName;
            themePark.Longitude = item.Longitude;
            themePark.Latitude = item.Latitude;

            _context.ThemeParks.Update(themePark);
            _context.SaveChanges();
            return NoContent();
        }
    }
}