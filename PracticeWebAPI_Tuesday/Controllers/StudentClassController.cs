using AutoMapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using PracticeWebAPI_Tuesday.Data;
using PracticeWebAPI_Tuesday.DTO;
using PracticeWebAPI_Tuesday.Model;

namespace PracticeWebAPI_Tuesday.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class StudentClassController : ControllerBase
    {
        private readonly IMapper _mapper;
        private readonly ApplicationDbContext _context;

        public StudentClassController(IMapper mapper,ApplicationDbContext context)
        {
            _mapper = mapper;
            _context = context;
        }
        // Get Method
        [HttpGet]
        public async Task<IActionResult> Get()
        {
            var product = await _context.Students.ToListAsync();
            //var model = await _context.Students.Select(c => new StudentClassDTO
            //{
            //    StudentId = c.StudentId,
            //    StudentName = c.StudentName,
            //    DateOfBirth = c.DateOfBirth
            //}).ToListAsync();

            var model = _mapper.Map<List<StudentClassDTO>>(product);         
            return Ok(model);
        }

        [HttpGet("{id}")]
        public async Task<IActionResult>Get(int id)
        {
            //var product = await _context.Students.Include(c => c.Enrollments)
            //    .FirstOrDefaultAsync(c => c.StudentId == id);
            //var model = new StudentDTO
            //{
            //    StudentId = product.StudentId,
            //    StudentName = product.StudentName,
            //    DateOfBirth = product.DateOfBirth,
            //    Enrollments = product.Enrollments.Select(e => new EnrollmentDTO
            //    {
            //        CourseId = e.CourseId
            //    }).ToList(),
            //};
            var product = await _context.Students.Include(c => c.Enrollments)
                .FirstOrDefaultAsync(c => c.StudentId == id);
            var model = _mapper.Map<StudentDTO>(product);
            return Ok(model);
        }
        // PostAction
        [HttpPost]
        public async Task<IActionResult> Post(StudentCreateDTO studentClassDTO)
        {
            //var model = new StudentClass
            //{           
            //    StudentName = studentClassDTO.StudentName,
            //    DateOfBirth = studentClassDTO.DateOfBirth
            //};
            var model = _mapper.Map<StudentClass>(studentClassDTO);
            await _context.Students.AddAsync(model);
            await _context.SaveChangesAsync();

            return Ok(model);
        }
        // Edit
        [HttpPut("{id}")]
        public async Task<IActionResult> Put (int id, StudentCreateDTO studentClassDTO)
        {
            var product = await _context.Students.FirstOrDefaultAsync(c => c.StudentId == id);
            
            if (product == null)
            {
                return BadRequest("Not Found");
            }


            product.StudentName = studentClassDTO.StudentName;
            product.DateOfBirth = studentClassDTO.DateOfBirth;

            await _context.SaveChangesAsync();

            return NoContent();
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(int id)
        {
            var product = await _context.Students.FindAsync(id);

            if (product == null)
            {
                return BadRequest("Not Found");
            }

             _context.Students.Remove(product);
            await _context.SaveChangesAsync();
            return NoContent();
        }
    }
}
