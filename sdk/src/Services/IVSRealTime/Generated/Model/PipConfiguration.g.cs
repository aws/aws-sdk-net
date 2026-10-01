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

namespace Amazon.IVSRealTime.Model
{
    /// <summary>
    /// Configuration information specific to Picture-in-Picture (PiP) layout, for <a href="https://docs.aws.amazon.com/ivs/latest/RealTimeUserGuide/server-side-composition.html">server-side
    /// composition</a>.
    /// </summary>
    public partial class PipConfiguration
    {
        /// <summary>
        /// Gets and sets the property FeaturedParticipantAttribute. 
        /// <para>
        /// This attribute name identifies the featured slot. A participant with this attribute
        /// set to <c>"true"</c> (as a string value) in <a>ParticipantTokenConfiguration</a> is
        /// placed in the featured slot. Default: <c>""</c> (no featured participant).
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 128)]
        public string FeaturedParticipantAttribute { get; set; }

        /// <summary>
        /// Checks to see if the FeaturedParticipantAttribute property is set.
        /// </summary>
        internal bool IsSetFeaturedParticipantAttribute() => this.FeaturedParticipantAttribute != null;

        /// <summary>
        /// Gets and sets the property GridGap. 
        /// <para>
        /// Specifies the spacing between participant tiles in pixels. Default: <c>0</c>.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0)]
        public int? GridGap { get; set; }

        /// <summary>
        /// Checks to see if the GridGap property is set.
        /// </summary>
        internal bool IsSetGridGap() => this.GridGap.HasValue;

        /// <summary>
        /// Gets and sets the property OmitStoppedVideo. 
        /// <para>
        /// Determines whether to omit participants with stopped video in the composition. Default:
        /// <c>false</c>.
        /// </para>
        /// </summary>
        public bool? OmitStoppedVideo { get; set; }

        /// <summary>
        /// Checks to see if the OmitStoppedVideo property is set.
        /// </summary>
        internal bool IsSetOmitStoppedVideo() => this.OmitStoppedVideo.HasValue;

        /// <summary>
        /// Gets and sets the property ParticipantOrderAttribute. 
        /// <para>
        /// Attribute name in <a>ParticipantTokenConfiguration</a> identifying the participant
        /// ordering key. Participants with <c>participantOrderAttribute</c> set to <c>""</c>
        /// or not specified are ordered based on their arrival time into the stage.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 128)]
        public string ParticipantOrderAttribute { get; set; }

        /// <summary>
        /// Checks to see if the ParticipantOrderAttribute property is set.
        /// </summary>
        internal bool IsSetParticipantOrderAttribute() => this.ParticipantOrderAttribute != null;

        /// <summary>
        /// Gets and sets the property PipBehavior. 
        /// <para>
        /// Defines PiP behavior when all participants have left: <c>STATIC</c> (maintains original
        /// position/size) or <c>DYNAMIC</c> (expands to full composition). Default: <c>STATIC</c>.
        /// </para>
        /// </summary>
        public PipBehavior PipBehavior { get; set; }

        /// <summary>
        /// Checks to see if the PipBehavior property is set.
        /// </summary>
        internal bool IsSetPipBehavior() => this.PipBehavior != null;

        /// <summary>
        /// Gets and sets the property PipHeight. 
        /// <para>
        /// Specifies the height of the PiP window in pixels. When this is not set explicitly,
        /// <c>pipHeight</c>’s value will be based on the size of the composition and the aspect
        /// ratio of the participant’s video.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1)]
        public int? PipHeight { get; set; }

        /// <summary>
        /// Checks to see if the PipHeight property is set.
        /// </summary>
        internal bool IsSetPipHeight() => this.PipHeight.HasValue;

        /// <summary>
        /// Gets and sets the property PipOffset. 
        /// <para>
        /// Sets the PiP window’s offset position in pixels from the closest edges determined
        /// by <c>PipPosition</c>. Default: <c>0</c>.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0)]
        public int? PipOffset { get; set; }

        /// <summary>
        /// Checks to see if the PipOffset property is set.
        /// </summary>
        internal bool IsSetPipOffset() => this.PipOffset.HasValue;

        /// <summary>
        /// Gets and sets the property PipParticipantAttribute. 
        /// <para>
        /// Specifies the participant for the PiP window. A participant with this attribute set
        /// to <c>"true"</c> (as a string value) in <a>ParticipantTokenConfiguration</a> is placed
        /// in the PiP slot. Default: <c>""</c> (no PiP participant).
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 128)]
        public string PipParticipantAttribute { get; set; }

        /// <summary>
        /// Checks to see if the PipParticipantAttribute property is set.
        /// </summary>
        internal bool IsSetPipParticipantAttribute() => this.PipParticipantAttribute != null;

        /// <summary>
        /// Gets and sets the property PipPosition. 
        /// <para>
        /// Determines the corner position of the PiP window. Default: <c>BOTTOM_RIGHT</c>.
        /// </para>
        /// </summary>
        public PipPosition PipPosition { get; set; }

        /// <summary>
        /// Checks to see if the PipPosition property is set.
        /// </summary>
        internal bool IsSetPipPosition() => this.PipPosition != null;

        /// <summary>
        /// Gets and sets the property PipWidth. 
        /// <para>
        /// Specifies the width of the PiP window in pixels. When this is not set explicitly,
        /// <c>pipWidth</c>’s value will be based on the size of the composition and the aspect
        /// ratio of the participant’s video.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1)]
        public int? PipWidth { get; set; }

        /// <summary>
        /// Checks to see if the PipWidth property is set.
        /// </summary>
        internal bool IsSetPipWidth() => this.PipWidth.HasValue;

        /// <summary>
        /// Gets and sets the property VideoFillMode. 
        /// <para>
        /// Defines how video content fits within the participant tile: <c>FILL</c> (stretched),
        /// <c>COVER</c> (cropped), or <c>CONTAIN</c> (letterboxed). Default: <c>COVER</c>.
        /// </para>
        /// </summary>
        public VideoFillMode VideoFillMode { get; set; }

        /// <summary>
        /// Checks to see if the VideoFillMode property is set.
        /// </summary>
        internal bool IsSetVideoFillMode() => this.VideoFillMode != null;
    }
}
