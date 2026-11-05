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
    /// Container for the parameters to the DescribeQueries operation. Returns a list of CloudWatch
    /// Logs Insights queries that are scheduled, running, or have been run recently in this
    /// account. You can request all queries or limit it to queries of a specific log group
    /// or queries with a certain status. <para> This operation includes both interactive
    /// queries started directly by users and automated queries executed by scheduled query
    /// configurations. Scheduled query executions appear in the results alongside manually
    /// initiated queries, providing visibility into all query activity in your account. </para>
    /// </summary>
    public partial class DescribeQueriesRequest : AmazonCloudWatchLogsRequest
    {
        /// <summary>
        /// Gets and sets the property LogGroupName. 
        /// <para>
        /// Limits the returned queries to only those for the specified log group.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 512)]
        public string LogGroupName { get; set; }

        /// <summary>
        /// Checks to see if the LogGroupName property is set.
        /// </summary>
        internal bool IsSetLogGroupName() => this.LogGroupName != null;

        /// <summary>
        /// Gets and sets the property MaxResults. 
        /// <para>
        /// Limits the number of returned queries to the specified number.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 1000)]
        public int? MaxResults { get; set; }

        /// <summary>
        /// Checks to see if the MaxResults property is set.
        /// </summary>
        internal bool IsSetMaxResults() => this.MaxResults.HasValue;

        /// <summary>
        /// Gets and sets the property NextToken.
        /// </summary>
        [AWSProperty(Min = 1)]
        public string NextToken { get; set; }

        /// <summary>
        /// Checks to see if the NextToken property is set.
        /// </summary>
        internal bool IsSetNextToken() => this.NextToken != null;

        /// <summary>
        /// Gets and sets the property QueryLanguage. 
        /// <para>
        /// Limits the returned queries to only the queries that use the specified query language.
        /// </para>
        /// </summary>
        public QueryLanguage QueryLanguage { get; set; }

        /// <summary>
        /// Checks to see if the QueryLanguage property is set.
        /// </summary>
        internal bool IsSetQueryLanguage() => this.QueryLanguage != null;

        /// <summary>
        /// Gets and sets the property Status. 
        /// <para>
        /// Limits the returned queries to only those that have the specified status. Valid values
        /// are <c>Cancelled</c>, <c>Complete</c>, <c>Failed</c>, <c>Running</c>, and <c>Scheduled</c>.
        /// </para>
        /// </summary>
        public QueryStatus Status { get; set; }

        /// <summary>
        /// Checks to see if the Status property is set.
        /// </summary>
        internal bool IsSetStatus() => this.Status != null;
    }
}
