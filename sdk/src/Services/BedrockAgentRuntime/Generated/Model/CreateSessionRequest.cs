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
    /// Container for the parameters to the CreateSession operation.
    /// Creates a session to temporarily store conversations for generative AI (GenAI) applications
    /// built with open-source frameworks such as LangGraph and LlamaIndex. Sessions enable
    /// you to save the state of conversations at checkpoints, with the added security and
    /// infrastructure of Amazon Web Services. For more information, see <a href="https://docs.aws.amazon.com/bedrock/latest/userguide/sessions.html">Store
    /// and retrieve conversation history and context with Amazon Bedrock sessions</a>.
    /// 
    ///  
    /// <para>
    /// By default, Amazon Bedrock uses Amazon Web Services-managed keys for session encryption,
    /// including session metadata, or you can use your own KMS key. For more information,
    /// see <a href="https://docs.aws.amazon.com/bedrock/latest/userguide/session-encryption.html">Amazon
    /// Bedrock session encryption</a>.
    /// </para>
    ///  <note> 
    /// <para>
    ///  You use a session to store state and conversation history for generative AI applications
    /// built with open-source frameworks. For Amazon Bedrock Agents, the service automatically
    /// manages conversation context and associates them with the agent-specific sessionId
    /// you specify in the <a href="https://docs.aws.amazon.com/bedrock/latest/APIReference/API_agent-runtime_InvokeAgent.html">InvokeAgent</a>
    /// API operation. 
    /// </para>
    ///  </note> 
    /// <para>
    /// Related APIs:
    /// </para>
    ///  <ul> <li> 
    /// <para>
    ///  <a href="https://docs.aws.amazon.com/bedrock/latest/APIReference/API_agent-runtime_ListSessions.html">ListSessions</a>
    /// 
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <a href="https://docs.aws.amazon.com/bedrock/latest/APIReference/API_agent-runtime_GetSession.html">GetSession</a>
    /// 
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <a href="https://docs.aws.amazon.com/bedrock/latest/APIReference/API_agent-runtime_EndSession.html">EndSession</a>
    /// 
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <a href="https://docs.aws.amazon.com/bedrock/latest/APIReference/API_agent-runtime_DeleteSession.html">DeleteSession</a>
    /// 
    /// </para>
    ///  </li> </ul>
    /// </summary>
    public partial class CreateSessionRequest : AmazonBedrockAgentRuntimeRequest
    {
        private string _encryptionKeyArn;
        private Dictionary<string, string> _sessionMetadata = AWSConfigs.InitializeCollections ? new Dictionary<string, string>() : null;
        private Dictionary<string, string> _tags = AWSConfigs.InitializeCollections ? new Dictionary<string, string>() : null;

        /// <summary>
        /// Gets and sets the property EncryptionKeyArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the KMS key to use to encrypt the session data.
        /// The user or role creating the session must have permission to use the key. For more
        /// information, see <a href="https://docs.aws.amazon.com/bedrock/latest/userguide/session-encryption.html">Amazon
        /// Bedrock session encryption</a>. 
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=2048)]
        public string EncryptionKeyArn
        {
            get { return this._encryptionKeyArn; }
            set { this._encryptionKeyArn = value; }
        }

        // Check to see if EncryptionKeyArn property is set
        internal bool IsSetEncryptionKeyArn()
        {
            return this._encryptionKeyArn != null;
        }

        /// <summary>
        /// Gets and sets the property SessionMetadata. 
        /// <para>
        /// A map of key-value pairs containing attributes to be persisted across the session.
        /// For example, the user's ID, their language preference, and the type of device they
        /// are using.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min=0, Max=50)]
        public Dictionary<string, string> SessionMetadata
        {
            get { return this._sessionMetadata; }
            set { this._sessionMetadata = value; }
        }

        // Check to see if SessionMetadata property is set
        internal bool IsSetSessionMetadata()
        {
            return this._sessionMetadata != null && (this._sessionMetadata.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property Tags. 
        /// <para>
        /// Specify the key-value pairs for the tags that you want to attach to the session.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min=1, Max=200)]
        public Dictionary<string, string> Tags
        {
            get { return this._tags; }
            set { this._tags = value; }
        }

        // Check to see if Tags property is set
        internal bool IsSetTags()
        {
            return this._tags != null && (this._tags.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

    }
}