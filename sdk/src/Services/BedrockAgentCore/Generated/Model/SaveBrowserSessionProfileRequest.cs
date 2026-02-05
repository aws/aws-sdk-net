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
    /// Container for the parameters to the SaveBrowserSessionProfile operation.
    /// Saves the current state of a browser session as a reusable profile in Amazon Bedrock
    /// AgentCore. A browser profile captures persistent browser data such as cookies and
    /// local storage from an active session, enabling you to reuse this data in future browser
    /// sessions.
    /// 
    ///  
    /// <para>
    /// To save a browser session profile, you must specify the profile identifier, browser
    /// identifier, and session ID. The session must be active when saving the profile. Once
    /// saved, the profile can be used with the <c>StartBrowserSession</c> operation to initialize
    /// new sessions with the stored browser state.
    /// </para>
    ///  
    /// <para>
    /// Browser profiles are useful for scenarios that require persistent authentication,
    /// maintaining user preferences across sessions, or continuing tasks that depend on previously
    /// stored browser data.
    /// </para>
    ///  
    /// <para>
    /// The following operations are related to <c>SaveBrowserSessionProfile</c>:
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
    ///  </li> </ul>
    /// </summary>
    public partial class SaveBrowserSessionProfileRequest : AmazonBedrockAgentCoreRequest
    {
        private string _browserIdentifier;
        private string _clientToken;
        private string _profileIdentifier;
        private string _sessionId;
        private string _traceId;
        private string _traceParent;

        /// <summary>
        /// Gets and sets the property BrowserIdentifier. 
        /// <para>
        /// The unique identifier of the browser associated with the session from which to save
        /// the profile.
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
        /// Gets and sets the property ClientToken. 
        /// <para>
        /// A unique, case-sensitive identifier to ensure that the API request completes no more
        /// than one time. If this token matches a previous request, Amazon Bedrock AgentCore
        /// ignores the request, but does not return an error.
        /// </para>
        /// </summary>
        [AWSProperty(Min=33, Max=256)]
        public string ClientToken
        {
            get { return this._clientToken; }
            set { this._clientToken = value; }
        }

        // Check to see if ClientToken property is set
        internal bool IsSetClientToken()
        {
            return this._clientToken != null;
        }

        /// <summary>
        /// Gets and sets the property ProfileIdentifier. 
        /// <para>
        /// The unique identifier for the browser profile. This identifier is used to reference
        /// the profile when starting new browser sessions. The identifier must follow the pattern
        /// of an alphanumeric name (up to 48 characters) followed by a hyphen and a 10-character
        /// alphanumeric suffix.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string ProfileIdentifier
        {
            get { return this._profileIdentifier; }
            set { this._profileIdentifier = value; }
        }

        // Check to see if ProfileIdentifier property is set
        internal bool IsSetProfileIdentifier()
        {
            return this._profileIdentifier != null;
        }

        /// <summary>
        /// Gets and sets the property SessionId. 
        /// <para>
        /// The unique identifier of the browser session from which to save the profile. The session
        /// must be active when saving the profile.
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

        /// <summary>
        /// Gets and sets the property TraceId. 
        /// <para>
        /// The trace identifier for request tracking.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=1024)]
        public string TraceId
        {
            get { return this._traceId; }
            set { this._traceId = value; }
        }

        // Check to see if TraceId property is set
        internal bool IsSetTraceId()
        {
            return this._traceId != null;
        }

        /// <summary>
        /// Gets and sets the property TraceParent. 
        /// <para>
        /// The parent trace information for distributed tracing.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=1024)]
        public string TraceParent
        {
            get { return this._traceParent; }
            set { this._traceParent = value; }
        }

        // Check to see if TraceParent property is set
        internal bool IsSetTraceParent()
        {
            return this._traceParent != null;
        }

    }
}