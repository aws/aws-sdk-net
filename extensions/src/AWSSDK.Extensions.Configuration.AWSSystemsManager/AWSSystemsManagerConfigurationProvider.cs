﻿/*
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
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using Amazon.Extensions.Configuration.AWSSystemsManager.Internal;
using Amazon.SimpleSystemsManagement.Model;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Primitives;

// ReSharper disable once CheckNamespace
namespace Amazon.Extensions.Configuration.AWSSystemsManager
{
    /// <inheritdoc />
    /// <summary>
    /// An AWS Systems Manager Parameter Store based <see cref="IConfigurationProvider" />.
    /// </summary>
    public class AWSSystemsManagerConfigurationProvider : ConfigurationProvider
    {
        private readonly IAWSSystemsManagerProcessor _awsSystemsManagerProcessor;

        public AWSSystemsManagerConfigurationSource Source { get; }

        /// <inheritdoc />
        /// <summary>
        /// Initializes a new instance with the specified source.
        /// </summary>
        /// <param name="source">The <see cref="IConfigurationSource"/> used to retrieve values from AWS Systems Manager Parameter Store</param>
        public AWSSystemsManagerConfigurationProvider(AWSSystemsManagerConfigurationSource source) : this(source, new AWSSystemsManagerProcessor())
        {
        }

        public AWSSystemsManagerConfigurationProvider(AWSSystemsManagerConfigurationSource source, IAWSSystemsManagerProcessor awsSystemsManagerProcessor)
        {
            Source = source ?? throw new ArgumentNullException(nameof(source));
            _awsSystemsManagerProcessor = awsSystemsManagerProcessor;

            if (source.AwsOptions == null) throw new ArgumentNullException(nameof(source.AwsOptions));
            if (source.Path == null) throw new ArgumentNullException(nameof(source.Path));

            if (source.ReloadAfter != null)
            {
                ChangeToken.OnChange(() =>
                {
                    var cancellationTokenSource = new CancellationTokenSource(source.ReloadAfter.Value);
                    var cancellationChangeToken = new CancellationChangeToken(cancellationTokenSource.Token);
                    return cancellationChangeToken;
                }, async () => await LoadAsync(true));
            }
        }

        /// <inheritdoc />
        /// <summary>
        /// Loads the AWS Systems Manager Parameters.
        /// </summary>
        public override void Load() => LoadAsync(false).ConfigureAwait(false).GetAwaiter().GetResult();

        private async Task LoadAsync(bool reload)
        {
            try
            {
                var path = Source.Path;
                var awsOptions = Source.AwsOptions;
                var parameters = await _awsSystemsManagerProcessor.GetParametersByPathAsync(awsOptions, path);

                Data = ProcessParameters(parameters, path);

                OnReload();
            }
            catch (Exception ex)
            {
                if (Source.Optional || reload) return;

                var ignoreException = false;
                if (Source.OnLoadException != null)
                {
                    var exceptionContext = new AWSSystemsManagerExceptionContext
                    {
                        Provider = this,
                        Exception = ex
                    };
                    Source.OnLoadException(exceptionContext);
                    ignoreException = exceptionContext.Ignore;
                }

                if (!ignoreException)
                    throw;
            }
        }

        private static string NormalizeKey(string key)
        {
            return key.Replace("/", ConfigurationPath.KeyDelimiter);
        }

        public static IDictionary<string, string> ProcessParameters(List<Parameter> parameters, string path) =>
            parameters
                .Select(parameter => new
                {
                    Key = NormalizeKey(parameter.Name.Substring(path.Length).TrimStart('/')),
                    parameter.Value
                })
                .ToDictionary(parameter => parameter.Key, parameter => parameter.Value, StringComparer.OrdinalIgnoreCase);
    }
}