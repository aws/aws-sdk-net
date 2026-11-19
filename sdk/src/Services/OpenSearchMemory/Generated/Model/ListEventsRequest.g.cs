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

namespace Amazon.OpenSearchMemory.Model
{
    /// <summary>
    /// Container for the parameters to the ListEvents operation. Lists the events in a session,
    /// sorted by time. Optionally limit the results to events whose <c>eventTimestamp</c>
    /// falls between <c>eventTimestampAfter</c> and <c>eventTimestampBefore</c>. Returns
    /// event metadata only. Call <c>GetEvent</c> for the payload. For full-text or relevance
    /// search, use <c>SearchEvents</c>. <para> If the space uses a customer managed AWS KMS
    /// key, the call can also fail because of the key. It fails with <c>AccessDeniedException</c>
    /// if you aren't allowed to use the key, and with <c>ThrottlingException</c> if AWS KMS
    /// throttles the request. It fails with <c>ValidationException</c> if the key is disabled,
    /// pending deletion, or deleted. </para>
    /// </summary>
    public partial class ListEventsRequest : AmazonOpenSearchMemoryRequest
    {
        /// <summary>
        /// Gets and sets the property ActorId. 
        /// <para>
        /// The actor whose events to list.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 255)]
        public string ActorId { get; set; }

        /// <summary>
        /// Checks to see if the ActorId property is set.
        /// </summary>
        internal bool IsSetActorId() => this.ActorId != null;

        /// <summary>
        /// Gets and sets the property EventTimestampAfter. 
        /// <para>
        /// Inclusive lower bound on <c>eventTimestamp</c>: only events at or after this time
        /// are returned. Omit for no lower bound.
        /// </para>
        ///  
        /// <para>
        /// If it's later than <c>eventTimestampBefore</c>, the request fails with <c>ValidationException</c>.
        /// </para>
        /// </summary>
        public DateTime? EventTimestampAfter { get; set; }

        /// <summary>
        /// Checks to see if the EventTimestampAfter property is set.
        /// </summary>
        internal bool IsSetEventTimestampAfter() => this.EventTimestampAfter.HasValue;

        /// <summary>
        /// Gets and sets the property EventTimestampBefore. 
        /// <para>
        /// Inclusive upper bound on <c>eventTimestamp</c>: only events at or before this time
        /// are returned. Omit for no upper bound.
        /// </para>
        /// </summary>
        public DateTime? EventTimestampBefore { get; set; }

        /// <summary>
        /// Checks to see if the EventTimestampBefore property is set.
        /// </summary>
        internal bool IsSetEventTimestampBefore() => this.EventTimestampBefore.HasValue;

        /// <summary>
        /// Gets and sets the property MaxResults. 
        /// <para>
        /// The maximum number of events to return, from 1 to 100. The default is 20.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 100)]
        public int? MaxResults { get; set; }

        /// <summary>
        /// Checks to see if the MaxResults property is set.
        /// </summary>
        internal bool IsSetMaxResults() => this.MaxResults.HasValue;

        /// <summary>
        /// Gets and sets the property MetadataFilters. 
        /// <para>
        /// Returns only events whose metadata contains every one of these key-value pairs. Omit,
        /// or leave empty, for no metadata filter. The service applies the filter after it reads
        /// events, so a page can hold fewer than <c>maxResults</c> events, or none, and still
        /// return a <c>nextToken</c>. Keep paging until <c>nextToken</c> is absent.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min = 0, Max = 15)]
        public Dictionary<string, string> MetadataFilters { get; set; } = AWSConfigs.InitializeCollections ? new Dictionary<string, string>() : null;

        /// <summary>
        /// Checks to see if the MetadataFilters property is set.
        /// </summary>
        internal bool IsSetMetadataFilters() => this.MetadataFilters != null && (this.MetadataFilters.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property NextToken. 
        /// <para>
        /// The token for the next set of results. Use the value returned in the previous response
        /// in the next request to retrieve the next set of results.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 2048)]
        public string NextToken { get; set; }

        /// <summary>
        /// Checks to see if the NextToken property is set.
        /// </summary>
        internal bool IsSetNextToken() => this.NextToken != null;

        /// <summary>
        /// Gets and sets the property SessionId. 
        /// <para>
        /// The session whose events to list. To find events across sessions, use <c>SearchEvents</c>.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 255)]
        public string SessionId { get; set; }

        /// <summary>
        /// Checks to see if the SessionId property is set.
        /// </summary>
        internal bool IsSetSessionId() => this.SessionId != null;

        /// <summary>
        /// Gets and sets the property SortOrder. 
        /// <para>
        /// The order of the results by <c>eventTimestamp</c>: <c>ASC</c> or <c>DESC</c>. The
        /// default is <c>DESC</c>, most recent first.
        /// </para>
        /// </summary>
        public SortOrder SortOrder { get; set; }

        /// <summary>
        /// Checks to see if the SortOrder property is set.
        /// </summary>
        internal bool IsSetSortOrder() => this.SortOrder != null;

        /// <summary>
        /// Gets and sets the property SpaceId. 
        /// <para>
        /// The ID of the space.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 64)]
        public string SpaceId { get; set; }

        /// <summary>
        /// Checks to see if the SpaceId property is set.
        /// </summary>
        internal bool IsSetSpaceId() => this.SpaceId != null;
    }
}
