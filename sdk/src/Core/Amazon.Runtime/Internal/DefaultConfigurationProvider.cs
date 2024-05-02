/* * Copyright Amazon.com, Inc. or its affiliates. All Rights Reserved.
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
using Amazon.Util;
using Amazon.Util.Internal;

namespace Amazon.Runtime.Internal
{
    /// <inheritdoc cref="GetDefaultConfiguration"/>
    public interface IDefaultConfigurationProvider
    {
        /// <summary>
        /// Determines the correct <see cref="DefaultConfiguration"/> to use.
        /// <para />
        /// Implementations of <see cref="IDefaultConfigurationProvider"/> are responsible for storing a reference to
        /// all valid <see cref="DefaultConfiguration"/>s for a given context.  Because the default values in a <see cref="DefaultConfiguration"/>
        /// can differ between Services, it's important to not use <see cref="IDefaultConfigurationProvider"/>s in a different
        /// Service Client.
        /// <para />
        /// The <see cref="DefaultConfiguration"/> is selected as follows:
        /// <list type="number">
        /// <item>Mode matching <paramref name="requestedConfigurationMode"/>.  This should be set via <see cref="ClientConfig.DefaultConfigurationMode"/></item>
        /// <item>The Environment Variable <see cref="DefaultConfigurationProvider.AWS_DEFAULTS_MODE_ENVIRONMENT_VARIABLE"/></item>
        /// <item>Shared config/credential file via <see cref="FallbackInternalConfigurationFactory.DefaultConfigurationModeName"/></item>
        /// <item><see cref="DefaultConfigurationMode.Standard"/></item>
        /// </list>
        /// </summary>
        /// <remarks>
        /// <see cref="IDefaultConfiguration"/> is not cached.  It will be re-resolved on every call.
        /// </remarks>
        IDefaultConfiguration GetDefaultConfiguration(RegionEndpoint clientRegion, DefaultConfigurationMode? requestedConfigurationMode = null);
    }

    /// <inheritdoc cref="IDefaultConfigurationProvider"/>
    public class DefaultConfigurationProvider : IDefaultConfigurationProvider
    {
        private const string AWS_DEFAULTS_MODE_ENVIRONMENT_VARIABLE = "AWS_DEFAULTS_MODE";

        private readonly IEnvironmentVariableRetriever _environmentVariableRetriever;
        private readonly IDefaultConfigurationAutoModeResolver _defaultConfigurationAutoModeResolver;

        private readonly IDefaultConfiguration[] _availableConfigurations;

        /// <inheritdoc cref="IDefaultConfigurationProvider"/>
        public DefaultConfigurationProvider(IEnumerable<IDefaultConfiguration> availableConfigurations)
            : this(EnvironmentVariableSource.Instance.EnvironmentVariableRetriever,
                new DefaultConfigurationAutoModeResolver(
                    new RuntimeInformationProvider(),
                    EnvironmentVariableSource.Instance.EnvironmentVariableRetriever),
                availableConfigurations) { }

        /// <inheritdoc cref="IDefaultConfigurationProvider"/>
        public DefaultConfigurationProvider(
            IEnvironmentVariableRetriever environmentVariableRetriever,
            IDefaultConfigurationAutoModeResolver defaultConfigurationAutoModeResolver,
            IEnumerable<IDefaultConfiguration> availableConfigurations)
            : this (environmentVariableRetriever, defaultConfigurationAutoModeResolver, availableConfigurations.ToArray()) { }

        /// <inheritdoc cref="IDefaultConfigurationProvider"/>
        public DefaultConfigurationProvider(
            IEnvironmentVariableRetriever environmentVariableRetriever,
            IDefaultConfigurationAutoModeResolver defaultConfigurationAutoModeResolver,
            params IDefaultConfiguration[] availableConfigurations)
        {
            if (availableConfigurations?.Any() != true)
                throw new ArgumentException(
                    "Must provide at least one Default Configuration",
                    nameof(availableConfigurations));

            _environmentVariableRetriever = environmentVariableRetriever;
            _defaultConfigurationAutoModeResolver = defaultConfigurationAutoModeResolver;
            _availableConfigurations = availableConfigurations;
        }

        /// <inheritdoc cref="IDefaultConfigurationProvider"/>
        public IDefaultConfiguration GetDefaultConfiguration(
            RegionEndpoint clientRegion,
            DefaultConfigurationMode? requestedConfigurationMode = null)
        {
            var defaultConfigurationModeName =
                // 1) requested mode
                requestedConfigurationMode?.ToString() ??
                // 2) try to get from environment variable
                _environmentVariableRetriever.GetEnvironmentVariable(AWS_DEFAULTS_MODE_ENVIRONMENT_VARIABLE) ??
                // 3) try to get from shared config/credential file
                FallbackInternalConfigurationFactory.DefaultConfigurationModeName ??
                // 4) fallback to 'Standard'
                DefaultConfigurationMode.Standard.ToString();

            Logger
                .GetLogger(GetType())
                .InfoFormat(
                    $"Resolved {nameof(DefaultConfigurationMode)} for {nameof(RegionEndpoint)} [{clientRegion?.SystemName}] to [{defaultConfigurationModeName}].");

            try
            {
                var mode =
                    (DefaultConfigurationMode)
                    Enum.Parse(typeof(DefaultConfigurationMode), defaultConfigurationModeName, ignoreCase: true);

                if (mode == DefaultConfigurationMode.Auto)
                    mode = _defaultConfigurationAutoModeResolver.Resolve(clientRegion, () => EC2InstanceMetadata.Region);
               
                // save resolved values to cache
                return _availableConfigurations.First(x => x.Name == mode);
            }
            catch (Exception)
            {
                throw new AmazonClientException(
                    $"Failed to find requested Default Configuration Mode '{defaultConfigurationModeName}'.  " +
                    $"Valid values are {string.Join(",", Enum.GetNames(typeof(DefaultConfigurationMode)))}");
            }
        }
    }
}