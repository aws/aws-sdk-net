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
    /// The video streams to capture for a specified media capture pipeline. The total number
    /// of video streams can't exceed 25.
    /// </summary>
    public partial class SelectedVideoStreams
    {
        private List<string> _attendeeIds = new List<string>();
        private List<string> _externalUserIds = new List<string>();

        /// <summary>
        /// Gets and sets the property AttendeeIds. 
        /// <para>
        /// The attendee IDs of the streams selected for a media capture pipeline. 
        /// </para>
        /// </summary>
        [AWSProperty(Min=1)]
        public List<string> AttendeeIds
        {
            get { return this._attendeeIds; }
            set { this._attendeeIds = value; }
        }

        // Check to see if AttendeeIds property is set
        internal bool IsSetAttendeeIds()
        {
            return this._attendeeIds != null && this._attendeeIds.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property ExternalUserIds. 
        /// <para>
        /// The external user IDs of the streams selected for a media capture pipeline.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1)]
        public List<string> ExternalUserIds
        {
            get { return this._externalUserIds; }
            set { this._externalUserIds = value; }
        }

        // Check to see if ExternalUserIds property is set
        internal bool IsSetExternalUserIds()
        {
            return this._externalUserIds != null && this._externalUserIds.Count > 0; 
        }

    }
}