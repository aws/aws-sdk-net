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
using System.IO;

using Xunit;

using Amazon;
using Amazon.Runtime;
using Amazon.Extensions.NETCore.Setup;

namespace NETCore.SetupTests
{
    /// <summary>
    /// Tests for <see cref="AWSOptions.GetCredentials"/>, which exposes the same credential resolution
    /// used when creating a service client so that credential-only APIs (for example
    /// Amazon.RDS.Util.RDSAuthTokenGenerator) can share a single AWSOptions configuration.
    /// </summary>
    public class GetCredentialsTests
    {
        [Fact]
        public void ExplicitCredentialsAreReturnedAsIs()
        {
            var explicitCredentials = new BasicAWSCredentials("access-key", "secret-key");
            var options = new AWSOptions
            {
                Credentials = explicitCredentials
            };

            var resolved = options.GetCredentials();

            // The exact instance the user supplied should come back untouched.
            Assert.Same(explicitCredentials, resolved);
        }

        [Fact]
        public void SessionRoleArnWrapsCredentialsInAssumeRole()
        {
            var sourceCredentials = new BasicAWSCredentials("access-key", "secret-key");
            var options = new AWSOptions
            {
                Credentials = sourceCredentials,
                SessionRoleArn = "arn:aws:iam::123456789012:role/fake_role",
                SessionName = "TestSessionName"
            };

            var resolved = options.GetCredentials();

            // With a role to assume configured, the resolved credentials must be the assume-role wrapper,
            // matching what a service client built from the same options would use.
            var assumeRole = Assert.IsType<AssumeRoleAWSCredentials>(resolved);
            // The role ARN, session name, and source credentials must be wired through from the options,
            // so a regression in that wiring is caught rather than just the wrapper type.
            Assert.Equal(options.SessionRoleArn, assumeRole.RoleArn);
            Assert.Equal(options.SessionName, assumeRole.RoleSessionName);
            Assert.Same(sourceCredentials, assumeRole.SourceCredentials);
            // No ExternalId was configured, so none should be set on the options.
            Assert.Null(assumeRole.Options.ExternalId);
        }

        [Fact]
        public void SessionRoleArnWithExternalIdWrapsCredentialsInAssumeRole()
        {
            var sourceCredentials = new BasicAWSCredentials("access-key", "secret-key");
            var options = new AWSOptions
            {
                Credentials = sourceCredentials,
                SessionRoleArn = "arn:aws:iam::123456789012:role/fake_role",
                SessionName = "TestSessionName",
                ExternalId = "TestExternalId"
            };

            var resolved = options.GetCredentials();

            var assumeRole = Assert.IsType<AssumeRoleAWSCredentials>(resolved);
            Assert.Equal(options.SessionRoleArn, assumeRole.RoleArn);
            Assert.Equal(options.SessionName, assumeRole.RoleSessionName);
            Assert.Same(sourceCredentials, assumeRole.SourceCredentials);
            // The ExternalId must be threaded through onto the assume-role options.
            Assert.Equal(options.ExternalId, assumeRole.Options.ExternalId);
        }

        [Fact]
        public void ProfileCredentialsAreResolvedFromProfileStore()
        {
            // Write an isolated shared-credentials file so this test does not depend on machine configuration.
            WithTempProfile((profileName, credentialsFile) =>
            {
                var options = new AWSOptions
                {
                    Profile = profileName,
                    ProfilesLocation = credentialsFile
                };

                var resolved = options.GetCredentials();

                Assert.NotNull(resolved);
                var immutable = resolved.GetCredentials();
                Assert.Equal(ProfileAccessKey, immutable.AccessKey);
                Assert.Equal(ProfileSecretKey, immutable.SecretKey);
            });
        }

        [Fact]
        public void ProfileCredentialsWithSessionRoleArnAreWrapped()
        {
            WithTempProfile((profileName, credentialsFile) =>
            {
                var options = new AWSOptions
                {
                    Profile = profileName,
                    ProfilesLocation = credentialsFile,
                    SessionRoleArn = "arn:aws:iam::123456789012:role/fake_role",
                    SessionName = "TestSessionName"
                };

                var resolved = options.GetCredentials();

                // The profile-resolved credentials must be wrapped, with the role ARN and session name
                // wired through from the options.
                var assumeRole = Assert.IsType<AssumeRoleAWSCredentials>(resolved);
                Assert.Equal(options.SessionRoleArn, assumeRole.RoleArn);
                Assert.Equal(options.SessionName, assumeRole.RoleSessionName);
            });
        }

        private const string ProfileName = "unit-test-profile";
        private const string ProfileAccessKey = "AKIAEXAMPLEPROFILEKEY";
        private const string ProfileSecretKey = "ExampleProfileSecretKeyValue";

        /// <summary>
        /// Writes an isolated shared-credentials file containing a single test profile, invokes the supplied
        /// action with the profile name and the credentials file path, then deletes the temporary directory.
        /// Keeps profile-based tests independent of machine configuration and free of duplicated setup/teardown.
        /// </summary>
        private static void WithTempProfile(Action<string, string> test)
        {
            var location = Path.Combine(Path.GetTempPath(), "aws-sdk-net-3228-" + Guid.NewGuid().ToString("N"));
            var credentialsFile = Path.Combine(location, "credentials");
            Directory.CreateDirectory(location);
            try
            {
                File.WriteAllText(credentialsFile,
                    "[" + ProfileName + "]" + Environment.NewLine +
                    "aws_access_key_id = " + ProfileAccessKey + Environment.NewLine +
                    "aws_secret_access_key = " + ProfileSecretKey + Environment.NewLine);

                test(ProfileName, credentialsFile);
            }
            finally
            {
                if (Directory.Exists(location))
                {
                    Directory.Delete(location, true);
                }
            }
        }
    }
}
