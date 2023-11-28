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
using Amazon.Runtime.CredentialManagement;
using Amazon.S3;
using AWSSDK_DotNet.CommonTest.Utils;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.IO;

namespace AWSSDK.UnitTests
{
    /// <summary>
    /// Tests the hierarchy of settings to disable session auth for S3Express
    /// </summary>
    [TestClass]
    public class DisableS3ExpressSessionAuthTests
    {

        private static readonly string ProfileText = @"[disable_s3express]
                                                         region=us-west-2
                                                         aws_access_key_id=default_aws_access_key_id
                                                         aws_secret_access_key=default_aws_secret_access_key
                                                         s3_disable_express_session_auth=true
                                                         [enable_s3express]
                                                         region=us-west-2
                                                         aws_access_key_id=other_aws_access_key_id
                                                         aws_secret_access_key=other_aws_secret_access_key
                                                         s3_disable_express_session_auth=false
                                                         ";



        private const string DisableS3ExpressSessionAuthVariable = "AWS_S3_DISABLE_EXPRESS_SESSION_AUTH";
        private const string AWSProfileVariable = "AWS_PROFILE";
        private string _beginningDisableS3ExpressSessionAuthEnvironmentValue;
        private string _beginningAWSProfileEnvironmentValue;
        private string _tempCredentialsFilePath;

        [TestInitialize]
        public void Initialize()
        {
            // Save off current environment variable value to restore later
            _beginningDisableS3ExpressSessionAuthEnvironmentValue = Environment.GetEnvironmentVariable(DisableS3ExpressSessionAuthVariable);
            _beginningAWSProfileEnvironmentValue = Environment.GetEnvironmentVariable(AWSProfileVariable);

            // Then clear the current value so every test is starting from a clean slate
            Environment.SetEnvironmentVariable(DisableS3ExpressSessionAuthVariable, "");
            Environment.SetEnvironmentVariable(AWSProfileVariable, "");

            // set credentials file and use it to load CredentialProfileStoreChain
            _tempCredentialsFilePath = Path.GetTempFileName();
            File.WriteAllText(_tempCredentialsFilePath, ProfileText);
            ReflectionHelpers.Invoke(typeof(AmazonS3Config), "credentialProfileChain", new CredentialProfileStoreChain(_tempCredentialsFilePath));
            ReflectionHelpers.Invoke(typeof(AmazonS3Config), "_triedToResolveProfile", false);
        }

        [TestCleanup]
        public void RestoreOriginalSettings()
        {
            Environment.SetEnvironmentVariable(DisableS3ExpressSessionAuthVariable, _beginningDisableS3ExpressSessionAuthEnvironmentValue);
            Environment.SetEnvironmentVariable(AWSProfileVariable, _beginningAWSProfileEnvironmentValue);
            File.Delete(_tempCredentialsFilePath);
        }

        [TestMethod]
        [TestCategory("S3")]
        public void CredentialProfileDisable_ShouldApplyToS3Config()
        {
            Environment.SetEnvironmentVariable(AWSProfileVariable, "disable_s3express");
            var config = new AmazonS3Config();
            Assert.IsTrue(config.DisableS3ExpressSessionAuth);

        }

        [TestMethod]
        [TestCategory("S3")]
        public void EnviromentVariableEnable_ShouldOverrideCredentialProfile()
        {
            Environment.SetEnvironmentVariable(AWSProfileVariable, "disable_s3express");
            Environment.SetEnvironmentVariable(DisableS3ExpressSessionAuthVariable, "false");
            var config = new AmazonS3Config();
            Assert.IsFalse(config.DisableS3ExpressSessionAuth);

        }

        [TestMethod]
        [TestCategory("S3")]
        public void ExplicitDisable_ShouldOverrideCredentialProfile()
        {
            Environment.SetEnvironmentVariable(AWSProfileVariable, "enable_s3express");

            var config = new AmazonS3Config
            {
                DisableS3ExpressSessionAuth = true
            };

            Assert.IsTrue(config.DisableS3ExpressSessionAuth);
        }

        [TestMethod]
        [TestCategory("S3")]
        public void EnabledByDefault()
        {
            var config = new AmazonS3Config();

            // S3ExpressSessionAuth should be enabled by default, so with no other configuration this should start at false
            Assert.IsFalse(config.DisableS3ExpressSessionAuth);
        }

        [TestMethod]
        [TestCategory("S3")]
        public void ExplicitDisable_ShouldOverrideEnvironmentVariable()
        {
            Environment.SetEnvironmentVariable(DisableS3ExpressSessionAuthVariable, "false");

            var config = new AmazonS3Config { DisableS3ExpressSessionAuth = true };

            // Disabling on the service client should supersede the environment variable value
            Assert.IsTrue(config.DisableS3ExpressSessionAuth);
        }

        [TestMethod]
        [TestCategory("S3")]
        public void DisabledViaEnvironmentVariable_ShouldApplyToS3Config()
        {
            Environment.SetEnvironmentVariable(DisableS3ExpressSessionAuthVariable, "true");

            var config = new AmazonS3Config();
            Assert.IsTrue(config.DisableS3ExpressSessionAuth);
        }
    }
}
