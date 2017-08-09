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
    public partial class CognitoUser
    { 
        /// <summary>
        /// The client secret for the associated client, if one is set
        /// </summary>
        private string ClientSecret { get; set; }

        /// <summary>
        /// The secret hash for the associated user, if a client secret is set
        /// </summary>
        internal string SecretHash { get; set; }

        /// <summary>
        /// The session for the associated user.
        /// </summary>
        public CognitoUserSession SessionTokens { get; set; }

        /// <summary>
        /// The CognitoDevice associated with this user, if exists
        /// </summary>
        public CognitoDevice Device { get; set; }

        /// <summary>
        /// The userID of the associated user. UserID can only be configured through the 
        /// constructor,  and once set it cannot be changed.
        /// </summary>
        public string UserID { get; private set; }

        /// <summary>
        /// The username of the associated user. Username can only be configured through the 
        /// constructor, and once set it cannot be changed.
        /// </summary>
        public string Username { get; private set; }

        /// <summary>
        /// The user pool of the associated user. UserPool can only be configured through 
        /// the constructor, and once set it cannot be changed.
        /// </summary>
        public CognitoUserPool UserPool { get; private set; }

        /// <summary>
        /// The clientID of the associated user. ClientID can only be configured through 
        /// the constructor, and once set it cannot be changed.
        /// </summary>
        public string ClientID { get; private set; }

        /// <summary>
        /// The AmazonCognitoIdentityProviderClient of the associated user. Provider can 
        /// only be configured through the constructor, and once set it cannot be changed.
        /// </summary>
        internal AmazonCognitoIdentityProviderClient Provider { get; private set; }

        /// <summary>
        /// The attributes of the associated user. 
        /// </summary>
        public Dictionary<string, string> Attributes { get; set; }

        /// <summary>
        /// The settings of the associated user.
        /// </summary>
        public Dictionary<string, string> Settings { get; set; }

        /// <summary>
        /// Private property to get and set the pool name of the user pool the user 
        /// is associated with.
        /// </summary>
        private string PoolName { get; set; }

        /// <summary>
        /// Creates an instance of CognitoUser
        /// </summary>
        /// <param name="userID">UserID of the specified user</param>
        /// <param name="clientID">ClientID associated with the user pool</param>
        /// <param name="pool">CognitoUserPool this user is associated with </param>
        /// <param name="provider">AmazonCognitoIdentityProviderClient for the specified user pool</param>
        /// <param name="clientSecret">Client secret for the specified client, if exists</param>
        /// <param name="username">Username for user, if different from userID</param>
        public CognitoUser(string userID, string clientID,
                           CognitoUserPool pool,
                           AmazonCognitoIdentityProviderClient provider,
                           string clientSecret = null,
                           string username = null)
        {
            if(pool.PoolID.Contains("_"))
            {
                this.PoolName = pool.PoolID.Split('_')[1];
            }
            else
            {
                throw new ArgumentException("Pool's poolID malformed, should be of the form <region>_<poolname>.");
            }

            this.ClientSecret = clientSecret;
            if (!string.IsNullOrEmpty(clientSecret))
            {
                this.SecretHash = Util.GetUserPoolSecretHash(userID, clientID, clientSecret);
            }

            this.UserID = userID;
            this.Username = userID;
            if (!string.IsNullOrEmpty(username))
            {
                this.Username = username;
            }
            else
            {
                this.Username = userID;
            }

            this.UserPool = pool;
            this.ClientID = clientID;
            this.SessionTokens = null;

            this.Provider = provider;
            this.Provider.BeforeRequestEvent += Util.ServiceClientBeforeRequestEvent;
        }

        /// <summary>
        /// Confirms the sign up of the associated user using the provided confirmation code
        /// using an asynchronous call
        /// </summary>
        /// <param name="confirmationCode">Confirmation code sent to user via email or SMS</param>
        /// <param name="forcedAliasCreation">Boolean specifying whether forced alias creation is desired</param>
        public Task ConfirmSignUpAsync(string confirmationCode, bool forcedAliasCreation)
        {
            ConfirmSignUpRequest confirmRequest = CreateConfirmSignUpRequest(confirmationCode, forcedAliasCreation);

            return Provider.ConfirmSignUpAsync(confirmRequest);
        }

        /// <summary>
        /// Request to resend registration confirmation code for a user using an asynchronous call
        /// </summary>
        /// <returns>Returns the delivery details for the confirmation code request</returns>
        public Task ResendConfirmationCodeAsync()
        {
            ResendConfirmationCodeRequest resendRequest = CreateResendConfirmationCodeRequest();

            return Provider.ResendConfirmationCodeAsync(resendRequest);
        }

        /// <summary>
        /// Allows the user to reset their password using an asynchronous call. Should be used in 
        /// conjunction with the ConfirmPasswordAsync method 
        /// </summary>
        public Task ForgotPasswordAsync()
        {
            ForgotPasswordRequest forgotPassRequest = CreateForgotPasswordRequest();

            return Provider.ForgotPasswordAsync(forgotPassRequest);
        }

        /// <summary>
        /// Confirms the user's new password using the confirmation code sent to them using
        /// an asynchronous call
        /// </summary>
        /// <param name="confirmationCode">The confirmation code sent to the suer</param>
        /// <param name="newPassword">The new desired password for the user</param>
        public Task ConfirmForgotPasswordAsync(string confirmationCode, string newPassword)
        {
            ConfirmForgotPasswordRequest confirmResetPassRequest =
                CreateConfirmPasswordRequest(confirmationCode, newPassword);

            return Provider.ConfirmForgotPasswordAsync(confirmResetPassRequest);
        }

        /// <summary>
        /// Allows an authenticated user to change their password using an
        /// asynchronous call
        /// </summary>
        /// <param name="oldPass">The user's old password</param>
        /// <param name="newPass">The desired new password</param>
        public Task ChangePasswordAsync(string oldPass, string newPass)
        {
            ChangePasswordRequest changePassRequest = CreateChangePasswordRequest(oldPass, newPass);

            return Provider.ChangePasswordAsync(changePassRequest);
        }

        /// <summary>
        /// Gets the details for the current user using an asynchronous call
        /// </summary>
        /// <returns>Returns a tuple containing the user attributes and settings, in that order</returns>
        public Task<GetUserResponse> GetUserDetailsAsync()
        {
            EnsureUserAuthenticated();

            GetUserRequest getUserRequest = new GetUserRequest()
            {
                AccessToken = SessionTokens.AccessToken
            };

            return Provider.GetUserAsync(getUserRequest);
        }

        /// <summary>
        /// Gets the attribute verification code for the specified attribute using
        /// an asynchronous call
        /// </summary>
        /// <param name="medium">Name of the attribute the verification code is being sent to.
        /// Should be either email or phone_number.</param>
        /// <returns>Returns the delivery details for the attribute verification code request</returns>
        public Task GetAttributeVerificationCodeAsync(string medium)
        {
            GetUserAttributeVerificationCodeRequest getAttributeCodeRequest =
                    CreateGetUserAttributeVerificationCodeRequest(medium);

            return Provider.GetUserAttributeVerificationCodeAsync(getAttributeCodeRequest);
        }

        /// <summary>
        /// Sign-out from all devices associated with this user using an asynchronous call
        /// </summary>
        public Task GlobalSignOutAsync()
        {
            EnsureUserAuthenticated();

            GlobalSignOutRequest globalSignOutRequest = new GlobalSignOutRequest()
            {
                AccessToken = SessionTokens.AccessToken
            };

            SessionTokens = null;
            return Provider.GlobalSignOutAsync(globalSignOutRequest);
        }

        /// <summary>
        /// Deletes the current user using an asynchronous call
        /// </summary>
        public Task DeleteUserAsync()
        {
            EnsureUserAuthenticated();

            DeleteUserRequest deleteUserRequest = new DeleteUserRequest()
            {
                AccessToken = SessionTokens.AccessToken
            };

            return Provider.DeleteUserAsync(deleteUserRequest);
        }

        /// <summary>
        /// Verifies the given attribute using an asynchronous call
        /// </summary>
        /// <param name="attributeName">Attribute to be verified. Should either be email or phone_number</param>
        /// <param name="verificationCode">The verification code for the attribute being verified</param>
        public Task VerifyAttributeAsync(string attributeName, string verificationCode)
        {
            VerifyUserAttributeRequest verifyUserAttributeRequest =
                CreateVerifyUserAttributeRequest(attributeName, verificationCode);

            return Provider.VerifyUserAttributeAsync(verifyUserAttributeRequest);
        }

        /// <summary>
        /// Updates the user's attributes defined in the attributes parameter (one at a time)
        /// using an asynchronous call
        /// </summary>
        /// <param name="attributes">The attributes to be updated</param>
        public async Task UpdateAttributesAsync(IDictionary<string, string> attributes)
        {
            UpdateUserAttributesRequest updateUserAttributesRequest =
                CreateUpdateUserAttributesRequest(attributes);

            await Provider.UpdateUserAttributesAsync(updateUserAttributesRequest).ConfigureAwait(false);

            //Update the local Attributes property
            foreach (KeyValuePair<string, string> entry in attributes)
            {
                Attributes[entry.Key] = entry.Value;
            }
        }

        /// <summary>
        /// Deletes the attributes specified in the attributeNamesToDelete list using
        /// an asynchronous call
        /// </summary>
        /// <param name="attributeNamesToDelete">List of attributes to delete</param>
        public async Task DeleteAttributesAsync(IList<string> attributeNamesToDelete)
        {
            DeleteUserAttributesRequest deleteUserAttributesRequest =
                CreateDeleteUserAttributesRequest(attributeNamesToDelete);

            await Provider.DeleteUserAttributesAsync(deleteUserAttributesRequest).ConfigureAwait(false);

            //Update the local Attributes property
            foreach (string attribute in attributeNamesToDelete)
            {
                if (Attributes.ContainsKey(attribute))
                {
                    Attributes.Remove(attribute);
                }
            }
        }

        /// <summary>
        /// Sets the MFAOptions to be the settings desibed in the userSettings dictionary
        /// using an asynchronous call
        /// </summary>
        /// <param name="userSettings">Dictionary for the user MFA settings of the form [attribute, delivery medium]</param>
        public async Task SetUserSettingsAsync(IDictionary<string, string> userSettings)
        {
            SetUserSettingsRequest setUserSettingsRequest = CreateSetUserSettingsRequest(userSettings);

            await Provider.SetUserSettingsAsync(setUserSettingsRequest).ConfigureAwait(false);

            //Update the local Settings property
            foreach (KeyValuePair<string, string> entry in userSettings)
            {
                Settings[entry.Key] = entry.Value;
            }
        }

        /// <summary>
        /// Lists the CognitoDevices associated with this user using an asynchronous call
        /// </summary>
        /// <param name="limit">Maxmimum number of devices to be returned in this call</param>
        /// <param name="paginationToken">Token to continue earlier search</param>
        /// <returns>Returns a list of CognitoDevices associated with this user</returns>
        public async Task<List<CognitoDevice>> ListDevicesAsync(int limit, string paginationToken)
        {
            ListDevicesRequest listDevicesRequest = CreateListDevicesRequest(limit, paginationToken);
            ListDevicesResponse listDevicesReponse = await Provider.ListDevicesAsync(listDevicesRequest).ConfigureAwait(false);
            List<CognitoDevice> devicesList = new List<CognitoDevice>();

            foreach (DeviceType device in listDevicesReponse.Devices)
            {
                devicesList.Add(new CognitoDevice(device, this));
            }

            return devicesList;
        }

        private ConfirmSignUpRequest CreateConfirmSignUpRequest(string confirmationCode, bool forcedAliasCreation)
        {
            ConfirmSignUpRequest confirmRequest = new ConfirmSignUpRequest()
            {
                ClientId = ClientID,
                Username = Username,
                ForceAliasCreation = forcedAliasCreation,
                ConfirmationCode = confirmationCode
            };

            if (!string.IsNullOrEmpty(SecretHash))
            {
                confirmRequest.SecretHash = SecretHash;
            }

            return confirmRequest;
        }

        private ResendConfirmationCodeRequest CreateResendConfirmationCodeRequest()
        {
            ResendConfirmationCodeRequest resendRequest = new ResendConfirmationCodeRequest()
            {
                Username = Username,
                ClientId = ClientID
            };

            if (!string.IsNullOrEmpty(SecretHash))
            {
                resendRequest.SecretHash = SecretHash;
            }

            return resendRequest;
        }

        private ForgotPasswordRequest CreateForgotPasswordRequest()
        {
            ForgotPasswordRequest forgotPassRequest = new ForgotPasswordRequest()
            {
                ClientId = ClientID,
                Username = Username
            };

            if (!string.IsNullOrEmpty(SecretHash))
            {
                forgotPassRequest.SecretHash = SecretHash;
            }

            return forgotPassRequest;
        }

        private ConfirmForgotPasswordRequest CreateConfirmPasswordRequest(string confirmationCode, string newPassword)
        {
            ConfirmForgotPasswordRequest confirmResetPassRequest = new ConfirmForgotPasswordRequest()
            {
                Username = Username,
                ClientId = ClientID,
                Password = newPassword,
                ConfirmationCode = confirmationCode
            };

            if (!string.IsNullOrEmpty(SecretHash))
            {
                confirmResetPassRequest.SecretHash = SecretHash;
            }

            return confirmResetPassRequest;
        }

        private ChangePasswordRequest CreateChangePasswordRequest(string oldPass, string newPass)
        {
            EnsureUserAuthenticated();

            ChangePasswordRequest changePassRequest = new ChangePasswordRequest()
            {
                PreviousPassword = oldPass,
                ProposedPassword = newPass,
                AccessToken = SessionTokens.AccessToken
            };

            return changePassRequest;
        }

        private GetUserAttributeVerificationCodeRequest CreateGetUserAttributeVerificationCodeRequest(string attributeName)
        {
            EnsureUserAuthenticated();

            GetUserAttributeVerificationCodeRequest getAttributeCodeRequest = new GetUserAttributeVerificationCodeRequest()
            {
                AccessToken = SessionTokens.AccessToken,
                AttributeName = attributeName
            };

            return getAttributeCodeRequest;
        }

        
        /// <summary>
        /// Internal function that creates a CognitoUserSession based on the authentication result
        /// </summary>
        /// <param name="authResult">An authentication result during authentication flow</param>
        /// <param name="refreshTokenOverride">Optional variable to override the refreshToken manually</param>
        /// <returns>Returns a CognitoUserSession based on the authentication result</returns>
        private CognitoUserSession GetCognitoUserSession(AuthenticationResultType authResult, string refreshTokenOverride = null)
        {
            string idToken = authResult.IdToken;
            string accessToken = authResult.AccessToken;
            string refreshToken;
            DateTime currentTime = DateTime.Now;

            if (!string.IsNullOrEmpty(refreshTokenOverride))
            {
                refreshToken = refreshTokenOverride;
            }
            else
            {
                refreshToken = authResult.RefreshToken;
            }

            return new CognitoUserSession(idToken, accessToken, refreshToken, currentTime, currentTime.AddSeconds(authResult.ExpiresIn));
        }

        /// <summary>
        /// Sign-out by making the invalidating user session
        /// </summary>
        public void SignOut()
        {
            this.SessionTokens = null;
        }

        private VerifyUserAttributeRequest CreateVerifyUserAttributeRequest(string attributeName, string verificationCode)
        {
            EnsureUserAuthenticated();

            VerifyUserAttributeRequest verifyUserAttributeRequest = new VerifyUserAttributeRequest()
            {
                AttributeName = attributeName,
                AccessToken = SessionTokens.AccessToken,
                Code = verificationCode
            };

            return verifyUserAttributeRequest;
        }

        private UpdateUserAttributesRequest CreateUpdateUserAttributesRequest(IDictionary<string, string> attributes)
        {
            EnsureUserAuthenticated();

            UpdateUserAttributesRequest updateUserAttributesRequest = new UpdateUserAttributesRequest()
            {
                AccessToken = SessionTokens.AccessToken,
                UserAttributes = Util.CreateAttributeList(attributes)
            };

            return updateUserAttributesRequest;
        }

        private DeleteUserAttributesRequest CreateDeleteUserAttributesRequest(IList<string> attributeNamesToDelete)
        {
            if (attributeNamesToDelete == null || attributeNamesToDelete.Count < 1)
            {
                throw new ArgumentNullException("attributeNamesToDelete cannot be null or empty.", "attributeNamesToDelete");
            }

            EnsureUserAuthenticated();

            DeleteUserAttributesRequest deleteUserAttributesRequest = new DeleteUserAttributesRequest()
            {
                AccessToken = SessionTokens.AccessToken,
                UserAttributeNames = new List<string>(attributeNamesToDelete)
            };

            return deleteUserAttributesRequest;
        }

        private SetUserSettingsRequest CreateSetUserSettingsRequest(IDictionary<string, string> userSettings)
        {
            if (userSettings == null || userSettings.Count < 1)
            {
                throw new ArgumentNullException("userSettings cannot be null or empty.", "userSettings");
            }

            EnsureUserAuthenticated();

            List<MFAOptionType> settingsList = new List<MFAOptionType>();
            foreach (KeyValuePair<string, string> setting in userSettings)
            {
                settingsList.Add(new MFAOptionType() { AttributeName = setting.Key, DeliveryMedium = setting.Value });
            }

            SetUserSettingsRequest setUserSettingsRequest = new SetUserSettingsRequest()
            {
                AccessToken = SessionTokens.AccessToken,
                MFAOptions = settingsList
            };

            return setUserSettingsRequest;
        }

        private ListDevicesRequest CreateListDevicesRequest(int limit, string paginationToken)
        {
            EnsureUserAuthenticated();

            ListDevicesRequest listDevicesRequest = new ListDevicesRequest()
            {
                AccessToken = SessionTokens.AccessToken,
                Limit = limit,
                PaginationToken = paginationToken
            };

            return listDevicesRequest;
        }

        private void EnsureUserAuthenticated()
        {
            if (SessionTokens == null || !SessionTokens.IsValid())
            {
                throw new NotAuthorizedException("User is not authenticated.");
            }
        }
    }
}