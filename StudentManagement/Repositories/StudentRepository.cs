using Microsoft.EntityFrameworkCore;
using StudentManagement.Data;
using StudentManagement.DTOs;
using StudentManagement.Interfaces;
using StudentManagement.Models;

namespace StudentManagement.Repositories
{
    public class StudentRepository : IStudentRepository
    {
        private readonly AppDbContext _context;

        public StudentRepository(AppDbContext context)
        {
            _context = context;
        }

        public async Task<PagedResult<StudentDto>> GetAllAsync(int page, int pageSize, string? search, string? sortBy, bool ascending)
        {
            if (page < 1)
                page = 1;

            if (pageSize < 1)
                pageSize = 10;

            var query = _context.Students.AsQueryable();

            if (!string.IsNullOrWhiteSpace(search))
            {
                search = search.Trim();

                query = query.Where(s =>
                    s.Id.ToString().Contains(search) ||
                    s.StudentFirstName.Contains(search) ||
                    s.StudentLastName.Contains(search));
            }

            query = sortBy switch
            {
                "Id" => ascending
                    ? query.OrderBy(x => x.Id)
                    : query.OrderByDescending(x => x.Id),

                "StudentFirstName" => ascending
                    ? query.OrderBy(x => x.StudentFirstName)
                    : query.OrderByDescending(x => x.StudentFirstName),

                "StudentLastName" => ascending
                    ? query.OrderBy(x => x.StudentLastName)
                    : query.OrderByDescending(x => x.StudentLastName),

                _ => query.OrderBy(x => x.Id)
            };

            var totalCount = await query.CountAsync();

            var items = await query
                .AsNoTracking()
                .Skip((page - 1) * pageSize)
                .Take(pageSize)
                .Select(s => new StudentDto
                {
                    Id = s.Id,
                    StudentFirstName = s.StudentFirstName,
                    StudentLastName = s.StudentLastName
                })
                .ToListAsync();

            return new PagedResult<StudentDto>
            {
                Items = items,
                TotalCount = totalCount,
                Page = page,
                PageSize = pageSize
            };
        }

        public async Task<Student?> GetByIdAsync(int id)
        {
            return await _context.Students
                .AsNoTracking()
                .FirstOrDefaultAsync(x => x.Id == id);
        }

        public async Task<Student> CreateAsync(Student student)
        {
            _context.Students.Add(student);
            await _context.SaveChangesAsync();

            return student;
        }

        public async Task<bool> UpdateAsync(Student student)
        {
            var existing = await _context.Students.FindAsync(student.Id);

            if (existing == null)
                return false;

            existing.StudentFirstName = student.StudentFirstName;
            existing.StudentLastName = student.StudentLastName;

            await _context.SaveChangesAsync();

            return true;
        }

        public async Task<bool> DeleteAsync(int id)
        {
            var student = await _context.Students.FindAsync(id);

            if (student == null)
                return false;

            _context.Students.Remove(student);

            await _context.SaveChangesAsync();

            return true;
        }
    }
}
