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
 * Do not modify this file. This file is generated from the chime-sdk-media-pipelines-2021-07-15.normal.json service model.
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
namespace Amazon.ChimeSDKMediaPipelines.Model
{
    /// <summary>
    /// Container for the parameters to the StartVoiceToneAnalysisTask operation.
    /// Starts a voice tone analysis task. For more information about voice tone analysis,
    /// see <a href="https://docs.aws.amazon.com/chime-sdk/latest/dg/voice-analytics.html">Using
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
    public partial class StartVoiceToneAnalysisTaskRequest : AmazonChimeSDKMediaPipelinesRequest
    {
        private string _clientRequestToken;
        private string _identifier;
        private KinesisVideoStreamSourceTaskConfiguration _kinesisVideoStreamSourceTaskConfiguration;
        private VoiceAnalyticsLanguageCode _languageCode;

        /// <summary>
        /// Gets and sets the property ClientRequestToken. 
        /// <para>
        /// The unique identifier for the client request. Use a different token for different
        /// voice tone analysis tasks.
        /// </para>
        /// </summary>
        [AWSProperty(Sensitive=true, Min=2, Max=64)]
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
        /// Gets and sets the property Identifier. 
        /// <para>
        /// The unique identifier of the resource to be updated. Valid values include the ID and
        /// ARN of the media insights pipeline.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Max=1024)]
        public string Identifier
        {
            get { return this._identifier; }
            set { this._identifier = value; }
        }

        // Check to see if Identifier property is set
        internal bool IsSetIdentifier()
        {
            return this._identifier != null;
        }

        /// <summary>
        /// Gets and sets the property KinesisVideoStreamSourceTaskConfiguration. 
        /// <para>
        /// The task configuration for the Kinesis video stream source of the media insights pipeline.
        /// </para>
        /// </summary>
        public KinesisVideoStreamSourceTaskConfiguration KinesisVideoStreamSourceTaskConfiguration
        {
            get { return this._kinesisVideoStreamSourceTaskConfiguration; }
            set { this._kinesisVideoStreamSourceTaskConfiguration = value; }
        }

        // Check to see if KinesisVideoStreamSourceTaskConfiguration property is set
        internal bool IsSetKinesisVideoStreamSourceTaskConfiguration()
        {
            return this._kinesisVideoStreamSourceTaskConfiguration != null;
        }

        /// <summary>
        /// Gets and sets the property LanguageCode. 
        /// <para>
        /// The language code.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public VoiceAnalyticsLanguageCode LanguageCode
        {
            get { return this._languageCode; }
            set { this._languageCode = value; }
        }

        // Check to see if LanguageCode property is set
        internal bool IsSetLanguageCode()
        {
            return this._languageCode != null;
        }

    }
}