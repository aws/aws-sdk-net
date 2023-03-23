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

namespace Amazon.ChimeSDKVoice.Model
{
    /// <summary>
    /// 
    /// </summary>
    public partial class SpeakerSearchDetails
    {
        private List<SpeakerSearchResult> _results = new List<SpeakerSearchResult>();
        private string _voiceprintGenerationStatus;

        /// <summary>
        /// Gets and sets the property Results.
        /// </summary>
        public List<SpeakerSearchResult> Results
        {
            get { return this._results; }
            set { this._results = value; }
        }

        // Check to see if Results property is set
        internal bool IsSetResults()
        {
            return this._results != null && this._results.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property VoiceprintGenerationStatus.
        /// </summary>
        [AWSProperty(Min=1, Max=256)]
        public string VoiceprintGenerationStatus
        {
            get { return this._voiceprintGenerationStatus; }
            set { this._voiceprintGenerationStatus = value; }
        }

        // Check to see if VoiceprintGenerationStatus property is set
        internal bool IsSetVoiceprintGenerationStatus()
        {
            return this._voiceprintGenerationStatus != null;
        }

    }
}