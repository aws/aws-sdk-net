using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Xunit;
using Amazon.EC2.Util;
using Amazon.EC2;

namespace Amazon.DNXCore.IntegrationTests.EC2
{
    public class ImageUtilitiesTest
    {
        static string[] imgs = { "WINDOWS_2012R2_BASE", "WINDOWS_2012R2_SQL_SERVER_EXPRESS_2014", "WINDOWS_2012R2_SQL_SERVER_STANDARD_2014", "WINDOWS_2012R2_SQL_SERVER_WEB_2014", "WINDOWS_2012_BASE","WINDOWS_2012_SQL_SERVER_EXPRESS_2014","WINDOWS_2012_SQL_SERVER_STANDARD_2014","WINDOWS_2012_SQL_SERVER_WEB_2014" };

        [Trait("Category","EC2-ImageUtilities")]
        [Fact]
        public async Task ImageTest()
        {
            var client = TestBase.CreateClient<AmazonEC2Client>(null,RegionEndpoint.USEast1);
            foreach (string img in imgs)
            {
                var image = await ImageUtilities.FindImageAsync((Amazon.EC2.IAmazonEC2)client, img).ConfigureAwait(false);
                Assert.NotNull(image);
            }   
        }
    }   
}
