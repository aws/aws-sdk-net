using System;

using System.Linq;

using Amazon;
using Amazon.CloudHSM;
using Amazon.CloudHSM.Model;
using Xunit;
using Amazon.DNXCore.IntegrationTests;

namespace Amazon.DNXCore.IntegrationTests
{
    
    public class CloudHSM : TestBase<AmazonCloudHSMClient>
    {
        [Fact]
        public void TestSimpleMethods()
        {
            var zones = Client.ListAvailableZonesAsync().Result.AZList;
            Assert.NotNull(zones);
            Assert.True(zones.Count > 0);
            var hsms = Client.ListHsmsAsync().Result.HsmList;
            Assert.NotNull(hsms);
        }

        [Fact]
        public void TestHapg()
        {
            var arn = Client.CreateHapgAsync(new CreateHapgRequest { Label = UtilityMethods.GenerateName() }).Result.HapgArn;
            Assert.NotNull(arn);

            var hapgs = Client.ListHapgsAsync().Result.HapgList;
            Assert.True(hapgs.Contains(arn));

            var status = Client.DeleteHapgAsync(arn).Result.Status;

            Assert.NotNull(status);
        }
    }
}
