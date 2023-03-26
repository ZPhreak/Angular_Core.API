namespace Angular_Core.API.Repositories
{
    public class LocalStorageImageRepository : IImageRepository
    {
        public async Task<string> Upload(IFormFile file, string fileName)
        {
            var filePath = Path.Combine(Directory.GetCurrentDirectory(), @"Resources\Images", fileName);
            using Stream fileStream = new FileStream(filePath, FileMode.Create);
            file.CopyToAsync(fileStream);
            return GetServerRelativePath(fileName);

        }

        private  string GetServerRelativePath(string fileName)
        {
            return Path.Combine(@"Resources\Images", fileName);
        }
    }
}
