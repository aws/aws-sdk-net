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

using System.Threading.Tasks;
using System.Collections.Generic;
using Xunit;

using Amazon.CognitoIdentityProvider.Model;

namespace Amazon.Extensions.CognitoAuthentication.IntegrationTests
{
    public class AuthenticationConfirmUserTests : BaseAuthenticationTestClass
    {
        public AuthenticationConfirmUserTests() : base()
        {
            SignUpRequest signUpRequest = new SignUpRequest()
            {
                ClientId = pool.ClientID,
                Password = "PassWord1!",
                Username = "User5",
                UserAttributes = new List<AttributeType>()
                {
                    new AttributeType() {Name=CognitoConstants.UserAttrEmail, Value="xxx@yyy.zzz"},
                },
                ValidationData = new List<AttributeType>()
                {
                   new AttributeType() {Name=CognitoConstants.UserAttrEmail, Value="xxx@yyy.zzz"}
                }
            };

            SignUpResponse signUpResponse = provider.SignUpAsync(signUpRequest).Result;

            AdminConfirmSignUpRequest confirmRequest = new AdminConfirmSignUpRequest()
            {
                Username = "User5",
                UserPoolId = pool.PoolID
            };
            AdminConfirmSignUpResponse confirmResponse = provider.AdminConfirmSignUpAsync(confirmRequest).Result;
            user = new CognitoUser("User5", pool.ClientID, pool, provider);
        }

        //Tests SRP authentication flow for web applications
        [Fact]
        public async void TestGenericSrpAuthentication()
        {
            string password = "PassWord1!";

            AuthFlowResponse context =
                await user.StartWithSrpAuthAsync(new InitiateSrpAuthRequest()
                {
                    Password = password
                }).ConfigureAwait(false);

            Assert.True(user.SessionTokens.IsValid());
        }

        // Tests the DeleteUser method
        [Fact]
        public async Task TestDeleteUser()
        {
            string userID = user.UserID;
            List<string> users = new List<string>();

            AuthFlowResponse context =
                await user.StartWithSrpAuthAsync(new InitiateSrpAuthRequest()
                {
                    Password = "PassWord1!"
                }).ConfigureAwait(false);

            ListUsersRequest listUsersRequest = new ListUsersRequest()
            {
                Limit = 60,
                UserPoolId = pool.PoolID
            };
            ListUsersResponse listUsersReponse = await provider.ListUsersAsync(listUsersRequest).ConfigureAwait(false);
            foreach (UserType listUser in listUsersReponse.Users)
            {
                users.Add(listUser.Username);
            }

            Assert.Contains(userID, users);

            await user.DeleteUserAsync().ConfigureAwait(false);

            listUsersReponse = await provider.ListUsersAsync(listUsersRequest).ConfigureAwait(false);
            users.Clear();
            foreach(UserType listUser in listUsersReponse.Users)
            {
                users.Add(listUser.Username);
            }

            Assert.DoesNotContain(userID, users);
        }
    }
}
