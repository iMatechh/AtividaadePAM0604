using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json;
using System.Threading.Tasks;
using CopaHAS.Data;
using CopaHAS.Migrations;
using CopaHAS.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;


namespace CopaHAS.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class EstadioController : ControllerBase
    {

        private readonly DataContext _context;

        public EstadioController(DataContext context)
        {
            _context = context;
        }

   [HttpGet("GetAll")]
        public async Task<IActionResult> GetAll()
        {
            try
            {
               List<Estadio> e = await _context.TB_ESTADIO
                     .ToListAsync();
                return Ok(e);
            }
            catch (System.Exception ex)
            {
                return BadRequest(ex.Message + " - " + ex.InnerException);
            }
        }

    }
}