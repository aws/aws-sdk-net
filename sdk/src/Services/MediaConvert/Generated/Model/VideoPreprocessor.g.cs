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
    /// Find additional transcoding features under Preprocessors. Enable the features at each
    /// output individually. These features are disabled by default.
    /// </summary>
    public partial class VideoPreprocessor
    {
        /// <summary>
        /// Gets and sets the property ColorCorrector. Use these settings to convert the color
        /// space or to modify properties such as hue and contrast for this output. For more information,
        /// see https://docs.aws.amazon.com/mediaconvert/latest/ug/converting-the-color-space.html.
        /// </summary>
        public ColorCorrector ColorCorrector { get; set; }

        /// <summary>
        /// Checks to see if the ColorCorrector property is set.
        /// </summary>
        internal bool IsSetColorCorrector() => this.ColorCorrector != null;

        /// <summary>
        /// Gets and sets the property Deinterlacer. Use the deinterlacer to produce smoother
        /// motion and a clearer picture. For more information, see https://docs.aws.amazon.com/mediaconvert/latest/ug/working-with-scan-type.html.
        /// </summary>
        public Deinterlacer Deinterlacer { get; set; }

        /// <summary>
        /// Checks to see if the Deinterlacer property is set.
        /// </summary>
        internal bool IsSetDeinterlacer() => this.Deinterlacer != null;

        /// <summary>
        /// Gets and sets the property DolbyVision. Enable Dolby Vision feature to produce Dolby
        /// Vision compatible video output.
        /// </summary>
        public DolbyVision DolbyVision { get; set; }

        /// <summary>
        /// Checks to see if the DolbyVision property is set.
        /// </summary>
        internal bool IsSetDolbyVision() => this.DolbyVision != null;

        /// <summary>
        /// Gets and sets the property DurationControl. Enable integer-second duration normalization.
        /// When enabled, the output duration is adjusted to land on an exact integer-second boundary.
        /// The adjustment method (trim, compress, or pad) is chosen automatically based on how
        /// far the input duration is from the nearest integer second.
        /// </summary>
        public DurationControl DurationControl { get; set; }

        /// <summary>
        /// Checks to see if the DurationControl property is set.
        /// </summary>
        internal bool IsSetDurationControl() => this.DurationControl != null;

        /// <summary>
        /// Gets and sets the property Hdr10Plus. Enable HDR10+ analysis and metadata injection.
        /// Compatible with HEVC only.
        /// </summary>
        public Hdr10Plus Hdr10Plus { get; set; }

        /// <summary>
        /// Checks to see if the Hdr10Plus property is set.
        /// </summary>
        internal bool IsSetHdr10Plus() => this.Hdr10Plus != null;

        /// <summary>
        /// Gets and sets the property ImageInserter. Enable the Image inserter feature to include
        /// a graphic overlay on your video. Enable or disable this feature for each output individually.
        /// This setting is disabled by default.
        /// </summary>
        public ImageInserter ImageInserter { get; set; }

        /// <summary>
        /// Checks to see if the ImageInserter property is set.
        /// </summary>
        internal bool IsSetImageInserter() => this.ImageInserter != null;

        /// <summary>
        /// Gets and sets the property NoiseReducer. Enable the Noise reducer feature to remove
        /// noise from your video output if necessary. Enable or disable this feature for each
        /// output individually. This setting is disabled by default. When you enable Noise reducer,
        /// you must also select a value for Noise reducer filter. For AVC outputs, when you include
        /// Noise reducer, you cannot include the Bandwidth reduction filter.
        /// </summary>
        public NoiseReducer NoiseReducer { get; set; }

        /// <summary>
        /// Checks to see if the NoiseReducer property is set.
        /// </summary>
        internal bool IsSetNoiseReducer() => this.NoiseReducer != null;

        /// <summary>
        /// Gets and sets the property PartnerWatermarking. If you work with a third party video
        /// watermarking partner, use the group of settings that correspond with your watermarking
        /// partner to include watermarks in your output.
        /// </summary>
        public PartnerWatermarking PartnerWatermarking { get; set; }

        /// <summary>
        /// Checks to see if the PartnerWatermarking property is set.
        /// </summary>
        internal bool IsSetPartnerWatermarking() => this.PartnerWatermarking != null;

        /// <summary>
        /// Gets and sets the property TimecodeBurnin. Settings for burning the output timecode
        /// and specified prefix into the output.
        /// </summary>
        public TimecodeBurnin TimecodeBurnin { get; set; }

        /// <summary>
        /// Checks to see if the TimecodeBurnin property is set.
        /// </summary>
        internal bool IsSetTimecodeBurnin() => this.TimecodeBurnin != null;
    }
}
