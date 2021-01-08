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
using Amazon.IdentityManagement;
using Amazon.IdentityManagement.Model;
using Amazon.Runtime;

namespace AWSSDK_DotNet.IntegrationTests.Utils
{
    public static class IAMTestUtil
    {
        private const string AssumeRolePolicyDocument = @"{
                ""Statement"":
                [
                {
                    ""Principal"":{""AWS"":""{AccountId}""},
                    ""Effect"":""Allow"",
                    ""Action"":[""sts:AssumeRole""]{Condition}
                }
                ]
            }";

        private const string AssumeRoleExternalIdCondition = @",
                    ""Condition"": {
                        ""StringEquals"": {
                            ""sts:ExternalId"": ""{ExternalId}""
                        }
                    }";

        private const string AllowListBucketsRolePolicyDocument = @"{
                ""Statement"" : [
                    {
                        ""Effect"" : ""Allow"",
                        ""Action"": [
                            ""s3:ListAllMyBuckets""
                        ],
                        ""Resource"" : ""*""
                    }
                ]
            }";

        private const string AssumeRoleUserPolicyDocument = @"{
                ""Statement"":{
                    ""Effect"":""Allow"",
                    ""Action"":""sts:AssumeRole"",
                    ""Resource"":""*""
                }
            }";

        public static BasicAWSCredentials CreateTestRoleAndUser(string roleName, string userName, string externalId)
        {
            var assumeRolePolicy = AssumeRolePolicyDocument.Replace("{AccountId}", UtilityMethods.AccountId);
            if (string.IsNullOrEmpty(externalId))
            {
                assumeRolePolicy = assumeRolePolicy.Replace("{Condition}","");
            }
            else
            {
                assumeRolePolicy = assumeRolePolicy.Replace("{Condition}", AssumeRoleExternalIdCondition.Replace("{ExternalId}", externalId));
            }
            using (var iamClient = new AmazonIdentityManagementServiceClient())
            {
                var role = iamClient.CreateRole(new CreateRoleRequest
                {
                    RoleName = roleName,
                    AssumeRolePolicyDocument = assumeRolePolicy
                }).Role;

                iamClient.PutRolePolicy(new PutRolePolicyRequest
                {
                    RoleName = role.RoleName,
                    PolicyName = "allow-list-buckets",
                    PolicyDocument = AllowListBucketsRolePolicyDocument
                });

                var user = iamClient.CreateUser(new CreateUserRequest
                {
                    UserName = userName
                }).User;

                iamClient.PutUserPolicy(new PutUserPolicyRequest
                {
                    UserName = user.UserName,
                    PolicyName = "assume-policy-1",
                    PolicyDocument = AssumeRoleUserPolicyDocument
                });

                var accessKey = iamClient.CreateAccessKey(new CreateAccessKeyRequest
                {
                    UserName = userName
                }).AccessKey;

                return new BasicAWSCredentials(accessKey.AccessKeyId, accessKey.SecretAccessKey);
            }
        }

        public static void CleanupTestRoleAndUser(string roleName, string userName)
        {
            using (var iamClient = new AmazonIdentityManagementServiceClient())
            {
                try
                {
                    var rolePolicies = iamClient.ListRolePolicies(new ListRolePoliciesRequest { RoleName = roleName }).PolicyNames;
                    foreach (var policy in rolePolicies)
                    {
                        iamClient.DeleteRolePolicy(new DeleteRolePolicyRequest
                        {
                            RoleName = roleName,
                            PolicyName = policy
                        });
                    }
                    iamClient.DeleteRole(new DeleteRoleRequest { RoleName = roleName });
                }
                catch(NoSuchEntityException)
                {
                    //this is ok - only clean up if it exists
                }

                try
                {
                    var userPolicies = iamClient.ListUserPolicies(new ListUserPoliciesRequest { UserName = userName }).PolicyNames;
                    foreach (var policy in userPolicies)
                    {
                        iamClient.DeleteUserPolicy(new DeleteUserPolicyRequest
                        {
                            UserName = userName,
                            PolicyName = policy
                        });
                    }
                    var accessKeys = iamClient.ListAccessKeys(new ListAccessKeysRequest { UserName = userName });
                    foreach (var accessKey in accessKeys.AccessKeyMetadata)
                    {
                        iamClient.DeleteAccessKey(new DeleteAccessKeyRequest
                        {
                            UserName = userName,
                            AccessKeyId = accessKey.AccessKeyId
                        });
                    }
                    iamClient.DeleteUser(new DeleteUserRequest { UserName = userName });
                }
                catch (NoSuchEntityException)
                {
                    //this is ok - only clean up if it exists
                }
            }
        }
    }
}
