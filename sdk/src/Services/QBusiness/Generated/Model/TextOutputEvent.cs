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
    /// An output event for an AI-generated response in an Amazon Q Business web experience.
    /// </summary>
    public partial class TextOutputEvent
        : IEventStreamEvent
    {
        private string _conversationId;
        private string _systemMessage;
        private string _systemMessageId;
        private SystemMessageType _systemMessageType;
        private string _userMessageId;

        /// <summary>
        /// Gets and sets the property ConversationId. 
        /// <para>
        /// The identifier of the conversation with which the text output event is associated.
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
        /// Gets and sets the property SystemMessage. 
        /// <para>
        /// An AI-generated message in a <c>TextOutputEvent</c>.
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
        /// The identifier of an AI-generated message in a <c>TextOutputEvent</c>.
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
        public SystemMessageType SystemMessageType
        {
            get { return this._systemMessageType; }
            set { this._systemMessageType = value; }
        }

        // Check to see if SystemMessageType property is set
        internal bool IsSetSystemMessageType()
        {
            return this._systemMessageType != null;
        }

        /// <summary>
        /// Gets and sets the property UserMessageId. 
        /// <para>
        /// The identifier of an end user message in a <c>TextOutputEvent</c>.
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