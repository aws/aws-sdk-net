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
    /// The function's Amazon CloudWatch Logs configuration settings.
    /// </summary>
    public partial class LoggingConfig
    {
        private ApplicationLogLevel _applicationLogLevel;
        private LogFormat _logFormat;
        private string _logGroup;
        private SystemLogLevel _systemLogLevel;

        /// <summary>
        /// Gets and sets the property ApplicationLogLevel. 
        /// <para>
        /// Set this property to filter the application logs for your function that Lambda sends
        /// to CloudWatch. Lambda only sends application logs at the selected level of detail
        /// and lower, where <c>TRACE</c> is the highest level and <c>FATAL</c> is the lowest.
        /// </para>
        /// </summary>
        public ApplicationLogLevel ApplicationLogLevel
        {
            get { return this._applicationLogLevel; }
            set { this._applicationLogLevel = value; }
        }

        // Check to see if ApplicationLogLevel property is set
        internal bool IsSetApplicationLogLevel()
        {
            return this._applicationLogLevel != null;
        }

        /// <summary>
        /// Gets and sets the property LogFormat. 
        /// <para>
        /// The format in which Lambda sends your function's application and system logs to CloudWatch.
        /// Select between plain text and structured JSON.
        /// </para>
        /// </summary>
        public LogFormat LogFormat
        {
            get { return this._logFormat; }
            set { this._logFormat = value; }
        }

        // Check to see if LogFormat property is set
        internal bool IsSetLogFormat()
        {
            return this._logFormat != null;
        }

        /// <summary>
        /// Gets and sets the property LogGroup. 
        /// <para>
        /// The name of the Amazon CloudWatch log group the function sends logs to. By default,
        /// Lambda functions send logs to a default log group named <c>/aws/lambda/&lt;function
        /// name&gt;</c>. To use a different log group, enter an existing log group or enter a
        /// new log group name.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=512)]
        public string LogGroup
        {
            get { return this._logGroup; }
            set { this._logGroup = value; }
        }

        // Check to see if LogGroup property is set
        internal bool IsSetLogGroup()
        {
            return this._logGroup != null;
        }

        /// <summary>
        /// Gets and sets the property SystemLogLevel. 
        /// <para>
        /// Set this property to filter the system logs for your function that Lambda sends to
        /// CloudWatch. Lambda only sends system logs at the selected level of detail and lower,
        /// where <c>DEBUG</c> is the highest level and <c>WARN</c> is the lowest.
        /// </para>
        /// </summary>
        public SystemLogLevel SystemLogLevel
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