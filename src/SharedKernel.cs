using System.Collections.Generic;

namespace LambdaExamples
{
    public static class SharedKernel
    {

        public static List<Shoe> ShoeList()
        {
            var returnMe = new List<Shoe>();

            for (int i = 0; i < 100; i++)
            {
                if (i % 5 == 0)
                {
                    returnMe.Add(new Shoe { Id = i, Category = "Running", Brand = "Brooks", ReleaseYear = i % 2 == 0 ? System.DateTime.Today.AddYears(0).Year : System.DateTime.Today.AddYears(1).Year });
                }
                else if (i % 4 == 0)
                {
                    returnMe.Add(new Shoe { Id = i, Category = "Leasure", Brand = "Nike", ReleaseYear = i % 2 == 0 ? System.DateTime.Today.AddYears(0).Year : System.DateTime.Today.AddYears(1).Year });
                }
                else if (i % 3 == 0)
                {
                    returnMe.Add(new Shoe { Id = i, Category = "Running", Brand = "Nike", ReleaseYear = i % 2 == 0 ? System.DateTime.Today.AddYears(0).Year : System.DateTime.Today.AddYears(1).Year });
                }
                else if (i % 2 == 0)
                {
                    returnMe.Add(new Shoe { Id = i, Category = "Leasure", Brand = "Adidas", ReleaseYear = i % 2 == 0 ? System.DateTime.Today.AddYears(0).Year : System.DateTime.Today.AddYears(1).Year });
                }
                else
                {
                    returnMe.Add(new Shoe { Id = i, Category = "Running", Brand = "Adidas", ReleaseYear = i % 2 == 0 ? System.DateTime.Today.AddYears(0).Year : System.DateTime.Today.AddYears(1).Year });
                }
            }

            return returnMe;
        }
    }

    public class Shoe
    {
        public int Id { get; set; }
        public string Category { get; set; }
        public string Brand { get; set; }
        public int ReleaseYear { get; set; }
    }
}