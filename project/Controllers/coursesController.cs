using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using project.Models;

namespace project.Controllers
{
    [Authorize]
    [Route("api/[controller]")]
    [ApiController]
    public class coursesController : ControllerBase
    {
        private readonly AppDbContext _context;

        public coursesController(AppDbContext context)
        {
            _context = context;
        }

        // GET: api/courses
        [HttpGet]
        public async Task<ActionResult<IEnumerable<courses>>> GetCourses()
        {
            return await _context.Courses.ToListAsync();
        }
       

        // GET: api/courses/5
        [HttpGet("{id}")]
        public async Task<ActionResult<courses>> Getcourses(int id)
        {
            var courses = await _context.Courses.FindAsync(id);

            if (courses == null)
            {
                return NotFound();
            }

            return courses;
        }

        // PUT: api/courses/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for
        // more details see https://aka.ms/RazorPagesCRUD.
        [HttpPut("{id}")]
        public async Task<IActionResult> Putcourses(int id, courses courses)
        {
            if (id != courses.CourseId)
            {
                return BadRequest();
            }

            _context.Entry(courses).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!coursesExists(id))
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

        // POST: api/courses
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for
        // more details see https://aka.ms/RazorPagesCRUD.
        [HttpPost]
        public async Task<ActionResult<courses>> Postcourses(courses courses)
        {
            _context.Courses.Add(courses);
            await _context.SaveChangesAsync();

            return CreatedAtAction("Getcourses", new { id = courses.CourseId }, courses);
        }

        // DELETE: api/courses/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<courses>> Deletecourses(int id)
        {
            var courses = await _context.Courses.FindAsync(id);
            if (courses == null)
            {
                return NotFound();
            }

            _context.Courses.Remove(courses);
            await _context.SaveChangesAsync();

            return courses;
        }

        private bool coursesExists(int id)
        {
            return _context.Courses.Any(e => e.CourseId == id);
        }
    }
}
