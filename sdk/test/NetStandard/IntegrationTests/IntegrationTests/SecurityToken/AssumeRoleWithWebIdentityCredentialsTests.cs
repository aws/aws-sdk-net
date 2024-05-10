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
using Amazon.Runtime;
using Amazon.IdentityManagement;
using Amazon.IdentityManagement.Model;
using Amazon.DNXCore.IntegrationTests;
using System.IO;
using Xunit;

namespace AWSSDK_DotNet.IntegrationTests.Tests
{
    public class AssumeRoleWithWebIdentityAWSCredentialsTests : TestBase<AmazonIdentityManagementServiceClient>
    {
        [Fact(Skip="Disabling to avoid requiring permissions to create an IAM role.")]
        [Trait(CategoryAttribute, "SecurityTokenService")]
        public async void TestAssumeRoleWithWebIdentityCredentialsUsesAnonymousAWSCredentialsToFetch()
        {
            var user = await Client.GetUserAsync();
            var createRoleRequest = new CreateRoleRequest()
            {
                RoleName = "DummyAccountRole",
                AssumeRolePolicyDocument = "{\"Version\": \"2012-10-17\", \"Statement\": [{ \"Effect\": \"Allow\",\"Principal\": {\"AWS\": \"" + user.User.Arn + "\"},\"Action\": \"sts:AssumeRole\",\"Condition\": {}}]}"
            };
            var role = await Client.CreateRoleAsync(createRoleRequest);

            var dummyToken = "dummyToken";
            var dummyRoleArn = role.Role.Arn;
            var dummyRoleSessionName = "dummyRoleSessionName";
            var dummyOptions = new AssumeRoleWithWebIdentityCredentialsOptions();
            var currentDirectory = Directory.GetCurrentDirectory();
            var webIdentityTokenFilePath = Path.Combine(currentDirectory, "my-token.jwt");
            File.WriteAllText(webIdentityTokenFilePath, dummyToken);

            var webIdentityCredentials = new AssumeRoleWithWebIdentityCredentials(webIdentityTokenFilePath, dummyRoleArn, dummyRoleSessionName, dummyOptions);
            try
            {
                var fetchedCredentials = webIdentityCredentials.GetCredentials();
            }
            catch (AmazonClientException e)
            {
                Assert.Equal("InvalidIdentityToken", ((AmazonServiceException)e.InnerException).ErrorCode);
            }
            finally
            {
                var deleteRoleRequest = new DeleteRoleRequest() { RoleName = role.Role.RoleName };
                await Client.DeleteRoleAsync(deleteRoleRequest);
            }
        }
    }
}
