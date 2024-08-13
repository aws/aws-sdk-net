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
using Amazon.Runtime.Endpoints;
using Amazon.S3;
using Amazon.S3.Model;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace AWSSDK.UnitTests.S3.Custom
{
    [TestClass]
    public class S3EndpointFlagTests
    {
        private const string AwsS3RegionalEndpointEnvironmentVariable = "AWS_S3_US_EAST_1_REGIONAL_ENDPOINT";

        [DataTestMethod]
        [DataRow("legacy", "https://s3.amazonaws.com/")]
        [DataRow("regional", "https://s3.us-east-1.amazonaws.com/")]
        [TestCategory("S3")]
        public void GivenAConfigWithFlagNotSetThenTheEnvironmentVariableIsRespected(string s3FlagValue, string expectedEndpointUrl)
        {
            var olds3EnvValue = Environment.GetEnvironmentVariable(AwsS3RegionalEndpointEnvironmentVariable);
            var oldRegion = Environment.GetEnvironmentVariable("AWS_REGION");
            try
            {
                Environment.SetEnvironmentVariable(AwsS3RegionalEndpointEnvironmentVariable, s3FlagValue);
                Environment.SetEnvironmentVariable("AWS_REGION", "us-east-1");
                var config = new AmazonS3Config()
                {
                    RegionEndpoint = Amazon.RegionEndpoint.USEast1
                };
                // Simulate a first service call
                // Use ListBucketsRequest as it is the most basic S3 request
                var url = config.DetermineServiceOperationEndpoint(new ServiceOperationEndpointParameters(new ListBucketsRequest())).URL;
                Assert.AreEqual(expectedEndpointUrl, url);
            }
            finally
            {
                Environment.SetEnvironmentVariable("AWS_REGION", oldRegion);
                Environment.SetEnvironmentVariable(AwsS3RegionalEndpointEnvironmentVariable, olds3EnvValue);
            }
        }

        [DataTestMethod]
        [DataRow("legacy", S3UsEast1RegionalEndpointValue.Legacy, S3UsEast1RegionalEndpointValue.Legacy, "https://s3.amazonaws.com/")]
        [DataRow("legacy", S3UsEast1RegionalEndpointValue.Regional, S3UsEast1RegionalEndpointValue.Regional, "https://s3.us-east-1.amazonaws.com/")]
        [TestCategory("S3")]
        public void GivenAConfigWithFlagSetThenTheEnvironmentVariableIsNotUsed(string s3EnvValue, S3UsEast1RegionalEndpointValue configFlagValue, S3UsEast1RegionalEndpointValue expectedValue, string expectedEndpointUrl)
        {
            var olds3EnvValue = Environment.GetEnvironmentVariable(AwsS3RegionalEndpointEnvironmentVariable);
            var oldRegion = Environment.GetEnvironmentVariable("AWS_REGION");
            try
            {
                Environment.SetEnvironmentVariable(AwsS3RegionalEndpointEnvironmentVariable, s3EnvValue);
                Environment.SetEnvironmentVariable("AWS_REGION", "us-east-1");
                var config = new AmazonS3Config()
                {
                    RegionEndpoint = Amazon.RegionEndpoint.USEast1,
                    USEast1RegionalEndpointValue = configFlagValue
                };
                // Simulate a first service call
                // Use ListBucketsRequest as it is the most basic S3 request
                var url = config.DetermineServiceOperationEndpoint(new ServiceOperationEndpointParameters(new ListBucketsRequest())).URL;
                Assert.AreEqual(expectedValue, config.USEast1RegionalEndpointValue);
                Assert.AreEqual(expectedEndpointUrl, url);
            }
            finally
            {
                Environment.SetEnvironmentVariable("AWS_REGION", oldRegion);
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
            var oldRegion = Environment.GetEnvironmentVariable("AWS_REGION");
            try
            {
                Environment.SetEnvironmentVariable("AWS_REGION", "us-east-1");
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
                Environment.SetEnvironmentVariable("AWS_REGION", oldRegion);
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
            var oldRegion = Environment.GetEnvironmentVariable("AWS_REGION");
            try
            {
                Environment.SetEnvironmentVariable("AWS_REGION", "us-east-1");
                Environment.SetEnvironmentVariable(AwsS3RegionalEndpointEnvironmentVariable, invalidValue);

                // Use ListBucketsRequest as it is the most basic S3 request
                Assert.ThrowsException<InvalidOperationException>(() => new AmazonS3Config().DetermineServiceOperationEndpoint(new ServiceOperationEndpointParameters(new ListBucketsRequest())));
            }
            finally
            {
                Environment.SetEnvironmentVariable(AwsS3RegionalEndpointEnvironmentVariable, olds3EnvValue);
                Environment.SetEnvironmentVariable("AWS_REGION", oldRegion);
            }
        }
    }
}
