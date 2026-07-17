using StudentManagement.DTOs;
using StudentManagement.Models;

namespace StudentManagement.Interfaces
{
    public interface IStudentRepository
    {
        Task<PagedResult<StudentDto>> GetAllAsync(int page, int pageSize, string? search, string? sortBy, bool ascending);

        Task<Student?> GetByIdAsync(int id);

        Task<Student> CreateAsync(Student student);

        Task<bool> UpdateAsync(Student student);

        Task<bool> DeleteAsync(int id);
    }
}
