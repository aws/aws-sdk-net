using System.IO;
using System.Text.Json;
using System.Threading.Tasks;
using Amazon;
using Amazon.BearerTokenAuthTest;
using Amazon.BearerTokenAuthTest.Model;
using Amazon.Runtime;
using Amazon.Runtime.Credentials.Internal;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Auth;
using Amazon.Runtime.SharedInterfaces;
using Amazon.Util;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;

namespace AWSSDK.UnitTests.Runtime
{
    /// <summary>
    /// Tests a Bearer Auth <see cref="AmazonServiceClient"/> can correctly use
    /// <see cref="Signer.SignRequest"/>.  These tests combine as much real plumbing together as possible
    /// to ensure the plumbing is working.
    /// <para />
    /// A Bearer Auth Service is when <see cref="BaseAuthResolverHandler"/> resolves
    /// <see cref="BearerTokenSigner"/>.
    /// </summary>
    [TestClass]
    public class BearerTokenServiceTests : RuntimePipelineTestBase
    {
        private const string FakeSessionName = "admin";
        private const string FakeStartUrl = "https://d-abc123.awsapps.com/start";
        private const string FakeFileUrl = "d033e22ae348aeb5660fc2140aec35850c4da997.json";
        private const string FakeCacheDirectory = "cache";

        /// <summary>
        /// Builds a Service Config that will use a real <see cref="SSOTokenProvider"/>, but
        /// one that is hard coded to look for a SSO Token in a file based on
        /// <see cref="FakeFileUrl"/> and will try to read said file from <paramref name="mockFileSystem"/>
        /// </summary>
        /// <returns></returns>
        private AmazonBearerTokenAuthTestConfig BuildConfig(MockFileSystem mockFileSystem)
        {
            return new AmazonBearerTokenAuthTestConfig
            {
                AWSTokenProvider =
                    new AWSTokenProviderChain(
                        new SSOTokenProvider(
                            new SSOTokenManager(
                                new Mock<ICoreAmazonSSOOIDC>().Object,
                                new SSOTokenFileCache(
                                    CryptoUtilFactory.CryptoInstance,
                                    mockFileSystem,
                                    mockFileSystem)),
                            FakeSessionName,
                            FakeStartUrl,
                            RegionEndpoint.USEast1.SystemName,
                            FakeCacheDirectory))
            };
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Runtime")]
        public void ServiceUsingBearerTokenCorrectlySetsAuthorizationHeader()
        {
            // ARRANGE
            var fakeToken = new
            {
                accessToken = "fakeAccess",
                expiresAt = "3000-11-14T04:05:45Z",
            };

            var mockFileSystem = new MockFileSystem();
            mockFileSystem.WriteAllText(
                Path.Combine(FakeCacheDirectory, FakeFileUrl),
                JsonSerializer.Serialize(fakeToken));

            var config = BuildConfig(mockFileSystem);

            var client = new AmazonBearerTokenAuthTestClientTestFixture(config);

            // ACT
            try
            {
                client.InheritBearerAuthOperation(new InheritBearerAuthOperationRequest());
            }
            catch { } // pipeline will throw exception intentionally to short circuit

            
            Assert.IsNotNull(client.CapturedContext);

            var authorizationHeader = client.CapturedContext.RequestContext.Request.Headers["Authorization"];

            Assert.AreEqual($"Bearer {fakeToken.accessToken}", authorizationHeader);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Runtime")]
        public void ServiceUsingBearerTokenAllowsCustomizingTokenProvider()
        {
            // ARRANGE
            const string fakeToken = "FakeStaticToken";

            var config = new AmazonBearerTokenAuthTestConfig
            {
                AWSTokenProvider = new StaticTokenProvider(fakeToken)
            };

            var client = new AmazonBearerTokenAuthTestClientTestFixture(config);

            // ACT
            try
            {
                client.InheritBearerAuthOperation(new InheritBearerAuthOperationRequest());
            }
            catch { } // pipeline will throw exception intentionally to short circuit

            // ASSERT
            Assert.IsNotNull(client.CapturedContext);

            var authorizationHeader = client.CapturedContext.RequestContext.Request.Headers["Authorization"];

            Assert.AreEqual($"Bearer {fakeToken}", authorizationHeader);
        }

        /// <summary>
        /// Wraps the real <see cref="AmazonBearerTokenAuthTestClient"/>, but tweaks said client to make it more test friendly
        /// by adding a <see cref="TerminatePipeline"/> handler to 1) prevent an actual outbound http request as well as
        /// 2) capturing the final request's <see cref="IExecutionContext"/> so Tests can assert against it.
        /// </summary>
        private class AmazonBearerTokenAuthTestClientTestFixture : AmazonBearerTokenAuthTestClient
        {
            private readonly TerminatePipeline _terminatePipeline = new TerminatePipeline();

            public IExecutionContext CapturedContext => _terminatePipeline.CapturedContext;

            public AmazonBearerTokenAuthTestClientTestFixture(AmazonBearerTokenAuthTestConfig config) : base(config)
            {
                RuntimePipeline.AddHandlerBefore<HttpHandler<Stream>>(_terminatePipeline);
            }
        }
    }
}