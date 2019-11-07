using System;
using System.Collections.Generic;
using System.Linq;

namespace LambdaExamples
{
    public class FilterListOnMultipleColumns
    {
        private readonly List<Shoe> _theList = new List<Shoe>();
        public FilterListOnMultipleColumns()
        {
            _theList = SharedKernel.ShoeList();
        }

        public List<Shoe> All()
        {
            return _theList;
        }

        public List<Shoe> ByBrand(string brand)
        {
            return _theList.Where(x => x.Brand == brand).ToList();
        }


        public List<ShoeByBrand> GroupByBrand()
        {
            var list = _theList.GroupBy(g => g.Brand).Select(s => new ShoeByBrand { Brand = s.Key, Count = s.Count() }).ToList();
            return list;
        }

        public List<ShoeByBrandCategory> GroupByBrandCategory()
        {
            var list = _theList.GroupBy(g => new { g.Brand, g.Category }).Select(s => new ShoeByBrandCategory { Brand = s.Key.Brand, Category = s.Key.Category, Count = s.Count() }).ToList();
            return list;
        }


        public List<Shoe> GetShoesByBrandCategory(int year)
        {
            var list = _theList.Where(x => x.ReleaseYear == year)
            .GroupBy(g => new { g.Brand, g.Category }).Select(s => new { Brand = s.Key.Brand, Category = s.Key.Category, Year = s.Max(m => m.ReleaseYear) }).ToList();

            List<Shoe> list1 = _theList.Where(x => list.Any(y => y.Brand == x.Brand && y.Category == x.Category && y.Year == x.ReleaseYear)).ToList();
            return list1;
        }
    }

    public class ShoeByBrandCategory
    {
        public string Brand { get; set; }
        public string Category { get; set; }
        public int Count { get; set; }
    }

    public class ShoeByBrand
    {
        public string Brand { get; set; }
        public int Count { get; set; }
    }
}