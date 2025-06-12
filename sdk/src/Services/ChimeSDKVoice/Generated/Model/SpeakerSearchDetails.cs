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
    /// The details of a speaker search task.
    /// </summary>
    public partial class SpeakerSearchDetails
    {
        private List<SpeakerSearchResult> _results = AWSConfigs.InitializeCollections ? new List<SpeakerSearchResult>() : null;
        private string _voiceprintGenerationStatus;

        /// <summary>
        /// Gets and sets the property Results. 
        /// <para>
        /// The result value in the speaker search details.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<SpeakerSearchResult> Results
        {
            get { return this._results; }
            set { this._results = value; }
        }

        // Check to see if Results property is set
        internal bool IsSetResults()
        {
            return this._results != null && (this._results.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property VoiceprintGenerationStatus. 
        /// <para>
        /// The status of a voice print generation operation, <c>VoiceprintGenerationSuccess</c>
        /// or <c>VoiceprintGenerationFailure</c>..
        /// </para>
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