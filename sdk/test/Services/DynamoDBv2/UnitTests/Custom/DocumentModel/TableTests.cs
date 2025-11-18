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
            clientConfigMock.SetupGet(c => c.RegionEndpoint).Returns((RegionEndpoint)null);
            clientConfigMock.SetupGet(c => c.ServiceURL).Returns((string)null);

            _ddbClientMock.SetupGet(c => c.Config).Returns(clientConfigMock.Object);

            var config = new TableConfig(_tableName);

            _table = new Table(_ddbClientMock.Object, config);
            _table.ClearTableData();
            _table.Keys.Add("Id", new KeyDescription { IsHash = true, Type = DynamoDBEntryType.String });
            _table.HashKeys.Add("Id");
        }

        [TestMethod]
        public void GivenDocument_WhenUpdateHelperCalledWithDefaultUpdateItemOperationConfig_ThenRequestSentWithAttributeUpdates()
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
        public void GivenExpressionProvided_WhenUpdateHelperCalled_ThenUpdateExpressionSet()
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
                        r.UpdateExpression == "SET #C = if_not_exists(#C, :zero) + :inc "
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
        public void GivenIfNotExistsAttributesProvided_WhenUpdateHelperCalled_ThenUpdateExpressionContainsIfNotExists()
        {
            // Arrange
            var doc = new Document { ["Id"] = "1", ["Score"] = 10 };
            var key = new Key { ["Id"] = new AttributeValue { S = "1" } };
            var config = new UpdateItemOperationConfig();
            var ifNotExistAttrs = new HashSet<string> { "Score" };

            _ddbClientMock
                .Setup(c => c.UpdateItem(It.Is<UpdateItemRequest>(r =>
                    r.UpdateExpression != null &&
                    r.UpdateExpression.Equals("SET #awsavar1 = if_not_exists(#awsavar1, :awsavar1) ")
                )))
                .Returns(new UpdateItemResponse { Attributes = new Dictionary<string, AttributeValue>() });

            // Act
            var result = _table.UpdateHelper(doc, key, config, null, ifNotExistAttrs);

            // Assert
            Assert.IsNull(result);
            _ddbClientMock.VerifyAll();
        }

        [TestMethod]
        public void GivenExpressionAndIfNotExistsAttributes_WhenUpdateHelperCalled_ThenUpdateExpressionContainsIfNotExists()
        {
            // Arrange
            var doc = new Document { ["Id"] = "1", ["Test"] = 10 };
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
            var ifNotExistAttrs = new HashSet<string> { "Test" };

            _ddbClientMock
                .Setup(c => c.UpdateItem(It.Is<UpdateItemRequest>(r =>
                    r.UpdateExpression != null &&
                    r.UpdateExpression.Equals("SET #S = if_not_exists(#S, :zero) + :val, #awsavar1 = if_not_exists(#awsavar1, :awsavar1) ") &&
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
        public void GivenChangedKeys_WhenUpdateHelperCalled_ThenAllAttributesUpdated()
        {
            // Arrange
            var doc = new Document { ["Id"] = "2", ["Name"] = "Changed" };
            doc.CommitChanges();
            var key = new Key { ["Id"] = new AttributeValue { S = "1" } };
            var config = new UpdateItemOperationConfig();
            doc["Id"] = "1";

            _ddbClientMock
                .Setup(c => c.UpdateItem(It.Is<UpdateItemRequest>(r =>
                    r.Key["Id"].S == "1" &&
                    r.AttributeUpdates!=null &&
                    r.AttributeUpdates.ContainsKey("Name")
                )))
                .Returns(new UpdateItemResponse { Attributes = new Dictionary<string, AttributeValue>() });

            // Act
            var result = _table.UpdateHelper(doc, key, config, null);

            // Assert
            Assert.IsNull(result);
            _ddbClientMock.VerifyAll();
        }

        [TestMethod]
        public void GivenExpectedDocument_WhenUpdateHelperCalled_ThenExpectedAddedToRequest()
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
        public void GivenExpectedState_WhenUpdateHelperCalled_ThenExpectedAddedToRequest()
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
        public void GivenNoAttributeChanges_WhenUpdateHelperCalled_ThenNoAttributeUpdatesSent()
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