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
    /// Container for the parameters to the BatchCreateAttendee operation.
    /// Creates up to 100 attendees for an active Amazon Chime SDK meeting. For more information
    /// about the Amazon Chime SDK, see <a href="https://docs.aws.amazon.com/chime/latest/dg/meetings-sdk.html">Using
    /// the Amazon Chime SDK</a> in the <i>Amazon Chime Developer Guide</i>.
    /// </summary>
    public partial class BatchCreateAttendeeRequest : AmazonChimeSDKMeetingsRequest
    {
        private List<CreateAttendeeRequestItem> _attendees = AWSConfigs.InitializeCollections ? new List<CreateAttendeeRequestItem>() : null;
        private string _meetingId;

        /// <summary>
        /// Gets and sets the property Attendees. 
        /// <para>
        /// The attendee information, including attendees' IDs and join tokens.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=100)]
        public List<CreateAttendeeRequestItem> Attendees
        {
            get { return this._attendees; }
            set { this._attendees = value; }
        }

        // Check to see if Attendees property is set
        internal bool IsSetAttendees()
        {
            return this._attendees != null && (this._attendees.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property MeetingId. 
        /// <para>
        /// The Amazon Chime SDK ID of the meeting to which you're adding attendees.
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