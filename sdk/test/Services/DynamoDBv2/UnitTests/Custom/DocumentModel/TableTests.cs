using System.Collections.Generic;
using Amazon;
using Amazon.DynamoDBv2;
using Amazon.DynamoDBv2.DocumentModel;
using Amazon.DynamoDBv2.Model;
using Amazon.Runtime;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;

namespace AWSSDK_DotNet.UnitTests
{
    [TestClass]
    public class TableTests
    {

        private Mock<IAmazonDynamoDB> _ddbClientMock;
        private Table _table;
        private string _tableName = "TestTable";

        [TestInitialize]
        public void Setup()
        {
            _ddbClientMock = new Mock<IAmazonDynamoDB>(MockBehavior.Strict);
            // Mock IClientConfig
            var clientConfigMock = new Mock<IClientConfig>();
            // Setup any properties/methods you expect to be used, e.g.:
            clientConfigMock.SetupGet(c => c.RegionEndpoint).Returns((RegionEndpoint)null);
            clientConfigMock.SetupGet(c => c.ServiceURL).Returns((string)null);
            // Add more setups as needed for your tests

            // Setup the Config property on the IAmazonDynamoDB mock
            _ddbClientMock.SetupGet(c => c.Config).Returns(clientConfigMock.Object);

            var config = new TableConfig(_tableName);

            _table = new Table(_ddbClientMock.Object, config);
            _table.ClearTableData();
            _table.Keys.Add("Id", new KeyDescription { IsHash = true, Type = DynamoDBEntryType.String });
            _table.HashKeys.Add("Id");
        }

        [TestMethod]
        public void UpdateHelper_StandardUpdate_SendsCorrectRequest()
        {
            // Arrange
            var doc = new Document { ["Id"] = "1", ["Name"] = "Test" };
            var key = new Key { ["Id"] = new AttributeValue { S = "1" } };
            var config = new UpdateItemOperationConfig();

            _ddbClientMock
                .Setup(c => c.UpdateItem(It.Is<UpdateItemRequest>(r =>
                    r.TableName == _tableName &&
                    r.Key.ContainsKey("Id") &&
                    r.AttributeUpdates != null &&
                    r.AttributeUpdates.ContainsKey("Name") &&
                    r.UpdateExpression == null
                )
                ))
                .Returns(new UpdateItemResponse { Attributes = new Dictionary<string, AttributeValue>() });

            // Act
            var result = _table.UpdateHelper(doc, key, config, null);

            // Assert
            Assert.IsNull(result);
            _ddbClientMock.VerifyAll();
        }

        [TestMethod]
        public void UpdateHelper_WithExpression_SetsUpdateExpression()
        {
            // Arrange
            var doc = new Document { ["Id"] = "1", ["Count"] = 5 };
            var key = new Key { ["Id"] = new AttributeValue { S = "1" } };
            var config = new UpdateItemOperationConfig();
            var expression = new Expression
            {
                ExpressionStatement = "SET #C = if_not_exists(#C, :zero) + :inc",
                ExpressionAttributeNames = new Dictionary<string, string> { { "#C", "Count" } },
                ExpressionAttributeValues = new Dictionary<string, DynamoDBEntry>
                {
                    { ":zero", 0 },
                    { ":inc", 1 }
                }
            };

            _ddbClientMock
                .Setup(c => c.UpdateItem(It.Is<UpdateItemRequest>
                (r =>
                    r.UpdateExpression != null &&
                    r.UpdateExpression.Contains("if_not_exists")
                    && r.ExpressionAttributeNames.ContainsKey("#C") &&
                    r.ExpressionAttributeValues.ContainsKey(":zero")
                )
                ))
                .Returns(new UpdateItemResponse { Attributes = new Dictionary<string, AttributeValue>() });

            // Act
            var result = _table.UpdateHelper(doc, key, config, expression);

            // Assert
            Assert.IsNull(result);
            _ddbClientMock.VerifyAll();
        }

        [TestMethod]
        public void UpdateHelper_WithIfNotExistAttributeNames_SetsUpdateExpression()
        {
            // Arrange
            var doc = new Document { ["Id"] = "1", ["Score"] = 10 };
            var key = new Key { ["Id"] = new AttributeValue { S = "1" } };
            var config = new UpdateItemOperationConfig();
            var ifNotExistAttrs = new List<string> { "Score" };

            _ddbClientMock
                .Setup(c => c.UpdateItem(It.Is<UpdateItemRequest>(r =>
                    r.UpdateExpression != null &&
                    r.UpdateExpression.Contains("if_not_exists")
                )))
                .Returns(new UpdateItemResponse { Attributes = new Dictionary<string, AttributeValue>() });

            // Act
            var result = _table.UpdateHelper(doc, key, config, null, ifNotExistAttrs);

            // Assert
            Assert.IsNull(result);
            _ddbClientMock.VerifyAll();
        }

        [TestMethod]
        public void UpdateHelper_WithExpressionAndIfNotExistAttributeNames_SetsUpdateExpression()
        {
            // Arrange
            var doc = new Document { ["Id"] = "1", ["Score"] = 10 };
            var key = new Key { ["Id"] = new AttributeValue { S = "1" } };
            var config = new UpdateItemOperationConfig();
            var expression = new Expression
            {
                ExpressionStatement = "SET #S = if_not_exists(#S, :zero) + :val",
                ExpressionAttributeNames = new Dictionary<string, string> { { "#S", "Score" } },
                ExpressionAttributeValues = new Dictionary<string, DynamoDBEntry>
                {
                    { ":zero", 0 },
                    { ":val", 10 }
                }
            };
            var ifNotExistAttrs = new List<string> { "Score" };

            _ddbClientMock
                .Setup(c => c.UpdateItem(It.Is<UpdateItemRequest>(r =>
                    r.UpdateExpression != null &&
                    r.UpdateExpression.Contains("if_not_exists") &&
                    r.ExpressionAttributeNames.ContainsKey("#S")
                )))
                .Returns(new UpdateItemResponse { Attributes = new Dictionary<string, AttributeValue>() });

            // Act
            var result = _table.UpdateHelper(doc, key, config, expression, ifNotExistAttrs);

            // Assert
            Assert.IsNull(result);
            _ddbClientMock.VerifyAll();
        }

        [TestMethod]
        public void UpdateHelper_KeysChanged_UpdatesAllAttributes()
        {
            // Arrange
            var doc = new Document { ["Id"] = "2", ["Name"] = "Changed" };
            var key = new Key { ["Id"] = new AttributeValue { S = "1" } };
            var config = new UpdateItemOperationConfig();

            // Simulate key change
            _table.HashKeys.Clear();
            _table.HashKeys.Add("Id");
            _table.Keys["Id"] = new KeyDescription { IsHash = true, Type = DynamoDBEntryType.String };

            _ddbClientMock
                .Setup(c => c.UpdateItem(It.Is<UpdateItemRequest>(r =>
                    r.Key["Id"].S == "1"
                )))
                .Returns(new UpdateItemResponse { Attributes = new Dictionary<string, AttributeValue>() });

            // Act
            var result = _table.UpdateHelper(doc, key, config, null);

            // Assert
            Assert.IsNull(result);
            _ddbClientMock.VerifyAll();
        }

        [TestMethod]
        public void UpdateHelper_WithExpected_SetsExpectedOnRequest()
        {
            // Arrange
            var doc = new Document { ["Id"] = "1", ["Status"] = "Active" };
            var key = new Key { ["Id"] = new AttributeValue { S = "1" } };
            var config = new UpdateItemOperationConfig
            {
                Expected = new Document { ["Status"] = "Active" }
            };

            _ddbClientMock
                .Setup(c => c.UpdateItem(It.Is<UpdateItemRequest>(r =>
                    r.Expected != null && r.Expected.ContainsKey("Status")
                )))
                .Returns(new UpdateItemResponse { Attributes = new Dictionary<string, AttributeValue>() });

            // Act
            var result = _table.UpdateHelper(doc, key, config, null);

            // Assert
            Assert.IsNull(result);
            _ddbClientMock.VerifyAll();
        }

        [TestMethod]
        public void UpdateHelper_WithExpectedState_SetsExpectedOnRequest()
        {
            // Arrange
            var doc = new Document { ["Id"] = "1", ["Status"] = "Active" };
            var key = new Key { ["Id"] = new AttributeValue { S = "1" } };
            var expectedState = new ExpectedState();
            expectedState.ExpectedValues.Add("Status", new ExpectedValue(true));
            var config = new UpdateItemOperationConfig
            {
                ExpectedState = expectedState
            };

            _ddbClientMock
                .Setup(c => c.UpdateItem(It.Is<UpdateItemRequest>(r =>
                    r.Expected != null && r.Expected.ContainsKey("Status")
                )))
                .Returns(new UpdateItemResponse { Attributes = new Dictionary<string, AttributeValue>() });

            // Act
            var result = _table.UpdateHelper(doc, key, config, null);

            // Assert
            Assert.IsNull(result);
            _ddbClientMock.VerifyAll();
        }
        
        [TestMethod]
        public void UpdateHelper_NoAttributeChanges_DoesNotSendAttributeUpdates()
        {
            // Arrange
            var doc = new Document { ["Id"] = "1" };
            var key = new Key { ["Id"] = new AttributeValue { S = "1" } };
            var config = new UpdateItemOperationConfig();

            _ddbClientMock
                .Setup(c => c.UpdateItem(It.Is<UpdateItemRequest>(r =>
                    r.AttributeUpdates == null
                )))
                .Returns(new UpdateItemResponse { Attributes = new Dictionary<string, AttributeValue>() });

            // Act
            var result = _table.UpdateHelper(doc, key, config, null);

            // Assert
            Assert.IsNull(result);
            _ddbClientMock.VerifyAll();
        }
    }
}