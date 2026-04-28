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
    /// Container for the parameters to the InvokeBrowser operation.
    /// Invokes an operating system-level action on a browser session in Amazon Bedrock AgentCore.
    /// This operation provides direct OS-level control over browser sessions, enabling mouse
    /// actions, keyboard input, and screenshots that the WebSocket-based Chrome DevTools
    /// Protocol (CDP) cannot handle — such as interacting with print dialogs, context menus,
    /// and JavaScript alerts.
    /// 
    ///  
    /// <para>
    /// You send a request with exactly one action in the <c>BrowserAction</c> union, and
    /// receive a corresponding result in the <c>BrowserActionResult</c> union.
    /// </para>
    ///  
    /// <para>
    /// The following operations are related to <c>InvokeBrowser</c>:
    /// </para>
    ///  <ul> <li> 
    /// <para>
    ///  <a href="https://docs.aws.amazon.com/bedrock-agentcore/latest/APIReference/API_StartBrowserSession.html">StartBrowserSession</a>
    /// 
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <a href="https://docs.aws.amazon.com/bedrock-agentcore/latest/APIReference/API_GetBrowserSession.html">GetBrowserSession</a>
    /// 
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <a href="https://docs.aws.amazon.com/bedrock-agentcore/latest/APIReference/API_StopBrowserSession.html">StopBrowserSession</a>
    /// 
    /// </para>
    ///  </li> </ul>
    /// </summary>
    public partial class InvokeBrowserRequest : AmazonBedrockAgentCoreRequest
    {
        private BrowserAction _action;
        private string _browserIdentifier;
        private string _sessionId;

        /// <summary>
        /// Gets and sets the property Action. 
        /// <para>
        /// The browser action to perform. Exactly one member of the <c>BrowserAction</c> union
        /// must be set per request.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public BrowserAction Action
        {
            get { return this._action; }
            set { this._action = value; }
        }

        // Check to see if Action property is set
        internal bool IsSetAction()
        {
            return this._action != null;
        }

        /// <summary>
        /// Gets and sets the property BrowserIdentifier. 
        /// <para>
        /// The unique identifier of the browser associated with the session. This must match
        /// the identifier used when creating the session with <c>StartBrowserSession</c>.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string BrowserIdentifier
        {
            get { return this._browserIdentifier; }
            set { this._browserIdentifier = value; }
        }

        // Check to see if BrowserIdentifier property is set
        internal bool IsSetBrowserIdentifier()
        {
            return this._browserIdentifier != null;
        }

        /// <summary>
        /// Gets and sets the property SessionId. 
        /// <para>
        /// The unique identifier of the browser session on which to perform the action. This
        /// must be an active session created with <c>StartBrowserSession</c>.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string SessionId
        {
            get { return this._sessionId; }
            set { this._sessionId = value; }
        }

        // Check to see if SessionId property is set
        internal bool IsSetSessionId()
        {
            return this._sessionId != null;
        }

    }
}