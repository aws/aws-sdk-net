using Amazon.Runtime;
using Amazon.Runtime.SharedInterfaces;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using Amazon.Signin.Internal;
using Amazon.Runtime.Endpoints;
using Amazon.Signin.Model;
using Amazon.Runtime.Credentials.Internal;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.UserAgent;
using Amazon.Signin.Util;

namespace Amazon.Signin
{
    public partial class AmazonSigninClient : AmazonServiceClient, IAmazonSignin
    {
#if BCL
        /// <summary>
        /// Invoke CreateOAuth2Token to get access and refresh tokens.
        /// </summary>
        /// <param name="request">CoreCreateOAuth2TokenRequest instance.</param>
        /// <param name="invokedFromTool">Indicates if this method was invoked from a tool.</param>
        /// <returns>CoreCreateOAuth2TokenResponse instance representing response from Signin service for CreateOAuth2Token operation.</returns>
        CoreCreateOAuth2TokenResponse ICoreAmazonSignin.CreateOAuth2Token(CoreCreateOAuth2TokenRequest request, bool invokedFromTool)
        {
            var createOAuth2TokenRequest = new CreateOAuth2TokenRequest
            {
                TokenInput = new CreateOAuth2TokenRequestBody()
                {
                    ClientId = request.TokenInput.ClientId,
                    Code = request.TokenInput.Code,
                    CodeVerifier = request.TokenInput.CodeVerifier,
                    GrantType = request.TokenInput.GrantType,
                    RedirectUri = request.TokenInput.RedirectUri,
                    RefreshToken = request.TokenInput.RefreshToken
                }
            };

            if (invokedFromTool)
            {
                if (request.TokenInput.ClientId == LoginUtils.ClientIdSameDevice)
                {
                    ((IAmazonWebServiceRequest)createOAuth2TokenRequest).UserAgentDetails.AddFeature(UserAgentFeatureId.LOGIN_SAME_DEVICE);
                }
                else if (request.TokenInput.ClientId == LoginUtils.ClientIdCrossDevice)
                {
                    ((IAmazonWebServiceRequest)createOAuth2TokenRequest).UserAgentDetails.AddFeature(UserAgentFeatureId.LOGIN_CROSS_DEVICE);
                }
            }

            var createOAuth2TokenResponse = this.CreateOAuth2Token(createOAuth2TokenRequest);

            return new CoreCreateOAuth2TokenResponse
            {
                TokenOutput = new CoreCreateOAuth2TokenResponseBody()
                {
                    AccessToken = new CoreAccessToken()
                    {
                        AccessKeyId = createOAuth2TokenResponse.TokenOutput.AccessToken.AccessKeyId,
                        SecretAccessKey = createOAuth2TokenResponse.TokenOutput.AccessToken.SecretAccessKey,
                        SessionToken = createOAuth2TokenResponse.TokenOutput.AccessToken.SessionToken
                    },
                    ExpiresIn = createOAuth2TokenResponse.TokenOutput.ExpiresIn,
                    IdToken = createOAuth2TokenResponse.TokenOutput.IdToken,
                    RefreshToken = createOAuth2TokenResponse.TokenOutput?.RefreshToken,
                    TokenType = createOAuth2TokenResponse.TokenOutput.TokenType
                }
            };
        }
#endif
        /// <summary>
        /// Invoke CreateOAuth2Token to get access and refresh tokens.
        /// </summary>
        /// <param name="request">CoreCreateOAuth2TokenRequest instance.</param>
        /// <param name="invokedFromTool">Indicates if this method was invoked from a tool.</param>
        /// <param name="cancellationToken">CancellationToken instance.</param>
        /// <returns>CoreCreateOAuth2TokenResponse instance representing response from Signin service for CreateOAuth2Token operation.</returns>
        async Task<CoreCreateOAuth2TokenResponse> ICoreAmazonSignin.CreateOAuth2TokenAsync(CoreCreateOAuth2TokenRequest request, bool invokedFromTool, CancellationToken cancellationToken)
        {
            var createOAuth2TokenRequest = new CreateOAuth2TokenRequest
            {
                TokenInput = new CreateOAuth2TokenRequestBody()
                {
                    ClientId = request.TokenInput.ClientId,
                    Code = request.TokenInput.Code,
                    CodeVerifier = request.TokenInput.CodeVerifier,
                    GrantType = request.TokenInput.GrantType,
                    RedirectUri = request.TokenInput.RedirectUri,
                    RefreshToken = request.TokenInput.RefreshToken
                }
            };

            if (invokedFromTool)
            {
                if (request.TokenInput.ClientId == LoginUtils.ClientIdSameDevice)
                {
                    ((IAmazonWebServiceRequest)createOAuth2TokenRequest).UserAgentDetails.AddFeature(UserAgentFeatureId.LOGIN_SAME_DEVICE);
                }
                else if (request.TokenInput.ClientId == LoginUtils.ClientIdCrossDevice)
                {
                    ((IAmazonWebServiceRequest)createOAuth2TokenRequest).UserAgentDetails.AddFeature(UserAgentFeatureId.LOGIN_CROSS_DEVICE);
                }
            }

            var createOAuth2TokenResponse = await this.CreateOAuth2TokenAsync(createOAuth2TokenRequest, cancellationToken).ConfigureAwait(false);

            return new CoreCreateOAuth2TokenResponse
            {
                TokenOutput = new CoreCreateOAuth2TokenResponseBody()
                {
                    AccessToken = new CoreAccessToken()
                    {
                        AccessKeyId = createOAuth2TokenResponse.TokenOutput.AccessToken.AccessKeyId,
                        SecretAccessKey = createOAuth2TokenResponse.TokenOutput.AccessToken.SecretAccessKey,
                        SessionToken = createOAuth2TokenResponse.TokenOutput.AccessToken.SessionToken
                    },
                    ExpiresIn = createOAuth2TokenResponse.TokenOutput.ExpiresIn,
                    IdToken = createOAuth2TokenResponse.TokenOutput.IdToken,
                    RefreshToken = createOAuth2TokenResponse.TokenOutput?.RefreshToken,
                    TokenType = createOAuth2TokenResponse.TokenOutput.TokenType
                }
            };
        }

        /// <summary>
        /// Generates DPoP Proof as a signed JSON Web Token (JWT).
        /// </summary>
        /// <param name="httpMethod">The HTTP method of the request the DPoP proof is for, such as POST for token requests and GET for API calls.</param>
        /// <param name="uri">The HTTP URI of the request the DPoP Proof JWT is for, without the fragment and query parameters.</param>
        /// <param name="dpopKey">PEM file contents containing the base64-encoding of the Elliptic Curve Private Key.</param>
        /// <returns>JWT token representing DPoP Proof.</returns>
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Design", "CA1033:Interface methods should be callable by child types")]
        string ICoreAmazonSignin.GenerateDPoPProof(string httpMethod, string uri, ref string dpopKey)
        {
            return DPoPProofGenerator.GenerateProof(httpMethod, uri, ref dpopKey);
        }

        /// <summary>
        /// Returns the base endpoint URL for Signin service.
        /// </summary>
        /// <returns>Base Endpoint URL for Signin service.</returns>
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Design", "CA1033:Interface methods should be callable by child types")]
        string ICoreAmazonSignin.GetBaseEndpoint()
        {
            var parameters = new ServiceOperationEndpointParameters(new CreateOAuth2TokenRequest());
            return this.Config.DetermineServiceOperationEndpoint(parameters)?.URL;
        }
    }
}
