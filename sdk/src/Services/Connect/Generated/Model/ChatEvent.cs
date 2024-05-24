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
 * Do not modify this file. This file is generated from the connect-2017-08-08.normal.json service model.
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
namespace Amazon.Connect.Model
{
    /// <summary>
    /// Chat integration event containing payload to perform different chat actions such as:
    /// 
    ///  <ul> <li> 
    /// <para>
    /// Sending a chat message
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// Sending a chat event, such as typing
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// Disconnecting from a chat
    /// </para>
    ///  </li> </ul>
    /// </summary>
    public partial class ChatEvent
    {
        private string _content;
        private string _contentType;
        private ChatEventType _type;

        /// <summary>
        /// Gets and sets the property Content. 
        /// <para>
        /// Content of the message or event. This is required when <c>Type</c> is <c>MESSAGE</c>
        /// and for certain <c>ContentTypes</c> when <c>Type</c> is <c>EVENT</c>.
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// For allowed message content, see the <c>Content</c> parameter in the <a href="https://docs.aws.amazon.com/connect-participant/latest/APIReference/API_SendMessage.html">SendMessage</a>
        /// topic in the <i>Amazon Connect Participant Service API Reference</i>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// For allowed event content, see the <c>Content</c> parameter in the <a href="https://docs.aws.amazon.com/connect-participant/latest/APIReference/API_SendEvent.html">SendEvent</a>
        /// topic in the <i>Amazon Connect Participant Service API Reference</i>. 
        /// </para>
        ///  </li> </ul>
        /// </summary>
        [AWSProperty(Min=1, Max=16384)]
        public string Content
        {
            get { return this._content; }
            set { this._content = value; }
        }

        // Check to see if Content property is set
        internal bool IsSetContent()
        {
            return this._content != null;
        }

        /// <summary>
        /// Gets and sets the property ContentType. 
        /// <para>
        /// Type of content. This is required when <c>Type</c> is <c>MESSAGE</c> or <c>EVENT</c>.
        /// 
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// For allowed message content types, see the <c>ContentType</c> parameter in the <a
        /// href="https://docs.aws.amazon.com/connect-participant/latest/APIReference/API_SendMessage.html">SendMessage</a>
        /// topic in the <i>Amazon Connect Participant Service API Reference</i>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// For allowed event content types, see the <c>ContentType</c> parameter in the <a href="https://docs.aws.amazon.com/connect-participant/latest/APIReference/API_SendEvent.html">SendEvent</a>
        /// topic in the <i>Amazon Connect Participant Service API Reference</i>. 
        /// </para>
        ///  </li> </ul>
        /// </summary>
        [AWSProperty(Min=1, Max=100)]
        public string ContentType
        {
            get { return this._contentType; }
            set { this._contentType = value; }
        }

        // Check to see if ContentType property is set
        internal bool IsSetContentType()
        {
            return this._contentType != null;
        }

        /// <summary>
        /// Gets and sets the property Type. 
        /// <para>
        /// Type of chat integration event. 
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public ChatEventType Type
        {
            get { return this._type; }
            set { this._type = value; }
        }

        // Check to see if Type property is set
        internal bool IsSetType()
        {
            return this._type != null;
        }

    }
}