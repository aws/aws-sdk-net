using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Amazon.Runtime;
using Xunit;
using Amazon.Runtime.Internal;
using Amazon.Util.Internal;
using System.Diagnostics;
using Amazon;
using Amazon.DynamoDBv2;
using System.Configuration;

namespace AWSSDK.AppConfigTests
{
    public class UnitTests
    {
        [Fact]
        [Trait("Category", "CSM")]
        [Trait("Category", "AppConfig")]
        public void AppConfigCSMSectionTest()
        {
            var client = new AmazonDynamoDBClient(RegionEndpoint.USEast1);
            Assert.True(AWSConfigs.CSMConfig.CSMEnabled);
            Assert.True(AWSConfigs.CSMConfig.CSMEnabled.HasValue);
        }

        [Fact]
        [Trait("Category", "CSM")]
        [Trait("Category", "AppConfig")]
        public void OverrideAppConfigCSMSectionTest()
        {
            Assert.True(AWSConfigs.CSMConfig.CSMEnabled);
            var client = new AmazonDynamoDBClient(RegionEndpoint.USEast1);
            AWSConfigs.CSMConfig.CSMEnabled = false;
            Assert.False(AWSConfigs.CSMConfig.CSMEnabled);
        }
    }
}
