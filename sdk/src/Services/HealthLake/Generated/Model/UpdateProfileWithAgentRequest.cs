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
 * Do not modify this file. This file is generated from the healthlake-2017-07-01.normal.json service model.
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
namespace Amazon.HealthLake.Model
{
    /// <summary>
    /// Container for the parameters to the UpdateProfileWithAgent operation.
    /// Updates a data transformation profile using chat-based interaction with an agent.
    /// Supports multi-turn conversations for iteratively customizing profiles.
    /// </summary>
    public partial class UpdateProfileWithAgentRequest : AmazonHealthLakeRequest
    {
        private string _conversationId;
        private AgentInputMessage _inputMessage;
        private string _profileId;
        private SourceFormat _sourceFormat;

        /// <summary>
        /// Gets and sets the property ConversationId. 
        /// <para>
        /// The conversation identifier for multi-turn interactions. Omit to start a new conversation.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=36)]
        public string ConversationId
        {
            get { return this._conversationId; }
            set { this._conversationId = value; }
        }

        // Check to see if ConversationId property is set
        internal bool IsSetConversationId()
        {
            return this._conversationId != null;
        }

        /// <summary>
        /// Gets and sets the property InputMessage. 
        /// <para>
        /// The message to send to the agent.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public AgentInputMessage InputMessage
        {
            get { return this._inputMessage; }
            set { this._inputMessage = value; }
        }

        // Check to see if InputMessage property is set
        internal bool IsSetInputMessage()
        {
            return this._inputMessage != null;
        }

        /// <summary>
        /// Gets and sets the property ProfileId. 
        /// <para>
        /// The unique identifier of the profile to update via the agent.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=32, Max=32)]
        public string ProfileId
        {
            get { return this._profileId; }
            set { this._profileId = value; }
        }

        // Check to see if ProfileId property is set
        internal bool IsSetProfileId()
        {
            return this._profileId != null;
        }

        /// <summary>
        /// Gets and sets the property SourceFormat. 
        /// <para>
        /// The source data format for the transformation.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public SourceFormat SourceFormat
        {
            get { return this._sourceFormat; }
            set { this._sourceFormat = value; }
        }

        // Check to see if SourceFormat property is set
        internal bool IsSetSourceFormat()
        {
            return this._sourceFormat != null;
        }

    }
}