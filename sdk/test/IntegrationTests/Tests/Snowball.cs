using System;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;

using Amazon;
using Amazon.Snowball;
using Amazon.Snowball.Model;
using Amazon.Runtime;

namespace AWSSDK_DotNet.IntegrationTests.Tests
{
    [TestClass]
    public class Snowball : TestBase<AmazonSnowballClient>
    {
        [TestMethod]
        [TestCategory("Snowball")]
        public void ListJobs()
        {
            var client = new AmazonSnowballClient(Amazon.RegionEndpoint.USWest1);
            client.ListJobs(new ListJobsRequest());
        }

        [TestMethod]
        [TestCategory("Snowball")]
        public void GetSnowballUsage()
        {
            var client = new AmazonSnowballClient(Amazon.RegionEndpoint.USWest1);
            var response = client.GetSnowballUsage(new GetSnowballUsageRequest());
        }
    }
}
