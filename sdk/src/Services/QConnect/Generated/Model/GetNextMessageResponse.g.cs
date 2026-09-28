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

namespace Amazon.QConnect.Model
{
    /// <summary>
    /// This is the response object from the GetNextMessage operation.
    /// </summary>
    public partial class GetNextMessageResponse : AmazonWebServiceResponse
    {
        /// <summary>
        /// Gets and sets the property ChunkedResponseTerminated. 
        /// <para>
        /// Indicates whether the chunked response has been terminated.
        /// </para>
        /// </summary>
        public bool? ChunkedResponseTerminated { get; set; }

        /// <summary>
        /// Checks to see if the ChunkedResponseTerminated property is set.
        /// </summary>
        internal bool IsSetChunkedResponseTerminated() => this.ChunkedResponseTerminated.HasValue;

        /// <summary>
        /// Gets and sets the property ConversationSessionData. 
        /// <para>
        /// The conversation data stored on an Amazon Q in Connect Session.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min = 0, Max = 50)]
        public List<RuntimeSessionData> ConversationSessionData { get; set; } = AWSConfigs.InitializeCollections ? new List<RuntimeSessionData>() : null;

        /// <summary>
        /// Checks to see if the ConversationSessionData property is set.
        /// </summary>
        internal bool IsSetConversationSessionData() => this.ConversationSessionData != null && (this.ConversationSessionData.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property ConversationState. 
        /// <para>
        /// The state of current conversation.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public ConversationState ConversationState { get; set; }

        /// <summary>
        /// Checks to see if the ConversationState property is set.
        /// </summary>
        internal bool IsSetConversationState() => this.ConversationState != null;

        /// <summary>
        /// Gets and sets the property NextMessageToken. 
        /// <para>
        /// The token for the next message.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 2048)]
        public string NextMessageToken { get; set; }

        /// <summary>
        /// Checks to see if the NextMessageToken property is set.
        /// </summary>
        internal bool IsSetNextMessageToken() => this.NextMessageToken != null;

        /// <summary>
        /// Gets and sets the property RequestMessageId. 
        /// <para>
        /// The identifier of the submitted message.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public string RequestMessageId { get; set; }

        /// <summary>
        /// Checks to see if the RequestMessageId property is set.
        /// </summary>
        internal bool IsSetRequestMessageId() => this.RequestMessageId != null;

        /// <summary>
        /// Gets and sets the property Response. 
        /// <para>
        /// The message response to the requested message.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public MessageOutput Response { get; set; }

        /// <summary>
        /// Checks to see if the Response property is set.
        /// </summary>
        internal bool IsSetResponse() => this.Response != null;

        /// <summary>
        /// Gets and sets the property Type. 
        /// <para>
        /// The type of message response.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public MessageType Type { get; set; }

        /// <summary>
        /// Checks to see if the Type property is set.
        /// </summary>
        internal bool IsSetType() => this.Type != null;
    }
}
