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

using Amazon.Runtime;

using Amazon.Runtime.SharedInterfaces;
using Amazon.SecurityToken.Model;
using Amazon.Runtime.Internal.Util;

#if BCL
using Amazon.SecurityToken.SAML;
#endif

namespace Amazon.SecurityToken
{
    public partial class AmazonSecurityTokenServiceClient : AmazonServiceClient, IAmazonSecurityTokenService
    {

#if BCL
        SAMLImmutableCredentials ICoreAmazonSTS.CredentialsFromSAMLAuthentication(string endpoint,
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
    }
}