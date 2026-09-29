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
    /// An output event for an AI-generated response in an Amazon Q Business web experience.
    /// </summary>
    public partial class TextOutputEvent : Amazon.Runtime.EventStreams.IEventStreamEvent
    {
        /// <summary>
        /// Gets and sets the property ConversationId. 
        /// <para>
        /// The identifier of the conversation with which the text output event is associated.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 36, Max = 36)]
        public string ConversationId { get; set; }

        /// <summary>
        /// Checks to see if the ConversationId property is set.
        /// </summary>
        internal bool IsSetConversationId() => this.ConversationId != null;

        /// <summary>
        /// Gets and sets the property SystemMessage. 
        /// <para>
        /// An AI-generated message in a <c>TextOutputEvent</c>.
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
        /// The identifier of an AI-generated message in a <c>TextOutputEvent</c>.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 36, Max = 36)]
        public string SystemMessageId { get; set; }

        /// <summary>
        /// Checks to see if the SystemMessageId property is set.
        /// </summary>
        internal bool IsSetSystemMessageId() => this.SystemMessageId != null;

        /// <summary>
        /// Gets and sets the property SystemMessageType. 
        /// <para>
        /// The type of AI-generated message in a <c>TextOutputEvent</c>. Amazon Q Business currently
        /// supports two types of messages:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <c>RESPONSE</c> - The Amazon Q Business system response.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>GROUNDED_RESPONSE</c> - The corrected, hallucination-reduced, response returned
        /// by Amazon Q Business. Available only if hallucination reduction is supported and configured
        /// for the application and detected in the end user chat query by Amazon Q Business.
        /// </para>
        ///  </li> </ul>
        /// </summary>
        public SystemMessageType SystemMessageType { get; set; }

        /// <summary>
        /// Checks to see if the SystemMessageType property is set.
        /// </summary>
        internal bool IsSetSystemMessageType() => this.SystemMessageType != null;

        /// <summary>
        /// Gets and sets the property UserMessageId. 
        /// <para>
        /// The identifier of an end user message in a <c>TextOutputEvent</c>.
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
