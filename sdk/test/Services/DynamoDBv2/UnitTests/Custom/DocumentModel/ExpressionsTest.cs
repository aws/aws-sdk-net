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
        public void GivenBothExpressionsNull_WhenMergeUpdateExpressionsCalled_ThenReturnsNull()
        {
            var result = Expression.MergeUpdateExpressions(null, null);
            Assert.IsNull(result);
        }

        [TestMethod]
        public void GivenOneExpressionNull_WhenMergeUpdateExpressionsCalled_ThenReturnsTheOtherExpressionStatement()
        {
            var left = new Expression { ExpressionStatement = "SET #A = :a" };
            var right = new Expression { ExpressionStatement = "SET #B = :b" };

            Assert.AreEqual(left.ExpressionStatement, Expression.MergeUpdateExpressions(null, left).ExpressionStatement);
            Assert.AreEqual(right.ExpressionStatement, Expression.MergeUpdateExpressions(right, null).ExpressionStatement);
        }

        [TestMethod]
        public void GivenTwoSetSections_WhenMerged_ThenCombinedSetClauseContainsBothAssignments()
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
        public void GivenSetAndRemoveSections_WhenMerged_ThenStatementContainsBothSections()
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
        public void GivenDuplicateAttributeNameDifferentValues_WhenMerged_ThenThrowsInvalidOperationException()
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
        public void GivenExpressionWithoutKeywords_WhenMerged_ThenThrowsUnableToParseException()
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

        [TestMethod]
        public void GivenDistinctAttributeNames_WhenMerged_ThenBothNamesPresent()
        {
            var left = new Expression
            {
                ExpressionStatement = "SET #A = :a",
                ExpressionAttributeNames = new() { ["#A"] = "AttrA" },
                ExpressionAttributeValues = new() { [":a"] = new Primitive("va") }
            };
            var right = new Expression
            {
                ExpressionStatement = "SET #B = :b",
                ExpressionAttributeNames = new() { ["#B"] = "AttrB" },
                ExpressionAttributeValues = new() { [":b"] = new Primitive("vb") }
            };

            var merged = Expression.MergeUpdateExpressions(right, left);

            Assert.IsNotNull(merged);
            Assert.IsNotNull(merged.ExpressionAttributeNames);
            Assert.AreEqual(2, merged.ExpressionAttributeNames.Count);
            Assert.AreEqual("AttrA", merged.ExpressionAttributeNames["#A"]);
            Assert.AreEqual("AttrB", merged.ExpressionAttributeNames["#B"]);
        }

        [TestMethod]
        public void GivenDuplicateAttributeNameSameValue_WhenMerged_ThenSingleNameRetained()
        {
            var left = new Expression
            {
                ExpressionStatement = "SET #X = :x1",
                ExpressionAttributeNames = new() { ["#X"] = "Same" },
                ExpressionAttributeValues = new() { [":x1"] = new Primitive("v1") }
            };
            var right = new Expression
            {
                ExpressionStatement = "SET #X = :x2",
                ExpressionAttributeNames = new() { ["#X"] = "Same" },
                ExpressionAttributeValues = new() { [":x2"] = new Primitive("v2") }
            };

            var merged = Expression.MergeUpdateExpressions(right, left);

            Assert.IsNotNull(merged);
            Assert.AreEqual(1, merged.ExpressionAttributeNames.Count);
            Assert.AreEqual("Same", merged.ExpressionAttributeNames["#X"]);
        }

        [TestMethod]
        public void GivenDuplicateAttributeNameDifferentValues_WhenMerged_ThenThrowsWithInnerException()
        {
            var left = new Expression
            {
                ExpressionStatement = "SET #C = :c1",
                ExpressionAttributeNames = new() { ["#C"] = "CriticRating" },
                ExpressionAttributeValues = new() { [":c1"] = new Primitive("1") }
            };
            var right = new Expression
            {
                ExpressionStatement = "SET #C = :c2",
                ExpressionAttributeNames = new() { ["#C"] = "CustomerRating" },
                ExpressionAttributeValues = new() { [":c2"] = new Primitive("2") }
            };

            var ex = Assert.ThrowsException<InvalidOperationException>(() =>
                Expression.MergeUpdateExpressions(right, left));

            StringAssert.StartsWith(ex.Message, "Failed to combine ExpressionAttributeNames due to duplicate keys with different values.");
            Assert.IsNotNull(ex.InnerException);
        }
    }
}