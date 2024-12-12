using Amazon.Runtime.Internal.Util;
using Amazon.Util;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;

namespace AWSSDK.UnitTests
{
    [TestClass]
    [TestCategory("UnitTest")]
    [TestCategory("Util")]
    public class MultiValueHeaderParserTests
    {
        [TestMethod]
        public void ToStringList_EmptyHeader_ReturnsEmptyList()
        {
            string header = "";
            var result = MultiValueHeaderParser.ToStringList(header);

            CollectionAssert.AreEqual(new List<string>(), result);
        }

        [TestMethod]
        public void ToStringList_SingleValueHeader_ReturnsSingleValueList()
        {
            string header = "a";
            var result = MultiValueHeaderParser.ToStringList(header);

            CollectionAssert.AreEqual(new List<string> { "a" }, result);
        }

        [TestMethod]
        public void ToStringList_ComplexValues_ReturnsList()
        {
            string header = "\"b,c\", \"\\\"def\\\"\", a";
            var result = MultiValueHeaderParser.ToStringList(header);

            CollectionAssert.AreEqual(new List<string> { "b,c", "\"def\"", "a" }, result);
        }

        [TestMethod]
        public void ToStringList_SimpleValues_ReturnsList()
        {
            string header = "1, 2, 3";
            var result = MultiValueHeaderParser.ToStringList(header);

            CollectionAssert.AreEqual(new List<string> { "1", "2", "3" }, result);
        }

        [TestMethod]
        public void ToDateTimeList_ISO8601Format_ReturnsDateTimeList()
        {
            string header = "2019-12-16T23:48:18Z, 2019-12-16T23:48:18Z";
            string format = "ISO8601";
            var result = MultiValueHeaderParser.ToDateTimeList(header, format);

            Assert.AreEqual(new DateTime(2019, 12, 16, 23, 48, 18, DateTimeKind.Utc), result[0]);
            Assert.AreEqual(new DateTime(2019, 12, 16, 23, 48, 18, DateTimeKind.Utc), result[1]);
        }

        [TestMethod]
        public void ToDateTimeList_RFC822Format_ReturnsDateTimeList()
        {
            string header = "Mon, 16 Dec 2019 23:48:18 GMT, Mon, 16 Dec 2019 23:48:18 GMT";
            string format = "RFC822";
            var result = MultiValueHeaderParser.ToDateTimeList(header, format);

            Assert.AreEqual(new DateTime(2019, 12, 16, 23, 48, 18, DateTimeKind.Utc), result[0]);
            Assert.AreEqual(new DateTime(2019, 12, 16, 23, 48, 18, DateTimeKind.Utc), result[1]);
        }

        [TestMethod]
        public void ToDateTimeList_UnixTimestampFormat_ReturnsDateTimeList()
        {
            string header = "1576540098, 1576540098";
            string format = "UnixTimestamp";
            var result = MultiValueHeaderParser.ToDateTimeList(header, format);

            Assert.AreEqual(new DateTime(2019, 12, 16, 23, 48, 18, DateTimeKind.Utc), result[0]);
            Assert.AreEqual(new DateTime(2019, 12, 16, 23, 48, 18, DateTimeKind.Utc), result[1]);
        }

        [TestMethod]
        public void ToValueTypeList_IntType_SimpleValues_ReturnsList()
        {
            string header = "1, 2, 3";
            var result = MultiValueHeaderParser.ToValueTypeList<int>(header);

            CollectionAssert.AreEqual(new List<int> { 1, 2, 3 }, result);
        }

        [TestMethod]
        public void ToValueTypeList_IntType_SingleValue_ReturnsList()
        {
            string header = "1";
            var result = MultiValueHeaderParser.ToValueTypeList<int>(header);

            CollectionAssert.AreEqual(new List<int> { 1 }, result);
        }

        [TestMethod]
        public void ToValueTypeList_IntType_EmptyHeader_ReturnsEmptyList()
        {
            string header = "";
            var result = MultiValueHeaderParser.ToValueTypeList<int>(header);

            CollectionAssert.AreEqual(new List<int>(), result);
        }
    }
}