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
    public class SampleTests : TestBase<AmazonS3Client>
    {
        [Test]
        public void ListBucketsTest()
        {
            RunAsSync(async () =>
            {
                var result = await Client.ListBucketsAsync(
                    new ListBucketsRequest());

                Assert.IsNotNull(result.Buckets);
            });
        }
    }
}

