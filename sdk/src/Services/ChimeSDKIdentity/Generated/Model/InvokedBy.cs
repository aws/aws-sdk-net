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
 * Do not modify this file. This file is generated from the chime-sdk-identity-2021-04-20.normal.json service model.
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
namespace Amazon.ChimeSDKIdentity.Model
{
    /// <summary>
    /// Specifies the type of message that triggers a bot.
    /// </summary>
    public partial class InvokedBy
    {
        private StandardMessages _standardMessages;
        private TargetedMessages _targetedMessages;

        /// <summary>
        /// Gets and sets the property StandardMessages. 
        /// <para>
        /// Sets standard messages as the bot trigger. For standard messages:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <c>ALL</c>: The bot processes all standard messages.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>AUTO</c>: The bot responds to ALL messages when the channel has one other non-hidden
        /// member, and responds to MENTIONS when the channel has more than one other non-hidden
        /// member.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>MENTIONS</c>: The bot processes all standard messages that have a message attribute
        /// with <c>CHIME.mentions</c> and a value of the bot ARN.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>NONE</c>: The bot processes no standard messages.
        /// </para>
        ///  </li> </ul>
        /// </summary>
        [AWSProperty(Required=true)]
        public StandardMessages StandardMessages
        {
            get { return this._standardMessages; }
            set { this._standardMessages = value; }
        }

        // Check to see if StandardMessages property is set
        internal bool IsSetStandardMessages()
        {
            return this._standardMessages != null;
        }

        /// <summary>
        /// Gets and sets the property TargetedMessages. 
        /// <para>
        /// Sets targeted messages as the bot trigger. For targeted messages:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <c>ALL</c>: The bot processes all <c>TargetedMessages</c> sent to it. The bot then
        /// responds with a targeted message back to the sender. 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>NONE</c>: The bot processes no targeted messages.
        /// </para>
        ///  </li> </ul>
        /// </summary>
        [AWSProperty(Required=true)]
        public TargetedMessages TargetedMessages
        {
            get { return this._targetedMessages; }
            set { this._targetedMessages = value; }
        }

        // Check to see if TargetedMessages property is set
        internal bool IsSetTargetedMessages()
        {
            return this._targetedMessages != null;
        }

    }
}