using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace ContentManagementSystem.Helpers
{
    public static class FileHelper
    {
        /// <summary>
        /// Uploads the file to local server and returns the filename to be saved on the database
        /// </summary>
        /// <param name="formFile"></param>
        /// <param name="hostingEnv"></param>
        /// <returns>File name</returns>
        public static string ProcessFileUpload(IFormFile formFile, IWebHostEnvironment hostingEnv)
        {
            string uniqueFileName = null;

            if(formFile != null)
            {
                string uploadsFolder = Path.Combine(hostingEnv.WebRootPath, "files");

                uniqueFileName = Guid.NewGuid().ToString() + "_" + formFile.FileName;

                string filePath = Path.Combine(uploadsFolder, uniqueFileName);

                using (var fileStream = new FileStream(filePath, FileMode.Create))
                {
                    formFile.CopyTo(fileStream);
                }
            }

            return uniqueFileName;
        }

        // TO:DO filter out certain file names.
    }
}
