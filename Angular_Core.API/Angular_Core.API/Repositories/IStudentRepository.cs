using Angular_Core.API.DataModels;
using Microsoft.EntityFrameworkCore.Query.SqlExpressions;

namespace Angular_Core.API.Repositories
{
    public interface IStudentRepository
    {
        Task<List<Student>> GetStudentsAsync();
        Task<Student> GetStudentAsync(Guid studentId);

        Task<List<Gender>> GetGendersAsync();

        Task<bool> Exists(Guid studentId);

        Task<Student> UpdateStudent(Guid studentId, Student student);

        Task<Student> DeleteStudentAsync(Guid studentId);

        Task<Student> AddStudent(Student student);

        Task<bool> UpdateProfileImage(Guid studentId, string profileImageUrl);

    }
}
