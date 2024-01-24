using System;
using api.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace api.Services
{
	public class StorageService : IStorageService
	{
        public FileStreamResult GetFile(string name)
        {
            var filePath = Path.Combine(Directory.GetCurrentDirectory(), "assets", "cars", name);
            var fileStream = new FileStream(filePath, FileMode.Open, FileAccess.Read, FileShare.Read);
            var contentType = "application/octet-stream";
            return new FileStreamResult(fileStream, contentType);
        }

        public async Task<string> SaveFile(IFormFile file)
        {
            if (file == null || file.Length == 0)
            {
                throw new ArgumentException("No file uploaded");
            }

            // Save the uploaded file
            var filePath = "assets/cars/" + file.FileName;
            using (var stream = new FileStream(filePath, FileMode.Create))
            {
                await file.CopyToAsync(stream);
            }
            return filePath;
        }
    }
}

