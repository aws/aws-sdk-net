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

namespace Amazon.BedrockAgentCore.Model
{
    /// <summary>
    /// Input structure to update an existing memory record.
    /// </summary>
    public partial class MemoryRecordUpdateInput
    {
        /// <summary>
        /// Gets and sets the property Content. 
        /// <para>
        /// The content to be stored within the memory record.
        /// </para>
        /// </summary>
        public MemoryContent Content { get; set; }

        /// <summary>
        /// Checks to see if the Content property is set.
        /// </summary>
        internal bool IsSetContent() => this.Content != null;

        /// <summary>
        /// Gets and sets the property MemoryRecordId. 
        /// <para>
        /// The unique ID of the memory record to be updated.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 40, Max = 50)]
        public string MemoryRecordId { get; set; }

        /// <summary>
        /// Checks to see if the MemoryRecordId property is set.
        /// </summary>
        internal bool IsSetMemoryRecordId() => this.MemoryRecordId != null;

        /// <summary>
        /// Gets and sets the property MemoryStrategyId. 
        /// <para>
        /// The updated ID of the memory strategy that defines how this memory record is grouped.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 100)]
        public string MemoryStrategyId { get; set; }

        /// <summary>
        /// Checks to see if the MemoryStrategyId property is set.
        /// </summary>
        internal bool IsSetMemoryStrategyId() => this.MemoryStrategyId != null;

        /// <summary>
        /// Gets and sets the property Metadata. 
        /// <para>
        /// Metadata key-value pairs to be stored with the memory record.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min = 1, Max = 20)]
        public Dictionary<string, MemoryRecordMetadataValue> Metadata { get; set; } = AWSConfigs.InitializeCollections ? new Dictionary<string, MemoryRecordMetadataValue>() : null;

        /// <summary>
        /// Checks to see if the Metadata property is set.
        /// </summary>
        internal bool IsSetMetadata() => this.Metadata != null && (this.Metadata.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property Namespaces. 
        /// <para>
        /// The updated list of namespace identifiers for categorizing the memory record.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Max = 1)]
        public List<string> Namespaces { get; set; } = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Checks to see if the Namespaces property is set.
        /// </summary>
        internal bool IsSetNamespaces() => this.Namespaces != null && (this.Namespaces.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property SourceNamespaces. 
        /// <para>
        /// The namespaces of the source memory record being updated. This value is used for IAM
        /// condition key authorization.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Max = 1)]
        public List<string> SourceNamespaces { get; set; } = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Checks to see if the SourceNamespaces property is set.
        /// </summary>
        internal bool IsSetSourceNamespaces() => this.SourceNamespaces != null && (this.SourceNamespaces.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property Timestamp. 
        /// <para>
        /// Time at which the memory record was updated
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public DateTime? Timestamp { get; set; }

        /// <summary>
        /// Checks to see if the Timestamp property is set.
        /// </summary>
        internal bool IsSetTimestamp() => this.Timestamp.HasValue;
    }
}
