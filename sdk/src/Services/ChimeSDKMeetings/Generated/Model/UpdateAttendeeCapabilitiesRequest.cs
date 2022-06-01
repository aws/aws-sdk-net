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
    /// Container for the parameters to the UpdateAttendeeCapabilities operation.
    /// The capabilties that you want to update.
    /// </summary>
    public partial class UpdateAttendeeCapabilitiesRequest : AmazonChimeSDKMeetingsRequest
    {
        private string _attendeeId;
        private AttendeeCapabilities _capabilities;
        private string _meetingId;

        /// <summary>
        /// Gets and sets the property AttendeeId. 
        /// <para>
        /// The ID of the attendee associated with the update request.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string AttendeeId
        {
            get { return this._attendeeId; }
            set { this._attendeeId = value; }
        }

        // Check to see if AttendeeId property is set
        internal bool IsSetAttendeeId()
        {
            return this._attendeeId != null;
        }

        /// <summary>
        /// Gets and sets the property Capabilities. 
        /// <para>
        /// The capabilties that you want to update.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public AttendeeCapabilities Capabilities
        {
            get { return this._capabilities; }
            set { this._capabilities = value; }
        }

        // Check to see if Capabilities property is set
        internal bool IsSetCapabilities()
        {
            return this._capabilities != null;
        }

        /// <summary>
        /// Gets and sets the property MeetingId. 
        /// <para>
        /// The ID of the meeting associated with the update request.
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