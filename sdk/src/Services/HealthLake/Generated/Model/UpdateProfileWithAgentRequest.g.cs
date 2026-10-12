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

namespace Amazon.HealthLake.Model
{
    /// <summary>
    /// Container for the parameters to the UpdateProfileWithAgent operation. Updates a data
    /// transformation profile using chat-based interaction with an agent. Supports multi-turn
    /// conversations for iteratively customizing profiles.
    /// </summary>
    public partial class UpdateProfileWithAgentRequest : AmazonHealthLakeRequest
    {
        /// <summary>
        /// Gets and sets the property ConversationId. 
        /// <para>
        /// The conversation identifier for multi-turn interactions. Omit to start a new conversation.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 36)]
        public string ConversationId { get; set; }

        /// <summary>
        /// Checks to see if the ConversationId property is set.
        /// </summary>
        internal bool IsSetConversationId() => this.ConversationId != null;

        /// <summary>
        /// Gets and sets the property InputMessage. 
        /// <para>
        /// The message to send to the agent.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public AgentInputMessage InputMessage { get; set; }

        /// <summary>
        /// Checks to see if the InputMessage property is set.
        /// </summary>
        internal bool IsSetInputMessage() => this.InputMessage != null;

        /// <summary>
        /// Gets and sets the property ProfileId. 
        /// <para>
        /// The unique identifier of the profile to update via the agent.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 32, Max = 32)]
        public string ProfileId { get; set; }

        /// <summary>
        /// Checks to see if the ProfileId property is set.
        /// </summary>
        internal bool IsSetProfileId() => this.ProfileId != null;

        /// <summary>
        /// Gets and sets the property SourceFormat. 
        /// <para>
        /// The source data format for the transformation.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public SourceFormat SourceFormat { get; set; }

        /// <summary>
        /// Checks to see if the SourceFormat property is set.
        /// </summary>
        internal bool IsSetSourceFormat() => this.SourceFormat != null;
    }
}
