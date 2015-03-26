using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;

using ServiceClientGenerator;

using ThirdParty.Json.LitJson;

namespace AWSSDK_DotNet35.UnitTests.TestTools
{
    [TestClass]
    public class JsonSampleGeneratorTests
    {
        static readonly ServiceModel DYNAMODB_MODEL = Utils.LoadServiceModel("dynamodb-2012-08-10.normal.json", null);

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

            JsonData rootdata = JsonMapper.ToObject(requestJson);

            Assert.IsTrue(rootdata["ExclusiveStartTableName"].IsString);
            Assert.IsTrue(rootdata["Limit"].IsInt);


            rootdata = JsonMapper.ToObject(responseJson);
            Assert.IsTrue(rootdata["LastEvaluatedTableName"].IsString);
            Assert.IsTrue(rootdata["TableNames"].IsArray);
            Assert.IsTrue(rootdata["TableNames"][0].IsString);
        }

        [TestMethod][TestCategory("UnitTest")]
        public void GetItem()
        {
            string requestJson, responseJson;
            Generate(DYNAMODB_MODEL, "GetItem", out requestJson, out responseJson);

            JsonData rootdata = JsonMapper.ToObject(requestJson);

            Assert.IsTrue(rootdata["AttributesToGet"].IsArray);
            Assert.IsTrue(rootdata["AttributesToGet"][0].IsString);

            Assert.IsTrue(rootdata["ConsistentRead"].IsBoolean);
            Assert.IsTrue(rootdata["TableName"].IsString);
            Assert.IsTrue(rootdata["ReturnConsumedCapacity"].IsString);

            Assert.IsTrue(rootdata["Key"].IsObject);
            foreach (KeyValuePair<string, JsonData> kvp in rootdata["Key"])
            {
                Assert.IsTrue(kvp.Value.IsObject);
            }


            rootdata = JsonMapper.ToObject(responseJson);
            Assert.IsTrue(rootdata["ConsumedCapacity"].IsObject);
            Assert.IsTrue(rootdata["ConsumedCapacity"]["CapacityUnits"].IsDouble);

            Assert.IsTrue(rootdata["ConsumedCapacity"]["GlobalSecondaryIndexes"].IsObject);
            foreach (KeyValuePair<string, JsonData> kvp in rootdata["ConsumedCapacity"]["GlobalSecondaryIndexes"])
            {
                Assert.IsTrue(kvp.Value.IsObject);
                Assert.IsTrue(kvp.Value["CapacityUnits"].IsDouble);
            }

            Assert.IsTrue(rootdata["ConsumedCapacity"]["LocalSecondaryIndexes"].IsObject);
            foreach (KeyValuePair<string, JsonData> kvp in rootdata["ConsumedCapacity"]["LocalSecondaryIndexes"])
            {
                Assert.IsTrue(kvp.Value.IsObject);
                Assert.IsTrue(kvp.Value["CapacityUnits"].IsDouble);
            }

            Assert.IsTrue(rootdata["ConsumedCapacity"]["LocalSecondaryIndexes"].IsObject);
            foreach (KeyValuePair<string, JsonData> kvp in rootdata["ConsumedCapacity"]["LocalSecondaryIndexes"])
            {
                Assert.IsTrue(kvp.Value.IsObject);
                Assert.IsTrue(kvp.Value["CapacityUnits"].IsDouble);
            }

            Assert.IsTrue(rootdata["ConsumedCapacity"]["Table"].IsObject);
            Assert.IsTrue(rootdata["ConsumedCapacity"]["Table"]["CapacityUnits"].IsDouble);

            Assert.IsTrue(rootdata["Item"].IsObject);
            foreach (KeyValuePair<string, JsonData> kvp in rootdata["Item"])
            {
                Assert.IsTrue(kvp.Value.IsObject);
                Assert.IsTrue(kvp.Value["B"].IsString);
                Assert.IsTrue(kvp.Value["BS"].IsArray);
                Assert.IsTrue(kvp.Value["BS"][0].IsString);

                Assert.IsTrue(kvp.Value["N"].IsString);
                Assert.IsTrue(kvp.Value["NS"].IsArray);
                Assert.IsTrue(kvp.Value["NS"][0].IsString);

                Assert.IsTrue(kvp.Value["S"].IsString);
                Assert.IsTrue(kvp.Value["SS"].IsArray);
                Assert.IsTrue(kvp.Value["SS"][0].IsString);
            }
        }

        void Generate(ServiceModel model, string operationName, out string requestJson, out string responseJson)
        {
            var operation = model.Operations.First(x => x.Name == operationName);
            JsonSampleGenerator generator = new JsonSampleGenerator(model, operation.RequestStructure);
            requestJson = generator.Execute();

            generator = new JsonSampleGenerator(model, operation.ResponseStructure);
            responseJson = generator.Execute();
        }
    }
}
