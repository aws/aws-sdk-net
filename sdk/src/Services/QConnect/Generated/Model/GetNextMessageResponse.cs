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
 * Do not modify this file. This file is generated from the qconnect-2020-10-19.normal.json service model.
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
        private List<RuntimeSessionData> _conversationSessionData = AWSConfigs.InitializeCollections ? new List<RuntimeSessionData>() : null;
        private ConversationState _conversationState;
        private string _nextMessageToken;
        private string _requestMessageId;
        private MessageOutput _response;
        private MessageType _type;

        /// <summary>
        /// Gets and sets the property ConversationSessionData. 
        /// <para>
        /// The conversation data stored on an Amazon Q in Connect Session.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min=0, Max=50)]
        public List<RuntimeSessionData> ConversationSessionData
        {
            get { return this._conversationSessionData; }
            set { this._conversationSessionData = value; }
        }

        // Check to see if ConversationSessionData property is set
        internal bool IsSetConversationSessionData()
        {
            return this._conversationSessionData != null && (this._conversationSessionData.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property ConversationState. 
        /// <para>
        /// The state of current conversation.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public ConversationState ConversationState
        {
            get { return this._conversationState; }
            set { this._conversationState = value; }
        }

        // Check to see if ConversationState property is set
        internal bool IsSetConversationState()
        {
            return this._conversationState != null;
        }

        /// <summary>
        /// Gets and sets the property NextMessageToken. 
        /// <para>
        /// The token for the next message.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=2048)]
        public string NextMessageToken
        {
            get { return this._nextMessageToken; }
            set { this._nextMessageToken = value; }
        }

        // Check to see if NextMessageToken property is set
        internal bool IsSetNextMessageToken()
        {
            return this._nextMessageToken != null;
        }

        /// <summary>
        /// Gets and sets the property RequestMessageId. 
        /// <para>
        /// The identifier of the submitted message.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string RequestMessageId
        {
            get { return this._requestMessageId; }
            set { this._requestMessageId = value; }
        }

        // Check to see if RequestMessageId property is set
        internal bool IsSetRequestMessageId()
        {
            return this._requestMessageId != null;
        }

        /// <summary>
        /// Gets and sets the property Response. 
        /// <para>
        /// The message response to the requested message.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public MessageOutput Response
        {
            get { return this._response; }
            set { this._response = value; }
        }

        // Check to see if Response property is set
        internal bool IsSetResponse()
        {
            return this._response != null;
        }

        /// <summary>
        /// Gets and sets the property Type. 
        /// <para>
        /// The type of message response.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public MessageType Type
        {
            get { return this._type; }
            set { this._type = value; }
        }

        // Check to see if Type property is set
        internal bool IsSetType()
        {
            return this._type != null;
        }

    }
}