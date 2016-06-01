using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using Amazon.DatabaseMigrationService;
using Amazon.DatabaseMigrationService.Model;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace AWSSDK_DotNet.IntegrationTests.Tests
{
    [TestClass]
    public class DataMigrationTests : TestBase<AmazonDatabaseMigrationServiceClient>
    {
        [TestMethod]
        [TestCategory("DataMigration")]
        public void TestDescribeEndpoints()
        {
            var response = Client.DescribeEndpoints(new DescribeEndpointsRequest { });
            Assert.IsNotNull(response);
        }
    }
}
