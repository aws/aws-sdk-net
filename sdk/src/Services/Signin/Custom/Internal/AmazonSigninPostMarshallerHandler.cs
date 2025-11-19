using Amazon.Runtime;

using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Util;

#if NETSTANDARD
using Amazon.Runtime.CredentialManagement;
using Amazon.Runtime.Credentials.Internal;
using Amazon.Signin.Internal;
using Amazon.Signin.Model;
using Amazon.Signin.Util;
using Amazon.Util;
using Amazon.Util.Internal;
using System.IO;
using System.Threading.Tasks;
#endif

using System;

namespace Amazon.Signin.Internal
{
    /// <summary>
    /// Signin PostMarshaller handler for calculating DPoP and storing Login Token
    /// </summary>
    public class AmazonSigninPostMarshallerHandler : PipelineHandler
    {
#if NETSTANDARD
        private const string LoginSessionPropertyName = "login_session";
        private const string ConfigFileName = "config";
        private const string DefaultProfileName = "default";
        private ILoginTokenFileCache _loginTokenFileCache;

        /// <summary>
        /// LoginTokenFileCache instance for saving Login Token to cache.
        /// </summary>
        public ILoginTokenFileCache LoginTokenFileCache
        {
            get
            {
                if (_loginTokenFileCache == null)
                {
                    _loginTokenFileCache = new LoginTokenFileCache(
                        CryptoUtilFactory.CryptoInstance,
                        new FileRetriever(),
                        new DirectoryRetriever());
                }
                return _loginTokenFileCache;
            }
            set
            {
                _loginTokenFileCache = value;
            }
        }

        /// <summary>
        /// Contains the processing logic for a synchronous request invocation.
        /// This method calls InnerHandler.InvokeSync to continue processing of the
        /// request by the pipeline.
        /// </summary>
        /// <param name="executionContext">The execution context which contains both the
        /// requests and response context.</param>
        public override void InvokeSync(IExecutionContext executionContext)
        {
            var requestContext = executionContext.RequestContext;
            var originalRequest = executionContext.RequestContext.OriginalRequest;
            var createOAuth2Request = (originalRequest as CreateOAuth2TokenRequest);
            string dpopKeyToSave = null;
            string originalIdentityToken = null;

            // Set DPoP Proof header.
            if (createOAuth2Request != null)
            {
                GetCreateOAuth2TokenRequiredParameters(requestContext, createOAuth2Request, out var existingDPoPKey, out var existingIdentityToken);

                dpopKeyToSave = existingDPoPKey;
                originalIdentityToken = existingIdentityToken;
                SetDPoPHeader(requestContext, ref existingDPoPKey);
            }

            base.InvokeSync(executionContext);

            // Only try to save LoginToken if original request was CreateOAuth2TokenRequest.
            if (createOAuth2Request != null)
            {
                SaveLoginToken(executionContext.ResponseContext, createOAuth2Request.TokenInput.ClientId, originalIdentityToken, dpopKeyToSave);
            }
        }

        /// <summary>
        /// Contains the processing logic for an asynchronous request invocation.
        /// This method calls InnerHandler.InvokeSync to continue processing of the
        /// request by the pipeline.
        /// </summary>
        /// <typeparam name="T">The response type for the current request.</typeparam>
        /// <param name="executionContext">The execution context, it contains the
        /// request and response context.</param>
        /// <returns>A task that represents the asynchronous operation.</returns>
        public override async Task<T> InvokeAsync<T>(IExecutionContext executionContext)
        {
            var requestContext = executionContext.RequestContext;
            var originalRequest = executionContext.RequestContext.OriginalRequest;
            var createOAuth2Request = (originalRequest as CreateOAuth2TokenRequest);
            string dpopKeyToSave = null;
            string originalIdentityToken = null;

            // Set DPoP Proof header.
            if (createOAuth2Request != null)
            {
                // Async methods cannot have ref/out parameters.
                GetCreateOAuth2TokenRequiredParameters(requestContext, createOAuth2Request, out var existingDPoPKey, out var existingIdentityToken);

                dpopKeyToSave = existingDPoPKey;
                originalIdentityToken = existingIdentityToken;
                SetDPoPHeader(requestContext, ref dpopKeyToSave);
            }

            var task = await base.InvokeAsync<T>(executionContext).ConfigureAwait(false);

            // Only try to save LoginToken if original request was CreateOAuth2TokenRequest.
            if (createOAuth2Request != null)
            {
                await SaveLoginTokenAsync(executionContext.ResponseContext, createOAuth2Request.TokenInput.ClientId, originalIdentityToken, dpopKeyToSave).ConfigureAwait(false);
            }

            return task;
        }

        private void SetDPoPHeader(IRequestContext requestContext, ref string dpopKey)
        {
            var request = requestContext.Request;
            var createOAuth2Request = (requestContext.OriginalRequest as CreateOAuth2TokenRequest);

            if (createOAuth2Request != null)
            {
                var endpoint = request.Endpoint;

                if (endpoint != null)
                {
                    UriBuilder uriBuilder = new UriBuilder(endpoint);
                    uriBuilder.Path = request.ResourcePath;
                    var dpopProof = DPoPProofGenerator.GenerateProof("POST", uriBuilder.Uri.ToString(), ref dpopKey);

                    if (!request.Headers.ContainsKey(HeaderKeys.DPoPHeader))
                    {
                        request.Headers.Add(HeaderKeys.DPoPHeader, dpopProof);
                    }
                }
            }
        }

        private void GetCreateOAuth2TokenRequiredParameters(IRequestContext requestContext, CreateOAuth2TokenRequest createOAuth2Request, out string dpopKey, out string identityToken)
        {
            dpopKey = null; // For authorization_code grant type, it is initial request.
            identityToken = null; // Identity Token is not included for refresh responses.

            if (createOAuth2Request.TokenInput.IsSetGrantType())
            {
                var grantType = createOAuth2Request.TokenInput.GrantType;

                // For refresh_token grent type, we need to get DPoP and IdentityToken key from LoginToken, which is resolved based on login_session key in profile.
                if (grantType == "refresh_token")
                {
                    var loginSession = GetLoginSessionFromProfile(requestContext.ClientConfig.Profile?.Name);

                    if (!string.IsNullOrWhiteSpace(loginSession))
                    {
                        if (LoginTokenFileCache.TryGetLoginToken(loginSession, null, out var loginToken))
                        {
                            dpopKey = loginToken.DPoPKey;
                            identityToken = loginToken.IdentityToken;
                        }
                    }
                }
            }
        }

        private string GetLoginSessionFromProfile(string profileName)
        {
            if (!string.IsNullOrWhiteSpace(profileName))
            {
                var sharedCredentialsFile = new SharedCredentialsFile();
                var configFile = GetSharedConfigFile(sharedCredentialsFile, profileName != null && profileName == DefaultProfileName);

                if (configFile.TryGetSection(profileName, false, false, out var properties, out var _))
                {
                    properties.TryGetValue(LoginSessionPropertyName, out var loginSession);
                    return loginSession;
                }
            }

            return null;
        }

        private static ProfileIniFile GetSharedConfigFile(SharedCredentialsFile sharedCredentialsFile, bool isDefaultProfile = false)
        {
            var awsConfigEnvironmentPath = Environment.GetEnvironmentVariable(SharedCredentialsFile.SharedConfigFileEnvVar);
            if (!string.IsNullOrEmpty(awsConfigEnvironmentPath))
            {
                return new ProfileIniFile(awsConfigEnvironmentPath, !isDefaultProfile);
            }

            // Second parameter profileMarkerRequired is required to be true for config files, but not for credentials file.
            return new ProfileIniFile(Path.Combine(Path.GetDirectoryName(sharedCredentialsFile.FilePath), ConfigFileName), !isDefaultProfile);
        }

        private void SaveLoginToken(IResponseContext responseContext, string clientId, string originalIdentityToken, string dpopKey)
        {
            var createOAuth2TokenResponse = (responseContext.Response as CreateOAuth2TokenResponse);

            if (createOAuth2TokenResponse != null)
            {
                // Identity Token is not included for refresh responses.
                var loginSession = LoginUtils.ExtractLoginSessionFromIdentityToken(createOAuth2TokenResponse.TokenOutput.IdToken ?? originalIdentityToken);

                var accountId = LoginUtils.ExtractAccountIdFromLoginSessionArn(loginSession);

                var newLoginToken = new LoginToken()
                {
                    AccessToken = new LoginImmutableCredentials(
                                    createOAuth2TokenResponse.TokenOutput.AccessToken.AccessKeyId,
                                    createOAuth2TokenResponse.TokenOutput.AccessToken.SecretAccessKey,
                                    createOAuth2TokenResponse.TokenOutput.AccessToken.SessionToken,
                                    AWSSDKUtils.CorrectedUtcNow.AddSeconds((double)createOAuth2TokenResponse.TokenOutput.ExpiresIn),
                                    accountId),
                    ClientId = clientId,
                    DPoPKey = dpopKey,
                    IdentityToken = createOAuth2TokenResponse.TokenOutput.IdToken ?? originalIdentityToken,
                    RefreshToken = createOAuth2TokenResponse.TokenOutput.RefreshToken,
                    TokenType = createOAuth2TokenResponse.TokenOutput.TokenType
                };

                LoginTokenFileCache.SaveLoginToken(loginSession, newLoginToken, null);
            }
        }

        private async Task SaveLoginTokenAsync(IResponseContext responseContext, string clientId, string originalIdentityToken, string dpopKey)
        {
            var createOAuth2TokenResponse = (responseContext.Response as CreateOAuth2TokenResponse);

            if (createOAuth2TokenResponse != null)
            {
                // Identity Token is not included for refresh responses.
                var loginSession = LoginUtils.ExtractLoginSessionFromIdentityToken(createOAuth2TokenResponse.TokenOutput.IdToken ?? originalIdentityToken);

                var accountId = LoginUtils.ExtractAccountIdFromLoginSessionArn(loginSession);

                var newLoginToken = new LoginToken()
                {
                    AccessToken = new LoginImmutableCredentials(
                                    createOAuth2TokenResponse.TokenOutput.AccessToken.AccessKeyId,
                                    createOAuth2TokenResponse.TokenOutput.AccessToken.SecretAccessKey,
                                    createOAuth2TokenResponse.TokenOutput.AccessToken.SessionToken,
                                    AWSSDKUtils.CorrectedUtcNow.AddSeconds((double)createOAuth2TokenResponse.TokenOutput.ExpiresIn),
                                    accountId),
                    ClientId = clientId,
                    DPoPKey = dpopKey,
                    IdentityToken = createOAuth2TokenResponse.TokenOutput.IdToken ?? originalIdentityToken,
                    RefreshToken = createOAuth2TokenResponse.TokenOutput.RefreshToken,
                    TokenType = createOAuth2TokenResponse.TokenOutput.TokenType
                };

                await LoginTokenFileCache.SaveLoginTokenAsync(loginSession, newLoginToken, null).ConfigureAwait(false);
            }
        }
#endif
    }
}
