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
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Amazon.Extensions.NETCore.Setup
{
    /// <summary>
    /// Exception for errors loading AWS options from IConfiguration object.
    /// </summary>
    public class ConfigurationException : Exception
    {
        /// <summary>
        /// Construct instance of ConfigurationException
        /// </summary>
        /// <param name="message">The error message.</param>
        public ConfigurationException(string message) : base(message) { }

        /// <summary>
        /// Construct instance of ConfigurationException
        /// </summary>
        /// <param name="message">The error message.</param>
        /// <param name="exception">Original exception.</param>
        public ConfigurationException(string message, Exception exception) : base(message, exception) { }

        /// <summary>
        /// The property that has an invalid value.
        /// </summary>
        public string PropertyName { get; set; }

        /// <summary>
        /// The value that was configured for the PropertyName.
        /// </summary>
        public string PropertyValue { get; set; }
    }
}
