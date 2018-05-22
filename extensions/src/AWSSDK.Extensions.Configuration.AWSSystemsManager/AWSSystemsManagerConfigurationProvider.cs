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
using System.Threading;
using System.Threading.Tasks;
using Amazon.Extensions.NETCore.Setup;
using Amazon.SimpleSystemsManagement.Model;
using AWSSDK.Extensions.Configuration.AWSSystemsManager;
using Microsoft.Extensions.Primitives;

// ReSharper disable once CheckNamespace
namespace Microsoft.Extensions.Configuration
{
    /// <inheritdoc />
    /// <summary>
    /// An AWS Systems Manager Parameter Store based <see cref="IConfigurationProvider" />.
    /// </summary>
    public class AWSSystemsManagerConfigurationProvider : ConfigurationProvider
    {
        private readonly AWSSystemsManagerConfigurationSource _configurationSource;
        private readonly IAWSSystemsManagerProcessor _iawsSystemsManagerProcessor;

        /// <inheritdoc />
        /// <summary>
        /// Initializes a new instance with the specified source.
        /// </summary>
        /// <param name="configurationSource">The <see cref="IConfigurationSource"/> used to retrieve values from AWS Systems Manager Parameter Store</param>
        public AWSSystemsManagerConfigurationProvider(AWSSystemsManagerConfigurationSource configurationSource) : this(configurationSource, new AWSSystemsManagerProcessor())
        {
        }

        internal AWSSystemsManagerConfigurationProvider(AWSSystemsManagerConfigurationSource configurationSource, IAWSSystemsManagerProcessor iawsSystemsManagerProcessor)
        {
            _configurationSource = configurationSource ?? throw new ArgumentNullException(nameof(configurationSource));
            _iawsSystemsManagerProcessor = iawsSystemsManagerProcessor;
            if (configurationSource.AwsOptions == null) throw new ArgumentNullException(nameof(configurationSource.AwsOptions));
            if (configurationSource.Path == null) throw new ArgumentNullException(nameof(configurationSource.Path));

            if (configurationSource.ReloadAfter != null)
            {
                ChangeToken.OnChange(() =>
                {
                    var cancellationTokenSource = new CancellationTokenSource(configurationSource.ReloadAfter.Value);
                    var cancellationChangeToken = new CancellationChangeToken(cancellationTokenSource.Token);
                    return cancellationChangeToken;
                }, async () => await LoadAsync());
            }
        }

        /// <inheritdoc />
        /// <summary>
        /// Loads the AWS Systems Manager Parameters.
        /// </summary>
        public override void Load() => LoadAsync().ConfigureAwait(false).GetAwaiter().GetResult();

        private async Task LoadAsync()
        {
            try
            {
                var path = _configurationSource.Path;
                var awsOptions = _configurationSource.AwsOptions;
                var parameters = await _iawsSystemsManagerProcessor.GetParametersByPath(awsOptions, path);

                Data = ProcessParameters(parameters, path);
            }
            catch (Exception ex)
            {
                var ignoreException = false;
                if (_configurationSource.OnLoadException != null)
                {
                    var exceptionContext = new AWSSystemsManagerExceptionContext
                    {
                        Provider = this,
                        Exception = ex
                    };
                    _configurationSource.OnLoadException(exceptionContext);
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

        internal static IDictionary<string, string> ProcessParameters(List<Parameter> parameters, string path) =>
            parameters
                .Select(parameter => new
                {
                    Key = NormalizeKey(parameter.Name.Substring(path.Length).TrimStart('/')),
                    parameter.Value
                })
                .ToDictionary(parameter => parameter.Key, parameter => parameter.Value, StringComparer.OrdinalIgnoreCase);
    }
}