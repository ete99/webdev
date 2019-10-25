using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using EApp.API.Data;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;

namespace EApp.API.Controllers
{
    [Authorize] // using this methods require authorization
    [ApiController]
    [Route("api/[controller]")]
    public class valuesController : ControllerBase
    {
        private readonly DataContext _context;
        public valuesController(DataContext context)
        {
            _context = context;

        }
        [AllowAnonymous]
        [HttpGet]
        public async Task<IActionResult> GetValues()
        {
            var values = await _context.Values.ToListAsync();
            return Ok(values);
        }
        [AllowAnonymous] // anyone can use without authorization
        [HttpGet("{id}")]
        public async Task<IActionResult> GetValue(int id)
        {
            var value = await _context.Values.FirstOrDefaultAsync(x => x.Id == id);
            return Ok(value);
        }
    }
}