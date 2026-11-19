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
    /// Container for the parameters to the CreateMemory operation. Writes a memory that you
    /// have already formed, without extracting it from events. The service embeds the text
    /// as given and stores it as a memory of the named strategy. To have the service extract
    /// memories from conversation turns, use <c>CreateEvent</c> instead. <para> The operation
    /// returns before the memory is searchable. The returned <c>memoryId</c> is final, but
    /// until the memory is indexed, <c>GetMemory</c>, <c>UpdateMemory</c>, and <c>DeleteMemory</c>
    /// return <c>ResourceNotFoundException</c> for it. </para> <para> If the request would
    /// exceed the service's rate for embedding requests, it fails with <c>ThrottlingException</c>.
    /// Retry with exponential backoff. </para> <para> If the space uses a customer managed
    /// AWS KMS key, the call can also fail because of the key. It fails with <c>AccessDeniedException</c>
    /// if you aren't allowed to use the key, and with <c>ThrottlingException</c> if AWS KMS
    /// throttles the request. It fails with <c>ValidationException</c> if the key is disabled,
    /// pending deletion, or deleted. </para>
    /// </summary>
    public partial class CreateMemoryRequest : AmazonOpenSearchMemoryRequest
    {
        /// <summary>
        /// Gets and sets the property ActorId. 
        /// <para>
        /// The actor (end user or agent) that owns the memory.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 255)]
        public string ActorId { get; set; }

        /// <summary>
        /// Checks to see if the ActorId property is set.
        /// </summary>
        internal bool IsSetActorId() => this.ActorId != null;

        /// <summary>
        /// Gets and sets the property ClientToken. 
        /// <para>
        /// A unique, case-sensitive identifier that makes the request idempotent. Within 2 hours
        /// of the first request, a retry with the same token returns the same <c>memoryId</c>
        /// instead of creating a second memory. Reusing the token with a different <c>name</c>,
        /// <c>content</c>, <c>metadata</c>, <c>actorId</c>, or <c>sessionId</c> fails with <c>ConflictException</c>.
        /// If you omit <c>sessionId</c>, a retry with the same token gets the same session. If
        /// you omit the token, each call creates a new memory.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 512)]
        public string ClientToken { get; set; }

        /// <summary>
        /// Checks to see if the ClientToken property is set.
        /// </summary>
        internal bool IsSetClientToken() => this.ClientToken != null;

        /// <summary>
        /// Gets and sets the property Content. 
        /// <para>
        /// The memory text, stored and embedded as provided.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Sensitive = true, Min = 1, Max = 16000)]
        public string Content { get; set; }

        /// <summary>
        /// Checks to see if the Content property is set.
        /// </summary>
        internal bool IsSetContent() => this.Content != null;

        /// <summary>
        /// Gets and sets the property Metadata. 
        /// <para>
        /// Metadata tags to store with the memory. Keys that begin with <c>x-amz-</c>, the key
        /// <c>documentS3Source</c>, and other keys that the service uses internally are reserved:
        /// a request that sets one fails with <c>ValidationException</c>, and the message names
        /// the key.
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
        /// Gets and sets the property Name. 
        /// <para>
        /// The name of the strategy that the memory belongs to. The space must already declare
        /// the strategy, and the memory's type comes from that strategy. The name must be 1 to
        /// 64 characters: letters, digits, periods, hyphens, and underscores, starting with a
        /// letter or digit.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 255)]
        public string Name { get; set; }

        /// <summary>
        /// Checks to see if the Name property is set.
        /// </summary>
        internal bool IsSetName() => this.Name != null;

        /// <summary>
        /// Gets and sets the property SessionId. 
        /// <para>
        /// The session that the memory belongs to. If you omit it, the service generates a session
        /// ID and returns it.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 255)]
        public string SessionId { get; set; }

        /// <summary>
        /// Checks to see if the SessionId property is set.
        /// </summary>
        internal bool IsSetSessionId() => this.SessionId != null;

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
    }
}
