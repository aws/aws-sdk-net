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
    /// Required when you set (Codec) under (VideoDescription)>(CodecSettings) to the value
    /// PRORES.
    /// </summary>
    public partial class ProresSettings
    {
        private ProresChromaSampling _chromaSampling;
        private ProresCodecProfile _codecProfile;
        private ProresFramerateControl _framerateControl;
        private ProresFramerateConversionAlgorithm _framerateConversionAlgorithm;
        private int? _framerateDenominator;
        private int? _framerateNumerator;
        private ProresInterlaceMode _interlaceMode;
        private ProresParControl _parControl;
        private int? _parDenominator;
        private int? _parNumerator;
        private ProresScanTypeConversionMode _scanTypeConversionMode;
        private ProresSlowPal _slowPal;
        private ProresTelecine _telecine;

        /// <summary>
        /// Gets and sets the property ChromaSampling. This setting applies only to ProRes 4444
        /// and ProRes 4444 XQ outputs that you create from inputs that use 4:4:4 chroma sampling.
        /// Set Preserve 4:4:4 sampling (PRESERVE_444_SAMPLING) to allow outputs to also use 4:4:4
        /// chroma sampling. You must specify a value for this setting when your output codec
        /// profile supports 4:4:4 chroma sampling. Related Settings: When you set Chroma sampling
        /// to Preserve 4:4:4 sampling (PRESERVE_444_SAMPLING), you must choose an output codec
        /// profile that supports 4:4:4 chroma sampling. These values for Profile (CodecProfile)
        /// support 4:4:4 chroma sampling: Apple ProRes 4444 (APPLE_PRORES_4444) or Apple ProRes
        /// 4444 XQ (APPLE_PRORES_4444_XQ). When you set Chroma sampling to Preserve 4:4:4 sampling,
        /// you must disable all video preprocessors except for Nexguard file marker (PartnerWatermarking).
        /// When you set Chroma sampling to Preserve 4:4:4 sampling and use framerate conversion,
        /// you must set Frame rate conversion algorithm (FramerateConversionAlgorithm) to Drop
        /// duplicate (DUPLICATE_DROP).
        /// </summary>
        public ProresChromaSampling ChromaSampling
        {
            get { return this._chromaSampling; }
            set { this._chromaSampling = value; }
        }

        // Check to see if ChromaSampling property is set
        internal bool IsSetChromaSampling()
        {
            return this._chromaSampling != null;
        }

        /// <summary>
        /// Gets and sets the property CodecProfile. Use Profile (ProResCodecProfile) to specify
        /// the type of Apple ProRes codec to use for this output.
        /// </summary>
        public ProresCodecProfile CodecProfile
        {
            get { return this._codecProfile; }
            set { this._codecProfile = value; }
        }

        // Check to see if CodecProfile property is set
        internal bool IsSetCodecProfile()
        {
            return this._codecProfile != null;
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
        public ProresFramerateControl FramerateControl
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
        public ProresFramerateConversionAlgorithm FramerateConversionAlgorithm
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
        /// 24000 / 1001 = 23.976 fps. Use FramerateDenominator to specify the denominator of
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
        /// 24000 / 1001 = 23.976 fps. Use FramerateNumerator to specify the numerator of this
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
        /// Gets and sets the property InterlaceMode. Choose the scan line type for the output.
        /// Keep the default value, Progressive (PROGRESSIVE) to create a progressive output,
        /// regardless of the scan type of your input. Use Top field first (TOP_FIELD) or Bottom
        /// field first (BOTTOM_FIELD) to create an output that's interlaced with the same field
        /// polarity throughout. Use Follow, default top (FOLLOW_TOP_FIELD) or Follow, default
        /// bottom (FOLLOW_BOTTOM_FIELD) to produce outputs with the same field polarity as the
        /// source. For jobs that have multiple inputs, the output field polarity might change
        /// over the course of the output. Follow behavior depends on the input scan type. If
        /// the source is interlaced, the output will be interlaced with the same polarity as
        /// the source. If the source is progressive, the output will be interlaced with top field
        /// bottom field first, depending on which of the Follow options you choose.
        /// </summary>
        public ProresInterlaceMode InterlaceMode
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
        /// Gets and sets the property ParControl. Optional. Specify how the service determines
        /// the pixel aspect ratio (PAR) for this output. The default behavior, Follow source
        /// (INITIALIZE_FROM_SOURCE), uses the PAR from your input video for your output. To specify
        /// a different PAR in the console, choose any value other than Follow source. To specify
        /// a different PAR by editing the JSON job specification, choose SPECIFIED. When you
        /// choose SPECIFIED for this setting, you must also specify values for the parNumerator
        /// and parDenominator settings.
        /// </summary>
        public ProresParControl ParControl
        {
            get { return this._parControl; }
            set { this._parControl = value; }
        }

        // Check to see if ParControl property is set
        internal bool IsSetParControl()
        {
            return this._parControl != null;
        }

        /// <summary>
        /// Gets and sets the property ParDenominator. Required when you set Pixel aspect ratio
        /// (parControl) to SPECIFIED. On the console, this corresponds to any value other than
        /// Follow source. When you specify an output pixel aspect ratio (PAR) that is different
        /// from your input video PAR, provide your output PAR as a ratio. For example, for D1/DV
        /// NTSC widescreen, you would specify the ratio 40:33. In this example, the value for
        /// parDenominator is 33.
        /// </summary>
        [AWSProperty(Min=1, Max=2147483647)]
        public int ParDenominator
        {
            get { return this._parDenominator.GetValueOrDefault(); }
            set { this._parDenominator = value; }
        }

        // Check to see if ParDenominator property is set
        internal bool IsSetParDenominator()
        {
            return this._parDenominator.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property ParNumerator. Required when you set Pixel aspect ratio
        /// (parControl) to SPECIFIED. On the console, this corresponds to any value other than
        /// Follow source. When you specify an output pixel aspect ratio (PAR) that is different
        /// from your input video PAR, provide your output PAR as a ratio. For example, for D1/DV
        /// NTSC widescreen, you would specify the ratio 40:33. In this example, the value for
        /// parNumerator is 40.
        /// </summary>
        [AWSProperty(Min=1, Max=2147483647)]
        public int ParNumerator
        {
            get { return this._parNumerator.GetValueOrDefault(); }
            set { this._parNumerator = value; }
        }

        // Check to see if ParNumerator property is set
        internal bool IsSetParNumerator()
        {
            return this._parNumerator.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property ScanTypeConversionMode. Use this setting for interlaced
        /// outputs, when your output frame rate is half of your input frame rate. In this situation,
        /// choose Optimized interlacing (INTERLACED_OPTIMIZE) to create a better quality interlaced
        /// output. In this case, each progressive frame from the input corresponds to an interlaced
        /// field in the output. Keep the default value, Basic interlacing (INTERLACED), for all
        /// other output frame rates. With basic interlacing, MediaConvert performs any frame
        /// rate conversion first and then interlaces the frames. When you choose Optimized interlacing
        /// and you set your output frame rate to a value that isn't suitable for optimized interlacing,
        /// MediaConvert automatically falls back to basic interlacing. Required settings: To
        /// use optimized interlacing, you must set Telecine (telecine) to None (NONE) or Soft
        /// (SOFT). You can't use optimized interlacing for hard telecine outputs. You must also
        /// set Interlace mode (interlaceMode) to a value other than Progressive (PROGRESSIVE).
        /// </summary>
        public ProresScanTypeConversionMode ScanTypeConversionMode
        {
            get { return this._scanTypeConversionMode; }
            set { this._scanTypeConversionMode = value; }
        }

        // Check to see if ScanTypeConversionMode property is set
        internal bool IsSetScanTypeConversionMode()
        {
            return this._scanTypeConversionMode != null;
        }

        /// <summary>
        /// Gets and sets the property SlowPal. Ignore this setting unless your input frame rate
        /// is 23.976 or 24 frames per second (fps). Enable slow PAL to create a 25 fps output.
        /// When you enable slow PAL, MediaConvert relabels the video frames to 25 fps and resamples
        /// your audio to keep it synchronized with the video. Note that enabling this setting
        /// will slightly reduce the duration of your video. Required settings: You must also
        /// set Framerate to 25. In your JSON job specification, set (framerateControl) to (SPECIFIED),
        /// (framerateNumerator) to 25 and (framerateDenominator) to 1.
        /// </summary>
        public ProresSlowPal SlowPal
        {
            get { return this._slowPal; }
            set { this._slowPal = value; }
        }

        // Check to see if SlowPal property is set
        internal bool IsSetSlowPal()
        {
            return this._slowPal != null;
        }

        /// <summary>
        /// Gets and sets the property Telecine. When you do frame rate conversion from 23.976
        /// frames per second (fps) to 29.97 fps, and your output scan type is interlaced, you
        /// can optionally enable hard telecine (HARD) to create a smoother picture. When you
        /// keep the default value, None (NONE), MediaConvert does a standard frame rate conversion
        /// to 29.97 without doing anything with the field polarity to create a smoother picture.
        /// </summary>
        public ProresTelecine Telecine
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