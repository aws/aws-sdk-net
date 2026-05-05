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
 * Do not modify this file. This file is generated from the bedrock-agentcore-control-2023-06-05.normal.json service model.
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
namespace Amazon.BedrockAgentCoreControl.Model
{
    /// <summary>
    /// Configuration for AgentCore Memory integration.
    /// </summary>
    public partial class HarnessAgentCoreMemoryConfiguration
    {
        private string _actorId;
        private string _arn;
        private int? _messagesCount;
        private Dictionary<string, HarnessAgentCoreMemoryRetrievalConfig> _retrievalConfig = AWSConfigs.InitializeCollections ? new Dictionary<string, HarnessAgentCoreMemoryRetrievalConfig>() : null;

        /// <summary>
        /// Gets and sets the property ActorId. 
        /// <para>
        /// The actor ID for memory operations.
        /// </para>
        /// </summary>
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
        /// Gets and sets the property Arn. 
        /// <para>
        /// The ARN of the AgentCore Memory resource.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string Arn
        {
            get { return this._arn; }
            set { this._arn = value; }
        }

        // Check to see if Arn property is set
        internal bool IsSetArn()
        {
            return this._arn != null;
        }

        /// <summary>
        /// Gets and sets the property MessagesCount. 
        /// <para>
        /// The number of messages to retrieve from memory.
        /// </para>
        /// </summary>
        public int? MessagesCount
        {
            get { return this._messagesCount; }
            set { this._messagesCount = value; }
        }

        // Check to see if MessagesCount property is set
        internal bool IsSetMessagesCount()
        {
            return this._messagesCount.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property RetrievalConfig. 
        /// <para>
        /// The retrieval configuration for long-term memory, mapping namespace path templates
        /// to retrieval settings.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public Dictionary<string, HarnessAgentCoreMemoryRetrievalConfig> RetrievalConfig
        {
            get { return this._retrievalConfig; }
            set { this._retrievalConfig = value; }
        }

        // Check to see if RetrievalConfig property is set
        internal bool IsSetRetrievalConfig()
        {
            return this._retrievalConfig != null && (this._retrievalConfig.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

    }
}