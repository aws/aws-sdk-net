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

#pragma warning disable CS0612,CS0618,CS1570
namespace Amazon.CloudWatchLogs.Model
{
    /// <summary>
    /// Container for the parameters to the GetLogObject operation.
    /// Retrieves a large logging object (LLO) and streams it back. This API is used to fetch
    /// the content of large portions of log events that have been ingested through the PutOpenTelemetryLogs
    /// API. When log events contain fields that would cause the total event size to exceed
    /// 1MB, CloudWatch Logs automatically processes up to 10 fields, starting with the largest
    /// fields. Each field is truncated as needed to keep the total event size as close to
    /// 1MB as possible. The excess portions are stored as Large Log Objects (LLOs) and these
    /// fields are processed separately and LLO reference system fields (in the format <c>@ptr.$[path.to.field]</c>)
    /// are added. The path in the reference field reflects the original JSON structure where
    /// the large field was located. For example, this could be <c>@ptr.$['input']['message']</c>,
    /// <c>@ptr.$['AAA']['BBB']['CCC']['DDD']</c>, <c>@ptr.$['AAA']</c>, or any other path
    /// matching your log structure.
    /// </summary>
    public partial class GetLogObjectRequest : AmazonCloudWatchLogsRequest
    {
        private string _logObjectPointer;
        private bool? _unmask;

        /// <summary>
        /// Gets and sets the property LogObjectPointer. 
        /// <para>
        /// A pointer to the specific log object to retrieve. This is a required parameter that
        /// uniquely identifies the log object within CloudWatch Logs. The pointer is typically
        /// obtained from a previous query or filter operation.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=512)]
        public string LogObjectPointer
        {
            get { return this._logObjectPointer; }
            set { this._logObjectPointer = value; }
        }

        // Check to see if LogObjectPointer property is set
        internal bool IsSetLogObjectPointer()
        {
            return this._logObjectPointer != null;
        }

        /// <summary>
        /// Gets and sets the property Unmask. 
        /// <para>
        /// A boolean flag that indicates whether to unmask sensitive log data. When set to true,
        /// any masked or redacted data in the log object will be displayed in its original form.
        /// Default is false.
        /// </para>
        /// </summary>
        public bool? Unmask
        {
            get { return this._unmask; }
            set { this._unmask = value; }
        }

        // Check to see if Unmask property is set
        internal bool IsSetUnmask()
        {
            return this._unmask.HasValue; 
        }

    }
}