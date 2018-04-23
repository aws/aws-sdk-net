using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;


using Amazon.ConfigService;
using Amazon.ConfigService.Model;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace AWSSDK_DotNet.IntegrationTests.Tests
{
    [TestClass]
    public class ConfigServiceTests : TestBase<AmazonConfigServiceClient>
    {
        [TestMethod]
        [TestCategory("ConfigService")]
        public void TestDescribeConfigurationRecorderStatus()
        {
            Client.DescribeConfigurationRecorderStatus(new DescribeConfigurationRecorderStatusRequest
            {

            });
        }


    }
}
