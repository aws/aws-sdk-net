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
using Amazon.Runtime.EventStreams;
using Amazon.Runtime.EventStreams.Internal;
using Amazon.BedrockAgentCore.Model.Internal.MarshallTransformations;
using Amazon.Runtime.EventStreams.Utils;
using Amazon.Runtime.Internal.Util;

#pragma warning disable CS0612,CS0618,CS1570
namespace Amazon.BedrockAgentCore.Model
{
    /// <summary>
    /// Event indicating the end of a message.
    /// </summary>
    public partial class HarnessMessageStopEvent
        : IEventStreamEvent
    {
        private HarnessStopReason _stopReason;

        /// <summary>
        /// Gets and sets the property StopReason. 
        /// <para>
        /// The reason the agent stopped generating.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public HarnessStopReason StopReason
        {
            get { return this._stopReason; }
            set { this._stopReason = value; }
        }

        // Check to see if StopReason property is set
        internal bool IsSetStopReason()
        {
            return this._stopReason != null;
        }

    }
}