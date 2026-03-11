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
 * Do not modify this file. This file is generated from the ivs-realtime-2020-07-14.normal.json service model.
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
namespace Amazon.IVSRealTime.Model
{
    /// <summary>
    /// Configuration information specific to Grid layout, for server-side composition. See
    /// "Layouts" in <a href="https://docs.aws.amazon.com/ivs/latest/RealTimeUserGuide/server-side-composition.html">Server-Side
    /// Composition</a>.
    /// </summary>
    public partial class GridConfiguration
    {
        private string _featuredParticipantAttribute;
        private int? _gridGap;
        private bool? _omitStoppedVideo;
        private string _participantOrderAttribute;
        private VideoAspectRatio _videoAspectRatio;
        private VideoFillMode _videoFillMode;

        /// <summary>
        /// Gets and sets the property FeaturedParticipantAttribute. 
        /// <para>
        /// This attribute name identifies the featured slot. A participant with this attribute
        /// set to <c>"true"</c> (as a string value) in <a>ParticipantTokenConfiguration</a> is
        /// placed in the featured slot. Default: <c>""</c> (no featured participant).
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=128)]
        public string FeaturedParticipantAttribute
        {
            get { return this._featuredParticipantAttribute; }
            set { this._featuredParticipantAttribute = value; }
        }

        // Check to see if FeaturedParticipantAttribute property is set
        internal bool IsSetFeaturedParticipantAttribute()
        {
            return this._featuredParticipantAttribute != null;
        }

        /// <summary>
        /// Gets and sets the property GridGap. 
        /// <para>
        /// Specifies the spacing between participant tiles in pixels. Default: <c>2</c>.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0)]
        public int? GridGap
        {
            get { return this._gridGap; }
            set { this._gridGap = value; }
        }

        // Check to see if GridGap property is set
        internal bool IsSetGridGap()
        {
            return this._gridGap.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property OmitStoppedVideo. 
        /// <para>
        /// Determines whether to omit participants with stopped video in the composition. Default:
        /// <c>false</c>.
        /// </para>
        /// </summary>
        public bool? OmitStoppedVideo
        {
            get { return this._omitStoppedVideo; }
            set { this._omitStoppedVideo = value; }
        }

        // Check to see if OmitStoppedVideo property is set
        internal bool IsSetOmitStoppedVideo()
        {
            return this._omitStoppedVideo.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property ParticipantOrderAttribute. 
        /// <para>
        /// Attribute name in <a>ParticipantTokenConfiguration</a> identifying the participant
        /// ordering key. Participants with <c>participantOrderAttribute</c> set to <c>""</c>
        /// or not specified are ordered based on their arrival time into the stage.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=128)]
        public string ParticipantOrderAttribute
        {
            get { return this._participantOrderAttribute; }
            set { this._participantOrderAttribute = value; }
        }

        // Check to see if ParticipantOrderAttribute property is set
        internal bool IsSetParticipantOrderAttribute()
        {
            return this._participantOrderAttribute != null;
        }

        /// <summary>
        /// Gets and sets the property VideoAspectRatio. 
        /// <para>
        /// Sets the non-featured participant display mode, to control the aspect ratio of video
        /// tiles. <c>VIDEO</c> is 16:9, <c>SQUARE</c> is 1:1, and <c>PORTRAIT</c> is 3:4. Default:
        /// <c>VIDEO</c>.
        /// </para>
        /// </summary>
        public VideoAspectRatio VideoAspectRatio
        {
            get { return this._videoAspectRatio; }
            set { this._videoAspectRatio = value; }
        }

        // Check to see if VideoAspectRatio property is set
        internal bool IsSetVideoAspectRatio()
        {
            return this._videoAspectRatio != null;
        }

        /// <summary>
        /// Gets and sets the property VideoFillMode. 
        /// <para>
        /// Defines how video content fits within the participant tile: <c>FILL</c> (stretched),
        /// <c>COVER</c> (cropped), or <c>CONTAIN</c> (letterboxed). When not set, <c>videoFillMode</c>
        /// defaults to <c>COVER</c> fill mode for participants in the grid and to <c>CONTAIN</c>
        /// fill mode for featured participants.
        /// </para>
        /// </summary>
        public VideoFillMode VideoFillMode
        {
            get { return this._videoFillMode; }
            set { this._videoFillMode = value; }
        }

        // Check to see if VideoFillMode property is set
        internal bool IsSetVideoFillMode()
        {
            return this._videoFillMode != null;
        }

    }
}