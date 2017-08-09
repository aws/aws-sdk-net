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
using Xunit;

using Amazon.CognitoIdentityProvider.Model;

namespace Amazon.Extensions.CognitoAuthentication.IntegrationTests
{
    public class SessionTests : AuthenticationConfirmUserTests
    {
        // Tests the ChangePassword method in CognitoUser to fail due to no valid session
        [Fact]
        public async void TestFailedChangePassword()
        {
            await Assert.ThrowsAsync<NotAuthorizedException>(() => user.ChangePasswordAsync("PassWord1!", "PassWord2!"));
        }

        // Tests that a CognitoUser object has a valid session object after being authenticated
        [Fact]
        public async Task TestValidSession()
        {
            AuthFlowResponse context =
                await user.StartWithSrpAuthAsync(new InitiateSrpAuthRequest()
                {
                    Password = "PassWord1!"
                }).ConfigureAwait(false);

            Assert.True(user.SessionTokens.IsValid());
        }

        // Tests for successful use of the GetDetails method (requires valid session)
        [Fact]
        public async Task TestGetUserDetails()
        {
            AuthFlowResponse context =
                await user.StartWithSrpAuthAsync(new InitiateSrpAuthRequest()
                {
                    Password = "PassWord1!"
                }).ConfigureAwait(false);
            GetUserResponse userDetails = await user.GetUserDetailsAsync().ConfigureAwait(false);

            Assert.True(string.Equals(userDetails.UserAttributes[2].Name, CognitoConstants.UserAttrEmail, StringComparison.Ordinal));
            Assert.Empty(userDetails.MFAOptions);
        }

        //Tests the GlobalSignOut method
        [Fact]
        public async Task TestGlobalSignOut()
        {
            AuthFlowResponse context =
                await user.StartWithSrpAuthAsync(new InitiateSrpAuthRequest()
                {
                    Password = "PassWord1!"
                }).ConfigureAwait(false);

            await user.GlobalSignOutAsync().ConfigureAwait(false);

            Assert.Null(user.SessionTokens);
        }
    }
}