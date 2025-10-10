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
 * Do not modify this file. This file is generated from the bedrock-agentcore-control-2023-06-05.normal.json service model.
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
namespace Amazon.BedrockAgentCoreControl.Model
{
    /// <summary>
    /// The trigger configuration based on a message.
    /// </summary>
    public partial class MessageBasedTriggerInput
    {
        private int? _messageCount;

        /// <summary>
        /// Gets and sets the property MessageCount. 
        /// <para>
        /// The number of messages that trigger memory processing.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=50)]
        public int MessageCount
        {
            get { return this._messageCount.GetValueOrDefault(); }
            set { this._messageCount = value; }
        }

        // Check to see if MessageCount property is set
        internal bool IsSetMessageCount()
        {
            return this._messageCount.HasValue; 
        }

    }
}