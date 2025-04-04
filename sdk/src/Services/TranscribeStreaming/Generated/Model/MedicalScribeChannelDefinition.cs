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
 * Do not modify this file. This file is generated from the transcribe-streaming-2017-10-26.normal.json service model.
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
namespace Amazon.TranscribeStreaming.Model
{
    /// <summary>
    /// Makes it possible to specify which speaker is on which channel. For example, if the
    /// clinician is the first participant to speak, you would set the <c>ChannelId</c> of
    /// the first <c>ChannelDefinition</c> in the list to <c>0</c> (to indicate the first
    /// channel) and <c>ParticipantRole</c> to <c>CLINICIAN</c> (to indicate that it's the
    /// clinician speaking). Then you would set the <c>ChannelId</c> of the second <c>ChannelDefinition</c>
    /// in the list to <c>1</c> (to indicate the second channel) and <c>ParticipantRole</c>
    /// to <c>PATIENT</c> (to indicate that it's the patient speaking). 
    /// 
    ///  
    /// <para>
    /// If you don't specify a channel definition, HealthScribe will diarize the transcription
    /// and identify speaker roles for each speaker.
    /// </para>
    /// </summary>
    public partial class MedicalScribeChannelDefinition
    {
        private int? _channelId;
        private MedicalScribeParticipantRole _participantRole;

        /// <summary>
        /// Gets and sets the property ChannelId. 
        /// <para>
        /// Specify the audio channel you want to define.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=0, Max=1)]
        public int? ChannelId
        {
            get { return this._channelId; }
            set { this._channelId = value; }
        }

        // Check to see if ChannelId property is set
        internal bool IsSetChannelId()
        {
            return this._channelId.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property ParticipantRole. 
        /// <para>
        /// Specify the participant that you want to flag. The allowed options are <c>CLINICIAN</c>
        /// and <c>PATIENT</c>. 
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public MedicalScribeParticipantRole ParticipantRole
        {
            get { return this._participantRole; }
            set { this._participantRole = value; }
        }

        // Check to see if ParticipantRole property is set
        internal bool IsSetParticipantRole()
        {
            return this._participantRole != null;
        }

    }
}