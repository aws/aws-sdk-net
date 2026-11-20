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
    /// Container for the parameters to the ListResourceRecordSetChanges operation. Lists
    /// the individual changes in the change history of a hosted zone. Each entry is one change,
    /// with the full resource record set that the change wrote or deleted. To list only the
    /// changes to the resource record sets that have a specific name and type, specify <c>RecordName</c>
    /// and <c>RecordType</c>. Weighted, latency, and other resource record sets that have
    /// the same name and type appear as separate entries, each with its <c>SetIdentifier</c>.
    /// <para> A change can take a few seconds to appear in <c>ListResourceRecordSetChanges</c>
    /// after it appears in <c>ListHostedZoneChangeBatches</c>. For a complete, ordered list
    /// of changes, use <c>ListHostedZoneChangeBatches</c>. </para> <para> Results are paginated.
    /// To get the next page, use the <c>NextToken</c> value from the response. </para> <para>
    /// If Change History isn't turned on for the hosted zone, Route 53 returns a <c>FeatureNotEnabled</c>
    /// error. </para>
    /// </summary>
    public partial class ListResourceRecordSetChangesRequest : AmazonRoute53Request
    {
        /// <summary>
        /// Gets and sets the property HostedZoneId. 
        /// <para>
        /// The ID of the hosted zone that you want to list changes for.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 0, Max = 32)]
        public string HostedZoneId { get; set; }

        /// <summary>
        /// Checks to see if the HostedZoneId property is set.
        /// </summary>
        internal bool IsSetHostedZoneId() => this.HostedZoneId != null;

        /// <summary>
        /// Gets and sets the property RecordName. 
        /// <para>
        /// The name of the resource record sets that you want to list changes for, for example,
        /// <c>www.example.com</c>. The name must be the name of the hosted zone or a subdomain
        /// of it. If you specify <c>RecordName</c>, you must also specify <c>RecordType</c>.
        /// If you specify neither, the results include every change in the hosted zone.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 1024)]
        public string RecordName { get; set; }

        /// <summary>
        /// Checks to see if the RecordName property is set.
        /// </summary>
        internal bool IsSetRecordName() => this.RecordName != null;

        /// <summary>
        /// Gets and sets the property RecordType. 
        /// <para>
        /// The DNS record type of the resource record sets that you want to list changes for.
        /// If you specify <c>RecordType</c>, you must also specify <c>RecordName</c>.
        /// </para>
        /// </summary>
        public RRType RecordType { get; set; }

        /// <summary>
        /// Checks to see if the RecordType property is set.
        /// </summary>
        internal bool IsSetRecordType() => this.RecordType != null;

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
        /// same range might return more changes.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 35)]
        public string SubmittedBefore { get; set; }

        /// <summary>
        /// Checks to see if the SubmittedBefore property is set.
        /// </summary>
        internal bool IsSetSubmittedBefore() => this.SubmittedBefore != null;

        /// <summary>
        /// Gets and sets the property SortOrder. 
        /// <para>
        /// The order in which you want Route 53 to return changes. Valid values:
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
        /// The maximum number of changes that you want Route 53 to return in this response. Specify
        /// a value from 1 to 100. If you don't specify a value, Route 53 returns up to 100 changes.
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
        /// If the response to a previous <c>ListResourceRecordSetChanges</c> request included
        /// a <c>NextToken</c> element, specify that value here to get the next page of results.
        /// If the previous request included any of the following parameters, include them with
        /// exactly the same values: <c>SubmittedAfter</c>, <c>SubmittedBefore</c>, <c>SortOrder</c>,
        /// <c>RecordName</c>, and <c>RecordType</c>. If you don't, Route 53 returns an <c>InvalidInput</c>
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
