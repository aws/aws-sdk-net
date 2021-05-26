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
 * Do not modify this file. This file is generated from the mwaa-2020-07-01.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.MWAA.Model
{
    /// <summary>
    /// Defines the type of logs to send for the Apache Airflow log type (e.g. <code>DagProcessingLogs</code>).
    /// Valid values: <code>CloudWatchLogGroupArn</code>, <code>Enabled</code>, <code>LogLevel</code>.
    /// </summary>
    public partial class ModuleLoggingConfigurationInput
    {
        private bool? _enabled;
        private LoggingLevel _logLevel;

        /// <summary>
        /// Gets and sets the property Enabled. 
        /// <para>
        /// Indicates whether to enable the Apache Airflow log type (e.g. <code>DagProcessingLogs</code>)
        /// in CloudWatch Logs.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public bool Enabled
        {
            get { return this._enabled.GetValueOrDefault(); }
            set { this._enabled = value; }
        }

        // Check to see if Enabled property is set
        internal bool IsSetEnabled()
        {
            return this._enabled.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property LogLevel. 
        /// <para>
        /// Defines the Apache Airflow logs to send for the log type (e.g. <code>DagProcessingLogs</code>)
        /// to CloudWatch Logs. Valid values: <code>CRITICAL</code>, <code>ERROR</code>, <code>WARNING</code>,
        /// <code>INFO</code>.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public LoggingLevel LogLevel
        {
            get { return this._logLevel; }
            set { this._logLevel = value; }
        }

        // Check to see if LogLevel property is set
        internal bool IsSetLogLevel()
        {
            return this._logLevel != null;
        }

    }
}