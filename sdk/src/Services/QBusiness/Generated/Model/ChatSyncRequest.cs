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

namespace Amazon.QBusiness.Model
{
    /// <summary>
    /// Container for the parameters to the ChatSync operation.
    /// Starts or continues a non-streaming Amazon Q conversation.
    /// </summary>
    public partial class ChatSyncRequest : AmazonQBusinessRequest
    {
        private ActionExecution _actionExecution;
        private string _applicationId;
        private List<AttachmentInput> _attachments = AWSConfigs.InitializeCollections ? new List<AttachmentInput>() : null;
        private AttributeFilter _attributeFilter;
        private string _clientToken;
        private string _conversationId;
        private string _parentMessageId;
        private List<string> _userGroups = AWSConfigs.InitializeCollections ? new List<string>() : null;
        private string _userId;
        private string _userMessage;

        /// <summary>
        /// Gets and sets the property ActionExecution. 
        /// <para>
        /// A request from an end user to perform an Amazon Q plugin action.
        /// </para>
        /// </summary>
        public ActionExecution ActionExecution
        {
            get { return this._actionExecution; }
            set { this._actionExecution = value; }
        }

        // Check to see if ActionExecution property is set
        internal bool IsSetActionExecution()
        {
            return this._actionExecution != null;
        }

        /// <summary>
        /// Gets and sets the property ApplicationId. 
        /// <para>
        /// The identifier of the Amazon Q application linked to the Amazon Q conversation.
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
        /// Gets and sets the property Attachments. 
        /// <para>
        /// A list of files uploaded directly during chat. You can upload a maximum of 5 files
        /// of upto 10 MB each.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1)]
        public List<AttachmentInput> Attachments
        {
            get { return this._attachments; }
            set { this._attachments = value; }
        }

        // Check to see if Attachments property is set
        internal bool IsSetAttachments()
        {
            return this._attachments != null && (this._attachments.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property AttributeFilter. 
        /// <para>
        /// Enables filtering of Amazon Q web experience responses based on document attributes
        /// or metadata fields.
        /// </para>
        /// </summary>
        public AttributeFilter AttributeFilter
        {
            get { return this._attributeFilter; }
            set { this._attributeFilter = value; }
        }

        // Check to see if AttributeFilter property is set
        internal bool IsSetAttributeFilter()
        {
            return this._attributeFilter != null;
        }

        /// <summary>
        /// Gets and sets the property ClientToken. 
        /// <para>
        /// A token that you provide to identify a chat request.
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
        /// The identifier of the Amazon Q conversation.
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
        /// Gets and sets the property ParentMessageId. 
        /// <para>
        /// The identifier of the previous end user text input message in a conversation.
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
        /// The groups that a user associated with the chat input belongs to.
        /// </para>
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
        [AWSProperty(Required=true, Min=1, Max=1024)]
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

        /// <summary>
        /// Gets and sets the property UserMessage. 
        /// <para>
        /// A end user message in a conversation.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=7000)]
        public string UserMessage
        {
            get { return this._userMessage; }
            set { this._userMessage = value; }
        }

        // Check to see if UserMessage property is set
        internal bool IsSetUserMessage()
        {
            return this._userMessage != null;
        }

    }
}