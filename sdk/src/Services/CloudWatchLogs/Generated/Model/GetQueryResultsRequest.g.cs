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
 * Do not modify this file. This file is generated from the smithy.json service model.
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
    /// Container for the parameters to the GetQueryResults operation. Returns the results
    /// from the specified query. <para> Only the fields requested in the query are returned,
    /// along with a <c>@ptr</c> field, which is the identifier for the log record. You can
    /// use the value of <c>@ptr</c> in a <a href="https://docs.aws.amazon.com/AmazonCloudWatchLogs/latest/APIReference/API_GetLogRecord.html">GetLogRecord</a>
    /// operation to get the full log record. </para> <para> <c>GetQueryResults</c> does not
    /// start running a query. To run a query, use <a href="https://docs.aws.amazon.com/AmazonCloudWatchLogs/latest/APIReference/API_StartQuery.html">StartQuery</a>.
    /// For more information about how long results of previous queries are available, see
    /// <a href="https://docs.aws.amazon.com/AmazonCloudWatch/latest/logs/cloudwatch_limits_cwl.html">CloudWatch
    /// Logs quotas</a>. </para> <para> If the value of the <c>Status</c> field in the output
    /// is <c>Running</c>, this operation returns only partial results. If you see a value
    /// of <c>Scheduled</c> or <c>Running</c> for the status, you can retry the operation
    /// later to see the final results. </para> <para> This operation is used both for retrieving
    /// results from interactive queries and from automated scheduled query executions. Scheduled
    /// queries use <c>GetQueryResults</c> internally to retrieve query results for processing
    /// and delivery to configured destinations. </para> <para> You can retrieve up to 100,000
    /// log event results from a query, if available, by using pagination. Use the <c>nextToken</c>
    /// returned in the response to request additional pages of results, with each page returning
    /// up to 10,000 log events. This is only supported for Logs Insights QL and is currently
    /// not supported for PPL and SQL query languages. </para> <para> If you are using CloudWatch
    /// cross-account observability, you can use this operation in a monitoring account to
    /// start queries in linked source accounts. For more information, see <a href="https://docs.aws.amazon.com/AmazonCloudWatch/latest/monitoring/CloudWatch-Unified-Cross-Account.html">CloudWatch
    /// cross-account observability</a>. </para>
    /// </summary>
    public partial class GetQueryResultsRequest : AmazonCloudWatchLogsRequest
    {
        /// <summary>
        /// Gets and sets the property MaxItems. 
        /// <para>
        /// The maximum number of log events to return in the response. The maximum is 10,000
        /// log events per request. You can retrieve up to 100,000 log event results from a query
        /// by paginating with the <c>nextToken</c>.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 10000)]
        public int? MaxItems { get; set; }

        /// <summary>
        /// Checks to see if the MaxItems property is set.
        /// </summary>
        internal bool IsSetMaxItems() => this.MaxItems.HasValue;

        /// <summary>
        /// Gets and sets the property NextToken. 
        /// <para>
        /// The token for the next set of items to return. The token expires after 1 hour.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 1024)]
        public string NextToken { get; set; }

        /// <summary>
        /// Checks to see if the NextToken property is set.
        /// </summary>
        internal bool IsSetNextToken() => this.NextToken != null;

        /// <summary>
        /// Gets and sets the property QueryId. 
        /// <para>
        /// The ID number of the query.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 256)]
        public string QueryId { get; set; }

        /// <summary>
        /// Checks to see if the QueryId property is set.
        /// </summary>
        internal bool IsSetQueryId() => this.QueryId != null;
    }
}
