#if !NETFRAMEWORK
using Amazon.DynamoDBv2;
using Amazon.DynamoDBv2.DocumentModel;
using Amazon.DynamoDBv2.Model;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;
using System;

namespace AWSSDK.UnitTests.DynamoDBv2
{
    [TestClass]
    public class DynamoDBNetStandardTests
    {
        [TestMethod]
        [TestCategory("DynamoDBv2.Model.AttributeValue")]
        public void AttributeValueIsBOOLSetTest()
        {
            var boolAV = new AttributeValue();
            Assert.IsFalse(boolAV.IsBOOLSet);
            Assert.IsFalse(boolAV.BOOL.HasValue);

            boolAV.BOOL = false;
            Assert.IsTrue(boolAV.IsBOOLSet);
            Assert.IsFalse(boolAV.BOOL.Value);

            boolAV.BOOL = true;
            Assert.IsTrue(boolAV.IsBOOLSet);
            Assert.IsTrue(boolAV.BOOL.Value);

            boolAV.IsBOOLSet = true;
            Assert.IsTrue(boolAV.IsBOOLSet);
            Assert.IsTrue(boolAV.BOOL.Value);

            boolAV.IsBOOLSet = false;
            Assert.IsFalse(boolAV.IsBOOLSet);
            Assert.IsFalse(boolAV.BOOL.HasValue);
        }

        [TestMethod]
        [TestCategory("DynamoDBv2")]
        public void TestMockingTableClient_LoadTable_Throws()
        {
            var mockClient = new Mock<IAmazonDynamoDB>();
            mockClient.Setup(x => x.Config).Returns(new AmazonDynamoDBConfig());

            Assert.ThrowsExactly<InvalidOperationException>(() => Table.LoadTable(mockClient.Object, "TestTable"));
        }
    }
}
#endif
