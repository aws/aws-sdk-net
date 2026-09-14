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
    /// Codec-specific parameters parsed from the video essence headers. This information
    /// provides detailed technical specifications about how the video was encoded, including
    /// profile settings, resolution details, and color space information that can help you
    /// understand the source video characteristics and make informed encoding decisions.
    /// </summary>
    public partial class CodecMetadata
    {
        /// <summary>
        /// Gets and sets the property BitDepth. The number of bits used per color component in
        /// the video essence such as 8, 10, or 12 bits. Standard range (SDR) video typically
        /// uses 8-bit, while 10-bit is common for high dynamic range (HDR).
        /// </summary>
        public int? BitDepth { get; set; }

        /// <summary>
        /// Checks to see if the BitDepth property is set.
        /// </summary>
        internal bool IsSetBitDepth() => this.BitDepth.HasValue;

        /// <summary>
        /// Gets and sets the property ChromaSubsampling. The chroma subsampling format used in
        /// the video encoding, such as "4:2:0" or "4:4:4". This describes how color information
        /// is sampled relative to brightness information. Different subsampling ratios affect
        /// video quality and file size, with "4:4:4" providing the highest color fidelity and
        /// "4:2:0" being most common for standard video.
        /// </summary>
        public string ChromaSubsampling { get; set; }

        /// <summary>
        /// Checks to see if the ChromaSubsampling property is set.
        /// </summary>
        internal bool IsSetChromaSubsampling() => this.ChromaSubsampling != null;

        /// <summary>
        /// Gets and sets the property CodedFrameRate. The frame rate of the video or audio track,
        /// expressed as a fraction with numerator and denominator values.
        /// </summary>
        public FrameRate CodedFrameRate { get; set; }

        /// <summary>
        /// Checks to see if the CodedFrameRate property is set.
        /// </summary>
        internal bool IsSetCodedFrameRate() => this.CodedFrameRate != null;

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
        /// Gets and sets the property ContentLightLevel. Content light level information (CTA-861.3).
        /// Describes the light level characteristics of the content.
        /// </summary>
        public ContentLightLevel ContentLightLevel { get; set; }

        /// <summary>
        /// Checks to see if the ContentLightLevel property is set.
        /// </summary>
        internal bool IsSetContentLightLevel() => this.ContentLightLevel != null;

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
        /// Gets and sets the property DolbyVision. Dolby Vision characteristics of the video
        /// track: the profile and level, and whether the RPU (dynamic metadata), base layer,
        /// and enhancement layer are present. Use this to distinguish Dolby Vision content from
        /// standard HEVC and to choose your encoding or passthrough settings. Omitted when the
        /// content is not Dolby Vision.
        /// </summary>
        public DolbyVisionMetadata DolbyVision { get; set; }

        /// <summary>
        /// Checks to see if the DolbyVision property is set.
        /// </summary>
        internal bool IsSetDolbyVision() => this.DolbyVision != null;

        /// <summary>
        /// Gets and sets the property FieldOrder. The field order of interlaced video, which
        /// indicates whether the top or bottom field is displayed first. Use this to select the
        /// correct deinterlacing behavior. One of "TopFieldFirst" or "BottomFieldFirst". This
        /// field is present only for interlaced video; it is omitted for progressive video and
        /// when the field order is not indicated by the source.
        /// </summary>
        public string FieldOrder { get; set; }

        /// <summary>
        /// Checks to see if the FieldOrder property is set.
        /// </summary>
        internal bool IsSetFieldOrder() => this.FieldOrder != null;

        /// <summary>
        /// Gets and sets the property Hdr10PlusPresence. Indicates that HDR10+ (SMPTE ST 2094-40)
        /// dynamic metadata was detected in the HEVC bitstream. Present only when detected.
        /// </summary>
        public Hdr10PlusPresence Hdr10PlusPresence { get; set; }

        /// <summary>
        /// Checks to see if the Hdr10PlusPresence property is set.
        /// </summary>
        internal bool IsSetHdr10PlusPresence() => this.Hdr10PlusPresence != null;

        /// <summary>
        /// Gets and sets the property Height. The height in pixels as coded by the codec. This
        /// represents the actual encoded video height as specified in the video stream headers.
        /// </summary>
        public int? Height { get; set; }

        /// <summary>
        /// Checks to see if the Height property is set.
        /// </summary>
        internal bool IsSetHeight() => this.Height.HasValue;

        /// <summary>
        /// Gets and sets the property Level. The codec level or tier that specifies the maximum
        /// processing requirements and capabilities. Levels define constraints such as maximum
        /// bit rate, frame rate, and resolution.
        /// </summary>
        public string Level { get; set; }

        /// <summary>
        /// Checks to see if the Level property is set.
        /// </summary>
        internal bool IsSetLevel() => this.Level != null;

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
        /// Gets and sets the property Profile. The codec profile used to encode the video. Profiles
        /// define specific feature sets and capabilities within a codec standard. For example,
        /// H.264 profiles include Baseline, Main, and High, each supporting different encoding
        /// features and complexity levels.
        /// </summary>
        public string Profile { get; set; }

        /// <summary>
        /// Checks to see if the Profile property is set.
        /// </summary>
        internal bool IsSetProfile() => this.Profile != null;

        /// <summary>
        /// Gets and sets the property Rotation. The clockwise rotation angle of the video, in
        /// degrees, as specified in the codec bitstream via a Display Orientation SEI message
        /// (payload type 47 for both H.264 and H.265). This field is null when the video essence
        /// does not contain a Display Orientation SEI message or when the rotation is 0 degrees.
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
        /// Gets and sets the property ScanType. The scanning method specified in the video essence,
        /// indicating whether the video uses progressive or interlaced scanning.
        /// </summary>
        public string ScanType { get; set; }

        /// <summary>
        /// Checks to see if the ScanType property is set.
        /// </summary>
        internal bool IsSetScanType() => this.ScanType != null;

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
        /// Gets and sets the property Width. The width in pixels as coded by the codec. This
        /// represents the actual encoded video width as specified in the video stream headers.
        /// </summary>
        public int? Width { get; set; }

        /// <summary>
        /// Checks to see if the Width property is set.
        /// </summary>
        internal bool IsSetWidth() => this.Width.HasValue;
    }
}
