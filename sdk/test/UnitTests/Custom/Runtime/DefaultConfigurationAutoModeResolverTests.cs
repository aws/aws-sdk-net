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
using Amazon;
using Moq;
using Amazon.Runtime.Internal;
using Amazon.Util;
using Amazon.Util.Internal;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace AWSSDK.UnitTests.Runtime
{
    [TestClass]
    public class DefaultConfigurationAutoModeResolverTests
    {
        private const string ExecutionEnvironmentEnvVar = "AWS_EXECUTION_ENV";
        private DefaultConfigurationAutoModeResolver _resolver;
        private readonly Mock<IRuntimeInformationProvider> _runtimeInformationProvider = new Mock<IRuntimeInformationProvider>();
        private readonly Mock<IEnvironmentVariableRetriever> _environmentVariableRetriever = new Mock<IEnvironmentVariableRetriever>();

        [TestInitialize]
        public void InitializeResolver()
        {
            _resolver = new DefaultConfigurationAutoModeResolver(_runtimeInformationProvider.Object, _environmentVariableRetriever.Object);
        }

        [DataTestMethod]
        [DataRow(true, "AWS_Lambda_java8", "us-east-1", null, null, null, "us-east-1", DefaultConfigurationMode.Mobile)]
        [DataRow(false, "AWS_Lambda_java8", "us-east-1", null, null, null, "us-east-1", DefaultConfigurationMode.InRegion)]
        [DataRow(false, "AWS_Lambda_java8", null, "us-west-2", null, null, "us-east-1", DefaultConfigurationMode.CrossRegion)]
        [DataRow(false, "AWS_Lambda_java8", null, null, null, "us-west-2", "us-east-1", DefaultConfigurationMode.CrossRegion)]
        [DataRow(false, null, "us-east-1", null, null, "us-east-1", "us-east-1", DefaultConfigurationMode.InRegion)]
        [DataRow(false, null, null, null, "false", "us-west-2", "us-east-1", DefaultConfigurationMode.CrossRegion)]
        [DataRow(false, null, null, null, "false", null, "us-west-2", DefaultConfigurationMode.Standard)]
        [DataRow(false, null, null, null, "true", null, "us-west-2", DefaultConfigurationMode.Standard)]
        public void Resolve(
            bool isMobile,
            string exeEnvVar,
            string regionEnvVar,
            string defaultRegionEnvVar,
            string awsEc2MetadataDisabled,
            string imdsRegion,
            string clientRegion,
            DefaultConfigurationMode expectedMode)
        {
            _runtimeInformationProvider.Setup(p => p.IsMobile()).Returns(isMobile);

            _environmentVariableRetriever.Setup(r => r.GetEnvironmentVariable(ExecutionEnvironmentEnvVar))
                .Returns(exeEnvVar);
            _environmentVariableRetriever.Setup(r => r.GetEnvironmentVariable(EnvironmentVariableAWSRegion.ENVIRONMENT_VARIABLE_REGION))
                .Returns(regionEnvVar);
            _environmentVariableRetriever.Setup(r => r.GetEnvironmentVariable(EnvironmentVariableAWSRegion.ENVIRONMENT_VARIABLE_DEFAULT_REGION))
                .Returns(defaultRegionEnvVar);
            _environmentVariableRetriever.Setup(r => r.GetEnvironmentVariable(EC2InstanceMetadata.AWS_EC2_METADATA_DISABLED))
                .Returns(awsEc2MetadataDisabled);

            var clientRegionEndpoint = clientRegion != null ? RegionEndpoint.GetBySystemName(clientRegion) : null;
            var imdsRegionEndpoint = imdsRegion != null ? RegionEndpoint.GetBySystemName(imdsRegion) : null;

            var mode = _resolver.Resolve(clientRegionEndpoint, () => imdsRegionEndpoint);

            Assert.AreEqual(expectedMode, mode);
        }
    }
}