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
    /// Container for the parameters to the GetQueryResults operation.
    /// Returns the results from the specified query.
    /// 
    ///  
    /// <para>
    /// Only the fields requested in the query are returned, along with a <c>@ptr</c> field,
    /// which is the identifier for the log record. You can use the value of <c>@ptr</c> in
    /// a <a href="https://docs.aws.amazon.com/AmazonCloudWatchLogs/latest/APIReference/API_GetLogRecord.html">GetLogRecord</a>
    /// operation to get the full log record.
    /// </para>
    ///  
    /// <para>
    ///  <c>GetQueryResults</c> does not start running a query. To run a query, use <a href="https://docs.aws.amazon.com/AmazonCloudWatchLogs/latest/APIReference/API_StartQuery.html">StartQuery</a>.
    /// For more information about how long results of previous queries are available, see
    /// <a href="https://docs.aws.amazon.com/AmazonCloudWatch/latest/logs/cloudwatch_limits_cwl.html">CloudWatch
    /// Logs quotas</a>.
    /// </para>
    ///  
    /// <para>
    /// If the value of the <c>Status</c> field in the output is <c>Running</c>, this operation
    /// returns only partial results. If you see a value of <c>Scheduled</c> or <c>Running</c>
    /// for the status, you can retry the operation later to see the final results. 
    /// </para>
    ///  
    /// <para>
    /// If you are using CloudWatch cross-account observability, you can use this operation
    /// in a monitoring account to start queries in linked source accounts. For more information,
    /// see <a href="https://docs.aws.amazon.com/AmazonCloudWatch/latest/monitoring/CloudWatch-Unified-Cross-Account.html">CloudWatch
    /// cross-account observability</a>.
    /// </para>
    /// </summary>
    public partial class GetQueryResultsRequest : AmazonCloudWatchLogsRequest
    {
        private string _queryId;

        /// <summary>
        /// Gets and sets the property QueryId. 
        /// <para>
        /// The ID number of the query.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=256)]
        public string QueryId
        {
            get { return this._queryId; }
            set { this._queryId = value; }
        }

        // Check to see if QueryId property is set
        internal bool IsSetQueryId()
        {
            return this._queryId != null;
        }

    }
}