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
    /// Video codec settings contains the group of settings related to video encoding. The
    /// settings in this group vary depending on the value that you choose for Video codec.
    /// For each codec enum that you choose, define the corresponding settings object. The
    /// following lists the codec enum, settings object pairs. * AV1, Av1Settings * AVC_INTRA,
    /// AvcIntraSettings * FRAME_CAPTURE, FrameCaptureSettings * GIF, GifSettings * H_264,
    /// H264Settings * H_265, H265Settings * MPEG2, Mpeg2Settings * PRORES, ProresSettings
    /// * UNCOMPRESSED, UncompressedSettings * VC3, Vc3Settings * VP8, Vp8Settings * VP9,
    /// Vp9Settings * XAVC, XavcSettings
    /// </summary>
    public partial class VideoCodecSettings
    {
        /// <summary>
        /// Gets and sets the property Av1Settings. Required when you set Codec, under VideoDescription>CodecSettings
        /// to the value AV1.
        /// </summary>
        public Av1Settings Av1Settings { get; set; }

        /// <summary>
        /// Checks to see if the Av1Settings property is set.
        /// </summary>
        internal bool IsSetAv1Settings() => this.Av1Settings != null;

        /// <summary>
        /// Gets and sets the property AvcIntraSettings. Required when you choose AVC-Intra for
        /// your output video codec. For more information about the AVC-Intra settings, see the
        /// relevant specification. For detailed information about SD and HD in AVC-Intra, see
        /// https://ieeexplore.ieee.org/document/7290936. For information about 4K/2K in AVC-Intra,
        /// see https://pro-av.panasonic.net/en/avc-ultra/AVC-ULTRAoverview.pdf.
        /// </summary>
        public AvcIntraSettings AvcIntraSettings { get; set; }

        /// <summary>
        /// Checks to see if the AvcIntraSettings property is set.
        /// </summary>
        internal bool IsSetAvcIntraSettings() => this.AvcIntraSettings != null;

        /// <summary>
        /// Gets and sets the property Codec. Specifies the video codec. This must be equal to
        /// one of the enum values defined by the object VideoCodec. To passthrough the video
        /// stream of your input without any video encoding: Choose Passthrough. More information
        /// about passthrough codec support and job settings requirements, see: https://docs.aws.amazon.com/mediaconvert/latest/ug/video-passthrough-feature-restrictions.html
        /// </summary>
        public VideoCodec Codec { get; set; }

        /// <summary>
        /// Checks to see if the Codec property is set.
        /// </summary>
        internal bool IsSetCodec() => this.Codec != null;

        /// <summary>
        /// Gets and sets the property FrameCaptureSettings. Required when you set Codec to the
        /// value FRAME_CAPTURE.
        /// </summary>
        public FrameCaptureSettings FrameCaptureSettings { get; set; }

        /// <summary>
        /// Checks to see if the FrameCaptureSettings property is set.
        /// </summary>
        internal bool IsSetFrameCaptureSettings() => this.FrameCaptureSettings != null;

        /// <summary>
        /// Gets and sets the property GifSettings. Required when you set (Codec) under (VideoDescription)>(CodecSettings)
        /// to the value GIF
        /// </summary>
        public GifSettings GifSettings { get; set; }

        /// <summary>
        /// Checks to see if the GifSettings property is set.
        /// </summary>
        internal bool IsSetGifSettings() => this.GifSettings != null;

        /// <summary>
        /// Gets and sets the property H264Settings. Required when you set Codec to the value
        /// H_264.
        /// </summary>
        public H264Settings H264Settings { get; set; }

        /// <summary>
        /// Checks to see if the H264Settings property is set.
        /// </summary>
        internal bool IsSetH264Settings() => this.H264Settings != null;

        /// <summary>
        /// Gets and sets the property H265Settings. Settings for H265 codec
        /// </summary>
        public H265Settings H265Settings { get; set; }

        /// <summary>
        /// Checks to see if the H265Settings property is set.
        /// </summary>
        internal bool IsSetH265Settings() => this.H265Settings != null;

        /// <summary>
        /// Gets and sets the property Mpeg2Settings. Required when you set Codec to the value
        /// MPEG2.
        /// </summary>
        public Mpeg2Settings Mpeg2Settings { get; set; }

        /// <summary>
        /// Checks to see if the Mpeg2Settings property is set.
        /// </summary>
        internal bool IsSetMpeg2Settings() => this.Mpeg2Settings != null;

        /// <summary>
        /// Gets and sets the property PassthroughSettings. Optional settings when you set Codec
        /// to the value Passthrough.
        /// </summary>
        public PassthroughSettings PassthroughSettings { get; set; }

        /// <summary>
        /// Checks to see if the PassthroughSettings property is set.
        /// </summary>
        internal bool IsSetPassthroughSettings() => this.PassthroughSettings != null;

        /// <summary>
        /// Gets and sets the property ProresSettings. Required when you set Codec to the value
        /// PRORES.
        /// </summary>
        public ProresSettings ProresSettings { get; set; }

        /// <summary>
        /// Checks to see if the ProresSettings property is set.
        /// </summary>
        internal bool IsSetProresSettings() => this.ProresSettings != null;

        /// <summary>
        /// Gets and sets the property UncompressedSettings. Required when you set Codec, under
        /// VideoDescription>CodecSettings to the value UNCOMPRESSED.
        /// </summary>
        public UncompressedSettings UncompressedSettings { get; set; }

        /// <summary>
        /// Checks to see if the UncompressedSettings property is set.
        /// </summary>
        internal bool IsSetUncompressedSettings() => this.UncompressedSettings != null;

        /// <summary>
        /// Gets and sets the property Vc3Settings. Required when you set Codec to the value VC3
        /// </summary>
        public Vc3Settings Vc3Settings { get; set; }

        /// <summary>
        /// Checks to see if the Vc3Settings property is set.
        /// </summary>
        internal bool IsSetVc3Settings() => this.Vc3Settings != null;

        /// <summary>
        /// Gets and sets the property Vp8Settings. Required when you set Codec to the value VP8.
        /// </summary>
        public Vp8Settings Vp8Settings { get; set; }

        /// <summary>
        /// Checks to see if the Vp8Settings property is set.
        /// </summary>
        internal bool IsSetVp8Settings() => this.Vp8Settings != null;

        /// <summary>
        /// Gets and sets the property Vp9Settings. Required when you set Codec to the value VP9.
        /// </summary>
        public Vp9Settings Vp9Settings { get; set; }

        /// <summary>
        /// Checks to see if the Vp9Settings property is set.
        /// </summary>
        internal bool IsSetVp9Settings() => this.Vp9Settings != null;

        /// <summary>
        /// Gets and sets the property XavcSettings. Required when you set Codec to the value
        /// XAVC.
        /// </summary>
        public XavcSettings XavcSettings { get; set; }

        /// <summary>
        /// Checks to see if the XavcSettings property is set.
        /// </summary>
        internal bool IsSetXavcSettings() => this.XavcSettings != null;
    }
}
