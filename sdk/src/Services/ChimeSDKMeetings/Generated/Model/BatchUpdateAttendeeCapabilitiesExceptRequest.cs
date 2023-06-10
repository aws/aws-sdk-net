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
    /// Container for the parameters to the BatchUpdateAttendeeCapabilitiesExcept operation.
    /// Updates <code>AttendeeCapabilities</code> except the capabilities listed in an <code>ExcludedAttendeeIds</code>
    /// table.
    /// 
    ///  <note> 
    /// <para>
    /// You use the capabilities with a set of values that control what the capabilities can
    /// do, such as <code>SendReceive</code> data. For more information about those values,
    /// see .
    /// </para>
    ///  </note> 
    /// <para>
    /// When using capabilities, be aware of these corner cases:
    /// </para>
    ///  <ul> <li> 
    /// <para>
    /// You can't set <code>content</code> capabilities to <code>SendReceive</code> or <code>Receive</code>
    /// unless you also set <code>video</code> capabilities to <code>SendReceive</code> or
    /// <code>Receive</code>. If you don't set the <code>video</code> capability to receive,
    /// the response will contain an HTTP 400 Bad Request status code. However, you can set
    /// your <code>video</code> capability to receive and you set your <code>content</code>
    /// capability to not receive.
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// When you change an <code>audio</code> capability from <code>None</code> or <code>Receive</code>
    /// to <code>Send</code> or <code>SendReceive</code> , and if the attendee left their
    /// microphone unmuted, audio will flow from the attendee to the other meeting participants.
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// When you change a <code>video</code> or <code>content</code> capability from <code>None</code>
    /// or <code>Receive</code> to <code>Send</code> or <code>SendReceive</code> , and if
    /// the attendee turned on their video or content streams, remote attendees can receive
    /// those streams, but only after media renegotiation between the client and the Amazon
    /// Chime back-end server.
    /// </para>
    ///  </li> </ul>
    /// </summary>
    public partial class BatchUpdateAttendeeCapabilitiesExceptRequest : AmazonChimeSDKMeetingsRequest
    {
        private AttendeeCapabilities _capabilities;
        private List<AttendeeIdItem> _excludedAttendeeIds = new List<AttendeeIdItem>();
        private string _meetingId;

        /// <summary>
        /// Gets and sets the property Capabilities. 
        /// <para>
        /// The capabilities (<code>audio</code>, <code>video</code>, or <code>content</code>)
        /// that you want to update.
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
        /// Gets and sets the property ExcludedAttendeeIds. 
        /// <para>
        /// The <code>AttendeeIDs</code> that you want to exclude from one or more capabilities.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=250)]
        public List<AttendeeIdItem> ExcludedAttendeeIds
        {
            get { return this._excludedAttendeeIds; }
            set { this._excludedAttendeeIds = value; }
        }

        // Check to see if ExcludedAttendeeIds property is set
        internal bool IsSetExcludedAttendeeIds()
        {
            return this._excludedAttendeeIds != null && this._excludedAttendeeIds.Count > 0; 
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