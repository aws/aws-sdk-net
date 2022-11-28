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
 * Do not modify this file. This file is generated from the logs-2014-03-28.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.CloudWatchLogs.Model
{
    /// <summary>
    /// Container for the parameters to the CreateLogStream operation.
    /// Creates a log stream for the specified log group. A log stream is a sequence of log
    /// events that originate from a single source, such as an application instance or a resource
    /// that is being monitored.
    /// 
    ///  
    /// <para>
    /// There is no limit on the number of log streams that you can create for a log group.
    /// There is a limit of 50 TPS on <code>CreateLogStream</code> operations, after which
    /// transactions are throttled.
    /// </para>
    ///  
    /// <para>
    /// You must use the following guidelines when naming a log stream:
    /// </para>
    ///  <ul> <li> 
    /// <para>
    /// Log stream names must be unique within the log group.
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// Log stream names can be between 1 and 512 characters long.
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// Don't use ':' (colon) or '*' (asterisk) characters.
    /// </para>
    ///  </li> </ul>
    /// </summary>
    public partial class CreateLogStreamRequest : AmazonCloudWatchLogsRequest
    {
        private string _logGroupName;
        private string _logStreamName;

        /// <summary>
        /// Empty constructor used to set  properties independently even when a simple constructor is available
        /// </summary>
        public CreateLogStreamRequest() { }

        /// <summary>
        /// Instantiates CreateLogStreamRequest with the parameterized properties
        /// </summary>
        /// <param name="logGroupName">The name of the log group.</param>
        /// <param name="logStreamName">The name of the log stream.</param>
        public CreateLogStreamRequest(string logGroupName, string logStreamName)
        {
            _logGroupName = logGroupName;
            _logStreamName = logStreamName;
        }

        /// <summary>
        /// Gets and sets the property LogGroupName. 
        /// <para>
        /// The name of the log group.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=512)]
        public string LogGroupName
        {
            get { return this._logGroupName; }
            set { this._logGroupName = value; }
        }

        // Check to see if LogGroupName property is set
        internal bool IsSetLogGroupName()
        {
            return this._logGroupName != null;
        }

        /// <summary>
        /// Gets and sets the property LogStreamName. 
        /// <para>
        /// The name of the log stream.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=512)]
        public string LogStreamName
        {
            get { return this._logStreamName; }
            set { this._logStreamName = value; }
        }

        // Check to see if LogStreamName property is set
        internal bool IsSetLogStreamName()
        {
            return this._logStreamName != null;
        }

    }
}