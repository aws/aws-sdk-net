using Amazon.DynamoDBv2;
using Amazon.DynamoDBv2.DataModel;
using Amazon.DynamoDBv2.Model;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;
using System;
using System.Linq.Expressions;

namespace AWSSDK_DotNet.UnitTests
{
    [TestClass]
    public class ContextInternalTests
    {
        public class TestEntity
        {
            [DynamoDBHashKey]
            public int Id { get; set; }
            [DynamoDBRangeKey]
            public string Name { get; set; }
        }

        private Mock<IAmazonDynamoDB> mockClient;
        private DynamoDBContext context;

        [TestInitialize]
        public void TestInitialize()
        {
            mockClient = new Mock<IAmazonDynamoDB>(MockBehavior.Strict);
            mockClient.Setup(m => m.Config).Returns(new AmazonDynamoDBConfig());
            mockClient.Setup(m => m.DescribeTable(It.IsAny<DescribeTableRequest>()))
                .Returns(new DescribeTableResponse
                {
                    Table = new TableDescription
                    {
                        TableName = "TestEntity",
                        KeySchema = new System.Collections.Generic.List<KeySchemaElement>
                        {
                            new KeySchemaElement
                            {
                                AttributeName = "Id",
                                KeyType = KeyType.HASH
                            },
                            new KeySchemaElement
                            {
                                AttributeName = "Name",
                                KeyType = KeyType.RANGE
                            }
                        },
                        AttributeDefinitions = new System.Collections.Generic.List<AttributeDefinition>
                        {
                            new AttributeDefinition
                            {
                                AttributeName = "Id",
                                AttributeType = ScalarAttributeType.N
                            },
                            new AttributeDefinition
                            {
                                AttributeName = "Name",
                                AttributeType = ScalarAttributeType.S
                            }
                        }
                    }
                });

            context = new DynamoDBContext(mockClient.Object, new DynamoDBContextConfig());
        }


        [TestMethod]
        public void ConvertScan_WithFilterExpression_ReturnsMappedFilterExpression()
        {
            // Create a filter expression (e => e.Id == 1)
            Expression<Func<TestEntity, bool>> expr = e => e.Id == 1;
            var filterExpr = new ContextExpression();
            filterExpr.SetFilter(expr);

            var result = context.ConvertScan<TestEntity>(filterExpr, null);

            Assert.IsNotNull(result);
            Assert.IsNotNull(result.Search.FilterExpression);
            var actualFilterExpression = result.Search.FilterExpression;
            Assert.AreEqual("#C0 = :C0", actualFilterExpression.ExpressionStatement);
            Assert.IsNotNull(actualFilterExpression.ExpressionAttributeNames);
            Assert.IsTrue(actualFilterExpression.ExpressionAttributeNames.ContainsKey("#C0"));
            Assert.AreEqual("Id", actualFilterExpression.ExpressionAttributeNames["#C0"]);

            Assert.IsNotNull(actualFilterExpression.ExpressionAttributeValues);
            Assert.IsTrue(actualFilterExpression.ExpressionAttributeValues.ContainsKey(":C0"));
            Assert.AreEqual(1, actualFilterExpression.ExpressionAttributeValues[":C0"].AsInt());
        }

        [TestMethod]
        public void ConvertScan_WithNameFilterExpression_ReturnsMappedFilterExpression()
        {
            // Filter: e => e.Name == "foo"
            Expression<Func<TestEntity, bool>> expr = e => e.Name == "foo";
            var filterExpr = new ContextExpression();
            filterExpr.SetFilter(expr);

            var result = context.ConvertScan<TestEntity>(filterExpr, null);

            Assert.IsNotNull(result);
            Assert.IsNotNull(result.Search.FilterExpression);
            var actualFilterExpression = result.Search.FilterExpression;
            Assert.AreEqual("#C0 = :C0", actualFilterExpression.ExpressionStatement);
            Assert.IsNotNull(actualFilterExpression.ExpressionAttributeNames);
            Assert.IsTrue(actualFilterExpression.ExpressionAttributeNames.ContainsKey("#C0"));
            Assert.AreEqual("Name", actualFilterExpression.ExpressionAttributeNames["#C0"]);
            Assert.IsNotNull(actualFilterExpression.ExpressionAttributeValues);
            Assert.IsTrue(actualFilterExpression.ExpressionAttributeValues.ContainsKey(":C0"));
            Assert.AreEqual("foo", actualFilterExpression.ExpressionAttributeValues[":C0"].AsString());
        }

        [TestMethod]
        public void ConvertScan_WithGreaterThanFilterExpression_ReturnsMappedFilterExpression()
        {
            // Filter: e => e.Id > 10
            Expression<Func<TestEntity, bool>> expr = e => e.Id > 10;
            var filterExpr = new ContextExpression();
            filterExpr.SetFilter(expr);

            var result = context.ConvertScan<TestEntity>(filterExpr, null);

            Assert.IsNotNull(result);
            Assert.IsNotNull(result.Search.FilterExpression);
            var actualFilterExpression = result.Search.FilterExpression;
            Assert.AreEqual("#C0 > :C0", actualFilterExpression.ExpressionStatement);
            Assert.IsNotNull(actualFilterExpression.ExpressionAttributeNames);
            Assert.IsTrue(actualFilterExpression.ExpressionAttributeNames.ContainsKey("#C0"));
            Assert.AreEqual("Id", actualFilterExpression.ExpressionAttributeNames["#C0"]);
            Assert.IsNotNull(actualFilterExpression.ExpressionAttributeValues);
            Assert.IsTrue(actualFilterExpression.ExpressionAttributeValues.ContainsKey(":C0"));
            Assert.AreEqual(10, actualFilterExpression.ExpressionAttributeValues[":C0"].AsInt());
        }

        [TestMethod]
        public void ConvertScan_WithAndFilterExpression_ReturnsMappedFilterExpression()
        {
            // Filter: e => e.Id == 1 && e.Name == "foo"
            Expression<Func<TestEntity, bool>> expr = e => e.Id == 1 && e.Name == "foo";
            var filterExpr = new ContextExpression();
            filterExpr.SetFilter(expr);

            var result = context.ConvertScan<TestEntity>(filterExpr, null);

            Assert.IsNotNull(result);
            Assert.IsNotNull(result.Search.FilterExpression);
            var actualFilterExpression = result.Search.FilterExpression;
            Assert.AreEqual("(#C0 = :C0) AND (#C1 = :C1)", actualFilterExpression.ExpressionStatement);
            Assert.IsNotNull(actualFilterExpression.ExpressionAttributeNames);
            Assert.AreEqual("Id", actualFilterExpression.ExpressionAttributeNames["#C0"]);
            Assert.AreEqual("Name", actualFilterExpression.ExpressionAttributeNames["#C1"]);
            Assert.IsNotNull(actualFilterExpression.ExpressionAttributeValues);
            Assert.AreEqual(1, actualFilterExpression.ExpressionAttributeValues[":C0"].AsInt());
            Assert.AreEqual("foo", actualFilterExpression.ExpressionAttributeValues[":C1"].AsString());
        }

        [TestMethod]
        public void ConvertQueryByValue_WithHashKeyOnly()
        {
            // Act
            var result = context.ConvertQueryByValue<TestEntity>(1, null, null);

            // Assert
            Assert.IsNotNull(result);
            Assert.IsNotNull(result.Search);
            var actualResult = result.Search;
            Assert.IsNotNull(actualResult.Filter);
            Assert.AreEqual(1,actualResult.Filter.ToConditions().Count);
            Assert.IsNull(actualResult.FilterExpression);
            Assert.IsNotNull(actualResult.AttributesToGet);
            Assert.AreEqual(2,actualResult.AttributesToGet.Count);
        }

        [TestMethod]
        public void ConvertQueryByValue_WithHashKeyAndExpressionFilter()
        {
            // Arrange
            Expression<Func<TestEntity, bool>> expr = e => e.Name == "bar";
            var filterExpr = new ContextExpression();
            filterExpr.SetFilter(expr);

            var operationConfig = new DynamoDBOperationConfig
            {
                Expression = filterExpr
            };

            // Act
            var result = context.ConvertQueryByValue<TestEntity>(1, null, operationConfig);

            // Assert
            Assert.IsNotNull(result);

            var search = (dynamic)result;
            Assert.IsNotNull(search.Search);
            Assert.IsNotNull(search.Search.KeyExpression);
            Assert.IsNotNull(search.Search.KeyExpression.ExpressionStatement);
            Assert.IsTrue(search.Search.KeyExpression.ExpressionStatement.Contains("#hashKey = :hashKey"));
            Assert.IsNotNull(search.Search.KeyExpression.ExpressionAttributeNames);
            Assert.IsTrue(search.Search.KeyExpression.ExpressionAttributeNames.ContainsKey("#hashKey"));
            Assert.IsNotNull(search.Search.KeyExpression.ExpressionAttributeValues);
            Assert.IsTrue(search.Search.KeyExpression.ExpressionAttributeValues.ContainsKey(":hashKey"));
            var keyValue = search.Search.KeyExpression.ExpressionAttributeValues[":hashKey"];
            Assert.AreEqual(1, keyValue.AsInt());

            // Assert filter expression
            Assert.IsNotNull(search.Search.FilterExpression);
            Assert.AreEqual("#C0 = :C0", search.Search.FilterExpression.ExpressionStatement);
            Assert.AreEqual("Name", search.Search.FilterExpression.ExpressionAttributeNames["#C0"]);
            Assert.AreEqual("bar", search.Search.FilterExpression.ExpressionAttributeValues[":C0"].ToString());
        }
    }
}