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
       // [Test]
        public async Task Test()
        {
            //Console.WriteLine("== Running SimpleTests.Test ==");
            await Task.Delay(1000);
            Assert.Fail("", null);

        }

        //[Test]
        public async Task ListBucketTestsAsync()
        {
            var result = await Client.ListBucketsAsync(
                new ListBucketsRequest());

            Assert.IsNotNull(result.Buckets);
            
        }

        [Test]
        public void ListBucketsTest()
        {
            ListBucketTestsAsync().Wait();
            //Test().Wait();
            //Assert.Pass("Passed");
        }
    }

    [TestFixture]
    public class SimpleTests : TestBase<AmazonS3Client>
    {
        [Test]
        public void SuccessTest()
        {
            Assert.True(true);
        }

        [Test]
        public void FailTest()
        {
            Assert.True(false);
        }

        [Test]
        public void InconclusiveTest()
        {
            Assert.Inconclusive();
        }

        //[Test]        
        //public void InconclusiveTest()
        //{
        //    //Assert.thr.Inconclusive();
        //}
    }
}
