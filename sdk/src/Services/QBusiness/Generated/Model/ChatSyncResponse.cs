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
    /// This is the response object from the ChatSync operation.
    /// </summary>
    public partial class ChatSyncResponse : AmazonWebServiceResponse
    {
        private ActionReview _actionReview;
        private AuthChallengeRequest _authChallengeRequest;
        private string _conversationId;
        private List<AttachmentOutput> _failedAttachments = AWSConfigs.InitializeCollections ? new List<AttachmentOutput>() : null;
        private List<SourceAttribution> _sourceAttributions = AWSConfigs.InitializeCollections ? new List<SourceAttribution>() : null;
        private string _systemMessage;
        private string _systemMessageId;
        private string _userMessageId;

        /// <summary>
        /// Gets and sets the property ActionReview. 
        /// <para>
        /// A request from Amazon Q Business to the end user for information Amazon Q Business
        /// needs to successfully complete a requested plugin action.
        /// </para>
        /// </summary>
        public ActionReview ActionReview
        {
            get { return this._actionReview; }
            set { this._actionReview = value; }
        }

        // Check to see if ActionReview property is set
        internal bool IsSetActionReview()
        {
            return this._actionReview != null;
        }

        /// <summary>
        /// Gets and sets the property AuthChallengeRequest. 
        /// <para>
        /// An authentication verification event activated by an end user request to use a custom
        /// plugin.
        /// </para>
        /// </summary>
        public AuthChallengeRequest AuthChallengeRequest
        {
            get { return this._authChallengeRequest; }
            set { this._authChallengeRequest = value; }
        }

        // Check to see if AuthChallengeRequest property is set
        internal bool IsSetAuthChallengeRequest()
        {
            return this._authChallengeRequest != null;
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
        /// Gets and sets the property FailedAttachments. 
        /// <para>
        /// A list of files which failed to upload during chat.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<AttachmentOutput> FailedAttachments
        {
            get { return this._failedAttachments; }
            set { this._failedAttachments = value; }
        }

        // Check to see if FailedAttachments property is set
        internal bool IsSetFailedAttachments()
        {
            return this._failedAttachments != null && (this._failedAttachments.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property SourceAttributions. 
        /// <para>
        /// The source documents used to generate the conversation response.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<SourceAttribution> SourceAttributions
        {
            get { return this._sourceAttributions; }
            set { this._sourceAttributions = value; }
        }

        // Check to see if SourceAttributions property is set
        internal bool IsSetSourceAttributions()
        {
            return this._sourceAttributions != null && (this._sourceAttributions.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property SystemMessage. 
        /// <para>
        /// An AI-generated message in a conversation.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=2048)]
        public string SystemMessage
        {
            get { return this._systemMessage; }
            set { this._systemMessage = value; }
        }

        // Check to see if SystemMessage property is set
        internal bool IsSetSystemMessage()
        {
            return this._systemMessage != null;
        }

        /// <summary>
        /// Gets and sets the property SystemMessageId. 
        /// <para>
        /// The identifier of an Amazon Q Business AI generated message within the conversation.
        /// </para>
        /// </summary>
        [AWSProperty(Min=36, Max=36)]
        public string SystemMessageId
        {
            get { return this._systemMessageId; }
            set { this._systemMessageId = value; }
        }

        // Check to see if SystemMessageId property is set
        internal bool IsSetSystemMessageId()
        {
            return this._systemMessageId != null;
        }

        /// <summary>
        /// Gets and sets the property UserMessageId. 
        /// <para>
        /// The identifier of an Amazon Q Business end user text input message within the conversation.
        /// </para>
        /// </summary>
        [AWSProperty(Min=36, Max=36)]
        public string UserMessageId
        {
            get { return this._userMessageId; }
            set { this._userMessageId = value; }
        }

        // Check to see if UserMessageId property is set
        internal bool IsSetUserMessageId()
        {
            return this._userMessageId != null;
        }

    }
}