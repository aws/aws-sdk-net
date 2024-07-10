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
    }
}
