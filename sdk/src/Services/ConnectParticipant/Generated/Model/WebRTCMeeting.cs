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
 * Do not modify this file. This file is generated from the connectparticipant-2018-09-07.normal.json service model.
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
namespace Amazon.ConnectParticipant.Model
{
    /// <summary>
    /// A meeting created using the Amazon Chime SDK.
    /// </summary>
    public partial class WebRTCMeeting
    {
        private WebRTCMediaPlacement _mediaPlacement;
        private MeetingFeaturesConfiguration _meetingFeatures;
        private string _meetingId;

        /// <summary>
        /// Gets and sets the property MediaPlacement. 
        /// <para>
        /// The media placement for the meeting.
        /// </para>
        /// </summary>
        public WebRTCMediaPlacement MediaPlacement
        {
            get { return this._mediaPlacement; }
            set { this._mediaPlacement = value; }
        }

        // Check to see if MediaPlacement property is set
        internal bool IsSetMediaPlacement()
        {
            return this._mediaPlacement != null;
        }

        /// <summary>
        /// Gets and sets the property MeetingFeatures.
        /// </summary>
        public MeetingFeaturesConfiguration MeetingFeatures
        {
            get { return this._meetingFeatures; }
            set { this._meetingFeatures = value; }
        }

        // Check to see if MeetingFeatures property is set
        internal bool IsSetMeetingFeatures()
        {
            return this._meetingFeatures != null;
        }

        /// <summary>
        /// Gets and sets the property MeetingId. 
        /// <para>
        /// The Amazon Chime SDK meeting ID.
        /// </para>
        /// </summary>
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