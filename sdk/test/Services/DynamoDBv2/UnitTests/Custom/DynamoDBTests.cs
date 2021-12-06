using Amazon.DynamoDBv2.DataModel;
using Amazon.DynamoDBv2.DocumentModel;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using ThirdParty.Json.LitJson;

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
        [DynamicData(nameof(DocumentDataSource), DynamicDataSourceType.Property)]
        public void TestValidConversions(Document document)
        {
            var convertedModel = new SampleModel
            {
                Name = document.GetOrDefault("preExistentkey"),
                Weight = (int)document.GetOrDefault("stableKey"),
                Active = document.GetOrDefault("newlyAddedKey")
            };

            Assert.IsNotNull(convertedModel);
            Assert.AreEqual(convertedModel.Name, document.GetOrDefault("preExistentkey").AsString());
            Assert.AreEqual(convertedModel.Weight, document.GetOrDefault("stableKey").AsInt());
            Assert.AreEqual(convertedModel.Active, document.GetOrDefault("newlyAddedKey")?.AsString());
        }

        [TestMethod]
        [TestCategory("DynamoDBv2")]
        public void TestInvalidConversion()
        {
            var document = new Document()
            {
                { "preExistentkey", "value 3"},
                { "stableKey", 5 }
            };

            Assert.ThrowsException<InvalidOperationException>(() => 
            {
                var convertedModel = new SampleModel
                {
                    Name = document.GetOrDefault("preExistentkey"),
                    Weight = (int)document.GetOrDefault("stableKey"),
                    RandomProperty = (bool)document.GetOrDefault("newlyAddedKey")
                };
            });
        }

        private class SampleModel
        {
            public string Name { get; set; }
            public int Weight { get; set; }
            public string Active { get; set; }
            public bool RandomProperty { get; set; }
        }

        static IEnumerable<Document[]> DocumentDataSource 
             => new[] 
            {
                new Document[]
                {
                    new Document()
                    {
                        { "preExistentkey", "value 1"},
                        { "stableKey", 10 },
                        { "newlyAddedKey" , null }
                    }
                },
                new Document[]
                {
                    new Document()
                    {
                        { "preExistentkey", "value 2"},
                        { "stableKey", 20 },
                        { "newlyAddedKey" , true }
                    }
                },
                new Document[]
                {
                    new Document()
                    {
                        { "preExistentkey", "value 3"},
                        { "stableKey", 5 }
                    } 
                }
            };

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

    }

    static class DocumentExtensions
    {
        public static DynamoDBEntry GetOrDefault(this Document document, string key)
        {
            document.TryGetValue(key, out DynamoDBEntry value);
            return value;
        }
    }
}
