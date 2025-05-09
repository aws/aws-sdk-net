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

#pragma warning disable CS0612,CS0618,CS1570
namespace Amazon.MediaConvert.Model
{
    /// <summary>
    /// Settings for color correction.
    /// </summary>
    public partial class ColorCorrector
    {
        private int? _brightness;
        private ClipLimits _clipLimits;
        private ColorSpaceConversion _colorSpaceConversion;
        private int? _contrast;
        private Hdr10Metadata _hdr10Metadata;
        private HDRToSDRToneMapper _hdrToSdrToneMapper;
        private int? _hue;
        private int? _maxLuminance;
        private SampleRangeConversion _sampleRangeConversion;
        private int? _saturation;
        private int? _sdrReferenceWhiteLevel;

        /// <summary>
        /// Gets and sets the property Brightness. Brightness level.
        /// </summary>
        [AWSProperty(Min=1, Max=100)]
        public int? Brightness
        {
            get { return this._brightness; }
            set { this._brightness = value; }
        }

        // Check to see if Brightness property is set
        internal bool IsSetBrightness()
        {
            return this._brightness.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property ClipLimits. Specify YUV limits and RGB tolerances when
        /// you set Sample range conversion to Limited range clip.
        /// </summary>
        public ClipLimits ClipLimits
        {
            get { return this._clipLimits; }
            set { this._clipLimits = value; }
        }

        // Check to see if ClipLimits property is set
        internal bool IsSetClipLimits()
        {
            return this._clipLimits != null;
        }

        /// <summary>
        /// Gets and sets the property ColorSpaceConversion. Specify the color space you want
        /// for this output. The service supports conversion between HDR formats, between SDR
        /// formats, from SDR to HDR, and from HDR to SDR. SDR to HDR conversion doesn't upgrade
        /// the dynamic range. The converted video has an HDR format, but visually appears the
        /// same as an unconverted output. HDR to SDR conversion uses tone mapping to approximate
        /// the outcome of manually regrading from HDR to SDR. When you specify an output color
        /// space, MediaConvert uses the following color space metadata, which includes color
        /// primaries, transfer characteristics, and matrix coefficients:  * HDR 10: BT.2020,
        /// PQ, BT.2020 non-constant  * HLG 2020: BT.2020, HLG, BT.2020 non-constant  * P3DCI
        /// (Theater): DCIP3, SMPTE 428M, BT.709  * P3D65 (SDR): Display P3, sRGB, BT.709  * P3D65
        /// (HDR): Display P3, PQ, BT.709
        /// </summary>
        public ColorSpaceConversion ColorSpaceConversion
        {
            get { return this._colorSpaceConversion; }
            set { this._colorSpaceConversion = value; }
        }

        // Check to see if ColorSpaceConversion property is set
        internal bool IsSetColorSpaceConversion()
        {
            return this._colorSpaceConversion != null;
        }

        /// <summary>
        /// Gets and sets the property Contrast. Contrast level.
        /// </summary>
        [AWSProperty(Min=1, Max=100)]
        public int? Contrast
        {
            get { return this._contrast; }
            set { this._contrast = value; }
        }

        // Check to see if Contrast property is set
        internal bool IsSetContrast()
        {
            return this._contrast.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Hdr10Metadata. Use these settings when you convert to the
        /// HDR 10 color space. Specify the SMPTE ST 2086 Mastering Display Color Volume static
        /// metadata that you want signaled in the output. These values don't affect the pixel
        /// values that are encoded in the video stream. They are intended to help the downstream
        /// video player display content in a way that reflects the intentions of the the content
        /// creator. When you set Color space conversion to HDR 10, these settings are required.
        /// You must set values for Max frame average light level and Max content light level;
        /// these settings don't have a default value. The default values for the other HDR 10
        /// metadata settings are defined by the P3D65 color space. For more information about
        /// MediaConvert HDR jobs, see https://docs.aws.amazon.com/console/mediaconvert/hdr.
        /// </summary>
        public Hdr10Metadata Hdr10Metadata
        {
            get { return this._hdr10Metadata; }
            set { this._hdr10Metadata = value; }
        }

        // Check to see if Hdr10Metadata property is set
        internal bool IsSetHdr10Metadata()
        {
            return this._hdr10Metadata != null;
        }

        /// <summary>
        /// Gets and sets the property HdrToSdrToneMapper. Specify how MediaConvert maps brightness
        /// and colors from your HDR input to your SDR output. The mode that you select represents
        /// a creative choice, with different tradeoffs in the details and tones of your output.
        /// To maintain details in bright or saturated areas of your output: Choose Preserve details.
        /// For some sources, your SDR output may look less bright and less saturated when compared
        /// to your HDR source. MediaConvert automatically applies this mode for HLG sources,
        /// regardless of your choice. For a bright and saturated output: Choose Vibrant. We recommend
        /// that you choose this mode when any of your source content is HDR10, and for the best
        /// results when it is mastered for 1000 nits. You may notice loss of details in bright
        /// or saturated areas of your output. HDR to SDR tone mapping has no effect when your
        /// input is SDR.
        /// </summary>
        public HDRToSDRToneMapper HdrToSdrToneMapper
        {
            get { return this._hdrToSdrToneMapper; }
            set { this._hdrToSdrToneMapper = value; }
        }

        // Check to see if HdrToSdrToneMapper property is set
        internal bool IsSetHdrToSdrToneMapper()
        {
            return this._hdrToSdrToneMapper != null;
        }

        /// <summary>
        /// Gets and sets the property Hue. Hue in degrees.
        /// </summary>
        [AWSProperty(Min=-180, Max=180)]
        public int? Hue
        {
            get { return this._hue; }
            set { this._hue = value; }
        }

        // Check to see if Hue property is set
        internal bool IsSetHue()
        {
            return this._hue.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property MaxLuminance. Specify the maximum mastering display luminance.
        /// Enter an integer from 0 to 2147483647, in units of 0.0001 nits. For example, enter
        /// 10000000 for 1000 nits.
        /// </summary>
        [AWSProperty(Min=0, Max=2147483647)]
        public int? MaxLuminance
        {
            get { return this._maxLuminance; }
            set { this._maxLuminance = value; }
        }

        // Check to see if MaxLuminance property is set
        internal bool IsSetMaxLuminance()
        {
            return this._maxLuminance.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property SampleRangeConversion. Specify how MediaConvert limits
        /// the color sample range for this output. To create a limited range output from a full
        /// range input: Choose Limited range squeeze. For full range inputs, MediaConvert performs
        /// a linear offset to color samples equally across all pixels and frames. Color samples
        /// in 10-bit outputs are limited to 64 through 940, and 8-bit outputs are limited to
        /// 16 through 235. Note: For limited range inputs, values for color samples are passed
        /// through to your output unchanged. MediaConvert does not limit the sample range. To
        /// correct pixels in your input that are out of range or out of gamut: Choose Limited
        /// range clip. Use for broadcast applications. MediaConvert conforms any pixels outside
        /// of the values that you specify under Minimum YUV and Maximum YUV to limited range
        /// bounds. MediaConvert also corrects any YUV values that, when converted to RGB, would
        /// be outside the bounds you specify under Minimum RGB tolerance and Maximum RGB tolerance.
        /// With either limited range conversion, MediaConvert writes the sample range metadata
        /// in the output.
        /// </summary>
        public SampleRangeConversion SampleRangeConversion
        {
            get { return this._sampleRangeConversion; }
            set { this._sampleRangeConversion = value; }
        }

        // Check to see if SampleRangeConversion property is set
        internal bool IsSetSampleRangeConversion()
        {
            return this._sampleRangeConversion != null;
        }

        /// <summary>
        /// Gets and sets the property Saturation. Saturation level.
        /// </summary>
        [AWSProperty(Min=1, Max=100)]
        public int? Saturation
        {
            get { return this._saturation; }
            set { this._saturation = value; }
        }

        // Check to see if Saturation property is set
        internal bool IsSetSaturation()
        {
            return this._saturation.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property SdrReferenceWhiteLevel. Specify the reference white level,
        /// in nits, for all of your SDR inputs. Use to correct brightness levels within HDR10
        /// outputs. The following color metadata must be present in your SDR input: color primaries,
        /// transfer characteristics, and matrix coefficients. If your SDR input has missing color
        /// metadata, or if you want to correct input color metadata, manually specify a color
        /// space in the input video selector. For 1,000 nit peak brightness displays, we recommend
        /// that you set SDR reference white level to 203 (according to ITU-R BT.2408). Leave
        /// blank to use the default value of 100, or specify an integer from 100 to 1000.
        /// </summary>
        [AWSProperty(Min=100, Max=1000)]
        public int? SdrReferenceWhiteLevel
        {
            get { return this._sdrReferenceWhiteLevel; }
            set { this._sdrReferenceWhiteLevel = value; }
        }

        // Check to see if SdrReferenceWhiteLevel property is set
        internal bool IsSetSdrReferenceWhiteLevel()
        {
            return this._sdrReferenceWhiteLevel.HasValue; 
        }

    }
}