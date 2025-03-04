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

using System;
using System.Net;
using Amazon.EC2.Model;
using AWSSDK_DotNet.CommonTest.Utils;
using AWSSDK_DotNet.IntegrationTests.Utils;
using AWSSDK_DotNet.UnitTests.TestTools;
using Amazon.Runtime;
using Amazon.Util;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace AWSSDK.UnitTests
{
    [TestClass]
    public class InstanceProfileAWSCredentialsTest
    {
        [TestMethod]
        public void TestNullRole()
        {
            AssertExtensions.ExpectException(() =>
            {
                var creds = new InstanceProfileAWSCredentials(role: null);
            }, typeof(ArgumentNullException), "Value cannot be null." + Environment.NewLine + "Parameter name: role");
        }

        [TestMethod]
        public void TestEmptyRole()
        {
            AssertExtensions.ExpectException(() =>
            {
                var creds = new InstanceProfileAWSCredentials(String.Empty);
            }, typeof(ArgumentException), "The argument 'role' must contain a valid role name.");
        }

        [TestMethod]
        public void TestWhitespaceRole()
        {
            AssertExtensions.ExpectException(() =>
            {
                var creds = new InstanceProfileAWSCredentials(" ");
            }, typeof(ArgumentException), "The argument 'role' must contain a valid role name.");
        }

        /// <summary>
        /// Test covering the scenario where IMDS experiences a service disruption
        /// and ensures expired credentials are continued to be reused.
        /// </summary>
        [TestMethod]
        public void StaticStabilityWhenIMDSExperiencesAnOutageScenarioTest()
        {
            var currentTime = new DateTime(1997, 8, 29, 16, 20, 0, DateTimeKind.Utc);

            var token = "ValidToken";
            
            var profileMetadata = new IAMInstanceProfileMetadata
            {
                InstanceProfileArn = "profile_arn",
                InstanceProfileId = "profile_id"
            };

            var validCredentialMetadata = new IAMSecurityCredentialMetadata
            {
                AccessKeyId = "value1",
                SecretAccessKey = "secret1",
                Expiration = currentTime.AddMinutes(75)
            };

            var expiredCredentialMetadata = new IAMSecurityCredentialMetadata
            {
                AccessKeyId = "expired",
                SecretAccessKey = "expired",
                Expiration = currentTime.Subtract(TimeSpan.FromMinutes(5))
            };

            var validCredentialMetadata2 = new IAMSecurityCredentialMetadata
            {
                AccessKeyId = "value2",
                SecretAccessKey = "secret2",
                Expiration = currentTime.AddHours(6)
            };

            using (new AWSConfigsDateFaker(() => currentTime.ToUniversalTime())) 
            using (var imdsServlet = new EC2InstanceMetadataServlet())
            {
                var instanceProfileAwsCredentials =
                    new InstanceProfileAWSCredentials(
                        // use a dummy role so InstanceProfileAWSCredentials doesn't try and call imds server to resolve role
                        role: "dummyRole",
                        proxy: null);

                // EXPIRED TEST 1 & 2 - can use IMDS provider if first IMDS call returns expired creds
                // Given IMDS service immediately returns an expired credential
                imdsServlet.AddTokenFetchResponse(token);
                imdsServlet.AddMetadataSecurityInfoResponse(profileMetadata, token);
                imdsServlet.AddMetadataGetSecurityCredentialsResponse(expiredCredentialMetadata, token);
                // When InstanceProfileAWSCredentials returns a Credential
                var expiredInitialCreds = instanceProfileAwsCredentials.GetCredentials();
                // Then the Credential is valid and be used to call a Service
                AssertAreEqual(expiredCredentialMetadata, expiredInitialCreds);

                // REFRESH TEST 2/LOGGING TEST - Can send a request after receiving a 500
                // Given 20 minutes has passed (expired credential cache time is up to 15 minutes)
                currentTime += TimeSpan.FromMinutes(20);
                // Given the IMDS service is running normally
                imdsServlet.AddTokenFetchResponse(token);
                imdsServlet.AddMetadataSecurityInfoResponse(profileMetadata, token);
                imdsServlet.AddMetadataGetSecurityCredentialsResponse(validCredentialMetadata, token);
                // When InstanceProfileAWSCredentials returns a Credential
                var initialCreds = instanceProfileAwsCredentials.GetCredentials();
                // Then the Credential is valid and be used to call a Service
                AssertAreEqual(validCredentialMetadata, initialCreds);

                // Given 1 hour has passed (default credential cache time is 1 hour)
                currentTime += TimeSpan.FromMinutes(65);
                // And the IMDS service returns 5xx error
                imdsServlet.AddTokenFetchResponse(token);
                imdsServlet.AddMetadataSecurityInfoResponse(profileMetadata, token);
                imdsServlet.AddMetadataGenericResponse(contents:"", token: token, HttpStatusCode.ServiceUnavailable);
                
                // When InstanceProfileAWSCredentials returns the previously valid Credential
                var badCreds = instanceProfileAwsCredentials.GetCredentials();
                // Then the Credential is the previously valid Credential and can be used to call a Service
                AssertAreEqual(validCredentialMetadata, badCreds);
                // And there is a log message that an expired credential is being used

                // Given 90 minutes has passed (credential cache time is up to 60 minutes)
                currentTime += TimeSpan.FromMinutes(90);
                // And the IMDS service is running normally (again)
                imdsServlet.AddTokenFetchResponse(token);
                imdsServlet.AddMetadataSecurityInfoResponse(profileMetadata, token);
                imdsServlet.AddMetadataGetSecurityCredentialsResponse(validCredentialMetadata2, token);
                // When InstanceProfileAWSCredentials returns a Credential
                var goodCreds2 = instanceProfileAwsCredentials.GetCredentials();
                // Then the Credential is valid and be used to call a Service
                AssertAreEqual(validCredentialMetadata2, goodCreds2);

                // EXPIRED TEST 3 - Can perform 3 successive requests with expired credentials. IMDS must only be called once.

                // Given IMDS service immediately returns an expired credential
                imdsServlet.AddTokenFetchResponse(token);
                imdsServlet.AddMetadataSecurityInfoResponse(profileMetadata, token);
                imdsServlet.AddMetadataGetSecurityCredentialsResponse(expiredCredentialMetadata, token);
                // When InstanceProfileAWSCredentials returns a Credential
                var creds1 = instanceProfileAwsCredentials.GetCredentials();
                // And InstanceProfileAWSCredentials returns a Credential
                var creds2 = instanceProfileAwsCredentials.GetCredentials();
                // And InstanceProfileAWSCredentials returns a Credential
                var creds3 = instanceProfileAwsCredentials.GetCredentials();
                // Then IMDS is only called once
                // (imdsServlet would have thrown an exception if an additional call was made)
            }
        }

        private void AssertAreEqual(IAMSecurityCredentialMetadata metadata, ImmutableCredentials creds)
        {
            Assert.AreEqual(metadata.AccessKeyId, creds.AccessKey);
            Assert.AreEqual(metadata.SecretAccessKey, creds.SecretKey);
            Assert.AreEqual(metadata.Token ?? "", creds.Token ?? "");
        }
    }
}
