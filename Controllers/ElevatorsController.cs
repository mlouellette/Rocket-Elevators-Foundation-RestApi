#nullable disable
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Rocket_Elevators_Rest_API.Models;

namespace Rocket_Elevators_Rest_API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ElevatorsController : ControllerBase
    {
        private readonly RocketElevatorsContext _context;

        public ElevatorsController(RocketElevatorsContext context)
        {
            _context = context;
        }

        // GET: api/Elevators
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Elevator>>> GetElevators()
        {
            return await _context.elevators.ToListAsync();
        }

        // GET: api/Elevators/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Elevator>> Get(int id)
        {
            var elevator = await _context.elevators.FindAsync(id);

            if (elevator == null)
            {
                return NotFound();
            }

            return elevator;
        }

        [HttpPut("{id}/status/{status}")]
        public async Task<ActionResult<Elevator>> Put(int id, string status)
        {
            // grab battery with id id
            var elevator = await _context.elevators.FindAsync(id);
            
            if(elevator == null) {
                return NotFound();
            }
            // change status of battery
            elevator.status = status;
            _context.SaveChanges();

            return elevator;
        }

        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpGet("status")]
         public async Task<ActionResult<IEnumerable<Elevator>>> GetElevatorStat()
        {
            return await _context.elevators.Where(e=>(e.elevator_status == "Inactive")).ToListAsync();
        }

        // DELETE: api/Elevators/5
        [HttpDelete("{id}")]
         public void Delete(int id)
        {
        }
    }
}
