using Angular_Core.API.DataModels;

namespace Angular_Core.API.Repositories
{
    public interface IStudentRepository
    {
        Task<List<Student>> GetStudentsAsync();
    }
}
