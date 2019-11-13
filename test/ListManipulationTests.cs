using Shouldly;
using Xunit;
using System.Linq;
using System.Collections.Generic;

namespace LambdaExamplesTests
{
    public class ListManipulationTests
    {
        [Fact]
        public void RemoveBrandTest()
        {
            var x = new LambdaExamples.ListManipulation();
            var list = x.RemoveBrand("Brooks");
            list.ShouldNotBeEmpty();
            list.Count(x => x.Brand == "Brooks").ShouldBe(0);
        }

        [Fact]
        public void RemoveBrandListTest()
        {
            var x = new LambdaExamples.ListManipulation();
            var list = x.RemoveWhereInList(new List<LambdaExamples.RemoveMe> { new LambdaExamples.RemoveMe("Nike", "Running") });
            list.ShouldNotBeEmpty();
            list.Count(x => x.Brand == "Nike" && x.Category == "Running").ShouldBe(0);
        }
       
        [Fact]
        public void RemoveBrandNotListTest()
        {
            var x = new LambdaExamples.ListManipulation();
            var list = x.RemoveWhereNotInList(new List<LambdaExamples.RemoveMe> { new LambdaExamples.RemoveMe("Nike", "Running") });
            list.ShouldNotBeEmpty();
            list.Count(x => x.Brand == "Nike" && x.Category == "Running").ShouldNotBe(0);
        }

        [Theory]
        [InlineData(1)]
        [InlineData(5)]
        public void GetNShoesTest(int n)
        {
            var x = new LambdaExamples.ListManipulation();
            var list = x.GetTopNShoes(n);
            list.ShouldNotBeEmpty();
            list.Count.ShouldBe(n);
        }
    }
}