using System;
using Amazon.ElasticTranscoder.Model;
using Amazon.RDS;
using Amazon.RDS.Model;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Reflection;

namespace AWSSDK_DotNet.IntegrationTests.Tests.RDS
{
    [TestClass]
    public class PreSignedUrl : TestBase<AmazonRDSClient>
    {
        [TestMethod]
        [TestCategory("RDS")]
        public void SourceRegion_CopyDBClusterSnapshot()
        {
            var type = typeof(CopyDBClusterSnapshotRequest);
            if (type.GetProperty("PreSignedUrl") != null)
            {
                Assert.IsTrue(false, "By removing this test I verify that I have manually tested CopyDBClusterSnapshot, " +
                    "cross-region, making sure the PreSignedUrl property was filled in correctly.");
            }
        }

        [TestMethod]
        [TestCategory("RDS")]
        public void SourceRegion_CreateDBCluster()
        {
            var type = typeof(CreateDBClusterRequest);
            if (type.GetProperty("PreSignedUrl") != null)
            {
                Assert.IsTrue(false, "By removing this test I verify that I have manually tested CreateDBCluster, " +
                    "cross-region, making sure the PreSignedUrl property was filled in correctly.");
            }
        }

    }
}
