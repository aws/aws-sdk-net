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

/*
 * Do not modify this file. This file is generated from the smithy.json service model.
 */
using Amazon.Runtime;
using Amazon.Runtime.Credentials.Internal;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Auth;
using Amazon.Runtime.Identity;
using System.Collections.Generic;

namespace Amazon.CognitoIdentityProvider.Internal
{
    /// <inheritdoc cref="IAuthSchemeParameters" />
    public class AmazonCognitoIdentityProviderAuthSchemeParameters : IAuthSchemeParameters
    {
        /// <inheritdoc />
        public string Operation { get; set; }

        /// <summary>
        /// Region is included as the service supports SigV4.
        /// </summary>
        public string Region { get; set; }
    }

    /// <summary>
    /// Handler responsible for converting the request context into the parameters expected by the auth scheme resolver.
    /// </summary>
    public class AmazonCognitoIdentityProviderAuthSchemeHandler : BaseAuthResolverHandler
    {
        /// <summary>
        /// Modeled auth scheme resolver for CognitoIdentityProvider.
        /// </summary>
        public AmazonCognitoIdentityProviderAuthSchemeResolver AuthSchemeResolver { get; } = new();

        /// <inheritdoc />
        protected override List<IAuthSchemeOption> ResolveAuthOptions(IExecutionContext executionContext)
        {
            var requestContext = executionContext.RequestContext;
            var mappedParameters = new AmazonCognitoIdentityProviderAuthSchemeParameters
            {
                Operation = requestContext.Request.RequestName,
                Region = requestContext.ClientConfig.RegionEndpoint?.SystemName,
            };

            return AuthSchemeResolver.ResolveAuthScheme(mappedParameters);
        }
    }

    /// <inheritdoc cref="IAuthSchemeResolver{T}" />
    public class AmazonCognitoIdentityProviderAuthSchemeResolver : IAuthSchemeResolver<AmazonCognitoIdentityProviderAuthSchemeParameters>
    {
        /// <inheritdoc />
        public List<IAuthSchemeOption> ResolveAuthScheme(AmazonCognitoIdentityProviderAuthSchemeParameters authParameters) =>
            authParameters.Operation switch
            {
                "AssociateSoftwareTokenRequest" => AuthSchemeOption.DEFAULT_NOAUTH,
                "ChangePasswordRequest" => AuthSchemeOption.DEFAULT_NOAUTH,
                "CompleteWebAuthnRegistrationRequest" => AuthSchemeOption.DEFAULT_NOAUTH,
                "ConfirmDeviceRequest" => AuthSchemeOption.DEFAULT_NOAUTH,
                "ConfirmForgotPasswordRequest" => AuthSchemeOption.DEFAULT_NOAUTH,
                "ConfirmSignUpRequest" => AuthSchemeOption.DEFAULT_NOAUTH,
                "DeleteUserRequest" => AuthSchemeOption.DEFAULT_NOAUTH,
                "DeleteUserAttributesRequest" => AuthSchemeOption.DEFAULT_NOAUTH,
                "DeleteWebAuthnCredentialRequest" => AuthSchemeOption.DEFAULT_NOAUTH,
                "ForgetDeviceRequest" => AuthSchemeOption.DEFAULT_NOAUTH,
                "ForgotPasswordRequest" => AuthSchemeOption.DEFAULT_NOAUTH,
                "GetDeviceRequest" => AuthSchemeOption.DEFAULT_NOAUTH,
                "GetTokensFromRefreshTokenRequest" => AuthSchemeOption.DEFAULT_NOAUTH,
                "GetUserRequest" => AuthSchemeOption.DEFAULT_NOAUTH,
                "GetUserAttributeVerificationCodeRequest" => AuthSchemeOption.DEFAULT_NOAUTH,
                "GetUserAuthFactorsRequest" => AuthSchemeOption.DEFAULT_NOAUTH,
                "GlobalSignOutRequest" => AuthSchemeOption.DEFAULT_NOAUTH,
                "InitiateAuthRequest" => AuthSchemeOption.DEFAULT_NOAUTH,
                "ListDevicesRequest" => AuthSchemeOption.DEFAULT_NOAUTH,
                "ListWebAuthnCredentialsRequest" => AuthSchemeOption.DEFAULT_NOAUTH,
                "ResendConfirmationCodeRequest" => AuthSchemeOption.DEFAULT_NOAUTH,
                "RespondToAuthChallengeRequest" => AuthSchemeOption.DEFAULT_NOAUTH,
                "RevokeTokenRequest" => AuthSchemeOption.DEFAULT_NOAUTH,
                "SetUserMFAPreferenceRequest" => AuthSchemeOption.DEFAULT_NOAUTH,
                "SetUserSettingsRequest" => AuthSchemeOption.DEFAULT_NOAUTH,
                "SignUpRequest" => AuthSchemeOption.DEFAULT_NOAUTH,
                "StartWebAuthnRegistrationRequest" => AuthSchemeOption.DEFAULT_NOAUTH,
                "UpdateAuthEventFeedbackRequest" => AuthSchemeOption.DEFAULT_NOAUTH,
                "UpdateDeviceStatusRequest" => AuthSchemeOption.DEFAULT_NOAUTH,
                "UpdateUserAttributesRequest" => AuthSchemeOption.DEFAULT_NOAUTH,
                "VerifySoftwareTokenRequest" => AuthSchemeOption.DEFAULT_NOAUTH,
                "VerifyUserAttributeRequest" => AuthSchemeOption.DEFAULT_NOAUTH,
                // Default for the service, applies to all remaining operations.
                _ => AuthSchemeOption.DEFAULT_SIGV4,
            };
    }
}
