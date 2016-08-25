/*
 * Copyright 2016 Amazon.com, Inc. or its affiliates. All Rights Reserved.
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
using System.Threading.Tasks;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

using Amazon;

namespace Microsoft.Extensions.Configuration
{
    /// <summary>
    /// This class adds extension methods to IConfiguration making it easier to pull out
    /// AWS configuration options.
    /// </summary>
    public static class ConfigurationExtensions
    {
        public const string DEFAULT_CONFIG_SECTION = "AWS";
        /// <summary>
        /// Constructs an AWSOptions class with the options specifed in the "AWS" section in the IConfiguration object.
        /// </summary>
        /// <param name="config"></param>
        /// <returns></returns>
        public static AWSOptions GetAWSOptions(this IConfiguration config)
        {
            return GetAWSOptions(config, DEFAULT_CONFIG_SECTION);
        }

        /// <summary>
        /// Constructs an AWSOptions class with the options specifed in the "AWS" section in the IConfiguration object.
        /// </summary>
        /// <param name="configSection">The config section to extract AWS options from.</param>
        /// <param name="config"></param>
        /// <returns></returns>, 
        public static AWSOptions GetAWSOptions(this IConfiguration config, string configSection)
        {
            var options = new AWSOptions();

            var section = config.GetSection(configSection) ?? config;
            if (section == null)
                return options;

            options.Profile = section["Profile"];

            if (!string.IsNullOrEmpty(section["Region"]))
            {
                options.Region = RegionEndpoint.GetBySystemName(section["Region"]);
            }

            return options;
        }
    }
}
