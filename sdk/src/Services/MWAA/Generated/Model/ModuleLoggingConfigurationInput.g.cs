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
 * Do not modify this file. This file is generated from the smithy.json service model.
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

namespace Amazon.MWAA.Model
{
    /// <summary>
    /// Enables the Apache Airflow log type (e.g. <c>DagProcessingLogs</c>) and defines the
    /// log level to send to CloudWatch Logs (e.g. <c>INFO</c>).
    /// </summary>
    public partial class ModuleLoggingConfigurationInput
    {
        /// <summary>
        /// Gets and sets the property Enabled. 
        /// <para>
        /// Indicates whether to enable the Apache Airflow log type (e.g. <c>DagProcessingLogs</c>).
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public bool? Enabled { get; set; }

        /// <summary>
        /// Checks to see if the Enabled property is set.
        /// </summary>
        internal bool IsSetEnabled() => this.Enabled.HasValue;

        /// <summary>
        /// Gets and sets the property LogLevel. 
        /// <para>
        /// Defines the Apache Airflow log level (e.g. <c>INFO</c>) to send to CloudWatch Logs.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public LoggingLevel LogLevel { get; set; }

        /// <summary>
        /// Checks to see if the LogLevel property is set.
        /// </summary>
        internal bool IsSetLogLevel() => this.LogLevel != null;
    }
}
