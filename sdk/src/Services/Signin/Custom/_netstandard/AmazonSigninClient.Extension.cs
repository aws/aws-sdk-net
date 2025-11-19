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

namespace Amazon.Signin
{
    public partial class AmazonSigninClient : AmazonServiceClient, IAmazonSignin
    {
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

            // Set feature ID in UserAgent.
            if (invokedFromTool)
            {
                if (request.TokenInput.ClientId == LoginUtils.ClientIdSameDevice)
                {
                    // Set this in future if support is added.
                }
                else if (request.TokenInput.ClientId == LoginUtils.ClientIdCrossDevice)
                {
                    // Set this in future if support is added.
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
    }
}
