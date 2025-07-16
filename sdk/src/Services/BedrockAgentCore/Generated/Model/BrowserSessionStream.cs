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
    /// The collection of streams associated with a browser session in Amazon Bedrock. These
    /// streams provide different ways to interact with and observe the browser session, including
    /// programmatic control and visual representation of the browser content.
    /// </summary>
    public partial class BrowserSessionStream
    {
        private AutomationStream _automationStream;
        private LiveViewStream _liveViewStream;

        /// <summary>
        /// Gets and sets the property AutomationStream. 
        /// <para>
        /// The stream that enables programmatic control of the browser. This stream allows agents
        /// to perform actions such as navigating to URLs, clicking elements, and filling forms.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public AutomationStream AutomationStream
        {
            get { return this._automationStream; }
            set { this._automationStream = value; }
        }

        // Check to see if AutomationStream property is set
        internal bool IsSetAutomationStream()
        {
            return this._automationStream != null;
        }

        /// <summary>
        /// Gets and sets the property LiveViewStream. 
        /// <para>
        /// The stream that provides a visual representation of the browser content. This stream
        /// allows agents to observe the current state of the browser, including rendered web
        /// pages and visual elements.
        /// </para>
        /// </summary>
        public LiveViewStream LiveViewStream
        {
            get { return this._liveViewStream; }
            set { this._liveViewStream = value; }
        }

        // Check to see if LiveViewStream property is set
        internal bool IsSetLiveViewStream()
        {
            return this._liveViewStream != null;
        }

    }
}