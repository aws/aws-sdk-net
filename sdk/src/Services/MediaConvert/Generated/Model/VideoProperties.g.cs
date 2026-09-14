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

namespace Amazon.MediaConvert.Model
{
    /// <summary>
    /// Details about the media file's video track.
    /// </summary>
    public partial class VideoProperties
    {
        /// <summary>
        /// Gets and sets the property BitDepth. The number of bits used per color component such
        /// as 8, 10, or 12 bits. Standard range (SDR) video typically uses 8-bit, while 10-bit
        /// is common for high dynamic range (HDR).
        /// </summary>
        public int? BitDepth { get; set; }

        /// <summary>
        /// Checks to see if the BitDepth property is set.
        /// </summary>
        internal bool IsSetBitDepth() => this.BitDepth.HasValue;

        /// <summary>
        /// Gets and sets the property BitRate. The bit rate of the video track, in bits per second.
        /// </summary>
        public long? BitRate { get; set; }

        /// <summary>
        /// Checks to see if the BitRate property is set.
        /// </summary>
        internal bool IsSetBitRate() => this.BitRate.HasValue;

        /// <summary>
        /// Gets and sets the property CodecMetadata. Codec-specific parameters parsed from the
        /// video essence headers. This information provides detailed technical specifications
        /// about how the video was encoded, including profile settings, resolution details, and
        /// color space information that can help you understand the source video characteristics
        /// and make informed encoding decisions.
        /// </summary>
        public CodecMetadata CodecMetadata { get; set; }

        /// <summary>
        /// Checks to see if the CodecMetadata property is set.
        /// </summary>
        internal bool IsSetCodecMetadata() => this.CodecMetadata != null;

        /// <summary>
        /// Gets and sets the property ColorPrimaries. The color space primaries of the video
        /// track, defining the red, green, and blue color coordinates used for the video. This
        /// information helps ensure accurate color reproduction during playback and transcoding.
        /// </summary>
        public ColorPrimaries ColorPrimaries { get; set; }

        /// <summary>
        /// Checks to see if the ColorPrimaries property is set.
        /// </summary>
        internal bool IsSetColorPrimaries() => this.ColorPrimaries != null;

        /// <summary>
        /// Gets and sets the property DisplayAspectRatio. An aspect ratio expressed as a fraction
        /// with numerator and denominator values, reduced to lowest terms. Used for the sample
        /// (pixel) aspect ratio and the display aspect ratio of a video track. For example, a
        /// 720x576 anamorphic track has a sample aspect ratio of 64 / 45 and a display aspect
        /// ratio of 16 / 9. A video track can declare an aspect ratio in two independent places,
        /// and MediaConvert reports each one where it was found rather than choosing between
        /// them. The ratio declared by the container appears on the video track itself, and the
        /// ratio declared by the video essence appears under codecMetadata. When a file declares
        /// an aspect ratio in only one of the two places, the other is null; when it declares
        /// both and they disagree, you can compare them and decide which to use.
        /// </summary>
        public AspectRatio DisplayAspectRatio { get; set; }

        /// <summary>
        /// Checks to see if the DisplayAspectRatio property is set.
        /// </summary>
        internal bool IsSetDisplayAspectRatio() => this.DisplayAspectRatio != null;

        /// <summary>
        /// Gets and sets the property FrameRate. The frame rate of the video or audio track,
        /// expressed as a fraction with numerator and denominator values.
        /// </summary>
        public FrameRate FrameRate { get; set; }

        /// <summary>
        /// Checks to see if the FrameRate property is set.
        /// </summary>
        internal bool IsSetFrameRate() => this.FrameRate != null;

        /// <summary>
        /// Gets and sets the property HdrMetadata. HDR (High Dynamic Range) metadata extracted
        /// from the container, including mastering display color volume and content light level
        /// information. This metadata is present in HDR10 and similar HDR content.
        /// </summary>
        public HdrMetadata HdrMetadata { get; set; }

        /// <summary>
        /// Checks to see if the HdrMetadata property is set.
        /// </summary>
        internal bool IsSetHdrMetadata() => this.HdrMetadata != null;

        /// <summary>
        /// Gets and sets the property Height. The height of the video track, in pixels.
        /// </summary>
        public int? Height { get; set; }

        /// <summary>
        /// Checks to see if the Height property is set.
        /// </summary>
        internal bool IsSetHeight() => this.Height.HasValue;

        /// <summary>
        /// Gets and sets the property MatrixCoefficients. The color space matrix coefficients
        /// of the video track, defining how RGB color values are converted to and from YUV color
        /// space. This affects color accuracy during encoding and decoding processes.
        /// </summary>
        public MatrixCoefficients MatrixCoefficients { get; set; }

        /// <summary>
        /// Checks to see if the MatrixCoefficients property is set.
        /// </summary>
        internal bool IsSetMatrixCoefficients() => this.MatrixCoefficients != null;

        /// <summary>
        /// Gets and sets the property Rotation. The clockwise rotation angle of the video track,
        /// in degrees, as derived from container-level metadata (e.g. the MP4 tkhd transformation
        /// matrix or the Matroska ProjectionPoseRoll element). Common values are 90, 180, and
        /// 270. This field is null when no rotation metadata is present or when the rotation
        /// is 0 degrees. For MP4, non-standard transformation matrices also yield null.
        /// </summary>
        public int? Rotation { get; set; }

        /// <summary>
        /// Checks to see if the Rotation property is set.
        /// </summary>
        internal bool IsSetRotation() => this.Rotation.HasValue;

        /// <summary>
        /// Gets and sets the property SampleAspectRatio. An aspect ratio expressed as a fraction
        /// with numerator and denominator values, reduced to lowest terms. Used for the sample
        /// (pixel) aspect ratio and the display aspect ratio of a video track. For example, a
        /// 720x576 anamorphic track has a sample aspect ratio of 64 / 45 and a display aspect
        /// ratio of 16 / 9. A video track can declare an aspect ratio in two independent places,
        /// and MediaConvert reports each one where it was found rather than choosing between
        /// them. The ratio declared by the container appears on the video track itself, and the
        /// ratio declared by the video essence appears under codecMetadata. When a file declares
        /// an aspect ratio in only one of the two places, the other is null; when it declares
        /// both and they disagree, you can compare them and decide which to use.
        /// </summary>
        public AspectRatio SampleAspectRatio { get; set; }

        /// <summary>
        /// Checks to see if the SampleAspectRatio property is set.
        /// </summary>
        internal bool IsSetSampleAspectRatio() => this.SampleAspectRatio != null;

        /// <summary>
        /// Gets and sets the property TransferCharacteristics. The color space transfer characteristics
        /// of the video track, defining the relationship between linear light values and the
        /// encoded signal values. This affects brightness and contrast reproduction.
        /// </summary>
        public TransferCharacteristics TransferCharacteristics { get; set; }

        /// <summary>
        /// Checks to see if the TransferCharacteristics property is set.
        /// </summary>
        internal bool IsSetTransferCharacteristics() => this.TransferCharacteristics != null;

        /// <summary>
        /// Gets and sets the property Width. The width of the video track, in pixels.
        /// </summary>
        public int? Width { get; set; }

        /// <summary>
        /// Checks to see if the Width property is set.
        /// </summary>
        internal bool IsSetWidth() => this.Width.HasValue;
    }
}
