using System.Collections.Generic;
using System.Linq;
using LambdaExamples;

namespace LambdaExamples
{
    public class ListManipulation
    {
        public ListManipulation()
        {
        }

        public List<Shoe> RemoveBrand(string brand)
        {
            var theList = SharedKernel.ShoeList();

            theList.RemoveAll(x => x.Brand == brand);
            return theList;
        }


        public List<Shoe> RemoveWhereInList(List<RemoveMe> removeMe)
        {
            var theList = SharedKernel.ShoeList();

            theList.RemoveAll(x => removeMe.Any(y => y.Brand == x.Brand && y.Category == x.Category));
            return theList;
        }

        public List<Shoe> RemoveWhereNotInList(List<RemoveMe> removeMe)
        {
            var theList = SharedKernel.ShoeList();

            theList.RemoveAll(x => !removeMe.Any(y => y.Brand == x.Brand && y.Category == x.Category));
            return theList;
        }
<<<<<<< HEAD

        public List<Shoe> GetTopNShoes(int n)
        {
            var theList = SharedKernel.ShoeList();

            return theList.Take(n).ToList();
        }
=======
>>>>>>> c44c9ce19d8f61cadfe396f67fd9659edb7a7fd2
    }

    public class RemoveMe
    {
        public string Category { get; }
        public string Brand { get; }
        public RemoveMe(string brand, string category)
        {
            Brand = brand;
            Category = category;
        }
    }
}