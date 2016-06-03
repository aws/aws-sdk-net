/*
 * Copyright 2011-2013 Amazon.com, Inc. or its affiliates. All Rights Reserved.
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
using System.Globalization;

using Amazon.Runtime.Internal.Util;
using System.Collections.Generic;
using Amazon.Util;

namespace Amazon.Runtime
{
    /// <summary>
    /// Base class for determining region based on inspection.
    /// </summary>
    public abstract class AWSRegion
    {
        public RegionEndpoint Region { get; protected set; }

        /// <summary>
        /// Sets the Region property by looking up the corresponding RegionEndpoint
        /// from the supplied region system name (us-east-1, us-west-2 etc).
        /// </summary>
        /// <param name="regionSystemName">The system name of the region.</param>
        protected void SetRegionFromName(string regionSystemName)
        {
            Region = RegionEndpoint.GetBySystemName(regionSystemName);
        }
    }

    /// <summary>
    /// Determines region based on application configuration settings. If the configuration does not contain
    /// the region setting key an InvalidOperationException is thrown.
    /// </summary>
    public class AppConfigAWSRegion : AWSRegion
    {
        /// <summary>
        /// Attempts to construct an instance of ApplicationConfigAWSRegion. If no region is found in the
        /// application configuration file then an InvalidOperationException is thrown.
        /// </summary>
        public AppConfigAWSRegion()
        {
            var region = AWSConfigs.RegionEndpoint;
            if (region != null)
            {
                this.Region = region;

                var logger = Logger.GetLogger(typeof(AppConfigAWSRegion));
                logger.InfoFormat("Region {0} found using {1} setting in application configuration file.", region.SystemName, AWSConfigs.AWSRegionKey);
            }
            else
                throw new InvalidOperationException(string.Format(CultureInfo.InvariantCulture,
                                                    "The app.config/web.config files for the application did not contain region information"));
        }
    }

#if BCL
    /// <summary>
    /// Determines region based on an environment variable. If the environment does not contain
    /// the region setting key an InvalidOperationException is thrown.
    /// </summary>
    public class EnvironmentVariableAWSRegion : AWSRegion
    {
        public const string ENVIRONMENT_VARIABLE_REGION = "AWS_REGION";

        /// <summary>
        /// Attempts to construct an instance of EnvironmentVariableAWSRegion. If no region is found in the
        /// environment then an InvalidOperationException is thrown.
        /// </summary>
        public EnvironmentVariableAWSRegion()
        {
            string regionName = Environment.GetEnvironmentVariable(ENVIRONMENT_VARIABLE_REGION);
            if (string.IsNullOrEmpty(regionName))
            {
                throw new InvalidOperationException(string.Format(CultureInfo.InvariantCulture,
                    "The environment variable {0} was not set with AWS region data.", ENVIRONMENT_VARIABLE_REGION));
            }

            SetRegionFromName(regionName);

            var logger = Logger.GetLogger(typeof(EnvironmentVariableAWSRegion));
            logger.InfoFormat("Region found using environment variable.");
        }
    }

    /// <summary>
    /// Determines region based on inspection of the instance metadata if running on an EC2 instance.
    /// If instance metadata cannot be read or does not contain region information an InvalidOperationException is thrown.
    /// </summary>
    public class InstanceProfileAWSRegion : AWSRegion
    {
        /// <summary>
        /// Attempts to construct an instance of InstanceProfileAWSRegion. If no region is found in the
        /// metadata or we are not running on an EC2 instance an InvalidOperationException is thrown.
        /// </summary>
        public InstanceProfileAWSRegion()
        {
            var region = EC2InstanceMetadata.Region;

            if (region == null)
            {
                throw new InvalidOperationException(string.Format(CultureInfo.InvariantCulture,
                    "EC2 instance metadata was not available or did not contain region information.", AWSConfigs.AWSRegionKey));
            }

            this.Region = region;

            var logger = Logger.GetLogger(typeof(InstanceProfileAWSRegion));
            logger.InfoFormat("Region found using EC2 instance metadata.");
        }
    }
#endif

    /// <summary>
    /// Probing mechanism to determine region from various sources.
    /// </summary>
    public static class FallbackRegionFactory
    {
        private static object _lock = new object();

        static FallbackRegionFactory()
        {
            Reset();
        }

        private delegate AWSRegion RegionGenerator();

        private static List<RegionGenerator> AllGenerators { get; set; }
        private static List<RegionGenerator> NonMetadataGenerators { get; set; }

        public static void Reset()
        {
            cachedRegion = null;
            AllGenerators = new List<RegionGenerator>
            {
                () => new AppConfigAWSRegion(),
#if BCL
                () => new EnvironmentVariableAWSRegion(),
                () => new InstanceProfileAWSRegion()
#endif
            };

            NonMetadataGenerators = new List<RegionGenerator>
            {
                () => new AppConfigAWSRegion(),
#if BCL
                () => new EnvironmentVariableAWSRegion()
#endif
            };
        }

        private static AWSRegion cachedRegion;

        public static RegionEndpoint GetRegionEndpoint()
        {
            return GetRegionEndpoint(true);
        }

        public static RegionEndpoint GetRegionEndpoint(bool includeInstanceMetadata)
        {
            lock(_lock)
            {
                if (cachedRegion != null)
                    return cachedRegion.Region;

                List<Exception> errors = new List<Exception>();

                IEnumerable<RegionGenerator> generators 
                    = includeInstanceMetadata ? AllGenerators : NonMetadataGenerators;
                foreach (var generator in generators)
                {
                    try
                    {
                        cachedRegion = generator();
                    }
                    catch (Exception e)
                    {
                        cachedRegion = null;
                        errors.Add(e);
                    }

                    if (cachedRegion != null)
                        break;
                }

                return cachedRegion != null ? cachedRegion.Region : null;
            }
        }
    }
}
