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
        private static readonly string ProfileText = @"[default]
                                                         region=us-west-2
                                                         aws_access_key_id=default_aws_access_key_id
                                                         aws_secret_access_key=default_aws_secret_access_key
                                                         s3_use_arn_region=true
                                                         [other]
                                                         region=us-west-2
                                                         aws_access_key_id=other_aws_access_key_id
                                                         aws_secret_access_key=other_aws_secret_access_key
                                                         ";

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
            Environment.SetEnvironmentVariable("AWS_S3_USE_ARN_REGION", "true");
            try
            {
                var config = new AmazonS3Config
                {
                };

                Assert.IsTrue(config.UseArnRegion);
            }
            finally
            {
                Environment.SetEnvironmentVariable("AWS_S3_USE_ARN_REGION", "");
            }
        }


        [TestMethod]
        [TestCategory("S3")]
        public void ExplicitDisableOverridesEnvironmentVariable()
        {
            Environment.SetEnvironmentVariable("AWS_S3_USE_ARN_REGION", "true");
            try
            {
                var config = new AmazonS3Config
                {
                    UseArnRegion = false
                };

                Assert.IsFalse(config.UseArnRegion);
            }
            finally
            {
                Environment.SetEnvironmentVariable("AWS_S3_USE_ARN_REGION", "");
            }
        }

        /*[TestMethod]
        [TestCategory("S3")]
        public void CredentialProfileEnable()
        {
            var tempCredentialsFilePath = Path.GetTempFileName();
            File.WriteAllText(tempCredentialsFilePath, ProfileText);
            try
            {
                ReflectionHelpers.Invoke(typeof(AmazonS3Config), "credentialProfileChain", new CredentialProfileStoreChain(tempCredentialsFilePath));
                
                var config = new AmazonS3Config
                {
                };

                Assert.IsTrue(config.UseArnRegion);
            }
            finally
            {
                File.Delete(tempCredentialsFilePath);
            }
        }

        [TestMethod]
        [TestCategory("S3")]
        public void ExplicitDisableOverridesCredentialProfile()
        {
            var currentAwsProfile = Environment.GetEnvironmentVariable("AWS_PROFILE");

            var tempCredentialsFilePath = Path.GetTempFileName();
            File.WriteAllText(tempCredentialsFilePath, ProfileText);
            try
            {
                Environment.SetEnvironmentVariable("AWS_PROFILE", "other");

                ReflectionHelpers.Invoke(typeof(AmazonS3Config), "credentialProfileChain", new CredentialProfileStoreChain(tempCredentialsFilePath));

                var config = new AmazonS3Config
                {
                    UseArnRegion = true
                };

                Assert.IsTrue(config.UseArnRegion);
            }
            finally
            {
                Environment.SetEnvironmentVariable("AWS_PROFILE", currentAwsProfile);
                File.Delete(tempCredentialsFilePath);
            }
        }*/
    }
}