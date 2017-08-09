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
using System.Threading.Tasks;
using System.Collections.Generic;

using Amazon.CognitoIdentityProvider;
using Amazon.CognitoIdentityProvider.Model;

namespace Amazon.Extensions.CognitoAuthentication
{
    public partial class CognitoUserPool
    {
        /// <summary>
        /// The poolID associated with the user pool. PoolID can only be configured 
        /// through the constructor, and once set it cannot be changed.
        /// </summary>
        public string PoolID { get; private set; }

        /// <summary>
        /// The clientID associated with the user pool. ClientID can only be configured 
        /// through the constructor, and once set it cannot be changed.
        /// </summary>
        public string ClientID { get; private set; }

        internal AmazonCognitoIdentityProviderClient Provider { get; set; }

        private string ClientSecret { get; set; }

        /// <summary>
        /// Create an instance of CognitoUserPool
        /// </summary>
        /// <param name="poolID">PoolID of the associated user pool</param>
        /// <param name="clientID">ClientID for the associated user pool</param>
        /// <param name="provider">AmazonCognitoIdentityProviderClient for the specified user pool</param>
        /// <param name="clientSecret">Client secret for the corresponding clientID, if exists</param>
        public CognitoUserPool(string poolID, 
                               string clientID, 
                               AmazonCognitoIdentityProviderClient provider, 
                               string clientSecret = null)
        {
            if(!poolID.Contains("_"))
            {
                throw new ArgumentException("PoolID should be of the form <region>_<poolname>.", "poolID");
            }

            this.PoolID = poolID;
            this.ClientID = clientID;
            this.ClientSecret = clientSecret;

            this.Provider = provider;
            this.Provider.BeforeRequestEvent += Util.ServiceClientBeforeRequestEvent;
        }

        /// <summary>
        /// Signs up the user with the specified parameters using an asynchronous call
        /// </summary>
        /// <param name="userID">The userID of the user being created</param>
        /// <param name="password">The password of the user being created</param>
        /// <param name="userAttributes">The user attributes of the user being created</param>
        /// <param name="validationData">The validation data of the user being created</param>
        /// <returns>Returns the delivery details for the sign up request</returns>
        public Task SignUpAsync(string userID,
                           string password,
                           IDictionary<string, string> userAttributes,
                           IDictionary<string, string> validationData)
        {
            SignUpRequest signUpUserRequest = CreateSignUpRequest(userID, password, userAttributes, validationData);

            return Provider.SignUpAsync(signUpUserRequest);
        }

        /// <summary>
        /// Internal method to aid in the sign up flow for a new user
        /// </summary>
        /// <param name="userID">The userID of the user being created</param>
        /// <param name="password">The password of the user being created</param>
        /// <param name="userAttributes">The user attributes of the user being created</param>
        /// <param name="validationData">The validation data of the user being created</param>
        /// <returns>Returns the SignUpResponse for the sign up API request using the provided information</returns>
        private SignUpRequest CreateSignUpRequest(string userID,
                                              string password,
                                              IDictionary<string, string> userAttributes,
                                              IDictionary<string, string> validationData)
        {
            List<AttributeType> userAttributesList = null;
            if (userAttributes != null)
            {
                userAttributesList = Util.CreateAttributeList(userAttributes);
            }
            else
            {
                throw new ArgumentNullException("userAttributes", "userAttributes cannot be null.");
            }

            List<AttributeType> validationDataList = 
                validationData != null ? Util.CreateAttributeList(validationData) : null;

            // Create User registration request
            SignUpRequest signUpUserRequest = new SignUpRequest()
            {
                Username = userID,
                Password = password,
                ClientId = ClientID,
                UserAttributes = userAttributesList,
                ValidationData = validationDataList
            };

            if (!string.IsNullOrEmpty(ClientSecret))
            {
                signUpUserRequest.SecretHash = Util.GetUserPoolSecretHash(userID, ClientID, ClientSecret);
            }

            return signUpUserRequest;
        }

        /// <summary>
        /// Gets a CognitoUser with no userID set
        /// </summary>
        /// <returns>Returns a user with no userID set</returns>
        public CognitoUser GetUser()
        {
            return new CognitoUser(null, ClientID, this, Provider, ClientSecret);
        }

        /// <summary>
        /// Gets a CognitoUser with the corresponding userID
        /// </summary>
        /// <param name="userID">The userID of the corresponding user</param>
        /// <returns>Returns a CognitoUser with the corresponding userID</returns>
        public CognitoUser GetUser(string userID)
        {
            if (string.IsNullOrEmpty(userID))
            {
                return GetUser();
            }

            return new CognitoUser(userID, ClientID, this, Provider, ClientSecret);
        }
    }
}
