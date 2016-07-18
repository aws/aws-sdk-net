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
        [Fact]
        public async Task ImageTest()
        {
            var client = TestUtil.EC2Client;
            foreach(string img in imgs)
            {
                var image = await ImageUtilities.FindImageAsync(client, img).ConfigureAwait(false);
                Assert.NotNull(image);
            }
            
        }
    }
    public sealed class TestUtil
    {
        private static AmazonEC2Client ec2Client;
        public static AmazonEC2Client EC2Client
        {
            get
            {
                if (ec2Client == null)
                {
                    AmazonEC2Config config = new AmazonEC2Config
                    {
                        RegionEndpoint = RegionEndpoint.USEast1
                        //ServiceURL = "http://ec2-online-iad-test-6002.iad6.amazon.com:8080"
                        //ServiceURL = "http://ec2-shiraz.amazonaws.com",
                        //ServiceURL = "http://ec2.amazonaws.com",
                        //ReadEntireResponse = true
                    };
                    ec2Client = new AmazonEC2Client(config);
                }
                return ec2Client;
            }
        }
    }
    
}
