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
using Amazon.S3.Model.Internal.MarshallTransformations;
using AWSSDK_DotNet.IntegrationTests.Utils;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.IO;
using System.Collections.Generic;
using System.Text;

using Amazon;
using Amazon.Util;
using Amazon.Runtime.Internal;
using Amazon.S3.Internal;
using Amazon.Runtime.Internal.Auth;
using Amazon.Runtime.Internal.Util;
using System.Threading.Tasks;
using Amazon.Runtime.Internal.Transform;
using AWSSDK_DotNet.CommonTest.Utils;
using Amazon.Runtime.CredentialManagement;

namespace AWSSDK.UnitTests
{
    [TestClass]
    public class UseArnRegionTests
    {
        private const string AWS_S3_USE_ARN_REGION_ENVIRONMENT_VARIABLE = "AWS_S3_USE_ARN_REGION";
        private const string AWS_PROFILE_ENVIRONMENT_VARIABLE = "AWS_PROFILE";
        private const string AWS_CONFIG_ENVIRONMENT_VARIABLE = "AWS_CONFIG_FILE";

        private string _beginningS3UseArnRegionEnvironmentValue;
        private string _beginningAWSProfileEnvironmentValue;
        private string _tempCredentialsFilePath;

        private static readonly string ProfileText = new StringBuilder()
            .AppendLine("[default]")
            .AppendLine("region=us-west-2")
            .AppendLine("aws_access_key_id=default_aws_access_key_id")
            .AppendLine("aws_secret_access_key=default_aws_secret_access_key")
            .AppendLine("[profile use-arn-region-enabled]")
            .AppendLine("s3_use_arn_region=true")
            .AppendLine("[profile use-arn-region-disabled]")
            .AppendLine("s3_use_arn_region=false")
            .ToString();

        [TestInitialize]
        public void Initialize()
        {
            // Save off current environment variable value to restore later
            _beginningS3UseArnRegionEnvironmentValue = Environment.GetEnvironmentVariable(AWS_S3_USE_ARN_REGION_ENVIRONMENT_VARIABLE);
            _beginningAWSProfileEnvironmentValue = Environment.GetEnvironmentVariable(AWS_PROFILE_ENVIRONMENT_VARIABLE);
            // Then clear the current value so every test is starting from a clean slate
            Environment.SetEnvironmentVariable(AWS_PROFILE_ENVIRONMENT_VARIABLE, "");
            // set credentials file and use it to load CredentialProfileStoreChain

            _tempCredentialsFilePath = Path.GetTempFileName();
            File.WriteAllText(_tempCredentialsFilePath, ProfileText);
            ReflectionHelpers.Invoke(typeof(AmazonS3Config), "credentialProfileChain", new CredentialProfileStoreChain(_tempCredentialsFilePath));
            ReflectionHelpers.Invoke(typeof(AmazonS3Config), "_triedToResolveProfile", false);
        }

        [TestCleanup]
        public void RestoreOriginalSettings()
        {
            Environment.SetEnvironmentVariable(AWS_S3_USE_ARN_REGION_ENVIRONMENT_VARIABLE, _beginningS3UseArnRegionEnvironmentValue);
            Environment.SetEnvironmentVariable(AWS_PROFILE_ENVIRONMENT_VARIABLE, _beginningAWSProfileEnvironmentValue);
            File.Delete(_tempCredentialsFilePath);
        }

        [TestMethod]
        [TestCategory("S3")]
        public void ExplicitlyEnable()
        {
            var config = new AmazonS3Config
            {
                UseArnRegion = true
            };

            Assert.IsTrue(config.UseArnRegion);
        }

        [TestMethod]
        [TestCategory("S3")]
        public void EnvironmentVariableEnable()
        {
            Environment.SetEnvironmentVariable(AWS_S3_USE_ARN_REGION_ENVIRONMENT_VARIABLE, "true");

            var config = new AmazonS3Config
            {
            };

            Assert.IsTrue(config.UseArnRegion);
        }

        [TestMethod]
        [TestCategory("S3")]
        public void ExplicitDisableOverridesEnvironmentVariable()
        {
            Environment.SetEnvironmentVariable(AWS_S3_USE_ARN_REGION_ENVIRONMENT_VARIABLE, "true");

            var config = new AmazonS3Config
            {
                UseArnRegion = false
            };

            Assert.IsFalse(config.UseArnRegion);
        }

        [TestMethod]
        [TestCategory("S3")]
        public void ProfileValueIsUsedIfSet()
        {
            Environment.SetEnvironmentVariable(AWS_PROFILE_ENVIRONMENT_VARIABLE, "use-arn-region-enabled");

            var config = new AmazonS3Config
            {
            };

            Assert.IsTrue(config.UseArnRegion);
        }

        [TestMethod]
        [TestCategory("S3")]
        public void EnvironmentVariableTakesPrecedenceOverProfileValue()
        {
            Environment.SetEnvironmentVariable(AWS_PROFILE_ENVIRONMENT_VARIABLE, "use-arn-region-enabled");
            Environment.SetEnvironmentVariable(AWS_S3_USE_ARN_REGION_ENVIRONMENT_VARIABLE, "false");

            var config = new AmazonS3Config
            {
            };

            Assert.IsFalse(config.UseArnRegion);
        }

        [TestMethod]
        [TestCategory("S3")]
        public void ConfigValueTakesPrecedenceOverAllValues()
        {
            Environment.SetEnvironmentVariable(AWS_PROFILE_ENVIRONMENT_VARIABLE, "use-arn-region-disabled");
            Environment.SetEnvironmentVariable(AWS_S3_USE_ARN_REGION_ENVIRONMENT_VARIABLE, "false");
            var config = new AmazonS3Config
            {
                UseArnRegion = true
            };

            Assert.IsTrue(config.UseArnRegion);
            
        }
    }
}