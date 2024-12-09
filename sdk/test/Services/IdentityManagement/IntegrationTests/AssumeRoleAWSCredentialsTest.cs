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
using Amazon.S3;
using Amazon.S3.Model;
using Amazon.SecurityToken;
using Amazon.SecurityToken.Model;
using AWSSDK_DotNet.IntegrationTests.Utils;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Net;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading;

namespace AWSSDK_DotNet.IntegrationTests.Tests
{
    [TestClass]
    public class AssumeRoleAWSCredentialsTest
    {
        private const string CredentialErrorMessage = "Error calling AssumeRole for role ";
        private const string TestUserName = "shared-credentials-file-user";
        private const string TestRoleName = "shared-credentials-file-role";
        private const string MfaCallbackErrorMessage = "The MfaSerialNumber has been set but the MfaTokenCodeCallback hasn't";
        private const string SecurityTokenErrorMessage = "The security token included in the request is invalid";
        private static readonly string MfaTokenCodeErrorMessage = "Making sure the MFA Token Code callback is being called.";
        private static readonly string TestExternalId = Guid.NewGuid().ToString();
        private static readonly string TestMfaSerialNumber = Guid.NewGuid().ToString();

        [Ignore("Excluding tests that need IAM Write/Permissions management.")]
        [TestMethod]
        [TestCategory("SecurityToken")]
        [TestCategory("IdentityManagement")]
        public void MfaProfileTokenCodeCallback()
        {
            // Since it's not practical to integ test the MFA, at least test that the callback to get
            // the MFA token code is being called correctly.
            // (An AssumeRoleAWSCredentials object with an MFA token code callback has been tested manually.)
            AssertExtensions.ExpectException(() =>
            {
                throw AssertExtensions.ExpectException(() =>
                {
                    TestAssumeRoleProfile(null, null, TestMfaSerialNumber, () =>
                    {
                        throw new Exception(MfaTokenCodeErrorMessage);
                    }, true, false);
                }, typeof(AmazonClientException), new Regex(CredentialErrorMessage)).InnerException;
            }, typeof(Exception), MfaTokenCodeErrorMessage);
        }

        [Ignore("Excluding tests that need IAM Write/Permissions management.")]
        [TestMethod]
        [TestCategory("SecurityToken")]
        [TestCategory("IdentityManagement")]
        public void MfaProfileNoTokenCodeCallback()
        {
            AssertExtensions.ExpectException(() =>
            {
                throw AssertExtensions.ExpectException(() =>
                {
                    TestAssumeRoleProfile(null, null, TestMfaSerialNumber, null, true, false);
                }, typeof(AmazonClientException), new Regex(CredentialErrorMessage)).InnerException;
            }, typeof(InvalidOperationException), new Regex(MfaCallbackErrorMessage));
        }

        [Ignore("Excluding tests that need IAM Write/Permissions management.")]
        [TestMethod]
        [TestCategory("SecurityToken")]
        [TestCategory("IdentityManagement")]
        public void NoExternalIdButExpected()
        {
            AssertExtensions.ExpectException(() =>
            {
                throw AssertExtensions.ExpectException(() =>
                {
                    TestAssumeRoleProfile(null, TestExternalId, null, null, true, false);
                }, typeof(AmazonClientException), new Regex(CredentialErrorMessage)).InnerException;
            }, typeof(AmazonSecurityTokenServiceException), new Regex(SecurityTokenErrorMessage));
        }

        [Ignore("Excluding tests that need IAM Write/Permissions management.")]
        [TestMethod]
        [TestCategory("SecurityToken")]
        [TestCategory("IdentityManagement")]
        public void ExternalIdProvidedButNotExpected()
        {
            AssertExtensions.ExpectException(() =>
            {
                throw AssertExtensions.ExpectException(() =>
                {
                    TestAssumeRoleProfile(TestExternalId, null, null, null, true, false);
                }, typeof(AmazonClientException), new Regex(CredentialErrorMessage)).InnerException;
            }, typeof(AmazonSecurityTokenServiceException), new Regex(SecurityTokenErrorMessage));
        }

        [Ignore("Excluding tests that need IAM Write/Permissions management.")]
        [TestMethod]
        [TestCategory("SecurityToken")]
        [TestCategory("IdentityManagement")]
        public void ExternalId()
        {
            TestAssumeRoleProfile(TestExternalId, TestExternalId, null, null, false, false);
        }

        [Ignore("Excluding tests that need IAM Write/Permissions management.")]
        [TestMethod]
        [TestCategory("SecurityToken")]
        [TestCategory("IdentityManagement")]
        public void NoExternalId()
        {
            TestAssumeRoleProfile(null, null, null, null, false, false);
        }

        [Ignore("Excluding tests that need IAM Write/Permissions management.")]
        [TestMethod]
        [TestCategory("SecurityToken")]
        [TestCategory("IdentityManagement")]
        public void AssumeRoleWithSessionCredentials()
        {
            TestAssumeRoleProfile(null, null, null, null, false, true);
        }

        public void TestAssumeRoleProfile(string roleExternalId, string credentialsExternalId,
            string mfaSerialNumber, Func<string> mfaTokenCallback, bool expectFailure, bool sessionCredsAsSource)
        {
            try
            {
                // clean up at start in case a test dies in the middle of clean up and is restarted
                IAMTestUtil.CleanupTestRoleAndUser(TestRoleName, TestUserName);

                var roleArn = "arn:aws:iam::" + UtilityMethods.AccountId + ":role/" + TestRoleName;
                var newCredentials = IAMTestUtil.CreateTestRoleAndUser(TestRoleName, TestUserName, roleExternalId);
                var sourceCredentials = sessionCredsAsSource ? GetSessionCredentials(newCredentials) : newCredentials;

                var options = new AssumeRoleAWSCredentialsOptions()
                {
                    ExternalId = credentialsExternalId,
                    MfaSerialNumber = mfaSerialNumber,
                    MfaTokenCodeCallback = mfaTokenCallback
                };

                var assumeRoleCredentials = new AssumeRoleAWSCredentials(sourceCredentials, roleArn, TestRoleName, options);

                TestCredentials(assumeRoleCredentials, expectFailure);
            }
            finally
            {
                IAMTestUtil.CleanupTestRoleAndUser(TestRoleName, TestUserName);
            }
        }

        private AWSCredentials GetSessionCredentials(AWSCredentials credentials)
        {
            using (var stsClient = new AmazonSecurityTokenServiceClient(credentials))
            {
                GetSessionTokenResponse response = null;

                // wait for eventual consistency of user creation
                UtilityMethods.WaitUntil(() =>
                {
                    try
                    {
                        response = stsClient.GetSessionToken();
                        return true;
                    }
                    catch (AmazonSecurityTokenServiceException e)
                    {
                        if (String.Equals(e.ErrorCode, "InvalidClientTokenId", StringComparison.OrdinalIgnoreCase))
                            return false;
                        else
                            throw e;
                    }
                });

                Assert.IsNotNull(response);
                Assert.IsNotNull(response.Credentials);

                return new SessionAWSCredentials(response.Credentials.AccessKeyId,
                    response.Credentials.SecretAccessKey, response.Credentials.SessionToken);
            }
        }

        private static void TestCredentials(AssumeRoleAWSCredentials assumeRoleCredentials, bool expectFailure)
        {
            ListBucketsResponse response = null;
            using (var client = new AmazonS3Client(assumeRoleCredentials))
            {
                // user/role setup may not be complete
                // so retry for a bit before giving up
                var stopTime = DateTime.UtcNow.AddSeconds(30);
                while (response == null && DateTime.UtcNow < stopTime)
                {
                    var doSleep = true;
                    try
                    {
                        response = client.ListBuckets();
                        Assert.AreEqual(HttpStatusCode.OK, response.HttpStatusCode);
                        doSleep = false;
                    }
                    catch (AmazonClientException)
                    {
                        // no need to retry if we're expecting a failure
                        if (expectFailure)
                        {
                            throw;
                        }
                    }
                    catch (AmazonServiceException)
                    {
                    }

                    if (doSleep)
                    {
                        Thread.Sleep(1000);
                    }
                }
            }

            if (expectFailure)
            {
                Assert.Fail("The test did not receive the expected authentication failure.");
            }
            else
            {
                Assert.IsNotNull(response, "Unable to use AssumeRoleCredentials to successfully complete a request.");
            }
        }
    }
}
