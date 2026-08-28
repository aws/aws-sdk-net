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
    /// Container for the parameters to the IngestData operation.
    /// Submits content directly for ingestion to generate long-term memory records in a AgentCore
    /// Memory resource.
    /// 
    ///  
    /// <para>
    /// To use this operation, you must have the <c>bedrock-agentcore:IngestData</c> permission.
    /// </para>
    /// </summary>
    public partial class IngestDataRequest : AmazonBedrockAgentCoreRequest
    {
        private string _actorId;
        private string _clientToken;
        private DateTime? _contentTimestamp;
        private ExtractionConfig _extractionConfig;
        private string _memoryId;
        private Dictionary<string, MetadataValue> _metadata = AWSConfigs.InitializeCollections ? new Dictionary<string, MetadataValue>() : null;
        private string _sessionId;
        private ContentSource _source;

        /// <summary>
        /// Gets and sets the property ActorId. 
        /// <para>
        /// The identifier of the actor associated with this content. An actor represents an entity
        /// that participates in sessions and generates content.
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
        /// Gets and sets the property ClientToken. 
        /// <para>
        /// A unique, case-sensitive identifier to ensure that the operation completes no more
        /// than one time. If this token matches a previous request, AgentCore ignores the request,
        /// but does not return an error.
        /// </para>
        /// </summary>
        public string ClientToken
        {
            get { return this._clientToken; }
            set { this._clientToken = value; }
        }

        // Check to see if ClientToken property is set
        internal bool IsSetClientToken()
        {
            return this._clientToken != null;
        }

        /// <summary>
        /// Gets and sets the property ContentTimestamp. 
        /// <para>
        /// The timestamp of when the content occurred.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public DateTime? ContentTimestamp
        {
            get { return this._contentTimestamp; }
            set { this._contentTimestamp = value; }
        }

        // Check to see if ContentTimestamp property is set
        internal bool IsSetContentTimestamp()
        {
            return this._contentTimestamp.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property ExtractionConfig. 
        /// <para>
        /// The extraction configuration for long-term memory records. Use this parameter to specify
        /// namespace variable keys and their values for namespace substitution during extraction.
        /// </para>
        /// </summary>
        public ExtractionConfig ExtractionConfig
        {
            get { return this._extractionConfig; }
            set { this._extractionConfig = value; }
        }

        // Check to see if ExtractionConfig property is set
        internal bool IsSetExtractionConfig()
        {
            return this._extractionConfig != null;
        }

        /// <summary>
        /// Gets and sets the property MemoryId. 
        /// <para>
        /// The identifier of the AgentCore Memory resource to ingest content into.
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
        /// Gets and sets the property Metadata. 
        /// <para>
        /// The key-value metadata to attach to the content.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min=0, Max=15)]
        public Dictionary<string, MetadataValue> Metadata
        {
            get { return this._metadata; }
            set { this._metadata = value; }
        }

        // Check to see if Metadata property is set
        internal bool IsSetMetadata()
        {
            return this._metadata != null && (this._metadata.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property SessionId. 
        /// <para>
        /// The identifier of the session that the content belongs to. If not provided, a session
        /// identifier is generated and returned in the response.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=100)]
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

        /// <summary>
        /// Gets and sets the property Source. 
        /// <para>
        /// The content to ingest. Only inline content is supported.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public ContentSource Source
        {
            get { return this._source; }
            set { this._source = value; }
        }

        // Check to see if Source property is set
        internal bool IsSetSource()
        {
            return this._source != null;
        }

    }
}