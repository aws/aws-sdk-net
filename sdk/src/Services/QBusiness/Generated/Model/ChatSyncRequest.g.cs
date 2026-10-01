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
    /// Container for the parameters to the ChatSync operation. Starts or continues a non-streaming
    /// Amazon Q Business conversation.
    /// </summary>
    public partial class ChatSyncRequest : AmazonQBusinessRequest
    {
        /// <summary>
        /// Gets and sets the property ActionExecution. 
        /// <para>
        /// A request from an end user to perform an Amazon Q Business plugin action.
        /// </para>
        /// </summary>
        public ActionExecution ActionExecution { get; set; }

        /// <summary>
        /// Checks to see if the ActionExecution property is set.
        /// </summary>
        internal bool IsSetActionExecution() => this.ActionExecution != null;

        /// <summary>
        /// Gets and sets the property ApplicationId. 
        /// <para>
        /// The identifier of the Amazon Q Business application linked to the Amazon Q Business
        /// conversation.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 36, Max = 36)]
        public string ApplicationId { get; set; }

        /// <summary>
        /// Checks to see if the ApplicationId property is set.
        /// </summary>
        internal bool IsSetApplicationId() => this.ApplicationId != null;

        /// <summary>
        /// Gets and sets the property Attachments. 
        /// <para>
        /// A list of files uploaded directly during chat. You can upload a maximum of 5 files
        /// of upto 10 MB each.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min = 1)]
        public List<AttachmentInput> Attachments { get; set; } = AWSConfigs.InitializeCollections ? new List<AttachmentInput>() : null;

        /// <summary>
        /// Checks to see if the Attachments property is set.
        /// </summary>
        internal bool IsSetAttachments() => this.Attachments != null && (this.Attachments.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property AttributeFilter. 
        /// <para>
        /// Enables filtering of Amazon Q Business web experience responses based on document
        /// attributes or metadata fields.
        /// </para>
        /// </summary>
        public AttributeFilter AttributeFilter { get; set; }

        /// <summary>
        /// Checks to see if the AttributeFilter property is set.
        /// </summary>
        internal bool IsSetAttributeFilter() => this.AttributeFilter != null;

        /// <summary>
        /// Gets and sets the property AuthChallengeResponse. 
        /// <para>
        /// An authentication verification event response by a third party authentication server
        /// to Amazon Q Business.
        /// </para>
        /// </summary>
        public AuthChallengeResponse AuthChallengeResponse { get; set; }

        /// <summary>
        /// Checks to see if the AuthChallengeResponse property is set.
        /// </summary>
        internal bool IsSetAuthChallengeResponse() => this.AuthChallengeResponse != null;

        /// <summary>
        /// Gets and sets the property ChatMode. 
        /// <para>
        /// The <c>chatMode</c> parameter determines the chat modes available to Amazon Q Business
        /// users:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <c>RETRIEVAL_MODE</c> - If you choose this mode, Amazon Q generates responses solely
        /// from the data sources connected and indexed by the application. If an answer is not
        /// found in the data sources or there are no data sources available, Amazon Q will respond
        /// with a "<i>No Answer Found</i>" message, unless LLM knowledge has been enabled. In
        /// that case, Amazon Q will generate a response from the LLM knowledge
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>CREATOR_MODE</c> - By selecting this mode, you can choose to generate responses
        /// only from the LLM knowledge. You can also attach files and have Amazon Q generate
        /// a response based on the data in those files. If the attached files do not contain
        /// an answer for the query, Amazon Q will automatically fall back to generating a response
        /// from the LLM knowledge.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>PLUGIN_MODE</c> - By selecting this mode, users can choose to use plugins in chat
        /// to get their responses.
        /// </para>
        ///  </li> </ul> <note> 
        /// <para>
        /// If none of the modes are selected, Amazon Q will only respond using the information
        /// from the attached files.
        /// </para>
        ///  </note> 
        /// <para>
        /// For more information, see <a href="https://docs.aws.amazon.com/amazonq/latest/qbusiness-ug/guardrails.html">Admin
        /// controls and guardrails</a>, <a href="https://docs.aws.amazon.com/amazonq/latest/qbusiness-ug/plugins.html">Plugins</a>,
        /// and <a href="https://docs.aws.amazon.com/amazonq/latest/business-use-dg/using-web-experience.html#chat-source-scope">Response
        /// sources</a>.
        /// </para>
        /// </summary>
        public ChatMode ChatMode { get; set; }

        /// <summary>
        /// Checks to see if the ChatMode property is set.
        /// </summary>
        internal bool IsSetChatMode() => this.ChatMode != null;

        /// <summary>
        /// Gets and sets the property ChatModeConfiguration. 
        /// <para>
        /// The chat mode configuration for an Amazon Q Business application.
        /// </para>
        /// </summary>
        public ChatModeConfiguration ChatModeConfiguration { get; set; }

        /// <summary>
        /// Checks to see if the ChatModeConfiguration property is set.
        /// </summary>
        internal bool IsSetChatModeConfiguration() => this.ChatModeConfiguration != null;

        /// <summary>
        /// Gets and sets the property ClientToken. 
        /// <para>
        /// A token that you provide to identify a chat request.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 100)]
        public string ClientToken { get; set; }

        /// <summary>
        /// Checks to see if the ClientToken property is set.
        /// </summary>
        internal bool IsSetClientToken() => this.ClientToken != null;

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
        /// Gets and sets the property ParentMessageId. 
        /// <para>
        /// The identifier of the previous system message in a conversation.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 36, Max = 36)]
        public string ParentMessageId { get; set; }

        /// <summary>
        /// Checks to see if the ParentMessageId property is set.
        /// </summary>
        internal bool IsSetParentMessageId() => this.ParentMessageId != null;

        /// <summary>
        /// Gets and sets the property UserGroups. 
        /// <para>
        /// The group names that a user associated with the chat input belongs to.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<string> UserGroups { get; set; } = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Checks to see if the UserGroups property is set.
        /// </summary>
        internal bool IsSetUserGroups() => this.UserGroups != null && (this.UserGroups.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property UserId. 
        /// <para>
        /// The identifier of the user attached to the chat input.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 1024)]
        public string UserId { get; set; }

        /// <summary>
        /// Checks to see if the UserId property is set.
        /// </summary>
        internal bool IsSetUserId() => this.UserId != null;

        /// <summary>
        /// Gets and sets the property UserMessage. 
        /// <para>
        /// A end user message in a conversation.
        /// </para>
        /// </summary>
        public string UserMessage { get; set; }

        /// <summary>
        /// Checks to see if the UserMessage property is set.
        /// </summary>
        internal bool IsSetUserMessage() => this.UserMessage != null;
    }
}
