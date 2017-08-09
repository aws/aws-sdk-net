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

using System;

using Amazon.CognitoIdentityProvider;
using Amazon.CognitoIdentityProvider.Model;

namespace Amazon.Extensions.CognitoAuthentication
{
    public class CognitoUserSession
    {
        /// <summary>
        /// The ID token associated with the current user session.
        /// </summary>
        public string IdToken { get; set; }

        /// <summary>
        /// The access token associated with the current user session.
        /// </summary>
        public string AccessToken { get; set; }

        /// <summary>
        /// The refresh token associated with the current user session.
        /// </summary>
        public string RefreshToken { get; set; }

        /// <summary>
        /// The expiration time associated with the current session's tokens. ExpirationTime 
        /// can only be configured through the constructor, and once set it cannot be changed.
        /// </summary>
        public DateTime ExpirationTime { get; private set; }

        /// <summary>
        /// The issue time associated with the current session's tokens. IssueTime 
        /// can only be configured through the constructor, and once set it cannot be changed.
        /// </summary>
        public DateTime IssuedTime { get; private set; }

        /// <summary>
        /// Creates an instance of CognitoUserSession
        /// </summary>
        /// <param name="idToken">The ID token for the current user session</param>
        /// <param name="accessToken">The access token for the current user session</param>
        /// <param name="refreshToken">The refresh token for the current user session</param>
        /// <param name="issuedTime">The time the tokens were issued</param>
        /// <param name="expirationTime">The time the tokens expire</param>
        public CognitoUserSession(string idToken, string accessToken, string refreshToken, 
                                  DateTime issuedTime, DateTime expirationTime)
        {
            this.IdToken = idToken;
            this.AccessToken = accessToken;
            this.RefreshToken = refreshToken;
            this.IssuedTime = issuedTime;
            this.ExpirationTime = expirationTime;
        }

        /// <summary>
        /// Determines if the tokens for a user are still valid
        /// </summary>
        /// <returns>Returns a boolean whether the user's tokens are still valid</returns>
        public bool IsValid()
        {
            DateTime currentTimeStamp = DateTime.Now;

            return (currentTimeStamp.CompareTo(ExpirationTime) < 0);
        }
    }
}
