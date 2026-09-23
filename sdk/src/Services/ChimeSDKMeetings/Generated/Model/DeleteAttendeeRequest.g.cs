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
 * Do not modify this file. This file is generated from the smithy.json service model.
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
    /// Container for the parameters to the DeleteAttendee operation. Deletes an attendee
    /// from the specified Amazon Chime SDK meeting and deletes their <c>JoinToken</c>. Attendees
    /// are automatically deleted when a Amazon Chime SDK meeting is deleted. For more information
    /// about the Amazon Chime SDK, see <a href="https://docs.aws.amazon.com/chime-sdk/latest/dg/meetings-sdk.html">Using
    /// the Amazon Chime SDK</a> in the <i>Amazon Chime Developer Guide</i>.
    /// </summary>
    public partial class DeleteAttendeeRequest : AmazonChimeSDKMeetingsRequest
    {
        /// <summary>
        /// Gets and sets the property AttendeeId. 
        /// <para>
        /// The Amazon Chime SDK attendee ID.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public string AttendeeId { get; set; }

        /// <summary>
        /// Checks to see if the AttendeeId property is set.
        /// </summary>
        internal bool IsSetAttendeeId() => this.AttendeeId != null;

        /// <summary>
        /// Gets and sets the property MeetingId. 
        /// <para>
        /// The Amazon Chime SDK meeting ID.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public string MeetingId { get; set; }

        /// <summary>
        /// Checks to see if the MeetingId property is set.
        /// </summary>
        internal bool IsSetMeetingId() => this.MeetingId != null;
    }
}
