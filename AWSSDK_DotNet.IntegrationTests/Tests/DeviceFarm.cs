using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using Microsoft.VisualStudio.TestTools.UnitTesting;

using Amazon;
using Amazon.Runtime;
using Amazon.DeviceFarm;
using Amazon.DeviceFarm.Model;

namespace AWSSDK_DotNet.IntegrationTests.Tests
{
    [TestClass]
    public class DeviceFarm
    {
        [TestMethod]
        [TestCategory("DeviceFarm")]
        public void TestDeviceFarmListOperations()
        {
            using (var client = new AmazonDeviceFarmClient(RegionEndpoint.USWest2))
            {
                var response = client.ListDevices(new ListDevicesRequest());
                Assert.IsNotNull(response);
                Assert.IsTrue(response.Devices.Count > 0);
                Assert.IsNotNull(response.Devices[0].Arn);
            }
        }
    }
}