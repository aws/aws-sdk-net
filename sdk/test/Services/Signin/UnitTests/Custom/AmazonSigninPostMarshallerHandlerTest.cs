using Amazon;
using Amazon.Runtime;
using Amazon.Runtime.CredentialManagement;
using Amazon.Runtime.Credentials.Internal;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Util;
using Amazon.Signin.Internal;
using Amazon.Signin.Model;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;
using System.Collections.Generic;
using System.IO;
using System.Threading;
using static AWSSDK.UnitTests.HttpHandlerTests;

namespace AWSSDK.UnitTests
{
    [TestClass]
    public class AmazonSigninPostMarshallerHandlerTest
    {
        private AmazonSigninPostMarshallerHandler _handler;
        private Mock<IExecutionContext> _mockExecutionContext;
        private Mock<IRequestContext> _mockRequestContext;
        private Mock<IResponseContext> _mockResponseContext;
        private RuntimePipeline _pipeline;

        [TestInitialize]
        public void Setup()
        {
            _handler = new AmazonSigninPostMarshallerHandler();
            _pipeline = new RuntimePipeline(new List<IPipelineHandler> { new NoopPipelineHandler(), _handler });
            _mockExecutionContext = new Mock<IExecutionContext>();
            _mockRequestContext = new Mock<IRequestContext>();
            _mockResponseContext = new Mock<IResponseContext>();

            _mockExecutionContext.Setup(x => x.RequestContext).Returns(_mockRequestContext.Object);
            _mockExecutionContext.Setup(x => x.ResponseContext).Returns(_mockResponseContext.Object);
        }

        [TestMethod]
        public void InvokeSync_CreateOAuth2TokenRequest_SetsDPoPHeader()
        {
            var request = new CreateOAuth2TokenRequest
            {
                TokenInput = new CreateOAuth2TokenRequestBody
                {
                    GrantType = "authorization_code",
                    ClientId = "test-client"
                }
            };
            var mockRequest = new Mock<IRequest>();
            var headers = new Dictionary<string, string>();
            mockRequest.Setup(x => x.Headers).Returns(headers);
            mockRequest.Setup(x => x.Endpoint).Returns(new System.Uri("https://signin.aws.amazon.com"));
            mockRequest.Setup(x => x.ResourcePath).Returns("/v1/token");

            _mockRequestContext.Setup(x => x.OriginalRequest).Returns(request);
            _mockRequestContext.Setup(x => x.Request).Returns(mockRequest.Object);

            _handler.InvokeSync(_mockExecutionContext.Object);

            Assert.IsTrue(headers.ContainsKey("DPoP"));
        }

        [TestMethod]
        public void InvokeSync_NonCreateOAuth2TokenRequest_DoesNothing()
        {
            var request = new Mock<AmazonWebServiceRequest>();
            var mockRequest = new Mock<IRequest>();
            var headers = new Dictionary<string, string>();
            mockRequest.Setup(x => x.Headers).Returns(headers);

            _mockRequestContext.Setup(x => x.OriginalRequest).Returns(request.Object);
            _mockRequestContext.Setup(x => x.Request).Returns(mockRequest.Object);

            _handler.InvokeSync(_mockExecutionContext.Object);

            Assert.IsFalse(headers.ContainsKey("DPoP"));
        }

        [TestMethod]
        public void InvokeSync_RefreshTokenRequest_UsesCachedDPoPKey()
        {
            var request = new CreateOAuth2TokenRequest
            {
                TokenInput = new CreateOAuth2TokenRequestBody
                {
                    GrantType = "refresh_token",
                    ClientId = "test-client"
                }
            };
            var mockRequest = new Mock<IRequest>();
            var headers = new Dictionary<string, string>();
            var mockClientConfig = new Mock<IClientConfig>();
            var profile = new CredentialProfile("test-profile", new CredentialProfileOptions());
            
            mockClientConfig.Setup(x => x.Profile).Returns(new Profile(profile.Name));
            mockRequest.Setup(x => x.Headers).Returns(headers);
            mockRequest.Setup(x => x.Endpoint).Returns(new System.Uri("https://signin.aws.amazon.com"));
            mockRequest.Setup(x => x.ResourcePath).Returns("/v1/token");

            _mockRequestContext.Setup(x => x.OriginalRequest).Returns(request);
            _mockRequestContext.Setup(x => x.Request).Returns(mockRequest.Object);
            _mockRequestContext.Setup(x => x.ClientConfig).Returns(mockClientConfig.Object);

            _handler.InvokeSync(_mockExecutionContext.Object);

            Assert.IsTrue(headers.ContainsKey("DPoP"));
        }

        [TestMethod]
        public void InvokeSync_CreateOAuth2TokenRequest_SavesLoginToken()
        {
            var mockLoginTokenFileCache = new Mock<ILoginTokenFileCache>();
            _handler.LoginTokenFileCache = mockLoginTokenFileCache.Object;
            
            var request = new CreateOAuth2TokenRequest
            {
                TokenInput = new CreateOAuth2TokenRequestBody
                {
                    GrantType = "authorization_code",
                    ClientId = "test-client"
                }
            };
            var mockRequest = new Mock<IRequest>();
            var headers = new Dictionary<string, string>();
            var mockResponse = new CreateOAuth2TokenResponse
            {
                TokenOutput = new CreateOAuth2TokenResponseBody
                {
                    AccessToken = new AccessToken
                    {
                        AccessKeyId = "test-access-key",
                        SecretAccessKey = "test-secret-key",
                        SessionToken = "test-session-token"
                    },
                    IdToken = "eyJhbGciOiJIUzI1NiIsInR5cCI6IkpXVCJ9.eyJzdWIiOiJhcm46YXdzOnNpZ25pbjo6MTIzNDU2Nzg5MDEyOmlkZW50aXR5L3Rlc3Qtc2Vzc2lvbiJ9.signature",
                    RefreshToken = "test-refresh-token",
                    TokenType = "aws_sigv4",
                    ExpiresIn = 3600
                }
            };

            mockRequest.Setup(x => x.Headers).Returns(headers);
            mockRequest.Setup(x => x.Endpoint).Returns(new System.Uri("https://signin.aws.amazon.com"));
            mockRequest.Setup(x => x.ResourcePath).Returns("/v1/token");

            _mockRequestContext.Setup(x => x.OriginalRequest).Returns(request);
            _mockRequestContext.Setup(x => x.Request).Returns(mockRequest.Object);
            _mockResponseContext.Setup(x => x.Response).Returns(mockResponse);

            _handler.InvokeSync(_mockExecutionContext.Object);

            Assert.IsTrue(headers.ContainsKey("DPoP"));
            mockLoginTokenFileCache.Verify(x => x.SaveLoginToken(
                It.IsAny<string>(),
                It.IsAny<LoginToken>(),
                It.IsAny<string>()), Times.Once);
        }

        [TestMethod]
        public async System.Threading.Tasks.Task InvokeAsync_CreateOAuth2TokenRequest_SetsDPoPHeader()
        {
            var request = new CreateOAuth2TokenRequest
            {
                TokenInput = new CreateOAuth2TokenRequestBody
                {
                    GrantType = "authorization_code",
                    ClientId = "test-client"
                }
            };
            var mockRequest = new Mock<IRequest>();
            var headers = new Dictionary<string, string>();
            mockRequest.Setup(x => x.Headers).Returns(headers);
            mockRequest.Setup(x => x.Endpoint).Returns(new System.Uri("https://signin.aws.amazon.com"));
            mockRequest.Setup(x => x.ResourcePath).Returns("/v1/token");

            _mockRequestContext.Setup(x => x.OriginalRequest).Returns(request);
            _mockRequestContext.Setup(x => x.Request).Returns(mockRequest.Object);

            await _handler.InvokeAsync<CreateOAuth2TokenResponse>(_mockExecutionContext.Object);

            Assert.IsTrue(headers.ContainsKey("DPoP"));
        }

        [TestMethod]
        public async System.Threading.Tasks.Task InvokeAsync_NonCreateOAuth2TokenRequest_DoesNothing()
        {
            var request = new Mock<AmazonWebServiceRequest>();
            var mockRequest = new Mock<IRequest>();
            var headers = new Dictionary<string, string>();
            mockRequest.Setup(x => x.Headers).Returns(headers);

            _mockRequestContext.Setup(x => x.OriginalRequest).Returns(request.Object);
            _mockRequestContext.Setup(x => x.Request).Returns(mockRequest.Object);

            await _handler.InvokeAsync<AmazonWebServiceResponse>(_mockExecutionContext.Object);

            Assert.IsFalse(headers.ContainsKey("DPoP"));
        }

        [TestMethod]
        public async System.Threading.Tasks.Task InvokeAsync_CreateOAuth2TokenRequest_SavesLoginToken()
        {
            var mockLoginTokenFileCache = new Mock<ILoginTokenFileCache>();
            _handler.LoginTokenFileCache = mockLoginTokenFileCache.Object;
            
            var request = new CreateOAuth2TokenRequest
            {
                TokenInput = new CreateOAuth2TokenRequestBody
                {
                    GrantType = "authorization_code",
                    ClientId = "test-client"
                }
            };
            var mockRequest = new Mock<IRequest>();
            var headers = new Dictionary<string, string>();
            var mockResponse = new CreateOAuth2TokenResponse
            {
                TokenOutput = new CreateOAuth2TokenResponseBody
                {
                    AccessToken = new AccessToken
                    {
                        AccessKeyId = "test-access-key",
                        SecretAccessKey = "test-secret-key",
                        SessionToken = "test-session-token"
                    },
                    IdToken = "eyJhbGciOiJIUzI1NiIsInR5cCI6IkpXVCJ9.eyJzdWIiOiJhcm46YXdzOnNpZ25pbjo6MTIzNDU2Nzg5MDEyOmlkZW50aXR5L3Rlc3Qtc2Vzc2lvbiJ9.signature",
                    RefreshToken = "test-refresh-token",
                    TokenType = "aws_sigv4",
                    ExpiresIn = 3600
                }
            };

            mockRequest.Setup(x => x.Headers).Returns(headers);
            mockRequest.Setup(x => x.Endpoint).Returns(new System.Uri("https://signin.aws.amazon.com"));
            mockRequest.Setup(x => x.ResourcePath).Returns("/v1/token");

            _mockRequestContext.Setup(x => x.OriginalRequest).Returns(request);
            _mockRequestContext.Setup(x => x.Request).Returns(mockRequest.Object);
            _mockResponseContext.Setup(x => x.Response).Returns(mockResponse);

            await _handler.InvokeAsync<CreateOAuth2TokenResponse>(_mockExecutionContext.Object);

            Assert.IsTrue(headers.ContainsKey("DPoP"));
            mockLoginTokenFileCache.Verify(x => x.SaveLoginTokenAsync(
                It.IsAny<string>(),
                It.IsAny<LoginToken>(),
                It.IsAny<string>(), 
                It.IsAny<CancellationToken>()), Times.Once);
        }

        [TestMethod]
        [DataRow(false)]
        [DataRow(true)]
        public async System.Threading.Tasks.Task Invoke_LoginRequest_SavesClientRegionAsSignInRegion(bool useAsync)
        {
            var clientConfig = new Mock<IClientConfig>();
            clientConfig.Setup(x => x.RegionEndpoint).Returns(RegionEndpoint.USEast1);

            var savedToken = await InvokeAndCaptureSavedToken("authorization_code", clientConfig, new Mock<ILoginTokenFileCache>(), useAsync);

            Assert.AreEqual("us-east-1", savedToken.SignInRegion);
        }

        [TestMethod]
        [DataRow(false)]
        [DataRow(true)]
        public async System.Threading.Tasks.Task Invoke_LoginRequestWithEndpointOverride_DoesNotSaveSignInRegion(bool useAsync)
        {
            var clientConfig = new Mock<IClientConfig>();
            clientConfig.Setup(x => x.RegionEndpoint).Returns(RegionEndpoint.USEast1);
            clientConfig.Setup(x => x.ServiceURL).Returns("https://signin.example.com");

            var savedToken = await InvokeAndCaptureSavedToken("authorization_code", clientConfig, new Mock<ILoginTokenFileCache>(), useAsync);

            Assert.IsNull(savedToken.SignInRegion);
        }

        [TestMethod]
        [DataRow("us-east-1", false)]
        [DataRow("us-east-1", true)]
        [DataRow(null, false)]
        [DataRow(null, true)]
        public async System.Threading.Tasks.Task Invoke_RefreshRequest_KeepsCachedSignInRegion(string cachedSignInRegion, bool useAsync)
        {
            var configFile = Path.GetTempFileName();
            var savedConfigFile = System.Environment.GetEnvironmentVariable(SharedCredentialsFile.SharedConfigFileEnvVar);
            try
            {
                File.WriteAllText(configFile, "[profile test-profile]\nlogin_session = test-session\n");
                System.Environment.SetEnvironmentVariable(SharedCredentialsFile.SharedConfigFileEnvVar, configFile);

                var clientConfig = new Mock<IClientConfig>();
                clientConfig.Setup(x => x.RegionEndpoint).Returns(RegionEndpoint.EUWest1);
                clientConfig.Setup(x => x.Profile).Returns(new Profile("test-profile"));
                var cachedToken = new LoginToken { IdentityToken = TestIdToken, SignInRegion = cachedSignInRegion };
                var fileCache = new Mock<ILoginTokenFileCache>();
                fileCache.Setup(x => x.TryGetLoginToken("test-session", null, out cachedToken)).Returns(true);

                var savedToken = await InvokeAndCaptureSavedToken("refresh_token", clientConfig, fileCache, useAsync);

                Assert.AreEqual(cachedSignInRegion, savedToken.SignInRegion);
            }
            finally
            {
                System.Environment.SetEnvironmentVariable(SharedCredentialsFile.SharedConfigFileEnvVar, savedConfigFile);
                File.Delete(configFile);
            }
        }

        [TestMethod]
        [DataRow(false)]
        [DataRow(true)]
        public async System.Threading.Tasks.Task Invoke_RefreshRequestWithoutCachedToken_DoesNotAddSignInRegion(bool useAsync)
        {
            var clientConfig = new Mock<IClientConfig>();
            clientConfig.Setup(x => x.RegionEndpoint).Returns(RegionEndpoint.EUWest1);

            var savedToken = await InvokeAndCaptureSavedToken("refresh_token", clientConfig, new Mock<ILoginTokenFileCache>(), useAsync, responseIdToken: TestIdToken);

            Assert.IsNull(savedToken.SignInRegion);
        }

        private const string TestIdToken = "eyJhbGciOiJIUzI1NiIsInR5cCI6IkpXVCJ9.eyJzdWIiOiJhcm46YXdzOnNpZ25pbjo6MTIzNDU2Nzg5MDEyOmlkZW50aXR5L3Rlc3Qtc2Vzc2lvbiJ9.signature";

        private async System.Threading.Tasks.Task<LoginToken> InvokeAndCaptureSavedToken(string grantType, Mock<IClientConfig> clientConfig, Mock<ILoginTokenFileCache> fileCache, bool useAsync, string responseIdToken = null)
        {
            LoginToken savedToken = null;
            fileCache.Setup(x => x.SaveLoginToken(It.IsAny<string>(), It.IsAny<LoginToken>(), It.IsAny<string>()))
                     .Callback<string, LoginToken, string>((_, token, __) => savedToken = token);
            fileCache.Setup(x => x.SaveLoginTokenAsync(It.IsAny<string>(), It.IsAny<LoginToken>(), It.IsAny<string>(), It.IsAny<CancellationToken>()))
                     .Callback<string, LoginToken, string, CancellationToken>((_, token, __, ___) => savedToken = token)
                     .Returns(System.Threading.Tasks.Task.CompletedTask);
            _handler.LoginTokenFileCache = fileCache.Object;

            var mockRequest = new Mock<IRequest>();
            mockRequest.Setup(x => x.Headers).Returns(new Dictionary<string, string>());
            mockRequest.Setup(x => x.Endpoint).Returns(new System.Uri("https://signin.aws.amazon.com"));
            mockRequest.Setup(x => x.ResourcePath).Returns("/v1/token");

            _mockRequestContext.Setup(x => x.OriginalRequest).Returns(new CreateOAuth2TokenRequest
            {
                TokenInput = new CreateOAuth2TokenRequestBody { GrantType = grantType, ClientId = "test-client" }
            });
            _mockRequestContext.Setup(x => x.Request).Returns(mockRequest.Object);
            _mockRequestContext.Setup(x => x.ClientConfig).Returns(clientConfig.Object);
            _mockResponseContext.Setup(x => x.Response).Returns(new CreateOAuth2TokenResponse
            {
                TokenOutput = new CreateOAuth2TokenResponseBody
                {
                    AccessToken = new AccessToken { AccessKeyId = "key", SecretAccessKey = "secret", SessionToken = "token" },
                    // Sign-In returns an ID token only for a login, not for a refresh.
                    IdToken = grantType == "refresh_token" ? responseIdToken : TestIdToken,
                    RefreshToken = "new-refresh-token",
                    ExpiresIn = 900
                }
            });

            if (useAsync)
                await _handler.InvokeAsync<CreateOAuth2TokenResponse>(_mockExecutionContext.Object);
            else
                _handler.InvokeSync(_mockExecutionContext.Object);

            Assert.IsNotNull(savedToken);
            return savedToken;
        }

        public class NoopPipelineHandler : IPipelineHandler
        {
            public ILogger Logger { get; set; }
            public IPipelineHandler InnerHandler { get; set; }
            public IPipelineHandler OuterHandler { get; set; }

            public virtual System.Threading.Tasks.Task<T> InvokeAsync<T>(IExecutionContext executionContext)
                where T : AmazonWebServiceResponse, new()
            {
                return System.Threading.Tasks.Task.FromResult(new T());
            }

            public void InvokeSync(IExecutionContext executionContext)
            {
            }
        }

    }
}