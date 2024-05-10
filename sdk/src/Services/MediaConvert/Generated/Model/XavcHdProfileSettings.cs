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
    /// Required when you set Profile to the value XAVC_HD.
    /// </summary>
    public partial class XavcHdProfileSettings
    {
        private XavcHdProfileBitrateClass _bitrateClass;
        private XavcFlickerAdaptiveQuantization _flickerAdaptiveQuantization;
        private XavcGopBReference _gopBReference;
        private int? _gopClosedCadence;
        private int? _hrdBufferSize;
        private XavcInterlaceMode _interlaceMode;
        private XavcHdProfileQualityTuningLevel _qualityTuningLevel;
        private int? _slices;
        private XavcHdProfileTelecine _telecine;

        /// <summary>
        /// Gets and sets the property BitrateClass. Specify the XAVC HD (Long GOP) Bitrate Class
        /// to set the bitrate of your output. Outputs of the same class have similar image quality
        /// over the operating points that are valid for that class.
        /// </summary>
        public XavcHdProfileBitrateClass BitrateClass
        {
            get { return this._bitrateClass; }
            set { this._bitrateClass = value; }
        }

        // Check to see if BitrateClass property is set
        internal bool IsSetBitrateClass()
        {
            return this._bitrateClass != null;
        }

        /// <summary>
        /// Gets and sets the property FlickerAdaptiveQuantization. The best way to set up adaptive
        /// quantization is to keep the default value, Auto, for the setting Adaptive quantization.
        /// When you do so, MediaConvert automatically applies the best types of quantization
        /// for your video content. Include this setting in your JSON job specification only when
        /// you choose to change the default value for Adaptive quantization. Enable this setting
        /// to have the encoder reduce I-frame pop. I-frame pop appears as a visual flicker that
        /// can arise when the encoder saves bits by copying some macroblocks many times from
        /// frame to frame, and then refreshes them at the I-frame. When you enable this setting,
        /// the encoder updates these macroblocks slightly more often to smooth out the flicker.
        /// This setting is disabled by default. Related setting: In addition to enabling this
        /// setting, you must also set Adaptive quantization to a value other than Off or Auto.
        /// Use Adaptive quantization to adjust the degree of smoothing that Flicker adaptive
        /// quantization provides.
        /// </summary>
        public XavcFlickerAdaptiveQuantization FlickerAdaptiveQuantization
        {
            get { return this._flickerAdaptiveQuantization; }
            set { this._flickerAdaptiveQuantization = value; }
        }

        // Check to see if FlickerAdaptiveQuantization property is set
        internal bool IsSetFlickerAdaptiveQuantization()
        {
            return this._flickerAdaptiveQuantization != null;
        }

        /// <summary>
        /// Gets and sets the property GopBReference. Specify whether the encoder uses B-frames
        /// as reference frames for other pictures in the same GOP. Choose Allow to allow the
        /// encoder to use B-frames as reference frames. Choose Don't allow to prevent the encoder
        /// from using B-frames as reference frames.
        /// </summary>
        public XavcGopBReference GopBReference
        {
            get { return this._gopBReference; }
            set { this._gopBReference = value; }
        }

        // Check to see if GopBReference property is set
        internal bool IsSetGopBReference()
        {
            return this._gopBReference != null;
        }

        /// <summary>
        /// Gets and sets the property GopClosedCadence. Frequency of closed GOPs. In streaming
        /// applications, it is recommended that this be set to 1 so a decoder joining mid-stream
        /// will receive an IDR frame as quickly as possible. Setting this value to 0 will break
        /// output segmenting.
        /// </summary>
        [AWSProperty(Min=0, Max=2147483647)]
        public int? GopClosedCadence
        {
            get { return this._gopClosedCadence; }
            set { this._gopClosedCadence = value; }
        }

        // Check to see if GopClosedCadence property is set
        internal bool IsSetGopClosedCadence()
        {
            return this._gopClosedCadence.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property HrdBufferSize. Specify the size of the buffer that MediaConvert
        /// uses in the HRD buffer model for this output. Specify this value in bits; for example,
        /// enter five megabits as 5000000. When you don't set this value, or you set it to zero,
        /// MediaConvert calculates the default by doubling the bitrate of this output point.
        /// </summary>
        [AWSProperty(Min=0, Max=1152000000)]
        public int? HrdBufferSize
        {
            get { return this._hrdBufferSize; }
            set { this._hrdBufferSize = value; }
        }

        // Check to see if HrdBufferSize property is set
        internal bool IsSetHrdBufferSize()
        {
            return this._hrdBufferSize.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property InterlaceMode. Choose the scan line type for the output.
        /// Keep the default value, Progressive to create a progressive output, regardless of
        /// the scan type of your input. Use Top field first or Bottom field first to create an
        /// output that's interlaced with the same field polarity throughout. Use Follow, default
        /// top or Follow, default bottom to produce outputs with the same field polarity as the
        /// source. For jobs that have multiple inputs, the output field polarity might change
        /// over the course of the output. Follow behavior depends on the input scan type. If
        /// the source is interlaced, the output will be interlaced with the same polarity as
        /// the source. If the source is progressive, the output will be interlaced with top field
        /// bottom field first, depending on which of the Follow options you choose.
        /// </summary>
        public XavcInterlaceMode InterlaceMode
        {
            get { return this._interlaceMode; }
            set { this._interlaceMode = value; }
        }

        // Check to see if InterlaceMode property is set
        internal bool IsSetInterlaceMode()
        {
            return this._interlaceMode != null;
        }

        /// <summary>
        /// Gets and sets the property QualityTuningLevel. Optional. Use Quality tuning level
        /// to choose how you want to trade off encoding speed for output video quality. The default
        /// behavior is faster, lower quality, single-pass encoding.
        /// </summary>
        public XavcHdProfileQualityTuningLevel QualityTuningLevel
        {
            get { return this._qualityTuningLevel; }
            set { this._qualityTuningLevel = value; }
        }

        // Check to see if QualityTuningLevel property is set
        internal bool IsSetQualityTuningLevel()
        {
            return this._qualityTuningLevel != null;
        }

        /// <summary>
        /// Gets and sets the property Slices. Number of slices per picture. Must be less than
        /// or equal to the number of macroblock rows for progressive pictures, and less than
        /// or equal to half the number of macroblock rows for interlaced pictures.
        /// </summary>
        [AWSProperty(Min=4, Max=12)]
        public int? Slices
        {
            get { return this._slices; }
            set { this._slices = value; }
        }

        // Check to see if Slices property is set
        internal bool IsSetSlices()
        {
            return this._slices.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Telecine. Ignore this setting unless you set Frame rate
        /// (framerateNumerator divided by framerateDenominator) to 29.970. If your input framerate
        /// is 23.976, choose Hard. Otherwise, keep the default value None. For more information,
        /// see https://docs.aws.amazon.com/mediaconvert/latest/ug/working-with-telecine-and-inverse-telecine.html.
        /// </summary>
        public XavcHdProfileTelecine Telecine
        {
            get { return this._telecine; }
            set { this._telecine = value; }
        }

        // Check to see if Telecine property is set
        internal bool IsSetTelecine()
        {
            return this._telecine != null;
        }

    }
}