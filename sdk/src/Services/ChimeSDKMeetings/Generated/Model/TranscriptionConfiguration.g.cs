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

namespace Amazon.ChimeSDKMeetings.Model
{
    /// <summary>
    /// The configuration for the current transcription operation. Must contain <c>EngineTranscribeSettings</c>
    /// or <c>EngineTranscribeMedicalSettings</c>.
    /// </summary>
    public partial class TranscriptionConfiguration
    {
        /// <summary>
        /// Gets and sets the property EngineTranscribeMedicalSettings. 
        /// <para>
        /// The transcription configuration settings passed to Amazon Transcribe Medical.
        /// </para>
        /// </summary>
        public EngineTranscribeMedicalSettings EngineTranscribeMedicalSettings { get; set; }

        /// <summary>
        /// Checks to see if the EngineTranscribeMedicalSettings property is set.
        /// </summary>
        internal bool IsSetEngineTranscribeMedicalSettings() => this.EngineTranscribeMedicalSettings != null;

        /// <summary>
        /// Gets and sets the property EngineTranscribeSettings. 
        /// <para>
        /// The transcription configuration settings passed to Amazon Transcribe.
        /// </para>
        /// </summary>
        public EngineTranscribeSettings EngineTranscribeSettings { get; set; }

        /// <summary>
        /// Checks to see if the EngineTranscribeSettings property is set.
        /// </summary>
        internal bool IsSetEngineTranscribeSettings() => this.EngineTranscribeSettings != null;
    }
}
