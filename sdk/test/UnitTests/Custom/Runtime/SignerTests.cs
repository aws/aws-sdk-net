using Amazon;
using Amazon.S3;
using Amazon.SecurityToken;
using Amazon.SecurityToken.Internal;
using Amazon.SecurityToken.Model;
using Amazon.SecurityToken.Model.Internal.MarshallTransformations;
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

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Runtime")]
        public void TestSignerWithRegionAndCustomServiceURLSetViaEnvVariables()
        {
            var savedEndpoint = Environment.GetEnvironmentVariable("AWS_ENDPOINT_URL");
            var savedRegion = Environment.GetEnvironmentVariable("AWS_REGION");
            try
            {
                Environment.SetEnvironmentVariable("AWS_ENDPOINT_URL", "https://non-aws-endpoint.com");
                Environment.SetEnvironmentVariable("AWS_REGION", "us-east-2");
                FallbackRegionFactory.Reset();

                var config = new AmazonSecurityTokenServiceConfig();

                var getCallerIdentityRequest = new GetCallerIdentityRequest();
                var marshaller = new GetCallerIdentityRequestMarshaller();
                var marshalledRequest = marshaller.Marshall(getCallerIdentityRequest);

                var signer = new AWS4Signer();
                var requestContext = new RequestContext(true, signer)
                {
                    ClientConfig = config,
                    OriginalRequest = getCallerIdentityRequest,
                    Request = marshalledRequest,
                    Identity = new BasicAWSCredentials("accessKey", "secretKey")
                };

                var executionContext = new ExecutionContext(requestContext, new ResponseContext());

                var pipeline = new RuntimePipeline(new MockHandler());
                pipeline.AddHandler(new Signer());
                pipeline.AddHandler(new AmazonSecurityTokenServiceEndpointResolver());

                pipeline.InvokeSync(executionContext);

                var authHeader = executionContext.RequestContext.Request.Headers[HeaderKeys.AuthorizationHeader];
                // When both region and serviceURL are set via env variables, the region env variable should be respected.
                Assert.IsTrue(authHeader.Contains("us-east-2/sts/aws4_request"),
                    $"Expected Authorization header to contain 'us-east-2/sts/aws4_request' but got: {authHeader}");
            }
            finally
            {
                Environment.SetEnvironmentVariable("AWS_REGION", savedRegion);
                Environment.SetEnvironmentVariable("AWS_ENDPOINT_URL", savedEndpoint);
                FallbackRegionFactory.Reset();
            }
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Runtime")]
        public void TestSignerWithRegionAndAWSServiceURLSetViaEnvVariables()
        {
            var savedRegion = Environment.GetEnvironmentVariable("AWS_REGION");
            var savedEndpoint = Environment.GetEnvironmentVariable("AWS_ENDPOINT_URL");
            try
            {
                Environment.SetEnvironmentVariable("AWS_REGION", "us-east-2");
                Environment.SetEnvironmentVariable("AWS_ENDPOINT_URL", "http://s3.amazonaws.com");
                FallbackRegionFactory.Reset();

                var config = new AmazonSecurityTokenServiceConfig();

                var getCallerIdentityRequest = new GetCallerIdentityRequest();
                var marshaller = new GetCallerIdentityRequestMarshaller();
                var marshalledRequest = marshaller.Marshall(getCallerIdentityRequest);

                var signer = new AWS4Signer();
                var requestContext = new RequestContext(true, signer)
                {
                    ClientConfig = config,
                    OriginalRequest = getCallerIdentityRequest,
                    Request = marshalledRequest,
                    Identity = new BasicAWSCredentials("accessKey", "secretKey")
                };

                var executionContext = new ExecutionContext(requestContext, new ResponseContext());

                var pipeline = new RuntimePipeline(new MockHandler());
                pipeline.AddHandler(new Signer());
                pipeline.AddHandler(new AmazonSecurityTokenServiceEndpointResolver());

                pipeline.InvokeSync(executionContext);

                var authHeader = executionContext.RequestContext.Request.Headers[HeaderKeys.AuthorizationHeader];
                // for aws endpoints, the global region is used as a default, even if one is provided via AWS_REGION 
                // to preserve backwards compatibility.
                Assert.IsTrue(authHeader.Contains("us-east-1/sts/aws4_request"),
                    $"Expected Authorization header to contain 'us-east-1/sts/aws4_request' but got: {authHeader}");
            }
            finally
            {
                Environment.SetEnvironmentVariable("AWS_REGION", savedRegion);
                Environment.SetEnvironmentVariable("AWS_ENDPOINT_URL", savedEndpoint);
                FallbackRegionFactory.Reset();
            }
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Runtime")]
        public void TestAuthenticationRegionOverridesRegionSetViaEnvVariable()
        {
            var savedRegion = Environment.GetEnvironmentVariable("AWS_REGION");
            var savedEndpoint = Environment.GetEnvironmentVariable("AWS_ENDPOINT_URL");
            try
            {
                Environment.SetEnvironmentVariable("AWS_REGION", "us-east-1");
                Environment.SetEnvironmentVariable("AWS_ENDPOINT_URL", "http://testEndpoint.com/443");
                FallbackRegionFactory.Reset();

                var config = new AmazonSecurityTokenServiceConfig();
                config.AuthenticationRegion = "us-east-2";

                var getCallerIdentityRequest = new GetCallerIdentityRequest();
                var marshaller = new GetCallerIdentityRequestMarshaller();
                var marshalledRequest = marshaller.Marshall(getCallerIdentityRequest);

                var signer = new AWS4Signer();
                var requestContext = new RequestContext(true, signer)
                {
                    ClientConfig = config,
                    OriginalRequest = getCallerIdentityRequest,
                    Request = marshalledRequest,
                    Identity = new BasicAWSCredentials("accessKey", "secretKey")
                };

                var executionContext = new ExecutionContext(requestContext, new ResponseContext());

                var pipeline = new RuntimePipeline(new MockHandler());
                pipeline.AddHandler(new Signer());
                pipeline.AddHandler(new AmazonSecurityTokenServiceEndpointResolver());

                pipeline.InvokeSync(executionContext);

                var authHeader = executionContext.RequestContext.Request.Headers[HeaderKeys.AuthorizationHeader];
                Assert.IsTrue(authHeader.Contains($"us-east-2/sts/aws4_request"),
                    $"Expected Authorization header to contain 'us-east-2/sts/aws4_request' but got: {authHeader}");
            }
            finally
            {
                Environment.SetEnvironmentVariable("AWS_REGION", savedRegion);
                Environment.SetEnvironmentVariable("AWS_ENDPOINT_URL", savedEndpoint);
                FallbackRegionFactory.Reset();
            }
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Runtime")]
        public void TestSignerWithNoServiceURLAndNoRegionEnvVariableRespectsClientConfig()
        {
            var savedRegion = Environment.GetEnvironmentVariable("AWS_REGION");
            var savedEndpoint = Environment.GetEnvironmentVariable("AWS_ENDPOINT_URL");
            try
            {
                Environment.SetEnvironmentVariable("AWS_REGION", null);
                Environment.SetEnvironmentVariable("AWS_ENDPOINT_URL", null);
                FallbackRegionFactory.Reset();

                var config = new AmazonSecurityTokenServiceConfig();
                config.RegionEndpoint = RegionEndpoint.USWest2;

                var getCallerIdentityRequest = new GetCallerIdentityRequest();
                var marshaller = new GetCallerIdentityRequestMarshaller();
                var marshalledRequest = marshaller.Marshall(getCallerIdentityRequest);

                var signer = new AWS4Signer();
                var requestContext = new RequestContext(true, signer)
                {
                    ClientConfig = config,
                    OriginalRequest = getCallerIdentityRequest,
                    Request = marshalledRequest,
                    Identity = new BasicAWSCredentials("accessKey", "secretKey")
                };

                var executionContext = new ExecutionContext(requestContext, new ResponseContext());

                var pipeline = new RuntimePipeline(new MockHandler());
                pipeline.AddHandler(new Signer());
                pipeline.AddHandler(new AmazonSecurityTokenServiceEndpointResolver());

                pipeline.InvokeSync(executionContext);
              
                var authHeader = executionContext.RequestContext.Request.Headers[HeaderKeys.AuthorizationHeader];
                // When no region is explicitly set via env var, the SDK falls back to profile/default region
                Assert.IsTrue(authHeader.Contains($"us-west-2"),
                    $"Expected Authorization header to contain 'us-west-2/sts/aws4_request' but got: {authHeader}");
            }
            finally
            {
                Environment.SetEnvironmentVariable("AWS_REGION", savedRegion);
                Environment.SetEnvironmentVariable("AWS_ENDPOINT_URL", savedEndpoint);
                FallbackRegionFactory.Reset();
            }
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
        public void TestCanonicalizeResourcePathAlreadyEncoded()
        {
            // pathAlreadyEncoded = true is the "zero encode passes" mode used by the standalone SigV4 signer for
            // S3: the segment values are already the final encoded (wire) form, so the canonical path must equal
            // them byte-for-byte. This matches how botocore / @smithy / Java v2 sign S3 (verified by the
            // sigv4-cross-sdk oracles). It is mutually exclusive with the encode pass, so the `encode` argument
            // is ignored when pathAlreadyEncoded is true.

            // Null/empty behave like the other overloads (return "/").
            Assert.AreEqual("/", AWSSDKUtils.CanonicalizeResourcePathV2(new Uri("https://s3.us-east-1.amazonaws.com"), null, false, null, pathAlreadyEncoded: true));
            Assert.AreEqual("/", AWSSDKUtils.CanonicalizeResourcePathV2(new Uri("https://s3.us-east-1.amazonaws.com"), string.Empty, false, null, pathAlreadyEncoded: true));

            // An already-encoded value is joined verbatim: no re-encoding of the '%' (so "%20" stays "%20",
            // not "%2520"), and an encoded slash ("%2F") is preserved inside its segment rather than re-encoded
            // or split into two segments.
            Assert.AreEqual(
                "/hello%20world",
                AWSSDKUtils.CanonicalizeResourcePathV2(new Uri("https://bucket.s3.us-east-1.amazonaws.com"), "/{Path+}", false, new Dictionary<string, string> { { "{Path+}", "hello%20world" } }, pathAlreadyEncoded: true));

            Assert.AreEqual(
                "/a%2Bb%3Dc",
                AWSSDKUtils.CanonicalizeResourcePathV2(new Uri("https://bucket.s3.us-east-1.amazonaws.com"), "/{Path+}", false, new Dictionary<string, string> { { "{Path+}", "a%2Bb%3Dc" } }, pathAlreadyEncoded: true));

            Assert.AreEqual(
                "/a%2Fb",
                AWSSDKUtils.CanonicalizeResourcePathV2(new Uri("https://bucket.s3.us-east-1.amazonaws.com"), "/{Path+}", false, new Dictionary<string, string> { { "{Path+}", "a%2Fb" } }, pathAlreadyEncoded: true));

            // A greedy value containing real '/' separators keeps them as segment boundaries but does not
            // re-encode the already-encoded content of each segment.
            Assert.AreEqual(
                "/hello%20world/caf%C3%A9-%E2%98%83.txt",
                AWSSDKUtils.CanonicalizeResourcePathV2(new Uri("https://bucket.s3.us-east-1.amazonaws.com"), "/{Path+}", false, new Dictionary<string, string> { { "{Path+}", "hello%20world/caf%C3%A9-%E2%98%83.txt" } }, pathAlreadyEncoded: true));

            // pathAlreadyEncoded overrides encode: passing encode = true still produces the verbatim path.
            Assert.AreEqual(
                "/a%2Fb",
                AWSSDKUtils.CanonicalizeResourcePathV2(new Uri("https://bucket.s3.us-east-1.amazonaws.com"), "/{Path+}", true, new Dictionary<string, string> { { "{Path+}", "a%2Fb" } }, pathAlreadyEncoded: true));

            // Contrast: the SAME encoded value with pathAlreadyEncoded = false (the non-S3 path) gets one more
            // encode pass, so "%2F" becomes "%252F". This is the exact non-S3-vs-S3 divergence the facade relies on.
            Assert.AreEqual(
                "/a%252Fb",
                AWSSDKUtils.CanonicalizeResourcePathV2(new Uri("https://example.amazonaws.com"), "/{Path+}", false, new Dictionary<string, string> { { "{Path+}", "a%2Fb" } }, pathAlreadyEncoded: false));
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
