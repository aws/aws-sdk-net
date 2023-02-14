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
    /// A meeting created using the Amazon Chime SDK.
    /// </summary>
    public partial class Meeting
    {
        private string _externalMeetingId;
        private MediaPlacement _mediaPlacement;
        private string _mediaRegion;
        private string _meetingId;

        /// <summary>
        /// Gets and sets the property ExternalMeetingId. 
        /// <para>
        /// The external meeting ID.
        /// </para>
        /// </summary>
        [AWSProperty(Sensitive=true, Min=2, Max=64)]
        public string ExternalMeetingId
        {
            get { return this._externalMeetingId; }
            set { this._externalMeetingId = value; }
        }

        // Check to see if ExternalMeetingId property is set
        internal bool IsSetExternalMeetingId()
        {
            return this._externalMeetingId != null;
        }

        /// <summary>
        /// Gets and sets the property MediaPlacement. 
        /// <para>
        /// The media placement for the meeting.
        /// </para>
        /// </summary>
        public MediaPlacement MediaPlacement
        {
            get { return this._mediaPlacement; }
            set { this._mediaPlacement = value; }
        }

        // Check to see if MediaPlacement property is set
        internal bool IsSetMediaPlacement()
        {
            return this._mediaPlacement != null;
        }

        /// <summary>
        /// Gets and sets the property MediaRegion. 
        /// <para>
        /// The Region in which you create the meeting. Available values: <code>af-south-1</code>,
        /// <code>ap-northeast-1</code>, <code>ap-northeast-2</code>, <code>ap-south-1</code>,
        /// <code>ap-southeast-1</code>, <code>ap-southeast-2</code>, <code>ca-central-1</code>,
        /// <code>eu-central-1</code>, <code>eu-north-1</code>, <code>eu-south-1</code>, <code>eu-west-1</code>,
        /// <code>eu-west-2</code>, <code>eu-west-3</code>, <code>sa-east-1</code>, <code>us-east-1</code>,
        /// <code>us-east-2</code>, <code>us-west-1</code>, <code>us-west-2</code>.
        /// </para>
        /// </summary>
        public string MediaRegion
        {
            get { return this._mediaRegion; }
            set { this._mediaRegion = value; }
        }

        // Check to see if MediaRegion property is set
        internal bool IsSetMediaRegion()
        {
            return this._mediaRegion != null;
        }

        /// <summary>
        /// Gets and sets the property MeetingId. 
        /// <para>
        /// The Amazon Chime SDK meeting ID.
        /// </para>
        /// </summary>
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