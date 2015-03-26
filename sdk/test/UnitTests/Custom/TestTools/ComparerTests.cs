using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AWSSDK_DotNet35.UnitTests.TestTools
{
    [TestClass]
    public class ComparerTests
    {
        [TestMethod][TestCategory("UnitTest")]
        public void TestJsonToObject()
        {
            var product = Comparer.JsonToObject<Product>(Utils.GetResourceText("ComparerTest.json"));
            Assert.AreEqual(123, product.Id);
            Assert.AreEqual("A", product.Name);
            Assert.AreEqual(1212, product.Price);
            Assert.AreEqual(1, product.Qty);
            Assert.IsNotNull(product.Tags);
            Assert.AreEqual(2, product.Tags.Count);
            Assert.AreEqual(1, product.Tags[0].Id);
            Assert.AreEqual("X", product.Tags[0].Name);
            Assert.AreEqual(2, product.Tags[1].Id);
            Assert.AreEqual("Y", product.Tags[1].Name);
            Assert.IsNotNull(product.TagMap);
            Assert.AreEqual(2, product.TagMap.Count);
            Assert.AreEqual(1, product.TagMap["Key0"].Id);
            Assert.AreEqual("X", product.TagMap["Key0"].Name);
            Assert.AreEqual(2, product.TagMap["Key1"].Id);
            Assert.AreEqual("Y", product.TagMap["Key1"].Name);
        }

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
                    LastStocked = DateTime.MinValue,
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
                    LastStocked = DateTime.MinValue,
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
                    LastStocked = DateTime.MinValue,
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
                    LastStocked = DateTime.MinValue,
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
                    LastStocked = DateTime.MinValue,
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
                    LastStocked = DateTime.MinValue,
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
