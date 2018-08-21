/*
 * Copyright 2018 Amazon.com, Inc. or its affiliates. All Rights Reserved.
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
using Amazon.Extensions.Configuration.AWSSystemsManager;
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
        /// <param name="optional">Whether the AWS Systems Manager Parameters are optional.</param>
        /// <param name="reloadAfter">Initiate reload after TimeSpan</param>
        /// <param name="onLoadException">Delegate to call on Exception</param>
        /// <returns>The <see cref="IConfigurationBuilder"/>.</returns>
        public static IConfigurationBuilder AddAWSSystemsManager(this IConfigurationBuilder builder, AWSOptions awsOptions, string path, bool optional = false, TimeSpan? reloadAfter = null, Action<AWSSystemsManagerExceptionContext> onLoadException = null)
        {
            if (string.IsNullOrWhiteSpace(path)) throw new ArgumentNullException(nameof(path));
            if (awsOptions == null) throw new ArgumentNullException(nameof(awsOptions));
            return builder.AddAWSSystemsManager(source =>
            {
                source.AwsOptions = awsOptions;
                source.Path = path;
                source.Optional = optional;
                source.ReloadAfter = reloadAfter;
                source.OnLoadException = onLoadException;
            });
        }

        /// <summary>
        /// Adds an <see cref="IConfigurationProvider"/> that reads configuration values from AWS Systems Manager Parameter variables with a specified path.
        /// </summary>
        /// <param name="builder">The <see cref="IConfigurationBuilder"/> to add to.</param>
        /// <param name="path">The path that variable names must start with. The path will be removed from the variable names.</param>
        /// <param name="optional">Whether the AWS Systems Manager Parameters are optional.</param>
        /// <param name="reloadAfter">Initiate reload after TimeSpan</param>
        /// <param name="onLoadException">Delegate to call on Exception</param>
        /// <returns>The <see cref="IConfigurationBuilder"/>.</returns>
        public static IConfigurationBuilder AddAWSSystemsManager(this IConfigurationBuilder builder, string path, bool optional = false, TimeSpan? reloadAfter = null, Action<AWSSystemsManagerExceptionContext> onLoadException = null)
        {
            if (string.IsNullOrWhiteSpace(path)) throw new ArgumentNullException(nameof(path));
            var config = builder.Build();
            return builder.AddAWSSystemsManager(config.GetAWSOptions(), path, optional, reloadAfter, onLoadException);
        }

        /// <summary>
        /// Adds an <see cref="IConfigurationProvider"/> that reads configuration values from AWS Systems Manager Parameter variables with a specified path.
        /// </summary>
        /// <param name="builder">The <see cref="IConfigurationBuilder"/> to add to.</param>
        /// <param name="configureSource">Configures the source.</param>
        /// <returns>The <see cref="IConfigurationBuilder"/>.</returns>
        public static IConfigurationBuilder AddAWSSystemsManager(this IConfigurationBuilder builder, Action<AWSSystemsManagerConfigurationSource> configureSource)
        {
            var source = new AWSSystemsManagerConfigurationSource();
            configureSource(source);
            if (string.IsNullOrWhiteSpace(source.Path)) throw new ArgumentNullException(nameof(source.Path));
            if (source.AwsOptions != null) return builder.Add(source);
            
            var config = builder.Build();
            source.AwsOptions = config.GetAWSOptions();
            return builder.Add(source);
        }
    }
}