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
 * Do not modify this file. This file is generated from the chime-sdk-voice-2022-08-03.normal.json service model.
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
    /// Container for the parameters to the StartVoiceToneAnalysisTask operation.
    /// Starts a voice tone analysis task. For more information about voice tone analysis,
    /// see <a href="https://docs.aws.amazon.com/chime-sdk/latest/dg/pstn-voice-analytics.html">Using
    /// Amazon Chime SDK voice analytics</a> in the <i>Amazon Chime SDK Developer Guide</i>.
    /// 
    ///  <important> 
    /// <para>
    /// Before starting any voice tone analysis tasks, you must provide all notices and obtain
    /// all consents from the speaker as required under applicable privacy and biometrics
    /// laws, and as required under the <a href="https://aws.amazon.com/service-terms/">AWS
    /// service terms</a> for the Amazon Chime SDK.
    /// </para>
    ///  </important>
    /// </summary>
    public partial class StartVoiceToneAnalysisTaskRequest : AmazonChimeSDKVoiceRequest
    {
        private string _clientRequestToken;
        private LanguageCode _languageCode;
        private string _transactionId;
        private string _voiceConnectorId;

        /// <summary>
        /// Gets and sets the property ClientRequestToken. 
        /// <para>
        /// The unique identifier for the client request. Use a different token for different
        /// voice tone analysis tasks.
        /// </para>
        /// </summary>
        public string ClientRequestToken
        {
            get { return this._clientRequestToken; }
            set { this._clientRequestToken = value; }
        }

        // Check to see if ClientRequestToken property is set
        internal bool IsSetClientRequestToken()
        {
            return this._clientRequestToken != null;
        }

        /// <summary>
        /// Gets and sets the property LanguageCode. 
        /// <para>
        /// The language code.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public LanguageCode LanguageCode
        {
            get { return this._languageCode; }
            set { this._languageCode = value; }
        }

        // Check to see if LanguageCode property is set
        internal bool IsSetLanguageCode()
        {
            return this._languageCode != null;
        }

        /// <summary>
        /// Gets and sets the property TransactionId. 
        /// <para>
        /// The transaction ID.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=256)]
        public string TransactionId
        {
            get { return this._transactionId; }
            set { this._transactionId = value; }
        }

        // Check to see if TransactionId property is set
        internal bool IsSetTransactionId()
        {
            return this._transactionId != null;
        }

        /// <summary>
        /// Gets and sets the property VoiceConnectorId. 
        /// <para>
        /// The Voice Connector ID.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=128)]
        public string VoiceConnectorId
        {
            get { return this._voiceConnectorId; }
            set { this._voiceConnectorId = value; }
        }

        // Check to see if VoiceConnectorId property is set
        internal bool IsSetVoiceConnectorId()
        {
            return this._voiceConnectorId != null;
        }

    }
}