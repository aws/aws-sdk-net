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

namespace Amazon.QBusiness.Model
{
    /// <summary>
    /// This is the response object from the ChatSync operation.
    /// </summary>
    public partial class ChatSyncResponse : AmazonWebServiceResponse
    {
        /// <summary>
        /// Gets and sets the property ActionReview. 
        /// <para>
        /// A request from Amazon Q Business to the end user for information Amazon Q Business
        /// needs to successfully complete a requested plugin action.
        /// </para>
        /// </summary>
        public ActionReview ActionReview { get; set; }

        /// <summary>
        /// Checks to see if the ActionReview property is set.
        /// </summary>
        internal bool IsSetActionReview() => this.ActionReview != null;

        /// <summary>
        /// Gets and sets the property AuthChallengeRequest. 
        /// <para>
        /// An authentication verification event activated by an end user request to use a custom
        /// plugin.
        /// </para>
        /// </summary>
        public AuthChallengeRequest AuthChallengeRequest { get; set; }

        /// <summary>
        /// Checks to see if the AuthChallengeRequest property is set.
        /// </summary>
        internal bool IsSetAuthChallengeRequest() => this.AuthChallengeRequest != null;

        /// <summary>
        /// Gets and sets the property ConversationId. 
        /// <para>
        /// The identifier of the Amazon Q Business conversation.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 36, Max = 36)]
        public string ConversationId { get; set; }

        /// <summary>
        /// Checks to see if the ConversationId property is set.
        /// </summary>
        internal bool IsSetConversationId() => this.ConversationId != null;

        /// <summary>
        /// Gets and sets the property FailedAttachments. 
        /// <para>
        /// A list of files which failed to upload during chat.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<AttachmentOutput> FailedAttachments { get; set; } = AWSConfigs.InitializeCollections ? new List<AttachmentOutput>() : null;

        /// <summary>
        /// Checks to see if the FailedAttachments property is set.
        /// </summary>
        internal bool IsSetFailedAttachments() => this.FailedAttachments != null && (this.FailedAttachments.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property SourceAttributions. 
        /// <para>
        /// The source documents used to generate the conversation response.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<SourceAttribution> SourceAttributions { get; set; } = AWSConfigs.InitializeCollections ? new List<SourceAttribution>() : null;

        /// <summary>
        /// Checks to see if the SourceAttributions property is set.
        /// </summary>
        internal bool IsSetSourceAttributions() => this.SourceAttributions != null && (this.SourceAttributions.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property SystemMessage. 
        /// <para>
        /// An AI-generated message in a conversation.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 2048)]
        public string SystemMessage { get; set; }

        /// <summary>
        /// Checks to see if the SystemMessage property is set.
        /// </summary>
        internal bool IsSetSystemMessage() => this.SystemMessage != null;

        /// <summary>
        /// Gets and sets the property SystemMessageId. 
        /// <para>
        /// The identifier of an Amazon Q Business AI generated message within the conversation.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 36, Max = 36)]
        public string SystemMessageId { get; set; }

        /// <summary>
        /// Checks to see if the SystemMessageId property is set.
        /// </summary>
        internal bool IsSetSystemMessageId() => this.SystemMessageId != null;

        /// <summary>
        /// Gets and sets the property UserMessageId. 
        /// <para>
        /// The identifier of an Amazon Q Business end user text input message within the conversation.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 36, Max = 36)]
        public string UserMessageId { get; set; }

        /// <summary>
        /// Checks to see if the UserMessageId property is set.
        /// </summary>
        internal bool IsSetUserMessageId() => this.UserMessageId != null;
    }
}
