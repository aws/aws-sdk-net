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

namespace Amazon.SSMIncidents.Model
{
    /// <summary>
    /// The AWS Chatbot chat channel used for collaboration during an incident.
    /// </summary>
    public partial class ChatChannel
    {
        private List<string> _chatbotSns = new List<string>();
        private EmptyChatChannel _empty;

        /// <summary>
        /// Gets and sets the property ChatbotSns. 
        /// <para>
        /// The SNS targets that AWS Chatbot uses to notify the chat channel of updates to an
        /// incident. You can also make updates to the incident through the chat channel by using
        /// the SNS topics. 
        /// </para>
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
            return this._chatbotSns != null && this._chatbotSns.Count > 0; 
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