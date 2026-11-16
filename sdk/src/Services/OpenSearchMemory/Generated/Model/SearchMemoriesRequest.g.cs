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
    /// Container for the parameters to the SearchMemories operation. Searches a space's memories
    /// by relevance. The query is a subset of the OpenSearch Query DSL. The service validates
    /// it, limits the search to the requested strategies and to the actor in <c>actorId</c>,
    /// and returns one ranked list of memories. You can page through only a limited number
    /// of results. A request past that limit fails with <c>ValidationException</c> (reason
    /// <c>invalidNextToken</c>), and the message gives the limit. <para> Memories past their
    /// expiry (set from the space's <c>memoryExpiryDays</c> when each memory is written)
    /// are left out of the results. Only current memories are returned: a memory that consolidation
    /// has superseded (an older version of a fact that a newer memory replaced) is left out.
    /// </para> <para> If the results are larger than 5 MiB, the request fails with <c>ValidationException</c>
    /// (reason <c>queryBodyTooLarge</c>). Lower <c>maxResults</c>. </para> <para> If the
    /// request would exceed the service's rate for embedding requests, it fails with <c>ThrottlingException</c>.
    /// Retry with exponential backoff. </para> <para> If the space uses a customer managed
    /// AWS KMS key, the call can also fail because of the key. It fails with <c>AccessDeniedException</c>
    /// if you aren't allowed to use the key, and with <c>ThrottlingException</c> if AWS KMS
    /// throttles the request. It fails with <c>ValidationException</c> if the key is disabled,
    /// pending deletion, or deleted. </para>
    /// </summary>
    public partial class SearchMemoriesRequest : AmazonOpenSearchMemoryRequest
    {
        /// <summary>
        /// Gets and sets the property ActorId. 
        /// <para>
        /// The actor whose memories to search (exact match). Required: every search covers exactly
        /// one actor, and a memory stored without an actor is never returned. This is the only
        /// way to filter by actor: a query that references <c>system_metadata.actor_id</c> fails
        /// with <c>ValidationException</c> (reason <c>nonFilterableField</c>).
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
        /// The maximum number of memories to return, from 1 to 100. The default is 20.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 100)]
        public int? MaxResults { get; set; }

        /// <summary>
        /// Checks to see if the MaxResults property is set.
        /// </summary>
        internal bool IsSetMaxResults() => this.MaxResults.HasValue;

        /// <summary>
        /// Gets and sets the property MemoryStrategies. 
        /// <para>
        /// The strategies to search, as a list of selectors. Each selector names a memory type
        /// and, optionally, specific strategy names of that type. A space can hold several strategies
        /// of the same type. A selector without <c>memoryStrategyNames</c> searches every strategy
        /// of its type, and omitting <c>memoryStrategies</c> searches every strategy in the space.
        /// A name that is not a declared strategy of that type fails with <c>ValidationException</c>.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min = 1, Max = 5)]
        public List<StrategySelector> MemoryStrategies { get; set; } = AWSConfigs.InitializeCollections ? new List<StrategySelector>() : null;

        /// <summary>
        /// Checks to see if the MemoryStrategies property is set.
        /// </summary>
        internal bool IsSetMemoryStrategies() => this.MemoryStrategies != null && (this.MemoryStrategies.Count > 0 || !AWSConfigs.InitializeCollections);

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
        /// The query: a subset of the OpenSearch Query DSL (see <c>SearchQuery</c>). You can't
        /// use the actor and session fields <c>system_metadata.actor_id</c> and <c>system_metadata.session_id</c>
        /// here. Use the top-level <c>actorId</c> to filter by actor. Searching memories doesn't
        /// filter by session.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Sensitive = true)]
        public Amazon.Runtime.Documents.Document Query { get; set; }

        /// <summary>
        /// Checks to see if the Query property is set.
        /// </summary>
        internal bool IsSetQuery() => !this.Query.IsNull();

        /// <summary>
        /// Gets and sets the property Sort. 
        /// <para>
        /// The sort order (see <c>SearchSort</c>). Omit to return the most relevant memories
        /// first.
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
        /// The space to search. Use <c>actorId</c> to narrow the search within it.
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
