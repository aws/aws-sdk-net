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

namespace Amazon.CloudTrail.Model
{
    /// <summary>
    /// Container for the parameters to the ListQueries operation. <important> <para> CloudTrail
    /// Lake will no longer be open to new customers starting May 31, 2026. If you would like
    /// to use CloudTrail Lake, sign up prior to that date. Existing customers can continue
    /// to use the service as normal. For more information, see <a href="https://docs.aws.amazon.com/awscloudtrail/latest/userguide/cloudtrail-lake-service-availability-change.html">CloudTrail
    /// Lake availability change</a>. </para> </important> <para> Returns a list of queries
    /// and query statuses for the past seven days. You must specify an ARN value for <c>EventDataStore</c>.
    /// Optionally, to shorten the list of results, you can specify a time range, formatted
    /// as timestamps, by adding <c>StartTime</c> and <c>EndTime</c> parameters, and a <c>QueryStatus</c>
    /// value. Valid values for <c>QueryStatus</c> include <c>QUEUED</c>, <c>RUNNING</c>,
    /// <c>FINISHED</c>, <c>FAILED</c>, <c>TIMED_OUT</c>, or <c>CANCELLED</c>. </para>
    /// </summary>
    public partial class ListQueriesRequest : AmazonCloudTrailRequest
    {
        /// <summary>
        /// Gets and sets the property EndTime. 
        /// <para>
        /// Use with <c>StartTime</c> to bound a <c>ListQueries</c> request, and limit its results
        /// to only those queries run within a specified time period.
        /// </para>
        /// </summary>
        public DateTime? EndTime { get; set; }

        /// <summary>
        /// Checks to see if the EndTime property is set.
        /// </summary>
        internal bool IsSetEndTime() => this.EndTime.HasValue;

        /// <summary>
        /// Gets and sets the property EventDataStore. 
        /// <para>
        /// The ARN (or the ID suffix of the ARN) of an event data store on which queries were
        /// run.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 3, Max = 256)]
        public string EventDataStore { get; set; }

        /// <summary>
        /// Checks to see if the EventDataStore property is set.
        /// </summary>
        internal bool IsSetEventDataStore() => this.EventDataStore != null;

        /// <summary>
        /// Gets and sets the property MaxResults. 
        /// <para>
        /// The maximum number of queries to show on a page.
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
        /// <para>
        /// A token you can use to get the next page of results.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 4, Max = 1000)]
        public string NextToken { get; set; }

        /// <summary>
        /// Checks to see if the NextToken property is set.
        /// </summary>
        internal bool IsSetNextToken() => this.NextToken != null;

        /// <summary>
        /// Gets and sets the property QueryStatus. 
        /// <para>
        /// The status of queries that you want to return in results. Valid values for <c>QueryStatus</c>
        /// include <c>QUEUED</c>, <c>RUNNING</c>, <c>FINISHED</c>, <c>FAILED</c>, <c>TIMED_OUT</c>,
        /// or <c>CANCELLED</c>.
        /// </para>
        /// </summary>
        public QueryStatus QueryStatus { get; set; }

        /// <summary>
        /// Checks to see if the QueryStatus property is set.
        /// </summary>
        internal bool IsSetQueryStatus() => this.QueryStatus != null;

        /// <summary>
        /// Gets and sets the property StartTime. 
        /// <para>
        /// Use with <c>EndTime</c> to bound a <c>ListQueries</c> request, and limit its results
        /// to only those queries run within a specified time period.
        /// </para>
        /// </summary>
        public DateTime? StartTime { get; set; }

        /// <summary>
        /// Checks to see if the StartTime property is set.
        /// </summary>
        internal bool IsSetStartTime() => this.StartTime.HasValue;
    }
}
