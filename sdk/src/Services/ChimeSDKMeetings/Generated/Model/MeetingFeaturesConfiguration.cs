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
    /// The configuration settings of the features available to a meeting.
    /// </summary>
    public partial class MeetingFeaturesConfiguration
    {
        private AttendeeFeatures _attendee;
        private AudioFeatures _audio;
        private ContentFeatures _content;
        private VideoFeatures _video;

        /// <summary>
        /// Gets and sets the property Attendee. 
        /// <para>
        /// The configuration settings for the attendee features available to a meeting.
        /// </para>
        /// </summary>
        public AttendeeFeatures Attendee
        {
            get { return this._attendee; }
            set { this._attendee = value; }
        }

        // Check to see if Attendee property is set
        internal bool IsSetAttendee()
        {
            return this._attendee != null;
        }

        /// <summary>
        /// Gets and sets the property Audio. 
        /// <para>
        /// The configuration settings for the audio features available to a meeting.
        /// </para>
        /// </summary>
        public AudioFeatures Audio
        {
            get { return this._audio; }
            set { this._audio = value; }
        }

        // Check to see if Audio property is set
        internal bool IsSetAudio()
        {
            return this._audio != null;
        }

        /// <summary>
        /// Gets and sets the property Content. 
        /// <para>
        /// The configuration settings for the content features available to a meeting.
        /// </para>
        /// </summary>
        public ContentFeatures Content
        {
            get { return this._content; }
            set { this._content = value; }
        }

        // Check to see if Content property is set
        internal bool IsSetContent()
        {
            return this._content != null;
        }

        /// <summary>
        /// Gets and sets the property Video. 
        /// <para>
        /// The configuration settings for the video features available to a meeting.
        /// </para>
        /// </summary>
        public VideoFeatures Video
        {
            get { return this._video; }
            set { this._video = value; }
        }

        // Check to see if Video property is set
        internal bool IsSetVideo()
        {
            return this._video != null;
        }

    }
}