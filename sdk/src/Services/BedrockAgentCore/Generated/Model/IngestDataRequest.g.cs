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
    /// Container for the parameters to the IngestData operation. Submits content directly
    /// for ingestion to generate long-term memory records in a AgentCore Memory resource.
    /// <para> To use this operation, you must have the <c>bedrock-agentcore:IngestData</c>
    /// permission. </para>
    /// </summary>
    public partial class IngestDataRequest : AmazonBedrockAgentCoreRequest
    {
        /// <summary>
        /// Gets and sets the property ActorId. 
        /// <para>
        /// The identifier of the actor associated with this content. An actor represents an entity
        /// that participates in sessions and generates content.
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
        /// A unique, case-sensitive identifier to ensure that the operation completes no more
        /// than one time. If this token matches a previous request, AgentCore ignores the request,
        /// but does not return an error.
        /// </para>
        /// </summary>
        public string ClientToken { get; set; }

        /// <summary>
        /// Checks to see if the ClientToken property is set.
        /// </summary>
        internal bool IsSetClientToken() => this.ClientToken != null;

        /// <summary>
        /// Gets and sets the property ContentTimestamp. 
        /// <para>
        /// The timestamp of when the content occurred.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public DateTime? ContentTimestamp { get; set; }

        /// <summary>
        /// Checks to see if the ContentTimestamp property is set.
        /// </summary>
        internal bool IsSetContentTimestamp() => this.ContentTimestamp.HasValue;

        /// <summary>
        /// Gets and sets the property ExtractionConfig. 
        /// <para>
        /// The extraction configuration for long-term memory records. Use this parameter to specify
        /// namespace variable keys and their values for namespace substitution during extraction.
        /// </para>
        /// </summary>
        public ExtractionConfig ExtractionConfig { get; set; }

        /// <summary>
        /// Checks to see if the ExtractionConfig property is set.
        /// </summary>
        internal bool IsSetExtractionConfig() => this.ExtractionConfig != null;

        /// <summary>
        /// Gets and sets the property MemoryId. 
        /// <para>
        /// The identifier of the AgentCore Memory resource to ingest content into.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 12)]
        public string MemoryId { get; set; }

        /// <summary>
        /// Checks to see if the MemoryId property is set.
        /// </summary>
        internal bool IsSetMemoryId() => this.MemoryId != null;

        /// <summary>
        /// Gets and sets the property Metadata. 
        /// <para>
        /// The key-value metadata to attach to the content.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min = 0, Max = 15)]
        public Dictionary<string, MetadataValue> Metadata { get; set; } = AWSConfigs.InitializeCollections ? new Dictionary<string, MetadataValue>() : null;

        /// <summary>
        /// Checks to see if the Metadata property is set.
        /// </summary>
        internal bool IsSetMetadata() => this.Metadata != null && (this.Metadata.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property SessionId. 
        /// <para>
        /// The identifier of the session that the content belongs to. If not provided, a session
        /// identifier is generated and returned in the response.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 100)]
        public string SessionId { get; set; }

        /// <summary>
        /// Checks to see if the SessionId property is set.
        /// </summary>
        internal bool IsSetSessionId() => this.SessionId != null;

        /// <summary>
        /// Gets and sets the property Source. 
        /// <para>
        /// The content to ingest. Only inline content is supported.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public ContentSource Source { get; set; }

        /// <summary>
        /// Checks to see if the Source property is set.
        /// </summary>
        internal bool IsSetSource() => this.Source != null;
    }
}
