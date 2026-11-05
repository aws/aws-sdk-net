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

namespace Amazon.MediaLive.Model
{
    /// <summary>
    /// Video settings for this stream.
    /// </summary>
    public partial class VideoDescription
    {
        /// <summary>
        /// Gets and sets the property Border. Specifies the number of pixels of black border
        /// that will be inserted around the edge of the encoded picture. Must be an even integer
        /// from 0 (no border, the default) up to 100. The width and height of the VideoDescription
        /// must each be greater than twice this value. Cannot be used together with {@link outputPositionRectangle}
        /// -- both govern the position of the encoded content within the output frame.
        /// </summary>
        public int? Border { get; set; }

        /// <summary>
        /// Checks to see if the Border property is set.
        /// </summary>
        internal bool IsSetBorder() => this.Border.HasValue;

        /// <summary>
        /// Gets and sets the property CodecSettings. Video codec settings.
        /// </summary>
        public VideoCodecSettings CodecSettings { get; set; }

        /// <summary>
        /// Checks to see if the CodecSettings property is set.
        /// </summary>
        internal bool IsSetCodecSettings() => this.CodecSettings != null;

        /// <summary>
        /// Gets and sets the property CropRectangle. Region of the input video to crop before
        /// scaling. If not specified, the entire input frame is used. Note: Unlike {@link outputPositionRectangle},
        /// the bounds of cropRectangle are validated at ingest time by the encoder/scaler rather
        /// than at the API level, because the input resolution is not known until the source
        /// is probed. Field-level constraints on (x, y, width, height) defined on {@link VideoPositionRectangle}
        /// still apply.
        /// </summary>
        public VideoPositionRectangle CropRectangle { get; set; }

        /// <summary>
        /// Checks to see if the CropRectangle property is set.
        /// </summary>
        internal bool IsSetCropRectangle() => this.CropRectangle != null;

        /// <summary>
        /// Gets and sets the property Height. Output video height, in pixels. Must be an even
        /// number. For most codecs, you can leave this field and width blank in order to use
        /// the height and width (resolution) from the source. Note, however, that leaving blank
        /// is not recommended. For the Frame Capture codec, height and width are required.
        /// </summary>
        public int? Height { get; set; }

        /// <summary>
        /// Checks to see if the Height property is set.
        /// </summary>
        internal bool IsSetHeight() => this.Height.HasValue;

        /// <summary>
        /// Gets and sets the property Name. The name of this VideoDescription. Outputs will use
        /// this name to uniquely identify this Description. Description names should be unique
        /// within this Live Event.
        /// </summary>
        [AWSProperty(Required = true)]
        public string Name { get; set; }

        /// <summary>
        /// Checks to see if the Name property is set.
        /// </summary>
        internal bool IsSetName() => this.Name != null;

        /// <summary>
        /// Gets and sets the property OutputPositionRectangle. Position of the encoded video
        /// within the output frame. The area outside the rectangle is filled with black. If not
        /// specified, the video fills the entire output frame. When used, both {@link width}
        /// and {@link height} of the VideoDescription must be explicitly specified so that the
        /// rectangle can be validated against the output frame.
        /// </summary>
        public VideoPositionRectangle OutputPositionRectangle { get; set; }

        /// <summary>
        /// Checks to see if the OutputPositionRectangle property is set.
        /// </summary>
        internal bool IsSetOutputPositionRectangle() => this.OutputPositionRectangle != null;

        /// <summary>
        /// Gets and sets the property RespondToAfd. Indicates how MediaLive will respond to the
        /// AFD values that might be in the input video. If you do not know what AFD signaling
        /// is, or if your downstream system has not given you guidance, choose PASSTHROUGH. RESPOND:
        /// MediaLive clips the input video using a formula that uses the AFD values (configured
        /// in afdSignaling ), the input display aspect ratio, and the output display aspect ratio.
        /// MediaLive also includes the AFD values in the output, unless the codec for this encode
        /// is FRAME_CAPTURE. PASSTHROUGH: MediaLive ignores the AFD values and does not clip
        /// the video. But MediaLive does include the values in the output. NONE: MediaLive does
        /// not clip the input video and does not include the AFD values in the output
        /// </summary>
        public VideoDescriptionRespondToAfd RespondToAfd { get; set; }

        /// <summary>
        /// Checks to see if the RespondToAfd property is set.
        /// </summary>
        internal bool IsSetRespondToAfd() => this.RespondToAfd != null;

        /// <summary>
        /// Gets and sets the property ScalingBehavior. Configures how MediaLive transforms the
        /// video picture to match the output frame. Use STRETCH_TO_OUTPUT to stretch the video
        /// to fill the output frame. The video might get distorted. Use DEFAULT to insert pillar
        /// boxes or letter boxes around the video to fill the output frame. The video won't get
        /// distorted. Use SMART_CROP to enable the smart crop feature that uses the Elemental
        /// Inference service to crop the frame using AI - see the MediaLive User Guide for more
        /// information.
        /// </summary>
        public VideoDescriptionScalingBehavior ScalingBehavior { get; set; }

        /// <summary>
        /// Checks to see if the ScalingBehavior property is set.
        /// </summary>
        internal bool IsSetScalingBehavior() => this.ScalingBehavior != null;

        /// <summary>
        /// Gets and sets the property Sharpness. Changes the strength of the anti-alias filter
        /// used for scaling. 0 is the softest setting, 100 is the sharpest. A setting of 50 is
        /// recommended for most content.
        /// </summary>
        public int? Sharpness { get; set; }

        /// <summary>
        /// Checks to see if the Sharpness property is set.
        /// </summary>
        internal bool IsSetSharpness() => this.Sharpness.HasValue;

        /// <summary>
        /// Gets and sets the property Width. Output video width, in pixels. Must be an even number.
        /// For most codecs, you can leave this field and height blank in order to use the height
        /// and width (resolution) from the source. Note, however, that leaving blank is not recommended.
        /// For the Frame Capture codec, height and width are required.
        /// </summary>
        public int? Width { get; set; }

        /// <summary>
        /// Checks to see if the Width property is set.
        /// </summary>
        internal bool IsSetWidth() => this.Width.HasValue;
    }
}
