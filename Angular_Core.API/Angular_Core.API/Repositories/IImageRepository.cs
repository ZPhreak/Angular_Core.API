using System.Net;

namespace Angular_Core.API.Repositories
{
    public interface IImageRepository
    {
        Task<string> Upload(IFormFile file, string fileName);

    }
}
