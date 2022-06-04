using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace UI_Layer.Models
{
    public class AddProfileImage
    {
        public void ImageAdd(IFormFile image, out string imageName)
        {
            var extension = Path.GetExtension(image.FileName);
            var newImageName = Guid.NewGuid() + extension;
            var location = Path.Combine(Directory.GetCurrentDirectory(),"wwwroot/ImageFiles/",newImageName);
            var stream = new FileStream(location, FileMode.Open);
            image.CopyTo(stream);
            imageName = image.FileName;            
        }
    }
}
