using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using FloralShop.Entity;

namespace FloralShop.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TypeProductsController : ControllerBase
    {
        private readonly FloralShopDbContext _context;

        public TypeProductsController(FloralShopDbContext context)
        {
            _context = context;
        }

        // GET: api/TypeProducts
        [HttpGet]
        public async Task<ActionResult<IEnumerable<TypeProduct>>> GetTypeProducts()
        {
            return await _context.TypeProducts.ToListAsync();
        }


        // GET: api/TypeProducts/5
        [HttpGet("{id}")]
        public async Task<ActionResult<TypeProduct>> GetTypeProduct(int id)
        {
            var typeProduct = await _context.TypeProducts.Include(tp => tp.Products).Where(tp => tp.ID == id).FirstOrDefaultAsync();

            if (typeProduct == null)
            {
                return NotFound();
            }

            return Ok(typeProduct);
        }

        // PUT: api/TypeProducts/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for
        // more details see https://aka.ms/RazorPagesCRUD.
        [HttpPut("{id}")]
        public async Task<IActionResult> PutTypeProduct(int id, TypeProduct typeProduct)
        {
            if (id != typeProduct.ID)
            {
                return BadRequest();
            }

            _context.Entry(typeProduct).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!TypeProductExists(id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return NoContent();
        }

        // POST: api/TypeProducts
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for
        // more details see https://aka.ms/RazorPagesCRUD.
        [HttpPost]
        public async Task<ActionResult<TypeProduct>> PostTypeProduct(TypeProduct typeProduct)
        {
            _context.TypeProducts.Add(typeProduct);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetTypeProduct", new { id = typeProduct.ID }, typeProduct);
        }

        // DELETE: api/TypeProducts/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<TypeProduct>> DeleteTypeProduct(int id)
        {
            var typeProduct = await _context.TypeProducts.FindAsync(id);
            if (typeProduct == null)
            {
                return NotFound();
            }

            _context.TypeProducts.Remove(typeProduct);
            await _context.SaveChangesAsync();

            return typeProduct;
        }

        private bool TypeProductExists(int id)
        {
            return _context.TypeProducts.Any(e => e.ID == id);
        }

        [HttpGet]
        [Route("home")]
        public async Task<ActionResult<IEnumerable<TypeProduct>>> HomeTypeProducts()
        {
            return await _context.TypeProducts.Take(4).ToListAsync();
        }
    }
}
