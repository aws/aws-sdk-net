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
    /// Container for the parameters to the PutRetentionPolicy operation.
    /// Sets the retention of the specified log group. A retention policy allows you to configure
    /// the number of days you want to retain log events in the specified log group.
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
        /// <param name="logGroupName">The name of the log group to associate the retention policy with.</param>
        /// <param name="retentionInDays">Sets the PutRetentionPolicyRequest RetentionInDays property</param>
        public PutRetentionPolicyRequest(string logGroupName, int retentionInDays)
        {
            _logGroupName = logGroupName;
            _retentionInDays = retentionInDays;
        }

        /// <summary>
        /// Gets and sets the property LogGroupName. 
        /// <para>
        /// The name of the log group to associate the retention policy with.
        /// </para>
        /// </summary>
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