using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VidzyMovieRentalStore
{
    class Program
    {
        static void Main(string[] args)
        {
            var context = new VidzyContext();
            var video = new Video()
            {
                Name = "name",
                ReleaseDate = DateTime.Now,
                GenreId=2
            };

            //  context.Videos.Add(video);
            //   context.SaveChanges();



            //add video by calling a store procedure 
            context.AddVideo("name7", DateTime.Now, "Thriller",Classification.Platium);



        }
    }
}
