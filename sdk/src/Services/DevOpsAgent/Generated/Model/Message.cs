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
 * Do not modify this file. This file is generated from the devops-agent-2026-01-01.normal.json service model.
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
namespace Amazon.DevOpsAgent.Model
{
    /// <summary>
    /// A message in a conversation, either from the user or the assistant.
    /// </summary>
    public partial class Message
    {
        private List<AssistantMessageBlock> _assistantMessage = AWSConfigs.InitializeCollections ? new List<AssistantMessageBlock>() : null;
        private List<UserMessageBlock> _userMessage = AWSConfigs.InitializeCollections ? new List<UserMessageBlock>() : null;

        /// <summary>
        /// Gets and sets the property AssistantMessage. 
        /// <para>
        /// A message from the assistant.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<AssistantMessageBlock> AssistantMessage
        {
            get { return this._assistantMessage; }
            set { this._assistantMessage = value; }
        }

        // Check to see if AssistantMessage property is set
        internal bool IsSetAssistantMessage()
        {
            return this._assistantMessage != null && (this._assistantMessage.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property UserMessage. 
        /// <para>
        /// A message from the user.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<UserMessageBlock> UserMessage
        {
            get { return this._userMessage; }
            set { this._userMessage = value; }
        }

        // Check to see if UserMessage property is set
        internal bool IsSetUserMessage()
        {
            return this._userMessage != null && (this._userMessage.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

    }
}