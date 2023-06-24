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
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Util;
using Amazon.Util;
using Amazon.Util.Internal;

namespace Amazon.Runtime.Internal
{
    /// <summary>
    /// Resolves <see cref="DefaultConfigurationMode.Auto"/> into the correct <see cref="DefaultConfigurationMode"/> given
    /// the current operating environment.
    /// </summary>
    public interface IDefaultConfigurationAutoModeResolver
    {
        /// <summary>
        /// Resolves <see cref="DefaultConfigurationMode.Auto"/> into the correct <see cref="DefaultConfigurationMode"/> given
        /// the current operating environment.
        ///<para />
        /// Auto resolution is heuristic based and does not guarantee 100% accuracy.
        /// If you are unsure about the behavior, use a <see cref="DefaultConfigurationMode"/> other
        /// than <see cref="DefaultConfigurationMode.Auto"/>.
        /// </summary>
        /// <param name="clientRegion">The <see cref="RegionEndpoint"/> configured in <see cref="IClientConfig.RegionEndpoint"/>.</param>
        /// <param name="imdsRegion">
        /// IMDS region provided by <see cref="EC2InstanceMetadata.Region"/>.
        /// Func allows to defer the check until the point of use.
        /// </param>
        /// <returns>The resolved <see cref="DefaultConfigurationMode"/> for the current operating environment.</returns>
        DefaultConfigurationMode Resolve(RegionEndpoint clientRegion, Func<RegionEndpoint> imdsRegion);
    }


    /// <inheritdoc />
    public class DefaultConfigurationAutoModeResolver : IDefaultConfigurationAutoModeResolver
    {
        private readonly IRuntimeInformationProvider _runtimeInformationProvider;
        private readonly IEnvironmentVariableRetriever _environmentVariableRetriever;

        public DefaultConfigurationAutoModeResolver(IRuntimeInformationProvider runtimeInformationProvider,
            IEnvironmentVariableRetriever environmentVariableRetriever)
        {
            _runtimeInformationProvider = runtimeInformationProvider;
            _environmentVariableRetriever = environmentVariableRetriever;
        }

        /// <inheritdoc />
        public DefaultConfigurationMode Resolve(RegionEndpoint clientRegion, Func<RegionEndpoint> imdsRegion)
        {
            var defaultConfigurationMode = ResolveInternal(clientRegion, imdsRegion);

            Logger
                .GetLogger(GetType())
                .InfoFormat($"Resolved {nameof(DefaultConfigurationMode)} for {nameof(RegionEndpoint)} [{clientRegion?.SystemName}] to [{defaultConfigurationMode}].");

            return defaultConfigurationMode;
        }

        private DefaultConfigurationMode ResolveInternal(RegionEndpoint clientRegion, Func<RegionEndpoint> imdsRegion)
        {
            if (_runtimeInformationProvider.IsMobile())
            {
                return DefaultConfigurationMode.Mobile;
            }

            // We're not on mobile (best we can tell). See if we can determine whether we're an in-region or cross-region client.
            string currentRegion = null;
            if (!string.IsNullOrEmpty(_environmentVariableRetriever.GetEnvironmentVariable(InternalSDKUtils.EXECUTION_ENVIRONMENT_ENVVAR)))
            {
                currentRegion =  _environmentVariableRetriever.GetEnvironmentVariable(EnvironmentVariableAWSRegion.ENVIRONMENT_VARIABLE_REGION);
                if (string.IsNullOrEmpty(currentRegion))
                {
                    currentRegion =  _environmentVariableRetriever.GetEnvironmentVariable(EnvironmentVariableAWSRegion.ENVIRONMENT_VARIABLE_DEFAULT_REGION);
                }
            }

            if (string.IsNullOrEmpty(currentRegion))
            {
                // We couldn't figure out the region from environment variables. Check IMDSv2
                // There is no need to check AWS_EC2_METADATA_DISABLED env var, because EC2InstanceMetadata handles it internally.
                currentRegion = imdsRegion()?.SystemName;
            }

            if (!string.IsNullOrEmpty(currentRegion))
            {
                if (clientRegion.SystemName == currentRegion)
                {
                    return DefaultConfigurationMode.InRegion;
                }
                else
                {
                    return DefaultConfigurationMode.CrossRegion;
                }
            }

            // We don't seem to be mobile, and we couldn't determine whether we're running within an AWS region. Fall back to standard.
            return DefaultConfigurationMode.Standard;
        }
    }
}