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

namespace Amazon.VoiceID.Model
{
    /// <summary>
    /// This is the response object from the EvaluateSession operation.
    /// </summary>
    public partial class EvaluateSessionResponse : AmazonWebServiceResponse
    {
        /// <summary>
        /// Gets and sets the property AuthenticationResult. 
        /// <para>
        /// Details resulting from the authentication process, such as authentication decision
        /// and authentication score.
        /// </para>
        /// </summary>
        public AuthenticationResult AuthenticationResult { get; set; }

        /// <summary>
        /// Checks to see if the AuthenticationResult property is set.
        /// </summary>
        internal bool IsSetAuthenticationResult() => this.AuthenticationResult != null;

        /// <summary>
        /// Gets and sets the property DomainId. 
        /// <para>
        /// The identifier of the domain that contains the session.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 22, Max = 22)]
        public string DomainId { get; set; }

        /// <summary>
        /// Checks to see if the DomainId property is set.
        /// </summary>
        internal bool IsSetDomainId() => this.DomainId != null;

        /// <summary>
        /// Gets and sets the property FraudDetectionResult. 
        /// <para>
        /// Details resulting from the fraud detection process, such as fraud detection decision
        /// and risk score.
        /// </para>
        /// </summary>
        public FraudDetectionResult FraudDetectionResult { get; set; }

        /// <summary>
        /// Checks to see if the FraudDetectionResult property is set.
        /// </summary>
        internal bool IsSetFraudDetectionResult() => this.FraudDetectionResult != null;

        /// <summary>
        /// Gets and sets the property SessionId. 
        /// <para>
        /// The service-generated identifier of the session.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 25, Max = 25)]
        public string SessionId { get; set; }

        /// <summary>
        /// Checks to see if the SessionId property is set.
        /// </summary>
        internal bool IsSetSessionId() => this.SessionId != null;

        /// <summary>
        /// Gets and sets the property SessionName. 
        /// <para>
        /// The client-provided name of the session.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 36)]
        public string SessionName { get; set; }

        /// <summary>
        /// Checks to see if the SessionName property is set.
        /// </summary>
        internal bool IsSetSessionName() => this.SessionName != null;

        /// <summary>
        /// Gets and sets the property StreamingStatus. 
        /// <para>
        /// The current status of audio streaming for this session. This field is useful to infer
        /// next steps when the Authentication or Fraud Detection results are empty or the decision
        /// is <c>NOT_ENOUGH_SPEECH</c>. In this situation, if the <c>StreamingStatus</c> is <c>ONGOING/PENDING_CONFIGURATION</c>,
        /// it can mean that the client should call the API again later, after Voice ID has enough
        /// audio to produce a result. If the decision remains <c>NOT_ENOUGH_SPEECH</c> even after
        /// <c>StreamingStatus</c> is <c>ENDED</c>, it means that the previously streamed session
        /// did not have enough speech to perform evaluation, and a new streaming session is needed
        /// to try again.
        /// </para>
        /// </summary>
        public StreamingStatus StreamingStatus { get; set; }

        /// <summary>
        /// Checks to see if the StreamingStatus property is set.
        /// </summary>
        internal bool IsSetStreamingStatus() => this.StreamingStatus != null;
    }
}
