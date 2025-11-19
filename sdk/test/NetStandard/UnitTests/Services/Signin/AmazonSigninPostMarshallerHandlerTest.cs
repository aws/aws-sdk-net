using Amazon;
using Amazon.Runtime;
using Amazon.Runtime.CredentialManagement;
using Amazon.Runtime.Credentials.Internal;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Util;
using Amazon.Signin.Internal;
using Amazon.Signin.Model;
using Xunit;
using Moq;
using System.Collections.Generic;
using System.Threading;

namespace AWSSDK.UnitTests
{
    public class AmazonSigninPostMarshallerHandlerTest
    {
        private AmazonSigninPostMarshallerHandler _handler;
        private Mock<IExecutionContext> _mockExecutionContext;
        private Mock<IRequestContext> _mockRequestContext;
        private Mock<IResponseContext> _mockResponseContext;
        private RuntimePipeline _pipeline;

        public AmazonSigninPostMarshallerHandlerTest()
        {
            _handler = new AmazonSigninPostMarshallerHandler();
            _pipeline = new RuntimePipeline(new List<IPipelineHandler> { new NoopPipelineHandler(), _handler });
            _mockExecutionContext = new Mock<IExecutionContext>();
            _mockRequestContext = new Mock<IRequestContext>();
            _mockResponseContext = new Mock<IResponseContext>();

            _mockExecutionContext.Setup(x => x.RequestContext).Returns(_mockRequestContext.Object);
            _mockExecutionContext.Setup(x => x.ResponseContext).Returns(_mockResponseContext.Object);
        }

        [Fact]
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

            Assert.True(headers.ContainsKey("DPoP"));
        }

        [Fact]
        public void InvokeSync_NonCreateOAuth2TokenRequest_DoesNothing()
        {
            var request = new Mock<AmazonWebServiceRequest>();
            var mockRequest = new Mock<IRequest>();
            var headers = new Dictionary<string, string>();
            mockRequest.Setup(x => x.Headers).Returns(headers);

            _mockRequestContext.Setup(x => x.OriginalRequest).Returns(request.Object);
            _mockRequestContext.Setup(x => x.Request).Returns(mockRequest.Object);

            _handler.InvokeSync(_mockExecutionContext.Object);

            Assert.False(headers.ContainsKey("DPoP"));
        }

        [Fact]
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

            Assert.True(headers.ContainsKey("DPoP"));
        }

        [Fact]
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

            Assert.True(headers.ContainsKey("DPoP"));
            mockLoginTokenFileCache.Verify(x => x.SaveLoginToken(
                It.IsAny<string>(),
                It.IsAny<LoginToken>(),
                It.IsAny<string>()), Times.Once);
        }

        [Fact]
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

            Assert.True(headers.ContainsKey("DPoP"));
        }

        [Fact]
        public async System.Threading.Tasks.Task InvokeAsync_NonCreateOAuth2TokenRequest_DoesNothing()
        {
            var request = new Mock<AmazonWebServiceRequest>();
            var mockRequest = new Mock<IRequest>();
            var headers = new Dictionary<string, string>();
            mockRequest.Setup(x => x.Headers).Returns(headers);

            _mockRequestContext.Setup(x => x.OriginalRequest).Returns(request.Object);
            _mockRequestContext.Setup(x => x.Request).Returns(mockRequest.Object);

            await _handler.InvokeAsync<AmazonWebServiceResponse>(_mockExecutionContext.Object);

            Assert.False(headers.ContainsKey("DPoP"));
        }

        [Fact]
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

            Assert.True(headers.ContainsKey("DPoP"));
            mockLoginTokenFileCache.Verify(x => x.SaveLoginTokenAsync(
                It.IsAny<string>(),
                It.IsAny<LoginToken>(),
                It.IsAny<string>(),
                It.IsAny<CancellationToken>()), Times.Once);
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