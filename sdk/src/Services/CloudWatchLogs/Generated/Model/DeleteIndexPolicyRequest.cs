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
    /// Container for the parameters to the DeleteIndexPolicy operation.
    /// Deletes a log-group level field index policy that was applied to a single log group.
    /// The indexing of the log events that happened before you delete the policy will still
    /// be used for as many as 30 days to improve CloudWatch Logs Insights queries.
    /// 
    ///  
    /// <para>
    /// You can't use this operation to delete an account-level index policy. Instead, use
    /// <a href="https://docs.aws.amazon.com/AmazonCloudWatchLogs/latest/APIReference/API_DeleteAccountPolicy.html">DeletAccountPolicy</a>.
    /// </para>
    ///  
    /// <para>
    /// If you delete a log-group level field index policy and there is an account-level field
    /// index policy, in a few minutes the log group begins using that account-wide policy
    /// to index new incoming log events. 
    /// </para>
    /// </summary>
    public partial class DeleteIndexPolicyRequest : AmazonCloudWatchLogsRequest
    {
        private string _logGroupIdentifier;

        /// <summary>
        /// Gets and sets the property LogGroupIdentifier. 
        /// <para>
        /// The log group to delete the index policy for. You can specify either the name or the
        /// ARN of the log group.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=2048)]
        public string LogGroupIdentifier
        {
            get { return this._logGroupIdentifier; }
            set { this._logGroupIdentifier = value; }
        }

        // Check to see if LogGroupIdentifier property is set
        internal bool IsSetLogGroupIdentifier()
        {
            return this._logGroupIdentifier != null;
        }

    }
}