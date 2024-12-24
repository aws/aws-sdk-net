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
using Amazon.Runtime.Credentials;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.IO;
using System.Text;

namespace AWSSDK.UnitTests
{
    [TestClass]
    public class DefaultCredentialsResolverTests
    {
        private static readonly string DefaultProfileConfigText = new StringBuilder()
            .AppendLine("[default]")
            .AppendLine("region=us-west-2")
            .AppendLine("output=json")
            .ToString();

        private static readonly string DefaultProfileCredentialsText = new StringBuilder()
            .AppendLine("[default]")
            .AppendLine("aws_access_key_id=aws_access_key_id")
            .AppendLine("aws_secret_access_key=aws_secret_access_key")
            .ToString();

        private string cachedConfigPathVariable;
        private string cachedCredsPathVariable;
        private string _tempConfigFile;
        private string _tempCredsFile;

        [TestInitialize]
        public void TestInitialize()
        {
            cachedConfigPathVariable = Environment.GetEnvironmentVariable("AWS_CONFIG_FILE");
            cachedCredsPathVariable = Environment.GetEnvironmentVariable("AWS_SHARED_CREDENTIALS_FILE");

            _tempConfigFile = Path.Combine(Path.GetTempPath(), Path.GetRandomFileName());
            File.WriteAllText(_tempConfigFile, DefaultProfileConfigText);

            _tempCredsFile = Path.Combine(Path.GetTempPath(), Path.GetRandomFileName());
            File.WriteAllText(_tempCredsFile, DefaultProfileCredentialsText);
            
            Environment.SetEnvironmentVariable("AWS_CONFIG_FILE", _tempConfigFile);
            Environment.SetEnvironmentVariable("AWS_SHARED_CREDENTIALS_FILE", _tempCredsFile);
        }

        [TestCleanup]
        public void TestCleanup()
        {
            Environment.SetEnvironmentVariable("AWS_CONFIG_FILE", cachedConfigPathVariable);
            Environment.SetEnvironmentVariable("AWS_SHARED_CREDENTIALS_FILE", cachedCredsPathVariable);

            File.Delete(_tempConfigFile);
            File.Delete(_tempCredsFile);
        }

        [TestMethod]
        public void CredentialsAreReevaluatedWhenEnvVarsAreSet()
        {
            var cachedAccessTokenVariable = Environment.GetEnvironmentVariable("AWS_ACCESS_KEY_ID");
            var cachedSecretKeyVariable = Environment.GetEnvironmentVariable("AWS_SECRET_ACCESS_KEY");
            var cachedSessionTokenVariable = Environment.GetEnvironmentVariable("AWS_SESSION_TOKEN");

            try
            {
                var identityResolver = new DefaultAWSCredentialsIdentityResolver();
                var initialIdentity = identityResolver.ResolveIdentity();
                Assert.IsNotNull(initialIdentity);
                Assert.IsTrue(initialIdentity is BasicAWSCredentials);

                Environment.SetEnvironmentVariable("AWS_ACCESS_KEY_ID", "updated_aws_access_key_id");
                Environment.SetEnvironmentVariable("AWS_SECRET_ACCESS_KEY", "updated_aws_secret_access_key");
                Environment.SetEnvironmentVariable("AWS_SESSION_TOKEN", "updated_aws_session_token");

                var updatedIdentity = identityResolver.ResolveIdentity();
                Assert.IsNotNull(updatedIdentity);
                Assert.IsTrue(updatedIdentity is EnvironmentVariablesAWSCredentials);
            }
            finally
            {
                Environment.SetEnvironmentVariable("AWS_ACCESS_KEY_ID", cachedAccessTokenVariable);
                Environment.SetEnvironmentVariable("AWS_SECRET_ACCESS_KEY", cachedSecretKeyVariable);
                Environment.SetEnvironmentVariable("AWS_SESSION_TOKEN", cachedSessionTokenVariable);
            }
        }

        [TestMethod]
        public void CredentialsAreReevaluatedWhenProfileChanges()
        {
            var cachedProfileVariable = Environment.GetEnvironmentVariable("AWS_PROFILE");
            var cachedImdsStateVariable = Environment.GetEnvironmentVariable("AWS_EC2_METADATA_DISABLED");

            try
            {
                // Disabling IMDS since these unit tests are only trying to validate changes in environment variables are respected.
                Environment.SetEnvironmentVariable("AWS_EC2_METADATA_DISABLED", "true");

                var identityResolver = new DefaultAWSCredentialsIdentityResolver();
                var identity = identityResolver.ResolveIdentity();
                Assert.IsNotNull(identity);
                Assert.IsTrue(identity is BasicAWSCredentials);

                // This should fail since the specified profile does not exist.
                Environment.SetEnvironmentVariable("AWS_PROFILE", "non-existent-profile");
                Assert.ThrowsException<AmazonClientException>(() => identityResolver.ResolveIdentity());
            }
            finally
            {
                Environment.SetEnvironmentVariable("AWS_PROFILE", cachedProfileVariable);
                Environment.SetEnvironmentVariable("AWS_EC2_METADATA_DISABLED", cachedImdsStateVariable);
            }
        }
    }
}
