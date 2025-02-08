using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.Json;
namespace AWSSDK_DotNet.UnitTests.TestTools
{
    [TestClass]
    public class ComparerTests
    {
        [TestMethod][TestCategory("UnitTest")]
        public void TestDoubleParsing()
        {
            var str = double.MaxValue.ToString("R", System.Globalization.CultureInfo.InvariantCulture);
            //var str = Convert.ToString (double.MaxValue, System.Globalization.NumberFormatInfo.InvariantInfo);
            double d = 0;
            Double.TryParse(str, System.Globalization.NumberStyles.Any, System.Globalization.CultureInfo.InvariantCulture, out d);
            Assert.AreEqual(double.MaxValue, d);
        }

        [TestMethod][TestCategory("UnitTest")]
        public void TestBasicComparisions()
        {   
            Comparer.CompareObjects<string>(null, null);

            Utils.AssertExceptionExpected(()=>Comparer.CompareObjects<string>(null, string.Empty));
            Comparer.CompareObjects<string>("aa", "aa");
            Utils.AssertExceptionExpected(() => Comparer.CompareObjects<string>("aa", "ab"));
            Comparer.CompareObjects<int>(10, 10);
            Utils.AssertExceptionExpected(() => Comparer.CompareObjects<int>(10, 12));
            Comparer.CompareObjects<int?>(10, 10);
            Utils.AssertExceptionExpected(() => Comparer.CompareObjects<int?>(10, 12));
            Utils.AssertExceptionExpected(() => 
                Comparer.CompareObjects<DateTime>(DateTime.MinValue, DateTime.MinValue));
            Utils.AssertExceptionExpected(() => 
                Comparer.CompareObjects<DateTime>(DateTime.MinValue, DateTime.MinValue.AddSeconds(1)));
        }

        [TestMethod][TestCategory("UnitTest")]
        public void TestCollectionAndMapComparisions()
        {
            Comparer.CompareObjects<List<string>>(
                new List<string> { "a", "b" },
                new List<string> { "a", "b" });
            Utils.AssertExceptionExpected(() => Comparer.CompareObjects<List<string>>(
                new List<string> { "a", "b" },
                new List<string> { "b", "a" }));
            Utils.AssertExceptionExpected(() => Comparer.CompareObjects<List<string>>(
                new List<string> { "a", "b" },
                new List<string> { "a" }));
            Utils.AssertExceptionExpected(() => Comparer.CompareObjects<List<string>>(
                new List<string> { "a", "b" },
                new List<string> { "a", "c" }));

            Comparer.CompareObjects<Dictionary<int, string>>(
                new Dictionary<int, string> { { 10, "a" }, { 20, "b" } },
                new Dictionary<int, string> { { 10, "a" }, { 20, "b" } });
            Comparer.CompareObjects<Dictionary<int, string>>(
               new Dictionary<int, string> { { 10, "a" }, { 20, "b" } },
               new Dictionary<int, string> { { 20, "b" }, { 10, "a" } });
            Utils.AssertExceptionExpected(() => Comparer.CompareObjects<Dictionary<int, string>>(
                new Dictionary<int, string> { { 10, "a" }, { 20, "b" } },
                new Dictionary<int, string> { { 10, "a" }, { 20, "c" } }));
            Utils.AssertExceptionExpected(() => Comparer.CompareObjects<Dictionary<int, string>>(
                new Dictionary<int, string> { { 10, "a" }, { 20, "b" } },
                new Dictionary<int, string> { { 10, "a" }, { 30, "b" } }));
            Utils.AssertExceptionExpected(() => Comparer.CompareObjects<Dictionary<int, string>>(
                new Dictionary<int, string> { { 10, "a" }, { 20, "b" } },
                new Dictionary<int, string> { { 10, "a" } }));
        }

        [TestMethod][TestCategory("UnitTest")]
        public void TestComplexTypeComparisions()
        {
            Comparer.CompareObjects<Product>(
                new Product
                {
                    Id = 1,
                    LastStocked = DateTime.SpecifyKind(DateTime.MinValue, DateTimeKind.Utc),
                    Name = "A",
                    Price = 10,
                    Qty = 5,
                    TagMap = new Dictionary<string, Tag> {
                        { "B", new Tag { Id = 1, Name = "B" } }, { "C", new Tag { Id = 1, Name = "C" } } },
                    Tags = new List<Tag> { new Tag { Id = 1, Name = "B" }, new Tag { Id = 1, Name = "C" } }
                },
                new Product
                {
                    Id = 1,
                    LastStocked = DateTime.SpecifyKind(DateTime.MinValue, DateTimeKind.Utc),
                    Name = "A",
                    Price = 10,
                    Qty = 5,
                    TagMap = new Dictionary<string, Tag> {
                        { "B", new Tag { Id = 1, Name = "B" } }, { "C", new Tag { Id = 1, Name = "C" } } },
                    Tags = new List<Tag> { new Tag { Id = 1, Name = "B" }, new Tag { Id = 1, Name = "C" } }
                });

            Utils.AssertExceptionExpected(() => Comparer.CompareObjects<Product>(
                new Product
                {
                    Id = 1,
                    LastStocked = DateTime.SpecifyKind(DateTime.MinValue, DateTimeKind.Utc),
                    Name = "A",
                    Price = 10,
                    Qty = 5,
                    TagMap = new Dictionary<string, Tag> {
                        { "B", new Tag { Id = 1, Name = "B" } }, { "C", new Tag { Id = 2, Name = "D" } } },
                    Tags = new List<Tag> { new Tag { Id = 1, Name = "B" }, new Tag { Id = 1, Name = "C" } }
                },
                new Product
                {
                    Id = 1,
                    LastStocked = DateTime.SpecifyKind(DateTime.MinValue, DateTimeKind.Utc),
                    Name = "A",
                    Price = 10,
                    Qty = 5,
                    TagMap = new Dictionary<string, Tag> {
                        { "B", new Tag { Id = 1, Name = "B" } }, { "C", new Tag { Id = 2, Name = "C" } } },
                    Tags = new List<Tag> { new Tag { Id = 1, Name = "B" }, new Tag { Id = 2, Name = "C" } }
                }));

            Utils.AssertExceptionExpected(() => Comparer.CompareObjects<Product>(
                new Product
                {
                    Id = 1,
                    LastStocked = DateTime.SpecifyKind(DateTime.MinValue, DateTimeKind.Utc),
                    Name = "A",
                    Price = 10,
                    Qty = 5,
                    TagMap = new Dictionary<string, Tag> {
                        { "B", new Tag { Id = 1, Name = "B" } }, { "C", new Tag { Id = 1, Name = "C" } } },
                    Tags = new List<Tag> { new Tag { Id = 1, Name = "D" }, new Tag { Id = 2, Name = "C" } }
                },
                new Product
                {
                    Id = 1,
                    LastStocked = DateTime.SpecifyKind(DateTime.MinValue, DateTimeKind.Utc),
                    Name = "A",
                    Price = 10,
                    Qty = 5,
                    TagMap = new Dictionary<string, Tag> {
                        { "B", new Tag { Id = 1, Name = "B" } }, { "C", new Tag { Id = 1, Name = "C" } } },
                    Tags = new List<Tag> { new Tag { Id = 1, Name = "B" }, new Tag { Id = 1, Name = "C" } }
                }));
        }

        class Product
        {
            public int Qty { get; set; }
            public string Name { get; set; }
            public DateTime LastStocked { get; set; }
            public long Id { get; set; }
            public double Price { get; set; }
            public List<Tag> Tags { get; set; }
            public Dictionary<string, Tag> TagMap { get; set; }
        }

        class Tag
        {
            public int Id { get; set; }
            public string Name { get; set; }
        }
    }
}
