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
using System.Collections.Generic;
using System.Linq;
using Amazon.Runtime;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace AWSSDK.UnitTests.Runtime
{
    [TestClass]
    public class SigV4aRegionSetConfigurationTests
    {
        [TestMethod]
        public void Constructor_WithValidRegionSet_CreatesConfiguration()
        {
            // Arrange
            var regions = new[] { "us-east-1", "us-west-2" };
            var source = SigV4aRegionSetSource.ClientConfiguration;

            // Act
            var config = new SigV4aRegionSetConfiguration(regions, source);

            // Assert
            Assert.IsNotNull(config);
            Assert.AreEqual(2, config.RegionSet.Count);
            Assert.AreEqual("us-east-1", config.RegionSet[0]);
            Assert.AreEqual("us-west-2", config.RegionSet[1]);
            Assert.AreEqual(source, config.Source);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        public void Constructor_WithNullRegionSet_ThrowsArgumentNullException()
        {
            // Act & Assert
            new SigV4aRegionSetConfiguration(null, SigV4aRegionSetSource.ClientConfiguration);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void Constructor_WithEmptyRegionSet_ThrowsArgumentException()
        {
            // Arrange
            var regions = new string[0];

            // Act & Assert
            new SigV4aRegionSetConfiguration(regions, SigV4aRegionSetSource.ClientConfiguration);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void Constructor_WithNullRegionInSet_ThrowsArgumentException()
        {
            // Arrange
            var regions = new[] { "us-east-1", null, "us-west-2" };

            // Act & Assert
            new SigV4aRegionSetConfiguration(regions, SigV4aRegionSetSource.ClientConfiguration);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void Constructor_WithEmptyRegionInSet_ThrowsArgumentException()
        {
            // Arrange
            var regions = new[] { "us-east-1", "", "us-west-2" };

            // Act & Assert
            new SigV4aRegionSetConfiguration(regions, SigV4aRegionSetSource.ClientConfiguration);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void Constructor_WithWhitespaceRegionInSet_ThrowsArgumentException()
        {
            // Arrange
            var regions = new[] { "us-east-1", "   ", "us-west-2" };

            // Act & Assert
            new SigV4aRegionSetConfiguration(regions, SigV4aRegionSetSource.ClientConfiguration);
        }

        [TestMethod]
        public void FromEndpointsMetadata_WithValidRegions_CreatesConfiguration()
        {
            // Arrange
            var regions = new[] { "us-east-1", "us-west-2", "eu-west-1" };

            // Act
            var config = SigV4aRegionSetConfiguration.FromEndpointsMetadata(regions);

            // Assert
            Assert.IsNotNull(config);
            Assert.AreEqual(3, config.RegionSet.Count);
            Assert.AreEqual(SigV4aRegionSetSource.EndpointsMetadata, config.Source);
            CollectionAssert.AreEqual(regions.ToList(), config.RegionSet.ToList());
        }

        [TestMethod]
        public void FromEnvironment_WithValidEnvironmentVariable_CreatesConfiguration()
        {
            // Arrange
            var originalValue = Environment.GetEnvironmentVariable("AWS_SIGV4A_SIGNING_REGION_SET");
            try
            {
                Environment.SetEnvironmentVariable("AWS_SIGV4A_SIGNING_REGION_SET", "us-east-1,us-west-2,eu-west-1");

                // Act
                var config = SigV4aRegionSetConfiguration.FromEnvironment();

                // Assert
                Assert.IsNotNull(config);
                Assert.AreEqual(3, config.RegionSet.Count);
                Assert.AreEqual(SigV4aRegionSetSource.Environment, config.Source);
                Assert.AreEqual("us-east-1", config.RegionSet[0]);
                Assert.AreEqual("us-west-2", config.RegionSet[1]);
                Assert.AreEqual("eu-west-1", config.RegionSet[2]);
            }
            finally
            {
                Environment.SetEnvironmentVariable("AWS_SIGV4A_SIGNING_REGION_SET", originalValue);
            }
        }

        [TestMethod]
        public void FromEnvironment_WithSpacesInEnvironmentVariable_CreatesConfigurationWithTrimmedRegions()
        {
            // Arrange
            var originalValue = Environment.GetEnvironmentVariable("AWS_SIGV4A_SIGNING_REGION_SET");
            try
            {
                Environment.SetEnvironmentVariable("AWS_SIGV4A_SIGNING_REGION_SET", " us-east-1 , us-west-2 , eu-west-1 ");

                // Act
                var config = SigV4aRegionSetConfiguration.FromEnvironment();

                // Assert
                Assert.IsNotNull(config);
                Assert.AreEqual(3, config.RegionSet.Count);
                Assert.AreEqual("us-east-1", config.RegionSet[0]);
                Assert.AreEqual("us-west-2", config.RegionSet[1]);
                Assert.AreEqual("eu-west-1", config.RegionSet[2]);
            }
            finally
            {
                Environment.SetEnvironmentVariable("AWS_SIGV4A_SIGNING_REGION_SET", originalValue);
            }
        }

        [TestMethod]
        public void FromEnvironment_WithEmptyEnvironmentVariable_ReturnsNull()
        {
            // Arrange
            var originalValue = Environment.GetEnvironmentVariable("AWS_SIGV4A_SIGNING_REGION_SET");
            try
            {
                Environment.SetEnvironmentVariable("AWS_SIGV4A_SIGNING_REGION_SET", "");

                // Act
                var config = SigV4aRegionSetConfiguration.FromEnvironment();

                // Assert
                Assert.IsNull(config);
            }
            finally
            {
                Environment.SetEnvironmentVariable("AWS_SIGV4A_SIGNING_REGION_SET", originalValue);
            }
        }

        [TestMethod]
        public void FromEnvironment_WithNoEnvironmentVariable_ReturnsNull()
        {
            // Arrange
            var originalValue = Environment.GetEnvironmentVariable("AWS_SIGV4A_SIGNING_REGION_SET");
            try
            {
                Environment.SetEnvironmentVariable("AWS_SIGV4A_SIGNING_REGION_SET", null);

                // Act
                var config = SigV4aRegionSetConfiguration.FromEnvironment();

                // Assert
                Assert.IsNull(config);
            }
            finally
            {
                Environment.SetEnvironmentVariable("AWS_SIGV4A_SIGNING_REGION_SET", originalValue);
            }
        }

        [TestMethod]
        public void FromConfigFile_WithValidConfigValue_CreatesConfiguration()
        {
            // Arrange
            var configValue = "us-east-1,us-west-2,eu-west-1";

            // Act
            var config = SigV4aRegionSetConfiguration.FromConfigFile(configValue);

            // Assert
            Assert.IsNotNull(config);
            Assert.AreEqual(3, config.RegionSet.Count);
            Assert.AreEqual(SigV4aRegionSetSource.ConfigFile, config.Source);
            Assert.AreEqual("us-east-1", config.RegionSet[0]);
            Assert.AreEqual("us-west-2", config.RegionSet[1]);
            Assert.AreEqual("eu-west-1", config.RegionSet[2]);
        }

        [TestMethod]
        public void FromConfigFile_WithEmptyConfigValue_ReturnsNull()
        {
            // Act
            var config = SigV4aRegionSetConfiguration.FromConfigFile("");

            // Assert
            Assert.IsNull(config);
        }

        [TestMethod]
        public void FromConfigFile_WithNullConfigValue_ReturnsNull()
        {
            // Act
            var config = SigV4aRegionSetConfiguration.FromConfigFile(null);

            // Assert
            Assert.IsNull(config);
        }

        [TestMethod]
        public void FromClientConfiguration_WithValidRegions_CreatesConfiguration()
        {
            // Arrange
            var regions = new[] { "us-east-1", "us-west-2" };

            // Act
            var config = SigV4aRegionSetConfiguration.FromClientConfiguration(regions);

            // Assert
            Assert.IsNotNull(config);
            Assert.AreEqual(2, config.RegionSet.Count);
            Assert.AreEqual(SigV4aRegionSetSource.ClientConfiguration, config.Source);
            CollectionAssert.AreEqual(regions.ToList(), config.RegionSet.ToList());
        }

        [TestMethod]
        public void FromSingleRegion_WithValidRegion_CreatesConfiguration()
        {
            // Arrange
            var region = "us-east-1";

            // Act
            var config = SigV4aRegionSetConfiguration.FromSingleRegion(region);

            // Assert
            Assert.IsNotNull(config);
            Assert.AreEqual(1, config.RegionSet.Count);
            Assert.AreEqual(region, config.RegionSet[0]);
            Assert.AreEqual(SigV4aRegionSetSource.SingleRegionFallback, config.Source);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void FromSingleRegion_WithNullRegion_ThrowsArgumentException()
        {
            // Act & Assert
            SigV4aRegionSetConfiguration.FromSingleRegion(null);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void FromSingleRegion_WithEmptyRegion_ThrowsArgumentException()
        {
            // Act & Assert
            SigV4aRegionSetConfiguration.FromSingleRegion("");
        }

        [TestMethod]
        public void ToCommaSeparatedString_WithMultipleRegions_ReturnsCommaSeparatedString()
        {
            // Arrange
            var regions = new[] { "us-east-1", "us-west-2", "eu-west-1" };
            var config = new SigV4aRegionSetConfiguration(regions, SigV4aRegionSetSource.ClientConfiguration);

            // Act
            var result = config.ToCommaSeparatedString();

            // Assert
            Assert.AreEqual("us-east-1,us-west-2,eu-west-1", result);
        }

        [TestMethod]
        public void ToCommaSeparatedString_WithSingleRegion_ReturnsSingleRegion()
        {
            // Arrange
            var regions = new[] { "us-east-1" };
            var config = new SigV4aRegionSetConfiguration(regions, SigV4aRegionSetSource.ClientConfiguration);

            // Act
            var result = config.ToCommaSeparatedString();

            // Assert
            Assert.AreEqual("us-east-1", result);
        }

        [TestMethod]
        public void Equals_WithSameRegionsAndSource_ReturnsTrue()
        {
            // Arrange
            var regions = new[] { "us-east-1", "us-west-2" };
            var config1 = new SigV4aRegionSetConfiguration(regions, SigV4aRegionSetSource.ClientConfiguration);
            var config2 = new SigV4aRegionSetConfiguration(regions, SigV4aRegionSetSource.ClientConfiguration);

            // Act & Assert
            Assert.IsTrue(config1.Equals(config2));
            Assert.IsTrue(config1 == config2);
            Assert.IsFalse(config1 != config2);
        }

        [TestMethod]
        public void Equals_WithDifferentRegions_ReturnsFalse()
        {
            // Arrange
            var regions1 = new[] { "us-east-1", "us-west-2" };
            var regions2 = new[] { "us-east-1", "eu-west-1" };
            var config1 = new SigV4aRegionSetConfiguration(regions1, SigV4aRegionSetSource.ClientConfiguration);
            var config2 = new SigV4aRegionSetConfiguration(regions2, SigV4aRegionSetSource.ClientConfiguration);

            // Act & Assert
            Assert.IsFalse(config1.Equals(config2));
            Assert.IsFalse(config1 == config2);
            Assert.IsTrue(config1 != config2);
        }

        [TestMethod]
        public void Equals_WithDifferentSource_ReturnsFalse()
        {
            // Arrange
            var regions = new[] { "us-east-1", "us-west-2" };
            var config1 = new SigV4aRegionSetConfiguration(regions, SigV4aRegionSetSource.ClientConfiguration);
            var config2 = new SigV4aRegionSetConfiguration(regions, SigV4aRegionSetSource.Environment);

            // Act & Assert
            Assert.IsFalse(config1.Equals(config2));
            Assert.IsFalse(config1 == config2);
            Assert.IsTrue(config1 != config2);
        }

        [TestMethod]
        public void Equals_WithNull_ReturnsFalse()
        {
            // Arrange
            var regions = new[] { "us-east-1", "us-west-2" };
            var config = new SigV4aRegionSetConfiguration(regions, SigV4aRegionSetSource.ClientConfiguration);

            // Act & Assert
            Assert.IsFalse(config.Equals(null));
            Assert.IsFalse(config == null);
            Assert.IsTrue(config != null);
        }

        [TestMethod]
        public void GetHashCode_WithSameRegionsAndSource_ReturnsSameHashCode()
        {
            // Arrange
            var regions = new[] { "us-east-1", "us-west-2" };
            var config1 = new SigV4aRegionSetConfiguration(regions, SigV4aRegionSetSource.ClientConfiguration);
            var config2 = new SigV4aRegionSetConfiguration(regions, SigV4aRegionSetSource.ClientConfiguration);

            // Act & Assert
            Assert.AreEqual(config1.GetHashCode(), config2.GetHashCode());
        }

        [TestMethod]
        public void ToString_WithMultipleRegions_ReturnsFormattedString()
        {
            // Arrange
            var regions = new[] { "us-east-1", "us-west-2" };
            var config = new SigV4aRegionSetConfiguration(regions, SigV4aRegionSetSource.ClientConfiguration);

            // Act
            var result = config.ToString();

            // Assert
            Assert.AreEqual("SigV4aRegionSetConfiguration(RegionSet=[us-east-1,us-west-2], Source=ClientConfiguration)", result);
        }

        [TestMethod]
        public void ParseRegionSet_WithValidCommaSeparatedString_ReturnsRegionList()
        {
            // This tests the internal parsing logic through the public FromConfigFile method
            // Arrange
            var configValue = "us-east-1,us-west-2,eu-west-1";

            // Act
            var config = SigV4aRegionSetConfiguration.FromConfigFile(configValue);

            // Assert
            Assert.IsNotNull(config);
            Assert.AreEqual(3, config.RegionSet.Count);
            Assert.AreEqual("us-east-1", config.RegionSet[0]);
            Assert.AreEqual("us-west-2", config.RegionSet[1]);
            Assert.AreEqual("eu-west-1", config.RegionSet[2]);
        }

        [TestMethod]
        public void ParseRegionSet_WithSpacesAndEmptyEntries_ReturnsCleanedRegionList()
        {
            // This tests the internal parsing logic through the public FromConfigFile method
            // Arrange
            var configValue = " us-east-1 , , us-west-2 ,  , eu-west-1 ";

            // Act
            var config = SigV4aRegionSetConfiguration.FromConfigFile(configValue);

            // Assert
            Assert.IsNotNull(config);
            Assert.AreEqual(3, config.RegionSet.Count);
            Assert.AreEqual("us-east-1", config.RegionSet[0]);
            Assert.AreEqual("us-west-2", config.RegionSet[1]);
            Assert.AreEqual("eu-west-1", config.RegionSet[2]);
        }
    }
}