using Amazon.S3;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.IO;
using AWSSDK_DotNet.CommonTest.Utils;
using Amazon.Runtime.CredentialManagement;

namespace AWSSDK.UnitTests
{
    [TestClass]
    public class S3ForcePathStyleTests
    {
        private static readonly string ProfileText =
            @"[enable_force_path_style]
                region = us-west-2
                aws_access_key_id = default_aws_access_key_id   
                aws_secret_access_key = default_aws_secret_access_key
                s3_force_path_style = true
                [disable_force_path_style]
                region = us-west-2
                aws_access_key_id = other_aws_access_key_id
                aws_secret_access_key = other_aws_secret_access_key
                s3_force_path_style = false";

        private const string AWSProfileVariable = "AWS_PROFILE";
        private string _beginningAWSProfileEnvironmentValue;
        private string _tempCredentialsFilePath;

        [TestInitialize]
        public void Initialize()
        {
            // Save off current environment variable value to restore later
            _beginningAWSProfileEnvironmentValue = Environment.GetEnvironmentVariable(AWSProfileVariable);

            // Then clear the current value so every test is starting from a clean slate
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
            Environment.SetEnvironmentVariable(AWSProfileVariable, _beginningAWSProfileEnvironmentValue);
            File.Delete(_tempCredentialsFilePath);
        }

        [TestMethod]
        [TestCategory("S3")]
        public void CredentialProfileEnable_ShouldApplyToS3Config()
        {
            Environment.SetEnvironmentVariable(AWSProfileVariable, "enable_force_path_style");
            var config = new AmazonS3Config();
            Assert.IsTrue(config.ForcePathStyle);
        }

        [TestMethod]
        [TestCategory("S3")]
        public void UnsetForcePathStyleShouldDefaultToFalse()
        {
            var config = new AmazonS3Config();
            Assert.IsFalse(config.ForcePathStyle);
        }

        [TestMethod]
        [TestCategory("S3")]
        public void ConfigShouldOverrideProfile()
        {
            Environment.SetEnvironmentVariable(AWSProfileVariable, "enable_force_path_style");
            var config = new AmazonS3Config
            {
                ForcePathStyle = false
            };
            Assert.IsFalse(config.ForcePathStyle);
        }
    }
}
