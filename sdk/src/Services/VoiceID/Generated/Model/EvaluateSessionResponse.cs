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
 * Do not modify this file. This file is generated from the voice-id-2021-09-27.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.VoiceID.Model
{
    /// <summary>
    /// This is the response object from the EvaluateSession operation.
    /// </summary>
    public partial class EvaluateSessionResponse : AmazonWebServiceResponse
    {
        private AuthenticationResult _authenticationResult;
        private string _domainId;
        private FraudDetectionResult _fraudDetectionResult;
        private string _sessionId;
        private string _sessionName;
        private StreamingStatus _streamingStatus;

        /// <summary>
        /// Gets and sets the property AuthenticationResult. 
        /// <para>
        /// Details resulting from the authentication process, such as authentication decision
        /// and authentication score.
        /// </para>
        /// </summary>
        public AuthenticationResult AuthenticationResult
        {
            get { return this._authenticationResult; }
            set { this._authenticationResult = value; }
        }

        // Check to see if AuthenticationResult property is set
        internal bool IsSetAuthenticationResult()
        {
            return this._authenticationResult != null;
        }

        /// <summary>
        /// Gets and sets the property DomainId. 
        /// <para>
        /// The identifier of the domain that contains the session.
        /// </para>
        /// </summary>
        [AWSProperty(Min=22, Max=22)]
        public string DomainId
        {
            get { return this._domainId; }
            set { this._domainId = value; }
        }

        // Check to see if DomainId property is set
        internal bool IsSetDomainId()
        {
            return this._domainId != null;
        }

        /// <summary>
        /// Gets and sets the property FraudDetectionResult. 
        /// <para>
        /// Details resulting from the fraud detection process, such as fraud detection decision
        /// and risk score.
        /// </para>
        /// </summary>
        public FraudDetectionResult FraudDetectionResult
        {
            get { return this._fraudDetectionResult; }
            set { this._fraudDetectionResult = value; }
        }

        // Check to see if FraudDetectionResult property is set
        internal bool IsSetFraudDetectionResult()
        {
            return this._fraudDetectionResult != null;
        }

        /// <summary>
        /// Gets and sets the property SessionId. 
        /// <para>
        /// The service-generated identifier of the session.
        /// </para>
        /// </summary>
        [AWSProperty(Min=25, Max=25)]
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
        /// Gets and sets the property SessionName. 
        /// <para>
        /// The client-provided name of the session.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=36)]
        public string SessionName
        {
            get { return this._sessionName; }
            set { this._sessionName = value; }
        }

        // Check to see if SessionName property is set
        internal bool IsSetSessionName()
        {
            return this._sessionName != null;
        }

        /// <summary>
        /// Gets and sets the property StreamingStatus. 
        /// <para>
        /// The current status of audio streaming for this session. This field is useful to infer
        /// next steps when the Authentication or Fraud Detection results are empty or the decision
        /// is <code>NOT_ENOUGH_SPEECH</code>. In this situation, if the <code>StreamingStatus</code>
        /// is <code>ONGOING/PENDING_CONFIGURATION</code>, it can mean that the client should
        /// call the API again later, after Voice ID has enough audio to produce a result. If
        /// the decision remains <code>NOT_ENOUGH_SPEECH</code> even after <code>StreamingStatus</code>
        /// is <code>ENDED</code>, it means that the previously streamed session did not have
        /// enough speech to perform evaluation, and a new streaming session is needed to try
        /// again.
        /// </para>
        /// </summary>
        public StreamingStatus StreamingStatus
        {
            get { return this._streamingStatus; }
            set { this._streamingStatus = value; }
        }

        // Check to see if StreamingStatus property is set
        internal bool IsSetStreamingStatus()
        {
            return this._streamingStatus != null;
        }

    }
}