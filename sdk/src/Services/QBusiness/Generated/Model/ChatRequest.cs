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
 * Do not modify this file. This file is generated from the qbusiness-2023-11-27.normal.json service model.
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
namespace Amazon.QBusiness.Model
{
    /// <summary>
    /// Container for the parameters to the Chat operation.
    /// Starts or continues a streaming Amazon Q Business conversation.
    /// </summary>
    public partial class ChatRequest : AmazonQBusinessRequest
    {
        private string _applicationId;
        private string _clientToken;
        private string _conversationId;
        private string _parentMessageId;
        private List<string> _userGroups = AWSConfigs.InitializeCollections ? new List<string>() : null;
        private string _userId;

        /// <summary>
        /// Gets and sets the property ApplicationId. 
        /// <para>
        /// The identifier of the Amazon Q Business application linked to a streaming Amazon Q
        /// Business conversation.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=36, Max=36)]
        public string ApplicationId
        {
            get { return this._applicationId; }
            set { this._applicationId = value; }
        }

        // Check to see if ApplicationId property is set
        internal bool IsSetApplicationId()
        {
            return this._applicationId != null;
        }

        /// <summary>
        /// Gets and sets the property ClientToken. 
        /// <para>
        /// A token that you provide to identify the chat input.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=100)]
        public string ClientToken
        {
            get { return this._clientToken; }
            set { this._clientToken = value; }
        }

        // Check to see if ClientToken property is set
        internal bool IsSetClientToken()
        {
            return this._clientToken != null;
        }

        /// <summary>
        /// Gets and sets the property ConversationId. 
        /// <para>
        /// The identifier of the Amazon Q Business conversation.
        /// </para>
        /// </summary>
        [AWSProperty(Min=36, Max=36)]
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
        /// Gets and sets the property InputStreamPublisher. 
        /// <para>
        /// The streaming input for the <c>Chat</c> API.
        /// </para>
        /// <para>
        /// The Func set for this property by the consumer of the SDK is used to stream events into the service. Consumers
        /// provide a Func that the SDK will continue to call to get events to send. When the consumer is done streaming
        /// events to the service the Func can return null to stop the SDK calling the Func for new events. The Func must
        /// return an event known by the service which can be identified by implementing the IChatInputStreamEvent
        /// interface. The known implementatons in the SDK for this interface are:
        /// <list type="bullet">
        ///   <item><term><see cref="ActionExecutionEvent"/></term></item>
        ///   <item><term><see cref="AttachmentInputEvent"/></term></item>
        ///   <item><term><see cref="AuthChallengeResponseEvent"/></term></item>
        ///   <item><term><see cref="ConfigurationEvent"/></term></item>
        ///   <item><term><see cref="EndOfInputEvent"/></term></item>
        ///   <item><term><see cref="TextInputEvent"/></term></item>
        /// </list>
        /// </para>
        /// 
        /// </summary>
        public  Func<System.Threading.Tasks.Task<IChatInputStreamEvent>> InputStreamPublisher { get; set; }

        /// <summary>
        /// Gets and sets the property ParentMessageId. 
        /// <para>
        /// The identifier used to associate a user message with a AI generated response.
        /// </para>
        /// </summary>
        [AWSProperty(Min=36, Max=36)]
        public string ParentMessageId
        {
            get { return this._parentMessageId; }
            set { this._parentMessageId = value; }
        }

        // Check to see if ParentMessageId property is set
        internal bool IsSetParentMessageId()
        {
            return this._parentMessageId != null;
        }

        /// <summary>
        /// Gets and sets the property UserGroups. 
        /// <para>
        /// The group names that a user associated with the chat input belongs to.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<string> UserGroups
        {
            get { return this._userGroups; }
            set { this._userGroups = value; }
        }

        // Check to see if UserGroups property is set
        internal bool IsSetUserGroups()
        {
            return this._userGroups != null && (this._userGroups.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property UserId. 
        /// <para>
        /// The identifier of the user attached to the chat input. 
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=1024)]
        public string UserId
        {
            get { return this._userId; }
            set { this._userId = value; }
        }

        // Check to see if UserId property is set
        internal bool IsSetUserId()
        {
            return this._userId != null;
        }

    }
}