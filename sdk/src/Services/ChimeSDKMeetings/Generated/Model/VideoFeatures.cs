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
    /// The video features set for the meeting. Applies to all attendees.
    /// 
    ///  <note> 
    /// <para>
    /// If you specify <c>MeetingFeatures:Video:MaxResolution:None</c> when you create a meeting,
    /// all API requests that include <c>SendReceive</c>, <c>Send</c>, or <c>Receive</c> for
    /// <c>AttendeeCapabilities:Video</c> will be rejected with <c>ValidationError 400</c>.
    /// </para>
    ///  </note>
    /// </summary>
    public partial class VideoFeatures
    {
        private VideoResolution _maxResolution;

        /// <summary>
        /// Gets and sets the property MaxResolution. 
        /// <para>
        /// The maximum video resolution for the meeting. Applies to all attendees.
        /// </para>
        ///  <note> 
        /// <para>
        /// Defaults to <c>HD</c>. To use <c>FHD</c>, you must also provide a <c>MeetingFeatures:Attendee:MaxCount</c>
        /// value and override the default size limit of 250 attendees.
        /// </para>
        ///  </note>
        /// </summary>
        public VideoResolution MaxResolution
        {
            get { return this._maxResolution; }
            set { this._maxResolution = value; }
        }

        // Check to see if MaxResolution property is set
        internal bool IsSetMaxResolution()
        {
            return this._maxResolution != null;
        }

    }
}