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
 * Do not modify this file. This file is generated from the smithy.json service model.
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
    /// Container for the parameters to the StopBrowserSession operation. Terminates an active
    /// browser session in Amazon Bedrock AgentCore. This operation stops the session, releases
    /// associated resources, and makes the session unavailable for further use. <para> To
    /// stop a browser session, you must specify both the browser identifier and the session
    /// ID. Once stopped, a session cannot be restarted; you must create a new session using
    /// <c>StartBrowserSession</c>. </para> <para> The following operations are related to
    /// <c>StopBrowserSession</c>: </para> <ul> <li> <para> <a href="https://docs.aws.amazon.com/bedrock-agentcore/latest/APIReference/API_StartBrowserSession.html">StartBrowserSession</a>
    /// </para> </li> <li> <para> <a href="https://docs.aws.amazon.com/bedrock-agentcore/latest/APIReference/API_GetBrowserSession.html">GetBrowserSession</a>
    /// </para> </li> </ul>
    /// </summary>
    public partial class StopBrowserSessionRequest : AmazonBedrockAgentCoreRequest
    {
        /// <summary>
        /// Gets and sets the property BrowserIdentifier. 
        /// <para>
        /// The unique identifier of the browser associated with the session.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public string BrowserIdentifier { get; set; }

        /// <summary>
        /// Checks to see if the BrowserIdentifier property is set.
        /// </summary>
        internal bool IsSetBrowserIdentifier() => this.BrowserIdentifier != null;

        /// <summary>
        /// Gets and sets the property ClientToken. 
        /// <para>
        /// A unique, case-sensitive identifier to ensure that the API request completes no more
        /// than one time. If this token matches a previous request, Amazon Bedrock AgentCore
        /// ignores the request, but does not return an error.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 33, Max = 256)]
        public string ClientToken { get; set; }

        /// <summary>
        /// Checks to see if the ClientToken property is set.
        /// </summary>
        internal bool IsSetClientToken() => this.ClientToken != null;

        /// <summary>
        /// Gets and sets the property SessionId. 
        /// <para>
        /// The unique identifier of the browser session to stop.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public string SessionId { get; set; }

        /// <summary>
        /// Checks to see if the SessionId property is set.
        /// </summary>
        internal bool IsSetSessionId() => this.SessionId != null;

        /// <summary>
        /// Gets and sets the property TraceId. 
        /// <para>
        /// The trace identifier for request tracking.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 1024)]
        public string TraceId { get; set; }

        /// <summary>
        /// Checks to see if the TraceId property is set.
        /// </summary>
        internal bool IsSetTraceId() => this.TraceId != null;

        /// <summary>
        /// Gets and sets the property TraceParent. 
        /// <para>
        /// The parent trace information for distributed tracing.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 1024)]
        public string TraceParent { get; set; }

        /// <summary>
        /// Checks to see if the TraceParent property is set.
        /// </summary>
        internal bool IsSetTraceParent() => this.TraceParent != null;
    }
}
