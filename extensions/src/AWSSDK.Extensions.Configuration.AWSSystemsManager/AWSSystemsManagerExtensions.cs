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
using Amazon.Extensions.NETCore.Setup;

// ReSharper disable once CheckNamespace
namespace Microsoft.Extensions.Configuration
{
    /// <summary>
    /// Extension methods for registering <see cref="AWSSystemsManagerConfigurationProvider"/> with <see cref="IConfigurationBuilder"/>.
    /// </summary>
    public static class AWSSystemsManagerExtensions
    {
        /// <summary>
        /// Adds an <see cref="IConfigurationProvider"/> that reads configuration values from AWS Systems Manager Parameter Store with a specified path.
        /// </summary>
        /// <param name="builder">The <see cref="IConfigurationBuilder"/> to add to.</param>
        /// <param name="awsOptions"><see cref="AWSOptions"/> used to create an AWS Systems Manager Client connection</param>
        /// <param name="path">The path that variable names must start with. The path will be removed from the variable names.</param>
        /// <param name="reloadAfter">Initiate reload after TimeSpan</param>
        /// <param name="onLoadException">Delegate to call on Exception</param>
        /// <returns>The <see cref="IConfigurationBuilder"/>.</returns>
        public static IConfigurationBuilder AddAWSSystemsManager(this IConfigurationBuilder builder, AWSOptions awsOptions, string path, TimeSpan? reloadAfter = null, Action<AWSSystemsManagerExceptionContext> onLoadException = null)
        {
            if (awsOptions == null) throw new ArgumentNullException(nameof(awsOptions));
            if (string.IsNullOrWhiteSpace(path)) throw new ArgumentNullException(nameof(path));
            return builder.AddAWSSystemsManager(source =>
            {
                source.AwsOptions = awsOptions;
                source.Path = path;
                source.ReloadAfter = reloadAfter;
                source.OnLoadException = onLoadException;
            });
        }

        /// <summary>
        /// Adds an <see cref="IConfigurationProvider"/> that reads configuration values from AWS Systems Manager Parameter variables with a specified path.
        /// </summary>
        /// <param name="builder">The <see cref="IConfigurationBuilder"/> to add to.</param>
        /// <param name="path">The path that variable names must start with. The path will be removed from the variable names.</param>
        /// <param name="reloadAfter">Initiate reload after TimeSpan</param>
        /// <param name="onLoadException">Delegate to call on Exception</param>
        /// <returns>The <see cref="IConfigurationBuilder"/>.</returns>
        public static IConfigurationBuilder AddAWSSystemsManager(this IConfigurationBuilder builder, string path, TimeSpan? reloadAfter = null, Action<AWSSystemsManagerExceptionContext> onLoadException = null)
        {
            if (string.IsNullOrWhiteSpace(path)) throw new ArgumentNullException(nameof(path));
            var config = builder.Build();
            return builder.AddAWSSystemsManager(config.GetAWSOptions(), path, reloadAfter, onLoadException);
        }

        /// <summary>
        /// Adds an <see cref="IConfigurationProvider"/> that reads configuration values from environment variables.
        /// </summary>
        /// <param name="builder">The <see cref="IConfigurationBuilder"/> to add to.</param>
        /// <param name="configureSource">Configures the source.</param>
        /// <returns>The <see cref="IConfigurationBuilder"/>.</returns>
        public static IConfigurationBuilder AddAWSSystemsManager(this IConfigurationBuilder builder, Action<AWSSystemsManagerConfigurationSource> configureSource)
        {
            var configurationSource = new AWSSystemsManagerConfigurationSource();
            configureSource(configurationSource);
            if (string.IsNullOrWhiteSpace(configurationSource.Path)) throw new ArgumentNullException(nameof(configurationSource.Path));
            if (configurationSource.AwsOptions != null) return builder.Add(configurationSource);
            
            var config = builder.Build();
            configurationSource.AwsOptions = config.GetAWSOptions();
            return builder.Add(configurationSource);
        }
    }
}