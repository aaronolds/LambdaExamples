using Shouldly;
using Xunit;
using System.Linq;

namespace LambdaExamplesTests
{
    public class FilterListOnMultipleColumnsUnitTest
    {
        [Fact]
        public void NoFilterTest()
        {
            var x = new LambdaExamples.FilterListOnMultipleColumns();
            var list = x.All();
            list.ShouldNotBeEmpty();
            list.Count.ShouldBe(100);
        }

        [Fact]
        public void GetNikesTest()
        {
            var x = new LambdaExamples.FilterListOnMultipleColumns();
            var list = x.ByBrand("Nike");
            list.ShouldNotBeEmpty();
            list.Count.ShouldBe(40);
        }


        [Fact]
        public void GetBrooksTest()
        {
            var x = new LambdaExamples.FilterListOnMultipleColumns();
            var list = x.ByBrand("Brooks");
            list.ShouldNotBeEmpty();
            list.Count.ShouldBe(20);
        }


        [Fact]
        public void GetAdidasTest()
        {
            var x = new LambdaExamples.FilterListOnMultipleColumns();
            var list = x.ByBrand("Adidas");
            list.ShouldNotBeEmpty();
            list.Count.ShouldBe(40);
        }

        [Fact]
        public void GetBrandGroupByTest()
        {
            var x = new LambdaExamples.FilterListOnMultipleColumns();
            var list = x.GroupByBrand();
            list.ShouldNotBeEmpty();
            list.First(c => c.Brand == "Nike").Count.ShouldBe(40);
            list.First(c => c.Brand == "Brooks").Count.ShouldBe(20);
            list.First(c => c.Brand == "Adidas").Count.ShouldBe(40);
        }

        [Fact]
        public void GetBrandCategoryGroupByTest()
        {
            var x = new LambdaExamples.FilterListOnMultipleColumns();
            var list = x.GroupByBrandCategory();
            list.ShouldNotBeEmpty();
        }

        [Fact]
        public void GetShowListBrandCategoryGroupByTest()
        {
            var x = new LambdaExamples.FilterListOnMultipleColumns();
            var list = x.GetShoesByBrandCategory(System.DateTime.Today.Year);
            list.ShouldNotBeEmpty();
            list.Count.ShouldBe(50);
        }
    }
}
