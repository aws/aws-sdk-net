using Amazon;
using Amazon.ECR;
using Amazon.IotData;
using Amazon.MTurk;
using Amazon.QuickSight;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Auth;
using Amazon.Util;
using AWSSDK_DotNet.IntegrationTests.Utils;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace AWSSDK.UnitTests
{
    [TestClass()]
    public class SignerTests : RuntimePipelineTestBase
    {
        [TestMethod][TestCategory("UnitTest")]
        [TestCategory("Runtime")]
        public void TestSignerWithAnonymousCredentials()
        {            
            var pipeline = new RuntimePipeline(new MockHandler());
            pipeline.AddHandler(new Signer());
            pipeline.AddHandler(new CredentialsRetriever(new AnonymousAWSCredentials()));

            var signer = new MockSigner();
            var context = CreateTestContext(signer);
            pipeline.InvokeSync(context);

            Assert.IsTrue(context.RequestContext.IsSigned);
            Assert.AreEqual(0, signer.SignCount);
        }

        [TestMethod][TestCategory("UnitTest")]
        [TestCategory("Runtime")]
        public void TestSignerWithBasicCredentials()
        {
            var pipeline = new RuntimePipeline(new MockHandler());
            pipeline.AddHandler(new Signer());
            pipeline.AddHandler(new CredentialsRetriever(new BasicAWSCredentials("accessKey", "secretKey")));

            var signer = new MockSigner();
            var context = CreateTestContext(signer);
            pipeline.InvokeSync(context);

            Assert.IsTrue(context.RequestContext.IsSigned);
            Assert.AreEqual(1, signer.SignCount);
        }

        [TestMethod][TestCategory("UnitTest")]
        [TestCategory("Runtime")]
        public void TestSignerWithMutableHeader()
        {
            var pipeline = new RuntimePipeline(new MockHandler());           
            pipeline.AddHandler(new Signer());
            pipeline.AddHandler(new CredentialsRetriever(new BasicAWSCredentials("accessKey", "secretKey")));

            var signer = new AWS4Signer();
            var context = CreateTestContext(signer);

            // inject a mutable header that the signer should strip out
            context.RequestContext.Request.Headers[HeaderKeys.XAmznTraceIdHeader] = "stuff";
            pipeline.InvokeSync(context);

            // verify that the header is not in the signature
            var t = context.RequestContext.Request.Headers[HeaderKeys.AuthorizationHeader];
            Assert.IsFalse(t.Contains(HeaderKeys.XAmznTraceIdHeader));

            Assert.IsTrue(context.RequestContext.Request.Headers.ContainsKey(HeaderKeys.XAmznTraceIdHeader));
        }

        private static IEnumerable<object[]> TestSignerScopeCases =>
            new List<object[]> 
            {
                // Real region, partition defaults
                new object[]{new AmazonIotDataConfig { RegionEndpoint = RegionEndpoint.GetBySystemName("us-east-1") },
                    "us-east-1", "iotdata", "data.iot.us-east-1.amazonaws.com" },
                // Real region with credentialScope.region
                new object[]{new AmazonECRConfig { RegionEndpoint = RegionEndpoint.GetBySystemName("us-east-1") },
                    "us-east-1", "ecr", "api.ecr.us-east-1.amazonaws.com" },
                // Pseudoregion with credentialScope.region
                new object[]{ new AmazonECRConfig { RegionEndpoint = RegionEndpoint.GetBySystemName("fips-dkr-us-east-1") },
                    "us-east-1", "ecr", "ecr-fips.us-east-1.amazonaws.com"},
                 // Pseudoregion with credentialScope.region, different partition
                new object[]{ new AmazonECRConfig { RegionEndpoint = RegionEndpoint.GetBySystemName("fips-us-gov-east-1") },
                    "us-gov-east-1", "ecr", "ecr-fips.us-gov-east-1.amazonaws.com" },
                // Pseudoregion, no credentialScope.region
                new object[]{new AmazonIotDataConfig { RegionEndpoint = RegionEndpoint.GetBySystemName("fips-us-east-1") },
                    "fips-us-east-1", "iotdata", "data.iot-fips.us-east-1.amazonaws.com" },
                // Non-FIPS pseudoregion, no credentialScope
                new object[]{new AmazonMTurkConfig { RegionEndpoint = RegionEndpoint.GetBySystemName("sandbox") },
                    "sandbox", "mturk-requester", "mturk-requester-sandbox.us-east-1.amazonaws.com" },
                // Non-FIPS pseudoregion, no credentialScope or hostname
                new object[]{new AmazonQuickSightConfig { RegionEndpoint = RegionEndpoint.GetBySystemName("api") },
                    "api", "quicksight", "quicksight.api.amazonaws.com" },
            };

        /// <summary>
        /// Tests that the signer selects the correct signing region and service
        /// </summary>
        /// <param name="config">Service client config with intended request region</param>
        /// <param name="expectedAuthRegion">Expected region name to be used for signing</param>
        /// <param name="expectedAuthService">Exected service name to be used for signing</param>
        /// <param name="expectedEndpoint">Expected hostname for the request</param>
        [DataTestMethod]
        [DynamicData(nameof(TestSignerScopeCases))]
        public void TestSignerScope(IClientConfig config, string expectedAuthRegion, string expectedAuthService, string expectedEndpoint)
        {
            var signer = new AWS4Signer();
            var mock = new Moq.Mock<IRequest>().SetupAllProperties();
            var request = mock.Object;

            mock.SetupGet(x => x.Headers).Returns(new Dictionary<string, string>());
            request.Endpoint = EndpointResolver.DetermineEndpoint(config, request);

            var result = signer.SignRequest(request, config, null, "accessKey", "secretKey");

            var scopePieces = result.Scope.Split('/'); // expected to be date/region/service/aws4_request
            Assert.AreEqual(expectedAuthRegion, scopePieces[1]);
            Assert.AreEqual(expectedAuthService, scopePieces[2]);
            Assert.AreEqual(expectedEndpoint, request.Endpoint.Host);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Runtime")]
        public void TestDetermineRegionFromURL()
        {
            Assert.AreEqual("eu-west-1", AWSSDKUtils.DetermineRegion("https://autoscaling.eu-west-1.amazonaws.com/"));
            Assert.AreEqual("eu-west-1", AWSSDKUtils.DetermineRegion("https://cognito-identity.eu-west-1.amazonaws.com/"));
            Assert.AreEqual("us-east-1", AWSSDKUtils.DetermineRegion("https://route53.amazonaws.com/"));
            Assert.AreEqual("us-east-1", AWSSDKUtils.DetermineRegion("https://s3.amazonaws.com/"));
            Assert.AreEqual("us-east-1", AWSSDKUtils.DetermineRegion("https://s3-external-1.amazonaws.com/"));
            Assert.AreEqual("eu-central-1", AWSSDKUtils.DetermineRegion("https://s3-eu-central-1.amazonaws.com/"));
            Assert.AreEqual("eu-central-1", AWSSDKUtils.DetermineRegion("https://s3.eu-central-1.amazonaws.com/"));
            Assert.AreEqual("us-west-2", AWSSDKUtils.DetermineRegion("https://streams.dynamodb.us-west-2.amazonaws.com/"));
            Assert.AreEqual("us-west-2", AWSSDKUtils.DetermineRegion("https://s3-control.us-west-2.amazonaws.com/"));
            Assert.AreEqual(null, AWSSDKUtils.DetermineRegion("https://bucket-name.s3-accelerate.amazonaws.com/"));
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Runtime")]
        public void TestCanonicalizeResourcePath()
        {
            Assert.AreEqual("/", AWSSDKUtils.CanonicalizeResourcePath(null, null));
            Assert.AreEqual("/", AWSSDKUtils.CanonicalizeResourcePath(null, string.Empty));
            Assert.AreEqual("/", AWSSDKUtils.CanonicalizeResourcePath(new Uri("https://ec2.us-west-1.amazonaws.com"), null));
            Assert.AreEqual("/", AWSSDKUtils.CanonicalizeResourcePath(new Uri("https://ec2.us-west-1.amazonaws.com"), string.Empty));
            Assert.AreEqual("/custompath", AWSSDKUtils.CanonicalizeResourcePath(new Uri("https://customhost/custompath"), null));
            Assert.AreEqual("/custompath", AWSSDKUtils.CanonicalizeResourcePath(new Uri("https://customhost/custompath"), string.Empty));

            Assert.AreEqual(
                "/vx_folder/1.0%5Cdatafiles%5Cfile.json",
                AWSSDKUtils.CanonicalizeResourcePath(null, @"/vx_folder/1.0\datafiles\file.json"));

            Assert.AreEqual(
                "/vx_folder/1.0%5Cdatafiles%5Cfile.json",
                AWSSDKUtils.CanonicalizeResourcePath(new Uri("https://s3-eu-west-1.amazonaws.com/"), @"/vx_folder/1.0\datafiles\file.json"));

            Assert.AreEqual(
                "/custompath/vx_folder/1.0%5Cdatafiles%5Cfile.json",
                AWSSDKUtils.CanonicalizeResourcePath(new Uri("https://customhost/custompath"), @"/vx_folder/1.0\datafiles\file.json"));
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Runtime")]
        public void TestCanonicalizeResourcePathDoubleEncoded()
        {
            Assert.AreEqual("/", AWSSDKUtils.CanonicalizeResourcePath(new Uri("https://ec2.us-west-1.amazonaws.com"), null, true));
            Assert.AreEqual("/", AWSSDKUtils.CanonicalizeResourcePath(new Uri("https://ec2.us-west-1.amazonaws.com"), string.Empty, true));
            Assert.AreEqual("/custompath", AWSSDKUtils.CanonicalizeResourcePath(new Uri("https://customhost/custompath"), null, true));
            Assert.AreEqual("/custompath", AWSSDKUtils.CanonicalizeResourcePath(new Uri("https://customhost/custompath"), string.Empty, true));

            // exception because the URI is necessary to decide whether or not to pre URL encode
            AssertExtensions.ExpectException(() =>
            {
                AWSSDKUtils.CanonicalizeResourcePath(null, "doesn't matter", true);
            }, typeof(ArgumentNullException), "A non-null endpoint is necessary to decide whether or not to pre URL encode.\r\nParameter name: endpoint");

            // should be single URL encoded because it's S3
            Assert.AreEqual(
                "/vx_folder/1.0%5Cdatafiles%5Cfile.json",
                AWSSDKUtils.CanonicalizeResourcePath(new Uri("https://s3-eu-west-1.amazonaws.com/"), @"/vx_folder/1.0\datafiles\file.json", true));

            // should be double URL encoded because it's not S3
            Assert.AreEqual(
                "/custompath/vx_folder/1.0%255Cdatafiles%255Cfile.json",
                AWSSDKUtils.CanonicalizeResourcePath(new Uri("https://customhost/custompath"), @"/vx_folder/1.0\datafiles\file.json", true));
        }

#if BCL45
        [TestMethod][TestCategory("UnitTest")]
        [TestCategory("Runtime")]
        [TestCategory(@"Runtime\Async45")]
        public async Task TestSignerWithBasicCredentialsAsync()
        {
            var pipeline = new RuntimePipeline(new MockHandler());            
            pipeline.AddHandler(new Signer());
            pipeline.AddHandler(new CredentialsRetriever(new BasicAWSCredentials("accessKey", "secretKey")));

            var signer = new MockSigner();
            var context = CreateTestContext(signer);
            await pipeline.InvokeAsync<AmazonWebServiceResponse>(context);

            Assert.IsTrue(context.RequestContext.IsSigned);
            Assert.AreEqual(1, signer.SignCount);
        }
#elif !BCL45 && BCL
        [TestMethod][TestCategory("UnitTest")]
        [TestCategory("Runtime")]
        [TestCategory(@"Runtime\Async35")]
        public void TestSignerWithBasicCredentialsAsync()
        {
            var pipeline = new RuntimePipeline(new MockHandler());
            pipeline.AddHandler(new Signer());
            pipeline.AddHandler(new CredentialsRetriever(new BasicAWSCredentials("accessKey", "secretKey")));

            var signer = new MockSigner();
            var context = CreateAsyncTestContext(signer);
            var asyncResult = pipeline.InvokeAsync(context);
            asyncResult.AsyncWaitHandle.WaitOne();

            Assert.IsTrue(context.RequestContext.IsSigned);
            Assert.AreEqual(1, signer.SignCount);
        }
#endif
    }
}
