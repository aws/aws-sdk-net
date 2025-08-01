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
    /// The configuration for a stream that provides a visual representation of a browser
    /// session in Amazon Bedrock. This stream enables agents to observe the current state
    /// of the browser, including rendered web pages, visual elements, and the results of
    /// interactions.
    /// </summary>
    public partial class LiveViewStream
    {
        private string _streamEndpoint;

        /// <summary>
        /// Gets and sets the property StreamEndpoint. 
        /// <para>
        /// The endpoint URL for the live view stream. This URL is used to establish a connection
        /// to receive visual updates from the browser session.
        /// </para>
        /// </summary>
        [AWSProperty(Min=10, Max=512)]
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

    }
}