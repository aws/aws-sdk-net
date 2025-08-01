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
    /// The configuration for a stream that enables programmatic control of a browser session
    /// in Amazon Bedrock. This stream provides a bidirectional communication channel for
    /// sending commands to the browser and receiving responses, allowing agents to automate
    /// web interactions such as navigation, form filling, and element clicking.
    /// </summary>
    public partial class AutomationStream
    {
        private string _streamEndpoint;
        private AutomationStreamStatus _streamStatus;

        /// <summary>
        /// Gets and sets the property StreamEndpoint. 
        /// <para>
        /// The endpoint URL for the automation stream. This URL is used to establish a WebSocket
        /// connection to the stream for sending commands and receiving responses.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=10, Max=512)]
        public string StreamEndpoint
        {
            get { return this._streamEndpoint; }
            set { this._streamEndpoint = value; }
        }

        // Check to see if StreamEndpoint property is set
        internal bool IsSetStreamEndpoint()
        {
            return this._streamEndpoint != null;
        }

        /// <summary>
        /// Gets and sets the property StreamStatus. 
        /// <para>
        /// The current status of the automation stream. This indicates whether the stream is
        /// available for use. Possible values include ACTIVE, CONNECTING, and DISCONNECTED.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public AutomationStreamStatus StreamStatus
        {
            get { return this._streamStatus; }
            set { this._streamStatus = value; }
        }

        // Check to see if StreamStatus property is set
        internal bool IsSetStreamStatus()
        {
            return this._streamStatus != null;
        }

    }
}