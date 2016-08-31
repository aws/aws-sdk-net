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
using System.Reflection;
using System.Threading.Tasks;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

using Amazon;
using Amazon.Runtime;

using Amazon.Extensions.NETCore.Setup;

namespace Microsoft.Extensions.Configuration
{
    /// <summary>
    /// This class adds extension methods to IConfiguration making it easier to pull out
    /// AWS configuration options.
    /// </summary>
    public static class ConfigurationExtensions
    {
        /// <summary>
        /// The default section where settings are read from the IConfiguration object. This is set to "AWS".
        /// </summary>
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

            IConfiguration section;
            if (string.IsNullOrEmpty(configSection))
                section = config;
            else
                section = config.GetSection(configSection);

            if (section == null)
                return options;

            var clientConfigTypeInfo = typeof(ClientConfig).GetTypeInfo();
            foreach(var element in section.GetChildren())
            {
                try
                {
                    var property = clientConfigTypeInfo.GetDeclaredProperty(element.Key);
                    if (property == null || property.SetMethod == null)
                        continue;

                    if (property.PropertyType == typeof(string) || property.PropertyType.GetTypeInfo().IsPrimitive)
                    {
                        var value = Convert.ChangeType(element.Value, property.PropertyType);
                        property.SetMethod.Invoke(options.DefaultClientConfig, new object[] { value });
                    }
                    else if (property.PropertyType == typeof(TimeSpan))
                    {
                        var milliSeconds = Convert.ToInt64(element.Value);
                        var timespan = TimeSpan.FromMilliseconds(milliSeconds);
                        property.SetMethod.Invoke(options.DefaultClientConfig, new object[] { timespan });
                    }
                }
                catch(Exception e)
                {
                    throw new ConfigurationException($"Error reading value for property {element.Key}.", e)
                    {
                        PropertyName = element.Key,
                        PropertyValue = element.Value
                    };
                }
            }

            if (!string.IsNullOrEmpty(section["Profile"]))
            {
                options.Profile = section["Profile"];
            }
            if (!string.IsNullOrEmpty(section["ProfilesLocation"]))
            {
                options.ProfilesLocation = section["Profile"];
            }
            if (!string.IsNullOrEmpty(section["Region"]))
            {
                options.Region = RegionEndpoint.GetBySystemName(section["Region"]);
            }

            return options;
        }
    }
}
