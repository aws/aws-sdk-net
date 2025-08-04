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
 * Do not modify this file. This file is generated from the bedrock-agentcore-2024-02-28.normal.json service model.
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
    /// Contains information about an event in an AgentCore Memory resource.
    /// </summary>
    public partial class Event
    {
        private string _actorId;
        private Branch _branch;
        private string _eventId;
        private DateTime? _eventTimestamp;
        private string _memoryId;
        private List<PayloadType> _payload = AWSConfigs.InitializeCollections ? new List<PayloadType>() : null;
        private string _sessionId;

        /// <summary>
        /// Gets and sets the property ActorId. 
        /// <para>
        /// The identifier of the actor associated with the event.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=255)]
        public string ActorId
        {
            get { return this._actorId; }
            set { this._actorId = value; }
        }

        // Check to see if ActorId property is set
        internal bool IsSetActorId()
        {
            return this._actorId != null;
        }

        /// <summary>
        /// Gets and sets the property Branch. 
        /// <para>
        /// The branch information for the event.
        /// </para>
        /// </summary>
        public Branch Branch
        {
            get { return this._branch; }
            set { this._branch = value; }
        }

        // Check to see if Branch property is set
        internal bool IsSetBranch()
        {
            return this._branch != null;
        }

        /// <summary>
        /// Gets and sets the property EventId. 
        /// <para>
        /// The unique identifier of the event.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string EventId
        {
            get { return this._eventId; }
            set { this._eventId = value; }
        }

        // Check to see if EventId property is set
        internal bool IsSetEventId()
        {
            return this._eventId != null;
        }

        /// <summary>
        /// Gets and sets the property EventTimestamp. 
        /// <para>
        /// The timestamp when the event occurred.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public DateTime? EventTimestamp
        {
            get { return this._eventTimestamp; }
            set { this._eventTimestamp = value; }
        }

        // Check to see if EventTimestamp property is set
        internal bool IsSetEventTimestamp()
        {
            return this._eventTimestamp.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property MemoryId. 
        /// <para>
        /// The identifier of the AgentCore Memory resource containing the event.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=12)]
        public string MemoryId
        {
            get { return this._memoryId; }
            set { this._memoryId = value; }
        }

        // Check to see if MemoryId property is set
        internal bool IsSetMemoryId()
        {
            return this._memoryId != null;
        }

        /// <summary>
        /// Gets and sets the property Payload. 
        /// <para>
        /// The content payload of the event.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Required=true, Min=0, Max=100)]
        public List<PayloadType> Payload
        {
            get { return this._payload; }
            set { this._payload = value; }
        }

        // Check to see if Payload property is set
        internal bool IsSetPayload()
        {
            return this._payload != null && (this._payload.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property SessionId. 
        /// <para>
        /// The identifier of the session containing the event.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=100)]
        public string SessionId
        {
            get { return this._sessionId; }
            set { this._sessionId = value; }
        }

        // Check to see if SessionId property is set
        internal bool IsSetSessionId()
        {
            return this._sessionId != null;
        }

    }
}