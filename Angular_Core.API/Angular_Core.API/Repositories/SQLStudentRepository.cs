using Angular_Core.API.DataModels;
using Microsoft.EntityFrameworkCore;

namespace Angular_Core.API.Repositories
{
    public class SQLStudentRepository : IStudentRepository
    {
        private readonly AngularCoreContext context;

        public SQLStudentRepository(AngularCoreContext context)
        {
            this.context = context;
        }
        public async Task<List<Student>> GetStudentsAsync()
        {
            return await context.Student.Include(nameof(Gender)).Include(nameof(Address)).ToListAsync();
        }

    }
}
