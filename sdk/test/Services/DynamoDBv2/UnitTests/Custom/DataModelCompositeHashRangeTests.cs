using Amazon.DynamoDBv2;
using Amazon.DynamoDBv2.DataModel;
using Amazon.DynamoDBv2.DocumentModel;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using System.Linq;

namespace AWSSDK_DotNet.UnitTests
{
    [TestClass]
    public class DataModelCompositeHashRangeTests
    {

        [TestMethod]
        public void TestQueryConditional_GSI1_HashKeyOnly()
        {
            // Arrange
            var queryConditional = QueryConditional.HashKeyEqualTo("UserName", "alice");

            // Act & Assert - This would be used with DynamoDBContext.QueryAsync<CompositeHashRangeEntity>
            Assert.IsNotNull(queryConditional);
            Assert.AreEqual(1, queryConditional.HashKeys.Count);
            Assert.AreEqual("alice", queryConditional.HashKeys["UserName"]);
        }

        [TestMethod]
        public void TestQueryConditional_GSI1_HashKeyAndRangeKey()
        {
            // Arrange
            var queryConditional = QueryConditional.HashKeyEqualTo("UserName", "alice")
                .AndRangeKeyGreaterThan("Timestamp", 1000);

            // Act & Assert
            Assert.IsNotNull(queryConditional);
            Assert.AreEqual(1, queryConditional.HashKeys.Count);
            Assert.AreEqual("alice", queryConditional.HashKeys["UserName"]);
            Assert.AreEqual(1, queryConditional.RangeValues.Count);
            Assert.IsTrue(queryConditional.RangeValues.ContainsKey("Timestamp"));
        }

        [TestMethod]
        public void TestQueryConditional_GSI2_MultipleHashKeys()
        {
            // Arrange
            var queryConditional = QueryConditional.HashKeyEqualTo("OrderId", "order-100")
                .AndHashKeyEqualTo("UserName", "bob");

            // Act & Assert
            Assert.IsNotNull(queryConditional);
            Assert.AreEqual(2, queryConditional.HashKeys.Count);
            Assert.AreEqual("order-100", queryConditional.HashKeys["OrderId"]);
            Assert.AreEqual("bob", queryConditional.HashKeys["UserName"]);
        }

        [TestMethod]
        public void TestQueryConditional_GSI2_MultipleHashKeysWithRangeKey()
        {
            // Arrange
            var queryConditional = QueryConditional.HashKeyEqualTo("OrderId", "order-100")
                .AndHashKeyEqualTo("UserName", "bob")
                .AndRangeKeyGreaterThan("Timestamp", 1000);

            // Act & Assert
            Assert.IsNotNull(queryConditional);
            Assert.AreEqual(2, queryConditional.HashKeys.Count);
            Assert.AreEqual(1, queryConditional.RangeValues.Count);
            Assert.IsTrue(queryConditional.RangeValues.ContainsKey("Timestamp"));
        }

        [TestMethod]
        public void TestQueryConditional_GSI3_MultipleHashKeysAndRangeKeys()
        {
            // Arrange
            var queryConditional = QueryConditional.HashKeyEqualTo("UserName", "bob")
                .AndHashKeyEqualTo("Region", "us-east-1")
                .AndRangeKeyEqualTo("Status", "delivered")
                .AndRangeKeyEqualTo("Category", "books");

            // Act & Assert
            Assert.IsNotNull(queryConditional);
            Assert.AreEqual(2, queryConditional.HashKeys.Count);
            Assert.AreEqual(2, queryConditional.RangeValues.Count);
            Assert.AreEqual("bob", queryConditional.HashKeys["UserName"]);
            Assert.AreEqual("us-east-1", queryConditional.HashKeys["Region"]);
            Assert.IsTrue(queryConditional.RangeValues.ContainsKey("Status"));
            Assert.IsTrue(queryConditional.RangeValues.ContainsKey("Category"));
        }

        [TestMethod]
        public void TestQueryConditional_GSI4_AllEightKeys()
        {
            // Arrange
            var queryConditional = QueryConditional.HashKeyEqualTo("Id", 2)
                .AndHashKeyEqualTo("UserName", "bob")
                .AndHashKeyEqualTo("OrderId", "order-100")
                .AndHashKeyEqualTo("Region", "us-east-1")
                .AndRangeKeyEqualTo("Status", "delivered")
                .AndRangeKeyEqualTo("Category", "books")
                .AndRangeKeyEqualTo("Amount", 150)
                .AndRangeKeyEqualTo("Priority", 3);

            // Act & Assert
            Assert.IsNotNull(queryConditional);
            Assert.AreEqual(4, queryConditional.HashKeys.Count);
            Assert.AreEqual(4, queryConditional.RangeValues.Count);
        }

        [TestMethod]
        public void TestQueryConditional_GSI4_WithNonEqualityOnRightmostRangeKey()
        {
            // Arrange
            var queryConditional = QueryConditional.HashKeyEqualTo("Id", 2)
                .AndHashKeyEqualTo("UserName", "bob")
                .AndHashKeyEqualTo("OrderId", "order-100")
                .AndHashKeyEqualTo("Region", "us-east-1")
                .AndRangeKeyEqualTo("Status", "delivered")
                .AndRangeKeyEqualTo("Category", "books")
                .AndRangeKeyEqualTo("Amount", 150)
                .AndRangeKeyGreaterThan("Priority", 2);

            // Act & Assert
            Assert.IsNotNull(queryConditional);
            Assert.AreEqual(4, queryConditional.HashKeys.Count);
            Assert.AreEqual(4, queryConditional.RangeValues.Count);
        }

        [TestMethod]
        public void TestQueryConditional_GSI3_WithBeginsWithOnRightmostRangeKey()
        {
            // Arrange
            var queryConditional = QueryConditional.HashKeyEqualTo("UserName", "bob")
                .AndHashKeyEqualTo("Region", "us-east-1")
                .AndRangeKeyEqualTo("Status", "delivered")
                .AndRangeKeyBeginsWith("Category", "book");

            // Act & Assert
            Assert.IsNotNull(queryConditional);
            Assert.AreEqual(2, queryConditional.HashKeys.Count);
            Assert.AreEqual(2, queryConditional.RangeValues.Count);
        }
    }
}