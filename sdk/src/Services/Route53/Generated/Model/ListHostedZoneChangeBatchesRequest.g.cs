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

namespace Amazon.Route53.Model
{
    /// <summary>
    /// Container for the parameters to the ListHostedZoneChangeBatches operation. Lists the
    /// change batches in an Amazon Route 53 hosted zone. For each change batch, the response
    /// contains its change ID, the operation that submitted it, and when and by whom it was
    /// submitted. It also contains the request ID, the comment if there is one, and the number
    /// of changes. Use this list to review who changed the hosted zone and when. <para> Each
    /// change batch records one <c>ChangeResourceRecordSets</c> or <c>CreateHostedZone</c>
    /// request. A <c>CreateHostedZone</c> change batch has a <c>ChangeCount</c> of 0. </para>
    /// <para> You can read a change batch for 365 days after it was submitted, but not from
    /// before the <c>RetentionStartsAt</c> time that <c>GetHostedZone</c> returns in <c>Features/ChangeHistory</c>.
    /// If Change History isn't turned on for the hosted zone, Route 53 returns a <c>FeatureNotEnabled</c>
    /// error. </para> <para> Results are paginated. To get the next page, use the <c>NextToken</c>
    /// value from the response. To get the changes in a change batch, use <c>GetHostedZoneChangeBatch</c>.
    /// </para>
    /// </summary>
    public partial class ListHostedZoneChangeBatchesRequest : AmazonRoute53Request
    {
        /// <summary>
        /// Gets and sets the property HostedZoneId. 
        /// <para>
        /// The ID of the hosted zone that you want to list change batches for.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 0, Max = 32)]
        public string HostedZoneId { get; set; }

        /// <summary>
        /// Checks to see if the HostedZoneId property is set.
        /// </summary>
        internal bool IsSetHostedZoneId() => this.HostedZoneId != null;

        /// <summary>
        /// Gets and sets the property SubmittedAfter. 
        /// <para>
        /// The start of the time range, in ISO 8601 format with a UTC offset, for example <c>2026-12-01T00:00:00Z</c>
        /// or <c>2026-12-01T05:30:00.123+05:30</c>. You can specify up to nine fractional digits.
        /// Route 53 rounds a value with more than millisecond precision up to the next millisecond.
        /// The range includes <c>SubmittedAfter</c>.
        /// </para>
        ///  
        /// <para>
        /// If you don't specify a value, the range starts at <c>RetentionStartsAt</c>. If you
        /// specify a value that's earlier than <c>RetentionStartsAt</c>, Route 53 returns an
        /// <c>InvalidInput</c> error that includes the earliest time that you can specify.
        /// </para>
        ///  
        /// <para>
        /// Because submit times can be slightly out of order, a returned <c>SubmittedAt</c> can
        /// fall just outside the range that you requested.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 35)]
        public string SubmittedAfter { get; set; }

        /// <summary>
        /// Checks to see if the SubmittedAfter property is set.
        /// </summary>
        internal bool IsSetSubmittedAfter() => this.SubmittedAfter != null;

        /// <summary>
        /// Gets and sets the property SubmittedBefore. 
        /// <para>
        /// The end of the time range, in ISO 8601 format with a UTC offset, for example <c>2026-12-02T00:00:00Z</c>
        /// or <c>2026-12-02T05:30:00.123+05:30</c>. You can specify up to nine fractional digits.
        /// Route 53 rounds a value with more than millisecond precision up to the next millisecond.
        /// The range excludes <c>SubmittedBefore</c>. The value must be at least one millisecond
        /// later than <c>SubmittedAfter</c>, or later than <c>RetentionStartsAt</c> if you omit
        /// <c>SubmittedAfter</c>.
        /// </para>
        ///  
        /// <para>
        /// If the range ends within a few seconds of the current time, a later request for the
        /// same range might return more change batches.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 35)]
        public string SubmittedBefore { get; set; }

        /// <summary>
        /// Checks to see if the SubmittedBefore property is set.
        /// </summary>
        internal bool IsSetSubmittedBefore() => this.SubmittedBefore != null;

        /// <summary>
        /// Gets and sets the property StartAfterChangeId. 
        /// <para>
        /// Returns the change batches after the specified change batch, not including it. Use
        /// this to read new change batches since the last change batch that you processed.
        /// </para>
        ///  
        /// <para>
        /// If you specify <c>StartAfterChangeId</c>, you must also specify <c>SortOrder</c> <c>ASCENDING</c>,
        /// and you can't specify <c>SubmittedAfter</c> or <c>SubmittedBefore</c>. If the change
        /// batch has expired, is from before <c>RetentionStartsAt</c>, or isn't in the hosted
        /// zone, Route 53 returns an <c>InvalidInput</c> error.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 32)]
        public string StartAfterChangeId { get; set; }

        /// <summary>
        /// Checks to see if the StartAfterChangeId property is set.
        /// </summary>
        internal bool IsSetStartAfterChangeId() => this.StartAfterChangeId != null;

        /// <summary>
        /// Gets and sets the property SortOrder. 
        /// <para>
        /// The order in which you want Route 53 to return change batches. Valid values:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <c>DESCENDING</c> – Newest first. This is the default.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>ASCENDING</c> – Oldest first.
        /// </para>
        ///  </li> </ul>
        /// </summary>
        public ChangeHistorySortOrder SortOrder { get; set; }

        /// <summary>
        /// Checks to see if the SortOrder property is set.
        /// </summary>
        internal bool IsSetSortOrder() => this.SortOrder != null;

        /// <summary>
        /// Gets and sets the property MaxResults. 
        /// <para>
        /// The maximum number of change batches that you want Route 53 to return in this response.
        /// Specify a value from 1 to 1,000. If you don't specify a value, Route 53 returns up
        /// to 100 change batches.
        /// </para>
        /// </summary>
        public int? MaxResults { get; set; }

        /// <summary>
        /// Checks to see if the MaxResults property is set.
        /// </summary>
        internal bool IsSetMaxResults() => this.MaxResults.HasValue;

        /// <summary>
        /// Gets and sets the property NextToken. 
        /// <para>
        /// If the response to a previous <c>ListHostedZoneChangeBatches</c> request included
        /// a <c>NextToken</c> element, specify that value here to get the next page of results.
        /// If the previous request included any of the following parameters, include them with
        /// exactly the same values: <c>SubmittedAfter</c>, <c>SubmittedBefore</c>, <c>SortOrder</c>,
        /// and <c>StartAfterChangeId</c>. If you don't, Route 53 returns an <c>InvalidInput</c>
        /// error. If you don't specify <c>NextToken</c>, Route 53 returns the first page of results.
        /// </para>
        ///  
        /// <para>
        /// A <c>NextToken</c> expires 24 hours after Route 53 returns it, and you can use it
        /// only with the hosted zone that it was returned for.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 1024)]
        public string NextToken { get; set; }

        /// <summary>
        /// Checks to see if the NextToken property is set.
        /// </summary>
        internal bool IsSetNextToken() => this.NextToken != null;
    }
}
