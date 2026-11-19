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
    /// A <c>SearchEvents</c> result: the matching chunk of an event and its provenance. Unlike
    /// <c>EventSummary</c> from <c>ListEvents</c>, it has a relevance score and the matched
    /// content, but not the full payload.
    /// </summary>
    public partial class EventSearchSummary
    {
        /// <summary>
        /// Gets and sets the property EventId. 
        /// <para>
        /// The ID of the event that the chunk belongs to. Use it with <c>GetEvent</c> or <c>DeleteEvent</c>.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 128)]
        public string EventId { get; set; }

        /// <summary>
        /// Checks to see if the EventId property is set.
        /// </summary>
        internal bool IsSetEventId() => this.EventId != null;

        /// <summary>
        /// Gets and sets the property MatchedContent. 
        /// <para>
        /// The text of the matching chunk.
        /// </para>
        /// </summary>
        [AWSProperty(Sensitive = true, Max = 40000)]
        public string MatchedContent { get; set; }

        /// <summary>
        /// Checks to see if the MatchedContent property is set.
        /// </summary>
        internal bool IsSetMatchedContent() => this.MatchedContent != null;

        /// <summary>
        /// Gets and sets the property Metadata. 
        /// <para>
        /// The event's metadata tags. All values are strings. In a query, filter on a tag as
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
        /// Gets and sets the property SystemMetadata. 
        /// <para>
        /// Provenance for the chunk: the owning actor and session, and when it was created and
        /// last updated. It is the same block that <c>ListMemories</c> and <c>SearchMemories</c>
        /// return. Event chunks are never modified, so <c>updatedAt</c> always equals <c>createdAt</c>.
        /// </para>
        ///  
        /// <para>
        /// Absent when the service has no provenance for the chunk.
        /// </para>
        /// </summary>
        public SystemMetadata SystemMetadata { get; set; }

        /// <summary>
        /// Checks to see if the SystemMetadata property is set.
        /// </summary>
        internal bool IsSetSystemMetadata() => this.SystemMetadata != null;
    }
}
