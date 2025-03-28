/*
 * Copyright Amazon.com, Inc. or its affiliates. All Rights Reserved.
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
using System.Collections.Generic;
using System.Net;
using System.Linq;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Util;
using Amazon.Runtime.SharedInterfaces;
using Amazon.SecurityToken.Model;
using Amazon.SecurityToken.SAML;
using Amazon.Util.Internal;
using Amazon.Util;
using Amazon.Runtime.Internal.Endpoints.StandardLibrary;
using System.Threading.Tasks;

namespace Amazon.SecurityToken
{
    public partial class AmazonSecurityTokenServiceClient : AmazonServiceClient, IAmazonSecurityTokenService
    {
        SAMLImmutableCredentials ICoreAmazonSTS.CredentialsFromSAMLAuthentication(
            string endpoint,
            string authenticationType,
            string roleARN,
            TimeSpan credentialDuration,
            ICredentials userCredential)
        {
            SAMLAssertion assertion;

            try
            {
                SAMLAuthenticationController authController = CreateSAMLAuthenticationController(endpoint);
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

        async Task<SAMLImmutableCredentials> ICoreAmazonSTS.CredentialsFromSAMLAuthenticationAsync(
            string endpoint,
            string authenticationType,
            string roleARN,
            TimeSpan credentialDuration,
            ICredentials userCredential)
        {
            SAMLAssertion assertion;

            try
            {
                SAMLAuthenticationController authController = CreateSAMLAuthenticationController(endpoint);
                assertion = await authController.GetSAMLAssertionAsync(endpoint, userCredential, authenticationType)
                                                .ConfigureAwait(false);
            }
            catch (Exception e)
            {
                throw new FederatedAuthenticationFailureException("Authentication failure, unable to obtain SAML assertion.", e);
            }

            try
            {
                return await assertion.GetRoleCredentialsAsync(this, roleARN, credentialDuration).ConfigureAwait(false);
            }
            catch (Exception e)
            {
                throw new AmazonClientException("Credential generation failed following successful authentication.", e);
            }
        }

        private SAMLAuthenticationController CreateSAMLAuthenticationController(string endpoint)
        {
            const string httpPrefix = "http://";
            const string httpsPrefix = "https://";

            var proxy = Config.GetWebProxy();
            if (proxy == null && !NoProxyFilter.Instance.Match(new Uri(endpoint)))
            {
                if (endpoint.StartsWith(httpPrefix))
                {
                    proxy = Config.GetHttpProxy();
                }
                else if (endpoint.StartsWith(httpsPrefix))
                {
                    proxy = Config.GetHttpsProxy();
                }
            }
            var authController = new SAMLAuthenticationController(proxy);
            return authController;
        }

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
        /// <see cref="ICoreAmazonSTS"/>
        /// </summary>
        /// <param name="webIdentityToken">The OAuth 2.0 access token or OpenID Connect ID token that is provided by the identity provider.</param>
        /// <param name="roleArn">The Amazon Resource Name (ARN) of the role to assume.</param>
        /// <param name="roleSessionName">An identifier for the assumed role session.</param>
        /// <param name="options">Options to be used in the call to AssumeRole.</param>
        /// <returns>Immutable AssumeRoleCredentials</returns>
        AssumeRoleImmutableCredentials ICoreAmazonSTS.CredentialsFromAssumeRoleWithWebIdentityAuthentication(string webIdentityToken, string roleArn,
            string roleSessionName, AssumeRoleWithWebIdentityCredentialsOptions options)
        {
            var request = SetupAssumeRoleWithWebIdentityRequest(webIdentityToken, roleArn, roleSessionName, options);
            try
            {
                var response = AssumeRoleWithWebIdentity(request);
                return new AssumeRoleImmutableCredentials(response.Credentials.AccessKeyId, response.Credentials.SecretAccessKey,
                    response.Credentials.SessionToken, response.Credentials.Expiration.GetValueOrDefault(), response.AssumedRoleUser != null ? Arn.Parse(response.AssumedRoleUser.Arn).AccountId : null);
            }
            catch (Exception e)
            {
                var msg = "Error calling AssumeRole for role " + roleArn;
                var exception = new AmazonClientException(msg, e);
                Logger.GetLogger(typeof(AmazonSecurityTokenServiceClient)).Error(exception, exception.Message);
                throw exception;
            }
        }

        /// <summary>
        /// <see cref="ICoreAmazonSTS"/>
        /// </summary>
        /// <param name="webIdentityToken">The OAuth 2.0 access token or OpenID Connect ID token that is provided by the identity provider.</param>
        /// <param name="roleArn">The Amazon Resource Name (ARN) of the role to assume.</param>
        /// <param name="roleSessionName">An identifier for the assumed role session.</param>
        /// <param name="options">Options to be used in the call to AssumeRole.</param>
        /// <returns>Immutable AssumeRoleCredentials</returns>
        async Task<AssumeRoleImmutableCredentials> ICoreAmazonSTS.CredentialsFromAssumeRoleWithWebIdentityAuthenticationAsync(string webIdentityToken, string roleArn,
            string roleSessionName, AssumeRoleWithWebIdentityCredentialsOptions options)
        {
            var request = SetupAssumeRoleWithWebIdentityRequest(webIdentityToken, roleArn, roleSessionName, options);
            try
            {
                var response = await AssumeRoleWithWebIdentityAsync(request).ConfigureAwait(false);
                return new AssumeRoleImmutableCredentials(response.Credentials.AccessKeyId, response.Credentials.SecretAccessKey,
                    response.Credentials.SessionToken, response.Credentials.Expiration.GetValueOrDefault(), response.AssumedRoleUser != null ? Arn.Parse(response.AssumedRoleUser.Arn).AccountId : null);
            }
            catch (Exception e)
            {
                var msg = "Error calling AssumeRole for role " + roleArn;
                var exception = new AmazonClientException(msg, e);
                Logger.GetLogger(typeof(AmazonSecurityTokenServiceClient)).Error(exception, exception.Message);
                throw exception;
            }
        }

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
                AssumeRoleRequest request = CreateAssumeRoleRequest(roleArn, roleSessionName, options);

                var response = AssumeRole(request);
                return new AssumeRoleImmutableCredentials(response.Credentials.AccessKeyId, response.Credentials.SecretAccessKey,
                    response.Credentials.SessionToken, response.Credentials.Expiration.GetValueOrDefault(), response.AssumedRoleUser != null ? Arn.Parse(response.AssumedRoleUser.Arn).AccountId : null);
            }
            catch (Exception e)
            {
                var msg = "Error calling AssumeRole for role " + roleArn;
                var exception = new AmazonClientException(msg, e);
                Logger.GetLogger(typeof(AmazonSecurityTokenServiceClient)).Error(exception, exception.Message);
                throw exception;
            }
        }

        /// <summary>
        /// <see cref="ICoreAmazonSTS"/>
        /// </summary>
        /// <param name="roleArn"></param>
        /// <param name="roleSessionName"></param>
        /// <param name="options"></param>
        /// <returns></returns>
        async Task<AssumeRoleImmutableCredentials> ICoreAmazonSTS.CredentialsFromAssumeRoleAuthenticationAsync(string roleArn,
            string roleSessionName, AssumeRoleAWSCredentialsOptions options)
        {
            try
            {
                AssumeRoleRequest request = CreateAssumeRoleRequest(roleArn, roleSessionName, options);

                var response = await AssumeRoleAsync(request).ConfigureAwait(false);
                return new AssumeRoleImmutableCredentials(response.Credentials.AccessKeyId, response.Credentials.SecretAccessKey,
                    response.Credentials.SessionToken, response.Credentials.Expiration.GetValueOrDefault());
            }
            catch (Exception e)
            {
                var msg = "Error calling AssumeRole for role " + roleArn;
                var exception = new AmazonClientException(msg, e);
                Logger.GetLogger(typeof(AmazonSecurityTokenServiceClient)).Error(exception, exception.Message);
                throw exception;
            }
        }

        private static AssumeRoleRequest CreateAssumeRoleRequest(string roleArn, string roleSessionName, AssumeRoleAWSCredentialsOptions options)
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
                request.SourceIdentity = options.SourceIdentity;

                if (options.DurationSeconds.HasValue)
                {
                    request.DurationSeconds = options.DurationSeconds.Value;
                }

                if (options.Tags != null && options.Tags.Count > 0)
                {
                    request.Tags = options.Tags.Select(kv => new Tag() { Key = kv.Key, Value = kv.Value }).ToList();
                }

                if (options.TransitiveTagKeys != null && options.TransitiveTagKeys.Count > 0)
                {
                    request.TransitiveTagKeys = options.TransitiveTagKeys;
                }
            }

            return request;
        }
    }
}
