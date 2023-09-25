﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using Microsoft.VisualStudio.TestTools.UnitTesting;

using Amazon.Auth.AccessControlPolicy;
using Amazon.Auth.AccessControlPolicy.ActionIdentifiers;
using Amazon.DynamoDBv2;
using Amazon.DynamoDBv2.DocumentModel;
using Amazon.DynamoDBv2.DataModel;
using Amazon.DynamoDBv2.Model;
using ThirdParty.Json.LitJson;

using Moq;
using Amazon;

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

        public class DateTestObject
        {
            public DateTime DateFromString { get; set; }
        }
        //This test is based off issue #2020 where user reported datetime with no decimals not being converted properly. 
        [TestMethod]
        [TestCategory("DynamoDBv2")]
        public void TestDateTimeDeserializationWithDdbContext()
        {
            //Arrange
            var dateWithNoDecimals = "2022-05-05T11:56:11Z";
            var expectedDateNoDecimal = DateTime.Parse(dateWithNoDecimals);

            var dateWithDecimals = "2022-05-05T11:56:11.000Z";
            var expectedDateDecimal = DateTime.Parse(dateWithDecimals);

            var jsonDateWithNoDecimals = JsonMapper.ToJson(new
            {
                DateFromString = dateWithNoDecimals
            });
            var jsonDateWithDecimals = JsonMapper.ToJson(new
            {
                DateFromString = dateWithDecimals
            });

            using (var dynamoDBContext = new DynamoDBContext())
            {
                var noDecimalDoc = Document.FromJson(jsonDateWithNoDecimals);
                var decimalDoc = Document.FromJson(jsonDateWithDecimals);

                var noDecimalContext = dynamoDBContext.FromDocument<DateTestObject>(noDecimalDoc);
                var decimalContext = dynamoDBContext.FromDocument<DateTestObject>(decimalDoc);

                Assert.IsNotNull(noDecimalContext);
                Assert.IsNotNull(decimalContext);
                //Assert that the two different formatted json dates get converted to the same date
                Assert.AreEqual(noDecimalContext.DateFromString, decimalContext.DateFromString);
                //Assert that the conversion itself works
                Assert.AreEqual(expectedDateNoDecimal, noDecimalContext.DateFromString);
                Assert.AreEqual(expectedDateDecimal, decimalContext.DateFromString);
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
        public void TestPropertyAttributeInheritance()
        {
            // Use a mock client to skip credential checks.
            var mockClient = new Mock<IAmazonDynamoDB>();
            var context = new DynamoDBContext(mockClient.Object);

            var parent = new Parent();
            parent.Property1 = "Value";

            var child = new Child();
            child.Property1 = "Value";

            var parentDocument = context.ToDocument(parent);
            var childDocument = context.ToDocument(child);

            Assert.AreEqual(parentDocument["actualPropertyName"].AsString(), parent.Property1);
            Assert.AreEqual(childDocument["actualPropertyName"].AsString(), child.Property1);
        }

        [TestMethod]
        [TestCategory("DynamoDBv2")]
        public void TestVersionAttributeRename()
        {
            var mockClient = new Mock<IAmazonDynamoDB>();
            var context = new DynamoDBContext(mockClient.Object);

            var parent = new Parent
            {
                Property1 = "Value",
                Version = 1
            };

            var document = context.ToDocument(parent);
            var attributes = document.ToAttributeMap();

            Assert.IsTrue(attributes.ContainsKey("V"));
            Assert.AreEqual(document["V"].AsInt(), 1);
        }

        [TestMethod]
        [TestCategory("DynamoDBv2")]
        public void TestGetTargetTable_DisableFetchingTableMetadata()
        {
            var dynamoDBContextConfig = new DynamoDBContextConfig
            {
                DisableFetchingTableMetadata = true,
                TableNamePrefix = "DotnetTest-"
            };
            var dynamoDBClient = new Mock<IAmazonDynamoDB>();
            var dynamoDBContext = new DynamoDBContext(dynamoDBClient.Object, dynamoDBContextConfig);

            var table = dynamoDBContext.GetTargetTable<Employee>();
            Assert.IsNotNull(table);
            Assert.AreEqual("DotnetTest-EmployeeDetails", table.TableName);
            Assert.AreEqual(2, table.Keys.Count);
            Assert.IsTrue(table.Keys.ContainsKey("Name"));
            Assert.IsTrue(table.Keys.ContainsKey("Age"));

            Assert.AreEqual(1, table.HashKeys.Count);
            Assert.AreEqual("Name", table.HashKeys[0]);

            Assert.AreEqual(1, table.RangeKeys.Count);
            Assert.AreEqual("Age", table.RangeKeys[0]);

            Assert.AreEqual(1, table.GlobalSecondaryIndexes.Count);
            var gsi = table.GlobalSecondaryIndexes["GlobalIndex"];
            Assert.AreEqual("GlobalIndex", gsi.IndexName);
            Assert.AreEqual(2, gsi.KeySchema.Count);
            Assert.AreEqual("Company", gsi.KeySchema[0].AttributeName);
            Assert.AreEqual(KeyType.HASH, gsi.KeySchema[0].KeyType);
            Assert.AreEqual("Score", gsi.KeySchema[1].AttributeName);
            Assert.AreEqual(KeyType.RANGE, gsi.KeySchema[1].KeyType);

            Assert.AreEqual(1, table.LocalSecondaryIndexes.Count);
            var lsi = table.LocalSecondaryIndexes["LocalIndex"];
            Assert.AreEqual("LocalIndex", lsi.IndexName);
            Assert.AreEqual(2, lsi.KeySchema.Count);
            Assert.AreEqual("Name", lsi.KeySchema[0].AttributeName);
            Assert.AreEqual(KeyType.HASH, lsi.KeySchema[0].KeyType);
            Assert.AreEqual("Manager", lsi.KeySchema[1].AttributeName);
            Assert.AreEqual(KeyType.RANGE, lsi.KeySchema[1].KeyType);
        }

        [TestMethod]
        [TestCategory("DynamoDBv2")]
        public void TestDisableFetchingTableMetadata_UsingGlobalContext()
        {
            AWSConfigsDynamoDB.Context.DisableFetchingTableMetadata = true;
            var config = new DynamoDBContextConfig();
            Assert.AreEqual(true, config.DisableFetchingTableMetadata);
            AWSConfigsDynamoDB.Context.DisableFetchingTableMetadata = false;
        }

        public class Parent
        {
            [DynamoDBProperty("actualPropertyName")]
            public virtual string Property1 { get; set; }

            [DynamoDBVersion(AttributeName = "V")]
            public int? Version { get; set; }
        }

        public class Child : Parent
        {
            public override string Property1 { get; set; }
        }

        [DynamoDBTable("EmployeeDetails")]
        public class Employee
        {
            // Hash key
            [DynamoDBHashKey]
            public string Name { get; set; }

            // Range key
            [DynamoDBRangeKey]
            public int Age { get; set; }

            [DynamoDBGlobalSecondaryIndexHashKey("GlobalIndex", AttributeName = "Company")]
            public string CompanyName { get; set; }

            [DynamoDBGlobalSecondaryIndexRangeKey("GlobalIndex")]
            public int Score { get; set; }

            [DynamoDBLocalSecondaryIndexRangeKey("LocalIndex", AttributeName = "Manager")]
            public string ManagerName { get; set; }
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

        /// <summary>
        /// Asserts that our desired exception is thrown when attempting to make a query
        /// that relies on the hash key without correct table metadata
        /// </summary>
        [TestMethod]
        public void DisableFetchingTableMetadata_QueryWithMissingHashKey_ThrowsException()
        {
            var config = new DynamoDBContextConfig()
            {
                DisableFetchingTableMetadata = true
            };

            var context = new DynamoDBContext(new Mock<IAmazonDynamoDB>().Object, config);

            Assert.ThrowsException<InvalidOperationException>(() => context.Query<EmployeeMissingHashKey>("123"));
        }

        /// <summary>
        /// Asserts that our desired exception is thrown when attempting to make a query
        /// that relies on a range key without correct table metadata
        /// </summary>
        [TestMethod]
        public void DisableFetchingTableMetadata_QueryWithMissingRangeKey_ThrowsException()
        {
            var config = new DynamoDBContextConfig()
            {
                DisableFetchingTableMetadata = true
            };

            var context = new DynamoDBContext(new Mock<IAmazonDynamoDB>().Object, config);

            // This is the table's range key, which is not attributed
            Assert.ThrowsException<InvalidOperationException>(() => 
            context.Query<EmployeeMissingRangeKeys>("123", QueryOperator.GreaterThan, 5));
            
            // This is a GSI's range key, which is not attributed
            Assert.ThrowsException<InvalidOperationException>(() =>
                context.Query<EmployeeMissingRangeKeys>("123", QueryOperator.GreaterThan, new List<object> { 5 }, new DynamoDBOperationConfig { IndexName = "GlobalIndex"}));
        }

        [DynamoDBTable("EmployeeDetails")]
        public class EmployeeMissingHashKey
        {
            public string Name { get; set; }

            public int Age { get; set; }
        }

        [DynamoDBTable("EmployeeDetails")]
        public class EmployeeMissingRangeKeys
        {
            [DynamoDBHashKey]
            public string Name { get; set; }

            // This is the range key for our typical testing table
            public int Age { get; set; }

            [DynamoDBLocalSecondaryIndexRangeKey("LocalIndex")]
            public string Manager { get; set; }

            [DynamoDBGlobalSecondaryIndexHashKey("GlobalIndex", AttributeName = "Company")]
            public string CompanyName { get; set; }

            // This is the range key for "GlobalIndex" for our typical testing table
            public int Score { get; set; }
        }
    }
}
