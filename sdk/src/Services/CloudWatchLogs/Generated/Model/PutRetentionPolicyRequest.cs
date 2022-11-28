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
    /// Container for the parameters to the PutRetentionPolicy operation.
    /// Sets the retention of the specified log group. With a retention policy, you can configure
    /// the number of days for which to retain log events in the specified log group.
    /// 
    ///  <note> 
    /// <para>
    /// CloudWatch Logs doesn’t immediately delete log events when they reach their retention
    /// setting. It typically takes up to 72 hours after that before log events are deleted,
    /// but in rare situations might take longer.
    /// </para>
    ///  
    /// <para>
    /// To illustrate, imagine that you change a log group to have a longer retention setting
    /// when it contains log events that are past the expiration date, but haven’t been deleted.
    /// Those log events will take up to 72 hours to be deleted after the new retention date
    /// is reached. To make sure that log data is deleted permanently, keep a log group at
    /// its lower retention setting until 72 hours after the previous retention period ends.
    /// Alternatively, wait to change the retention setting until you confirm that the earlier
    /// log events are deleted. 
    /// </para>
    ///  </note>
    /// </summary>
    public partial class PutRetentionPolicyRequest : AmazonCloudWatchLogsRequest
    {
        private string _logGroupName;
        private int? _retentionInDays;

        /// <summary>
        /// Empty constructor used to set  properties independently even when a simple constructor is available
        /// </summary>
        public PutRetentionPolicyRequest() { }

        /// <summary>
        /// Instantiates PutRetentionPolicyRequest with the parameterized properties
        /// </summary>
        /// <param name="logGroupName">The name of the log group.</param>
        /// <param name="retentionInDays">Sets the PutRetentionPolicyRequest RetentionInDays property</param>
        public PutRetentionPolicyRequest(string logGroupName, int retentionInDays)
        {
            _logGroupName = logGroupName;
            _retentionInDays = retentionInDays;
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
        /// Gets and sets the property RetentionInDays.
        /// </summary>
        [AWSProperty(Required=true)]
        public int RetentionInDays
        {
            get { return this._retentionInDays.GetValueOrDefault(); }
            set { this._retentionInDays = value; }
        }

        // Check to see if RetentionInDays property is set
        internal bool IsSetRetentionInDays()
        {
            return this._retentionInDays.HasValue; 
        }

    }
}