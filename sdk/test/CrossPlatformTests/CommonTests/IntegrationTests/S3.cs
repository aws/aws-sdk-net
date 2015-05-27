using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using Amazon.S3;
using Amazon.S3.Model;

namespace CommonTests.IntegrationTests
{
    [TestFixture]
    public class S3 : TestBase<AmazonS3Client>
    {
        [Test]
        public async Task Test()
        {
            //Console.WriteLine("== Running SimpleTests.Test ==");
            await Task.Delay(1000);
            Assert.Fail("", null);

        }

        [Test]
        public async Task ListBucketTest()
        {
            var result = await Client.ListBucketsAsync(
                new ListBucketsRequest());

            Assert.IsNotNull(result.Buckets);
            
        }
    }
}
