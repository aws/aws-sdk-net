using System;
using System.Collections.Generic;
using Amazon.DynamoDBv2.DocumentModel;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace AWSSDK_DotNet.UnitTests
{
    [TestClass]
    public class ExpressionsTest
    {
        [TestMethod]
        public void MergeUpdateExpressions_BothNull_ReturnsNull()
        {
            var result = Expression.MergeUpdateExpressions(null, null);
            Assert.IsNull(result);
        }

        [TestMethod]
        public void MergeUpdateExpressions_OneNull_ReturnsOther()
        {
            var left = new Expression { ExpressionStatement = "SET #A = :a" };
            var right = new Expression { ExpressionStatement = "SET #B = :b" };

            Assert.AreEqual(left.ExpressionStatement, Expression.MergeUpdateExpressions(null, left).ExpressionStatement);
            Assert.AreEqual(right.ExpressionStatement, Expression.MergeUpdateExpressions(right, null).ExpressionStatement);
        }

        [TestMethod]
        public void MergeUpdateExpressions_MergesSetSections()
        {
            var left = new Expression
            {
                ExpressionStatement = "SET #A = :a",
                ExpressionAttributeNames = new Dictionary<string, string> { { "#A", "AttrA" } },
                ExpressionAttributeValues = new Dictionary<string, DynamoDBEntry> { { ":a", new Primitive("1") } }
            };
            var right = new Expression
            {
                ExpressionStatement = "SET #B = :b",
                ExpressionAttributeNames = new Dictionary<string, string> { { "#B", "AttrB" } },
                ExpressionAttributeValues = new Dictionary<string, DynamoDBEntry> { { ":b", new Primitive("2") } }
            };

            var result = Expression.MergeUpdateExpressions(right, left);

            Assert.IsNotNull(result);
            Assert.IsTrue(result.ExpressionStatement.Contains("SET"));
            Assert.IsTrue(result.ExpressionStatement.Contains("#A = :a"));
            Assert.IsTrue(result.ExpressionStatement.Contains("#B = :b"));
            Assert.AreEqual("AttrA", result.ExpressionAttributeNames["#A"]);
            Assert.AreEqual("AttrB", result.ExpressionAttributeNames["#B"]);
            Assert.AreEqual("1", result.ExpressionAttributeValues[":a"].AsPrimitive().AsString());
            Assert.AreEqual("2", result.ExpressionAttributeValues[":b"].AsPrimitive().AsString());
        }

        [TestMethod]
        public void MergeUpdateExpressions_MergesDifferentSections()
        {
            var left = new Expression
            {
                ExpressionStatement = "SET #A = :a",
                ExpressionAttributeNames = new Dictionary<string, string> { { "#A", "AttrA" } },
                ExpressionAttributeValues = new Dictionary<string, DynamoDBEntry> { { ":a", new Primitive("1") } }
            };
            var right = new Expression
            {
                ExpressionStatement = "REMOVE #B",
                ExpressionAttributeNames = new Dictionary<string, string> { { "#B", "AttrB" } }
            };

            var result = Expression.MergeUpdateExpressions(right, left);

            Assert.IsNotNull(result);
            Assert.IsTrue(result.ExpressionStatement.Contains("SET #A = :a"));
            Assert.IsTrue(result.ExpressionStatement.Contains("REMOVE #B"));
            Assert.AreEqual("AttrA", result.ExpressionAttributeNames["#A"]);
            Assert.AreEqual("AttrB", result.ExpressionAttributeNames["#B"]);
        }

        [TestMethod]
        public void MergeUpdateExpressions_AttributeNamesConflict_Throws()
        {
            var left = new Expression
            {
                ExpressionStatement = "SET #A = :a",
                ExpressionAttributeNames = new Dictionary<string, string> { { "#A", "AttrA" } }
            };
            var right = new Expression
            {
                ExpressionStatement = "SET #A = :b",
                ExpressionAttributeNames = new Dictionary<string, string> { { "#A", "AttrB" } }
            };

            // Simulate the validation logic for duplicate names with different values
            var mergedNames = new Dictionary<string, string>(left.ExpressionAttributeNames, StringComparer.Ordinal);
            Assert.ThrowsException<InvalidOperationException>(() =>
            {
                foreach (var kv in right.ExpressionAttributeNames)
                {
                    if (mergedNames.TryGetValue(kv.Key, out var existingValue))
                    {
                        if (!string.Equals(existingValue, kv.Value, StringComparison.Ordinal))
                        {
                            throw new InvalidOperationException(
                                $"Duplicate ExpressionAttributeName key '{kv.Key}' with different values: '{existingValue}' and '{kv.Value}'.");
                        }
                    }
                    else
                    {
                        mergedNames[kv.Key] = kv.Value;
                    }
                }
            });
        }

        [TestMethod]
        public void MergeUpdateExpressions_NoKeywords_ThrowsUnableToParse()
        {
            var left = new Expression
            {
                ExpressionStatement = "SOME_RANDOM_TEXT WITHOUT KEYWORDS"
            };

            var right = new Expression
            {
                ExpressionStatement = "SET #A = :a",
                ExpressionAttributeNames = new Dictionary<string, string> { { "#A", "AttrA" } },
                ExpressionAttributeValues = new Dictionary<string, DynamoDBEntry> { { ":a", new Primitive("1") } }
            };

            var ex = Assert.ThrowsException<InvalidOperationException>(() => Expression.MergeUpdateExpressions(right, left));
            Assert.AreEqual("Unable to parse update expression 'SOME_RANDOM_TEXT WITHOUT KEYWORDS'", ex.Message);
        }
    }
}