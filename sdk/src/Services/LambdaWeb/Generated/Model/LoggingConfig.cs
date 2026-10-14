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
 * Do not modify this file. This file is generated from the lambda-web-2025-03-07.normal.json service model.
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
namespace Amazon.LambdaWeb.Model
{
    /// <summary>
    /// The logging configuration for a web function revision.
    /// </summary>
    public partial class LoggingConfig
    {
        private ApplicationLogLevel _applicationLogLevel;
        private string _logGroup;
        private SystemLogLevel _systemLogLevel;

        /// <summary>
        /// Gets and sets the property ApplicationLogLevel. 
        /// <para>
        /// The log level for application logs emitted by the web function. If you don't specify
        /// a value, the default is <c>INFO</c>, and this default is returned in the response.
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
        /// Gets and sets the property LogGroup. 
        /// <para>
        /// The name of the Amazon CloudWatch Logs log group the web function sends logs to. If
        /// you don't specify a value, the default is <c>/aws/lambda/web/{functionName}</c>, and
        /// this default is returned in the response.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=500)]
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
        /// The log level for system logs emitted by the Lambda runtime. If you don't specify
        /// a value, the default is <c>INFO</c>, and this default is returned in the response.
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