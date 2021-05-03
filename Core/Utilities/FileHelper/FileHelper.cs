using Core.Utilities.Results;
using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace Core.Utilities.FileHelper
{
    public class FileHelper
    {

        public static string Add(IFormFile image)
        {
            string directory = Environment.CurrentDirectory + @"\wwwroot\";
            string folder = Path.Combine(directory, "Images");
            string fileName = ChangeFileName(image.FileName);
            if (!Directory.Exists(folder))
            {
                Directory.CreateDirectory(folder);
            }
            using (FileStream fileStream = new FileStream(Path.Combine(folder, fileName), FileMode.Create))
            {
                image.CopyTo(fileStream);
            }

            return fileName;

        }
        public static IResult Delete(string path)
        {
            try
            {
                File.Delete(Environment.CurrentDirectory + @"\wwwroot\Images\" + path);
            }
            catch (Exception)
            {
                return new ErrorResult();
            }

            return new SuccessResult();
        }
        public static string Update(string updatedPath, IFormFile file)
        {
            File.Delete(Environment.CurrentDirectory + @"\wwwroot\Images\" + updatedPath);
            var result = Add(file);
            return result;
        }

        public static string ChangeFileName(string name)
        {
            string extension = Path.GetExtension(name);
            string newFileName = string.Format(@"resim_{0}{1}",  Guid.NewGuid(), extension);
            return newFileName;
        }
    }
}
