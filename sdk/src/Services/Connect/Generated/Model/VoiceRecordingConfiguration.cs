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
 * Do not modify this file. This file is generated from the connect-2017-08-08.normal.json service model.
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
namespace Amazon.Connect.Model
{
    /// <summary>
    /// Contains information about the recording configuration settings.
    /// </summary>
    public partial class VoiceRecordingConfiguration
    {
        private IvrRecordingTrack _ivrRecordingTrack;
        private VoiceRecordingTrack _voiceRecordingTrack;

        /// <summary>
        /// Gets and sets the property IvrRecordingTrack. 
        /// <para>
        /// Identifies which IVR track is being recorded.
        /// </para>
        ///  
        /// <para>
        /// One and only one of the track configurations should be presented in the request.
        /// </para>
        /// </summary>
        public IvrRecordingTrack IvrRecordingTrack
        {
            get { return this._ivrRecordingTrack; }
            set { this._ivrRecordingTrack = value; }
        }

        // Check to see if IvrRecordingTrack property is set
        internal bool IsSetIvrRecordingTrack()
        {
            return this._ivrRecordingTrack != null;
        }

        /// <summary>
        /// Gets and sets the property VoiceRecordingTrack. 
        /// <para>
        /// Identifies which track is being recorded.
        /// </para>
        /// </summary>
        public VoiceRecordingTrack VoiceRecordingTrack
        {
            get { return this._voiceRecordingTrack; }
            set { this._voiceRecordingTrack = value; }
        }

        // Check to see if VoiceRecordingTrack property is set
        internal bool IsSetVoiceRecordingTrack()
        {
            return this._voiceRecordingTrack != null;
        }

    }
}