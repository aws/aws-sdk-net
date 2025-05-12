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
using Amazon.Runtime.CredentialManagement;
using Amazon.Runtime.Credentials;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace AWSSDK.UnitTests
{
    [TestClass]
    public class DefaultCredentialsResolverTests
    {
        private const string AWS_PROFILE_ENVIRONMENT_VARIABLE = "AWS_PROFILE";

        private string _cachedContainersUriVariable;
        private string _cachedProfileVariable;
        private string _cachedAccessTokenVariable;
        private string _cachedSecretKeyVariable;
        private string _cachedSessionTokenVariable;

        [TestInitialize]
        public void TestInitialize()
        {
            // When running these tests on CodeBuild, we need to clear the "AWS_CONTAINER_CREDENTIALS_RELATIVE_URI" variable
            // to prevent using the container credentials provider.
            _cachedContainersUriVariable = Environment.GetEnvironmentVariable(GenericContainerCredentials.RelativeURIEnvVariable);
            Environment.SetEnvironmentVariable(GenericContainerCredentials.RelativeURIEnvVariable, null);

            _cachedProfileVariable = Environment.GetEnvironmentVariable(AWS_PROFILE_ENVIRONMENT_VARIABLE);
            _cachedAccessTokenVariable = Environment.GetEnvironmentVariable(EnvironmentVariablesAWSCredentials.ENVIRONMENT_VARIABLE_ACCESSKEY);
            _cachedSecretKeyVariable = Environment.GetEnvironmentVariable(EnvironmentVariablesAWSCredentials.ENVIRONMENT_VARIABLE_SECRETKEY);
            _cachedSessionTokenVariable = Environment.GetEnvironmentVariable(EnvironmentVariablesAWSCredentials.ENVIRONMENT_VARIABLE_SESSION_TOKEN);
        }

        [TestCleanup]
        public void TestCleanup()
        {
            Environment.SetEnvironmentVariable(GenericContainerCredentials.RelativeURIEnvVariable, _cachedContainersUriVariable);
            Environment.SetEnvironmentVariable(AWS_PROFILE_ENVIRONMENT_VARIABLE, _cachedProfileVariable);
            Environment.SetEnvironmentVariable(EnvironmentVariablesAWSCredentials.ENVIRONMENT_VARIABLE_ACCESSKEY, _cachedAccessTokenVariable);
            Environment.SetEnvironmentVariable(EnvironmentVariablesAWSCredentials.ENVIRONMENT_VARIABLE_SECRETKEY, _cachedSecretKeyVariable);
            Environment.SetEnvironmentVariable(EnvironmentVariablesAWSCredentials.ENVIRONMENT_VARIABLE_SESSION_TOKEN, _cachedSessionTokenVariable);
        }

        [TestMethod]
        public void CredentialsAreReevaluatedWhenEnvVarsAreSet()
        {
            Environment.SetEnvironmentVariable(EnvironmentVariablesAWSCredentials.ENVIRONMENT_VARIABLE_ACCESSKEY, null);
            Environment.SetEnvironmentVariable(EnvironmentVariablesAWSCredentials.ENVIRONMENT_VARIABLE_SECRETKEY, null);
            Environment.SetEnvironmentVariable(EnvironmentVariablesAWSCredentials.ENVIRONMENT_VARIABLE_SESSION_TOKEN, null);

            // By setting the environment variables to null, the identity resolver will use either basic credentials (from the default 
            // profile) or session credentials (when using an IAM role - for example, in CodeBuild).
            var identityResolver = new DefaultAWSCredentialsIdentityResolver();
            var initialIdentity = identityResolver.ResolveIdentity(clientConfig: null);
            Assert.IsFalse(initialIdentity is EnvironmentVariablesAWSCredentials);

            Environment.SetEnvironmentVariable(EnvironmentVariablesAWSCredentials.ENVIRONMENT_VARIABLE_ACCESSKEY, "updated_aws_access_key_id");
            Environment.SetEnvironmentVariable(EnvironmentVariablesAWSCredentials.ENVIRONMENT_VARIABLE_SECRETKEY, "updated_aws_secret_access_key");
            Environment.SetEnvironmentVariable(EnvironmentVariablesAWSCredentials.ENVIRONMENT_VARIABLE_SESSION_TOKEN, "updated_aws_session_token");

            var updatedIdentity = identityResolver.ResolveIdentity(clientConfig: null);
            Assert.IsTrue(updatedIdentity is EnvironmentVariablesAWSCredentials);
        }

        [TestMethod]
        public void CredentialsAreReevaluatedWhenProfileChanges()
        {
            var identityResolver = new DefaultAWSCredentialsIdentityResolver();
            var initialIdentity = identityResolver.ResolveIdentity(clientConfig: null);
            Assert.IsFalse(initialIdentity is DefaultInstanceProfileAWSCredentials);

            // Since the specified profile does not exist, the identity resolver will throw an exception.
            Environment.SetEnvironmentVariable(AWS_PROFILE_ENVIRONMENT_VARIABLE, "non-existent-profile");
            Assert.ThrowsException<ProfileNotFoundException>(() => identityResolver.ResolveIdentity(clientConfig: null));
        }
    }
}
