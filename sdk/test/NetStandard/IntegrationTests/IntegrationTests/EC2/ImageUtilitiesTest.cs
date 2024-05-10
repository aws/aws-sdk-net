﻿using System;
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
        [Trait(CategoryAttribute, "EC2")]
        [Fact]
        public async Task ImageTest()
        {
            var imageKey = "WINDOWS_2016_BASE";
            var image = await ImageUtilities.FindImageAsync(Client, imageKey);
            Assert.NotNull(image);
        }

        [Trait(CategoryAttribute, "EC2")]
        [Fact]
        public async Task GetDescriptors()
        {
            var descriptor = await ImageUtilities.DescriptorFromKeyAsync("WINDOWS_2016_BASE", Client);
            Assert.Equal("Windows_Server-2016-English-Full-Base*", descriptor.NamePrefix);

            descriptor = await ImageUtilities.DescriptorFromKeyAsync("WINDOWS_2012_SQL_SERVER_WEB_2012", Client);
            Assert.Equal("Windows_Server-2012-RTM-English-64Bit-SQL_2012_SP4_Web*", descriptor.NamePrefix);
        }
    }
}
