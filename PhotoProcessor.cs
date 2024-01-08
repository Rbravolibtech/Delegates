using System;

namespace Delegates
{
    // The PhotoProcessor class is responsible for processing photos.
    public class PhotoProcessor
    {
        public delegate void PhotoFilterHandler(Photo photo); 
        // The Process method takes a file path as a parameter and performs various photo processing tasks.
        public void Process(string path, PhotoFilterHandler filterHandler)
        {
            //System.Action<>

            //System.Func<>

            var photo = Photo.Load(path);

           filterHandler(photo);
            //// Load the photo from the specified path using the Photo class.
            //var photo = Photo.Load(path);

            //// Create an instance of the PhotoFilters class to apply filters to the photo.
            //var filters = new PhotoFilters();


            //filters.ApplyBrightness(photo);
            //filters.ApplyContrast(photo);
            //filters.Resize(photo);

            // Save the processed photo.
            photo.Save();
        }
    }
}
