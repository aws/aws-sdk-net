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

/*
 * Do not modify this file. This file is generated from the lambda-2015-03-31.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

#pragma warning disable CS0612,CS0618,CS1570
namespace Amazon.Lambda.Model
{
    /// <summary>
    /// (Amazon MSK, and self-managed Apache Kafka only) The logging configuration for your
    /// event source. Use this configuration object to define the level of logs for your event
    /// source mapping.
    /// </summary>
    public partial class EventSourceMappingLoggingConfig
    {
        private EventSourceMappingSystemLogLevel _systemLogLevel;

        /// <summary>
        /// Gets and sets the property SystemLogLevel. 
        /// <para>
        ///  The log level you want your event source mapping to use. Lambda event poller only
        /// sends system logs at the selected level of detail and lower, where <c>DEBUG</c> is
        /// the highest level and <c>WARN</c> is the lowest. For more information about these
        /// metrics, see <a href="https://docs.aws.amazon.com/lambda/latest/dg/esm-logging.html">
        /// Event source mapping logging</a>. 
        /// </para>
        /// </summary>
        public EventSourceMappingSystemLogLevel SystemLogLevel
        {
            get { return this._systemLogLevel; }
            set { this._systemLogLevel = value; }
        }

        // Check to see if SystemLogLevel property is set
        internal bool IsSetSystemLogLevel()
        {
            return this._systemLogLevel != null;
        }

    }
}