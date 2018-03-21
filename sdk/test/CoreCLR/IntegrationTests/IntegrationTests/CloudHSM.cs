using System;

using System.Linq;
using System.Threading.Tasks;

using Amazon;
using Amazon.CloudHSM;
using Amazon.CloudHSM.Model;
using Xunit;
using Amazon.DNXCore.IntegrationTests;

namespace Amazon.DNXCore.IntegrationTests
{
    
    public class CloudHSM : TestBase<AmazonCloudHSMClient>
    {
        [Fact(Skip="CloudHSM classic is not available to newly created AWS accounts.")]
        public async Task TestSimpleMethods()
        {
            var zones = (await Client.ListAvailableZonesAsync()).AZList;
            Assert.NotNull(zones);
            Assert.True(zones.Count > 0);
            var hsms = Client.ListHsmsAsync().Result.HsmList;
            Assert.NotNull(hsms);
        }
    }
}
