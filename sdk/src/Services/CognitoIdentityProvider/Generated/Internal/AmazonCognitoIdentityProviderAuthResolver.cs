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
 * Do not modify this file. This file is generated from the cognito-idp-2016-04-18.normal.json service model.
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

        /// <inheritdoc/>
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
        public List<IAuthSchemeOption> ResolveAuthScheme(AmazonCognitoIdentityProviderAuthSchemeParameters authParameters)
        {
            switch (authParameters.Operation)
            {
                case "AssociateSoftwareTokenRequest":
                    return AuthSchemeOption.DEFAULT_NOAUTH;
                case "ChangePasswordRequest":
                    return AuthSchemeOption.DEFAULT_NOAUTH;
                case "CompleteWebAuthnRegistrationRequest":
                    return AuthSchemeOption.DEFAULT_NOAUTH;
                case "ConfirmDeviceRequest":
                    return AuthSchemeOption.DEFAULT_NOAUTH;
                case "ConfirmForgotPasswordRequest":
                    return AuthSchemeOption.DEFAULT_NOAUTH;
                case "ConfirmSignUpRequest":
                    return AuthSchemeOption.DEFAULT_NOAUTH;
                case "DeleteUserRequest":
                    return AuthSchemeOption.DEFAULT_NOAUTH;
                case "DeleteUserAttributesRequest":
                    return AuthSchemeOption.DEFAULT_NOAUTH;
                case "DeleteWebAuthnCredentialRequest":
                    return AuthSchemeOption.DEFAULT_NOAUTH;
                case "ForgetDeviceRequest":
                    return AuthSchemeOption.DEFAULT_NOAUTH;
                case "ForgotPasswordRequest":
                    return AuthSchemeOption.DEFAULT_NOAUTH;
                case "GetDeviceRequest":
                    return AuthSchemeOption.DEFAULT_NOAUTH;
                case "GetTokensFromRefreshTokenRequest":
                    return AuthSchemeOption.DEFAULT_NOAUTH;
                case "GetUserRequest":
                    return AuthSchemeOption.DEFAULT_NOAUTH;
                case "GetUserAttributeVerificationCodeRequest":
                    return AuthSchemeOption.DEFAULT_NOAUTH;
                case "GetUserAuthFactorsRequest":
                    return AuthSchemeOption.DEFAULT_NOAUTH;
                case "GlobalSignOutRequest":
                    return AuthSchemeOption.DEFAULT_NOAUTH;
                case "InitiateAuthRequest":
                    return AuthSchemeOption.DEFAULT_NOAUTH;
                case "ListDevicesRequest":
                    return AuthSchemeOption.DEFAULT_NOAUTH;
                case "ListWebAuthnCredentialsRequest":
                    return AuthSchemeOption.DEFAULT_NOAUTH;
                case "ResendConfirmationCodeRequest":
                    return AuthSchemeOption.DEFAULT_NOAUTH;
                case "RespondToAuthChallengeRequest":
                    return AuthSchemeOption.DEFAULT_NOAUTH;
                case "RevokeTokenRequest":
                    return AuthSchemeOption.DEFAULT_NOAUTH;
                case "SetUserMFAPreferenceRequest":
                    return AuthSchemeOption.DEFAULT_NOAUTH;
                case "SetUserSettingsRequest":
                    return AuthSchemeOption.DEFAULT_NOAUTH;
                case "SignUpRequest":
                    return AuthSchemeOption.DEFAULT_NOAUTH;
                case "StartWebAuthnRegistrationRequest":
                    return AuthSchemeOption.DEFAULT_NOAUTH;
                case "UpdateAuthEventFeedbackRequest":
                    return AuthSchemeOption.DEFAULT_NOAUTH;
                case "UpdateDeviceStatusRequest":
                    return AuthSchemeOption.DEFAULT_NOAUTH;
                case "UpdateUserAttributesRequest":
                    return AuthSchemeOption.DEFAULT_NOAUTH;
                case "VerifySoftwareTokenRequest":
                    return AuthSchemeOption.DEFAULT_NOAUTH;
                case "VerifyUserAttributeRequest":
                    return AuthSchemeOption.DEFAULT_NOAUTH;
                default:
                    // Default for the service, applies to all remaining operations.
                    return AuthSchemeOption.DEFAULT_SIGV4;
            }
        }
    }
}