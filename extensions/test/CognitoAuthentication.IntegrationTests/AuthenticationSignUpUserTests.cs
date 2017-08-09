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
using Xunit;

using Amazon.CognitoIdentityProvider.Model;

namespace Amazon.Extensions.CognitoAuthentication.IntegrationTests
{
    public class AuthenticationSignUpUserTests : BaseAuthenticationTestClass
    {
        public AuthenticationSignUpUserTests() : base()
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
            user = new CognitoUser("User5", pool.ClientID, pool, provider);
        }

        // Tests the SignUp method (using random, dummy email)
        [Fact]
        public async Task TestSignUpProcess()
        {
            string userID = "User55";
            string password = "PassWord1!";
            Dictionary<string, string> userAttributes = new Dictionary<string, string>(StringComparer.Ordinal)
            {
                { CognitoConstants.UserAttrEmail, "xxx@yyy.zzz"}
            };
            Dictionary<string, string> validationData = new Dictionary<string, string>(StringComparer.Ordinal)
            {
                { CognitoConstants.UserAttrEmail, "xxx@yyy.zzz"}
            };

            await pool.SignUpAsync(userID, password, userAttributes, validationData).ConfigureAwait(false);

            ListUsersRequest listUsersRequest = new ListUsersRequest()
            {
                Limit = 2,
                UserPoolId = pool.PoolID
            };
            ListUsersResponse listUsersResponse = await provider.ListUsersAsync(listUsersRequest).ConfigureAwait(false);
            bool containsUser55 = false;

            foreach (UserType user in listUsersResponse.Users)
            {
                if (string.Equals(user.Username, userID, StringComparison.Ordinal))
                {
                    containsUser55 = true;
                }
            }

            Assert.True(containsUser55);
        }

        // Tests that ConfirmSignUp reaches the proper failure point with incorrect confirmation code
        [Fact]
        public void TestConfirmSignUpFail()
        {
            Assert.ThrowsAsync<CodeMismatchException>(() => user.ConfirmSignUpAsync("fakeConfirmationCode", false));
        }
    }
}
