using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using Amazon.DynamoDBv2;
using Amazon.DynamoDBv2.DocumentModel;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace AWSSDK.UnitTests.DynamoDBv2.Net45.Custom
{
    [TestClass]
    public class DynamoDBEntryConversionTests
    {
        [DataTestMethod]
        [DynamicData(nameof(V1PrimitiveData))]
        public void V1_ConvertToEntry_Primitives(object value, DynamoDBEntry expectedPrimitive)
        {
            var actualPrimitive = DynamoDBEntryConversion.V1.ConvertToEntry(value.GetType(), value);
            Assert.AreEqual(expectedPrimitive, actualPrimitive);
        }

        [DataTestMethod]
        [DynamicData(nameof(V1PrimitiveData))]
        public void V1_ConvertFromEntry_Primitives(object expectedValue, DynamoDBEntry primitive)
        {
            var actualValue = DynamoDBEntryConversion.V1.ConvertFromEntry(expectedValue.GetType(), primitive);
            Assert.AreEqual(expectedValue, actualValue);
        }

        [DataTestMethod]
        [DynamicData(nameof(V2PrimitiveData))]
        public void V2_ConvertToEntry_Primitives(object value, DynamoDBEntry expectedPrimitive)
        {
            var actualPrimitive = DynamoDBEntryConversion.V2.ConvertToEntry(value.GetType(), value);
            Assert.AreEqual(expectedPrimitive, actualPrimitive);
        }

        [DataTestMethod]
        [DynamicData(nameof(V2PrimitiveData))]
        public void V2_ConvertFromEntry_Primitives(object expectedValue, DynamoDBEntry primitive)
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

        [DataTestMethod]
        [DynamicData((nameof(DynamoDBEntryConversions)))]
        public void ConvertToEntry_Dictionary(DynamoDBEntryConversion conversion)
        {
            var dictionary = new Dictionary<string, object>
            {
                ["key1"] = "str",
                ["key2"] = 123,
                ["key3"] = new Dictionary<string, object>
                {
                    ["innerKey"] = "innerStr"
                }
            };

            var document = conversion.ConvertToEntry(dictionary).AsDocument();

            var expectedDocument = new Document
            {
                ["key1"] = new Primitive("str"),
                ["key2"] = new Primitive("123", true),
                ["key3"] = new Document
                {
                    ["innerKey"] = new Primitive("innerStr")
                }
            };
            Assert.AreEqual(expectedDocument, document);
        }

        [DataTestMethod]
        [DynamicData((nameof(DynamoDBEntryConversions)))]
        public void ConvertFromEntry_DynamoDbList_ToArray(DynamoDBEntryConversion conversion)
        {
            var dynamoDbList = new DynamoDBList(new DynamoDBEntry[]
            {
                new Primitive("A"), new Primitive("B"), new Primitive("C")
            });
            var convertedArray = conversion.ConvertFromEntry<string[]>(dynamoDbList);
            CollectionAssert.AreEqual(new[] { "A", "B", "C" }, convertedArray);
        }

        [DataTestMethod]
        [DynamicData((nameof(DynamoDBEntryConversions)))]
        public void ConvertFromEntry_DynamoDbList_ToList(DynamoDBEntryConversion conversion)
        {
            var dynamoDbList = new DynamoDBList(new DynamoDBEntry[]
            {
                new Primitive("1", true), new Primitive("2", true), new Primitive("3", true)
            });
            var convertedList = conversion.ConvertFromEntry<List<int>>(dynamoDbList);
            CollectionAssert.AreEqual(new[] { 1, 2, 3 }, convertedList);
        }

        [DataTestMethod]
        [DynamicData((nameof(DynamoDBEntryConversions)))]
        public void ConvertFromEntry_PrimitiveList_ToArray(DynamoDBEntryConversion conversion)
        {
            var primitiveList = new PrimitiveList(DynamoDBEntryType.String)
            {
                Entries = { "A", "B", "C" }
            };
            var convertedArray = conversion.ConvertFromEntry<string[]>(primitiveList);
            CollectionAssert.AreEqual(new[] { "A", "B", "C" }, convertedArray);
        }

        [DataTestMethod]
        [DynamicData((nameof(DynamoDBEntryConversions)))]
        public void ConvertFromEntry_PrimitiveList_ToList(DynamoDBEntryConversion conversion)
        {
            var primitiveList = new PrimitiveList(DynamoDBEntryType.Numeric)
            {
                Entries = { 1, 2, 3 }
            };
            var convertedList = conversion.ConvertFromEntry<List<int>>(primitiveList);
            CollectionAssert.AreEqual(new[] { 1, 2, 3 }, convertedList);
        }

        [DataTestMethod]
        [DynamicData((nameof(DynamoDBEntryConversions)))]
        public void ConvertFromEntry_PrimitiveList_ToHashSet(DynamoDBEntryConversion conversion)
        {
            var primitiveList = new PrimitiveList(DynamoDBEntryType.Numeric)
            {
                Entries = { 0, 1, 2 }
            };
            var convertedHashSet = conversion.ConvertFromEntry<HashSet<long>>(primitiveList);
            Assert.IsTrue(convertedHashSet.SetEquals(new long[] { 0, 1, 2 }));
        }

        [TestMethod]
        public void V1_ConvertToEntry_Array()
        {
            var array = new[] { "A", "B", "C" };
            var entry = DynamoDBEntryConversion.V1.ConvertToEntry(array);
            var expectedList = new PrimitiveList { Entries = { "A", "B", "C" } };
            Assert.AreEqual(expectedList, entry);
        }

        [TestMethod]
        public void V1_ConvertToEntry_List()
        {
            var list = new List<int> { 3, 2, 1 };
            var entry = DynamoDBEntryConversion.V1.ConvertToEntry(list);
            var expectedList = new PrimitiveList(DynamoDBEntryType.Numeric) { Entries = { 3, 2, 1 } };
            Assert.AreEqual(expectedList, entry);
        }

        [TestMethod]
        public void V1_ConvertToEntry_HashSet()
        {
            var hashSet = new HashSet<long> { 0, 1, 2 };
            var entry = DynamoDBEntryConversion.V1.ConvertToEntry(hashSet);
            var expectedList = new PrimitiveList(DynamoDBEntryType.Numeric) { Entries = { 0, 1, 2 } };
            Assert.AreEqual(expectedList, entry);
        }

        [TestMethod]
        public void V2_ConvertToEntry_Array()
        {
            var array = new[] { "A", "B", "C" };
            var entry = DynamoDBEntryConversion.V2.ConvertToEntry(array);
            var expectedList = new DynamoDBList(new DynamoDBEntry[]
            {
                new Primitive("A"), new Primitive("B"),  new Primitive("C")
            });
            Assert.AreEqual(expectedList, entry);
        }

        [TestMethod]
        public void V2_ConvertToEntry_List()
        {
            var list = new List<int> { 3, 2, 1 };
            var entry = DynamoDBEntryConversion.V2.ConvertToEntry(list);
            var expectedList = new DynamoDBList(new DynamoDBEntry[]
            {
                new Primitive("3", true), new Primitive("2", true),  new Primitive("1", true)
            });
            Assert.AreEqual(expectedList, entry);
        }

        [TestMethod]
        public void V2_ConvertToEntry_HashSet()
        {
            var hashSet = new HashSet<long> { 0, 1, 2 };
            var entry = DynamoDBEntryConversion.V2.ConvertToEntry(hashSet);
            var expectedList = new PrimitiveList(DynamoDBEntryType.Numeric)
            {
                Entries = { new Primitive("0", true), new Primitive("1", true), new Primitive("2", true) }
            };
            Assert.AreEqual(expectedList, entry);
        }

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

        private enum TestEnum { A, B, C }
    }
}