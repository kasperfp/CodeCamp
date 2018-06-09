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
    [Route("api/ThemePark")]
    public class ThemeParkController : ControllerBase
    {
        private readonly ThemeParkContext _context;

        public ThemeParkController(ThemeParkContext context)
        {
            _context = context;

            if (_context.ThemeParks.Count() == 0)
            {
                _context.ThemeParks.Add(new ThemePark {
                    ThemeParkName = "Tivoli",
                    Latitude = 55.673684,
                    Longitude = 12.568147
                });
                _context.SaveChanges();
            }
        }
    }
}