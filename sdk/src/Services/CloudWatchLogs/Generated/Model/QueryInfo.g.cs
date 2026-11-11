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
    /// Information about one CloudWatch Logs Insights query that matches the request in a
    /// <c>DescribeQueries</c> operation.
    /// </summary>
    public partial class QueryInfo
    {
        /// <summary>
        /// Gets and sets the property BytesScanned. 
        /// <para>
        /// The total number of bytes scanned by the query. This indicates the cost associated
        /// with the query.
        /// </para>
        /// </summary>
        public double? BytesScanned { get; set; }

        /// <summary>
        /// Checks to see if the BytesScanned property is set.
        /// </summary>
        internal bool IsSetBytesScanned() => this.BytesScanned.HasValue;

        /// <summary>
        /// Gets and sets the property CreateTime. 
        /// <para>
        /// The date and time that this query was created.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0)]
        public long? CreateTime { get; set; }

        /// <summary>
        /// Checks to see if the CreateTime property is set.
        /// </summary>
        internal bool IsSetCreateTime() => this.CreateTime.HasValue;

        /// <summary>
        /// Gets and sets the property LogGroupName. 
        /// <para>
        /// The name of the log group scanned by this query.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 512)]
        public string LogGroupName { get; set; }

        /// <summary>
        /// Checks to see if the LogGroupName property is set.
        /// </summary>
        internal bool IsSetLogGroupName() => this.LogGroupName != null;

        /// <summary>
        /// Gets and sets the property QueryDuration. 
        /// <para>
        /// The duration in milliseconds that the query took to execute.
        /// </para>
        /// </summary>
        public long? QueryDuration { get; set; }

        /// <summary>
        /// Checks to see if the QueryDuration property is set.
        /// </summary>
        internal bool IsSetQueryDuration() => this.QueryDuration.HasValue;

        /// <summary>
        /// Gets and sets the property QueryId. 
        /// <para>
        /// The unique ID number of this query.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 256)]
        public string QueryId { get; set; }

        /// <summary>
        /// Checks to see if the QueryId property is set.
        /// </summary>
        internal bool IsSetQueryId() => this.QueryId != null;

        /// <summary>
        /// Gets and sets the property QueryLanguage. 
        /// <para>
        /// The query language used for this query. For more information about the query languages
        /// that CloudWatch Logs supports, see <a href="https://docs.aws.amazon.com/AmazonCloudWatch/latest/logs/CWL_AnalyzeLogData_Languages.html">Supported
        /// query languages</a>.
        /// </para>
        /// </summary>
        public QueryLanguage QueryLanguage { get; set; }

        /// <summary>
        /// Checks to see if the QueryLanguage property is set.
        /// </summary>
        internal bool IsSetQueryLanguage() => this.QueryLanguage != null;

        /// <summary>
        /// Gets and sets the property QueryString. 
        /// <para>
        /// The query string used in this query.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 10000)]
        public string QueryString { get; set; }

        /// <summary>
        /// Checks to see if the QueryString property is set.
        /// </summary>
        internal bool IsSetQueryString() => this.QueryString != null;

        /// <summary>
        /// Gets and sets the property Status. 
        /// <para>
        /// The status of this query. Possible values are <c>Cancelled</c>, <c>Complete</c>, <c>Failed</c>,
        /// <c>Running</c>, <c>Scheduled</c>, and <c>Unknown</c>.
        /// </para>
        /// </summary>
        public QueryStatus Status { get; set; }

        /// <summary>
        /// Checks to see if the Status property is set.
        /// </summary>
        internal bool IsSetStatus() => this.Status != null;

        /// <summary>
        /// Gets and sets the property UserIdentity. 
        /// <para>
        /// The ARN of the user who ran the query.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 2048)]
        public string UserIdentity { get; set; }

        /// <summary>
        /// Checks to see if the UserIdentity property is set.
        /// </summary>
        internal bool IsSetUserIdentity() => this.UserIdentity != null;
    }
}
