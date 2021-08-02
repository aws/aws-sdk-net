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
using Amazon.S3;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace AWSSDK.UnitTests
{
    /// <summary>
    /// Tests the hierarchy of settings to disable multi-region access points
    /// </summary>
    [TestClass]
    public class DisableMultiRegionAccessPointsTests
    {
        private const string DisableMRAPEnvironmentVariable = "AWS_S3_DISABLE_MULTIREGION_ACCESS_POINTS";
        private string _beginningEnvironmentValue;

        [TestInitialize]
        public void SaveCurrentSettings()
        {
            // Save off current environment variable value to restore later
            _beginningEnvironmentValue = Environment.GetEnvironmentVariable(DisableMRAPEnvironmentVariable);

            // Then clear the current value so every test is starting from a clean slate
            Environment.SetEnvironmentVariable(DisableMRAPEnvironmentVariable, "");
        }

        [TestCleanup]
        public void RestoreOriginalSettings()
        {
            Environment.SetEnvironmentVariable(DisableMRAPEnvironmentVariable, _beginningEnvironmentValue);
        }

        [TestMethod]
        [TestCategory("S3")]
        public void EnabledByDefault()
        {
            var config = new AmazonS3Config();

            // MRAPs should be enabled by default, so with no other configuration this should start at false
            Assert.IsFalse(config.DisableMultiregionAccessPoints);
        }

        [TestMethod]
        [TestCategory("S3")]
        public void ExplicitDisableOverEnvironment()
        {
            Environment.SetEnvironmentVariable(DisableMRAPEnvironmentVariable, "false");

            var config = new AmazonS3Config { DisableMultiregionAccessPoints = true };

            // Disabling on the service client should supersede the environment variable value
            Assert.IsTrue(config.DisableMultiregionAccessPoints);
        }

        [TestMethod]
        [TestCategory("S3")]
        public void DisabledViaEnvironmentVariable()
        {
            Environment.SetEnvironmentVariable("AWS_S3_DISABLE_MULTIREGION_ACCESS_POINTS", "true");

            var config = new AmazonS3Config();
            Assert.IsTrue(config.DisableMultiregionAccessPoints);
        }

        [TestMethod]
        [TestCategory("S3")]
        [ExpectedException(typeof(InvalidOperationException))]
        public void InvalidEnvironmentVariableThrowsException()
        {
            //"disabled" is invalid, expecting true or false
            Environment.SetEnvironmentVariable("AWS_S3_DISABLE_MULTIREGION_ACCESS_POINTS", "disabled");

            var config = new AmazonS3Config();
            Assert.IsTrue(config.DisableMultiregionAccessPoints);
        }
    }
}
