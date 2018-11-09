using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Xunit;
using Amazon.EC2.Util;
using Amazon.EC2;

namespace Amazon.DNXCore.IntegrationTests.EC2
{
    public class ImageUtilitiesTest : TestBase<AmazonEC2Client>
    {
        static string[] imgs = { "WINDOWS_2012R2_BASE", "WINDOWS_2012R2_SQL_SERVER_EXPRESS_2014", "WINDOWS_2012R2_SQL_SERVER_STANDARD_2014", "WINDOWS_2012R2_SQL_SERVER_WEB_2014", "WINDOWS_2012_BASE","WINDOWS_2012_SQL_SERVER_EXPRESS_2014","WINDOWS_2012_SQL_SERVER_STANDARD_2014","WINDOWS_2012_SQL_SERVER_WEB_2014" };
        
        [Trait(CategoryAttribute, "EC2")]
        [Fact]
        public async Task ImageTest()
        {
            foreach (string img in imgs)
            {
                var image = await ImageUtilities.FindImageAsync(Client, img).ConfigureAwait(false);
                Assert.NotNull(image);
            }
        }

        [Trait(CategoryAttribute, "EC2")]
        [Fact]
        public async Task GetDescriptors()
        {
            var descriptor = await ImageUtilities.DescriptorFromKeyAsync("WINDOWS_2016_BASE", Client);
            Assert.Equal(descriptor.NamePrefix, "Windows_Server-2016-English-Full-Base*");

            descriptor = await ImageUtilities.DescriptorFromKeyAsync("WINDOWS_2012_SQL_SERVER_WEB_2012", Client);
            Assert.Equal(descriptor.NamePrefix, "Windows_Server-2012-RTM-English-64Bit-SQL_2012_SP4_Web*");
        }
    }
}
