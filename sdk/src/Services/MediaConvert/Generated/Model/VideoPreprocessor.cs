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
    /// Find additional transcoding features under Preprocessors (VideoPreprocessors). Enable
    /// the features at each output individually. These features are disabled by default.
    /// </summary>
    public partial class VideoPreprocessor
    {
        private ColorCorrector _colorCorrector;
        private Deinterlacer _deinterlacer;
        private DolbyVision _dolbyVision;
        private Hdr10Plus _hdr10Plus;
        private ImageInserter _imageInserter;
        private NoiseReducer _noiseReducer;
        private PartnerWatermarking _partnerWatermarking;
        private TimecodeBurnin _timecodeBurnin;

        /// <summary>
        /// Gets and sets the property ColorCorrector. Use these settings to convert the color
        /// space or to modify properties such as hue and contrast for this output. For more information,
        /// see https://docs.aws.amazon.com/mediaconvert/latest/ug/converting-the-color-space.html.
        /// </summary>
        public ColorCorrector ColorCorrector
        {
            get { return this._colorCorrector; }
            set { this._colorCorrector = value; }
        }

        // Check to see if ColorCorrector property is set
        internal bool IsSetColorCorrector()
        {
            return this._colorCorrector != null;
        }

        /// <summary>
        /// Gets and sets the property Deinterlacer. Use the deinterlacer to produce smoother
        /// motion and a clearer picture. For more information, see https://docs.aws.amazon.com/mediaconvert/latest/ug/working-with-scan-type.html.
        /// </summary>
        public Deinterlacer Deinterlacer
        {
            get { return this._deinterlacer; }
            set { this._deinterlacer = value; }
        }

        // Check to see if Deinterlacer property is set
        internal bool IsSetDeinterlacer()
        {
            return this._deinterlacer != null;
        }

        /// <summary>
        /// Gets and sets the property DolbyVision. Enable Dolby Vision feature to produce Dolby
        /// Vision compatible video output.
        /// </summary>
        public DolbyVision DolbyVision
        {
            get { return this._dolbyVision; }
            set { this._dolbyVision = value; }
        }

        // Check to see if DolbyVision property is set
        internal bool IsSetDolbyVision()
        {
            return this._dolbyVision != null;
        }

        /// <summary>
        /// Gets and sets the property Hdr10Plus. Enable HDR10+ analyis and metadata injection.
        /// Compatible with HEVC only.
        /// </summary>
        public Hdr10Plus Hdr10Plus
        {
            get { return this._hdr10Plus; }
            set { this._hdr10Plus = value; }
        }

        // Check to see if Hdr10Plus property is set
        internal bool IsSetHdr10Plus()
        {
            return this._hdr10Plus != null;
        }

        /// <summary>
        /// Gets and sets the property ImageInserter. Enable the Image inserter (ImageInserter)
        /// feature to include a graphic overlay on your video. Enable or disable this feature
        /// for each output individually. This setting is disabled by default.
        /// </summary>
        public ImageInserter ImageInserter
        {
            get { return this._imageInserter; }
            set { this._imageInserter = value; }
        }

        // Check to see if ImageInserter property is set
        internal bool IsSetImageInserter()
        {
            return this._imageInserter != null;
        }

        /// <summary>
        /// Gets and sets the property NoiseReducer. Enable the Noise reducer feature to remove
        /// noise from your video output if necessary. Enable or disable this feature for each
        /// output individually. This setting is disabled by default. When you enable Noise reducer,
        /// you must also select a value for Noise reducer filter. For AVC outputs, when you include
        /// Noise reducer, you cannot include the Bandwidth reduction filter.
        /// </summary>
        public NoiseReducer NoiseReducer
        {
            get { return this._noiseReducer; }
            set { this._noiseReducer = value; }
        }

        // Check to see if NoiseReducer property is set
        internal bool IsSetNoiseReducer()
        {
            return this._noiseReducer != null;
        }

        /// <summary>
        /// Gets and sets the property PartnerWatermarking. If you work with a third party video
        /// watermarking partner, use the group of settings that correspond with your watermarking
        /// partner to include watermarks in your output.
        /// </summary>
        public PartnerWatermarking PartnerWatermarking
        {
            get { return this._partnerWatermarking; }
            set { this._partnerWatermarking = value; }
        }

        // Check to see if PartnerWatermarking property is set
        internal bool IsSetPartnerWatermarking()
        {
            return this._partnerWatermarking != null;
        }

        /// <summary>
        /// Gets and sets the property TimecodeBurnin. Settings for burning the output timecode
        /// and specified prefix into the output.
        /// </summary>
        public TimecodeBurnin TimecodeBurnin
        {
            get { return this._timecodeBurnin; }
            set { this._timecodeBurnin = value; }
        }

        // Check to see if TimecodeBurnin property is set
        internal bool IsSetTimecodeBurnin()
        {
            return this._timecodeBurnin != null;
        }

    }
}