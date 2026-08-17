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
 * Do not modify this file. This file is generated from the bedrock-agent-runtime-2023-07-26.normal.json service model.
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
namespace Amazon.BedrockAgentRuntime.Model
{
    /// <summary>
    /// Specifies an AgentCore Memory resource and how this retrieval uses it. Set sessionBinding
    /// to restore and continue a session. Set retrievalConfigs to let the agent retrieve
    /// from long-term memory. You must specify at least one of the two.
    /// </summary>
    public partial class AgenticRetrieveMemoryConfiguration
    {
        private string _memoryId;
        private AgenticRetrieveMemoryPersistenceMode _persistenceMode;
        private List<AgenticRetrieveMemoryRetrievalConfig> _retrievalConfigs = AWSConfigs.InitializeCollections ? new List<AgenticRetrieveMemoryRetrievalConfig>() : null;
        private AgenticRetrieveMemorySessionBinding _sessionBinding;

        /// <summary>
        /// Gets and sets the property MemoryId. 
        /// <para>
        /// The identifier of the AgentCore Memory resource to use. The resource must exist in
        /// your account and be in the ACTIVE state.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=12, Max=111)]
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
        /// Gets and sets the property PersistenceMode. 
        /// <para>
        /// Specifies whether the agent-generated answer is written back to the given short-term
        /// memory session, and applies only when sessionBinding is set. Valid values:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <c>DEFAULT</c> (default) – Specifies that the question and the agent-generated answer
        /// are persisted to the session as a single event. This value requires generateResponse
        /// to be true.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>NONE</c> – Specifies that the session is left unchanged.
        /// </para>
        ///  </li> </ul>
        /// </summary>
        public AgenticRetrieveMemoryPersistenceMode PersistenceMode
        {
            get { return this._persistenceMode; }
            set { this._persistenceMode = value; }
        }

        // Check to see if PersistenceMode property is set
        internal bool IsSetPersistenceMode()
        {
            return this._persistenceMode != null;
        }

        /// <summary>
        /// Gets and sets the property RetrievalConfigs. 
        /// <para>
        /// Specifies the long-term memory configuration the agent can retrieve from. The agent
        /// decides whether to retrieve and composes its own query. This field currently accepts
        /// at most one entry.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<AgenticRetrieveMemoryRetrievalConfig> RetrievalConfigs
        {
            get { return this._retrievalConfigs; }
            set { this._retrievalConfigs = value; }
        }

        // Check to see if RetrievalConfigs property is set
        internal bool IsSetRetrievalConfigs()
        {
            return this._retrievalConfigs != null && (this._retrievalConfigs.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property SessionBinding. 
        /// <para>
        /// The short-term memory session whose history is restored for this retrieval. To persist
        /// the agent-generated answer to the session, omit persistenceMode or set it to DEFAULT.
        /// To leave the session unchanged, set persistenceMode to NONE. Supply session history
        /// through the existing messages parameter or through short-term memory, but not both.
        /// </para>
        /// </summary>
        public AgenticRetrieveMemorySessionBinding SessionBinding
        {
            get { return this._sessionBinding; }
            set { this._sessionBinding = value; }
        }

        // Check to see if SessionBinding property is set
        internal bool IsSetSessionBinding()
        {
            return this._sessionBinding != null;
        }

    }
}