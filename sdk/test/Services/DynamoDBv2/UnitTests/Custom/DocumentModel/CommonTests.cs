using Amazon.DynamoDBv2;
using Amazon.DynamoDBv2.DocumentModel;
using Amazon.DynamoDBv2.Model;
using Amazon.Runtime;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;
using System;
using System.Collections.Generic;
using System.Linq;

namespace AWSSDK_DotNet.UnitTests
{
    [TestClass]
    public class CommonTests
    {
        private Table CreateTable()
        {
            var ddbClientMock = new Mock<IAmazonDynamoDB>(MockBehavior.Strict);

            var clientConfigMock = new Mock<IClientConfig>();
            clientConfigMock.SetupGet(c => c.RegionEndpoint).Returns((Amazon.RegionEndpoint)null);
            clientConfigMock.SetupGet(c => c.ServiceURL).Returns((string)null);
            ddbClientMock.SetupGet(c => c.Config).Returns(clientConfigMock.Object);

            var config = new TableConfig("TestTable");
            var table = new Table(ddbClientMock.Object, config);

            table.ClearTableData();
            table.Keys.Add("Id", new KeyDescription { IsHash = true, Type = DynamoDBEntryType.String });
            table.HashKeys.Add("Id");
            return table;
        }
        private class DummyExpression : Expression
        {
            public DummyExpression(string statement, Dictionary<string, string> names, Dictionary<string, DynamoDBEntry> values)
            {
                ExpressionStatement = statement;
                ExpressionAttributeNames = names;
                ExpressionAttributeValues = values;
            }
        }

        private static AttributeValueUpdate Put(string s) =>
            new (new AttributeValue { S = s }, AttributeAction.PUT);

        [TestMethod]
        public void GivenSinglePutUpdate_WhenConvertAttributeUpdatesToUpdateExpression_ThenSetClauseAndMappingsCreated()
        {
            var updates = new Dictionary<string, AttributeValueUpdate>
            {
                { "Attr1", new AttributeValueUpdate { Action = AttributeAction.PUT, Value = new AttributeValue { S = "val1" } } }
            };
            var table = CreateTable();
            Common.ConvertAttributeUpdatesToUpdateExpression(updates, null, null, table,
                out var statement, out var exprValues, out var exprNames);

            Assert.IsTrue(statement.StartsWith("SET"));
            Assert.AreEqual(1, exprValues.Count);
            Assert.AreEqual(1, exprNames.Count);
            Assert.IsTrue(exprNames.Values.Contains("Attr1"));
        }

        [TestMethod]
        public void GivenSingleDeleteUpdate_WhenConvertAttributeUpdatesToUpdateExpression_ThenRemoveClauseCreated()
        {
            var updates = new Dictionary<string, AttributeValueUpdate>
            {
                { "Attr2", new AttributeValueUpdate { Action = AttributeAction.DELETE, Value = new AttributeValue { S = "val2" } } }
            };
            var table = CreateTable();
            Common.ConvertAttributeUpdatesToUpdateExpression(updates, null, null, table,
                out var statement, out var exprValues, out var exprNames);

            Assert.IsTrue(statement.Contains("REMOVE"));
            Assert.AreEqual(0, exprValues.Count);
            Assert.AreEqual(1, exprNames.Count);
            Assert.IsTrue(exprNames.Values.Contains("Attr2"));
        }

        [TestMethod]
        public void GivenIfNotExistsAttribute_WhenConvertAttributeUpdatesToUpdateExpression_ThenIfNotExistsUsed()
        {
            var updates = new Dictionary<string, AttributeValueUpdate>
            {
                { "Attr3", new AttributeValueUpdate { Action = AttributeAction.PUT, Value = new AttributeValue { S = "val3" } } }
            };
            var ifNotExist = new HashSet<string> { "Attr3" };
            var table = CreateTable();
            Common.ConvertAttributeUpdatesToUpdateExpression(updates, ifNotExist, null, table,
                out var statement, out var exprValues, out var exprNames);

            Assert.IsTrue(statement.Contains("if_not_exists"));
            Assert.AreEqual(1, exprValues.Count);
            Assert.AreEqual(1, exprNames.Count);
        }

        [TestMethod]
        public void GivenExistingExpressionAndNewUpdate_WhenConvertAttributeUpdatesToUpdateExpression_ThenExistingStatementExtended()
        {
            var updates = new Dictionary<string, AttributeValueUpdate>
            {
                { "Attr4", new AttributeValueUpdate { Action = AttributeAction.PUT, Value = new AttributeValue { S = "val4" } } }
            };
            var table = CreateTable();
            var exprNames = new Dictionary<string, string> { { "#existing", "ExistingAttr" } };

            var exprValues = new Dictionary<string, DynamoDBEntry> { { ":existing", new Primitive("existingVal") } };
            var updateExpr = new DummyExpression("SET #existing = :existing", exprNames, exprValues);

            Common.ConvertAttributeUpdatesToUpdateExpression(updates, null, updateExpr, table,
                out var statement, out var outValues, out var outNames);

            Assert.IsTrue(statement.StartsWith("SET #existing = :existing,"));
            Assert.IsTrue(statement.Contains("#awsavar1 = :awsavar1"));
            Assert.AreEqual(2, outNames.Count);
            Assert.AreEqual(2, outValues.Count);
        }

        [TestMethod]
        public void GivenNoUpdates_WhenConvertAttributeUpdatesToUpdateExpression_ThenEmptyStatementAndNoMappings()
        {
            var updates = new Dictionary<string, AttributeValueUpdate>();
            var table = CreateTable();
            Common.ConvertAttributeUpdatesToUpdateExpression(updates, null, null, table,
                out var statement, out var exprValues, out var exprNames);

            Assert.AreEqual(string.Empty, statement.Trim());
            Assert.AreEqual(0, exprValues.Count);
            Assert.AreEqual(0, exprNames.Count);
        }

        [TestMethod]
        public void GivenUpdateExpressionProvided_WhenConvertCalled_ThenExistingAttributeCollectionsReused()
        {
            var attributesToUpdates = new Dictionary<string, AttributeValueUpdate>(StringComparer.Ordinal);
            var updateExpression = new Expression
            {
                ExpressionAttributeNames = new Dictionary<string, string>(StringComparer.Ordinal)
                {
                    { "#A", "AttrA" }
                },
                ExpressionAttributeValues = new Dictionary<string, DynamoDBEntry>(StringComparer.Ordinal)
            };

            Common.ConvertAttributeUpdatesToUpdateExpression(
                attributesToUpdates,
                ifNotExistAttributeNames: null,
                updateExpression,
                table: null,
                out var statement,
                out var expressionAttributeValues,
                out var expressionAttributes);

            Assert.AreSame(updateExpression.ExpressionAttributeNames, expressionAttributes);
            Assert.AreEqual(0, expressionAttributeValues.Count);
            Assert.IsNotNull(statement);
        }

        [TestMethod]
        public void GivenExistingAttributeNameInExpression_WhenUpdateContainsSameAttribute_ThenAttributeSkipped()
        {
            var updateExpression = new Expression
            {
                ExpressionAttributeNames = new Dictionary<string, string>(StringComparer.Ordinal)
                {
                    { "#X", "ExistingAttr" }
                },
                ExpressionAttributeValues = new Dictionary<string, DynamoDBEntry>(StringComparer.Ordinal)
            };

            var attributesToUpdates = new Dictionary<string, AttributeValueUpdate>(StringComparer.Ordinal)
            {
                { "ExistingAttr", Put("newVal") }
            };

            Common.ConvertAttributeUpdatesToUpdateExpression(
                attributesToUpdates,
                ifNotExistAttributeNames: null,
                updateExpression,
                table: null,
                out var statement,
                out var expressionAttributeValues,
                out var expressionAttributes);

            foreach (var k in expressionAttributes.Keys)
            {
                Assert.AreNotEqual("#awsavar1", k);
            }
            Assert.AreEqual(1, expressionAttributes.Count);
            Assert.AreEqual(0, expressionAttributeValues.Count);
            Assert.IsTrue(string.IsNullOrWhiteSpace(statement));
        }

        [TestMethod]
        public void GivenNewAttributeNotInExpression_WhenConvertCalled_ThenVariableAndSetClauseGenerated()
        {
            var updateExpression = new Expression
            {
                ExpressionAttributeNames = new Dictionary<string, string>(StringComparer.Ordinal)
                {
                    { "#X", "ExistingAttr" }
                },
                ExpressionAttributeValues = new Dictionary<string, DynamoDBEntry>(StringComparer.Ordinal)
            };

            var attributesToUpdates = new Dictionary<string, AttributeValueUpdate>(StringComparer.Ordinal)
            {
                { "NewAttr", Put("Val1") }
            };

            Common.ConvertAttributeUpdatesToUpdateExpression(
                attributesToUpdates,
                ifNotExistAttributeNames: null,
                updateExpression,
                table: null,
                out var statement,
                out var expressionAttributeValues,
                out var expressionAttributes);

            Assert.AreEqual(2, expressionAttributes.Count);

            string newAttrRef = null;
            foreach (var kvp in expressionAttributes)
            {
                if (kvp.Value == "NewAttr")
                    newAttrRef = kvp.Key;
            }
            Assert.IsNotNull(newAttrRef);
            Assert.IsTrue(newAttrRef.StartsWith("#awsavar"));

            bool foundValue = false;
            foreach (var kvp in expressionAttributeValues)
            {
                if (kvp.Key.StartsWith(":awsavar") && kvp.Value.S == "Val1")
                {
                    foundValue = true;
                    break;
                }
            }
            Assert.IsTrue(foundValue);
            Assert.IsTrue(statement.StartsWith("SET "));
            StringAssert.Contains(statement, newAttrRef);
        }

        [TestMethod]
        public void GivenSingleDeleteWithoutCreateOnly_WhenConvertAttributeUpdatesToUpdateExpression_ThenRemoveListContainsOneReference()
        {
            var updates = new Dictionary<string, AttributeValueUpdate>
            {
                { "DelA", new AttributeValueUpdate { Action = AttributeAction.DELETE, Value = new AttributeValue { S = "x" } } }
            };
            var table = CreateTable();

            Common.ConvertAttributeUpdatesToUpdateExpression(updates, ifNotExistAttributeNames: null, updateExpression: null, table,
                out var statement, out var exprValues, out var exprNames);

            Assert.IsTrue(statement == "REMOVE #awsavar1");
            Assert.AreEqual(0, exprValues.Count);
            Assert.AreEqual("DelA", exprNames["#awsavar1"]);
        }

        [TestMethod]
        public void GivenMultipleDeletesWithoutCreateOnly_WhenConvertAttributeUpdatesToUpdateExpression_ThenRemoveClauseCommaSeparated()
        {
            var updates = new Dictionary<string, AttributeValueUpdate>
            {
                { "DelA", new AttributeValueUpdate { Action = AttributeAction.DELETE, Value = new AttributeValue { S = "x" } } },
                { "DelB", new AttributeValueUpdate { Action = AttributeAction.DELETE, Value = new AttributeValue { S = "y" } } }
            };
            var table = CreateTable();

            Common.ConvertAttributeUpdatesToUpdateExpression(updates, null, null, table,
                out var statement, out var exprValues, out var exprNames);

            Assert.IsTrue(statement.StartsWith("REMOVE "));
            StringAssert.Contains(statement, ",");
            Assert.IsFalse(statement.Contains("SET"));
            Assert.AreEqual(0, exprValues.Count);
            Assert.AreEqual(2, exprNames.Count);
        }

        [TestMethod]
        public void GivenDeleteMarkedCreateOnly_WhenConvertAttributeUpdatesToUpdateExpression_ThenSetClauseUsesIfNotExistsAndValueAdded()
        {
            var updates = new Dictionary<string, AttributeValueUpdate>
            {
                { "DelCreate", new AttributeValueUpdate { Action = AttributeAction.DELETE, Value = new AttributeValue { S = "seed" } } }
            };
            var createOnly = new HashSet<string> { "DelCreate" };
            var table = CreateTable();

            Common.ConvertAttributeUpdatesToUpdateExpression(updates, createOnly, null, table,
                out var statement, out var exprValues, out var exprNames);

            Assert.IsTrue(string.IsNullOrEmpty(statement));
            Assert.AreEqual(0, exprValues.Count);
            Assert.AreEqual(0, exprNames.Count);
        }

        [TestMethod]
        public void GivenMixedPutAndDelete_WhenConvertAttributeUpdatesToUpdateExpression_ThenSetThenRemoveClausesGenerated()
        {
            var updates = new Dictionary<string, AttributeValueUpdate>
            {
                { "PutAttr", new AttributeValueUpdate { Action = AttributeAction.PUT, Value = new AttributeValue { S = "val" } } },
                { "DelAttr", new AttributeValueUpdate { Action = AttributeAction.DELETE, Value = new AttributeValue { S = "ignored" } } }
            };
            var table = CreateTable();

            Common.ConvertAttributeUpdatesToUpdateExpression(updates, null, null, table,
                out var statement, out var exprValues, out var exprNames);

            Assert.AreEqual("SET #awsavar1 = :awsavar1  REMOVE #awsavar2", statement);
            Assert.AreEqual(1, exprValues.Count);
            Assert.AreEqual(2, exprNames.Count);
        }

    }
}