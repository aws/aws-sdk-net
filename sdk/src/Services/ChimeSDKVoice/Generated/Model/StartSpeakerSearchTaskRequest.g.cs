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

namespace Amazon.ChimeSDKVoice.Model
{
    /// <summary>
    /// Container for the parameters to the StartSpeakerSearchTask operation. Starts a speaker
    /// search task. <important> <para> Before starting any speaker search tasks, you must
    /// provide all notices and obtain all consents from the speaker as required under applicable
    /// privacy and biometrics laws, and as required under the <a href="https://aws.amazon.com/service-terms/">AWS
    /// service terms</a> for the Amazon Chime SDK. </para> </important>
    /// </summary>
    public partial class StartSpeakerSearchTaskRequest : AmazonChimeSDKVoiceRequest
    {
        /// <summary>
        /// Gets and sets the property CallLeg. 
        /// <para>
        /// Specifies which call leg to stream for speaker search.
        /// </para>
        /// </summary>
        public CallLegType CallLeg { get; set; }

        /// <summary>
        /// Checks to see if the CallLeg property is set.
        /// </summary>
        internal bool IsSetCallLeg() => this.CallLeg != null;

        /// <summary>
        /// Gets and sets the property ClientRequestToken. 
        /// <para>
        /// The unique identifier for the client request. Use a different token for different
        /// speaker search tasks.
        /// </para>
        /// </summary>
        public string ClientRequestToken { get; set; }

        /// <summary>
        /// Checks to see if the ClientRequestToken property is set.
        /// </summary>
        internal bool IsSetClientRequestToken() => this.ClientRequestToken != null;

        /// <summary>
        /// Gets and sets the property TransactionId. 
        /// <para>
        /// The transaction ID of the call being analyzed.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 256)]
        public string TransactionId { get; set; }

        /// <summary>
        /// Checks to see if the TransactionId property is set.
        /// </summary>
        internal bool IsSetTransactionId() => this.TransactionId != null;

        /// <summary>
        /// Gets and sets the property VoiceConnectorId. 
        /// <para>
        /// The Voice Connector ID.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public string VoiceConnectorId { get; set; }

        /// <summary>
        /// Checks to see if the VoiceConnectorId property is set.
        /// </summary>
        internal bool IsSetVoiceConnectorId() => this.VoiceConnectorId != null;

        /// <summary>
        /// Gets and sets the property VoiceProfileDomainId. 
        /// <para>
        /// The ID of the voice profile domain that will store the voice profile.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 256)]
        public string VoiceProfileDomainId { get; set; }

        /// <summary>
        /// Checks to see if the VoiceProfileDomainId property is set.
        /// </summary>
        internal bool IsSetVoiceProfileDomainId() => this.VoiceProfileDomainId != null;
    }
}
