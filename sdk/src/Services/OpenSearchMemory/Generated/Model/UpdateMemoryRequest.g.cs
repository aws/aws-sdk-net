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
    /// Container for the parameters to the UpdateMemory operation. Updates a memory in place.
    /// Supply only the fields to change. Omitted fields keep their stored values. A request
    /// must supply <c>content</c> or <c>metadata</c>, or it fails with <c>ValidationException</c>.
    /// Supplying <c>content</c> re-embeds the memory. A change to metadata alone doesn't.
    /// <para> The memory keeps its <c>memoryId</c> across updates. Shortly after an update,
    /// searches stop returning the previous content. </para> <para> <c>memoryType</c> can't
    /// be changed. To change it, delete the memory and create a new one. </para> <para> A
    /// memory past its expiry (set from the space's <c>memoryExpiryDays</c> when the memory
    /// is written) reads as not found: the operation fails with <c>ResourceNotFoundException</c>
    /// and changes nothing. An update does not move the expiry. </para> <para> Concurrent
    /// updates to one memory are last-writer-wins. There is no version check. To avoid lost
    /// updates, serialize your updates to a memory. </para> <para> If you supply <c>content</c>
    /// and the request would exceed the service's rate for embedding requests, it fails with
    /// <c>ThrottlingException</c>. Retry with exponential backoff. </para> <para> If the
    /// space uses a customer managed AWS KMS key, the call can also fail because of the key.
    /// It fails with <c>AccessDeniedException</c> if you aren't allowed to use the key, and
    /// with <c>ThrottlingException</c> if AWS KMS throttles the request. It fails with <c>ValidationException</c>
    /// if the key is disabled, pending deletion, or deleted. </para>
    /// </summary>
    public partial class UpdateMemoryRequest : AmazonOpenSearchMemoryRequest
    {
        /// <summary>
        /// Gets and sets the property ActorId. 
        /// <para>
        /// The ID of the actor that the memory must belong to. Omit it to skip this check. If
        /// it doesn't match the stored memory, the call fails with <c>ResourceNotFoundException</c>,
        /// as if the memory did not exist.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 255)]
        public string ActorId { get; set; }

        /// <summary>
        /// Checks to see if the ActorId property is set.
        /// </summary>
        internal bool IsSetActorId() => this.ActorId != null;

        /// <summary>
        /// Gets and sets the property Content. 
        /// <para>
        /// Replacement memory text. Supplying it re-embeds the memory. Omit to leave the text
        /// unchanged.
        /// </para>
        /// </summary>
        [AWSProperty(Sensitive = true, Min = 1, Max = 16000)]
        public string Content { get; set; }

        /// <summary>
        /// Checks to see if the Content property is set.
        /// </summary>
        internal bool IsSetContent() => this.Content != null;

        /// <summary>
        /// Gets and sets the property MemoryId. 
        /// <para>
        /// The ID of the memory to update.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 128)]
        public string MemoryId { get; set; }

        /// <summary>
        /// Checks to see if the MemoryId property is set.
        /// </summary>
        internal bool IsSetMemoryId() => this.MemoryId != null;

        /// <summary>
        /// Gets and sets the property Metadata. 
        /// <para>
        /// The metadata tags to apply. By default this map replaces the stored metadata, and
        /// any key not present is removed. Set <c>metadataMode</c> to <c>MERGE</c> to keep the
        /// keys you don't supply. Limits apply to the resulting metadata, not to the request.
        /// Keys that begin with <c>x-amz-</c> and the key <c>documentS3Source</c> are reserved:
        /// a request that sets one fails with <c>ValidationException</c>.
        /// </para>
        ///  
        /// <para>
        /// A space can use at most 50 distinct metadata keys across all of its events and memories.
        /// A request that would add a key beyond that fails with <c>ValidationException</c>.
        /// Reuse an existing key instead.
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
        /// Gets and sets the property MetadataMode. 
        /// <para>
        /// How <c>metadata</c> combines with what is stored. The default is <c>REPLACE</c>.
        /// </para>
        /// </summary>
        public MetadataMode MetadataMode { get; set; }

        /// <summary>
        /// Checks to see if the MetadataMode property is set.
        /// </summary>
        internal bool IsSetMetadataMode() => this.MetadataMode != null;

        /// <summary>
        /// Gets and sets the property SpaceId. 
        /// <para>
        /// The ID of the space that owns the memory, for example <c>sp-02864597b164</c>.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 64)]
        public string SpaceId { get; set; }

        /// <summary>
        /// Checks to see if the SpaceId property is set.
        /// </summary>
        internal bool IsSetSpaceId() => this.SpaceId != null;

        /// <summary>
        /// Gets and sets the property StrategyName. 
        /// <para>
        /// The name of the strategy that the memory must belong to. Omit it to skip this check.
        /// If it doesn't match the stored memory, the call fails with <c>ResourceNotFoundException</c>,
        /// as if the memory did not exist.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 255)]
        public string StrategyName { get; set; }

        /// <summary>
        /// Checks to see if the StrategyName property is set.
        /// </summary>
        internal bool IsSetStrategyName() => this.StrategyName != null;
    }
}
