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
    /// Container for the parameters to the SearchEvents operation. Searches a space's events
    /// by relevance. It works like <c>SearchMemories</c> without the memory type and strategy
    /// selector. The query is a subset of the OpenSearch Query DSL. The service validates
    /// it, limits the search to the actor in <c>actorId</c> and the sessions in <c>sessionIds</c>,
    /// and returns ranked results. Each result is the matching chunk of an event, not the
    /// whole event. You can page through only a limited number of results. A request past
    /// that limit fails with <c>ValidationException</c> (reason <c>invalidNextToken</c>),
    /// and the message gives the limit. <para> If the results are larger than 5 MiB, the
    /// request fails with <c>ValidationException</c> (reason <c>queryBodyTooLarge</c>). Lower
    /// <c>maxResults</c>. </para> <para> If the request would exceed the service's rate for
    /// embedding requests, it fails with <c>ThrottlingException</c>. Retry with exponential
    /// backoff. </para> <para> If the space uses a customer managed AWS KMS key, the call
    /// can also fail because of the key. It fails with <c>AccessDeniedException</c> if you
    /// aren't allowed to use the key, and with <c>ThrottlingException</c> if AWS KMS throttles
    /// the request. It fails with <c>ValidationException</c> if the key is disabled, pending
    /// deletion, or deleted. </para>
    /// </summary>
    public partial class SearchEventsRequest : AmazonOpenSearchMemoryRequest
    {
        /// <summary>
        /// Gets and sets the property ActorId. 
        /// <para>
        /// The actor whose events to search (exact match). Required: every search covers exactly
        /// one actor, and an event stored without an actor is never returned. Narrow the search
        /// further with <c>sessionIds</c>, combined by AND. This is the only way to filter by
        /// actor: a query that references <c>system_metadata.actor_id</c> fails with <c>ValidationException</c>
        /// (reason <c>nonFilterableField</c>).
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 255)]
        public string ActorId { get; set; }

        /// <summary>
        /// Checks to see if the ActorId property is set.
        /// </summary>
        internal bool IsSetActorId() => this.ActorId != null;

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
        /// Gets and sets the property Query. 
        /// <para>
        /// The query: a subset of the OpenSearch Query DSL (see <c>SearchQuery</c>), validated
        /// by the same rules as on <c>SearchMemories</c>. Query event text as <c>text</c> and
        /// embeddings as <c>vector</c>. A search covers both conversation turns and chunks of
        /// documents submitted as a <c>blob</c>. You can't use actor and session fields here.
        /// Use the top-level <c>actorId</c> and <c>sessionIds</c>.
        /// </para>
        ///  
        /// <para>
        /// To search only the content of particular events, filter on <c>event_ids</c> with <c>term</c>
        /// or <c>terms</c>, for example with the <c>sourceEventIds</c> that a <c>SearchMemories</c>
        /// result returns. A <c>terms</c> clause on <c>event_ids</c> can list up to 10 event
        /// IDs. More IDs fail with <c>ValidationException</c> (reason <c>queryBodyTooLarge</c>).
        /// You can use <c>event_ids</c> only in <c>term</c>, <c>terms</c>, and <c>exists</c>
        /// queries.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Sensitive = true)]
        public Amazon.Runtime.Documents.Document Query { get; set; }

        /// <summary>
        /// Checks to see if the Query property is set.
        /// </summary>
        internal bool IsSetQuery() => !this.Query.IsNull();

        /// <summary>
        /// Gets and sets the property SessionIds. 
        /// <para>
        /// Returns only events from one of these sessions (exact match). Combined with <c>actorId</c>
        /// by AND. Omit for no session filter. An empty list fails validation. An event stored
        /// without a session never matches a session filter. This is the only way to filter by
        /// session: a query that references <c>system_metadata.session_id</c> fails with <c>ValidationException</c>
        /// (reason <c>nonFilterableField</c>).
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min = 1, Max = 10)]
        public List<string> SessionIds { get; set; } = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Checks to see if the SessionIds property is set.
        /// </summary>
        internal bool IsSetSessionIds() => this.SessionIds != null && (this.SessionIds.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property Sort. 
        /// <para>
        /// The sort order (see <c>SearchSort</c>). Omit to return the most relevant events first.
        /// </para>
        /// </summary>
        [AWSProperty(Sensitive = true)]
        public Amazon.Runtime.Documents.Document Sort { get; set; }

        /// <summary>
        /// Checks to see if the Sort property is set.
        /// </summary>
        internal bool IsSetSort() => !this.Sort.IsNull();

        /// <summary>
        /// Gets and sets the property SpaceId. 
        /// <para>
        /// The space whose events to search. Use <c>actorId</c> and <c>sessionIds</c> to narrow
        /// the search within it.
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
