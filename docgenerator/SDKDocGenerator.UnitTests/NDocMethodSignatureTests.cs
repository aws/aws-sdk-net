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
            var methodInfo = typeof(TestMethods).GetMethod("Query", new Type[] { typeof(string) });
            var signature = NDocUtilities.DetermineNDocNameLookupSignature(methodInfo, "");
            Assert.Equal("M:SDKDocGenerator.UnitTests.TestMethods.Query``1(System.String)", signature);
        }

        [Fact]
        public void CollectionTestMethod()
        {
            var methodInfo = typeof(TestMethods).GetMethods().First(x => x.Name == "CollectionTest");
            var signature = NDocUtilities.DetermineNDocNameLookupSignature(methodInfo, "");
            Assert.Equal(
                "M:SDKDocGenerator.UnitTests.TestMethods.CollectionTest(System.Collections.Generic.IList{System.Collections.Generic.IDictionary{System.String,SDKDocGenerator.UnitTests.TestMethods}})",
                signature);
        }

        [Fact]
        public void MultiOutTestMethod()
        {
            var methodInfo = typeof(TestMethods).GetMethods().First(x => x.Name == "MultiOutTest");
            var signature = NDocUtilities.DetermineNDocNameLookupSignature(methodInfo, "");
            Assert.Equal(
                "M:SDKDocGenerator.UnitTests.TestMethods.MultiOutTest(System.Int32@,System.String@)",
                signature);
        }

        [Fact]
        public void CollectionOutTestMethod()
        {
            var methodInfo = typeof(TestMethods).GetMethods().First(x => x.Name == "CollectionOutTest");
            var signature = NDocUtilities.DetermineNDocNameLookupSignature(methodInfo, "");
            Assert.Equal(
                "M:SDKDocGenerator.UnitTests.TestMethods.CollectionOutTest(System.Collections.Generic.IList{System.String}@)",
                signature);
        }

        [Fact]
        public void ArrayParameterMethod()
        {
            var methodInfo = typeof(TestMethods).GetMethods().First(x => x.Name == "ArrayTest");
            var signature = NDocUtilities.DetermineNDocNameLookupSignature(methodInfo, "");
            Assert.Equal(
                "M:SDKDocGenerator.UnitTests.TestMethods.ArrayTest(System.String[])",
                signature);
        }

        [Fact]
        public void NestedGenericParameterMethod()
        {
            var methodInfo = typeof(TestMethods).GetMethods().First(x => x.Name == "NestedGenericTest");
            var signature = NDocUtilities.DetermineNDocNameLookupSignature(methodInfo, "");
            Assert.Equal(
                "M:SDKDocGenerator.UnitTests.TestMethods.NestedGenericTest(System.Collections.Generic.Dictionary{System.String,System.Collections.Generic.List{System.Int32}})",
                signature);
        }

        [Fact]
        public void ConstructorSignature_Parameterless()
        {
            var ctor = typeof(TestMethods).GetConstructor(Type.EmptyTypes);
            var wrapper = new ConstructorInfoWrapper(ctor, "");
            var signature = NDocUtilities.DetermineConstructorSignature(wrapper);
            Assert.Equal(
                "M:SDKDocGenerator.UnitTests.TestMethods.#ctor",
                signature);
        }

        [Fact]
        public void ConstructorSignature_WithParameters()
        {
            var ctor = typeof(TestCtorClass).GetConstructor(new[] { typeof(string), typeof(int) });
            var wrapper = new ConstructorInfoWrapper(ctor, "");
            var signature = NDocUtilities.DetermineConstructorSignature(wrapper);
            Assert.Equal(
                "M:SDKDocGenerator.UnitTests.TestCtorClass.#ctor(System.String,System.Int32)",
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
        /// <param name="s1"></param>
        /// <param name="s2"></param>
        public void MultiOutTest(out int s1, out string s2)
        {
            s1 = 1;
            s2 = "Test";
        }

        /// <summary>
        /// Test Method
        /// </summary>
        /// <param name="param"></param>
        public void CollectionOutTest(out IList<string> param)
        {
            param = new List<string>();
        }

        /// <summary>
        /// Test Method
        /// </summary>
        /// <param name="items"></param>
        public void ArrayTest(string[] items)
        {
        }

        /// <summary>
        /// Test Method
        /// </summary>
        /// <param name="param"></param>
        public void NestedGenericTest(Dictionary<string, List<int>> param)
        {
        }

    }

    public class TestCtorClass
    {
        public TestCtorClass(string name, int value)
        {
        }
    }
}
