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
    /// A failed file upload during web experience chat.
    /// </summary>
    public partial class FailedAttachmentEvent : Amazon.Runtime.EventStreams.IEventStreamEvent
    {
        /// <summary>
        /// Gets and sets the property Attachment.
        /// </summary>
        public AttachmentOutput Attachment { get; set; }

        /// <summary>
        /// Checks to see if the Attachment property is set.
        /// </summary>
        internal bool IsSetAttachment() => this.Attachment != null;

        /// <summary>
        /// Gets and sets the property ConversationId. 
        /// <para>
        ///  The identifier of the conversation associated with the failed file upload.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 36, Max = 36)]
        public string ConversationId { get; set; }

        /// <summary>
        /// Checks to see if the ConversationId property is set.
        /// </summary>
        internal bool IsSetConversationId() => this.ConversationId != null;

        /// <summary>
        /// Gets and sets the property SystemMessageId. 
        /// <para>
        /// The identifier of the AI-generated message associated with the file upload.
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
        /// The identifier of the end user chat message associated with the file upload.
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
