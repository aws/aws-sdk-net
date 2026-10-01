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
    /// Container for the parameters to the PutFeedback operation. Enables your end user to
    /// provide feedback on their Amazon Q Business generated chat responses.
    /// </summary>
    public partial class PutFeedbackRequest : AmazonQBusinessRequest
    {
        /// <summary>
        /// Gets and sets the property ApplicationId. 
        /// <para>
        /// The identifier of the application associated with the feedback.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 36, Max = 36)]
        public string ApplicationId { get; set; }

        /// <summary>
        /// Checks to see if the ApplicationId property is set.
        /// </summary>
        internal bool IsSetApplicationId() => this.ApplicationId != null;

        /// <summary>
        /// Gets and sets the property ConversationId. 
        /// <para>
        /// The identifier of the conversation the feedback is attached to.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 36, Max = 36)]
        public string ConversationId { get; set; }

        /// <summary>
        /// Checks to see if the ConversationId property is set.
        /// </summary>
        internal bool IsSetConversationId() => this.ConversationId != null;

        /// <summary>
        /// Gets and sets the property MessageCopiedAt. 
        /// <para>
        /// The timestamp for when the feedback was recorded.
        /// </para>
        /// </summary>
        public DateTime? MessageCopiedAt { get; set; }

        /// <summary>
        /// Checks to see if the MessageCopiedAt property is set.
        /// </summary>
        internal bool IsSetMessageCopiedAt() => this.MessageCopiedAt.HasValue;

        /// <summary>
        /// Gets and sets the property MessageId. 
        /// <para>
        /// The identifier of the chat message that the feedback was given for.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 36, Max = 36)]
        public string MessageId { get; set; }

        /// <summary>
        /// Checks to see if the MessageId property is set.
        /// </summary>
        internal bool IsSetMessageId() => this.MessageId != null;

        /// <summary>
        /// Gets and sets the property MessageUsefulness. 
        /// <para>
        /// The feedback usefulness value given by the user to the chat message.
        /// </para>
        /// </summary>
        public MessageUsefulnessFeedback MessageUsefulness { get; set; }

        /// <summary>
        /// Checks to see if the MessageUsefulness property is set.
        /// </summary>
        internal bool IsSetMessageUsefulness() => this.MessageUsefulness != null;

        /// <summary>
        /// Gets and sets the property UserId. 
        /// <para>
        /// The identifier of the user giving the feedback.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 1024)]
        public string UserId { get; set; }

        /// <summary>
        /// Checks to see if the UserId property is set.
        /// </summary>
        internal bool IsSetUserId() => this.UserId != null;
    }
}
