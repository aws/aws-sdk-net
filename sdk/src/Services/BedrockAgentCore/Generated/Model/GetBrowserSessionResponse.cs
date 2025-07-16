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
    /// This is the response object from the GetBrowserSession operation.
    /// </summary>
    public partial class GetBrowserSessionResponse : AmazonWebServiceResponse
    {
        private string _browserIdentifier;
        private DateTime? _createdAt;
        private DateTime? _lastUpdatedAt;
        private string _name;
        private string _sessionId;
        private string _sessionReplayArtifact;
        private int? _sessionTimeoutSeconds;
        private BrowserSessionStatus _status;
        private BrowserSessionStream _streams;
        private ViewPort _viewPort;

        /// <summary>
        /// Gets and sets the property BrowserIdentifier. 
        /// <para>
        /// The identifier of the browser.
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
        /// Gets and sets the property CreatedAt. 
        /// <para>
        /// The time at which the browser session was created.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public DateTime? CreatedAt
        {
            get { return this._createdAt; }
            set { this._createdAt = value; }
        }

        // Check to see if CreatedAt property is set
        internal bool IsSetCreatedAt()
        {
            return this._createdAt.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property LastUpdatedAt. 
        /// <para>
        /// The time at which the browser session was last updated.
        /// </para>
        /// </summary>
        public DateTime? LastUpdatedAt
        {
            get { return this._lastUpdatedAt; }
            set { this._lastUpdatedAt = value; }
        }

        // Check to see if LastUpdatedAt property is set
        internal bool IsSetLastUpdatedAt()
        {
            return this._lastUpdatedAt.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Name. 
        /// <para>
        /// The name of the browser session.
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
        /// Gets and sets the property SessionId. 
        /// <para>
        /// The identifier of the browser session.
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
        /// Gets and sets the property SessionReplayArtifact. 
        /// <para>
        /// The artifact containing the session replay information.
        /// </para>
        /// </summary>
        public string SessionReplayArtifact
        {
            get { return this._sessionReplayArtifact; }
            set { this._sessionReplayArtifact = value; }
        }

        // Check to see if SessionReplayArtifact property is set
        internal bool IsSetSessionReplayArtifact()
        {
            return this._sessionReplayArtifact != null;
        }

        /// <summary>
        /// Gets and sets the property SessionTimeoutSeconds. 
        /// <para>
        /// The timeout period for the browser session in seconds.
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
        /// Gets and sets the property Status. 
        /// <para>
        /// The current status of the browser session. Possible values include ACTIVE, STOPPING,
        /// and STOPPED.
        /// </para>
        /// </summary>
        public BrowserSessionStatus Status
        {
            get { return this._status; }
            set { this._status = value; }
        }

        // Check to see if Status property is set
        internal bool IsSetStatus()
        {
            return this._status != null;
        }

        /// <summary>
        /// Gets and sets the property Streams. 
        /// <para>
        /// The streams associated with this browser session. These include the automation stream
        /// and live view stream.
        /// </para>
        /// </summary>
        public BrowserSessionStream Streams
        {
            get { return this._streams; }
            set { this._streams = value; }
        }

        // Check to see if Streams property is set
        internal bool IsSetStreams()
        {
            return this._streams != null;
        }

        /// <summary>
        /// Gets and sets the property ViewPort.
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