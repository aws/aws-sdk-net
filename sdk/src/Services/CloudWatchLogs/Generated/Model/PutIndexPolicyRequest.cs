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
    /// Container for the parameters to the PutIndexPolicy operation.
    /// Creates or updates a <i>field index policy</i> for the specified log group. Only log
    /// groups in the Standard log class support field index policies. For more information
    /// about log classes, see <a href="https://docs.aws.amazon.com/AmazonCloudWatch/latest/logs/CloudWatch_Logs_Log_Classes.html">Log
    /// classes</a>.
    /// 
    ///  
    /// <para>
    /// You can use field index policies to create <i>field indexes</i> on fields found in
    /// log events in the log group. Creating field indexes speeds up and lowers the costs
    /// for CloudWatch Logs Insights queries that reference those field indexes, because these
    /// queries attempt to skip the processing of log events that are known to not match the
    /// indexed field. Good fields to index are fields that you often need to query for and
    /// fields or values that match only a small fraction of the total log events. Common
    /// examples of indexes include request ID, session ID, userID, and instance IDs. For
    /// more information, see <a href="https://docs.aws.amazon.com/AmazonCloudWatch/latest/logs/CloudWatchLogs-Field-Indexing.html">Create
    /// field indexes to improve query performance and reduce costs</a>.
    /// </para>
    ///  
    /// <para>
    /// To find the fields that are in your log group events, use the <a href="https://docs.aws.amazon.com/AmazonCloudWatchLogs/latest/APIReference/API_GetLogGroupFields.html">GetLogGroupFields</a>
    /// operation.
    /// </para>
    ///  
    /// <para>
    /// For example, suppose you have created a field index for <c>requestId</c>. Then, any
    /// CloudWatch Logs Insights query on that log group that includes <c>requestId = <i>value</i>
    /// </c> or <c>requestId IN [<i>value</i>, <i>value</i>, ...]</c> will process fewer log
    /// events to reduce costs, and have improved performance.
    /// </para>
    ///  
    /// <para>
    /// CloudWatch Logs provides default field indexes for all log groups in the Standard
    /// log class. Default field indexes are automatically available for the following fields:
    /// 
    /// </para>
    ///  <ul> <li> 
    /// <para>
    ///  <c>@aws.region</c> 
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <c>@aws.account</c> 
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <c>@source.log</c> 
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <c>traceId</c> 
    /// </para>
    ///  </li> </ul> 
    /// <para>
    /// Default field indexes are in addition to any custom field indexes you define within
    /// your policy. Default field indexes are not counted towards your field index quota.
    /// 
    /// </para>
    ///  
    /// <para>
    /// Each index policy has the following quotas and restrictions:
    /// </para>
    ///  <ul> <li> 
    /// <para>
    /// As many as 20 fields can be included in the policy.
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// Each field name can include as many as 100 characters.
    /// </para>
    ///  </li> </ul> 
    /// <para>
    /// Matches of log events to the names of indexed fields are case-sensitive. For example,
    /// a field index of <c>RequestId</c> won't match a log event containing <c>requestId</c>.
    /// </para>
    ///  
    /// <para>
    /// Log group-level field index policies created with <c>PutIndexPolicy</c> override account-level
    /// field index policies created with <a href="https://docs.aws.amazon.com/AmazonCloudWatchLogs/latest/APIReference/API_PutAccountPolicy.html">PutAccountPolicy</a>.
    /// If you use <c>PutIndexPolicy</c> to create a field index policy for a log group, that
    /// log group uses only that policy. The log group ignores any account-wide field index
    /// policy that you might have created.
    /// </para>
    /// </summary>
    public partial class PutIndexPolicyRequest : AmazonCloudWatchLogsRequest
    {
        private string _logGroupIdentifier;
        private string _policyDocument;

        /// <summary>
        /// Gets and sets the property LogGroupIdentifier. 
        /// <para>
        /// Specify either the log group name or log group ARN to apply this field index policy
        /// to. If you specify an ARN, use the format arn:aws:logs:<i>region</i>:<i>account-id</i>:log-group:<i>log_group_name</i>
        /// Don't include an * at the end.
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

        /// <summary>
        /// Gets and sets the property PolicyDocument. 
        /// <para>
        /// The index policy document, in JSON format. The following is an example of an index
        /// policy document that creates two indexes, <c>RequestId</c> and <c>TransactionId</c>.
        /// </para>
        ///  
        /// <para>
        ///  <c>"policyDocument": "{ "Fields": [ "RequestId", "TransactionId" ] }"</c> 
        /// </para>
        ///  
        /// <para>
        /// The policy document must include at least one field index. For more information about
        /// the fields that can be included and other restrictions, see <a href="https://docs.aws.amazon.com/AmazonCloudWatch/latest/logs/CloudWatchLogs-Field-Indexing-Syntax.html">Field
        /// index syntax and quotas</a>.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=5120)]
        public string PolicyDocument
        {
            get { return this._policyDocument; }
            set { this._policyDocument = value; }
        }

        // Check to see if PolicyDocument property is set
        internal bool IsSetPolicyDocument()
        {
            return this._policyDocument != null;
        }

    }
}