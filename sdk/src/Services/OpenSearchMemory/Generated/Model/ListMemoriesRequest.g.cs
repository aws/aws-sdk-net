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
    /// Container for the parameters to the ListMemories operation. Lists a space's memories
    /// without a query, for example the most recent memories or the memories of one strategy.
    /// Filter by strategy and optionally by owning actor or session, sort by creation or
    /// update time, and page through the results. Results have no relevance score. To query
    /// or filter by metadata, use <c>SearchMemories</c>. <para> If memories are written or
    /// deleted while you page, the results can skip a memory or return it twice. You can
    /// page through only a limited number of results. A request past that limit fails with
    /// <c>ValidationException</c> (reason <c>invalidNextToken</c>), and the message gives
    /// the limit. </para> <para> Memories past their expiry (set from the space's <c>memoryExpiryDays</c>
    /// when each memory is written) are left out. Unlike <c>SearchMemories</c>, this operation
    /// also returns memories that consolidation has superseded. </para> <para> If the space
    /// uses a customer managed AWS KMS key, the call can also fail because of the key. It
    /// fails with <c>AccessDeniedException</c> if you aren't allowed to use the key, and
    /// with <c>ThrottlingException</c> if AWS KMS throttles the request. It fails with <c>ValidationException</c>
    /// if the key is disabled, pending deletion, or deleted. </para>
    /// </summary>
    public partial class ListMemoriesRequest : AmazonOpenSearchMemoryRequest
    {
        /// <summary>
        /// Gets and sets the property ActorIds. 
        /// <para>
        /// Lists only memories owned by one of these actors. Combined with <c>sessionIds</c>
        /// by AND: a memory must match both filters when both are given. Omit for no actor filter.
        /// An empty list fails validation. A memory stored without an actor never matches an
        /// actor filter.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min = 1, Max = 10)]
        public List<string> ActorIds { get; set; } = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Checks to see if the ActorIds property is set.
        /// </summary>
        internal bool IsSetActorIds() => this.ActorIds != null && (this.ActorIds.Count > 0 || !AWSConfigs.InitializeCollections);

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
        /// The strategies to list, as selectors. A selector without <c>memoryStrategyNames</c>
        /// lists every strategy of its type, and omitting <c>memoryStrategies</c> lists every
        /// strategy in the space. A name that is not a declared strategy of that type fails with
        /// <c>ValidationException</c>.
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
        /// Gets and sets the property SessionIds. 
        /// <para>
        /// Lists only memories from one of these sessions. Combined with <c>actorIds</c> by AND.
        /// Omit for no session filter. An empty list fails validation. A memory stored without
        /// a session never matches a session filter.
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
        /// Gets and sets the property SortBy. 
        /// <para>
        /// The timestamp to sort by, as returned in <c>systemMetadata</c>: <c>CREATED_AT</c>
        /// (the default) or <c>UPDATED_AT</c>.
        /// </para>
        /// </summary>
        public MemorySortField SortBy { get; set; }

        /// <summary>
        /// Checks to see if the SortBy property is set.
        /// </summary>
        internal bool IsSetSortBy() => this.SortBy != null;

        /// <summary>
        /// Gets and sets the property SortOrder. 
        /// <para>
        /// The sort order: <c>ASC</c> or <c>DESC</c>. The default is <c>DESC</c>, most recent
        /// first.
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
        /// The space whose memories to list.
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
