using Amazon;
using Amazon.DynamoDBv2;
using Amazon.DynamoDBv2.DocumentModel;
using Amazon.DynamoDBv2.Model;
using Amazon.Runtime;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;
using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;

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

        #region Helpers

        private Task<Document> InvokeUpdateAsync(UpdateItemDocumentOperationRequest request)
            => _table.UpdateHelperAsync(request, CancellationToken.None);

        private Document InvokeUpdateSync(UpdateItemDocumentOperationRequest request)
            => _table.UpdateHelper(request);
        private Task<Document> InvokeDeleteAsync(DeleteItemDocumentOperationRequest request)
            => _table.DeleteHelperAsync(request, CancellationToken.None);

        private Document InvokeDeleteSync(DeleteItemDocumentOperationRequest request)
            => _table.DeleteHelper(request);

        private Task<Document> InvokePutAsync(PutItemDocumentOperationRequest request)
            => _table.PutItemAsync(request, CancellationToken.None);

        private Document InvokePutSync(PutItemDocumentOperationRequest request)
            => _table.PutItem(request);

        private Task<Document> InvokeGetAsync(GetItemDocumentOperationRequest request)
            => _table.GetItemAsync(request, CancellationToken.None);

        private Document InvokeGetSync(GetItemDocumentOperationRequest request)
            => _table.GetItem(request);

        private async Task AssertThrowsAsync<T>(Func<Task> act, string expectedMessage = null) where T : Exception
        {
            var ex = await Assert.ThrowsExceptionAsync<T>(act);
            if (expectedMessage != null)
                Assert.AreEqual(expectedMessage, ex.Message);
        }

        private void AssertThrowsSync<T>(Action act, string expectedMessage = null) where T : Exception
        {
            var ex = Assert.ThrowsException<T>(act);
            if (expectedMessage != null)
                Assert.AreEqual(expectedMessage, ex.Message);
        }

        #endregion

        #region UpdateHelper Tests 

        [DataTestMethod]
        [DataRow(true)]
        [DataRow(false)]
        public async Task UpdateHelper_RequestNull_ThrowsArgumentNullException(bool isAsync)
        {
            if (isAsync)
                await AssertThrowsAsync<ArgumentNullException>(() => InvokeUpdateAsync(null));
            else
                AssertThrowsSync<ArgumentNullException>(() => InvokeUpdateSync(null));
        }

        [DataTestMethod]
        [DataRow(null, null, "Either Document or UpdateExpression must be set (exclusively).", true)]
        [DataRow("doc", "expr", "Either Document or UpdateExpression must be set (exclusively).", true)]
        [DataRow(null, null, "Either Document or UpdateExpression must be set (exclusively).", false)]
        [DataRow("doc", "expr", "Either Document or UpdateExpression must be set (exclusively).", false)]
        public async Task UpdateHelper_RequestInvalidDocExprCombination_ThrowsInvalidOperationException(object docObj, object exprObj, string expectedMessage, bool isAsync)
        {
            Document doc = docObj as Document;
            Expression expr = exprObj as Expression;

            if (docObj is string && (string)docObj == "doc")
                doc = new Document { ["Id"] = "1", ["Count"] = 5 };
            if (exprObj is string && (string)exprObj == "expr")
                expr = new Expression { ExpressionStatement = "test" };

            var request = new UpdateItemDocumentOperationRequest
            {
                Document = doc,
                UpdateExpression = expr
            };

            if (isAsync)
                await AssertThrowsAsync<InvalidOperationException>(() => InvokeUpdateAsync(request), expectedMessage);
            else
                AssertThrowsSync<InvalidOperationException>(() => InvokeUpdateSync(request), expectedMessage);
        }

        [DataTestMethod]
        [DataRow(true)]
        [DataRow(false)]
        public async Task UpdateHelper_KeyMissing_ThrowsInvalidOperationException(bool isAsync)
        {
            var request = new UpdateItemDocumentOperationRequest
            {
                UpdateExpression = new Expression { ExpressionStatement = "test" },
                Key = null
            };
            _table.HashKeys.Clear();
            _table.Keys.Clear();

            if (isAsync)
                await AssertThrowsAsync<InvalidOperationException>(() => InvokeUpdateAsync(request));
            else
                AssertThrowsSync<InvalidOperationException>(() => InvokeUpdateSync(request));
        }

        [DataTestMethod]
        [DataRow(true)]
        [DataRow(false)]
        public async Task UpdateHelper_ReturnsDocument_WhenReturnValuesNotNone(bool isAsync)
        {
            var docMock = new Document { ["Id"] = "1", ["Count"] = 5 };

            var request = new UpdateItemDocumentOperationRequest
            {
                Document = docMock,
                UpdateExpression = null,
                Key = new Dictionary<string, DynamoDBEntry> { { "Id", new Primitive("abc") } },
                ReturnValues = ReturnValues.AllOldAttributes
            };

            var updateItemResponse = new UpdateItemResponse
            {
                Attributes = new Dictionary<string, AttributeValue> { { "Id", new AttributeValue { S = "abc" } } }
            };

            if (isAsync)
                _ddbClientMock.Setup(c => c.UpdateItemAsync(It.IsAny<UpdateItemRequest>(), It.IsAny<CancellationToken>()))
                    .ReturnsAsync(updateItemResponse);
            else
                _ddbClientMock.Setup(c => c.UpdateItem(It.IsAny<UpdateItemRequest>()))
                    .Returns(updateItemResponse);

            var result = isAsync
                ? await InvokeUpdateAsync(request)
                : InvokeUpdateSync(request);

            Assert.IsNotNull(result);
        }

        [DataTestMethod]
        [DataRow(true)]
        [DataRow(false)]
        public async Task UpdateHelper_SetsUpdateExpression_WhenDocumentProvided(bool isAsync)
        {
            var doc = new Document { ["Id"] = "1", ["Count"] = 5 };

            var request = new UpdateItemDocumentOperationRequest
            {
                Document = doc,
                UpdateExpression = null,
                Key = null,
                ReturnValues = ReturnValues.AllNewAttributes
            };

            var updateItemResponse = new UpdateItemResponse
            {
                Attributes = new Dictionary<string, AttributeValue> { { "Id", new AttributeValue { S = "1" } }, { "Count", new AttributeValue { N = "5" } } }
            };

            if (isAsync)
            {
                _ddbClientMock.Setup(c => c.UpdateItemAsync(
                        It.Is<UpdateItemRequest>(r => r.Key.ContainsKey("Id")
                            && r.UpdateExpression != null
                            && r.ExpressionAttributeValues != null
                            && r.ExpressionAttributeNames != null), It.IsAny<CancellationToken>()))
                    .ReturnsAsync(updateItemResponse)
                    .Verifiable();
            }
            else
            {
                _ddbClientMock.Setup(c => c.UpdateItem(
                        It.Is<UpdateItemRequest>(r => r.Key.ContainsKey("Id")
                            && r.UpdateExpression != null
                            && r.ExpressionAttributeValues != null
                            && r.ExpressionAttributeNames != null)))
                    .Returns(updateItemResponse)
                    .Verifiable();
            }

            var result = isAsync ? await InvokeUpdateAsync(request) : InvokeUpdateSync(request);

            Assert.IsNotNull(result);

            if (isAsync)
                _ddbClientMock.Verify(c => c.UpdateItemAsync(
                    It.Is<UpdateItemRequest>(r => r.UpdateExpression != null
                        && r.ExpressionAttributeValues != null
                        && r.ExpressionAttributeNames != null),
                    It.IsAny<CancellationToken>()), Times.Once);
            else
                _ddbClientMock.Verify(c => c.UpdateItem(
                    It.Is<UpdateItemRequest>(r => r.UpdateExpression != null
                        && r.ExpressionAttributeValues != null
                        && r.ExpressionAttributeNames != null)), Times.Once);
        }

        [DataTestMethod]
        [DataRow(true)]
        [DataRow(false)]
        public async Task UpdateHelper_UsesOnlyChangedAttributes_WhenKeysUnchanged(bool isAsync)
        {
            var doc = new Document { ["Id"] = "1", ["Count"] = 5, ["Prop"] = "test" };
            doc.CommitChanges();
            doc["Count"] = 10;
            doc["Prop2"] = "test";

            var request = new UpdateItemDocumentOperationRequest
            {
                Document = doc,
                UpdateExpression = null,
                Key = null,
                ReturnValues = ReturnValues.AllNewAttributes
            };

            var updateItemResponse = new UpdateItemResponse
            {
                Attributes = new Dictionary<string, AttributeValue>
                { { "Id", new AttributeValue { S = "1" } }, { "Count", new AttributeValue { N = "5" } } }
            };

            Predicate<UpdateItemRequest> predicate = r =>
                r.Key.ContainsKey("Id")
                && r.UpdateExpression != null
                && r.ExpressionAttributeValues.Count == 2
                && r.ExpressionAttributeNames.ContainsValue("Count")
                && r.ExpressionAttributeNames.ContainsValue("Prop2")
                && !r.ExpressionAttributeNames.ContainsValue("Prop");

            if (isAsync)
                _ddbClientMock.Setup(c => c.UpdateItemAsync(It.Is<UpdateItemRequest>(r => predicate(r)), It.IsAny<CancellationToken>()))
                    .ReturnsAsync(updateItemResponse)
                    .Verifiable();
            else
                _ddbClientMock.Setup(c => c.UpdateItem(It.Is<UpdateItemRequest>(r => predicate(r))))
                    .Returns(updateItemResponse)
                    .Verifiable();

            var result = isAsync ? await InvokeUpdateAsync(request) : InvokeUpdateSync(request);

            Assert.IsNotNull(result);

            if (isAsync)
                _ddbClientMock.Verify(c => c.UpdateItemAsync(It.Is<UpdateItemRequest>(r => predicate(r)), It.IsAny<CancellationToken>()), Times.Once);
            else
                _ddbClientMock.Verify(c => c.UpdateItem(It.Is<UpdateItemRequest>(r => predicate(r))), Times.Once);
        }

        [DataTestMethod]
        [DataRow(true)]
        [DataRow(false)]
        public async Task UpdateHelper_AppliesUpdateExpression(bool isAsync)
        {
            var updateExpr = new Expression()
            {
                ExpressionStatement = "SET #N = :v",
                ExpressionAttributeNames = new Dictionary<string, string> { { "#N", "test" } },
                ExpressionAttributeValues = new Dictionary<string, DynamoDBEntry> { { ":v", "test" } },
            };
            var request = new UpdateItemDocumentOperationRequest
            {
                Document = null,
                UpdateExpression = updateExpr,
                ConditionalExpression = null,
                Key = new Dictionary<string, DynamoDBEntry> { { "Id", new Primitive("abc") } }
            };

            Predicate<UpdateItemRequest> predicate = r =>
                r.Key.ContainsKey("Id")
                && r.UpdateExpression == "SET #N = :v"
                && r.ExpressionAttributeValues.Count == 1;

            if (isAsync)
                _ddbClientMock.Setup(c => c.UpdateItemAsync(It.Is<UpdateItemRequest>(r => predicate(r)), It.IsAny<CancellationToken>()))
                    .ReturnsAsync(new UpdateItemResponse());
            else
                _ddbClientMock.Setup(c => c.UpdateItem(It.Is<UpdateItemRequest>(r => predicate(r))))
                    .Returns(new UpdateItemResponse());

            if (isAsync)
                await InvokeUpdateAsync(request);
            else
                InvokeUpdateSync(request);

            if (isAsync)
                _ddbClientMock.Verify(c => c.UpdateItemAsync(It.Is<UpdateItemRequest>(r => predicate(r)), It.IsAny<CancellationToken>()), Times.Once);
            else
                _ddbClientMock.Verify(c => c.UpdateItem(It.Is<UpdateItemRequest>(r => predicate(r))), Times.Once);
        }

        [DataTestMethod]
        [DataRow(true)]
        [DataRow(false)]
        public async Task UpdateHelper_AppliesConditionalExpression(bool isAsync)
        {
            var condExpr = new Expression()
            {
                ExpressionStatement = "#N = :v",
                ExpressionAttributeNames = new Dictionary<string, string> { { "#N", "test" } },
                ExpressionAttributeValues = new Dictionary<string, DynamoDBEntry> { { ":v", "test" } },
            };
            var doc = new Document { ["Id"] = "1", ["Count"] = 5, ["Prop"] = "test" };
            var request = new UpdateItemDocumentOperationRequest
            {
                Document = doc,
                UpdateExpression = null,
                ConditionalExpression = condExpr,
                Key = new Dictionary<string, DynamoDBEntry> { { "Id", new Primitive("abc") } }
            };

            Predicate<UpdateItemRequest> predicate = r =>
                r.Key.ContainsKey("Id")
                && r.ConditionExpression == "#N = :v"
                && r.ExpressionAttributeValues.Count == 3; // :v + converted Count + Prop

            if (isAsync)
                _ddbClientMock.Setup(c => c.UpdateItemAsync(It.Is<UpdateItemRequest>(r => predicate(r)), It.IsAny<CancellationToken>()))
                    .ReturnsAsync(new UpdateItemResponse());
            else
                _ddbClientMock.Setup(c => c.UpdateItem(It.Is<UpdateItemRequest>(r => predicate(r))))
                    .Returns(new UpdateItemResponse());

            if (isAsync)
                await InvokeUpdateAsync(request);
            else
                InvokeUpdateSync(request);

            if (isAsync)
                _ddbClientMock.Verify(c => c.UpdateItemAsync(It.Is<UpdateItemRequest>(r => predicate(r)), It.IsAny<CancellationToken>()), Times.Once);
            else
                _ddbClientMock.Verify(c => c.UpdateItem(It.Is<UpdateItemRequest>(r => predicate(r))), Times.Once);
        }

        [DataTestMethod]
        [DataRow(true)]
        [DataRow(false)]
        public async Task UpdateHelper_AppliesBothExpressions(bool isAsync)
        {
            var updateExpr = new Expression()
            {
                ExpressionStatement = "SET #Nu = :vu",
                ExpressionAttributeNames = new Dictionary<string, string> { { "#Nu", "test" } },
                ExpressionAttributeValues = new Dictionary<string, DynamoDBEntry> { { ":vu", "test" } },
            };
            var condExpr = new Expression()
            {
                ExpressionStatement = "#Nc = :vc",
                ExpressionAttributeNames = new Dictionary<string, string> { { "#Nc", "test" } },
                ExpressionAttributeValues = new Dictionary<string, DynamoDBEntry> { { ":vc", "test" } },
            };
            var request = new UpdateItemDocumentOperationRequest
            {
                Document = null,
                UpdateExpression = updateExpr,
                ConditionalExpression = condExpr,
                Key = new Dictionary<string, DynamoDBEntry> { { "Id", new Primitive("abc") } }
            };

            Predicate<UpdateItemRequest> predicate = r =>
                r.Key.ContainsKey("Id")
                && r.ConditionExpression == "#Nc = :vc"
                && r.UpdateExpression == "SET #Nu = :vu"
                && r.ExpressionAttributeValues.Count == 2;

            if (isAsync)
                _ddbClientMock.Setup(c => c.UpdateItemAsync(It.Is<UpdateItemRequest>(r => predicate(r)), It.IsAny<CancellationToken>()))
                    .ReturnsAsync(new UpdateItemResponse());
            else
                _ddbClientMock.Setup(c => c.UpdateItem(It.Is<UpdateItemRequest>(r => predicate(r))))
                    .Returns(new UpdateItemResponse());

            if (isAsync)
                await InvokeUpdateAsync(request);
            else
                InvokeUpdateSync(request);

            if (isAsync)
                _ddbClientMock.Verify(c => c.UpdateItemAsync(It.Is<UpdateItemRequest>(r => predicate(r)), It.IsAny<CancellationToken>()), Times.Once);
            else
                _ddbClientMock.Verify(c => c.UpdateItem(It.Is<UpdateItemRequest>(r => predicate(r))), Times.Once);
        }

        #endregion

        #region DeleteHelper Tests 

        [DataTestMethod]
        [DataRow(true)]
        [DataRow(false)]
        public async Task DeleteHelper_RequestNull_ThrowsArgumentNullException(bool isAsync)
        {
            if (isAsync)
                await AssertThrowsAsync<ArgumentNullException>(() => InvokeDeleteAsync(null));
            else
                AssertThrowsSync<ArgumentNullException>(() => InvokeDeleteSync(null));
        }

        [DataTestMethod]
        [DataRow(true)]
        [DataRow(false)]
        public async Task DeleteHelper_ReturnsDocument_WhenReturnValuesAllOldAttributes(bool isAsync)
        {
            var request = new DeleteItemDocumentOperationRequest
            {
                Key = new Dictionary<string, DynamoDBEntry> { { "Id", new Primitive("abc") } },
                ReturnValues = ReturnValues.AllOldAttributes
            };

            var deleteResponse = new DeleteItemResponse
            {
                Attributes = new Dictionary<string, AttributeValue> { { "Id", new AttributeValue { S = "abc" } } }
            };

            if (isAsync)
                _ddbClientMock.Setup(c => c.DeleteItemAsync(It.IsAny<DeleteItemRequest>(), It.IsAny<CancellationToken>()))
                    .ReturnsAsync(deleteResponse);
            else
                _ddbClientMock.Setup(c => c.DeleteItem(It.IsAny<DeleteItemRequest>()))
                    .Returns(deleteResponse);

            var result = isAsync ? await InvokeDeleteAsync(request) : InvokeDeleteSync(request);

            Assert.IsNotNull(result);
        }

        [DataTestMethod]
        [DataRow(true)]
        [DataRow(false)]
        public async Task DeleteHelper_ReturnsNull_WhenReturnValuesNone(bool isAsync)
        {
            var request = new DeleteItemDocumentOperationRequest
            {
                Key = new Dictionary<string, DynamoDBEntry> { { "Id", new Primitive("xyz") } },
                ReturnValues = ReturnValues.None
            };

            var deleteResponse = new DeleteItemResponse
            {
                Attributes = new Dictionary<string, AttributeValue> { { "Id", new AttributeValue { S = "xyz" } } }
            };

            if (isAsync)
                _ddbClientMock.Setup(c => c.DeleteItemAsync(It.IsAny<DeleteItemRequest>(), It.IsAny<CancellationToken>()))
                    .ReturnsAsync(deleteResponse);
            else
                _ddbClientMock.Setup(c => c.DeleteItem(It.IsAny<DeleteItemRequest>()))
                    .Returns(deleteResponse);

            var result = isAsync ? await InvokeDeleteAsync(request) : InvokeDeleteSync(request);

            Assert.IsNull(result);
        }

        [DataTestMethod]
        [DataRow(true)]
        [DataRow(false)]
        public async Task DeleteHelper_AppliesConditionalExpression(bool isAsync)
        {
            var condExpr = new Expression
            {
                ExpressionStatement = "#A = :v",
                ExpressionAttributeNames = new Dictionary<string, string> { { "#A", "Attr" } },
                ExpressionAttributeValues = new Dictionary<string, DynamoDBEntry> { { ":v", "val" } }
            };

            var request = new DeleteItemDocumentOperationRequest
            {
                Key = new Dictionary<string, DynamoDBEntry> { { "Id", new Primitive("abc") } },
                ConditionalExpression = condExpr,
                ReturnValues = ReturnValues.None
            };

            Predicate<DeleteItemRequest> predicate = r =>
                r.Key.ContainsKey("Id")
                && r.ConditionExpression == "#A = :v"
                && r.ExpressionAttributeValues.Count == 1;

            var deleteResponse = new DeleteItemResponse();

            if (isAsync)
                _ddbClientMock.Setup(c => c.DeleteItemAsync(It.Is<DeleteItemRequest>(r => predicate(r)), It.IsAny<CancellationToken>()))
                    .ReturnsAsync(deleteResponse)
                    .Verifiable();
            else
                _ddbClientMock.Setup(c => c.DeleteItem(It.Is<DeleteItemRequest>(r => predicate(r))))
                    .Returns(deleteResponse)
                    .Verifiable();

            var result = isAsync ? await InvokeDeleteAsync(request) : InvokeDeleteSync(request);

            Assert.IsNull(result); // ReturnValues.None

            if (isAsync)
                _ddbClientMock.Verify(c => c.DeleteItemAsync(It.Is<DeleteItemRequest>(r => predicate(r)), It.IsAny<CancellationToken>()), Times.Once);
            else
                _ddbClientMock.Verify(c => c.DeleteItem(It.Is<DeleteItemRequest>(r => predicate(r))), Times.Once);
        }

        [DataTestMethod]
        [DataRow(true)]
        [DataRow(false)]
        public async Task DeleteHelper_AppliesConditionalExpression_WithAllOldAttributes(bool isAsync)
        {
            var condExpr = new Expression
            {
                ExpressionStatement = "#A = :v",
                ExpressionAttributeNames = new Dictionary<string, string> { { "#A", "Attr" } },
                ExpressionAttributeValues = new Dictionary<string, DynamoDBEntry> { { ":v", "val" } }
            };

            var request = new DeleteItemDocumentOperationRequest
            {
                Key = new Dictionary<string, DynamoDBEntry> { { "Id", new Primitive("abc") } },
                ConditionalExpression = condExpr,
                ReturnValues = ReturnValues.AllOldAttributes
            };

            var deleteResponse = new DeleteItemResponse
            {
                Attributes = new Dictionary<string, AttributeValue>
                {
                    { "Id", new AttributeValue { S = "abc" } },
                    { "Attr", new AttributeValue { S = "val" } }
                }
            };

            Predicate<DeleteItemRequest> predicate = r =>
                r.Key.ContainsKey("Id")
                && r.ConditionExpression == "#A = :v"
                && r.ExpressionAttributeValues.Count == 1;

            if (isAsync)
                _ddbClientMock.Setup(c => c.DeleteItemAsync(It.Is<DeleteItemRequest>(r => predicate(r)), It.IsAny<CancellationToken>()))
                    .ReturnsAsync(deleteResponse)
                    .Verifiable();
            else
                _ddbClientMock.Setup(c => c.DeleteItem(It.Is<DeleteItemRequest>(r => predicate(r))))
                    .Returns(deleteResponse)
                    .Verifiable();

            var result = isAsync ? await InvokeDeleteAsync(request) : InvokeDeleteSync(request);

            Assert.IsNotNull(result);
            Assert.AreEqual("abc", result["Id"].AsPrimitive().Value);

            if (isAsync)
                _ddbClientMock.Verify(c => c.DeleteItemAsync(It.Is<DeleteItemRequest>(r => predicate(r)), It.IsAny<CancellationToken>()), Times.Once);
            else
                _ddbClientMock.Verify(c => c.DeleteItem(It.Is<DeleteItemRequest>(r => predicate(r))), Times.Once);
        }

        [DataTestMethod]
        [DataRow(true, true)]  
        [DataRow(true, false)]  
        [DataRow(false, true)]  
        [DataRow(false, false)] 
        public async Task DeleteHelper_KeyNullOrEmpty_ThrowsInvalidOperationException(bool isAsync, bool keyIsNull)
        {
            var request = new DeleteItemDocumentOperationRequest
            {
                Key = keyIsNull ? null : new Dictionary<string, DynamoDBEntry>(),
                ReturnValues = ReturnValues.None
            };

            const string expectedMessage = "DeleteItemDocumentOperationRequest.Key cannot be null or empty.";

            if (isAsync)
            {
                var ex = await Assert.ThrowsExceptionAsync<InvalidOperationException>(() => InvokeDeleteAsync(request));
                Assert.AreEqual(expectedMessage, ex.Message);
            }
            else
            {
                var ex = Assert.ThrowsException<InvalidOperationException>(() => InvokeDeleteSync(request));
                Assert.AreEqual(expectedMessage, ex.Message);
            }
        }

        #endregion

        #region PutItemHelper Tests

        [DataTestMethod]
        [DataRow(true)]
        [DataRow(false)]
        public async Task PutItemHelper_RequestNull_ThrowsArgumentNullException(bool isAsync)
        {
            if (isAsync)
                await AssertThrowsAsync<ArgumentNullException>(() => InvokePutAsync(null));
            else
                AssertThrowsSync<ArgumentNullException>(() => InvokePutSync(null));
        }

        [DataTestMethod]
        [DataRow(true)]
        [DataRow(false)]
        public async Task PutItemHelper_ReturnsNull_WhenReturnValuesNone(bool isAsync)
        {
            var doc = new Document { ["Id"] = "1", ["Value"] = "A" };
            var request = new PutItemDocumentOperationRequest
            {
                Document = doc,
                ReturnValues = ReturnValues.None
            };

            var putResponse = new PutItemResponse
            {
                Attributes = new Dictionary<string, AttributeValue> { { "Id", new AttributeValue { S = "1" } }, { "Value", new AttributeValue { S = "A" } } }
            };

            if (isAsync)
                _ddbClientMock.Setup(c => c.PutItemAsync(It.IsAny<PutItemRequest>(), It.IsAny<CancellationToken>()))
                    .ReturnsAsync(putResponse);
            else
                _ddbClientMock.Setup(c => c.PutItem(It.IsAny<PutItemRequest>()))
                    .Returns(putResponse);

            var result = isAsync ? await InvokePutAsync(request) : InvokePutSync(request);

            Assert.IsNull(result);
        }

        [DataTestMethod]
        [DataRow(true)]
        [DataRow(false)]
        public async Task PutItemHelper_ReturnsOldAttributes_WhenReturnValuesAllOld(bool isAsync)
        {
            var doc = new Document { ["Id"] = "1", ["Value"] = "A" };
            var request = new PutItemDocumentOperationRequest
            {
                Document = doc,
                ReturnValues = ReturnValues.AllOldAttributes
            };

            var oldAttributes = new Dictionary<string, AttributeValue>
            {
                { "Id", new AttributeValue { S = "1" } },
                { "Value", new AttributeValue { S = "OLD" } }
            };

            var putResponse = new PutItemResponse { Attributes = oldAttributes };

            if (isAsync)
                _ddbClientMock.Setup(c => c.PutItemAsync(It.IsAny<PutItemRequest>(), It.IsAny<CancellationToken>()))
                    .ReturnsAsync(putResponse);
            else
                _ddbClientMock.Setup(c => c.PutItem(It.IsAny<PutItemRequest>()))
                    .Returns(putResponse);

            var result = isAsync ? await InvokePutAsync(request) : InvokePutSync(request);

            Assert.IsNotNull(result);
            Assert.AreEqual("OLD", result["Value"].AsPrimitive().Value);
        }

        [DataTestMethod]
        [DataRow(true)]
        [DataRow(false)]
        public async Task PutItemHelper_CommitsDocumentChanges(bool isAsync)
        {
            var doc = new Document { ["Id"] = "1", ["Value"] = "A" };
            // Initially document has changes
            Assert.IsTrue(doc.IsDirty());

            var request = new PutItemDocumentOperationRequest
            {
                Document = doc,
                ReturnValues = ReturnValues.None
            };

            var putResponse = new PutItemResponse { Attributes = new Dictionary<string, AttributeValue>() };

            if (isAsync)
                _ddbClientMock.Setup(c => c.PutItemAsync(It.IsAny<PutItemRequest>(), It.IsAny<CancellationToken>()))
                    .ReturnsAsync(putResponse);
            else
                _ddbClientMock.Setup(c => c.PutItem(It.IsAny<PutItemRequest>()))
                    .Returns(putResponse);

            if (isAsync)
                await InvokePutAsync(request);
            else
                InvokePutSync(request);

            Assert.IsFalse(doc.IsDirty(), "Document should have committed changes after PutItem.");
        }

        [DataTestMethod]
        [DataRow(true)]
        [DataRow(false)]
        public async Task PutItemHelper_PassesConditionalExpression(bool isAsync)
        {
            var doc = new Document { ["Id"] = "1", ["Value"] = "A" };
            var condExpr = new Expression
            {
                ExpressionStatement = "attribute_not_exists(#PK)",
                ExpressionAttributeNames = new Dictionary<string, string> { { "#PK", "Id" } }
            };

            var request = new PutItemDocumentOperationRequest
            {
                Document = doc,
                ConditionalExpression = condExpr,
                ReturnValues = ReturnValues.None
            };

            Predicate<PutItemRequest> predicate = r =>
                r.Item.ContainsKey("Id") &&
                r.ConditionExpression == "attribute_not_exists(#PK)" &&
                r.ExpressionAttributeNames.ContainsKey("#PK");

            var putResponse = new PutItemResponse();

            if (isAsync)
                _ddbClientMock.Setup(c => c.PutItemAsync(It.Is<PutItemRequest>(r => predicate(r)), It.IsAny<CancellationToken>()))
                    .ReturnsAsync(putResponse);
            else
                _ddbClientMock.Setup(c => c.PutItem(It.Is<PutItemRequest>(r => predicate(r))))
                    .Returns(putResponse);

            if (isAsync)
                await InvokePutAsync(request);
            else
                InvokePutSync(request);

            if (isAsync)
                _ddbClientMock.Verify(c => c.PutItemAsync(It.Is<PutItemRequest>(r => predicate(r)), It.IsAny<CancellationToken>()), Times.Once);
            else
                _ddbClientMock.Verify(c => c.PutItem(It.Is<PutItemRequest>(r => predicate(r))), Times.Once);
        }

        [DataTestMethod]
        [DataRow(true)]
        [DataRow(false)]
        public async Task PutItemHelper_DocumentNull_ThrowsInvalidOperationException(bool isAsync)
        {
            var request = new PutItemDocumentOperationRequest
            {
                Document = null,
                ReturnValues = ReturnValues.None
            };

            const string expectedMessage = "The Document property of the PutItemDocumentOperationRequest cannot be null.";

            if (isAsync)
            {
                var ex = await Assert.ThrowsExceptionAsync<InvalidOperationException>(() => InvokePutAsync(request));
                Assert.AreEqual(expectedMessage, ex.Message);
            }
            else
            {
                var ex = Assert.ThrowsException<InvalidOperationException>(() => InvokePutSync(request));
                Assert.AreEqual(expectedMessage, ex.Message);
            }
        }
        #endregion

        #region GetItemHelper Tests

        [DataTestMethod]
        [DataRow(true)]
        [DataRow(false)]
        public async Task GetItemHelper_RequestNull_ThrowsArgumentNullException(bool isAsync)
        {
            if (isAsync)
            {
                await AssertThrowsAsync<System.ArgumentNullException>(() => InvokeGetAsync(null));
            }
            else
            {
                AssertThrowsSync<System.ArgumentNullException>(() => InvokeGetSync(null));
            }
        }

        [DataTestMethod]
        [DataRow(true, true)]
        [DataRow(true, false)]
        [DataRow(false, true)]
        [DataRow(false, false)]
        public async Task GetItemHelper_KeyNullOrEmpty_ThrowsInvalidOperationException(bool isAsync, bool keyIsNull)
        {
            var request = new GetItemDocumentOperationRequest
            {
                Key = keyIsNull ? null : new Dictionary<string, DynamoDBEntry>(),
                ConsistentRead = false
            };

            const string expectedMessage = "GetItemDocumentOperationRequest.Key cannot be null or empty.";

            if (isAsync)
            {
                var ex = await Assert.ThrowsExceptionAsync<System.InvalidOperationException>(() => InvokeGetAsync(request));
                Assert.AreEqual(expectedMessage, ex.Message);
            }
            else
            {
                var ex = Assert.ThrowsException<System.InvalidOperationException>(() => InvokeGetSync(request));
                Assert.AreEqual(expectedMessage, ex.Message);
            }
        }

        [DataTestMethod]
        [DataRow(true)]
        [DataRow(false)]
        public async Task GetItemHelper_AppliesProjectionExpression(bool isAsync)
        {
            var request = new GetItemDocumentOperationRequest
            {
                Key = new Dictionary<string, DynamoDBEntry> { { "Id", new Primitive("abc") } },
                ConsistentRead = true,
                ProjectionExpression = new Expression
                {
                    ExpressionStatement = "#A, #B",
                    ExpressionAttributeNames = new Dictionary<string, string>
                    {
                        { "#A", "AttrA" },
                        { "#B", "AttrB" }
                    }
                }
            };

            Predicate<GetItemRequest> predicate = r =>
                r.Key.ContainsKey("Id")
                && r.ConsistentRead == true
                && r.ProjectionExpression == "#A, #B"
                && r.ExpressionAttributeNames.ContainsKey("#A")
                && r.ExpressionAttributeNames.ContainsKey("#B");

            var getResponse = new GetItemResponse { Item = new Dictionary<string, AttributeValue> { { "AttrA", new AttributeValue { S = "valA" } } } };

            if (isAsync)
            {
                _ddbClientMock
                    .Setup(c => c.GetItemAsync(It.Is<GetItemRequest>(r => predicate(r)), It.IsAny<CancellationToken>()))
                    .ReturnsAsync(getResponse)
                    .Verifiable();

                var result = await InvokeGetAsync(request);
                Assert.IsNotNull(result);
                _ddbClientMock.Verify(c => c.GetItemAsync(It.Is<GetItemRequest>(r => predicate(r)), It.IsAny<CancellationToken>()), Times.Once);
            }
            else
            {
                _ddbClientMock
                    .Setup(c => c.GetItem(It.Is<GetItemRequest>(r => predicate(r))))
                    .Returns(getResponse)
                    .Verifiable();

                var result = InvokeGetSync(request);
                Assert.IsNotNull(result);
                _ddbClientMock.Verify(c => c.GetItem(It.Is<GetItemRequest>(r => predicate(r))), Times.Once);
            }
        }

        [DataTestMethod]
        [DataRow(true)]
        [DataRow(false)]
        public async Task GetItemHelper_ReturnsDocument(bool isAsync)
        {
            var request = new GetItemDocumentOperationRequest
            {
                Key = new Dictionary<string, DynamoDBEntry> { { "Id", new Primitive("123") } },
                ConsistentRead = false
            };

            var getResponse = new GetItemResponse
            {
                Item = new Dictionary<string, AttributeValue>
                {
                    { "Id", new AttributeValue { S = "123" } },
                    { "Name", new AttributeValue { S = "John" } }
                }
            };

            if (isAsync)
            {
                _ddbClientMock.Setup(c => c.GetItemAsync(It.IsAny<GetItemRequest>(), It.IsAny<CancellationToken>()))
                    .ReturnsAsync(getResponse);

                var result = await InvokeGetAsync(request);
                Assert.IsNotNull(result);
                Assert.AreEqual("123", result["Id"].AsPrimitive().Value);
                Assert.AreEqual("John", result["Name"].AsPrimitive().Value);
            }
            else
            {
                _ddbClientMock.Setup(c => c.GetItem(It.IsAny<GetItemRequest>()))
                    .Returns(getResponse);

                var result = InvokeGetSync(request);
                Assert.IsNotNull(result);
                Assert.AreEqual("123", result["Id"].AsPrimitive().Value);
                Assert.AreEqual("John", result["Name"].AsPrimitive().Value);
            }
        }
        #endregion
    }
}
