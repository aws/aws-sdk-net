/*
 * Copyright 2016-2017 Amazon.com, Inc. or its affiliates. All Rights Reserved.
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
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Primitives;

namespace Amazon.Extensions.NETCore.Setup
{
    /// <summary>
    /// This class reacts to reloads triggered by IConfiguration.
    /// </summary>
    public class AWSOptionsMonitor : IDisposable
    {
        private readonly IConfiguration configuration;
        private readonly AWSOptions options;
        private readonly IDisposable changeRegistration;
        private readonly object changeProcessingLock = new object();

        public AWSOptionsMonitor(IConfiguration configuration, AWSOptions options)
        {
            this.configuration = configuration;
            this.options = options;

            changeRegistration = ChangeToken.OnChange(
                configuration.GetReloadToken,
                InvokeChanged
            );
        }

        private void InvokeChanged()
        {
            lock (changeProcessingLock)
            {
                var updatedAwsOptions = configuration.GetAWSOptions();
                if (options.LogTo != updatedAwsOptions.LogTo)
                {
                    options.LogTo = updatedAwsOptions.LogTo;
                    AWSConfigs.LoggingConfig.LogTo = updatedAwsOptions.LogTo;
                }
            }
        }

        public void Dispose()
        {
            changeRegistration?.Dispose();
        }
    }
}