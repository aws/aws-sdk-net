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
 * Do not modify this file. This file is generated from the chime-2018-05-01.normal.json service model.
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
namespace Amazon.Chime.Model
{
    /// <summary>
    /// The retention settings for an Amazon Chime Enterprise account that determine how long
    /// to retain items such as chat-room messages and chat-conversation messages.
    /// </summary>
    public partial class RetentionSettings
    {
        private ConversationRetentionSettings _conversationRetentionSettings;
        private RoomRetentionSettings _roomRetentionSettings;

        /// <summary>
        /// Gets and sets the property ConversationRetentionSettings. 
        /// <para>
        /// The chat conversation retention settings.
        /// </para>
        /// </summary>
        public ConversationRetentionSettings ConversationRetentionSettings
        {
            get { return this._conversationRetentionSettings; }
            set { this._conversationRetentionSettings = value; }
        }

        // Check to see if ConversationRetentionSettings property is set
        internal bool IsSetConversationRetentionSettings()
        {
            return this._conversationRetentionSettings != null;
        }

        /// <summary>
        /// Gets and sets the property RoomRetentionSettings. 
        /// <para>
        /// The chat room retention settings.
        /// </para>
        /// </summary>
        public RoomRetentionSettings RoomRetentionSettings
        {
            get { return this._roomRetentionSettings; }
            set { this._roomRetentionSettings = value; }
        }

        // Check to see if RoomRetentionSettings property is set
        internal bool IsSetRoomRetentionSettings()
        {
            return this._roomRetentionSettings != null;
        }

    }
}