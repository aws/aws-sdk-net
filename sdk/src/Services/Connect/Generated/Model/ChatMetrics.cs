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
    /// Information about how agent, bot, and customer interact in a chat contact.
    /// </summary>
    public partial class ChatMetrics
    {
        private ParticipantMetrics _agentMetrics;
        private ChatContactMetrics _chatContactMetrics;
        private ParticipantMetrics _customerMetrics;

        /// <summary>
        /// Gets and sets the property AgentMetrics. 
        /// <para>
        /// Information about agent interactions in a contact.
        /// </para>
        /// </summary>
        public ParticipantMetrics AgentMetrics
        {
            get { return this._agentMetrics; }
            set { this._agentMetrics = value; }
        }

        // Check to see if AgentMetrics property is set
        internal bool IsSetAgentMetrics()
        {
            return this._agentMetrics != null;
        }

        /// <summary>
        /// Gets and sets the property ChatContactMetrics. 
        /// <para>
        /// Information about the overall participant interactions at the contact level.
        /// </para>
        /// </summary>
        public ChatContactMetrics ChatContactMetrics
        {
            get { return this._chatContactMetrics; }
            set { this._chatContactMetrics = value; }
        }

        // Check to see if ChatContactMetrics property is set
        internal bool IsSetChatContactMetrics()
        {
            return this._chatContactMetrics != null;
        }

        /// <summary>
        /// Gets and sets the property CustomerMetrics. 
        /// <para>
        /// Information about customer interactions in a contact.
        /// </para>
        /// </summary>
        public ParticipantMetrics CustomerMetrics
        {
            get { return this._customerMetrics; }
            set { this._customerMetrics = value; }
        }

        // Check to see if CustomerMetrics property is set
        internal bool IsSetCustomerMetrics()
        {
            return this._customerMetrics != null;
        }

    }
}