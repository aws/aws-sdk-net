using Amazon.DynamoDBv2.DocumentModel;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

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
    }

}