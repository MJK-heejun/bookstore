using bookstore.Dto;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace bookstore.Controllers
{
    [Produces("application/json")]
    [Route("api/[controller]")]
    public class BooksController : Controller
    {
        private readonly ApplicationDbContext _context;

        public BooksController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: api/Books
        [HttpGet]
        public IEnumerable<BookDto> GetBooks([FromQuery] string title, string author, string genre = "")
        {
            IEnumerable<BookDto> result = _context.Books;
 
            if (!string.IsNullOrEmpty(title))
                result = result.Where(b => b.title.Contains(title));
            if (!string.IsNullOrEmpty(author))
                result = result.Where(b => b.author.Contains(author));
            int genreInt;
            if (!string.IsNullOrEmpty(genre) && int.TryParse(genre, out genreInt))
                result = result.Where(b => (int)b.genre == genreInt);

            return result;
        }
        
        // GET: api/Books/5
        [HttpGet("{id:int}")]
        public async Task<IActionResult> GetBookDto([FromRoute] int id)
        {
            if (!ModelState.IsValid)
                return BadRequest(ModelState);

            var bookDto = await _context.Books.SingleOrDefaultAsync(m => m.id == id);

            if (bookDto == null)
                return NotFound();

            return Ok(bookDto);
        }

        // PUT: api/Books/5
        [HttpPut("{id:int}")]
        public async Task<IActionResult> PutBookDto([FromRoute] int id, [FromBody] BookDto bookDto)
        {
            if (!ModelState.IsValid)
                return BadRequest(ModelState);

            if (id != bookDto.id)
                return BadRequest();

            _context.Entry(bookDto).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!BookDtoExists(id))
                    return NotFound();
                else
                    throw;
            }

            return NoContent();
        }

        // POST: api/Books
        [HttpPost]
        public async Task<IActionResult> PostBookDto([FromBody] BookDto bookDto)
        {
            if (!ModelState.IsValid)
                return BadRequest(ModelState);

            _context.Books.Add(bookDto);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetBookDto", new { id = bookDto.id }, bookDto);
        }

        // DELETE: api/Books/5
        [HttpDelete("{id:int}")]
        public async Task<IActionResult> DeleteBookDto([FromRoute] int id)
        {
            if (!ModelState.IsValid)
                return BadRequest(ModelState);

            var bookDto = await _context.Books.SingleOrDefaultAsync(m => m.id == id);
            if (bookDto == null)
                return NotFound();

            _context.Books.Remove(bookDto);
            await _context.SaveChangesAsync();

            return Ok(bookDto);
        }

        private bool BookDtoExists(int id)
        {
            return _context.Books.Any(e => e.id == id);
        }
        
    }

}