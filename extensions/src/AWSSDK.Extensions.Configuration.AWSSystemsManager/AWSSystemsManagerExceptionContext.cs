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

// ReSharper disable once CheckNamespace
namespace Microsoft.Extensions.Configuration
{
    /// <summary>Contains information about an AWSSystemsManager load exception.</summary>
    public class AWSSystemsManagerExceptionContext
    {
        /// <summary>
        /// The <see cref="T:Microsoft.Extensions.Configuration.AWSSystemsManagerConfigurationProvider" /> that caused the exception.
        /// </summary>
        public AWSSystemsManagerConfigurationProvider Provider { get; set; }

        /// <summary>The exception that occured in Load.</summary>
        public Exception Exception { get; set; }

        /// <summary>If true, the exception will not be rethrown.</summary>
        public bool Ignore { get; set; }
    }
}