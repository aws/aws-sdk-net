using Amazon.DynamoDBv2.DocumentModel;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;

namespace AWSSDK_DotNet.UnitTests
{
    [TestClass]
    public class ExpressionBuilderTests
    {

        [TestMethod]
        [ExpectedException(typeof(InvalidOperationException))]
        [TestCategory("DynamoDBv2")]
        public void Build_ShouldThrowExceptionWhenNoOperation()
        {
            var builder = UpdateExpressionBuilder.New().Build();
        }

        [TestMethod]
        [TestCategory("DynamoDBv2")]
        public void BuildForSetOperation_ShouldReturnExpression()
        {
            var builder = UpdateExpressionBuilder.New();
            builder.Set(NameBuilder.New("test"),
                SetValueBuilder.New().WithValue(10).Plus(20));

            var expressionTree = builder.Build();

            Assert.IsTrue(expressionTree.ExpressionStatement.Contains("SET"));
            Assert.AreEqual(2, expressionTree.ExpressionAttributeValues.Count);
            Assert.AreEqual(1, expressionTree.ExpressionAttributeNames.Count);
        }

        [TestMethod]
        public void BuildForRemoveOperation_ShouldReturnExpression()
        {
            var builder = UpdateExpressionBuilder.New();
            builder.Remove(NameBuilder.New("test"));

            var expressionTree = builder.Build();

            Assert.IsTrue(expressionTree.ExpressionStatement.Contains("REMOVE"));
            Assert.AreEqual(1, expressionTree.ExpressionAttributeNames.Count);
        }

        [TestMethod]
        public void BuildForAddOperation_ShouldReturnExpression()
        {
            var builder = UpdateExpressionBuilder.New();
            builder.Add(NameBuilder.New("Garbage"), ValueBuilder.New("asdf"));

            var expressionTree = builder.Build();

            Assert.IsTrue(expressionTree.ExpressionStatement.Contains("ADD"));
            Assert.AreEqual(1, expressionTree.ExpressionAttributeNames.Count);
            Assert.AreEqual(1, expressionTree.ExpressionAttributeValues.Count);
        }

        [TestMethod]
        public void BuildForDeleteOperation_ShouldReturnExpression()
        {
            var builder = UpdateExpressionBuilder.New();
            builder.Delete(NameBuilder.New("test"), ValueBuilder.New(10));

            var expressionTree = builder.Build();

            Assert.IsTrue(expressionTree.ExpressionStatement.Contains("DELETE"));
            Assert.AreEqual(1, expressionTree.ExpressionAttributeNames.Count);
            Assert.AreEqual(1, expressionTree.ExpressionAttributeValues.Count);
        }

        [TestMethod]
        [ExpectedException(typeof(InvalidOperationException))]
        public void BuildForRemoveOperation_WithInvalidName_ShouldThrowException()
        {
            var builder = UpdateExpressionBuilder.New();
            builder.Remove(NameBuilder.New(""));
            builder.Build();
        }

        [TestMethod]
        [TestCategory("DynamoDBv2")]
        public void UpdateExpressionBuilder_WithMultipleSetOperations_Should_Build_Correctly()
        {
            var updateExpression = UpdateExpressionBuilder.New().
                Set(NameBuilder.New("test"),
                    SetValueBuilder.New().WithValue(10).Plus(20)).
                Set(NameBuilder.New("test2"),
                    SetValueBuilder.New().WithValue(20).Minus(30)).
                Build();

            Assert.AreEqual("SET #U0 = :U0 + :U1, #U1 = :U2 - :U3\n", updateExpression.ExpressionStatement);
            Assert.AreEqual(2, updateExpression.ExpressionAttributeNames.Count);
            Assert.AreEqual("test", updateExpression.ExpressionAttributeNames["#U0"]);
            Assert.AreEqual("test2", updateExpression.ExpressionAttributeNames["#U1"]);
            Assert.AreEqual(4, updateExpression.ExpressionAttributeValues.Count);
        }

        [TestMethod]
        [TestCategory("DynamoDBv2")]
        public void UpdateExpressionBuilder_SetAndRemoveExpressionBuilder_Build_Correctly()
        {
            var updateExpression = UpdateExpressionBuilder.New().
                Set(NameBuilder.New("test"),
                    SetValueBuilder.New().WithValue(10).Plus(20)).
                Remove(NameBuilder.New("test2")).
                Build();

            Assert.AreEqual("SET #U0 = :U0 + :U1\nREMOVE #U1\n" ,updateExpression.ExpressionStatement);
            Assert.AreEqual(2, updateExpression.ExpressionAttributeNames.Count);
            Assert.AreEqual(2, updateExpression.ExpressionAttributeValues.Count);
        }

        [TestMethod]
        [TestCategory("DynamoDBv2")]
        public void ConditionExpressionBuilderTest()
        {
            var conditionExpression = ConditionExpressionBuilder.New().WithName("Age").Equal(21).
                And(ConditionExpressionBuilder.New().WithName("Status").GreaterThan(1)).Build();

            Assert.AreEqual("(#C0 = :C0) AND (#C1 > :C1)", conditionExpression.ExpressionStatement);
            Assert.AreEqual(2, conditionExpression.ExpressionAttributeNames.Count);
            Assert.AreEqual("Age", conditionExpression.ExpressionAttributeNames["#C0"]);
            Assert.AreEqual("Status", conditionExpression.ExpressionAttributeNames["#C1"]);
            Assert.AreEqual(2, conditionExpression.ExpressionAttributeValues.Count);
        }

        [TestMethod]
        [TestCategory("DynamoDBv2")]
        public void NameBuilderConstructor_WhenCalled_CreatesValidInstance()
        {
            var nameBuilder = NameBuilder.New("test");

            Assert.IsNotNull(nameBuilder);
            Assert.IsInstanceOfType(nameBuilder, typeof(OperandBuilder));
        }

        [TestMethod]
        [TestCategory("DynamoDBv2")]
        public void Complex_Attribute_Paths_Should_Build_Correctly()
        {
            var nameBuilder = NameBuilder.New("parent.child[0].attribute");
            var node = nameBuilder.AttributeExists().Build();

            Assert.AreEqual("attribute_exists (#C0.#C1[0].#C2)", node.ExpressionStatement);
            Assert.AreEqual(0, node.ExpressionAttributeValues.Count);
            Assert.AreEqual(3, node.ExpressionAttributeNames.Count);
            Assert.AreEqual("parent", node.ExpressionAttributeNames["#C0"]);
            Assert.AreEqual("child", node.ExpressionAttributeNames["#C1"]);
            Assert.AreEqual("attribute", node.ExpressionAttributeNames["#C2"]);

        }

        [TestMethod]
        [TestCategory("DynamoDBv2")]
        public void BuildNameBuilder_WithSpecialCharacters_Should_Build_Correctly()
        {
            var attributeName = "Test#Attribute-Name.123";
            var nameBuilder = NameBuilder.New(attributeName);

            var result = nameBuilder.AttributeExists().Build();

            Assert.IsNotNull(result);
            Assert.AreEqual("attribute_exists (#C0.#C1)", result.ExpressionStatement);
            Assert.AreEqual(2, result.ExpressionAttributeNames.Count);
            Assert.AreEqual("Test#Attribute-Name", result.ExpressionAttributeNames["#C0"]);
            Assert.AreEqual("123", result.ExpressionAttributeNames["#C1"]);
        }

        [TestMethod]
        [TestCategory("DynamoDBv2")]
        public void BuildNameBuilder_Equal_WithValue_ReturnsCondition()
        {
            var nameBuilder = NameBuilder.New("TestAttribute");

            var result = nameBuilder.Equal(10);
            var resultNode = result.Build();

            Assert.IsNotNull(resultNode);
            Assert.AreEqual("#C0 = :C0", resultNode.ExpressionStatement);
        }

        [TestMethod]
        [TestCategory("DynamoDBv2")]
        public void BuildNameBuilder_NotEqual_WithValue_ReturnsCondition()
        {
            var nameBuilder = NameBuilder.New("TestAttribute");

            var result = nameBuilder.NotEqual(10);
            var resultNode = result.Build();

            Assert.IsNotNull(result);
            Assert.AreEqual("#C0 <> :C0", resultNode.ExpressionStatement);
        }

        [TestMethod]
        [TestCategory("DynamoDBv2")]
        public void BuildNameBuilder_GreaterThan_WithValue_ReturnsCondition()
        {
            var nameBuilder = NameBuilder.New("TestAttribute");

            var result = nameBuilder.GreaterThan(10);
            var resultNode = result.Build();

            Assert.IsNotNull(resultNode);
            Assert.AreEqual("#C0 > :C0", resultNode.ExpressionStatement);
        }

        [TestMethod]
        [TestCategory("DynamoDBv2")]
        public void BuildNameBuilder_GreaterThanOrEqual_WithValue_ReturnsCondition()
        {
            var nameBuilder = NameBuilder.New("TestAttribute");

            var result = nameBuilder.GreaterThanOrEqual(10);
            var resultNode = result.Build();

            Assert.IsNotNull(resultNode);
            Assert.AreEqual("#C0 >= :C0", resultNode.ExpressionStatement);
        }

        [TestMethod]
        [TestCategory("DynamoDBv2")]
        public void BuildNameBuilder_LessThan_WithValue_ReturnsCondition()
        {
            var nameBuilder = NameBuilder.New("TestAttribute");

            var result = nameBuilder.LessThan(10);
            var resultNode = result.Build();

            Assert.IsNotNull(result);
            Assert.AreEqual("#C0 < :C0", resultNode.ExpressionStatement);
        }

        [TestMethod]
        [TestCategory("DynamoDBv2")]
        public void BuildNameBuilder_LessThanOrEqual_WithValue_ReturnsCondition()
        {
            var nameBuilder = NameBuilder.New("TestAttribute");

            var result = nameBuilder.LessThanOrEqual(10);
            var resultNode = result.Build();

            Assert.IsNotNull(result);
            Assert.AreEqual("#C0 <= :C0", resultNode.ExpressionStatement);
        }

        [TestMethod]
        [TestCategory("DynamoDBv2")]
        public void BuildNameBuilder_Between_WithValue_ReturnsCondition()
        {
            var nameBuilder = NameBuilder.New("TestAttribute");

            var result = nameBuilder.Between(10, 20);
            var resultNode = result.Build();

            Assert.IsNotNull(result);
            Assert.AreEqual("#C0 BETWEEN :C0 AND :C1", resultNode.ExpressionStatement);
            Assert.AreEqual(1, resultNode.ExpressionAttributeNames.Count);
            Assert.AreEqual(2, resultNode.ExpressionAttributeValues.Count);
            Assert.AreEqual(10, resultNode.ExpressionAttributeValues[":C0"]);
            Assert.AreEqual(20, resultNode.ExpressionAttributeValues[":C1"]);
            
        }

        [TestMethod]
        [TestCategory("DynamoDBv2")]
        public void BuildNameBuilder_In_WithValue_ReturnsCondition()
        {
            var nameBuilder = NameBuilder.New("TestAttribute");

            var result = nameBuilder.In(10, 20, 30);
            var resultNode = result.Build();

            Assert.IsNotNull(resultNode);
            Assert.AreEqual("#C0 IN (:C0, :C1, :C2)", resultNode.ExpressionStatement);

            // Assert ExpressionAttributeNames
            Assert.AreEqual(1, resultNode.ExpressionAttributeNames.Count);
            Assert.AreEqual("TestAttribute", resultNode.ExpressionAttributeNames["#C0"]);

            // Assert ExpressionAttributeValues
            Assert.AreEqual(3, resultNode.ExpressionAttributeValues.Count);
            Assert.AreEqual(10, resultNode.ExpressionAttributeValues[":C0"]);
            Assert.AreEqual(20, resultNode.ExpressionAttributeValues[":C1"]);
            Assert.AreEqual(30, resultNode.ExpressionAttributeValues[":C2"]);

        }

        [TestMethod]
        [TestCategory("DynamoDBv2")]
        public void BuildNameBuilder_BeginsWith_WithValue_ReturnsCondition()
        {
            var nameBuilder = NameBuilder.New("TestAttribute");

            var result = nameBuilder.BeginsWith("test");
            var resultNode = result.Build();

            Assert.IsNotNull(resultNode);
            Assert.AreEqual("begins_with (#C0, :C0)", resultNode.ExpressionStatement);

            // Assert ExpressionAttributeNames
            Assert.AreEqual(1, resultNode.ExpressionAttributeNames.Count);
            Assert.AreEqual("TestAttribute", resultNode.ExpressionAttributeNames["#C0"]);

            // Assert ExpressionAttributeValues
            Assert.AreEqual(1, resultNode.ExpressionAttributeValues.Count);
            Assert.AreEqual("test", resultNode.ExpressionAttributeValues[":C0"].AsString());
        }

        [TestMethod]
        [TestCategory("DynamoDBv2")]
        public void BuildNameBuilder_Contains_WithValue_ReturnsCondition()
        {
            var nameBuilder = NameBuilder.New("TestAttribute");

            var result = nameBuilder.Contains("test");
            var resultNode = result.Build();

            Assert.IsNotNull(resultNode);
            Assert.AreEqual("contains (#C0, :C0)", resultNode.ExpressionStatement);

            // Assert ExpressionAttributeNames
            Assert.AreEqual(1, resultNode.ExpressionAttributeNames.Count);
            Assert.AreEqual("TestAttribute", resultNode.ExpressionAttributeNames["#C0"]);

            // Assert ExpressionAttributeValues
            Assert.AreEqual(1, resultNode.ExpressionAttributeValues.Count);
            Assert.AreEqual("test", resultNode.ExpressionAttributeValues[":C0"].AsString());
        }

        [TestMethod]
        [TestCategory("DynamoDBv2")]
        public void BuildNameBuilder_AttributeExists_ReturnsCondition()
        {
            var nameBuilder = NameBuilder.New("TestAttribute");
            
            var result = nameBuilder.AttributeExists();
            var resultNode = result.Build();
            
            Assert.IsNotNull(resultNode);
            Assert.AreEqual("attribute_exists (#C0)", resultNode.ExpressionStatement);
            // Assert ExpressionAttributeNames
            Assert.AreEqual(1, resultNode.ExpressionAttributeNames.Count);
            Assert.AreEqual("TestAttribute", resultNode.ExpressionAttributeNames["#C0"]);

            // Assert ExpressionAttributeValues
            Assert.AreEqual(0, resultNode.ExpressionAttributeValues.Count);
        }

        [TestMethod]
        [TestCategory("DynamoDBv2")]
        public void BuildNameBuilder_AttributeNotExists_ReturnsCondition()
        {
            var nameBuilder = NameBuilder.New("TestAttribute");
            
            var result = nameBuilder.AttributeNotExists();
            var resultNode = result.Build();
            
            Assert.IsNotNull(resultNode);
            Assert.AreEqual("attribute_not_exists (#C0)", resultNode.ExpressionStatement);
            // Assert ExpressionAttributeNames
            Assert.AreEqual(1, resultNode.ExpressionAttributeNames.Count);
            Assert.AreEqual("TestAttribute", resultNode.ExpressionAttributeNames["#C0"]);

            // Assert ExpressionAttributeValues
            Assert.AreEqual(0, resultNode.ExpressionAttributeValues.Count);
        }

        [TestMethod]
        [TestCategory("DynamoDBv2")]
        public void BuildNameBuilder_AttributeType_ReturnsCondition()
        {
            var nameBuilder = NameBuilder.New("TestAttribute");
            
            var result = nameBuilder.AttributeType(DynamoDBAttributeType.B);
            var resultNode = result.Build();
            
            Assert.IsNotNull(resultNode);
            Assert.AreEqual("attribute_type (#C0, :C0)", resultNode.ExpressionStatement);
            // Assert ExpressionAttributeNames
            Assert.AreEqual(1, resultNode.ExpressionAttributeNames.Count);
            Assert.AreEqual("TestAttribute", resultNode.ExpressionAttributeNames["#C0"]);

            // Assert ExpressionAttributeValues
            Assert.AreEqual(1, resultNode.ExpressionAttributeValues.Count);
            Assert.AreEqual(DynamoDBAttributeType.B.Value, resultNode.ExpressionAttributeValues[":C0"].AsString());
        }

        [TestMethod]
        [TestCategory("DynamoDBv2")]
        public void ConditionExpressionBuilder_And_ReturnsCondition()
        {
            var result = ConditionExpressionBuilder.
                And(NameBuilder.New("Attribute1").Equal(10),
                NameBuilder.New("Attribute2").Equal(10));

            var resultNode = result.Build();
            
            Assert.IsNotNull(result);
            Assert.AreEqual("(#C0 = :C0) AND (#C1 = :C1)", resultNode.ExpressionStatement);
            // Assert ExpressionAttributeNames
            Assert.AreEqual(2, resultNode.ExpressionAttributeNames.Count);
            Assert.AreEqual("Attribute1", resultNode.ExpressionAttributeNames["#C0"]);
            Assert.AreEqual("Attribute2", resultNode.ExpressionAttributeNames["#C1"]);

            // Assert ExpressionAttributeValues
            Assert.AreEqual(2, resultNode.ExpressionAttributeValues.Count);
            Assert.AreEqual(10, resultNode.ExpressionAttributeValues[":C0"]);
            Assert.AreEqual(10, resultNode.ExpressionAttributeValues[":C1"]);
        }

        [TestMethod]
        [TestCategory("DynamoDBv2")]
        public void ConditionExpressionBuilder_And_Multiple_ReturnsCondition()
        {
            
            var result = ConditionExpressionBuilder.And(NameBuilder.New("Attribute1").Equal(10),
                NameBuilder.New("Attribute2").Equal(10),
                NameBuilder.New("Attribute3").Equal(10),
                NameBuilder.New("Attribute4").Equal(10));

            var resultNode = result.Build();
            
            Assert.IsNotNull(resultNode);
            Assert.AreEqual("(#C0 = :C0) AND (#C1 = :C1) AND (#C2 = :C2) AND (#C3 = :C3)", resultNode.ExpressionStatement);

            // Assert ExpressionAttributeNames
            Assert.AreEqual(4, resultNode.ExpressionAttributeNames.Count);
            Assert.AreEqual("Attribute1", resultNode.ExpressionAttributeNames["#C0"]);
            Assert.AreEqual("Attribute2", resultNode.ExpressionAttributeNames["#C1"]);
            Assert.AreEqual("Attribute3", resultNode.ExpressionAttributeNames["#C2"]);
            Assert.AreEqual("Attribute4", resultNode.ExpressionAttributeNames["#C3"]);

            // Assert ExpressionAttributeValues
            Assert.AreEqual(4, resultNode.ExpressionAttributeValues.Count);
            Assert.AreEqual(10, resultNode.ExpressionAttributeValues[":C0"]);
            Assert.AreEqual(10, resultNode.ExpressionAttributeValues[":C1"]);
            Assert.AreEqual(10, resultNode.ExpressionAttributeValues[":C2"]);
            Assert.AreEqual(10, resultNode.ExpressionAttributeValues[":C3"]);
        }

        [TestMethod]
        [TestCategory("DynamoDBv2")]
        public void ConditionExpressionBuilder_Or_ReturnsCondition()
        {
            var result = ConditionExpressionBuilder.Or(NameBuilder.New("Attribute1").Equal(10),
                NameBuilder.New("Attribute2").Equal(20));

            var resultNode = result.Build();
            
            Assert.IsNotNull(result);
            Assert.AreEqual("(#C0 = :C0) OR (#C1 = :C1)", resultNode.ExpressionStatement);

            // Assert ExpressionAttributeNames
            Assert.AreEqual(2, resultNode.ExpressionAttributeNames.Count);
            Assert.AreEqual("Attribute1", resultNode.ExpressionAttributeNames["#C0"]);
            Assert.AreEqual("Attribute2", resultNode.ExpressionAttributeNames["#C1"]);

            // Assert ExpressionAttributeValues
            Assert.AreEqual(2, resultNode.ExpressionAttributeValues.Count);
            Assert.AreEqual(10, resultNode.ExpressionAttributeValues[":C0"]);
            Assert.AreEqual(20, resultNode.ExpressionAttributeValues[":C1"]);
        }

        [TestMethod]
        [TestCategory("DynamoDBv2")]
        public void ConditionExpressionBuilder_Or_Multiple_ReturnsCondition()
        {
            var result = ConditionExpressionBuilder.Or(NameBuilder.New("Attribute1").Equal(10),
                NameBuilder.New("Attribute2").Equal(20),
                NameBuilder.New("Attribute3").Equal(30),
                NameBuilder.New("Attribute4").Equal(40));

            var resultNode = result.Build();
            
            Assert.IsNotNull(resultNode);
            Assert.AreEqual("(#C0 = :C0) OR (#C1 = :C1) OR (#C2 = :C2) OR (#C3 = :C3)", resultNode.ExpressionStatement);

            // Assert ExpressionAttributeNames
            Assert.AreEqual(4, resultNode.ExpressionAttributeNames.Count);
            Assert.AreEqual("Attribute1", resultNode.ExpressionAttributeNames["#C0"]);
            Assert.AreEqual("Attribute2", resultNode.ExpressionAttributeNames["#C1"]);
            Assert.AreEqual("Attribute3", resultNode.ExpressionAttributeNames["#C2"]);
            Assert.AreEqual("Attribute4", resultNode.ExpressionAttributeNames["#C3"]);

            // Assert ExpressionAttributeValues
            Assert.AreEqual(4, resultNode.ExpressionAttributeValues.Count);
            Assert.AreEqual(10, resultNode.ExpressionAttributeValues[":C0"]);
            Assert.AreEqual(20, resultNode.ExpressionAttributeValues[":C1"]);
            Assert.AreEqual(30, resultNode.ExpressionAttributeValues[":C2"]);
            Assert.AreEqual(40, resultNode.ExpressionAttributeValues[":C3"]);
        }

        [TestMethod]
        [TestCategory("DynamoDBv2")]
        public void ConditionExpressionBuilder_AndNestedOr_ReturnsCondition()
        {
            var result = ConditionExpressionBuilder.
                And(NameBuilder.New("Attribute1").Equal(10),
                ConditionExpressionBuilder.Or(NameBuilder.New("Attribute2").Equal(20),
                    NameBuilder.New("Attribute3").Equal(30)));

            var resultNode = result.Build();
            
            Assert.IsNotNull(resultNode);
            Assert.AreEqual("(#C0 = :C0) AND ((#C1 = :C1) OR (#C2 = :C2))", resultNode.ExpressionStatement);

            // Assert ExpressionAttributeNames
            Assert.AreEqual(3, resultNode.ExpressionAttributeNames.Count);
            Assert.AreEqual("Attribute1", resultNode.ExpressionAttributeNames["#C0"]);
            Assert.AreEqual("Attribute2", resultNode.ExpressionAttributeNames["#C1"]);
            Assert.AreEqual("Attribute3", resultNode.ExpressionAttributeNames["#C2"]);

            // Assert ExpressionAttributeValues
            Assert.AreEqual(3, resultNode.ExpressionAttributeValues.Count);
            Assert.AreEqual(10, resultNode.ExpressionAttributeValues[":C0"]);
            Assert.AreEqual(20, resultNode.ExpressionAttributeValues[":C1"]);
            Assert.AreEqual(30, resultNode.ExpressionAttributeValues[":C2"]);
        }

        [TestMethod]
        [TestCategory("DynamoDBv2")]
        public void ConditionExpressionBuilder_AndOr_ReturnsCondition()
        {
            var result = ConditionExpressionBuilder.
                And(NameBuilder.New("Attribute1").Equal(10),
                NameBuilder.New("Attribute2").Equal(20)).Or(
                    NameBuilder.New("Attribute3").Equal(30));

            var resultNode = result.Build();
            
            Assert.IsNotNull(resultNode);
            Assert.AreEqual("((#C0 = :C0) AND (#C1 = :C1)) OR (#C2 = :C2)", resultNode.ExpressionStatement);

            // Assert ExpressionAttributeNames
            Assert.AreEqual(3, resultNode.ExpressionAttributeNames.Count);
            Assert.AreEqual("Attribute1", resultNode.ExpressionAttributeNames["#C0"]);
            Assert.AreEqual("Attribute2", resultNode.ExpressionAttributeNames["#C1"]);
            Assert.AreEqual("Attribute3", resultNode.ExpressionAttributeNames["#C2"]);

            // Assert ExpressionAttributeValues
            Assert.AreEqual(3, resultNode.ExpressionAttributeValues.Count);
            Assert.AreEqual(10, resultNode.ExpressionAttributeValues[":C0"]);
            Assert.AreEqual(20, resultNode.ExpressionAttributeValues[":C1"]);
            Assert.AreEqual(30, resultNode.ExpressionAttributeValues[":C2"]);
        }

        [TestMethod]
        [TestCategory("DynamoDBv2")]
        public void ConditionExpressionBuilder_Not_ReturnsCondition()
        {
            var result = ConditionExpressionBuilder.
                Not(NameBuilder.New("Attribute1").Equal(10));
            
            var resultNode = result.Build();
            
            Assert.IsNotNull(resultNode);
            Assert.AreEqual("NOT (#C0 = :C0)", resultNode.ExpressionStatement);
            // Assert ExpressionAttributeNames
            Assert.AreEqual(1, resultNode.ExpressionAttributeNames.Count);
            Assert.AreEqual("Attribute1", resultNode.ExpressionAttributeNames["#C0"]);

            // Assert ExpressionAttributeValues
            Assert.AreEqual(1, resultNode.ExpressionAttributeValues.Count);
            Assert.AreEqual(10, resultNode.ExpressionAttributeValues[":C0"]);
        }

        [TestMethod]
        [TestCategory("DynamoDBv2")]
        public void KeyExpressionBuilder_Equal_ReturnsKeyCondition()
        {
            var result = NameBuilder.New("PK").KeyEqual("user123");
            var resultNode = result.Build();
            
            Assert.IsNotNull(resultNode);
            Assert.AreEqual("#K0 = :K0", resultNode.ExpressionStatement);
            Assert.AreEqual(1, resultNode.ExpressionAttributeNames.Count);
            Assert.AreEqual("PK", resultNode.ExpressionAttributeNames["#K0"]);
            Assert.AreEqual(1, resultNode.ExpressionAttributeValues.Count);
            Assert.AreEqual("user123", resultNode.ExpressionAttributeValues[":K0"].AsString());
        }

        [TestMethod]
        [TestCategory("DynamoDBv2")]
        public void KeyExpressionBuilder_LessThan_ReturnsKeyCondition()
        {
            var result = NameBuilder.New("SK").KeyLessThan(100);
            var resultNode = result.Build();
            
            Assert.IsNotNull(resultNode);
            Assert.AreEqual("#K0 < :K0", resultNode.ExpressionStatement);
            Assert.AreEqual(1, resultNode.ExpressionAttributeNames.Count);
            Assert.AreEqual("SK", resultNode.ExpressionAttributeNames["#K0"]);
            Assert.AreEqual(1, resultNode.ExpressionAttributeValues.Count);
            Assert.AreEqual(100, resultNode.ExpressionAttributeValues[":K0"]);
        }

        [TestMethod]
        [TestCategory("DynamoDBv2")]
        public void KeyExpressionBuilder_LessThanOrEqual_ReturnsKeyCondition()
        {
            var result = NameBuilder.New("SK").KeyLessThanOrEqual(50);
            var resultNode = result.Build();
            
            Assert.IsNotNull(resultNode);
            Assert.AreEqual("#K0 <= :K0", resultNode.ExpressionStatement);
            Assert.AreEqual(1, resultNode.ExpressionAttributeNames.Count);
            Assert.AreEqual("SK", resultNode.ExpressionAttributeNames["#K0"]);
            Assert.AreEqual(1, resultNode.ExpressionAttributeValues.Count);
            Assert.AreEqual(50, resultNode.ExpressionAttributeValues[":K0"]);
        }

        [TestMethod]
        [TestCategory("DynamoDBv2")]
        public void KeyExpressionBuilder_GreaterThan_ReturnsKeyCondition()
        {
            var result = NameBuilder.New("SK").KeyGreaterThan(25);
            var resultNode = result.Build();
            
            Assert.IsNotNull(resultNode);
            Assert.AreEqual("#K0 > :K0", resultNode.ExpressionStatement);
            Assert.AreEqual(1, resultNode.ExpressionAttributeNames.Count);
            Assert.AreEqual("SK", resultNode.ExpressionAttributeNames["#K0"]);
            Assert.AreEqual(1, resultNode.ExpressionAttributeValues.Count);
            Assert.AreEqual(25, resultNode.ExpressionAttributeValues[":K0"]);
        }

        [TestMethod]
        [TestCategory("DynamoDBv2")]
        public void KeyExpressionBuilder_GreaterThanOrEqual_ReturnsKeyCondition()
        {
            var result = NameBuilder.New("SK").KeyGreaterThanOrEqual(75);
            var resultNode = result.Build();
            
            Assert.IsNotNull(resultNode);
            Assert.AreEqual("#K0 >= :K0", resultNode.ExpressionStatement);
            Assert.AreEqual(1, resultNode.ExpressionAttributeNames.Count);
            Assert.AreEqual("SK", resultNode.ExpressionAttributeNames["#K0"]);
            Assert.AreEqual(1, resultNode.ExpressionAttributeValues.Count);
            Assert.AreEqual(75, resultNode.ExpressionAttributeValues[":K0"]);
        }

        [TestMethod]
        [TestCategory("DynamoDBv2")]
        public void KeyExpressionBuilder_Between_ReturnsKeyCondition()
        {
            var result = NameBuilder.New("SK").KeyBetween(10, 90);
            var resultNode = result.Build();
            
            Assert.IsNotNull(resultNode);
            Assert.AreEqual("#K0 BETWEEN :K0 AND :K1", resultNode.ExpressionStatement);
            Assert.AreEqual(1, resultNode.ExpressionAttributeNames.Count);
            Assert.AreEqual("SK", resultNode.ExpressionAttributeNames["#K0"]);
            Assert.AreEqual(2, resultNode.ExpressionAttributeValues.Count);
            Assert.AreEqual(10, resultNode.ExpressionAttributeValues[":K0"]);
            Assert.AreEqual(90, resultNode.ExpressionAttributeValues[":K1"]);
        }

        [TestMethod]
        [TestCategory("DynamoDBv2")]
        public void KeyExpressionBuilder_BeginsWith_ReturnsKeyCondition()
        {
            var result = NameBuilder.New("SK").KeyBeginsWith("prefix");
            var resultNode = result.Build();
            
            Assert.IsNotNull(resultNode);
            Assert.AreEqual("begins_with (#K0, :K0)", resultNode.ExpressionStatement);
            Assert.AreEqual(1, resultNode.ExpressionAttributeNames.Count);
            Assert.AreEqual("SK", resultNode.ExpressionAttributeNames["#K0"]);
            Assert.AreEqual(1, resultNode.ExpressionAttributeValues.Count);
            Assert.AreEqual("prefix", resultNode.ExpressionAttributeValues[":K0"].AsString());
        }

        [TestMethod]
        [TestCategory("DynamoDBv2")]
        public void KeyExpressionBuilder_And_ReturnsKeyCondition()
        {
            var result = NameBuilder.New("PK").KeyEqual("user123")
                .And(NameBuilder.New("SK").KeyGreaterThan(50));
            var resultNode = result.Build();
            
            Assert.IsNotNull(resultNode);
            Assert.AreEqual("(#K0 = :K0) AND (#K1 > :K1)", resultNode.ExpressionStatement);
            Assert.AreEqual(2, resultNode.ExpressionAttributeNames.Count);
            Assert.AreEqual("PK", resultNode.ExpressionAttributeNames["#K0"]);
            Assert.AreEqual("SK", resultNode.ExpressionAttributeNames["#K1"]);
            Assert.AreEqual(2, resultNode.ExpressionAttributeValues.Count);
            Assert.AreEqual("user123", resultNode.ExpressionAttributeValues[":K0"].AsString());
            Assert.AreEqual(50, resultNode.ExpressionAttributeValues[":K1"]);
        }

        [TestMethod]
        [TestCategory("DynamoDBv2")]
        public void KeyExpressionBuilder_StaticAnd_ReturnsKeyCondition()
        {
            var result = KeyExpressionBuilder.And(
                NameBuilder.New("PK").KeyEqual("user123"),
                NameBuilder.New("SK").KeyLessThan(100));
            var resultNode = result.Build();
            
            Assert.IsNotNull(resultNode);
            Assert.AreEqual("(#K0 = :K0) AND (#K1 < :K1)", resultNode.ExpressionStatement);
            Assert.AreEqual(2, resultNode.ExpressionAttributeNames.Count);
            Assert.AreEqual("PK", resultNode.ExpressionAttributeNames["#K0"]);
            Assert.AreEqual("SK", resultNode.ExpressionAttributeNames["#K1"]);
            Assert.AreEqual(2, resultNode.ExpressionAttributeValues.Count);
            Assert.AreEqual("user123", resultNode.ExpressionAttributeValues[":K0"].AsString());
            Assert.AreEqual(100, resultNode.ExpressionAttributeValues[":K1"]);
        }

        [TestMethod]
        [TestCategory("DynamoDBv2")]
        public void KeyExpressionBuilder_WithName_ReturnsNameBuilder()
        {
            var keyBuilder = KeyExpressionBuilder.New();
            var nameBuilder = keyBuilder.WithName("TestAttribute");
            
            Assert.IsNotNull(nameBuilder);
            Assert.IsInstanceOfType(nameBuilder, typeof(NameBuilder));
        }

        [TestMethod]
        [TestCategory("DynamoDBv2")]
        public void KeyExpressionBuilder_WithName_ComplexPath_ReturnsNameBuilder()
        {
            var keyBuilder = KeyExpressionBuilder.New();
            var nameBuilder = keyBuilder.WithName("parent.child[0].attribute");
            
            Assert.IsNotNull(nameBuilder);
            Assert.IsInstanceOfType(nameBuilder, typeof(NameBuilder));
        }

        [TestMethod]
        [TestCategory("DynamoDBv2")]
        public void KeyExpressionBuilder_StaticEqual_WithOperands_ReturnsKeyCondition()
        {
            var nameOperand = NameBuilder.New("PK");
            var valueOperand = ValueBuilder.New("user456");
            var result = KeyExpressionBuilder.Equal(nameOperand, valueOperand);
            var resultNode = result.Build();
            
            Assert.IsNotNull(resultNode);
            Assert.AreEqual("#K0 = :K0", resultNode.ExpressionStatement);
            Assert.AreEqual(1, resultNode.ExpressionAttributeNames.Count);
            Assert.AreEqual("PK", resultNode.ExpressionAttributeNames["#K0"]);
            Assert.AreEqual(1, resultNode.ExpressionAttributeValues.Count);
            Assert.AreEqual("user456", resultNode.ExpressionAttributeValues[":K0"].AsString());
        }

        [TestMethod]
        [TestCategory("DynamoDBv2")]
        public void KeyExpressionBuilder_StaticEqual_WithNumericValue_ReturnsKeyCondition()
        {
            var nameOperand = NameBuilder.New("SK");
            var valueOperand = ValueBuilder.New(42);
            var result = KeyExpressionBuilder.Equal(nameOperand, valueOperand);
            var resultNode = result.Build();
            
            Assert.IsNotNull(resultNode);
            Assert.AreEqual("#K0 = :K0", resultNode.ExpressionStatement);
            Assert.AreEqual(1, resultNode.ExpressionAttributeNames.Count);
            Assert.AreEqual("SK", resultNode.ExpressionAttributeNames["#K0"]);
            Assert.AreEqual(1, resultNode.ExpressionAttributeValues.Count);
            Assert.AreEqual(42, resultNode.ExpressionAttributeValues[":K0"]);
        }

        [TestMethod]
        [TestCategory("DynamoDBv2")]
        public void ProjectionExpressionBuilder_WithSingleName_Builds_Correctly()
        {
            var projection = ProjectionExpressionBuilder.New()
                .WithName("Attribute1")
                .Build();

            Assert.IsNotNull(projection);
            Assert.AreEqual("#P0", projection.ExpressionStatement);
            Assert.AreEqual(1, projection.ExpressionAttributeNames.Count);
            Assert.AreEqual("Attribute1", projection.ExpressionAttributeNames["#P0"]);
            Assert.AreEqual(0, projection.ExpressionAttributeValues.Count);
        }

        [TestMethod]
        [TestCategory("DynamoDBv2")]
        public void ProjectionExpressionBuilder_WithComplexAttributePath_Builds_Correctly()
        {
            var projection = ProjectionExpressionBuilder.New()
                .WithName("parent.child[0].attribute")
                .Build();

            Assert.IsNotNull(projection);
            Assert.AreEqual("#P0.#P1[0].#P2", projection.ExpressionStatement);
            Assert.AreEqual(3, projection.ExpressionAttributeNames.Count);
            Assert.AreEqual("parent", projection.ExpressionAttributeNames["#P0"]);
            Assert.AreEqual("child", projection.ExpressionAttributeNames["#P1"]);
            Assert.AreEqual("attribute", projection.ExpressionAttributeNames["#P2"]);
            Assert.AreEqual(0, projection.ExpressionAttributeValues.Count);
        }
        
        [TestMethod]
        [TestCategory("DynamoDBv2")]
        public void ProjectionExpressionBuilder_WithSpecialCharacters_Builds_Correctly()
        {
            var projection = ProjectionExpressionBuilder.New()
                .WithName("Test#Attribute-Name.123")
                .Build();

            Assert.IsNotNull(projection);
            Assert.AreEqual("#P0.#P1", projection.ExpressionStatement);
            Assert.AreEqual(2, projection.ExpressionAttributeNames.Count);
            Assert.AreEqual("Test#Attribute-Name", projection.ExpressionAttributeNames["#P0"]);
            Assert.AreEqual("123", projection.ExpressionAttributeNames["#P1"]);
            Assert.AreEqual(0, projection.ExpressionAttributeValues.Count);
        }

        [TestMethod]
        [TestCategory("DynamoDBv2")]
        public void ProjectionExpressionBuilder_AddNames_WithSingleName_Build_Correctly()
        {
            var projection = ProjectionExpressionBuilder.New()
                .WithName("Attribute1")
                .AddName(NameBuilder.New("Attribute2"))
                .Build();

            Assert.IsNotNull(projection);
            Assert.AreEqual("#P0, #P1", projection.ExpressionStatement);
            Assert.AreEqual(2, projection.ExpressionAttributeNames.Count);
            Assert.AreEqual("Attribute1", projection.ExpressionAttributeNames["#P0"]);
            Assert.AreEqual("Attribute2", projection.ExpressionAttributeNames["#P1"]);
            Assert.AreEqual(0, projection.ExpressionAttributeValues.Count);
        }

        [TestMethod]
        [TestCategory("DynamoDBv2")]
        public void ProjectionExpressionBuilder_AddNames_WithComplexAttributePath_Build_Correctly()
        {
            var projection = ProjectionExpressionBuilder.New()
                .WithName("parent.child[0].attribute1")
                .AddName(NameBuilder.New("test.attribute2"))
                .Build();

            Assert.IsNotNull(projection);
            Assert.AreEqual("#P0.#P1[0].#P2, #P3.#P4", projection.ExpressionStatement);
            Assert.AreEqual(5, projection.ExpressionAttributeNames.Count);
            Assert.AreEqual("parent", projection.ExpressionAttributeNames["#P0"]);
            Assert.AreEqual("child", projection.ExpressionAttributeNames["#P1"]);
            Assert.AreEqual("attribute1", projection.ExpressionAttributeNames["#P2"]);
            Assert.AreEqual("test", projection.ExpressionAttributeNames["#P3"]);
            Assert.AreEqual("attribute2", projection.ExpressionAttributeNames["#P4"]);
            Assert.AreEqual(0, projection.ExpressionAttributeValues.Count);
        }

        [TestMethod]
        [TestCategory("DynamoDBv2")]
        public void ProjectionExpressionBuilder_NamesList_WithSingleName_Build_Correctly()
        {
            var projection = ProjectionExpressionBuilder.New()
                .NamesList(NameBuilder.New("Attribute1"), NameBuilder.New("Attribute2"))
                .AddName(NameBuilder.New("Attribute3"))
                .Build();

            Assert.IsNotNull(projection);
            Assert.AreEqual("#P0, #P1, #P2", projection.ExpressionStatement);
            Assert.AreEqual(3, projection.ExpressionAttributeNames.Count);
            Assert.AreEqual("Attribute1", projection.ExpressionAttributeNames["#P0"]);
            Assert.AreEqual("Attribute2", projection.ExpressionAttributeNames["#P1"]);
            Assert.AreEqual("Attribute3", projection.ExpressionAttributeNames["#P2"]);
            Assert.AreEqual(0, projection.ExpressionAttributeValues.Count);
        }

        [TestMethod]
        [TestCategory("DynamoDBv2")]
        public void ProjectionExpressionBuilder_NamesList_WithComplexAttributePath_Build_Correctly()
        {
            var projection = ProjectionExpressionBuilder.New()
                .NamesList(NameBuilder.New("parent.child[0].attribute1"), NameBuilder.New("Attribute2"))
                .WithName("parent.child[1].attribute3")
                .Build();

            Assert.IsNotNull(projection);
            Assert.AreEqual("#P0.#P1[0].#P2, #P3, #P4.#P5[1].#P6", projection.ExpressionStatement);
            Assert.AreEqual(7, projection.ExpressionAttributeNames.Count);
            Assert.AreEqual("parent", projection.ExpressionAttributeNames["#P0"]);
            Assert.AreEqual("child", projection.ExpressionAttributeNames["#P1"]);
            Assert.AreEqual("attribute1", projection.ExpressionAttributeNames["#P2"]);
            Assert.AreEqual("Attribute2", projection.ExpressionAttributeNames["#P3"]);
            Assert.AreEqual("parent", projection.ExpressionAttributeNames["#P4"]);
            Assert.AreEqual("child", projection.ExpressionAttributeNames["#P5"]);
            Assert.AreEqual("attribute3", projection.ExpressionAttributeNames["#P6"]);
            Assert.AreEqual(0, projection.ExpressionAttributeValues.Count);
        }

        [TestMethod]
        [ExpectedException(typeof(InvalidOperationException))]
        public void BuildProjectionExpressionBuilder_WithNoAttributeNames_ShouldThrowException()
        {
            var projectionBuilder = ProjectionExpressionBuilder.New();
            projectionBuilder.Build();
        }
    }
}