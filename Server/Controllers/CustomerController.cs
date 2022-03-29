using BlazorCRUD.Server.Data;
using BlazorCRUD.Shared.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlazorCRUD.Server.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CustomerController : ControllerBase
    {
        private readonly ApplicationDBContext _context;
        public CustomerController(ApplicationDBContext context)
        {
            this._context = context;
        }
        [HttpGet]
        public async Task<IActionResult> Get()
        {
            var custs = await _context.Customers.ToListAsync();
            return Ok(custs);
        }
        [HttpGet("{id}")]
        public async Task<IActionResult> Get(int id)
        {
            var custs = await _context.Customers.FirstOrDefaultAsync(a => a.Id == id);
            return Ok(custs);
        }
        [HttpPost]
        public async Task<IActionResult> Post(Customer customer)
        {
            _context.Add(customer);
            await _context.SaveChangesAsync();
            return Ok(customer.Id);
        }
        [HttpPut]
        public async Task<IActionResult> Put(Customer customer)
        {
            _context.Entry(customer).State = EntityState.Modified;
            await _context.SaveChangesAsync();
            return NoContent();
        }
        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(int id)
        {
            var dev = new Customer { Id = id };
            _context.Remove(dev);
            await _context.SaveChangesAsync();
            return NoContent();
        }
    }

}