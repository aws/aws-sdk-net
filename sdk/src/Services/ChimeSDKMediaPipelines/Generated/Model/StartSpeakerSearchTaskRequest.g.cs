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

namespace Amazon.ChimeSDKMediaPipelines.Model
{
    /// <summary>
    /// Container for the parameters to the StartSpeakerSearchTask operation. Starts a speaker
    /// search task. <important> <para> Before starting any speaker search tasks, you must
    /// provide all notices and obtain all consents from the speaker as required under applicable
    /// privacy and biometrics laws, and as required under the <a href="https://aws.amazon.com/service-terms/">AWS
    /// service terms</a> for the Amazon Chime SDK. </para> </important>
    /// </summary>
    public partial class StartSpeakerSearchTaskRequest : AmazonChimeSDKMediaPipelinesRequest
    {
        /// <summary>
        /// Gets and sets the property ClientRequestToken. 
        /// <para>
        /// The unique identifier for the client request. Use a different token for different
        /// speaker search tasks.
        /// </para>
        /// </summary>
        [AWSProperty(Sensitive = true, Min = 2, Max = 64)]
        public string ClientRequestToken { get; set; }

        /// <summary>
        /// Checks to see if the ClientRequestToken property is set.
        /// </summary>
        internal bool IsSetClientRequestToken() => this.ClientRequestToken != null;

        /// <summary>
        /// Gets and sets the property Identifier. 
        /// <para>
        /// The unique identifier of the resource to be updated. Valid values include the ID and
        /// ARN of the media insights pipeline.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 0, Max = 1024)]
        public string Identifier { get; set; }

        /// <summary>
        /// Checks to see if the Identifier property is set.
        /// </summary>
        internal bool IsSetIdentifier() => this.Identifier != null;

        /// <summary>
        /// Gets and sets the property KinesisVideoStreamSourceTaskConfiguration. 
        /// <para>
        /// The task configuration for the Kinesis video stream source of the media insights pipeline.
        /// </para>
        /// </summary>
        public KinesisVideoStreamSourceTaskConfiguration KinesisVideoStreamSourceTaskConfiguration { get; set; }

        /// <summary>
        /// Checks to see if the KinesisVideoStreamSourceTaskConfiguration property is set.
        /// </summary>
        internal bool IsSetKinesisVideoStreamSourceTaskConfiguration() => this.KinesisVideoStreamSourceTaskConfiguration != null;

        /// <summary>
        /// Gets and sets the property VoiceProfileDomainArn. 
        /// <para>
        /// The ARN of the voice profile domain that will store the voice profile.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Sensitive = true, Min = 1, Max = 1024)]
        public string VoiceProfileDomainArn { get; set; }

        /// <summary>
        /// Checks to see if the VoiceProfileDomainArn property is set.
        /// </summary>
        internal bool IsSetVoiceProfileDomainArn() => this.VoiceProfileDomainArn != null;
    }
}
