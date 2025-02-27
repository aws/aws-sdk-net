using Amazon.DynamoDBv2;
using Amazon.DynamoDBv2.DocumentModel;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;

namespace AWSSDK_DotNet.UnitTests
{
    [TestClass]
    public class DynamoDBEntryConversionTests
    {
        [TestMethod]
        public void ValidateAllConvertersAreRegisteredForConversionV1()
        {
            AssertAllConvertersAreRegistered(DynamoDBEntryConversion.V1, "ConverterV1");
        }

        [TestMethod]
        public void ValidateAllConvertersAreRegisteredForConversionV2()
        {
            AssertAllConvertersAreRegistered(DynamoDBEntryConversion.V2, "ConverterV2");
        }

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
            var entry = new Primitive("2024-07-03T01:31:47.000Z", false);
            var actualDateTime = conversion.ConvertFromEntry<DateTime>(entry);
            var expectedDateTime = new DateTime(2024, 07, 03, 01, 31, 47, DateTimeKind.Utc);
            Assert.AreEqual(expectedDateTime, actualDateTime);
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

#if NET8_0_OR_GREATER
        [DataTestMethod]
        [DynamicData((nameof(DynamoDBEntryConversions)))]
        public void ConvertToEntry_DateOnly(DynamoDBEntryConversion conversion)
        {
            var dateOnly = new DateOnly(2024, 07, 03);
            var entry = conversion.ConvertToEntry(dateOnly);
            Assert.AreEqual(new Primitive("2024-07-03", false), entry);
        }

        [DataTestMethod]
        [DynamicData((nameof(DynamoDBEntryConversions)))]
        public void ConvertFromEntry_DateOnly(DynamoDBEntryConversion conversion)
        {
            var entry = new Primitive("2024-07-03", false);
            var actualDateOnly = conversion.ConvertFromEntry<DateOnly>(entry);
            var expectedDateOnly = new DateOnly(2024, 07, 03);
            Assert.AreEqual(expectedDateOnly, actualDateOnly);
        }

        [DataTestMethod]
        [DynamicData((nameof(DynamoDBEntryConversions)))]
        public void ConvertToEntry_TimeOnly(DynamoDBEntryConversion conversion)
        {
            var timeOnly = new TimeOnly(18, 31, 56, 123);
            var entry = conversion.ConvertToEntry(timeOnly);
            Assert.AreEqual(new Primitive("18:31:56.123", false), entry);
        }

        [DataTestMethod]
        [DynamicData((nameof(DynamoDBEntryConversions)))]
        public void ConvertFromEntry_TimeOnly(DynamoDBEntryConversion conversion)
        {
            var entry = new Primitive("18:31:56.123", false);
            var actualTimeOnly = conversion.ConvertFromEntry<TimeOnly>(entry);
            var expectedTimeOnly = new TimeOnly(18, 31, 56, 123);
            Assert.AreEqual(expectedTimeOnly, actualTimeOnly);
        }

        [DataTestMethod]
        [DynamicData((nameof(DynamoDBEntryConversions)))]
        public void ConvertFromEntry_ShouldBeAbleToReadDateOnlyAsDateTime(DynamoDBEntryConversion conversion)
        {
            var dateOnly = new DateOnly(2024, 07, 03);
            var entry = conversion.ConvertToEntry(dateOnly);

            var actualDateTime = conversion.ConvertFromEntry<DateTime>(entry);
            var expectedDateTime = new DateTime(2024, 07, 03, 0, 0, 0, DateTimeKind.Utc);

            Assert.AreEqual(expectedDateTime, actualDateTime);
        }
#endif

        private void AssertAllConvertersAreRegistered(DynamoDBEntryConversion conversion, string suffix)
        {
            var converters = GetConverters(suffix);

            var tryGetConverterInfo = conversion.GetType().GetMethod("TryGetConverter", BindingFlags.NonPublic | BindingFlags.Instance);

            foreach (var converter in converters)
            {
                var getTargetTypeInfo = converter.GetType().GetMethod("GetTargetTypes");
                IEnumerable<Type> targetTypes = (IEnumerable<Type>)getTargetTypeInfo.Invoke(converter, new object[0]);
                foreach (var type in targetTypes)
                {
                    var tryGetConverterParams = new object[] { type, null };
                    tryGetConverterInfo.Invoke(conversion, tryGetConverterParams);
                    var registeredConverter = tryGetConverterParams[1];

                    Assert.IsNotNull(registeredConverter);
                    Assert.AreEqual(converter.GetType(), registeredConverter.GetType());
                }
            }
        }

        private IEnumerable<object> GetConverters(string suffix)
        {
            const string converterTypeName = "Amazon.DynamoDBv2.Converter";
            var assembly = typeof(DynamoDBEntryConversion).Assembly;

            var allTypes = assembly.GetTypes();
            var typedConverterType = allTypes.FirstOrDefault(x => string.Equals(converterTypeName, x.FullName));

            foreach (var type in allTypes)
            {
                if (type.IsAbstract)
                    continue;

                if (!type.Name.EndsWith(suffix, StringComparison.Ordinal))
                    continue;

                if (!typedConverterType.IsAssignableFrom(type))
                    continue;

                var constructor = type.GetConstructor(BindingFlags.NonPublic | BindingFlags.Public | BindingFlags.Instance, null, new Type[0], null);
                yield return constructor.Invoke(new object[0]);
            }
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