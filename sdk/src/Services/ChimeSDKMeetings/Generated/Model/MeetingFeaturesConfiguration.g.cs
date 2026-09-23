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
    /// The configuration settings of the features available to a meeting.
    /// </summary>
    public partial class MeetingFeaturesConfiguration
    {
        /// <summary>
        /// Gets and sets the property Attendee. 
        /// <para>
        /// The configuration settings for the attendee features available to a meeting.
        /// </para>
        /// </summary>
        public AttendeeFeatures Attendee { get; set; }

        /// <summary>
        /// Checks to see if the Attendee property is set.
        /// </summary>
        internal bool IsSetAttendee() => this.Attendee != null;

        /// <summary>
        /// Gets and sets the property Audio. 
        /// <para>
        /// The configuration settings for the audio features available to a meeting.
        /// </para>
        /// </summary>
        public AudioFeatures Audio { get; set; }

        /// <summary>
        /// Checks to see if the Audio property is set.
        /// </summary>
        internal bool IsSetAudio() => this.Audio != null;

        /// <summary>
        /// Gets and sets the property Content. 
        /// <para>
        /// The configuration settings for the content features available to a meeting.
        /// </para>
        /// </summary>
        public ContentFeatures Content { get; set; }

        /// <summary>
        /// Checks to see if the Content property is set.
        /// </summary>
        internal bool IsSetContent() => this.Content != null;

        /// <summary>
        /// Gets and sets the property Video. 
        /// <para>
        /// The configuration settings for the video features available to a meeting.
        /// </para>
        /// </summary>
        public VideoFeatures Video { get; set; }

        /// <summary>
        /// Checks to see if the Video property is set.
        /// </summary>
        internal bool IsSetVideo() => this.Video != null;
    }
}
