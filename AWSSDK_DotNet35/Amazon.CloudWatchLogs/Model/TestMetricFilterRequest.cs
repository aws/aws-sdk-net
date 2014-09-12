/*
 * Copyright 2010-2014 Amazon.com, Inc. or its affiliates. All Rights Reserved.
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

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.CloudWatchLogs.Model
{
    /// <summary>
    /// Container for the parameters to the TestMetricFilter operation.
    /// Tests the filter pattern of a metric filter against a sample of log event messages.
    /// You can use this operation to validate the correctness of a metric filter pattern.
    /// </summary>
    public partial class TestMetricFilterRequest : AmazonCloudWatchLogsRequest
    {
        private string _filterPattern;
        private List<string> _logEventMessages = new List<string>();

        /// <summary>
        /// Gets and sets the property FilterPattern.
        /// </summary>
        public string FilterPattern
        {
            get { return this._filterPattern; }
            set { this._filterPattern = value; }
        }

        // Check to see if FilterPattern property is set
        internal bool IsSetFilterPattern()
        {
            return this._filterPattern != null;
        }

        /// <summary>
        /// Gets and sets the property LogEventMessages.
        /// </summary>
        public List<string> LogEventMessages
        {
            get { return this._logEventMessages; }
            set { this._logEventMessages = value; }
        }

        // Check to see if LogEventMessages property is set
        internal bool IsSetLogEventMessages()
        {
            return this._logEventMessages != null && this._logEventMessages.Count > 0; 
        }

    }
}