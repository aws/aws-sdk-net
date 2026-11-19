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
    /// A <c>SearchMemories</c> result: a matching memory and its relevance score.
    /// </summary>
    public partial class MemorySearchSummary
    {
        /// <summary>
        /// Gets and sets the property Content. 
        /// <para>
        /// The memory text.
        /// </para>
        /// </summary>
        [AWSProperty(Sensitive = true, Max = 40000)]
        public string Content { get; set; }

        /// <summary>
        /// Checks to see if the Content property is set.
        /// </summary>
        internal bool IsSetContent() => this.Content != null;

        /// <summary>
        /// Gets and sets the property MemoryId. 
        /// <para>
        /// The memory's ID, assigned by the service. Always present.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 128)]
        public string MemoryId { get; set; }

        /// <summary>
        /// Checks to see if the MemoryId property is set.
        /// </summary>
        internal bool IsSetMemoryId() => this.MemoryId != null;

        /// <summary>
        /// Gets and sets the property MemoryType. 
        /// <para>
        /// The memory type of the result.
        /// </para>
        /// </summary>
        public MemoryType MemoryType { get; set; }

        /// <summary>
        /// Checks to see if the MemoryType property is set.
        /// </summary>
        internal bool IsSetMemoryType() => this.MemoryType != null;

        /// <summary>
        /// Gets and sets the property Metadata. 
        /// <para>
        /// The memory's metadata tags. All values are strings. In a query, filter on a tag as
        /// <c>metadata.&lt;key&gt;</c>.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min = 0, Max = 15)]
        public Dictionary<string, string> Metadata { get; set; } = AWSConfigs.InitializeCollections ? new Dictionary<string, string>() : null;

        /// <summary>
        /// Checks to see if the Metadata property is set.
        /// </summary>
        internal bool IsSetMetadata() => this.Metadata != null && (this.Metadata.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property Score. 
        /// <para>
        /// The relevance score of the result. A higher score is more relevant. Scores aren't
        /// normalized to a fixed range and can be greater than 1, so use them only to order results.
        /// </para>
        /// </summary>
        public double? Score { get; set; }

        /// <summary>
        /// Checks to see if the Score property is set.
        /// </summary>
        internal bool IsSetScore() => this.Score.HasValue;

        /// <summary>
        /// Gets and sets the property SourceEventIds. 
        /// <para>
        /// The IDs of the events the memory was derived from, without duplicates. Use them with
        /// <c>GetEvent</c> or <c>BatchGetEvent</c>, or to search those events' content with <c>SearchEvents</c>
        /// by filtering on <c>event_ids</c> in the query. Absent for a memory created directly
        /// with <c>CreateMemory</c>. A memory can be derived from several events. The service
        /// sets this value.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Max = 100)]
        public List<string> SourceEventIds { get; set; } = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Checks to see if the SourceEventIds property is set.
        /// </summary>
        internal bool IsSetSourceEventIds() => this.SourceEventIds != null && (this.SourceEventIds.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property StrategyName. 
        /// <para>
        /// The name of the strategy the memory belongs to, for example <c>user-facts</c>: the
        /// strategy <c>memoryStrategies</c> selects on in <c>SearchMemories</c>. Absent when
        /// the memory's strategy is no longer declared on the space, for example right after
        /// the strategy is deleted.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 255)]
        public string StrategyName { get; set; }

        /// <summary>
        /// Checks to see if the StrategyName property is set.
        /// </summary>
        internal bool IsSetStrategyName() => this.StrategyName != null;

        /// <summary>
        /// Gets and sets the property SystemMetadata. 
        /// <para>
        /// Provenance for the memory: the actor and session that own it, and when it was created
        /// and last updated. It is the same block that <c>ListMemories</c>, <c>GetMemory</c>,
        /// and <c>SearchEvents</c> return.
        /// </para>
        ///  
        /// <para>
        /// In a query, filter or sort on the timestamps as <c>system_metadata.created_at</c>
        /// and <c>system_metadata.updated_at</c>. Scope by owner with the top-level <c>actorId</c>,
        /// not in the query. Searching memories doesn't filter by session.
        /// </para>
        ///  
        /// <para>
        /// Absent when the service has no provenance for the memory.
        /// </para>
        /// </summary>
        public SystemMetadata SystemMetadata { get; set; }

        /// <summary>
        /// Checks to see if the SystemMetadata property is set.
        /// </summary>
        internal bool IsSetSystemMetadata() => this.SystemMetadata != null;
    }
}
