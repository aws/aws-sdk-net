/*
 * Copyright 2017 Amazon.com, Inc. or its affiliates. All Rights Reserved.
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

using System.Collections.Generic;

using Amazon.CognitoIdentityProvider;
using Amazon.CognitoIdentityProvider.Model;

namespace Amazon.Extensions.CognitoAuthentication
{
    /// <summary>
    /// Class necessary for allowing users to respond to authentication results
    /// at each step of the authentication flow
    /// </summary>
    public class AuthFlowResponse
    {
        /// <summary>
        /// The sessionID for the current authentication flow.
        /// </summary>
        public string SessionID { get; internal set; }

        /// <summary>
        /// The current challenge name for the authentication flow.
        /// </summary>
        public ChallengeNameType ChallengeName { get; internal set; }

        /// <summary>
        /// The current authentication result for the authentication flow.
        /// </summary>
        public AuthenticationResultType AuthenticationResult { get; internal set; }

        /// <summary>
        /// The challenge parameters for the current authentication flow.
        /// </summary>
        public IDictionary<string, string> ChallengeParameters { get; internal set; }

        /// <summary>
        /// The client metadata for the current authentication flow. Only 
        /// applicable for custom authentication.
        /// </summary>
        public IDictionary<string, string> ClientMetadata { get; internal set; }
    }

    /// <summary>
    /// Class containing the necessary properities to initiate SRP authentication flow
    /// </summary>
    public class InitiateSrpAuthRequest
    {
        /// <summary>
        /// The password for the corresponding CognitoUser.
        /// </summary>
        public string Password { get; set; }
    }

    /// <summary>
    /// Class containing the necessary properities to initiate custom authentication flow
    /// </summary>
    public class InitiateCustomAuthRequest
    {
        /// <summary>
        /// The authentication parameters for the current authentication flow.
        /// </summary>
        public IDictionary<string, string> AuthParameters { get; set; }

        /// <summary>
        /// The client metadata for the current authentication flow.
        /// </summary>
        public IDictionary<string, string> ClientMetadata { get; set; }
    }

    /// <summary>
    /// Class containing the necessary properities to initiate either REFRESH_TOKEN or
    /// REFRESH_TOKEN_AUTH authentication
    /// </summary>
    public class InitiateRefreshTokenAuthRequest
    {
        /// <summary>
        /// The authentication flow type for the current authentication flow; 
        /// either REFRESH_TOKEN or REFRESH_TOKEN_AUTH
        /// </summary>
        public AuthFlowType AuthFlowType { get; set; }
    }

    /// <summary>
    /// Class containing the necessary properities to respond to an SMS MFA authentication challenge
    /// </summary>
    public class RespondToSmsMfaRequest
    {
        /// <summary>
        /// The session ID for the current authentication flow.
        /// </summary>
        public string SessionID { get; set; }

        /// <summary>
        /// The MFA verification code needed to authenticate the user.
        /// </summary>
        public string MfaCode { get; set; }
    }

    /// <summary>
    /// Class containing the necessary properities to respond to a new password required authentication challenge
    /// </summary>
    public class RespondToNewPasswordRequiredRequest
    {
        /// <summary>
        /// The session ID for the current authentication flow.
        /// </summary>
        public string SessionID { get; set; }

        /// <summary>
        /// The new desired password for the user.
        /// </summary>
        public string NewPassword { get; set; }
    }

    /// <summary>
    /// Class containing the necessary properities to respond to a custom authentication challenge
    /// </summary>
    public class RespondToCustomChallengeRequest
    {
        /// <summary>
        /// The authentication parameters for the current authentication flow.
        /// </summary>
        public IDictionary<string, string> ChallengeParameters { get; set; }

        /// <summary>
        /// The sessionID for the current authentication flow.
        /// </summary>
        public string SessionID { get; set; }
    }

    /// <summary>
    /// Class containing the necessary parameters to inititate ADMIN_NO_SRP authentication
    /// </summary>
    public class InitiateAdminNoSrpAuthRequest
    {
        /// <summary>
        /// The associated user's password
        /// </summary>
        public string Password { get; set; }

        /// <summary>
        /// Optional client metadata to provide in the Initiate Admin Authentication API call
        /// </summary>
        public IDictionary<string, string> ClientMetadata { get; set; }
    }
}
