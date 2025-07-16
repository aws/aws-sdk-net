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
    /// Container for the parameters to the StartBrowserSession operation.
    /// Creates and initializes a browser session in Amazon Bedrock. The session enables agents
    /// to navigate and interact with web content, extract information from websites, and
    /// perform web-based tasks as part of their response generation.
    /// 
    ///  
    /// <para>
    /// To create a session, you must specify a browser identifier and a name. You can also
    /// configure the viewport dimensions to control the visible area of web content. The
    /// session remains active until it times out or you explicitly stop it using the <c>StopBrowserSession</c>
    /// operation.
    /// </para>
    ///  
    /// <para>
    /// The following operations are related to <c>StartBrowserSession</c>:
    /// </para>
    ///  <ul> <li> 
    /// <para>
    ///  <a href="https://docs.aws.amazon.com/API_GetBrowserSession.html">GetBrowserSession</a>
    /// 
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <a href="https://docs.aws.amazon.com/API_UpdateBrowserStream.html">UpdateBrowserStream</a>
    /// 
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <a href="https://docs.aws.amazon.com/API_StopBrowserSession.html">StopBrowserSession</a>
    /// 
    /// </para>
    ///  </li> </ul>
    /// </summary>
    public partial class StartBrowserSessionRequest : AmazonBedrockAgentCoreRequest
    {
        private string _browserIdentifier;
        private string _clientToken;
        private string _name;
        private int? _sessionTimeoutSeconds;
        private ViewPort _viewPort;

        /// <summary>
        /// Gets and sets the property BrowserIdentifier. 
        /// <para>
        /// The unique identifier of the browser to use for this session. This identifier specifies
        /// which browser environment to initialize for the session.
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
        /// than one time. If this token matches a previous request, Amazon Bedrock ignores the
        /// request, but does not return an error. This parameter helps prevent the creation of
        /// duplicate sessions if there are temporary network issues.
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
        /// Gets and sets the property Name. 
        /// <para>
        /// The name of the browser session. This name helps you identify and manage the session.
        /// The name does not need to be unique.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=100)]
        public string Name
        {
            get { return this._name; }
            set { this._name = value; }
        }

        // Check to see if Name property is set
        internal bool IsSetName()
        {
            return this._name != null;
        }

        /// <summary>
        /// Gets and sets the property SessionTimeoutSeconds. 
        /// <para>
        /// The time in seconds after which the session automatically terminates if there is no
        /// activity. The default value is 3600 seconds (1 hour). The minimum allowed value is
        /// 60 seconds, and the maximum allowed value is 28800 seconds (8 hours).
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=28800)]
        public int? SessionTimeoutSeconds
        {
            get { return this._sessionTimeoutSeconds; }
            set { this._sessionTimeoutSeconds = value; }
        }

        // Check to see if SessionTimeoutSeconds property is set
        internal bool IsSetSessionTimeoutSeconds()
        {
            return this._sessionTimeoutSeconds.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property ViewPort. 
        /// <para>
        /// The dimensions of the browser viewport for this session. This determines the visible
        /// area of the web content and affects how web pages are rendered. If not specified,
        /// Amazon Bedrock uses a default viewport size.
        /// </para>
        /// </summary>
        public ViewPort ViewPort
        {
            get { return this._viewPort; }
            set { this._viewPort = value; }
        }

        // Check to see if ViewPort property is set
        internal bool IsSetViewPort()
        {
            return this._viewPort != null;
        }

    }
}