/*
  * Copyright 2019 Amazon.com, Inc. or its affiliates. All Rights Reserved.
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
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace AWSSDK.UnitTests.S3.Net45.Custom
{
    [TestClass]
    public class S3EndpointFlagTests
    {
        private const string AwsS3RegionalEndpointEnvironmentVariable = "AWS_S3_US_EAST_1_REGIONAL_ENDPOINT";

        [DataTestMethod]
        [DataRow("legacy", "us-east-1")]
        [DataRow("regional", "us-east-1-regional")]
        [TestCategory("S3")]
        public void GivenAConfigWithFlagNotSetThenTheEnvironmentVariableIsRespected(string s3FlagValue, string expectedEndpointSystemName)
        {
            var olds3EnvValue = Environment.GetEnvironmentVariable(AwsS3RegionalEndpointEnvironmentVariable);
            try
            {
                Environment.SetEnvironmentVariable(AwsS3RegionalEndpointEnvironmentVariable, s3FlagValue);
                var config = new AmazonS3Config()
                {
                    RegionEndpoint = Amazon.RegionEndpoint.USEast1
                };
                // Simulate a first service call
                config.DetermineServiceURL();
                Assert.AreEqual(expectedEndpointSystemName, config.RegionEndpoint.SystemName);
            }
            finally
            {
                Environment.SetEnvironmentVariable(AwsS3RegionalEndpointEnvironmentVariable, olds3EnvValue);
            }
        }

        [DataTestMethod]
        [DataRow("legacy", S3UsEast1RegionalEndpointValue.Legacy, S3UsEast1RegionalEndpointValue.Legacy, "us-east-1")]
        [DataRow("legacy", S3UsEast1RegionalEndpointValue.Regional, S3UsEast1RegionalEndpointValue.Regional, "us-east-1-regional")]
        [TestCategory("S3")]
        public void GivenAConfigWithFlagSetThenTheEnvironmentVariableIsNotUsed(string s3EnvValue, S3UsEast1RegionalEndpointValue configFlagValue, S3UsEast1RegionalEndpointValue expectedValue, string expectedEndpointSystemName)
        {
            var olds3EnvValue = Environment.GetEnvironmentVariable(AwsS3RegionalEndpointEnvironmentVariable);
            try
            {
                Environment.SetEnvironmentVariable(AwsS3RegionalEndpointEnvironmentVariable, s3EnvValue);
                var config = new AmazonS3Config()
                {
                    RegionEndpoint = Amazon.RegionEndpoint.USEast1,
                    USEast1RegionalEndpointValue = configFlagValue
                };
                // Simulate a first service call
                config.DetermineServiceURL();
                Assert.AreEqual(expectedValue, config.USEast1RegionalEndpointValue);
                Assert.AreEqual(expectedEndpointSystemName, config.RegionEndpoint.SystemName);
            }
            finally
            {
                Environment.SetEnvironmentVariable(AwsS3RegionalEndpointEnvironmentVariable, olds3EnvValue);
            }
        }

        [DataTestMethod]
        [DataRow(null)]
        [DataRow(S3UsEast1RegionalEndpointValue.Legacy)]
        [DataRow(S3UsEast1RegionalEndpointValue.Regional)]
        [TestCategory("S3")]
        public void GivenAConfigWithFlagSetAndAnEmptyEnvironmentVariableThenTheFlagIsNotAltered(S3UsEast1RegionalEndpointValue s3FlagValue)
        {
            var olds3EnvValue = Environment.GetEnvironmentVariable(AwsS3RegionalEndpointEnvironmentVariable);
            try
            {
                Environment.SetEnvironmentVariable(AwsS3RegionalEndpointEnvironmentVariable, "");
                var config = new AmazonS3Config()
                {
                    USEast1RegionalEndpointValue = s3FlagValue
                };
                Assert.AreEqual(s3FlagValue, config.USEast1RegionalEndpointValue);
            }
            finally
            {
                Environment.SetEnvironmentVariable(AwsS3RegionalEndpointEnvironmentVariable, olds3EnvValue);
            }
        }

        [DataTestMethod]
        [TestCategory("S3")]
        [DataRow("invalid")]
        [DataRow("999999999999999999999999999999999999999999999999999999999999999999")]
        [DataRow("true")]
        public void GivenAConfigWithAndAnInvalidEnvironmentVariableThenInvalidOperationExceptionIsThrown(string invalidValue)
        {
            var olds3EnvValue = Environment.GetEnvironmentVariable(AwsS3RegionalEndpointEnvironmentVariable);
            try
            {
                Environment.SetEnvironmentVariable(AwsS3RegionalEndpointEnvironmentVariable, invalidValue);
                Assert.ThrowsException<InvalidOperationException>(() => new AmazonS3Config());
            }
            finally
            {
                Environment.SetEnvironmentVariable(AwsS3RegionalEndpointEnvironmentVariable, olds3EnvValue);
            }
        }
    }
}
