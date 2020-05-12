using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AboneApp.API.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace AboneApp.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AbonesController : ControllerBase
    {
        private readonly DataContext _context;

        public AbonesController(DataContext context)
        {
            _context = context;

        }
        // GET api/abones
        [HttpGet]
        public async Task<IActionResult> Get()
        {
            var value = await _context.Abones.ToListAsync();
            return Ok(value);
            //return new string[] { "value1", "value2" };
        }

        // GET api/abones/5
        [HttpGet("{id}")]
        public async Task<IActionResult> Get(int id)
        {
            var value = await _context.Abones.FirstOrDefaultAsync(x=>x.Id==id);
            return Ok(value);
            //return "value";
        }

        // POST api/abones
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT api/abones/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/abones/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
