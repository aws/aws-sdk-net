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
        /// The capabilities (<c>audio</c>, <c>video</c>, or <c>content</c>) that you want to
        /// grant an attendee. If you don't specify capabilities, all users have send and receive
        /// capabilities on all media channels by default.
        /// </para>
        ///  <note> 
        /// <para>
        /// You use the capabilities with a set of values that control what the capabilities can
        /// do, such as <c>SendReceive</c> data. For more information about those values, see
        /// .
        /// </para>
        ///  </note> 
        /// <para>
        /// When using capabilities, be aware of these corner cases:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// If you specify <c>MeetingFeatures:Video:MaxResolution:None</c> when you create a meeting,
        /// all API requests that include <c>SendReceive</c>, <c>Send</c>, or <c>Receive</c> for
        /// <c>AttendeeCapabilities:Video</c> will be rejected with <c>ValidationError 400</c>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// If you specify <c>MeetingFeatures:Content:MaxResolution:None</c> when you create a
        /// meeting, all API requests that include <c>SendReceive</c>, <c>Send</c>, or <c>Receive</c>
        /// for <c>AttendeeCapabilities:Content</c> will be rejected with <c>ValidationError 400</c>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You can't set <c>content</c> capabilities to <c>SendReceive</c> or <c>Receive</c>
        /// unless you also set <c>video</c> capabilities to <c>SendReceive</c> or <c>Receive</c>.
        /// If you don't set the <c>video</c> capability to receive, the response will contain
        /// an HTTP 400 Bad Request status code. However, you can set your <c>video</c> capability
        /// to receive and you set your <c>content</c> capability to not receive.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// When you change an <c>audio</c> capability from <c>None</c> or <c>Receive</c> to <c>Send</c>
        /// or <c>SendReceive</c> , and if the attendee left their microphone unmuted, audio will
        /// flow from the attendee to the other meeting participants.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// When you change a <c>video</c> or <c>content</c> capability from <c>None</c> or <c>Receive</c>
        /// to <c>Send</c> or <c>SendReceive</c> , and if the attendee turned on their video or
        /// content streams, remote attendees can receive those streams, but only after media
        /// renegotiation between the client and the Amazon Chime back-end server.
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
        ///  
        /// <para>
        /// Pattern: <c>[-_&amp;@+=,(){}\[\]\/«».:|'"#a-zA-Z0-9À-ÿ\s]*</c> 
        /// </para>
        ///  
        /// <para>
        /// Values that begin with <c>aws:</c> are reserved. You can't configure a value that
        /// uses this prefix.
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