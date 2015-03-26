using System;
using System.IO;
using System.Text;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace AWSSDK_DotNet35.UnitTests.TestTools
{
    /// <summary>
    /// Summary description for InstantiateClassGeneratorTests
    /// </summary>
    [TestClass]
    public class InstantiateClassGeneratorTests
    {
        public InstantiateClassGeneratorTests()
        {
        }

        private TestContext testContextInstance;

        /// <summary>
        ///Gets or sets the test context which provides
        ///information about and functionality for the current test run.
        ///</summary>
        public TestContext TestContext
        {
            get
            {
                return testContextInstance;
            }
            set
            {
                testContextInstance = value;
            }
        }

        #region Additional test attributes
        //
        // You can use the following additional attributes as you write your tests:
        //
        // Use ClassInitialize to run code before running the first test in the class
        // [ClassInitialize()]
        // public static void MyClassInitialize(TestContext testContext) { }
        //
        // Use ClassCleanup to run code after all tests in a class have run
        // [ClassCleanup()]
        // public static void MyClassCleanup() { }
        //
        // Use TestInitialize to run code before running each test 
        // [TestInitialize()]
        // public void MyTestInitialize() { }
        //
        // Use TestCleanup to run code after each test has run
        // [TestCleanup()]
        // public void MyTestCleanup() { }
        //
        #endregion

        [TestMethod][TestCategory("UnitTest")]
        public void ClassWithJustSimpleTypesProperty()
        {
            var rootObject = InstantiateClassGenerator.Execute<SimpleTypesPropertyTest>();
            AreAllPropertiesSet(rootObject);
        }


        [TestMethod][TestCategory("UnitTest")]
        public void ListTests()
        {
            var rootObject = InstantiateClassGenerator.Execute<ListTestClass>();

            Assert.IsTrue(rootObject.ListOfSimpleProperties.Count > 0);
            foreach (var item in rootObject.ListOfSimpleProperties)
            {
                AreAllPropertiesSet(item);
            }
            Assert.IsTrue(rootObject.ListOfStrings.Count > 0);
            Assert.IsTrue(rootObject.ListOfInts.Count > 0);
            Assert.IsTrue(rootObject.ListOfLongs.Count > 0);
            Assert.IsTrue(rootObject.ListOfDateTimes.Count > 0);
            Assert.IsTrue(rootObject.ListOfDoubles.Count > 0);
            Assert.IsTrue(rootObject.ListOfBlobs.Count > 0);
        }

        [TestMethod][TestCategory("UnitTest")]
        public void DictionaryTests()
        {
            var rootObject = InstantiateClassGenerator.Execute<DictionaryTestClass>();

            Assert.IsTrue(rootObject.DictionaryOfSimpleProperties.Count > 0);
            foreach (var kvp in rootObject.DictionaryOfSimpleProperties)
            {
                AreAllPropertiesSet(kvp.Value);
            }
            Assert.IsTrue(rootObject.DictionaryOfStrings.Count > 0);
            Assert.IsTrue(rootObject.DictionaryOfInts.Count > 0);
            Assert.IsTrue(rootObject.DictionaryOfLongs.Count > 0);
            Assert.IsTrue(rootObject.DictionaryOfDateTimes.Count > 0);
            Assert.IsTrue(rootObject.DictionaryOfDoubles.Count > 0);
            Assert.IsTrue(rootObject.DictionaryOfBlobs.Count > 0);

            Assert.IsTrue(rootObject.DictionaryOfListOfStrings.Count > 0);
            foreach (var kvp in rootObject.DictionaryOfListOfStrings)
            {
                Assert.IsTrue(kvp.Value.Count > 0);
            }

            Assert.IsTrue(rootObject.DictionaryOfListOfSimpleTypesProperties.Count > 0);
            foreach (var kvp in rootObject.DictionaryOfListOfSimpleTypesProperties)
            {
                Assert.IsTrue(kvp.Value.Count > 0);
                foreach (var value in kvp.Value)
                {
                    AreAllPropertiesSet(value);
                }
            }
        }


        private void AreAllPropertiesSet(SimpleTypesPropertyTest obj)
        {
            Assert.IsNotNull(obj);
            Assert.IsTrue(obj.IsSetTestString());
            Assert.IsTrue(obj.IsSetTestBoolean());
            Assert.IsTrue(obj.IsSetTestInt());
            Assert.IsTrue(obj.IsSetTestLong());
            Assert.IsTrue(obj.IsSetTestDateTime());
            Assert.IsTrue(obj.IsSetTestDouble());
            Assert.IsTrue(obj.IsSetTestBlob());
        }

        class ListTestClass
        {
            List<string> _listOfStrings;
            List<int> _listOfInts;
            List<long> _listOfLongs;
            List<DateTime> _listOfDateTimes;
            List<double> _listOfDoubles;
            List<MemoryStream> _listOfBlobs;
            List<SimpleTypesPropertyTest> _listOfSimpleProperties;

            public List<SimpleTypesPropertyTest> ListOfSimpleProperties
            {
                get { return this._listOfSimpleProperties; }
                set { this._listOfSimpleProperties = value; }
            }

            internal bool IsSetListOfSimpleProperties()
            {
                return this._listOfSimpleProperties != null && this._listOfSimpleProperties.Count > 0;
            }

            public List<string> ListOfStrings
            {
                get { return this._listOfStrings; }
                set { this._listOfStrings = value; }
            }

            internal bool IsSetListOfStrings()
            {
                return this._listOfStrings != null && this._listOfStrings.Count > 0;
            }

            public List<int> ListOfInts
            {
                get { return this._listOfInts; }
                set { this._listOfInts = value; }
            }

            internal bool IsSetListOfInts()
            {
                return this._listOfInts != null && this._listOfInts.Count > 0;
            }

            public List<long> ListOfLongs
            {
                get { return this._listOfLongs; }
                set { this._listOfLongs = value; }
            }

            internal bool IsSetListOfLongs()
            {
                return this._listOfLongs != null && this._listOfLongs.Count > 0;
            }

            public List<DateTime> ListOfDateTimes
            {
                get { return this._listOfDateTimes; }
                set { this._listOfDateTimes = value; }
            }

            internal bool IsSetListOfDateTimes()
            {
                return this._listOfDateTimes != null && this._listOfDateTimes.Count > 0;
            }

            public List<double> ListOfDoubles
            {
                get { return this._listOfDoubles; }
                set { this._listOfDoubles = value; }
            }

            internal bool IsSetListOfDoubles()
            {
                return this._listOfDoubles != null && this._listOfDoubles.Count > 0;
            }

            public List<MemoryStream> ListOfBlobs
            {
                get { return this._listOfBlobs; }
                set { this._listOfBlobs = value; }
            }

            internal bool IsSetListOfBlobs()
            {
                return this._listOfBlobs != null && this._listOfBlobs.Count > 0;
            }

        }

        class DictionaryTestClass
        {
            Dictionary<string, string> _dictionaryOfStrings;
            Dictionary<string, int> _dictionaryOfInts;
            Dictionary<string, long> _dictionaryOfLongs;
            Dictionary<string, DateTime> _dictionaryOfDateTimes;
            Dictionary<string, double> _dictionaryOfDoubles;
            Dictionary<string, MemoryStream> _dictionaryOfBlobs;
            Dictionary<string, SimpleTypesPropertyTest> _dictionaryOfSimpleProperties;

            Dictionary<string, List<string>> _dictionaryOfListOfStrings;
            Dictionary<string, List<SimpleTypesPropertyTest>> _dictionaryOfListOfSimpleTypesProperties;

            public Dictionary<string, SimpleTypesPropertyTest> DictionaryOfSimpleProperties
            {
                get { return this._dictionaryOfSimpleProperties; }
                set { this._dictionaryOfSimpleProperties = value; }
            }

            internal bool IsSetDictionaryOfSimpleProperties()
            {
                return this._dictionaryOfSimpleProperties != null && this._dictionaryOfSimpleProperties.Count > 0;
            }

            public Dictionary<string, string> DictionaryOfStrings
            {
                get { return this._dictionaryOfStrings; }
                set { this._dictionaryOfStrings = value; }
            }

            internal bool IsSetDictionaryOfStrings()
            {
                return this._dictionaryOfStrings != null && this._dictionaryOfStrings.Count > 0;
            }

            public Dictionary<string, int> DictionaryOfInts
            {
                get { return this._dictionaryOfInts; }
                set { this._dictionaryOfInts = value; }
            }

            internal bool IsSetDictionaryOfInts()
            {
                return this._dictionaryOfInts != null && this._dictionaryOfInts.Count > 0;
            }

            public Dictionary<string, long> DictionaryOfLongs
            {
                get { return this._dictionaryOfLongs; }
                set { this._dictionaryOfLongs = value; }
            }

            internal bool IsSetDictionaryOfLongs()
            {
                return this._dictionaryOfLongs != null && this._dictionaryOfLongs.Count > 0;
            }

            public Dictionary<string, DateTime> DictionaryOfDateTimes
            {
                get { return this._dictionaryOfDateTimes; }
                set { this._dictionaryOfDateTimes = value; }
            }

            internal bool IsSetDictionaryOfDateTimes()
            {
                return this._dictionaryOfDateTimes != null && this._dictionaryOfDateTimes.Count > 0;
            }

            public Dictionary<string, double> DictionaryOfDoubles
            {
                get { return this._dictionaryOfDoubles; }
                set { this._dictionaryOfDoubles = value; }
            }

            internal bool IsSetDictionaryOfDoubles()
            {
                return this._dictionaryOfDoubles != null && this._dictionaryOfDoubles.Count > 0;
            }

            public Dictionary<string, MemoryStream> DictionaryOfBlobs
            {
                get { return this._dictionaryOfBlobs; }
                set { this._dictionaryOfBlobs = value; }
            }

            internal bool IsSetDictionaryOfBlobs()
            {
                return this._dictionaryOfBlobs != null && this._dictionaryOfBlobs.Count > 0;
            }

            public Dictionary<string, List<string>> DictionaryOfListOfStrings
            {
                get { return this._dictionaryOfListOfStrings; }
                set { this._dictionaryOfListOfStrings = value; }
            }

            internal bool IsSetDictionaryOfListOfStrings()
            {
                return this._dictionaryOfListOfStrings != null && this._dictionaryOfListOfStrings.Count > 0;
            }

            public Dictionary<string, List<SimpleTypesPropertyTest>> DictionaryOfListOfSimpleTypesProperties
            {
                get { return this._dictionaryOfListOfSimpleTypesProperties; }
                set { this._dictionaryOfListOfSimpleTypesProperties = value; }
            }

            internal bool IsSetDictionaryOfListOfSimpleTypesProperties()
            {
                return this._dictionaryOfListOfSimpleTypesProperties != null && this._dictionaryOfListOfSimpleTypesProperties.Count > 0;
            }

        }

        class SimpleTypesPropertyTest
        {
            private string testString;
            private bool? testBoolean;
            private int? testInt;
            private long? testLong;
            private DateTime? testDateTime;
            private double? testDouble;
            private MemoryStream testBlob;
            private SimpleObject testSimpleObject;

            public string TestString
            {
                get { return this.testString; }
                set { this.testString = value; }
            }

            public bool IsSetTestString()
            {
                return this.testString != null;
            }

            public bool TestBoolean
            {
                get { return this.testBoolean.GetValueOrDefault(); }
                set { this.testBoolean = value; }
            }

            public bool IsSetTestBoolean()
            {
                return this.testBoolean.HasValue;
            }

            public int TestInt
            {
                get { return this.testInt.GetValueOrDefault(); }
                set { this.testInt = value; }
            }

            public bool IsSetTestInt()
            {
                return this.testInt.HasValue;
            }

            public long TestLong
            {
                get { return this.testLong.GetValueOrDefault(); }
                set { this.testLong = value; }
            }

            public bool IsSetTestLong()
            {
                return this.testLong.HasValue;
            }

            public DateTime TestDateTime
            {
                get { return this.testDateTime.GetValueOrDefault(); }
                set { this.testDateTime = value; }
            }

            public bool IsSetTestDateTime()
            {
                return this.testDateTime.HasValue;
            }

            public double TestDouble
            {
                get { return this.testDouble.GetValueOrDefault(); }
                set { this.testDouble = value; }
            }

            public bool IsSetTestDouble()
            {
                return this.testDouble.HasValue;
            }

            public MemoryStream TestBlob
            {
                get { return this.testBlob; }
                set { this.testBlob = value; }
            }

            public bool IsSetTestBlob()
            {
                return this.testBlob != null;
            }

            public SimpleObject TestSimpleObject
            {
                get { return this.testSimpleObject; }
                set { this.testSimpleObject = value; }
            }

            public bool IsSetTestSimpleObject()
            {
                return this.testSimpleObject != null;
            }
        }

        class SimpleObject
        {
            private string testString;

            public string TestString
            {
                get { return this.testString; }
                set { this.testString = value; }
            }

            public bool IsSetTestString()
            {
                return this.testString != null;
            }
        }
    }
}
