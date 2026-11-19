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
    /// A memory, as returned by <c>GetMemory</c> and <c>UpdateMemory</c>. Unlike <c>MemoryListSummary</c>
    /// it includes <c>content</c>, and unlike <c>MemorySearchSummary</c> it has no relevance
    /// score.
    /// </summary>
    public partial class Memory
    {
        /// <summary>
        /// Gets and sets the property Content. 
        /// <para>
        /// The memory text.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Sensitive = true, Max = 40000)]
        public string Content { get; set; }

        /// <summary>
        /// Checks to see if the Content property is set.
        /// </summary>
        internal bool IsSetContent() => this.Content != null;

        /// <summary>
        /// Gets and sets the property MemoryId. 
        /// <para>
        /// The memory's ID, assigned by the service.
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
        /// The memory type.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public MemoryType MemoryType { get; set; }

        /// <summary>
        /// Checks to see if the MemoryType property is set.
        /// </summary>
        internal bool IsSetMemoryType() => this.MemoryType != null;

        /// <summary>
        /// Gets and sets the property Metadata. 
        /// <para>
        /// The memory's metadata tags. All values are strings. May be empty.
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
        /// Gets and sets the property StrategyName. 
        /// <para>
        /// The name of the strategy the memory belongs to, for example <c>user-facts</c>. A space
        /// can hold several strategies of the same type, so this tells them apart. Absent when
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
        /// Provenance for the memory: the owning actor and session, and when it was created and
        /// last updated. Always present. <c>updatedAt</c> equals <c>createdAt</c> for a memory
        /// that has never been updated.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public SystemMetadata SystemMetadata { get; set; }

        /// <summary>
        /// Checks to see if the SystemMetadata property is set.
        /// </summary>
        internal bool IsSetSystemMetadata() => this.SystemMetadata != null;
    }
}
