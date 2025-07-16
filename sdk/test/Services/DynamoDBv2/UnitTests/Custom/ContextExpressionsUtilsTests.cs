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
            Assert.AreEqual(42, result);
        }

        [TestMethod]
        public void GetConstant_ReturnsConstantFromUnary()
        {
            var constExpr = Expression.Constant(42);
            var unaryExpr = Expression.Convert(constExpr, typeof(object));
            var result = ContextExpressionsUtils.GetConstant(unaryExpr);
            Assert.AreEqual(42, result);
        }

        [TestMethod]
        public void GetConstant_ReturnsNullForUnsupported()
        {
            var paramExpr = Expression.Parameter(typeof(int), "x");
            Assert.ThrowsException<NotSupportedException>(() => ContextExpressionsUtils.GetConstant(paramExpr));
        }

        [TestMethod]
        public void GetConstant_ReturnsConstantFromMember_Field()
        {
            var testObj = new TestClass { Field = 123 };
            Expression<Func<int>> expr = () => testObj.Field;
            var memberExpr = (MemberExpression)expr.Body;
            var result = ContextExpressionsUtils.GetConstant(memberExpr);
            Assert.IsNotNull(result);
            Assert.AreEqual(123, result);
        }

        [TestMethod]
        public void GetConstant_ReturnsConstantFromMember_Property()
        {
            var testObj = new TestClass { Property = 456 };
            Expression<Func<int>> expr = () => testObj.Property;
            var memberExpr = (MemberExpression)expr.Body;
            var result = ContextExpressionsUtils.GetConstant(memberExpr);
            Assert.IsNotNull(result);
            Assert.AreEqual(456, result);
        }

        [TestMethod]
        public void GetConstant_ReturnsInstanceOfType()
        {
            Expression expr = Expression.New(typeof(TestClass));
            var result=ContextExpressionsUtils.GetConstant(expr);
            Assert.IsNotNull(result);
            Assert.IsInstanceOfType(result, typeof(TestClass));
        }

        [TestMethod]
        public void GetConstant_ReturnsConstantFromNestedMember()
        {
            var inner = new TestClass { Field = 99, Property = 100 };
            var outer = new NestedTestClass { Inner = inner };
            Expression<Func<int>> expr = () => outer.Inner.Field;
            var memberExpr = (MemberExpression)expr.Body;
            var result = ContextExpressionsUtils.GetConstant(memberExpr);
            Assert.IsNotNull(result);
            Assert.AreEqual(99, result);
        }

        [TestMethod]
        public void GetConstant_ReturnsStaticField()
        {
            Expression expr = Expression.Field(null, typeof(Math).GetField(nameof(Math.PI)));
            var result = ContextExpressionsUtils.GetConstant(expr);
            Assert.AreEqual(Math.PI, result);
        }

        [TestMethod]
        public void GetConstant_ReturnsStaticProperty()
        {
            Expression expr = Expression.Property(null, typeof(DateTime).GetProperty(nameof(DateTime.Now)));
            var result = ContextExpressionsUtils.GetConstant(expr);
            Assert.IsInstanceOfType(result, typeof(DateTime));
        }

        [TestMethod]
        public void GetConstant_ReturnsListIndexer()
        {
            var list = new List<int> { 10, 20, 30 };
            Expression expr = Expression.Call(
                Expression.Constant(list),
                typeof(List<int>).GetMethod("get_Item"),
                Expression.Constant(1));
            var result = ContextExpressionsUtils.GetConstant(expr);
            Assert.AreEqual(20, result);
        }

        [TestMethod]
        public void GetConstant_ReturnsDictionaryIndexer()
        {
            var dict = new Dictionary<string, int> { { "a", 1 }, { "b", 2 } };
            Expression expr = Expression.Call(
                Expression.Constant(dict),
                typeof(Dictionary<string, int>).GetMethod("get_Item"),
                Expression.Constant("b"));
            var result = ContextExpressionsUtils.GetConstant(expr);
            Assert.AreEqual(2, result);
        }

        [TestMethod]
        public void GetConstant_ReturnsMethodCallWithArguments()
        {
            var str = "hello";
            Expression expr = Expression.Call(
                Expression.Constant(str),
                typeof(string).GetMethod("Substring", new[] { typeof(int), typeof(int) }),
                Expression.Constant(1),
                Expression.Constant(2));
            var result = ContextExpressionsUtils.GetConstant(expr);
            Assert.AreEqual("el", result);
        }

        [TestMethod]
        public void GetConstant_ReturnsStaticMethodCall()
        {
            Expression expr = Expression.Call(
                null,
                typeof(string).GetMethod("IsNullOrEmpty", new[] { typeof(string) }),
                Expression.Constant(""));
            var result = ContextExpressionsUtils.GetConstant(expr);
            Assert.AreEqual(true, result);
        }

        [TestMethod]
        public void GetConstant_ReturnsUnaryConvertToString()
        {
            var constExpr = Expression.Constant(123);
            var unaryExpr = Expression.Convert(constExpr, typeof(string), typeof(Convert).GetMethod("ToString", new[] { typeof(int) }));
            var result = ContextExpressionsUtils.GetConstant(unaryExpr);
            Assert.AreEqual("123", result.ToString());
        }

        [TestMethod]
        public void GetConstant_ReturnsNewExpressionWithArguments()
        {
            Expression expr = Expression.New(typeof(TimeSpan).GetConstructor(new[] { typeof(int), typeof(int), typeof(int) }),
                Expression.Constant(1), Expression.Constant(2), Expression.Constant(3));
            var result = ContextExpressionsUtils.GetConstant(expr);
            Assert.AreEqual(new TimeSpan(1, 2, 3), result);
        }

        class NestedTestClass
        {
            public TestClass Inner { get; set; }
        }

        class TestClass
        {
            public int Field;
            public int Property { get; set; }
            public List<bool> Array { get; set; }
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
        public void GetMember_ReturnsMemberExpression_Direct()
        {
            Expression<Func<TestClass, int>> expr = t => t.Field;
            var memberExpr = expr.Body as MemberExpression;
            var result = ContextExpressionsUtils.GetMember(expr.Body);
            Assert.AreEqual(memberExpr, result);
        }

        [TestMethod]
        public void GetMember_ReturnsMemberExpression_FromUnary()
        {
            Expression<Func<TestClass, object>> expr = t => (object)t.Property;
            var result = ContextExpressionsUtils.GetMember(expr.Body);
            Assert.IsNotNull(result);
            Assert.AreEqual("Property", result.Member.Name);
        }

        [TestMethod]
        public void GetMember_ReturnsMemberExpression_FirstOrDefault()
        {
            Expression<Func<TestClass, bool>> expr = l => l.Array.FirstOrDefault() == true;
            var methodCall = expr.Body as BinaryExpression;
            var result = ContextExpressionsUtils.GetMember(methodCall.Left);
            Assert.IsNotNull(result);
            Assert.AreEqual("Array", result.Member.Name);
        }

        [TestMethod]
        public void GetMember_ReturnsMemberExpression_FromIndexer()
        {
            Expression<Func<TestClass, bool>> expr = l => l.Array[0] == true;
            var methodCall = expr.Body as BinaryExpression;
            var result = ContextExpressionsUtils.GetMember(methodCall.Left);
            Assert.IsNotNull(result);
            Assert.AreEqual("Array", result.Member.Name);
        }

        [TestMethod]
        public void GetMember_ReturnsMemberExpression_First()
        {
            Expression<Func<TestClass, bool>> expr = l => l.Array.First() == true;
            var methodCall = expr.Body as BinaryExpression;
            var result = ContextExpressionsUtils.GetMember(methodCall.Left);
            Assert.IsNotNull(result);
            Assert.AreEqual("Array", result.Member.Name);
        }

        [TestMethod]
        public void GetMember_ReturnsNull_ForNonMember()
        {
            Expression<Func<int>> expr = () => 1 + 2;
            var result = ContextExpressionsUtils.GetMember(expr.Body);
            Assert.IsNull(result);
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