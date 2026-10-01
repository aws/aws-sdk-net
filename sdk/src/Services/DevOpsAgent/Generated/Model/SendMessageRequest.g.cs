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

namespace Amazon.DevOpsAgent.Model
{
    /// <summary>
    /// Container for the parameters to the SendMessage operation. Sends a chat message and
    /// streams the response for the specified agent space execution
    /// </summary>
    public partial class SendMessageRequest : AmazonDevOpsAgentRequest
    {
        /// <summary>
        /// Gets and sets the property AgentSpaceId. 
        /// <para>
        /// The agent space identifier
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 2048)]
        public string AgentSpaceId { get; set; }

        /// <summary>
        /// Checks to see if the AgentSpaceId property is set.
        /// </summary>
        internal bool IsSetAgentSpaceId() => this.AgentSpaceId != null;

        /// <summary>
        /// Gets and sets the property AssetIds. 
        /// <para>
        /// Optional list of asset identifiers to attach to the message
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Max = 20)]
        public List<string> AssetIds { get; set; } = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Checks to see if the AssetIds property is set.
        /// </summary>
        internal bool IsSetAssetIds() => this.AssetIds != null && (this.AssetIds.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property Content. 
        /// <para>
        /// The user message content
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Max = 32768)]
        public string Content { get; set; }

        /// <summary>
        /// Checks to see if the Content property is set.
        /// </summary>
        internal bool IsSetContent() => this.Content != null;

        /// <summary>
        /// Gets and sets the property Context. 
        /// <para>
        /// Optional context for the message
        /// </para>
        /// </summary>
        public SendMessageContext Context { get; set; }

        /// <summary>
        /// Checks to see if the Context property is set.
        /// </summary>
        internal bool IsSetContext() => this.Context != null;

        /// <summary>
        /// Gets and sets the property ExecutionId. 
        /// <para>
        /// The execution identifier for the chat session
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 32, Max = 50)]
        public string ExecutionId { get; set; }

        /// <summary>
        /// Checks to see if the ExecutionId property is set.
        /// </summary>
        internal bool IsSetExecutionId() => this.ExecutionId != null;

        /// <summary>
        /// Gets and sets the property ModelTier. 
        /// <para>
        /// Optional model tier selection. Valid values: smart, balanced, fast. Absent or unrecognized
        /// values default to balanced.
        /// </para>
        /// </summary>
        public string ModelTier { get; set; }

        /// <summary>
        /// Checks to see if the ModelTier property is set.
        /// </summary>
        internal bool IsSetModelTier() => this.ModelTier != null;

        /// <summary>
        /// Gets and sets the property UserId. 
        /// <para>
        /// User identifier. This field is deprecated and will be ignored — the service resolves
        /// user identity from the authenticated session.
        /// </para>
        /// </summary>
        [Obsolete("userId is managed by the service and should not be provided by the caller")]
        [AWSProperty(Min = 1, Max = 128)]
        public string UserId { get; set; }

        /// <summary>
        /// Checks to see if the UserId property is set.
        /// </summary>
        internal bool IsSetUserId() => this.UserId != null;
    }
}
