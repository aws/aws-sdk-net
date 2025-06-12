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
 * Do not modify this file. This file is generated from the ssm-incidents-2018-05-10.normal.json service model.
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
namespace Amazon.SSMIncidents.Model
{
    /// <summary>
    /// The Chatbot chat channel used for collaboration during an incident.
    /// </summary>
    public partial class ChatChannel
    {
        private List<string> _chatbotSns = AWSConfigs.InitializeCollections ? new List<string>() : null;
        private EmptyChatChannel _empty;

        /// <summary>
        /// Gets and sets the property ChatbotSns. 
        /// <para>
        /// The Amazon SNS targets that Chatbot uses to notify the chat channel of updates to
        /// an incident. You can also make updates to the incident through the chat channel by
        /// using the Amazon SNS topics. 
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min=1, Max=5)]
        public List<string> ChatbotSns
        {
            get { return this._chatbotSns; }
            set { this._chatbotSns = value; }
        }

        // Check to see if ChatbotSns property is set
        internal bool IsSetChatbotSns()
        {
            return this._chatbotSns != null && (this._chatbotSns.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property Empty. 
        /// <para>
        /// Used to remove the chat channel from an incident record or response plan.
        /// </para>
        /// </summary>
        public EmptyChatChannel Empty
        {
            get { return this._empty; }
            set { this._empty = value; }
        }

        // Check to see if Empty property is set
        internal bool IsSetEmpty()
        {
            return this._empty != null;
        }

    }
}