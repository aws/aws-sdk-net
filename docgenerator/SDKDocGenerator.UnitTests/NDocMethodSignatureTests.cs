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
        public void CollectionTestMethod()
        {
            var methodInfo = typeof(TestMethods).GetMethods().First(x => x.Name == "CollectionTest");
            var signature = NDocUtilities.DetermineNDocNameLookupSignature(methodInfo);
            Assert.Equal("M:SDKDocGenerator.UnitTests.TestMethods.CollectionTest(System.Collections.Generic.IList{System.Collections.Generic.IDictionary{System.String,SDKDocGenerator.UnitTests.TestMethods}})", signature);
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
    }
}
