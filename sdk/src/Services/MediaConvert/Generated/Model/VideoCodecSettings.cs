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
 * Do not modify this file. This file is generated from the mediaconvert-2017-08-29.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.MediaConvert.Model
{
    /// <summary>
    /// Video codec settings, (CodecSettings) under (VideoDescription), contains the group
    /// of settings related to video encoding. The settings in this group vary depending on
    /// the value that you choose for Video codec (Codec). For each codec enum that you choose,
    /// define the corresponding settings object. The following lists the codec enum, settings
    /// object pairs. * AV1, Av1Settings * AVC_INTRA, AvcIntraSettings * FRAME_CAPTURE, FrameCaptureSettings
    /// * H_264, H264Settings * H_265, H265Settings * MPEG2, Mpeg2Settings * PRORES, ProresSettings
    /// * VC3, Vc3Settings * VP8, Vp8Settings * VP9, Vp9Settings * XAVC, XavcSettings
    /// </summary>
    public partial class VideoCodecSettings
    {
        private Av1Settings _av1Settings;
        private AvcIntraSettings _avcIntraSettings;
        private VideoCodec _codec;
        private FrameCaptureSettings _frameCaptureSettings;
        private H264Settings _h264Settings;
        private H265Settings _h265Settings;
        private Mpeg2Settings _mpeg2Settings;
        private ProresSettings _proresSettings;
        private Vc3Settings _vc3Settings;
        private Vp8Settings _vp8Settings;
        private Vp9Settings _vp9Settings;
        private XavcSettings _xavcSettings;

        /// <summary>
        /// Gets and sets the property Av1Settings. Required when you set Codec, under VideoDescription>CodecSettings
        /// to the value AV1.
        /// </summary>
        public Av1Settings Av1Settings
        {
            get { return this._av1Settings; }
            set { this._av1Settings = value; }
        }

        // Check to see if Av1Settings property is set
        internal bool IsSetAv1Settings()
        {
            return this._av1Settings != null;
        }

        /// <summary>
        /// Gets and sets the property AvcIntraSettings. Required when you choose AVC-Intra for
        /// your output video codec. For more information about the AVC-Intra settings, see the
        /// relevant specification. For detailed information about SD and HD in AVC-Intra, see
        /// https://ieeexplore.ieee.org/document/7290936. For information about 4K/2K in AVC-Intra,
        /// see https://pro-av.panasonic.net/en/avc-ultra/AVC-ULTRAoverview.pdf.
        /// </summary>
        public AvcIntraSettings AvcIntraSettings
        {
            get { return this._avcIntraSettings; }
            set { this._avcIntraSettings = value; }
        }

        // Check to see if AvcIntraSettings property is set
        internal bool IsSetAvcIntraSettings()
        {
            return this._avcIntraSettings != null;
        }

        /// <summary>
        /// Gets and sets the property Codec. Specifies the video codec. This must be equal to
        /// one of the enum values defined by the object VideoCodec.
        /// </summary>
        public VideoCodec Codec
        {
            get { return this._codec; }
            set { this._codec = value; }
        }

        // Check to see if Codec property is set
        internal bool IsSetCodec()
        {
            return this._codec != null;
        }

        /// <summary>
        /// Gets and sets the property FrameCaptureSettings. Required when you set (Codec) under
        /// (VideoDescription)>(CodecSettings) to the value FRAME_CAPTURE.
        /// </summary>
        public FrameCaptureSettings FrameCaptureSettings
        {
            get { return this._frameCaptureSettings; }
            set { this._frameCaptureSettings = value; }
        }

        // Check to see if FrameCaptureSettings property is set
        internal bool IsSetFrameCaptureSettings()
        {
            return this._frameCaptureSettings != null;
        }

        /// <summary>
        /// Gets and sets the property H264Settings. Required when you set (Codec) under (VideoDescription)>(CodecSettings)
        /// to the value H_264.
        /// </summary>
        public H264Settings H264Settings
        {
            get { return this._h264Settings; }
            set { this._h264Settings = value; }
        }

        // Check to see if H264Settings property is set
        internal bool IsSetH264Settings()
        {
            return this._h264Settings != null;
        }

        /// <summary>
        /// Gets and sets the property H265Settings. Settings for H265 codec
        /// </summary>
        public H265Settings H265Settings
        {
            get { return this._h265Settings; }
            set { this._h265Settings = value; }
        }

        // Check to see if H265Settings property is set
        internal bool IsSetH265Settings()
        {
            return this._h265Settings != null;
        }

        /// <summary>
        /// Gets and sets the property Mpeg2Settings. Required when you set (Codec) under (VideoDescription)>(CodecSettings)
        /// to the value MPEG2.
        /// </summary>
        public Mpeg2Settings Mpeg2Settings
        {
            get { return this._mpeg2Settings; }
            set { this._mpeg2Settings = value; }
        }

        // Check to see if Mpeg2Settings property is set
        internal bool IsSetMpeg2Settings()
        {
            return this._mpeg2Settings != null;
        }

        /// <summary>
        /// Gets and sets the property ProresSettings. Required when you set (Codec) under (VideoDescription)>(CodecSettings)
        /// to the value PRORES.
        /// </summary>
        public ProresSettings ProresSettings
        {
            get { return this._proresSettings; }
            set { this._proresSettings = value; }
        }

        // Check to see if ProresSettings property is set
        internal bool IsSetProresSettings()
        {
            return this._proresSettings != null;
        }

        /// <summary>
        /// Gets and sets the property Vc3Settings. Required when you set (Codec) under (VideoDescription)>(CodecSettings)
        /// to the value VC3
        /// </summary>
        public Vc3Settings Vc3Settings
        {
            get { return this._vc3Settings; }
            set { this._vc3Settings = value; }
        }

        // Check to see if Vc3Settings property is set
        internal bool IsSetVc3Settings()
        {
            return this._vc3Settings != null;
        }

        /// <summary>
        /// Gets and sets the property Vp8Settings. Required when you set (Codec) under (VideoDescription)>(CodecSettings)
        /// to the value VP8.
        /// </summary>
        public Vp8Settings Vp8Settings
        {
            get { return this._vp8Settings; }
            set { this._vp8Settings = value; }
        }

        // Check to see if Vp8Settings property is set
        internal bool IsSetVp8Settings()
        {
            return this._vp8Settings != null;
        }

        /// <summary>
        /// Gets and sets the property Vp9Settings. Required when you set (Codec) under (VideoDescription)>(CodecSettings)
        /// to the value VP9.
        /// </summary>
        public Vp9Settings Vp9Settings
        {
            get { return this._vp9Settings; }
            set { this._vp9Settings = value; }
        }

        // Check to see if Vp9Settings property is set
        internal bool IsSetVp9Settings()
        {
            return this._vp9Settings != null;
        }

        /// <summary>
        /// Gets and sets the property XavcSettings. Required when you set (Codec) under (VideoDescription)>(CodecSettings)
        /// to the value XAVC.
        /// </summary>
        public XavcSettings XavcSettings
        {
            get { return this._xavcSettings; }
            set { this._xavcSettings = value; }
        }

        // Check to see if XavcSettings property is set
        internal bool IsSetXavcSettings()
        {
            return this._xavcSettings != null;
        }

    }
}