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
    /// Lists the content (screen share) features for the meeting. Applies to all attendees.
    /// 
    ///  <note> 
    /// <para>
    /// If you specify <code>MeetingFeatures:Content:MaxResolution:None</code> when you create
    /// a meeting, all API requests that include <code>SendReceive</code>, <code>Send</code>,
    /// or <code>Receive</code> for <code>AttendeeCapabilities:Content</code> will be rejected
    /// with <code>ValidationError 400</code>.
    /// </para>
    ///  </note>
    /// </summary>
    public partial class ContentFeatures
    {
        private ContentResolution _maxResolution;

        /// <summary>
        /// Gets and sets the property MaxResolution. 
        /// <para>
        /// The maximum resolution for the meeting content.
        /// </para>
        ///  <note> 
        /// <para>
        /// Defaults to <code>FHD</code>. To use <code>UHD</code>, you must also provide a <code>MeetingFeatures:Attendee:MaxCount</code>
        /// value and override the default size limit of 250 attendees.
        /// </para>
        ///  </note>
        /// </summary>
        public ContentResolution MaxResolution
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