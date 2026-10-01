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
    /// The configuration settings for a voice analytics processor.
    /// </summary>
    public partial class VoiceAnalyticsProcessorConfiguration
    {
        /// <summary>
        /// Gets and sets the property SpeakerSearchStatus. 
        /// <para>
        /// The status of the speaker search task.
        /// </para>
        /// </summary>
        public VoiceAnalyticsConfigurationStatus SpeakerSearchStatus { get; set; }

        /// <summary>
        /// Checks to see if the SpeakerSearchStatus property is set.
        /// </summary>
        internal bool IsSetSpeakerSearchStatus() => this.SpeakerSearchStatus != null;

        /// <summary>
        /// Gets and sets the property VoiceToneAnalysisStatus. 
        /// <para>
        /// The status of the voice tone analysis task.
        /// </para>
        /// </summary>
        public VoiceAnalyticsConfigurationStatus VoiceToneAnalysisStatus { get; set; }

        /// <summary>
        /// Checks to see if the VoiceToneAnalysisStatus property is set.
        /// </summary>
        internal bool IsSetVoiceToneAnalysisStatus() => this.VoiceToneAnalysisStatus != null;
    }
}
