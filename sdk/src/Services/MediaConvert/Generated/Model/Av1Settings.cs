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
    /// Required when you set Codec, under VideoDescription>CodecSettings to the value AV1.
    /// </summary>
    public partial class Av1Settings
    {
        private Av1AdaptiveQuantization _adaptiveQuantization;
        private Av1FramerateControl _framerateControl;
        private Av1FramerateConversionAlgorithm _framerateConversionAlgorithm;
        private int? _framerateDenominator;
        private int? _framerateNumerator;
        private double? _gopSize;
        private int? _maxBitrate;
        private int? _numberBFramesBetweenReferenceFrames;
        private Av1QvbrSettings _qvbrSettings;
        private Av1RateControlMode _rateControlMode;
        private int? _slices;
        private Av1SpatialAdaptiveQuantization _spatialAdaptiveQuantization;

        /// <summary>
        /// Gets and sets the property AdaptiveQuantization. Specify the strength of any adaptive
        /// quantization filters that you enable. The value that you choose here applies to Spatial
        /// adaptive quantization (spatialAdaptiveQuantization).
        /// </summary>
        public Av1AdaptiveQuantization AdaptiveQuantization
        {
            get { return this._adaptiveQuantization; }
            set { this._adaptiveQuantization = value; }
        }

        // Check to see if AdaptiveQuantization property is set
        internal bool IsSetAdaptiveQuantization()
        {
            return this._adaptiveQuantization != null;
        }

        /// <summary>
        /// Gets and sets the property FramerateControl. If you are using the console, use the
        /// Framerate setting to specify the frame rate for this output. If you want to keep the
        /// same frame rate as the input video, choose Follow source. If you want to do frame
        /// rate conversion, choose a frame rate from the dropdown list or choose Custom. The
        /// framerates shown in the dropdown list are decimal approximations of fractions. If
        /// you choose Custom, specify your frame rate as a fraction. If you are creating your
        /// transcoding job specification as a JSON file without the console, use FramerateControl
        /// to specify which value the service uses for the frame rate for this output. Choose
        /// INITIALIZE_FROM_SOURCE if you want the service to use the frame rate from the input.
        /// Choose SPECIFIED if you want the service to use the frame rate you specify in the
        /// settings FramerateNumerator and FramerateDenominator.
        /// </summary>
        public Av1FramerateControl FramerateControl
        {
            get { return this._framerateControl; }
            set { this._framerateControl = value; }
        }

        // Check to see if FramerateControl property is set
        internal bool IsSetFramerateControl()
        {
            return this._framerateControl != null;
        }

        /// <summary>
        /// Gets and sets the property FramerateConversionAlgorithm. Choose the method that you
        /// want MediaConvert to use when increasing or decreasing the frame rate. We recommend
        /// using drop duplicate (DUPLICATE_DROP) for numerically simple conversions, such as
        /// 60 fps to 30 fps. For numerically complex conversions, you can use interpolate (INTERPOLATE)
        /// to avoid stutter. This results in a smooth picture, but might introduce undesirable
        /// video artifacts. For complex frame rate conversions, especially if your source video
        /// has already been converted from its original cadence, use FrameFormer (FRAMEFORMER)
        /// to do motion-compensated interpolation. FrameFormer chooses the best conversion method
        /// frame by frame. Note that using FrameFormer increases the transcoding time and incurs
        /// a significant add-on cost.
        /// </summary>
        public Av1FramerateConversionAlgorithm FramerateConversionAlgorithm
        {
            get { return this._framerateConversionAlgorithm; }
            set { this._framerateConversionAlgorithm = value; }
        }

        // Check to see if FramerateConversionAlgorithm property is set
        internal bool IsSetFramerateConversionAlgorithm()
        {
            return this._framerateConversionAlgorithm != null;
        }

        /// <summary>
        /// Gets and sets the property FramerateDenominator. When you use the API for transcode
        /// jobs that use frame rate conversion, specify the frame rate as a fraction. For example,
        ///  24000 / 1001 = 23.976 fps. Use FramerateDenominator to specify the denominator of
        /// this fraction. In this example, use 1001 for the value of FramerateDenominator. When
        /// you use the console for transcode jobs that use frame rate conversion, provide the
        /// value as a decimal number for Framerate. In this example, specify 23.976.
        /// </summary>
        [AWSProperty(Min=1, Max=2147483647)]
        public int FramerateDenominator
        {
            get { return this._framerateDenominator.GetValueOrDefault(); }
            set { this._framerateDenominator = value; }
        }

        // Check to see if FramerateDenominator property is set
        internal bool IsSetFramerateDenominator()
        {
            return this._framerateDenominator.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property FramerateNumerator. When you use the API for transcode
        /// jobs that use frame rate conversion, specify the frame rate as a fraction. For example,
        ///  24000 / 1001 = 23.976 fps. Use FramerateNumerator to specify the numerator of this
        /// fraction. In this example, use 24000 for the value of FramerateNumerator. When you
        /// use the console for transcode jobs that use frame rate conversion, provide the value
        /// as a decimal number for Framerate. In this example, specify 23.976.
        /// </summary>
        [AWSProperty(Min=1, Max=2147483647)]
        public int FramerateNumerator
        {
            get { return this._framerateNumerator.GetValueOrDefault(); }
            set { this._framerateNumerator = value; }
        }

        // Check to see if FramerateNumerator property is set
        internal bool IsSetFramerateNumerator()
        {
            return this._framerateNumerator.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property GopSize. Specify the GOP length (keyframe interval) in
        /// frames. With AV1, MediaConvert doesn't support GOP length in seconds. This value must
        /// be greater than zero and preferably equal to 1 + ((numberBFrames + 1) * x), where
        /// x is an integer value.
        /// </summary>
        public double GopSize
        {
            get { return this._gopSize.GetValueOrDefault(); }
            set { this._gopSize = value; }
        }

        // Check to see if GopSize property is set
        internal bool IsSetGopSize()
        {
            return this._gopSize.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property MaxBitrate. Maximum bitrate in bits/second. For example,
        /// enter five megabits per second as 5000000. Required when Rate control mode is QVBR.
        /// </summary>
        [AWSProperty(Min=1000, Max=1152000000)]
        public int MaxBitrate
        {
            get { return this._maxBitrate.GetValueOrDefault(); }
            set { this._maxBitrate = value; }
        }

        // Check to see if MaxBitrate property is set
        internal bool IsSetMaxBitrate()
        {
            return this._maxBitrate.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property NumberBFramesBetweenReferenceFrames. Specify the number
        /// of B-frames. With AV1, MediaConvert supports only 7 or 15.
        /// </summary>
        [AWSProperty(Min=7, Max=15)]
        public int NumberBFramesBetweenReferenceFrames
        {
            get { return this._numberBFramesBetweenReferenceFrames.GetValueOrDefault(); }
            set { this._numberBFramesBetweenReferenceFrames = value; }
        }

        // Check to see if NumberBFramesBetweenReferenceFrames property is set
        internal bool IsSetNumberBFramesBetweenReferenceFrames()
        {
            return this._numberBFramesBetweenReferenceFrames.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property QvbrSettings. Settings for quality-defined variable bitrate
        /// encoding with the AV1 codec. Required when you set Rate control mode to QVBR. Not
        /// valid when you set Rate control mode to a value other than QVBR, or when you don't
        /// define Rate control mode.
        /// </summary>
        public Av1QvbrSettings QvbrSettings
        {
            get { return this._qvbrSettings; }
            set { this._qvbrSettings = value; }
        }

        // Check to see if QvbrSettings property is set
        internal bool IsSetQvbrSettings()
        {
            return this._qvbrSettings != null;
        }

        /// <summary>
        /// Gets and sets the property RateControlMode. 'With AV1 outputs, for rate control mode,
        /// MediaConvert supports only quality-defined variable bitrate (QVBR). You can''t use
        /// CBR or VBR.'
        /// </summary>
        public Av1RateControlMode RateControlMode
        {
            get { return this._rateControlMode; }
            set { this._rateControlMode = value; }
        }

        // Check to see if RateControlMode property is set
        internal bool IsSetRateControlMode()
        {
            return this._rateControlMode != null;
        }

        /// <summary>
        /// Gets and sets the property Slices. Specify the number of slices per picture. This
        /// value must be 1, 2, 4, 8, 16, or 32. For progressive pictures, this value must be
        /// less than or equal to the number of macroblock rows. For interlaced pictures, this
        /// value must be less than or equal to half the number of macroblock rows.
        /// </summary>
        [AWSProperty(Min=1, Max=32)]
        public int Slices
        {
            get { return this._slices.GetValueOrDefault(); }
            set { this._slices = value; }
        }

        // Check to see if Slices property is set
        internal bool IsSetSlices()
        {
            return this._slices.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property SpatialAdaptiveQuantization. Keep the default value, Enabled
        /// (ENABLED), to adjust quantization within each frame based on spatial variation of
        /// content complexity. When you enable this feature, the encoder uses fewer bits on areas
        /// that can sustain more distortion with no noticeable visual degradation and uses more
        /// bits on areas where any small distortion will be noticeable. For example, complex
        /// textured blocks are encoded with fewer bits and smooth textured blocks are encoded
        /// with more bits. Enabling this feature will almost always improve your video quality.
        /// Note, though, that this feature doesn't take into account where the viewer's attention
        /// is likely to be. If viewers are likely to be focusing their attention on a part of
        /// the screen with a lot of complex texture, you might choose to disable this feature.
        /// Related setting: When you enable spatial adaptive quantization, set the value for
        /// Adaptive quantization (adaptiveQuantization) depending on your content. For homogeneous
        /// content, such as cartoons and video games, set it to Low. For content with a wider
        /// variety of textures, set it to High or Higher.
        /// </summary>
        public Av1SpatialAdaptiveQuantization SpatialAdaptiveQuantization
        {
            get { return this._spatialAdaptiveQuantization; }
            set { this._spatialAdaptiveQuantization = value; }
        }

        // Check to see if SpatialAdaptiveQuantization property is set
        internal bool IsSetSpatialAdaptiveQuantization()
        {
            return this._spatialAdaptiveQuantization != null;
        }

    }
}