using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using StudentManagement.DTOs;
using StudentManagement.Interfaces;
using StudentManagement.Models;

namespace StudentManagement.Controllers
{
    [Authorize]
    [ApiController]
    [Route("student")]
    public class StudentController : ControllerBase
    {
        private readonly IStudentRepository _repository;

        public StudentController(IStudentRepository repository)
        {
            _repository = repository;
        }

        [HttpGet]
        public async Task<ActionResult<PagedResult<StudentDto>>> GetAll(int page = 1, int pageSize = 10, string? search = null, string? sortBy = null, bool ascending = true)
        {
            var result = await _repository.GetAllAsync(page, pageSize, search, sortBy, ascending);

            return Ok(result);
        }

        [HttpGet("{id:int}")]
        public async Task<ActionResult<Student>> GetById(int id)
        {
            var student = await _repository.GetByIdAsync(id);

            if (student == null)
                return NotFound();

            return Ok(student);
        }

        [HttpPost]
        public async Task<ActionResult<Student>> Create(StudentDto dto)
        {
            var student = new Student
            {
                StudentFirstName = dto.StudentFirstName,
                StudentLastName = dto.StudentLastName
            };

            await _repository.CreateAsync(student);

            return CreatedAtAction(
                nameof(GetById),
                new { id = student.Id },
                student);
        }

        [HttpPut("{id:int}")]
        public async Task<IActionResult> Update(int id, StudentDto dto)
        {
            var student = new Student
            {
                Id = id,
                StudentFirstName = dto.StudentFirstName,
                StudentLastName = dto.StudentLastName
            };

            var updated = await _repository.UpdateAsync(student);

            if (!updated)
                return NotFound();

            return NoContent();
        }

        [HttpDelete("{id:int}")]
        public async Task<IActionResult> Delete(int id)
        {
            var deleted = await _repository.DeleteAsync(id);

            if (!deleted)
                return NotFound();

            return NoContent();
        }
    }
}
