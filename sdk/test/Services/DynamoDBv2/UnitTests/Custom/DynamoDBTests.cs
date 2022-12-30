using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using Microsoft.VisualStudio.TestTools.UnitTesting;

using Amazon.Auth.AccessControlPolicy;
using Amazon.Auth.AccessControlPolicy.ActionIdentifiers;
using Amazon.DynamoDBv2.DocumentModel;
using Amazon.DynamoDBv2.DataModel;
using Amazon.DynamoDBv2.Model;
using Amazon.DynamoDBv2;
using ThirdParty.Json.LitJson;

using Moq;

namespace AWSSDK_DotNet35.UnitTests
{
    [TestClass]
    public class DynamoDBEntryTests
    {
        [TestMethod]
        [TestCategory("DynamoDBv2")]
        public void TestDynamoDBEqualsOverrides()
        {
            var ddbeType = typeof(DynamoDBEntry);
            var ddbeSubTypes = GetSubTypes(ddbeType);
            foreach(var subType in ddbeSubTypes)
            {
                var equalsMethod = subType.GetMethod("Equals", new Type[] { typeof(object) });
                Assert.IsTrue(equalsMethod.DeclaringType == subType, "Testing that type {0} implements Equals", subType.FullName);
            }

            Console.WriteLine(ddbeSubTypes.Count);
        }

        [TestMethod]
        [TestCategory("DynamoDBv2")]
        public void TestContextConfig()
        {
            // Test in response to GitHub issue
            // https://github.com/aws/aws-sdk-net/issues/209
            var config = new DynamoDBContextConfig()
            {
                TableNamePrefix = "Test"
            };

            Assert.AreEqual("Test", config.TableNamePrefix);
        }

        [TestMethod]
        [TestCategory("DynamoDBv2")]
        public void TestConvertingListIfNullSet()
        {
            var initialAttributeMap = new Dictionary<string, AttributeValue>
            {
                {
                    "testlist", new AttributeValue
                    {
                        L = new List<AttributeValue>
                        {
                            new AttributeValue("test")
                        },
                        NULL = false
                    }
                }
            };

            var dynamoDocument = Document.FromAttributeMap(initialAttributeMap);

            Assert.AreEqual("test", dynamoDocument["testlist"].AsDynamoDBList().Entries[0].AsString());
        }

        [TestMethod]
        [TestCategory("DynamoDBv2")]
        public void TestConvertingMapIfNullSet()
        {
            var initialAttributeMap = new Dictionary<string, AttributeValue>
            {
                {
                    "testmap", new AttributeValue
                    {
                        M = new Dictionary<string, AttributeValue>(){{"test", new AttributeValue("testvalue")}},
                        NULL = false
                    }
                }
            };

            var dynamoDocument = Document.FromAttributeMap(initialAttributeMap);

            Assert.AreEqual("testvalue", dynamoDocument["testmap"].AsDocument()["test"].AsString());
        }

        [TestMethod]
        [TestCategory("DynamoDBv2")]
        public void TestConvertingEmptyListToJson()
        {
            var initialAttributeMap = new Dictionary<string, AttributeValue>
            {
                { "Lists", new AttributeValue
                    {
                        L = new List<AttributeValue>
                        {
                            new AttributeValue
                            {
                                M = new Dictionary<string, AttributeValue>(),
                            }
                        }
                    }
                }
            };

            var document = Document.FromAttributeMap(initialAttributeMap);
            Assert.AreEqual(document["Lists"].AsListOfDocument().Count, 0);

            var jsonString = document.ToJson();
            Assert.IsNotNull(jsonString);
        }

        [TestMethod]
        [TestCategory("DynamoDBv2")]
        [DataRow(@"{
            ""Lists"": {
                ""L"": [
                    {
                        ""M"": {
                            ""SubLists"": {
                                ""L"": [
                                    {
                                        ""M"": {}
                                    }
                                ]
                            }
                        }
                    }
                ]
            }
        }")]
        [DataRow(@"{
            ""Lists"": {
                ""L"": [
                    {
                        ""M"": {}
                    }
                ]
            }
        }")]
        public void TestJsonContainsEmptyMapToDocumentAndBackToJson(string json)
        {
            var initialDocument = Document.FromJson(json);
            Assert.IsNotNull(initialDocument);

            var initialAttributeMap = initialDocument.ToAttributeMap();
            var convertedDocument = Document.FromAttributeMap(initialAttributeMap);
            Assert.IsNotNull(convertedDocument);

            var jsonString = convertedDocument.ToJson();
            Assert.IsNotNull(jsonString);
        }

        private static List<Type> GetSubTypes(Type baseType)
        {
            var assembly = baseType.Assembly;
            var allTypes = assembly.GetTypes();

            var subTypes = new List<Type>();
            foreach (var type in allTypes)
            {
                if (baseType.IsAssignableFrom(type) &&
                    baseType != type)
                    subTypes.Add(type);
            }
            return subTypes;
        }

        [TestMethod]
        [TestCategory("DynamoDBv2")]
        public void DocumentFromJsonTest()
        {
            string jsonDocument =
@"{
""Zero""   : 0,
""PInt""   : 2147483647,
""NInt""   : -2147483648,
""UInt""   : 4294967295,
""Long""   : 4294967296,
""PLong""  : 9223372036854775807,
""NLong""  : -9223372036854775808, 
""ULong""  : 18446744073709551615,
""Double"" : 0.0,
""PDouble"": 1.7976931348623157E+308,
""NDouble"": -1.7976931348623157E+308
}";
            var dynamoDBDocument = Document.FromJson(jsonDocument);

            Assert.IsNotNull(dynamoDBDocument);

            Assert.AreEqual(0,                          dynamoDBDocument["Zero"].AsInt());
            Assert.AreEqual(2147483647,                 dynamoDBDocument["PInt"].AsInt());
            Assert.AreEqual(-2147483648,                dynamoDBDocument["NInt"].AsInt());
            Assert.AreEqual(4294967295,                 dynamoDBDocument["UInt"].AsUInt());
            Assert.AreEqual(4294967296,                 dynamoDBDocument["Long"].AsLong());
            Assert.AreEqual(9223372036854775807,        dynamoDBDocument["PLong"].AsLong());
            Assert.AreEqual(-9223372036854775808,       dynamoDBDocument["NLong"].AsLong());
            Assert.AreEqual(18446744073709551615,       dynamoDBDocument["ULong"].AsULong());
            Assert.AreEqual(0.0,                        dynamoDBDocument["Double"].AsDouble());
            Assert.AreEqual(1.7976931348623157E+308,    dynamoDBDocument["PDouble"].AsDouble());
            Assert.AreEqual(-1.7976931348623157E+308,   dynamoDBDocument["NDouble"].AsDouble());

            JsonData jsonOriginal = JsonMapper.ToObject(jsonDocument);
            JsonData jsonNew = JsonMapper.ToObject(dynamoDBDocument.ToJson());

            foreach (string property in jsonOriginal.PropertyNames)
            {
                Assert.AreEqual(jsonOriginal[property].ToString(), jsonNew[property].ToString());
            }
        }

        [TestMethod]
        [TestCategory("DynamoDBv2")]
        public void TestEmptyPropertyFromObjectOnDocument()
        {
            var doc = new Document
            {
                ["Name"] = (string)null
            };

            Assert.IsTrue(doc["Name"] is Primitive);
            Assert.IsNull(doc["Name"].AsPrimitive().Value);
        }

        [TestMethod]
        [TestCategory("DynamoDBv2")]
        public void TestExplicitNullPropertyOnDocument()
        {
            var doc = new Document
            {
                ["Name"] = null
            };

            Assert.IsTrue(doc["Name"] is Primitive);
            Assert.IsNull(doc["Name"].AsPrimitive().Value);
        }

        [TestMethod]
        [TestCategory("DynamoDBv2")]
        public void TestFromJsonCanHandleAllDateTypes()
        {
            var json = @"
                {
                  ""StringValue"": ""test string"",
                  ""BoolValue"": true,
                  ""IntValue"": 200,
                  ""DateValue"": ""2022-12-29T12:46:14.097Z"",
                  ""NullableBoolValue"": null,
                  ""NullableIntValue"": null,
                  ""NullableDateValue"": null,
                  ""SubData"": null,
                  ""SubData2"": {
                    ""StringValue"": null,
                    ""NullableBoolValue"": false,
                    ""NullableIntValue"": 500,
                    ""NullableDateValue"": ""2022-12-28T12:46:14.097Z""
                  }
                }";

            using (var dbClient = new AmazonDynamoDBClient())
            using (var context = new DynamoDBContext(dbClient))
            {
                var document = Document.FromJson(json);
                var container = context.FromDocument<DataContainer>(document);

                Assert.IsNotNull(container);
                Assert.AreEqual(container.StringValue, "test string");
                Assert.AreEqual(container.BoolValue, true);
                Assert.AreEqual(container.IntValue, 200);
                Assert.AreEqual(container.DateValue, DateTime.Parse("2022-12-29T12:46:14.097Z"));
                Assert.IsNull(container.NullableBoolValue);
                Assert.IsNull(container.NullableIntValue);
                Assert.IsNull(container.NullableDateValue);
                Assert.IsNull(container.SubData);
                Assert.IsNotNull(container.SubData2);
                Assert.IsNull(container.SubData2.StringValue);
                Assert.IsNotNull(container.SubData2.NullableIntValue);
            }
        }

        public class DataContainer
        {
            public string StringValue { get; set; }
            public bool BoolValue { get; set; }
            public int IntValue { get; set; }
            public DateTime DateValue { get; set; }

            public bool? NullableBoolValue { get; set; }
            public int? NullableIntValue { get; set; }
            public DateTime? NullableDateValue { get; set; }

            public SubContainer SubData { get; set; }
            public SubContainer SubData2 { get; set; }

            public class SubContainer
            {
                public string StringValue { get; set; }
                public bool? NullableBoolValue { get; set; }
                public int? NullableIntValue { get; set; }
                public DateTime? NullableDateValue { get; set; }
            }
        }

#if ASYNC_AWAIT
        [TestMethod]
        [TestCategory("DynamoDBv2")]
        public async Task TestMockingAsyncSeach()
        {
            var mockDBContext = new Mock<IDynamoDBContext>();
            mockDBContext
                .Setup(x => x.ScanAsync<DataItem>(
                   It.IsAny<IEnumerable<ScanCondition>>(),
                   It.IsAny<DynamoDBOperationConfig>()))
                .Returns(
                   new MockAsyncSearch<DataItem>() // Return mock version of AsyncSearch
                );

            var search = mockDBContext.Object.ScanAsync<DataItem>(new List<ScanCondition>());
            Assert.IsInstanceOfType(search, typeof(MockAsyncSearch<DataItem>));

            var items = await search.GetNextSetAsync();
            Assert.AreEqual(0, items.Count());
        }

        public class DataItem
        {
            public string Id { get; set; }
        }

        public class MockAsyncSearch<T> : AsyncSearch<T>
        {
            public override Task<List<T>> GetNextSetAsync(CancellationToken cancellationToken = default(CancellationToken))
            {
                return Task.FromResult(new List<T>());
            }
        }
#endif
    }
}
