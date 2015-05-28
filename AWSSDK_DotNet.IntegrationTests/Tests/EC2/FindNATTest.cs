using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using Amazon.IdentityManagement.Model;
using Amazon.Runtime;
using Microsoft.VisualStudio.TestTools.UnitTesting;

using Amazon;
using Amazon.EC2;
using Amazon.EC2.Util;

using AWSSDK_DotNet.IntegrationTests.Utils;

namespace AWSSDK_DotNet.IntegrationTests.Tests.EC2
{
    [TestClass]
    public class VPCUtilitiesTests
    {
        [TestMethod]
        public void FindNATInEverRegion()
        {
            foreach(var region in RegionEndpoint.EnumerableAllRegions)
            {
                if (region == RegionEndpoint.CNNorth1 || region == RegionEndpoint.USGovCloudWest1)
                    continue;

                using(var client = new AmazonEC2Client(region))
                {
                    var image = VPCUtilities.FindNATImage(client, VirtualizationType.Hvm);
                    Assert.IsNotNull(image, "Failed to find HVM NAT image for region {0}", region.SystemName);

                    image = VPCUtilities.FindNATImage(client, VirtualizationType.Paravirtual);
                    Assert.IsNotNull(image, "Failed to find Para virtual NAT image for region {0}", region.SystemName);
                }
            }
        }

    }
}