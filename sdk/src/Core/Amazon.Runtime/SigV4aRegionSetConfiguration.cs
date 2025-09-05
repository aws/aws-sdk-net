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
using Amazon.Runtime.Internal.Util;

namespace Amazon.Runtime
{
    /// <summary>
    /// Represents the configuration for SigV4a signing region set.
    /// </summary>
    public class SigV4aRegionSetConfiguration : IEquatable<SigV4aRegionSetConfiguration>
    {
        /// <summary>
        /// Gets the list of regions in the signing region set.
        /// </summary>
        public IReadOnlyList<string> RegionSet { get; }

        /// <summary>
        /// Gets the source of this region set configuration.
        /// </summary>
        public SigV4aRegionSetSource Source { get; }

        /// <summary>
        /// Initializes a new instance of the SigV4aRegionSetConfiguration class.
        /// </summary>
        /// <param name="regionSet">The list of regions for the signing region set.</param>
        /// <param name="source">The source of this configuration.</param>
        /// <exception cref="ArgumentNullException">Thrown when regionSet is null.</exception>
        /// <exception cref="ArgumentException">Thrown when regionSet is empty or contains null/empty regions.</exception>
        public SigV4aRegionSetConfiguration(IEnumerable<string> regionSet, SigV4aRegionSetSource source)
        {
            if (regionSet == null)
                throw new ArgumentNullException(nameof(regionSet));

            var regions = regionSet.ToList();
            if (regions.Count == 0)
                throw new ArgumentException("Region set cannot be empty", nameof(regionSet));

            if (regions.Any(r => string.IsNullOrWhiteSpace(r)))
                throw new ArgumentException("Region set cannot contain null or empty regions", nameof(regionSet));

            RegionSet = regions.AsReadOnly();
            Source = source;
        }

        /// <summary>
        /// Creates a SigV4aRegionSetConfiguration from endpoints 2.0 metadata.
        /// </summary>
        /// <param name="regions">The list of regions from endpoints metadata.</param>
        /// <returns>A new SigV4aRegionSetConfiguration instance.</returns>
        public static SigV4aRegionSetConfiguration FromEndpointsMetadata(IEnumerable<string> regions)
        {
            return new SigV4aRegionSetConfiguration(regions, SigV4aRegionSetSource.EndpointsMetadata);
        }

        /// <summary>
        /// Creates a SigV4aRegionSetConfiguration from environment variables.
        /// </summary>
        /// <returns>A new SigV4aRegionSetConfiguration instance if the environment variable is set; otherwise, null.</returns>
        public static SigV4aRegionSetConfiguration FromEnvironment()
        {
            var envValue = EnvironmentConfigurationProvider.GetSigV4aRegionSet();
            if (string.IsNullOrWhiteSpace(envValue))
                return null;

            var regions = ParseRegionSet(envValue);
            return new SigV4aRegionSetConfiguration(regions, SigV4aRegionSetSource.Environment);
        }

        /// <summary>
        /// Creates a SigV4aRegionSetConfiguration from configuration file.
        /// </summary>
        /// <param name="configValue">The configuration value from the config file.</param>
        /// <returns>A new SigV4aRegionSetConfiguration instance if configValue is valid; otherwise, null.</returns>
        public static SigV4aRegionSetConfiguration FromConfigFile(string configValue)
        {
            if (string.IsNullOrWhiteSpace(configValue))
                return null;

            var regions = ParseRegionSet(configValue);
            return new SigV4aRegionSetConfiguration(regions, SigV4aRegionSetSource.ConfigFile);
        }

        /// <summary>
        /// Creates a SigV4aRegionSetConfiguration from client configuration.
        /// </summary>
        /// <param name="regions">The list of regions from client configuration.</param>
        /// <returns>A new SigV4aRegionSetConfiguration instance.</returns>
        public static SigV4aRegionSetConfiguration FromClientConfiguration(IEnumerable<string> regions)
        {
            return new SigV4aRegionSetConfiguration(regions, SigV4aRegionSetSource.ClientConfiguration);
        }

        /// <summary>
        /// Creates a SigV4aRegionSetConfiguration with a single region (fallback).
        /// </summary>
        /// <param name="region">The single region to use.</param>
        /// <returns>A new SigV4aRegionSetConfiguration instance.</returns>
        public static SigV4aRegionSetConfiguration FromSingleRegion(string region)
        {
            if (string.IsNullOrWhiteSpace(region))
                throw new ArgumentException("Region cannot be null or empty", nameof(region));

            return new SigV4aRegionSetConfiguration(new[] { region }, SigV4aRegionSetSource.SingleRegionFallback);
        }

        /// <summary>
        /// Parses a comma-separated region set string.
        /// </summary>
        /// <param name="regionSetString">The comma-separated region set string.</param>
        /// <returns>A list of parsed regions.</returns>
        private static List<string> ParseRegionSet(string regionSetString)
        {
            if (string.IsNullOrWhiteSpace(regionSetString))
                throw new ArgumentException("Region set string cannot be null or empty", nameof(regionSetString));

            return regionSetString
                .Split(',')
                .Select(r => r.Trim())
                .Where(r => !string.IsNullOrWhiteSpace(r))
                .ToList();
        }

        /// <summary>
        /// Returns a comma-separated string representation of the region set.
        /// </summary>
        /// <returns>A comma-separated string of regions.</returns>
        public string ToCommaSeparatedString()
        {
            return string.Join(",", RegionSet);
        }

        /// <summary>
        /// Determines whether the specified object is equal to the current SigV4aRegionSetConfiguration.
        /// </summary>
        /// <param name="obj">The object to compare with the current SigV4aRegionSetConfiguration.</param>
        /// <returns>true if the specified object is equal to the current SigV4aRegionSetConfiguration; otherwise, false.</returns>
        public override bool Equals(object obj)
        {
            return Equals(obj as SigV4aRegionSetConfiguration);
        }

        /// <summary>
        /// Determines whether the specified SigV4aRegionSetConfiguration is equal to the current SigV4aRegionSetConfiguration.
        /// </summary>
        /// <param name="other">The SigV4aRegionSetConfiguration to compare with the current SigV4aRegionSetConfiguration.</param>
        /// <returns>true if the specified SigV4aRegionSetConfiguration is equal to the current SigV4aRegionSetConfiguration; otherwise, false.</returns>
        public bool Equals(SigV4aRegionSetConfiguration other)
        {
            if (other is null) return false;
            if (ReferenceEquals(this, other)) return true;
            return Source == other.Source && RegionSet.SequenceEqual(other.RegionSet);
        }

        /// <summary>
        /// Returns the hash code for this SigV4aRegionSetConfiguration.
        /// </summary>
        /// <returns>A hash code for the current SigV4aRegionSetConfiguration.</returns>
        public override int GetHashCode()
        {
            var regionHash = HashCodeHelper.CombineHashCodes(RegionSet.ToArray());
            return HashCodeHelper.CombineHashCodes(Source, regionHash);
        }

        /// <summary>
        /// Returns a string representation of the SigV4aRegionSetConfiguration.
        /// </summary>
        /// <returns>A string representation of the SigV4aRegionSetConfiguration.</returns>
        public override string ToString()
        {
            return $"SigV4aRegionSetConfiguration(RegionSet=[{ToCommaSeparatedString()}], Source={Source})";
        }

        /// <summary>
        /// Determines whether two SigV4aRegionSetConfiguration instances are equal.
        /// </summary>
        /// <param name="left">The first SigV4aRegionSetConfiguration to compare.</param>
        /// <param name="right">The second SigV4aRegionSetConfiguration to compare.</param>
        /// <returns>true if the SigV4aRegionSetConfiguration instances are equal; otherwise, false.</returns>
        public static bool operator ==(SigV4aRegionSetConfiguration left, SigV4aRegionSetConfiguration right)
        {
            if (left is null) return right is null;
            return left.Equals(right);
        }

        /// <summary>
        /// Determines whether two SigV4aRegionSetConfiguration instances are not equal.
        /// </summary>
        /// <param name="left">The first SigV4aRegionSetConfiguration to compare.</param>
        /// <param name="right">The second SigV4aRegionSetConfiguration to compare.</param>
        /// <returns>true if the SigV4aRegionSetConfiguration instances are not equal; otherwise, false.</returns>
        public static bool operator !=(SigV4aRegionSetConfiguration left, SigV4aRegionSetConfiguration right)
        {
            return !(left == right);
        }
    }

    /// <summary>
    /// Enumeration of SigV4a region set configuration sources.
    /// </summary>
    public enum SigV4aRegionSetSource
    {
        /// <summary>
        /// Region set from client configuration (highest priority).
        /// </summary>
        ClientConfiguration,

        /// <summary>
        /// Region set from environment variables.
        /// </summary>
        Environment,

        /// <summary>
        /// Region set from configuration file.
        /// </summary>
        ConfigFile,

        /// <summary>
        /// Region set from endpoints 2.0 metadata.
        /// </summary>
        EndpointsMetadata,

        /// <summary>
        /// Single region fallback (lowest priority).
        /// </summary>
        SingleRegionFallback
    }
}