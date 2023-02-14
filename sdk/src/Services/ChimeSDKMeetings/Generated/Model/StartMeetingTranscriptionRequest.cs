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
 * Do not modify this file. This file is generated from the chime-sdk-meetings-2021-07-15.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.ChimeSDKMeetings.Model
{
    /// <summary>
    /// Container for the parameters to the StartMeetingTranscription operation.
    /// Starts transcription for the specified <code>meetingId</code>. For more information,
    /// refer to <a href="https://docs.aws.amazon.com/chime-sdk/latest/dg/meeting-transcription.html">
    /// Using Amazon Chime SDK live transcription </a> in the <i>Amazon Chime SDK Developer
    /// Guide</i>.
    /// 
    ///  <important> 
    /// <para>
    /// Amazon Chime SDK live transcription is powered by Amazon Transcribe. Use of Amazon
    /// Transcribe is subject to the <a href="https://aws.amazon.com/service-terms/">AWS Service
    /// Terms</a>, including the terms specific to the AWS Machine Learning and Artificial
    /// Intelligence Services.
    /// </para>
    ///  </important>
    /// </summary>
    public partial class StartMeetingTranscriptionRequest : AmazonChimeSDKMeetingsRequest
    {
        private string _meetingId;
        private TranscriptionConfiguration _transcriptionConfiguration;

        /// <summary>
        /// Gets and sets the property MeetingId. 
        /// <para>
        /// The unique ID of the meeting being transcribed.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string MeetingId
        {
            get { return this._meetingId; }
            set { this._meetingId = value; }
        }

        // Check to see if MeetingId property is set
        internal bool IsSetMeetingId()
        {
            return this._meetingId != null;
        }

        /// <summary>
        /// Gets and sets the property TranscriptionConfiguration. 
        /// <para>
        /// The configuration for the current transcription operation. Must contain <code>EngineTranscribeSettings</code>
        /// or <code>EngineTranscribeMedicalSettings</code>.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public TranscriptionConfiguration TranscriptionConfiguration
        {
            get { return this._transcriptionConfiguration; }
            set { this._transcriptionConfiguration = value; }
        }

        // Check to see if TranscriptionConfiguration property is set
        internal bool IsSetTranscriptionConfiguration()
        {
            return this._transcriptionConfiguration != null;
        }

    }
}