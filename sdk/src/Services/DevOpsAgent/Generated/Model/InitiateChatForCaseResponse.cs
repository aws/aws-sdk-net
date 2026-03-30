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
 * Do not modify this file. This file is generated from the devops-agent-2026-01-01.normal.json service model.
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
namespace Amazon.DevOpsAgent.Model
{
    /// <summary>
    /// Response structure containing the chat participant connection
    /// </summary>
    public partial class InitiateChatForCaseResponse : AmazonWebServiceResponse
    {
        private ChatParticipantConnection _chatParticipantConnection;

        /// <summary>
        /// Gets and sets the property ChatParticipantConnection. 
        /// <para>
        /// The newly created chat participant connection
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public ChatParticipantConnection ChatParticipantConnection
        {
            get { return this._chatParticipantConnection; }
            set { this._chatParticipantConnection = value; }
        }

        // Check to see if ChatParticipantConnection property is set
        internal bool IsSetChatParticipantConnection()
        {
            return this._chatParticipantConnection != null;
        }

    }
}