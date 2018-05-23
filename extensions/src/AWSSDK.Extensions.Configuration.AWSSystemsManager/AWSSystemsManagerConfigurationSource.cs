﻿/*
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
    /// <inheritdoc />
    /// <summary>
    /// Represents AWS Systems Manager Parameter Store variables as an <see cref="T:Microsoft.Extensions.Configuration.IConfigurationSource" />.
    /// </summary>
    public class AWSSystemsManagerConfigurationSource : IConfigurationSource
    {
        /// <summary>
        /// A Path used to filter parameters.
        /// </summary>
        public string Path { get; set; }

        /// <summary>
        /// <see cref="AWSOptions"/> used to create an AWS Systems Manager Client />.
        /// </summary>
        public AWSOptions AwsOptions { get; set; }

        /// <summary>
        /// Paramaters will be reloaded from the AWS Systems Manager Parameter Store after the specified timeframe
        /// </summary>
        public TimeSpan? ReloadAfter { get; set; }

        /// <summary>
        /// Will be called if an uncaught exception occurs in <see cref="AWSSystemsManagerConfigurationProvider"/>.Load.
        /// </summary>
        public Action<AWSSystemsManagerExceptionContext> OnLoadException { get; set; }

        /// <inheritdoc />
        /// <summary>
        /// Builds the <see cref="T:Microsoft.Extensions.Configuration.AWSSystemsManagerConfigurationProvider" /> for this source.
        /// </summary>
        /// <param name="builder">The <see cref="T:Microsoft.Extensions.Configuration.IConfigurationBuilder" />.</param>
        /// <returns>A <see cref="T:Microsoft.Extensions.Configuration.AWSSystemsManagerConfigurationProvider" /></returns>
        public IConfigurationProvider Build(IConfigurationBuilder builder)
        {
            return new AWSSystemsManagerConfigurationProvider(this);
        }
    }
}
