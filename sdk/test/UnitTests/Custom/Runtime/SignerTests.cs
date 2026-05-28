using Amazon;
using Amazon.S3;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Auth;
using Amazon.Runtime.Internal.Util;
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

            var signer = new MockSigner();
            var context = CreateTestContext(signer);
            context.RequestContext.Identity = new AnonymousAWSCredentials();
            pipeline.InvokeSync(context);

            Assert.IsTrue(context.RequestContext.IsSigned);
            Assert.AreEqual(1, signer.SignCount);
        }

        [TestMethod][TestCategory("UnitTest")]
        [TestCategory("Runtime")]
        public void TestSignerWithBasicCredentials()
        {
            var pipeline = new RuntimePipeline(new MockHandler());
            pipeline.AddHandler(new Signer());

            var signer = new MockSigner();
            var context = CreateTestContext(signer);
            context.RequestContext.Identity = new BasicAWSCredentials("accessKey", "secretKey");
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

            var signer = new AWS4Signer();
            var context = CreateTestContext(signer);
            context.RequestContext.Identity = new BasicAWSCredentials("accessKey", "secretKey");

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
                new object[]
                {
                    new AmazonS3Config { RegionEndpoint = RegionEndpoint.GetBySystemName("us-east-1") },
                    "us-east-1",
                    "s3"
                },
                // FIPS pseudoregion normalized to real region
                new object[]
                {
                    new AmazonS3Config { RegionEndpoint = RegionEndpoint.GetBySystemName("fips-us-east-1") },
                    "us-east-1", 
                    "s3" 
                },
                // Non-FIPS pseudoregion
                new object[]
                {
                    new AmazonS3Config { RegionEndpoint = RegionEndpoint.GetBySystemName("aws-global") },
                    "aws-global",
                    "s3"
                },
            };

        /// <summary>
        /// Tests that the signer selects the correct signing region and service
        /// </summary>
        /// <param name="config">Service client config with intended request region</param>
        /// <param name="expectedAuthRegion">Expected region name to be used for signing</param>
        /// <param name="expectedAuthService">Expected service name to be used for signing</param>
        [TestMethod]
        [DynamicData(nameof(TestSignerScopeCases))]
        public void TestSignerScope(IClientConfig config, string expectedAuthRegion, string expectedAuthService)
        {
            var signer = new AWS4Signer();
            var mock = new Moq.Mock<IRequest>().SetupAllProperties();
            var requestMock = new Moq.Mock<AmazonWebServiceRequest>().SetupAllProperties();
            var request = mock.Object;

            mock.SetupGet(x => x.Headers).Returns(new Dictionary<string, string>());
            mock.SetupGet(x => x.OriginalRequest).Returns(requestMock.Object);
            request.Endpoint = EndpointResolver.DetermineEndpoint(config, request);

            var result = signer.SignRequest(request, config, null, "accessKey", "secretKey");

            var scopePieces = result.Scope.Split('/'); // expected to be date/region/service/aws4_request
            Assert.AreEqual(expectedAuthRegion, scopePieces[1]);
            Assert.AreEqual(expectedAuthService, scopePieces[2]);
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
        public void TestCanonicalizeResourcePathSingleEncoded()
        {
            Assert.AreEqual("/", AWSSDKUtils.CanonicalizeResourcePathV2(null, null, false, null));
            Assert.AreEqual("/", AWSSDKUtils.CanonicalizeResourcePathV2(null, string.Empty, false, null));
            Assert.AreEqual("/", AWSSDKUtils.CanonicalizeResourcePathV2(new Uri("https://ec2.us-west-1.amazonaws.com"), null, false, null));
            Assert.AreEqual("/", AWSSDKUtils.CanonicalizeResourcePathV2(new Uri("https://ec2.us-west-1.amazonaws.com"), string.Empty, false, null));
            Assert.AreEqual("/custompath", AWSSDKUtils.CanonicalizeResourcePathV2(new Uri("https://customhost/custompath"), null, false, null));
            Assert.AreEqual("/custompath", AWSSDKUtils.CanonicalizeResourcePathV2(new Uri("https://customhost/custompath"), string.Empty, false, null));

            Assert.AreEqual(
                "/vx_folder/1.0%5Cdatafiles%5Cfile.json",
                AWSSDKUtils.CanonicalizeResourcePathV2(new Uri("https://s3-eu-west-1.amazonaws.com/"), @"/{a}/{b}", false, new Dictionary<string, string> { {"{a}", "vx_folder" },{ "{b}", @"1.0\datafiles\file.json" } }));

            Assert.AreEqual(
                "/custompath/vx_folder/1.0%5Cdatafiles%5Cfile.json",
                AWSSDKUtils.CanonicalizeResourcePathV2(new Uri("https://customhost/custompath"), @"/{a}/{b}", false, new Dictionary<string, string> { { "{a}", "vx_folder" }, { "{b}", @"1.0\datafiles\file.json" } }));

            Assert.AreEqual("/%40%23%24%3A%21.json",
                    AWSSDKUtils.CanonicalizeResourcePathV2(new Uri("https://customhost"), @"/{a}", false, new Dictionary<string, string> { { "{a}", "@#$:!.json" } }));

            Assert.AreEqual("/$custompath/%40%23%24%3A%21.json",
                    AWSSDKUtils.CanonicalizeResourcePathV2(new Uri("https://customhost/$custompath"), @"/{a}", false, new Dictionary<string, string> { { "{a}", "@#$:!.json" } }));
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Runtime")]
        public void TestCanonicalizeResourcePathDoubleEncoded()
        {
            Assert.AreEqual("/", AWSSDKUtils.CanonicalizeResourcePathV2(new Uri("https://ec2.us-west-1.amazonaws.com"), null, true, null));
            Assert.AreEqual("/", AWSSDKUtils.CanonicalizeResourcePathV2(new Uri("https://ec2.us-west-1.amazonaws.com"), string.Empty, true, null));
            Assert.AreEqual("/custompath", AWSSDKUtils.CanonicalizeResourcePathV2(new Uri("https://customhost/custompath"), null, true, null));
            Assert.AreEqual("/custompath", AWSSDKUtils.CanonicalizeResourcePathV2(new Uri("https://customhost/custompath"), string.Empty, true, null));

            // exception because the URI is necessary to decide whether or not to pre URL encode
            AssertExtensions.ExpectException(() => AWSSDKUtils.CanonicalizeResourcePathV2(null, "doesn't matter", true, null), typeof(ArgumentNullException));

            // In the new signer path, if it's s3, we pass in false for double encoding
            Assert.AreEqual(
                "/vx_folder/1.0%5Cdatafiles%5Cfile.json",
                AWSSDKUtils.CanonicalizeResourcePathV2(new Uri("https://s3-eu-west-1.amazonaws.com/"), @"/{a}/{b}", false, new Dictionary<string, string> { { "{a}", "vx_folder" }, { "{b}", @"1.0\datafiles\file.json" } }));

            // should be double URL encoded because it's not S3
            Assert.AreEqual(
                "/custompath/vx_folder/1.0%255Cdatafiles%255Cfile.json",
                AWSSDKUtils.CanonicalizeResourcePathV2(new Uri("https://customhost/custompath"), @"/{a}/{b}", true, new Dictionary<string, string> { { "{a}", "vx_folder" }, { "{b}", @"1.0\datafiles\file.json" } }));
            // some services like apiagatewaymanagementapi allow special characters to be in the configured endpoint's resource path, in this case the endpoint's resource path is single encoded 
            // and the resource path from the request is double encoded. Since $ is the only special character allowed in the endpoint, we test for this case
            Assert.AreEqual(
                "/$custompath/vx_folder/1.0%255Cdatafiles%255Cfile.json",
                AWSSDKUtils.CanonicalizeResourcePathV2(new Uri("https://customhost/$custompath"), @"/{a}/{b}", true, new Dictionary<string, string> { { "{a}", "vx_folder" }, { "{b}", @"1.0\datafiles\file.json" } }));

            Assert.AreEqual("/$custompath/%2540%2523%2524%253A%2521.json",
                AWSSDKUtils.CanonicalizeResourcePathV2(new Uri("https://customhost/$custompath"), @"/{a}", true, new Dictionary<string, string> { { "{a}", "@#$:!.json" } }));
            
            Assert.AreEqual("/%2540%2523%2524%253A%2521.json",
                AWSSDKUtils.CanonicalizeResourcePathV2(new Uri("https://customhost"), @"/{a}", true, new Dictionary<string, string> { { "{a}", "@#$:!.json" } }));
            
            Assert.AreEqual("/$custompath/nospecialcharacters",
                AWSSDKUtils.CanonicalizeResourcePathV2(new Uri("https://customhost/$custompath"), @"/{a}", true, new Dictionary<string, string> { { "{a}", "nospecialcharacters" } }));
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Runtime")]
        public async Task TestSignerWithBasicCredentialsAsync()
        {
            var pipeline = new RuntimePipeline(new MockHandler());            
            pipeline.AddHandler(new Signer());

            var signer = new MockSigner();
            var context = CreateTestContext(signer);
            context.RequestContext.Identity = new BasicAWSCredentials("accessKey", "secretKey");
            await pipeline.InvokeAsync<AmazonWebServiceResponse>(context);

            Assert.IsTrue(context.RequestContext.IsSigned);
            Assert.AreEqual(1, signer.SignCount);
        }

        [TestMethod]
        [TestCategory("Runtime")]
        [TestCategory("Signer")]
        public void TestV4SignerHandlesAnonymousCredentials()
        {
            var mock = new Moq.Mock<IRequest>().SetupAllProperties();
            var requestMock = new Moq.Mock<AmazonWebServiceRequest>().SetupAllProperties();
            var request = mock.Object;
            var config = new AmazonS3Config { RegionEndpoint = RegionEndpoint.USEast1 };

            mock.SetupGet(x => x.Headers).Returns(new Dictionary<string, string>());
            mock.SetupGet(x => x.OriginalRequest).Returns(requestMock.Object);
            request.Endpoint = EndpointResolver.DetermineEndpoint(config, request);

            var signer = new AWS4Signer();
            var credentials = new AnonymousAWSCredentials();

            // After the SRA changes, the signers were updated to retrieve credentials themselves (instead of
            // relying on a pipeline handler to place the value in the request context). One miss from the original
            // implementation is that customers may call the signer indirectly with anonymous credentials (for example, if
            // their environment is set to assume a role with web identity).
            signer.Sign(request, config, new RequestMetrics(), credentials);

            // This test verifies the signer does not fail with a null reference exception, but doesn't add the authorization
            // header either.
            Assert.IsFalse(request.Headers.ContainsKey(HeaderKeys.AuthorizationHeader));
        }
    }
}
