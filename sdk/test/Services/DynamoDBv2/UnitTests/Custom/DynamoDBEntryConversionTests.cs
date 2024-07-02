using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Amazon.DynamoDBv2;
using Amazon.DynamoDBv2.DocumentModel;
using Amazon.DynamoDBv2.Model;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace AWSSDK.UnitTests.DynamoDBv2.Net45.Custom
{
    [TestClass]
    public class DynamoDBEntryConversionTests
    {
        [DataTestMethod]
        [DynamicData(nameof(V1PrimitiveData))]
        public void V1_Primitives_ConvertToEntry(object value, DynamoDBEntry expectedPrimitive)
        {
            var actualPrimitive = DynamoDBEntryConversion.V1.ConvertToEntry(value.GetType(), value);
            Assert.AreEqual(expectedPrimitive, actualPrimitive);
        }

        [DataTestMethod]
        [DynamicData(nameof(V1PrimitiveData))]
        public void V1_Primitives_ConvertFromEntry(object expectedValue, DynamoDBEntry primitive)
        {
            var actualValue = DynamoDBEntryConversion.V1.ConvertFromEntry(expectedValue.GetType(), primitive);
            Assert.AreEqual(expectedValue, actualValue);
        }

        [DataTestMethod]
        [DynamicData(nameof(V2PrimitiveData))]
        public void V2_Primitives_ConvertToEntry(object value, DynamoDBEntry expectedPrimitive)
        {
            var actualPrimitive = DynamoDBEntryConversion.V2.ConvertToEntry(value.GetType(), value);
            Assert.AreEqual(expectedPrimitive, actualPrimitive);
        }

        [DataTestMethod]
        [DynamicData(nameof(V2PrimitiveData))]
        public void V2_Primitives_ConvertFromEntry(object expectedValue, DynamoDBEntry primitive)
        {
            var actualValue = DynamoDBEntryConversion.V2.ConvertFromEntry(expectedValue.GetType(), primitive);
            Assert.AreEqual(expectedValue, actualValue);
        }

        [DataTestMethod]
        [DynamicData((nameof(DynamoDBEntryConversions)))]
        public void ConvertToEntry_MemoryStream(DynamoDBEntryConversion conversion)
        {
            var memoryStream = new MemoryStream(ByteArray);
            var entry = conversion.ConvertToEntry(memoryStream);
            Assert.AreEqual(new Primitive(ByteArray), entry);
        }

        [DataTestMethod]
        [DynamicData((nameof(DynamoDBEntryConversions)))]
        public void ConvertFromEntry_MemoryStream(DynamoDBEntryConversion conversion)
        {
            var entry = new Primitive(ByteArray);
            var memoryStream = conversion.ConvertFromEntry<MemoryStream>(entry);
            CollectionAssert.AreEqual(ByteArray, memoryStream.ToArray());
        }

        [DataTestMethod]
        [DynamicData((nameof(DynamoDBEntryConversions)))]
        public void ConvertToEntry_DateTime(DynamoDBEntryConversion conversion)
        {
            var dateTime = new DateTime(2024, 07, 03, 01, 31, 47, DateTimeKind.Utc);
            var entry = conversion.ConvertToEntry(dateTime);
            Assert.AreEqual(new Primitive("2024-07-03T01:31:47.000Z", false), entry);
        }

        [DataTestMethod]
        [DynamicData((nameof(DynamoDBEntryConversions)))]
        public void ConvertFromEntry_DateTime(DynamoDBEntryConversion conversion)
        {
            // DynamoDBEntryConversion returns local DateTime by default:
            // https://github.com/aws/aws-sdk-net/issues/1450
            var entry = new Primitive("2024-07-03T01:31:47.000Z", false);
            var actualDateTime = conversion.ConvertFromEntry<DateTime>(entry);
            var utcDateTime = actualDateTime.ToUniversalTime();
            var expectedDateTime = new DateTime(2024, 07, 03, 01, 31, 47, DateTimeKind.Utc);
            Assert.AreEqual(expectedDateTime, utcDateTime);
        }


        private enum TestEnum { A, B }

        private static byte[] ByteArray = new byte[] { 1, 2, 3, 4, 5 };

        private static IEnumerable<object[]> DynamoDBEntryConversions { get; } = new object[][]
        {
            new object[] { DynamoDBEntryConversion.V1 },
            new object[] { DynamoDBEntryConversion.V2 },
        };

        private static IEnumerable<object[]> CommonPrimitiveData { get; } = new object[][]
        {
            new object[] { (short)-1, new Primitive("-1", true) },
            new object[] { (ushort)1, new Primitive("1", true) },
            new object[] { (int)-2, new Primitive("-2", true) },
            new object[] { (uint)2, new Primitive("2", true) },
            new object[] { (long)-3, new Primitive("-3", true) },
            new object[] { (ulong)3, new Primitive("3", true) },
            new object[] { (byte)4, new Primitive("4", true) },
            new object[] { (sbyte)5, new Primitive("5", true) },
            new object[] { (float)1.23, new Primitive("1.23", true) },
            new object[] { (double)2.34, new Primitive("2.34", true) },
            new object[] { (decimal)3.45, new Primitive("3.45", true) },
            new object[] { (char)'c', new Primitive("c", false) },
            new object[] { "stringValue", new Primitive("stringValue", false) },
            new object[] { new Guid("6a34ff83-9d2b-4893-950f-1da35414f9b0"), new Primitive("6a34ff83-9d2b-4893-950f-1da35414f9b0", false) },
            new object[] { TestEnum.A, new Primitive("0", true) },
            new object[] { TestEnum.B, new Primitive("1", true) },
            new object[] { ByteArray, new Primitive(ByteArray) }
        };

        public static IEnumerable<object[]> V1PrimitiveData { get; } = CommonPrimitiveData.Concat(new object[][]
        {
            new object[] { true, new Primitive("1", true) },
            new object[] { false, new Primitive("0", true) }
        });

        public static IEnumerable<object[]> V2PrimitiveData { get; } = CommonPrimitiveData.Concat(new object[][]
        {
            new object[] { true, new DynamoDBBool(true) },
            new object[] { false, new DynamoDBBool(false) }
        });
    }
}