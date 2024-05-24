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

#pragma warning disable CS0612,CS0618,CS1570
namespace Amazon.ChimeSDKMeetings.Model
{
    /// <summary>
    /// Container for the parameters to the StopMeetingTranscription operation.
    /// Stops transcription for the specified <c>meetingId</c>. For more information, refer
    /// to <a href="https://docs.aws.amazon.com/chime-sdk/latest/dg/meeting-transcription.html">
    /// Using Amazon Chime SDK live transcription </a> in the <i>Amazon Chime SDK Developer
    /// Guide</i>.
    /// 
    ///  <important> 
    /// <para>
    /// By default, Amazon Transcribe may use and store audio content processed by the service
    /// to develop and improve Amazon Web Services AI/ML services as further described in
    /// section 50 of the <a href="https://aws.amazon.com/service-terms/">Amazon Web Services
    /// Service Terms</a>. Using Amazon Transcribe may be subject to federal and state laws
    /// or regulations regarding the recording or interception of electronic communications.
    /// It is your and your end users’ responsibility to comply with all applicable laws regarding
    /// the recording, including properly notifying all participants in a recorded session
    /// or communication that the session or communication is being recorded, and obtaining
    /// all necessary consents. You can opt out from Amazon Web Services using audio content
    /// to develop and improve Amazon Web Services AI/ML services by configuring an AI services
    /// opt out policy using Amazon Web Services Organizations.
    /// </para>
    ///  </important>
    /// </summary>
    public partial class StopMeetingTranscriptionRequest : AmazonChimeSDKMeetingsRequest
    {
        private string _meetingId;

        /// <summary>
        /// Gets and sets the property MeetingId. 
        /// <para>
        /// The unique ID of the meeting for which you stop transcription.
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

    }
}