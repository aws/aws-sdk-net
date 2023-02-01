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
    /// Container for the parameters to the CreateAttendee operation.
    /// Creates a new attendee for an active Amazon Chime SDK meeting. For more information
    /// about the Amazon Chime SDK, see <a href="https://docs.aws.amazon.com/chime/latest/dg/meetings-sdk.html">Using
    /// the Amazon Chime SDK</a> in the <i>Amazon Chime Developer Guide</i>.
    /// </summary>
    public partial class CreateAttendeeRequest : AmazonChimeSDKMeetingsRequest
    {
        private AttendeeCapabilities _capabilities;
        private string _externalUserId;
        private string _meetingId;

        /// <summary>
        /// Gets and sets the property Capabilities. 
        /// <para>
        /// The capabilities (<code>audio</code>, <code>video</code>, or <code>content</code>)
        /// that you want to grant an attendee. If you don't specify capabilities, all users have
        /// send and receive capabilities on all media channels by default.
        /// </para>
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
        /// the attendee turned on their video or content streams, remote attendess can receive
        /// those streams, but only after media renegotiation between the client and the Amazon
        /// Chime back-end server.
        /// </para>
        ///  </li> </ul>
        /// </summary>
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
        /// Gets and sets the property ExternalUserId. 
        /// <para>
        /// The Amazon Chime SDK external user ID. An idempotency token. Links the attendee to
        /// an identity managed by a builder application.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Sensitive=true, Min=2, Max=64)]
        public string ExternalUserId
        {
            get { return this._externalUserId; }
            set { this._externalUserId = value; }
        }

        // Check to see if ExternalUserId property is set
        internal bool IsSetExternalUserId()
        {
            return this._externalUserId != null;
        }

        /// <summary>
        /// Gets and sets the property MeetingId. 
        /// <para>
        /// The unique ID of the meeting.
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