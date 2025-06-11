using Amazon.DynamoDBv2.DataModel;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using Amazon.DynamoDBv2.DocumentModel;
using Expression = System.Linq.Expressions.Expression;

namespace AWSSDK_DotNet.UnitTests
{
    [TestClass]
    public class ContextExpressionsUtilsTests
    {
        [TestMethod]
        [DataRow(QueryOperator.Equal, " AND myKey = :rangeKey0")]
        [DataRow(QueryOperator.LessThan, " AND myKey < :rangeKey0")]
        [DataRow(QueryOperator.LessThanOrEqual, " AND myKey <= :rangeKey0")]
        [DataRow(QueryOperator.GreaterThan, " AND myKey > :rangeKey0")]
        [DataRow(QueryOperator.GreaterThanOrEqual, " AND myKey >= :rangeKey0")]
        [DataRow(QueryOperator.Between, " AND myKey BETWEEN :rangeKey0 AND :rangeKey0")]
        [DataRow(QueryOperator.BeginsWith, " AND begins_with(myKey, :rangeKey0)")]
        public void GetRangeKeyConditionExpression_ReturnsExpected(QueryOperator op, string expected)
        {
            var result = ContextExpressionsUtils.GetRangeKeyConditionExpression("myKey", op);
            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        public void GetRangeKeyConditionExpression_ThrowsOnUnsupported()
        {
            Assert.ThrowsException<NotSupportedException>(() =>
                ContextExpressionsUtils.GetRangeKeyConditionExpression("myKey", (QueryOperator)999));
        }

        [TestMethod]
        public void IsMember_ReturnsTrueForMemberExpression()
        {
            Expression<Func<object>> expr = () => "".Length;
            Assert.IsTrue(ContextExpressionsUtils.IsMember(expr.Body));
        }

        [TestMethod]
        public void IsMember_ReturnsTrueForUnaryMemberExpression()
        {
            Expression<Func<object>> expr = () => (object)"".Length;
            Assert.IsTrue(ContextExpressionsUtils.IsMember(expr.Body));
        }

        [TestMethod]
        public void IsMember_ReturnsFalseForOtherExpressions()
        {
            Expression<Func<int>> expr = () => 5 + 3;
            Assert.IsFalse(ContextExpressionsUtils.IsMember(expr.Body));
        }

        [TestMethod]
        public void GetConstant_ReturnsConstantExpression()
        {
            var constExpr = Expression.Constant(42);
            var result = ContextExpressionsUtils.GetConstant(constExpr);
            Assert.AreEqual(constExpr, result);
        }

        [TestMethod]
        public void GetConstant_ReturnsConstantFromUnary()
        {
            var constExpr = Expression.Constant(42);
            var unaryExpr = Expression.Convert(constExpr, typeof(object));
            var result = ContextExpressionsUtils.GetConstant(unaryExpr);
            Assert.AreEqual(constExpr, result);
        }

        [TestMethod]
        public void GetConstant_ReturnsNullForUnsupported()
        {
            var paramExpr = Expression.Parameter(typeof(int), "x");
            Assert.IsNull(ContextExpressionsUtils.GetConstant(paramExpr));
        }

        [TestMethod]
        public void IsComparison_ReturnsTrueForComparisonTypes()
        {
            Assert.IsTrue(ContextExpressionsUtils.IsComparison(ExpressionType.Equal));
            Assert.IsTrue(ContextExpressionsUtils.IsComparison(ExpressionType.NotEqual));
            Assert.IsTrue(ContextExpressionsUtils.IsComparison(ExpressionType.GreaterThan));
            Assert.IsTrue(ContextExpressionsUtils.IsComparison(ExpressionType.GreaterThanOrEqual));
            Assert.IsTrue(ContextExpressionsUtils.IsComparison(ExpressionType.LessThan));
            Assert.IsTrue(ContextExpressionsUtils.IsComparison(ExpressionType.LessThanOrEqual));
        }

        [TestMethod]
        public void IsComparison_ReturnsFalseForOtherTypes()
        {
            Assert.IsFalse(ContextExpressionsUtils.IsComparison(ExpressionType.Add));
        }

        [TestMethod]
        public void GetMember_ReturnsNullForNonMember()
        {
            Expression<Func<int>> expr = () => 5 + 3;
            Assert.IsNull(ContextExpressionsUtils.GetMember(expr.Body));
        }

        [TestMethod]
        public void ExtractPathNodes_PropertyPath()
        {
            Expression<Func<Dummy, int>> expr = d => d.Child.Value;
            var nodes = ContextExpressionsUtils.ExtractPathNodes(expr.Body);
            Assert.AreEqual(2, nodes.Count);
            Assert.AreEqual("Child", nodes[0].Path);
            Assert.AreEqual("Value", nodes[1].Path);
        }

        [TestMethod]
        public void ExtractPathNodes_ListIndexer()
        {
            Expression<Func<ComplexDummy, int>> expr = d => d.Children[2].Value;
            var nodes = ContextExpressionsUtils.ExtractPathNodes(expr.Body);
            Assert.AreEqual(2, nodes.Count);
            Assert.AreEqual("Children", nodes[0].Path);
            Assert.AreEqual(1, nodes[0].IndexDepth);
            Assert.AreEqual("Value", nodes[1].Path);
        }

        [TestMethod]
        public void ExtractPathNodes_NestedListIndexer()
        {
            Expression<Func<ComplexDummy, int>> expr = d => d.Children[1].Child.Value;
            var nodes = ContextExpressionsUtils.ExtractPathNodes(expr.Body);
            Assert.AreEqual(3, nodes.Count);
            Assert.AreEqual("Children", nodes[0].Path);
            Assert.AreEqual(1, nodes[0].IndexDepth);
            Assert.AreEqual("Child", nodes[1].Path);
            Assert.AreEqual("Value", nodes[2].Path);
        }

        [TestMethod]
        public void ExtractPathNodes_DictionaryStringIndexer()
        {
            Expression<Func<ComplexDummy, int>> expr = d => d.Map["foo"].Value;
            var nodes = ContextExpressionsUtils.ExtractPathNodes(expr.Body);
            Assert.AreEqual(3, nodes.Count);
            Assert.AreEqual("Map", nodes[0].Path);
            Assert.AreEqual("foo", nodes[1].Path);
            Assert.IsTrue(nodes[1].IsMap);
            Assert.AreEqual("Value", nodes[2].Path);
        }

        [TestMethod]
        [ExpectedException(typeof(NotSupportedException))]
        public void ExtractPathNodes_UnsupportedMethodCall_Throws()
        {
            Expression<Func<List<int>, int>> expr = l => l.Sum();
            ContextExpressionsUtils.ExtractPathNodes(expr.Body);
        }

        [TestMethod]
        public void ExtractPathNodes_ConversionExpression()
        {
            Expression<Func<Dummy, object>> expr = d => (object)d.Value;
            var nodes = ContextExpressionsUtils.ExtractPathNodes(expr.Body);
            Assert.AreEqual(1, nodes.Count);
            Assert.AreEqual("Value", nodes[0].Path);
        }

        [TestMethod]
        public void ExtractPathNodes_FirstOrDefault()
        {
            Expression<Func<ComplexDummy, int>> expr = d => d.Children.FirstOrDefault().Value;
            var nodes = ContextExpressionsUtils.ExtractPathNodes(expr.Body);
            Assert.AreEqual(2, nodes.Count);
            Assert.AreEqual("Children", nodes[0].Path);
            Assert.AreEqual(1, nodes[0].IndexDepth);
            Assert.AreEqual("Value", nodes[1].Path);
        }

        class Dummy { public Dummy Child { get; set; } public int Value { get; set; } }

        class ComplexDummy
        {
            public List<Dummy> Children { get; set; }
            public Dictionary<string, Dummy> Map { get; set; }
            public Dummy Child { get; set; }
        }
    }
}