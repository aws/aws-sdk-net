/*
 * Copyright 2010-2016 Amazon.com, Inc. or its affiliates. All Rights Reserved.
 * 
 * Licensed under the Apache License, Version 2.0 (the "License").
 * You may not use this file except in compliance with the License.
 * A copy of the License is located at
 * 
 *  http://aws.amazon.com/apache2.0
 * 
 * or in the "license" file accompanying this file. This file is distributed
 * on an "AS IS" BASIS, WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either
 * express or implied. See the License for the specific language governing
 * permissions and limitations under the License.
 */
using System;
using System.Net;
using System.Linq;
using Amazon.Runtime;
using Amazon.Runtime.Internal.Util;
using Amazon.Runtime.SharedInterfaces;
using Amazon.SecurityToken.Model;
using Amazon.Runtime.Internal;
#if AWS_ASYNC_API
using System.Threading.Tasks;
#endif
#if BCL || (NETSTANDARD && !NETSTANDARD13)
using Amazon.SecurityToken.SAML;
#endif

namespace Amazon.SecurityToken
{
    public partial class AmazonSecurityTokenServiceClient : AmazonServiceClient, IAmazonSecurityTokenService
#if BCL || NETSTANDARD
     , ICoreAmazonSTS_WebIdentity
#endif
    {
#if BCL || (NETSTANDARD && !NETSTANDARD13)
#if NETSTANDARD20
        SAMLImmutableCredentials ICoreAmazonSTS_SAML.CredentialsFromSAMLAuthentication(
#else
        SAMLImmutableCredentials ICoreAmazonSTS.CredentialsFromSAMLAuthentication(
#endif
            string endpoint,
            string authenticationType,
            string roleARN,
            TimeSpan credentialDuration,
            ICredentials userCredential)
        {
            SAMLAssertion assertion;

            try
            {
                var authController = new SAMLAuthenticationController(Config.GetWebProxy());
                assertion = authController.GetSAMLAssertion(endpoint, userCredential, authenticationType);
            }
            catch (Exception e)
            {
                throw new FederatedAuthenticationFailureException("Authentication failure, unable to obtain SAML assertion.", e);
            }

            try
            {
                return assertion.GetRoleCredentials(this, roleARN, credentialDuration);
            }
            catch (Exception e)
            {
                throw new AmazonClientException("Credential generation failed following successful authentication.", e);
            }
        }
#endif

#if BCL || NETSTANDARD
        private AssumeRoleWithWebIdentityRequest SetupAssumeRoleWithWebIdentityRequest(string webIdentityToken, string roleArn,
            string roleSessionName, AssumeRoleWithWebIdentityCredentialsOptions options)
        {
            var request = new AssumeRoleWithWebIdentityRequest
            {
                WebIdentityToken = webIdentityToken,
                RoleArn = roleArn,
                RoleSessionName = roleSessionName
            };
            if (options != null)
            {
                request.ProviderId = options.ProviderId;
                request.PolicyArns = options.PolicyArns?.Select((arn) => new PolicyDescriptorType { Arn = arn }).ToList();
                request.Policy = options.Policy;
                if (options.DurationSeconds.HasValue)
                {
                    request.DurationSeconds = options.DurationSeconds.Value;
                }
            }

            return request;
        }

        /// <summary>
        /// <see cref="ICoreAmazonSTS_WebIdentity"/>
        /// </summary>
        /// <param name="webIdentityToken">The OAuth 2.0 access token or OpenID Connect ID token that is provided by the identity provider.</param>
        /// <param name="roleArn">The Amazon Resource Name (ARN) of the role to assume.</param>
        /// <param name="roleSessionName">An identifier for the assumed role session.</param>
        /// <param name="options">Options to be used in the call to AssumeRole.</param>
        /// <returns>Immutable AssumeRoleCredentials</returns>
        AssumeRoleImmutableCredentials ICoreAmazonSTS_WebIdentity.CredentialsFromAssumeRoleWithWebIdentityAuthentication(string webIdentityToken, string roleArn,
            string roleSessionName, AssumeRoleWithWebIdentityCredentialsOptions options)
        {
            var request = SetupAssumeRoleWithWebIdentityRequest(webIdentityToken, roleArn, roleSessionName, options);
            try
            {
                var response = AssumeRoleWithWebIdentity(request);
                return new AssumeRoleImmutableCredentials(response.Credentials.AccessKeyId, response.Credentials.SecretAccessKey,
                    response.Credentials.SessionToken, response.Credentials.Expiration);
            }
            catch (Exception e)
            {
                var msg = "Error calling AssumeRole for role " + roleArn;
                var exception = new AmazonClientException(msg, e);
                Logger.GetLogger(typeof(AmazonSecurityTokenServiceClient)).Error(exception, exception.Message);
                throw exception;
            }
        }

#if AWS_ASYNC_API
        /// <summary>
        /// <see cref="ICoreAmazonSTS_WebIdentity"/>
        /// </summary>
        /// <param name="webIdentityToken">The OAuth 2.0 access token or OpenID Connect ID token that is provided by the identity provider.</param>
        /// <param name="roleArn">The Amazon Resource Name (ARN) of the role to assume.</param>
        /// <param name="roleSessionName">An identifier for the assumed role session.</param>
        /// <param name="options">Options to be used in the call to AssumeRole.</param>
        /// <returns>Immutable AssumeRoleCredentials</returns>
        async Task<AssumeRoleImmutableCredentials> ICoreAmazonSTS_WebIdentity.CredentialsFromAssumeRoleWithWebIdentityAuthenticationAsync(string webIdentityToken, string roleArn,
            string roleSessionName, AssumeRoleWithWebIdentityCredentialsOptions options)
        {
            var request = SetupAssumeRoleWithWebIdentityRequest(webIdentityToken, roleArn, roleSessionName, options);
            try
            {
                var response = await AssumeRoleWithWebIdentityAsync(request).ConfigureAwait(false);
                return new AssumeRoleImmutableCredentials(response.Credentials.AccessKeyId, response.Credentials.SecretAccessKey,
                    response.Credentials.SessionToken, response.Credentials.Expiration);
            }
            catch (Exception e)
            {
                var msg = "Error calling AssumeRole for role " + roleArn;
                var exception = new AmazonClientException(msg, e);
                Logger.GetLogger(typeof(AmazonSecurityTokenServiceClient)).Error(exception, exception.Message);
                throw exception;
            }
        }
#endif
#endif // BCL || NETSTANDARD

        /// <summary>
        /// <see cref="ICoreAmazonSTS"/>
        /// </summary>
        /// <param name="roleArn"></param>
        /// <param name="roleSessionName"></param>
        /// <param name="options"></param>
        /// <returns></returns>
        AssumeRoleImmutableCredentials ICoreAmazonSTS.CredentialsFromAssumeRoleAuthentication(string roleArn,
            string roleSessionName, AssumeRoleAWSCredentialsOptions options)
        {
            try
            {
                var request = new AssumeRoleRequest
                {
                    RoleArn = roleArn,
                    RoleSessionName = roleSessionName
                };
                if (options != null)
                {
                    request.ExternalId = options.ExternalId;
                    request.SerialNumber = options.MfaSerialNumber;
                    request.TokenCode = options.MfaTokenCode;
                    request.Policy = options.Policy;

                    if (options.DurationSeconds.HasValue)
                    {
                        request.DurationSeconds = options.DurationSeconds.Value;
                    }
                }

                var response = AssumeRole(request);
                return new AssumeRoleImmutableCredentials(response.Credentials.AccessKeyId, response.Credentials.SecretAccessKey,
                    response.Credentials.SessionToken, response.Credentials.Expiration);
            }
            catch (Exception e)
            {
                var msg = "Error calling AssumeRole for role " + roleArn;
                var exception = new AmazonClientException(msg, e);
                Logger.GetLogger(typeof(AmazonSecurityTokenServiceClient)).Error(exception, exception.Message);
                throw exception;
            }
        }

#if BCL || NETSTANDARD
        /// <summary>
        /// Customizes the runtime pipeline by replacing the default retry handler with a custom one that retries certain STS errors.
        /// </summary>
        /// <param name="pipeline">The client runtime pipeline</param>
        protected override void CustomizeRuntimePipeline(RuntimePipeline pipeline)
        {
            if(this.Config.RetryMode == RequestRetryMode.Legacy)
            {
                pipeline.ReplaceHandler<RetryHandler>(new RetryHandler(new SecurityTokenServiceRetryPolicy(this.Config)));
            }
            else if (this.Config.RetryMode == RequestRetryMode.Standard)
            {
                pipeline.ReplaceHandler<RetryHandler>(new RetryHandler(new SecurityTokenServiceStandardRetryPolicy(this.Config)));
            }
            else if (this.Config.RetryMode == RequestRetryMode.Adaptive)
            {
                pipeline.ReplaceHandler<RetryHandler>(new RetryHandler(new SecurityTokenServiceAdaptiveRetryPolicy(this.Config)));
            }
        }
#endif
    }
}
