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
 * Do not modify this file. This file is generated from the lambda-microvms-2025-09-09.normal.json service model.
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
namespace Amazon.LambdaMicrovms.Model
{
    /// <summary>
    /// Configuration for MicroVM logging output. Specify exactly one: cloudWatch to enable
    /// CloudWatch logging, or disabled to turn off logging.
    /// </summary>
    public partial class Logging
    {
        private CloudWatchLogging _cloudWatch;
        private LoggingDisabled _disabled;

        /// <summary>
        /// Gets and sets the property CloudWatch. 
        /// <para>
        /// Configuration for sending logs to Amazon CloudWatch Logs.
        /// </para>
        /// </summary>
        public CloudWatchLogging CloudWatch
        {
            get { return this._cloudWatch; }
            set { this._cloudWatch = value; }
        }

        // Check to see if CloudWatch property is set
        internal bool IsSetCloudWatch()
        {
            return this._cloudWatch != null;
        }

        /// <summary>
        /// Gets and sets the property Disabled. 
        /// <para>
        /// Specifies that logging is disabled.
        /// </para>
        /// </summary>
        public LoggingDisabled Disabled
        {
            get { return this._disabled; }
            set { this._disabled = value; }
        }

        // Check to see if Disabled property is set
        internal bool IsSetDisabled()
        {
            return this._disabled != null;
        }

    }
}