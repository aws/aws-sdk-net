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
 * Do not modify this file. This file is generated from the bedrock-agentcore-2024-02-28.normal.json service model.
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
namespace Amazon.BedrockAgentCore.Model
{
    /// <summary>
    /// Metadata information associated with this message.
    /// </summary>
    public partial class MessageMetadata
    {
        private string _eventId;
        private int? _messageIndex;

        /// <summary>
        /// Gets and sets the property EventId. 
        /// <para>
        /// The identifier of the event associated with this message.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string EventId
        {
            get { return this._eventId; }
            set { this._eventId = value; }
        }

        // Check to see if EventId property is set
        internal bool IsSetEventId()
        {
            return this._eventId != null;
        }

        /// <summary>
        /// Gets and sets the property MessageIndex. 
        /// <para>
        /// The position of this message within that event’s ordered list of messages.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public int MessageIndex
        {
            get { return this._messageIndex.GetValueOrDefault(); }
            set { this._messageIndex = value; }
        }

        // Check to see if MessageIndex property is set
        internal bool IsSetMessageIndex()
        {
            return this._messageIndex.HasValue; 
        }

    }
}