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
using System.Reflection;

using Amazon;
using Amazon.Runtime;
using Amazon.Util;

using Amazon.Extensions.NETCore.Setup;
using System.Linq;

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
        /// Constructs an AWSOptions class with the options specified in the "AWS" section in the IConfiguration object.
        /// </summary>
        /// <param name="config"></param>
        /// <returns>The AWSOptions containing the values set in configuration system.</returns>
        public static AWSOptions GetAWSOptions(this IConfiguration config)
        {
            return GetAWSOptions(config, DEFAULT_CONFIG_SECTION);
        }

        /// <summary>
        /// Constructs an AWSOptions class with the options specified in the "AWS" section in the IConfiguration object.
        /// </summary>
        /// <param name="config"></param>
        /// <param name="configSection">The config section to extract AWS options from.</param>
        /// <returns>The AWSOptions containing the values set in configuration system.</returns>
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
                    var property = clientConfigTypeInfo.DeclaredProperties.SingleOrDefault(p => p.Name.Equals(element.Key, StringComparison.OrdinalIgnoreCase));
                    if (property == null || property.SetMethod == null)
                        continue;

                    if (property.PropertyType == typeof(string) || property.PropertyType.GetTypeInfo().IsPrimitive)
                    {
                        var value = Convert.ChangeType(element.Value, property.PropertyType);
                        property.SetMethod.Invoke(options.DefaultClientConfig, new object[] { value });
                    }
                    else if (property.PropertyType == typeof(TimeSpan) || property.PropertyType == typeof(Nullable<TimeSpan>))
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
            // Check legacy name if the new name isn't set
            else if (!string.IsNullOrEmpty(section["AWSProfileName"]))
            {
                options.Profile = section["AWSProfileName"];
            }

            if (!string.IsNullOrEmpty(section["ProfilesLocation"]))
            {
                options.ProfilesLocation = section["ProfilesLocation"];
            }
            // Check legacy name if the new name isn't set
            else if (!string.IsNullOrEmpty(section["AWSProfilesLocation"]))
            {
                options.ProfilesLocation = section["AWSProfilesLocation"];
            }

            if (!string.IsNullOrEmpty(section["Region"]))
            {
                options.Region = RegionEndpoint.GetBySystemName(section["Region"]);
            }
            // Check legacy name if the new name isn't set
            else if (!string.IsNullOrEmpty(section["AWSRegion"]))
            {
                options.Region = RegionEndpoint.GetBySystemName(section["AWSRegion"]);
            }

            if (!string.IsNullOrEmpty(section["DefaultsMode"]))
            {
                if(!Enum.TryParse<DefaultConfigurationMode>(section["DefaultsMode"], out var mode))
                {
                    throw new ArgumentException($"Invalid value for DefaultConfiguration. Valid values are: {string.Join(", ", Enum.GetNames(typeof(DefaultConfigurationMode)))} ");
                }
                options.DefaultConfigurationMode = mode;
            }

            if (!string.IsNullOrEmpty(section["SessionRoleArn"]))
            {
                options.SessionRoleArn = section["SessionRoleArn"];
            }

            if (!string.IsNullOrEmpty(section["SessionName"]))
            {
                options.SessionName = section["SessionName"];
            }

            var loggingSection = section.GetSection("Logging");
            if(loggingSection != null)
            {
                options.Logging = new AWSOptions.LoggingSetting();

                if (!string.IsNullOrEmpty(loggingSection[nameof(AWSOptions.LoggingSetting.LogTo)]))
                {
                    if (!Enum.TryParse<LoggingOptions>(loggingSection[nameof(AWSOptions.LoggingSetting.LogTo)], out var logTo))
                    {
                        throw new ArgumentException($"Invalid value for {nameof(AWSOptions.LoggingSetting.LogTo)}. Valid values are: {string.Join(", ", Enum.GetNames(typeof(LoggingOptions)))} ");
                    }
                    options.Logging.LogTo = logTo;
                }

                if (!string.IsNullOrEmpty(loggingSection[nameof(AWSOptions.LoggingSetting.LogResponses)]))
                {
                    if (!Enum.TryParse<ResponseLoggingOption>(loggingSection[nameof(AWSOptions.LoggingSetting.LogResponses)], out var logResponses))
                    {
                        throw new ArgumentException($"Invalid value for {nameof(AWSOptions.LoggingSetting.LogResponses)}. Valid values are: {string.Join(", ", Enum.GetNames(typeof(ResponseLoggingOption)))} ");
                    }
                    options.Logging.LogResponses = logResponses;
                }

                if (!string.IsNullOrEmpty(loggingSection[nameof(AWSOptions.LoggingSetting.LogResponsesSizeLimit)]))
                {
                    if (!int.TryParse(loggingSection[nameof(AWSOptions.LoggingSetting.LogResponsesSizeLimit)], out var logResponsesSizeLimit))
                    {
                        throw new ArgumentException($"Invalid integer value for {nameof(AWSOptions.LoggingSetting.LogResponsesSizeLimit)}.");
                    }
                    options.Logging.LogResponsesSizeLimit = logResponsesSizeLimit;
                }

                if (!string.IsNullOrEmpty(loggingSection[nameof(AWSOptions.LoggingSetting.LogMetrics)]))
                {
                    if (!bool.TryParse(loggingSection[nameof(AWSOptions.LoggingSetting.LogMetrics)], out var logMetrics))
                    {
                        throw new ArgumentException($"Invalid boolean value for {nameof(AWSOptions.LoggingSetting.LogMetrics)}.");
                    }
                    options.Logging.LogMetrics = logMetrics;
                }
            }

            return options;
        }
    }
}
