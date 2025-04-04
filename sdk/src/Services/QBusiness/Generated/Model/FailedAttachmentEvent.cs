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
using Amazon.Runtime.EventStreams;
using Amazon.Runtime.EventStreams.Internal;
using Amazon.QBusiness.Model.Internal.MarshallTransformations;
using Amazon.Runtime.EventStreams.Utils;
using Amazon.Runtime.Internal.Util;

#pragma warning disable CS0612,CS0618,CS1570
namespace Amazon.QBusiness.Model
{
    /// <summary>
    /// A failed file upload during web experience chat.
    /// </summary>
    public partial class FailedAttachmentEvent
        : IEventStreamEvent
    {
        private AttachmentOutput _attachment;
        private string _conversationId;
        private string _systemMessageId;
        private string _userMessageId;

        /// <summary>
        /// Gets and sets the property Attachment.
        /// </summary>
        public AttachmentOutput Attachment
        {
            get { return this._attachment; }
            set { this._attachment = value; }
        }

        // Check to see if Attachment property is set
        internal bool IsSetAttachment()
        {
            return this._attachment != null;
        }

        /// <summary>
        /// Gets and sets the property ConversationId. 
        /// <para>
        ///  The identifier of the conversation associated with the failed file upload.
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
        /// Gets and sets the property SystemMessageId. 
        /// <para>
        /// The identifier of the AI-generated message associated with the file upload.
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
        /// The identifier of the end user chat message associated with the file upload.
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