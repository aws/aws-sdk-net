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
 * Do not modify this file. This file is generated from the chime-2018-05-01.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.Chime.Model
{
    /// <summary>
    /// Container for the parameters to the ListAttendeeTags operation.
    /// Lists the tags applied to an Amazon Chime SDK attendee resource.
    /// 
    ///  <important> 
    /// <para>
    /// ListAttendeeTags is not supported in the Amazon Chime SDK Meetings Namespace. Update
    /// your application to remove calls to this API.
    /// </para>
    ///  </important>
    /// </summary>
    public partial class ListAttendeeTagsRequest : AmazonChimeRequest
    {
        private string _attendeeId;
        private string _meetingId;

        /// <summary>
        /// Gets and sets the property AttendeeId. 
        /// <para>
        /// The Amazon Chime SDK attendee ID.
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
        /// Gets and sets the property MeetingId. 
        /// <para>
        /// The Amazon Chime SDK meeting ID.
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