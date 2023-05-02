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
    /// The media capabilities of an attendee: audio, video, or content. 
    /// 
    ///  <note> 
    /// <para>
    /// You use the capabilities with a set of values that control what the capabilities can
    /// do, such as <code>SendReceive</code> data. For more information about those values,
    /// see .
    /// </para>
    ///  </note> 
    /// <para>
    /// When using capabilities, be aware of these corner cases:
    /// </para>
    ///  <ul> <li> 
    /// <para>
    /// You can't set <code>content</code> capabilities to <code>SendReceive</code> or <code>Receive</code>
    /// unless you also set <code>video</code> capabilities to <code>SendReceive</code> or
    /// <code>Receive</code>. If you don't set the <code>video</code> capability to receive,
    /// the response will contain an HTTP 400 Bad Request status code. However, you can set
    /// your <code>video</code> capability to receive and you set your <code>content</code>
    /// capability to not receive.
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// When you change an <code>audio</code> capability from <code>None</code> or <code>Receive</code>
    /// to <code>Send</code> or <code>SendReceive</code> , and if the attendee left their
    /// microphone unmuted, audio will flow from the attendee to the other meeting participants.
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// When you change a <code>video</code> or <code>content</code> capability from <code>None</code>
    /// or <code>Receive</code> to <code>Send</code> or <code>SendReceive</code> , and if
    /// the attendee turned on their video or content streams, remote attendees can receive
    /// those streams, but only after media renegotiation between the client and the Amazon
    /// Chime back-end server.
    /// </para>
    ///  </li> </ul>
    /// </summary>
    public partial class AttendeeCapabilities
    {
        private MediaCapabilities _audio;
        private MediaCapabilities _content;
        private MediaCapabilities _video;

        /// <summary>
        /// Gets and sets the property Audio. 
        /// <para>
        /// The audio capability assigned to an attendee.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public MediaCapabilities Audio
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
        /// The content capability assigned to an attendee.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public MediaCapabilities Content
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
        /// The video capability assigned to an attendee.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public MediaCapabilities Video
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