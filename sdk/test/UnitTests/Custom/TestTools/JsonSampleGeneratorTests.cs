using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text.Json;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ServiceClientGenerator;

namespace AWSSDK_DotNet.UnitTests.TestTools
{
    [TestClass]
    public class JsonSampleGeneratorTests
    {
        static readonly ServiceModel DYNAMODB_MODEL = Utils.LoadServiceModel("dynamodb");

        [TestMethod][TestCategory("UnitTest")]
        public void SanityGenerateForAllDynamoDBOperations()
        {
            foreach (var operation in DYNAMODB_MODEL.Operations)
            {
                try
                {
                    string requestJson, responseJson;
                    Generate(DYNAMODB_MODEL, operation.Name, out requestJson, out responseJson);
                }
                catch (Exception e)
                {
                    throw new Exception("Failed to generate for operation " + operation, e);
                }
            }
        }

        [TestMethod][TestCategory("UnitTest")]
        public void ListTables()
        {
            string requestJson, responseJson;
            Generate(DYNAMODB_MODEL, "ListTables", out requestJson, out responseJson);
            Assert.IsNotNull(requestJson);
            Assert.IsNotNull(responseJson);

            JsonDocument rootData = JsonDocument.Parse(requestJson);

            Assert.IsTrue(rootData.RootElement.GetProperty("ExclusiveStartTableName").ValueKind == JsonValueKind.String);
            Assert.IsTrue(rootData.RootElement.GetProperty("Limit").ValueKind == JsonValueKind.Number);

            rootData = JsonDocument.Parse(responseJson);
            Assert.IsTrue(rootData.RootElement.GetProperty("LastEvaluatedTableName").ValueKind == JsonValueKind.String);
            Assert.IsTrue(rootData.RootElement.GetProperty("TableNames").ValueKind == JsonValueKind.Array);
            Assert.IsTrue(rootData.RootElement.GetProperty("TableNames").EnumerateArray().First().ValueKind == JsonValueKind.String);
        }

        [TestMethod][TestCategory("UnitTest")]
        public void GetItem()
        {
            string requestJson, responseJson;
            Generate(DYNAMODB_MODEL, "GetItem", out requestJson, out responseJson);
            Assert.IsNotNull(requestJson);
            Assert.IsNotNull(responseJson);

            JsonDocument rootData = JsonDocument.Parse(requestJson);

            Assert.IsTrue(rootData.RootElement.GetProperty("AttributesToGet").ValueKind == JsonValueKind.Array);
            Assert.IsTrue(rootData.RootElement.GetProperty("AttributesToGet").EnumerateArray().First().ValueKind == JsonValueKind.String);

            Assert.IsTrue(rootData.RootElement.GetProperty("ConsistentRead").ValueKind == JsonValueKind.True || rootData.RootElement.GetProperty("ConsistentRead").ValueKind == JsonValueKind.False);
            Assert.IsTrue(rootData.RootElement.GetProperty("TableName").ValueKind == JsonValueKind.String);
            Assert.IsTrue(rootData.RootElement.GetProperty("ReturnConsumedCapacity").ValueKind == JsonValueKind.String);

            Assert.IsTrue(rootData.RootElement.GetProperty("Key").ValueKind == JsonValueKind.Object);
            Assert.IsTrue(rootData.RootElement.GetProperty("Key").EnumerateObject().All(x => x.Value.ValueKind == JsonValueKind.Object));


            rootData = JsonDocument.Parse(responseJson);
            Assert.IsTrue(rootData.RootElement.GetProperty("ConsumedCapacity").ValueKind == JsonValueKind.Object);  
            Assert.IsTrue(rootData.RootElement.GetProperty("ConsumedCapacity").GetProperty("CapacityUnits").ValueKind == JsonValueKind.Number);

            Assert.IsTrue(rootData.RootElement.GetProperty("ConsumedCapacity").GetProperty("GlobalSecondaryIndexes").ValueKind == JsonValueKind.Object);
            Assert.IsTrue(rootData.RootElement.GetProperty("ConsumedCapacity").GetProperty("GlobalSecondaryIndexes").EnumerateObject().All(x => x.Value.ValueKind == JsonValueKind.Object));
            Assert.IsTrue(rootData.RootElement.GetProperty("ConsumedCapacity").GetProperty("GlobalSecondaryIndexes").EnumerateObject().All(x => x.Value.GetProperty("CapacityUnits").ValueKind == JsonValueKind.Number));

            Assert.IsTrue(rootData.RootElement.GetProperty("ConsumedCapacity").GetProperty("LocalSecondaryIndexes").ValueKind == JsonValueKind.Object);
            Assert.IsTrue(rootData.RootElement.GetProperty("ConsumedCapacity").GetProperty("LocalSecondaryIndexes").EnumerateObject().All(x => x.Value.ValueKind == JsonValueKind.Object));
            Assert.IsTrue(rootData.RootElement.GetProperty("ConsumedCapacity").GetProperty("LocalSecondaryIndexes").EnumerateObject().All(x => x.Value.GetProperty("CapacityUnits").ValueKind == JsonValueKind.Number));


            Assert.IsTrue(rootData.RootElement.GetProperty("ConsumedCapacity").GetProperty("Table").ValueKind == JsonValueKind.Object);
            Assert.IsTrue(rootData.RootElement.GetProperty("ConsumedCapacity").GetProperty("Table").GetProperty("CapacityUnits").ValueKind == JsonValueKind.Number);

            Assert.IsTrue(rootData.RootElement.GetProperty("Item").ValueKind == JsonValueKind.Object);
            foreach (var kvp in rootData.RootElement.GetProperty("Item").EnumerateObject())
            {
                Assert.IsTrue(kvp.Value.ValueKind == JsonValueKind.Object);
                Assert.IsTrue(kvp.Value.GetProperty("B").ValueKind == JsonValueKind.String);
                Assert.IsTrue(kvp.Value.GetProperty("BS").ValueKind == JsonValueKind.Array);
                Assert.IsTrue(kvp.Value.GetProperty("BS").EnumerateArray().First().ValueKind == JsonValueKind.String);

                Assert.IsTrue(kvp.Value.GetProperty("N").ValueKind == JsonValueKind.String);
                Assert.IsTrue(kvp.Value.GetProperty("NS").ValueKind == JsonValueKind.Array);
                Assert.IsTrue(kvp.Value.GetProperty("NS").EnumerateArray().First().ValueKind == JsonValueKind.String);

                Assert.IsTrue(kvp.Value.GetProperty("S").ValueKind == JsonValueKind.String);
                Assert.IsTrue(kvp.Value.GetProperty("SS").ValueKind == JsonValueKind.Array);
                Assert.IsTrue(kvp.Value.GetProperty("SS").EnumerateArray().First().ValueKind == JsonValueKind.String);
            }
        }

        void Generate(ServiceModel model, string operationName, out string requestJson, out string responseJson)
        {
            var operation = model.Operations.First(x => x.Name == operationName);

            if (operation.RequestStructure == null)
                requestJson = null;
            else
            {
                var requestGenerator = new JsonSampleGenerator(model, operation.RequestStructure);
                requestJson = requestGenerator.Execute();
            }

            if (operation.ResponseStructure == null)
                responseJson = null;
            else
            {
                var responseGenerator = new JsonSampleGenerator(model, operation.ResponseStructure);
                responseJson = responseGenerator.Execute();
            }
           
        }
    }
}
