using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xunit;

using SDKDocGenerator;

namespace SDKDocGenerator.UnitTests
{
    public class NDocMethodSignatureTests
    {
        [Fact]
        public void GenericReturnMethod()
        {
            var methodInfo = typeof(TestMethods).GetMethod("Query", new Type[]{typeof(string)});
            var signature = NDocUtilities.DetermineNDocNameLookupSignature(methodInfo);
            Assert.Equal("M:SDKDocGenerator.UnitTests.TestMethods.Query``1(System.String)", signature);
        }

        [Fact]
        public static void CollectionTestMethod()
        {
            var methodInfo = typeof(TestMethods).GetMethods().First(x => x.Name == "CollectionTest");
            var signature = NDocUtilities.DetermineNDocNameLookupSignature(methodInfo);
            Assert.Equal(
                "M:SDKDocGenerator.UnitTests.TestMethods.CollectionTest(System.Collections.Generic.IList{System.Collections.Generic.IDictionary{System.String,SDKDocGenerator.UnitTests.TestMethods}})", 
                signature);
        }

        [Fact]
        public static void StringTestMethod()
        {
            var methodInfo = typeof(TestMethods).GetMethod("StringTest", new Type[] {typeof(string)});
            var signature = NDocUtilities.DetermineNDocNameLookupSignature(methodInfo);
            Assert.Equal("M:SDKDocGenerator.UnitTests.TestMethods.StringTest(System.String)", signature);
        }

        [Fact]
        public static void ListTestMethod()
        {
            var methodInfo = typeof(TestMethods).GetMethods().First(x => x.Name == "ListTest");
            var signature = NDocUtilities.DetermineNDocNameLookupSignature(methodInfo);
            Assert.Equal("M:SDKDocGenerator.UnitTests.TestMethods.ListTest(System.Collections.Generic.IList{System.String})", signature);
        }

        [Fact]
        public static void DictionaryTestMethod()
        {
            var methodInfo = typeof(TestMethods).GetMethods().First(x => x.Name == "DictionaryTest");
            var signature = NDocUtilities.DetermineNDocNameLookupSignature(methodInfo);
            Assert.Equal(
                "M:SDKDocGenerator.UnitTests.TestMethods.DictionaryTest(System.Collections.Generic.IDictionary{System.String,SDKDocGenerator.UnitTests.TestMethods})", 
                signature);
        }

        [Fact]
        public static void CollectionOfCollectionTestMethod()
        {
            var methodInfo = typeof(TestMethods).GetMethods().First(x => x.Name == "CollectionOfCollectionTest");
            var signature = NDocUtilities.DetermineNDocNameLookupSignature(methodInfo);
            Assert.Equal(
                "M:SDKDocGenerator.UnitTests.TestMethods.CollectionOfCollectionTest(System.Collections.Generic.IList{System.Collections.Generic.IDictionary{System.String,System.Collections.Generic.IList{System.String}}})", 
                signature);
        }

    }

    public class TestMethods
    {
        /// <summary>
        /// Test Method
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="name"></param>
        /// <returns></returns>
        public T Query<T>(string name)
        {
            return default(T);
        }

        /// <summary>
        /// Test Method
        /// </summary>
        /// <param name="param"></param>
        public void CollectionTest(IList<IDictionary<string, TestMethods>> param)
        {

        }

        /// <summary>
        /// Test Method
        /// </summary>
        /// <param name="name"></param>
        public void StringTest(string name)
        {

        }

        /// <summary>
        /// Test Method
        /// </summary>
        /// <param name="param"></param>
        public void ListTest(IList<string> param)
        {

        }

        /// <summary>
        /// Test Method
        /// </summary>
        /// <param name="param"></param>
        public void DictionaryTest(IDictionary<string, TestMethods> param)
        {

        }

        /// <summary>
        /// Test Method
        /// </summary>
        /// <param name="param"></param>
        public void CollectionOfCollectionTest(IList<IDictionary<string, IList<string>>> param)
        {

        }
    }
}
