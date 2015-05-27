using Amazon;
using Amazon.Runtime;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommonTests
{
    public abstract class TestRunner
    {
        internal static AWSCredentials Credentials { get; set; }

        internal static RegionEndpoint RegionEndpoint 
        {
            get { return RegionEndpoint.USWest2; } 
        }

		public TestRunner(Stream credentials)
        {
            TestRunner.Credentials = 
				new VendedCredentials(credentials);
        }

        public void ExecuteAllTests()
        {
            var test = new IntegrationTests.S3();
            test.ListBucketTest().Wait();
        }

        public async Task ExecuteAllTestsAsync()
        {
            var test = new IntegrationTests.S3();
            await test.ListBucketTest();
        }

    }
}
