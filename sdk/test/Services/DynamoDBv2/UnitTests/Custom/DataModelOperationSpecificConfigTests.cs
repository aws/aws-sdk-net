using Amazon.DynamoDBv2.DataModel;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace AWSSDK_DotNet.UnitTests
{
    /// <summary>
    /// These tests serve as a reminder to developers and reviewers to 
    /// ensure that new DynamoDB operation-specific properties are plumbed
    /// into the internal code paths correctly
    /// </summary>
    [TestClass]
    public class DataModelOperationSpecificConfigTests
    {
        [TestMethod]
        public void BaseOperationConfig()
        {
            // If this fails because you've added a property, be sure to add it to
            // `ToDynamoDBOperationConfig` before updating this unit test
            Assert.AreEqual(6, typeof(BaseOperationConfig).GetProperties().Length);
        }

        [TestMethod]
        public void BatchGetConfig()
        {
            // If this fails because you've added a property, be sure to add it to
            // `ToDynamoDBOperationConfig` before updating this unit test
            Assert.AreEqual(8, typeof(BatchGetConfig).GetProperties().Length);
        }

        [TestMethod]
        public void BatchWriteConfig()
        {
            // If this fails because you've added a property, be sure to add it to
            // `ToDynamoDBOperationConfig` before updating this unit test
            Assert.AreEqual(8, typeof(BatchWriteConfig).GetProperties().Length);
        }

        [TestMethod]
        public void TransactGetConfig()
        {
            // If this fails because you've added a property, be sure to add it to
            // `ToDynamoDBOperationConfig` before updating this unit test
            Assert.AreEqual(7, typeof(TransactGetConfig).GetProperties().Length);
        }

        [TestMethod]
        public void TransactWriteConfig()
        {
            // If this fails because you've added a property, be sure to add it to
            // `ToDynamoDBOperationConfig` before updating this unit test
            Assert.AreEqual(7, typeof(TransactWriteConfig).GetProperties().Length);
        }
    }
}
