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
    /// Container for the parameters to the CreateEvent operation. Submits an event (conversation
    /// turns, structured data, or a PDF document stored in Amazon S3) to a session in a space.
    /// <para> The operation returns as soon as the event is saved. <c>GetEvent</c> and <c>ListEvents</c>
    /// return it immediately. <c>SearchEvents</c> returns it after it's indexed. <c>SearchMemories</c>
    /// returns memories extracted from it only after a strategy's extraction trigger fires
    /// and the memories are indexed. </para> <para> If the space uses a customer managed
    /// AWS KMS key, the call can also fail because of the key. It fails with <c>AccessDeniedException</c>
    /// if you aren't allowed to use the key, and with <c>ThrottlingException</c> if AWS KMS
    /// throttles the request. It fails with <c>ValidationException</c> if the key is disabled,
    /// pending deletion, or deleted. </para>
    /// </summary>
    public partial class CreateEventRequest : AmazonOpenSearchMemoryRequest
    {
        /// <summary>
        /// Gets and sets the property ActorId. 
        /// <para>
        /// The ID of the actor (end user or agent) that the event belongs to.
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
        /// of the first request, a retry with the same token and the same request, including
        /// the same <c>sessionId</c>, returns the same event. If you omit <c>sessionId</c>, the
        /// service generates a new one on each attempt, so a retry fails with <c>ConflictException</c>.
        /// Reusing the token with different request content also fails with <c>ConflictException</c>.
        /// <c>eventTimestamp</c> isn't compared. After 2 hours, the token starts a new event.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 512)]
        public string ClientToken { get; set; }

        /// <summary>
        /// Checks to see if the ClientToken property is set.
        /// </summary>
        internal bool IsSetClientToken() => this.ClientToken != null;

        /// <summary>
        /// Gets and sets the property EventTimestamp. 
        /// <para>
        /// When the event occurred. The default is the time that the service receives the request.
        /// </para>
        /// </summary>
        public DateTime? EventTimestamp { get; set; }

        /// <summary>
        /// Checks to see if the EventTimestamp property is set.
        /// </summary>
        internal bool IsSetEventTimestamp() => this.EventTimestamp.HasValue;

        /// <summary>
        /// Gets and sets the property Infer. 
        /// <para>
        /// Specifies whether to extract memories from this event. The default is <c>true</c>.
        /// Set it to <c>false</c> to store the event without extraction: the service skips strategies
        /// that infer memories, and still indexes the event's turns for <c>SearchEvents</c>.
        /// A document submitted as a <c>blob</c> is still extracted.
        /// </para>
        /// </summary>
        public bool? Infer { get; set; }

        /// <summary>
        /// Checks to see if the Infer property is set.
        /// </summary>
        internal bool IsSetInfer() => this.Infer.HasValue;

        /// <summary>
        /// Gets and sets the property Metadata. 
        /// <para>
        /// Metadata tags to store with the event. Memories derived from the event carry the same
        /// tags. Keys that begin with <c>x-amz-</c>, the keys <c>documentS3Source</c> and <c>documentS3Url</c>,
        /// and other keys that the service uses internally are reserved: a request that sets
        /// one fails with <c>ValidationException</c>, and the message names the key.
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
        /// Gets and sets the property Payload. 
        /// <para>
        /// The event content. Set exactly one union member.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public EventPayload Payload { get; set; }

        /// <summary>
        /// Checks to see if the Payload property is set.
        /// </summary>
        internal bool IsSetPayload() => this.Payload != null;

        /// <summary>
        /// Gets and sets the property SessionId. 
        /// <para>
        /// The session the event belongs to. Send every event of one conversation with the same
        /// session ID, so that <c>SUMMARY</c> strategies summarize the conversation as one session.
        /// If you omit it, the service generates a session ID and returns it.
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
        /// The ID of the space that owns the event, for example <c>sp-02864597b164</c>.
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
