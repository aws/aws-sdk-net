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

namespace Amazon.IVSRealTime.Model
{
    /// <summary>
    /// Configuration information specific to Picture-in-Picture (PiP) layout, for <a href="https://docs.aws.amazon.com/ivs/latest/RealTimeUserGuide/server-side-composition.html">server-side
    /// composition</a>.
    /// </summary>
    public partial class PipConfiguration
    {
        private string _featuredParticipantAttribute;
        private int? _gridGap;
        private bool? _omitStoppedVideo;
        private PipBehavior _pipBehavior;
        private int? _pipHeight;
        private int? _pipOffset;
        private string _pipParticipantAttribute;
        private PipPosition _pipPosition;
        private int? _pipWidth;
        private VideoFillMode _videoFillMode;

        /// <summary>
        /// Gets and sets the property FeaturedParticipantAttribute. 
        /// <para>
        /// This attribute name identifies the featured slot. A participant with this attribute
        /// set to <c>"true"</c> (as a string value) in <a>ParticipantTokenConfiguration</a> is
        /// placed in the featured slot.
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
        /// Specifies the spacing between participant tiles in pixels. Default: <c>0</c>.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0)]
        public int GridGap
        {
            get { return this._gridGap.GetValueOrDefault(); }
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
        public bool OmitStoppedVideo
        {
            get { return this._omitStoppedVideo.GetValueOrDefault(); }
            set { this._omitStoppedVideo = value; }
        }

        // Check to see if OmitStoppedVideo property is set
        internal bool IsSetOmitStoppedVideo()
        {
            return this._omitStoppedVideo.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property PipBehavior. 
        /// <para>
        /// Defines PiP behavior when all participants have left. Default: <c>STATIC</c>.
        /// </para>
        /// </summary>
        public PipBehavior PipBehavior
        {
            get { return this._pipBehavior; }
            set { this._pipBehavior = value; }
        }

        // Check to see if PipBehavior property is set
        internal bool IsSetPipBehavior()
        {
            return this._pipBehavior != null;
        }

        /// <summary>
        /// Gets and sets the property PipHeight. 
        /// <para>
        /// Specifies the height of the PiP window in pixels. When this is not set explicitly,
        /// <c>pipHeight</c>’s value will be based on the size of the composition and the aspect
        /// ratio of the participant’s video.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1)]
        public int PipHeight
        {
            get { return this._pipHeight.GetValueOrDefault(); }
            set { this._pipHeight = value; }
        }

        // Check to see if PipHeight property is set
        internal bool IsSetPipHeight()
        {
            return this._pipHeight.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property PipOffset. 
        /// <para>
        /// Sets the PiP window’s offset position in pixels from the closest edges determined
        /// by <c>PipPosition</c>. Default: <c>0</c>.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0)]
        public int PipOffset
        {
            get { return this._pipOffset.GetValueOrDefault(); }
            set { this._pipOffset = value; }
        }

        // Check to see if PipOffset property is set
        internal bool IsSetPipOffset()
        {
            return this._pipOffset.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property PipParticipantAttribute. 
        /// <para>
        /// Identifies the PiP slot. A participant with this attribute set to <c>"true"</c> (as
        /// a string value) in <a>ParticipantTokenConfiguration</a> is placed in the PiP slot.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=128)]
        public string PipParticipantAttribute
        {
            get { return this._pipParticipantAttribute; }
            set { this._pipParticipantAttribute = value; }
        }

        // Check to see if PipParticipantAttribute property is set
        internal bool IsSetPipParticipantAttribute()
        {
            return this._pipParticipantAttribute != null;
        }

        /// <summary>
        /// Gets and sets the property PipPosition. 
        /// <para>
        /// Determines the corner position of the PiP window. Default: <c>BOTTOM_RIGHT</c>.
        /// </para>
        /// </summary>
        public PipPosition PipPosition
        {
            get { return this._pipPosition; }
            set { this._pipPosition = value; }
        }

        // Check to see if PipPosition property is set
        internal bool IsSetPipPosition()
        {
            return this._pipPosition != null;
        }

        /// <summary>
        /// Gets and sets the property PipWidth. 
        /// <para>
        /// Specifies the width of the PiP window in pixels. When this is not set explicitly,
        /// <c>pipWidth</c>’s value will be based on the size of the composition and the aspect
        /// ratio of the participant’s video.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1)]
        public int PipWidth
        {
            get { return this._pipWidth.GetValueOrDefault(); }
            set { this._pipWidth = value; }
        }

        // Check to see if PipWidth property is set
        internal bool IsSetPipWidth()
        {
            return this._pipWidth.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property VideoFillMode. 
        /// <para>
        /// Defines how video fits within the participant tile. Default: <c>COVER</c>. 
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