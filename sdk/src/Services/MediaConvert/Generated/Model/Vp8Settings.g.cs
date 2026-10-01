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
    /// Required when you set Codec to the value VP8.
    /// </summary>
    public partial class Vp8Settings
    {
        /// <summary>
        /// Gets and sets the property Bitrate. Target bitrate in bits/second. For example, enter
        /// five megabits per second as 5000000.
        /// </summary>
        [AWSProperty(Min = 1000, Max = 1152000000)]
        public int? Bitrate { get; set; }

        /// <summary>
        /// Checks to see if the Bitrate property is set.
        /// </summary>
        internal bool IsSetBitrate() => this.Bitrate.HasValue;

        /// <summary>
        /// Gets and sets the property FramerateControl. If you are using the console, use the
        /// Framerate setting to specify the frame rate for this output. If you want to keep the
        /// same frame rate as the input video, choose Follow source. If you want to do frame
        /// rate conversion, choose a frame rate from the dropdown list or choose Custom. The
        /// framerates shown in the dropdown list are decimal approximations of fractions. If
        /// you choose Custom, specify your frame rate as a fraction.
        /// </summary>
        public Vp8FramerateControl FramerateControl { get; set; }

        /// <summary>
        /// Checks to see if the FramerateControl property is set.
        /// </summary>
        internal bool IsSetFramerateControl() => this.FramerateControl != null;

        /// <summary>
        /// Gets and sets the property FramerateConversionAlgorithm. Choose the method that you
        /// want MediaConvert to use when increasing or decreasing your video's frame rate. For
        /// numerically simple conversions, such as 60 fps to 30 fps: We recommend that you keep
        /// the default value, Drop duplicate. For numerically complex conversions, to avoid stutter:
        /// Choose Interpolate. This results in a smooth picture, but might introduce undesirable
        /// video artifacts. For complex frame rate conversions, especially if your source video
        /// has already been converted from its original cadence: Choose FrameFormer to do motion-compensated
        /// interpolation. FrameFormer uses the best conversion method frame by frame. Note that
        /// using FrameFormer increases the transcoding time and incurs a significant add-on cost.
        /// When you choose FrameFormer, your input video resolution must be at least 128x96.
        /// To create an output with the same number of frames as your input: Choose Maintain
        /// frame count. When you do, MediaConvert will not drop, interpolate, add, or otherwise
        /// change the frame count from your input to your output. Note that since the frame count
        /// is maintained, the duration of your output will become shorter at higher frame rates
        /// and longer at lower frame rates.
        /// </summary>
        public Vp8FramerateConversionAlgorithm FramerateConversionAlgorithm { get; set; }

        /// <summary>
        /// Checks to see if the FramerateConversionAlgorithm property is set.
        /// </summary>
        internal bool IsSetFramerateConversionAlgorithm() => this.FramerateConversionAlgorithm != null;

        /// <summary>
        /// Gets and sets the property FramerateDenominator. When you use the API for transcode
        /// jobs that use frame rate conversion, specify the frame rate as a fraction. For example,
        /// 24000 / 1001 = 23.976 fps. Use FramerateDenominator to specify the denominator of
        /// this fraction. In this example, use 1001 for the value of FramerateDenominator. When
        /// you use the console for transcode jobs that use frame rate conversion, provide the
        /// value as a decimal number for Framerate. In this example, specify 23.976.
        /// </summary>
        [AWSProperty(Min = 1, Max = 2147483647)]
        public int? FramerateDenominator { get; set; }

        /// <summary>
        /// Checks to see if the FramerateDenominator property is set.
        /// </summary>
        internal bool IsSetFramerateDenominator() => this.FramerateDenominator.HasValue;

        /// <summary>
        /// Gets and sets the property FramerateNumerator. When you use the API for transcode
        /// jobs that use frame rate conversion, specify the frame rate as a fraction. For example,
        /// 24000 / 1001 = 23.976 fps. Use FramerateNumerator to specify the numerator of this
        /// fraction. In this example, use 24000 for the value of FramerateNumerator. When you
        /// use the console for transcode jobs that use frame rate conversion, provide the value
        /// as a decimal number for Framerate. In this example, specify 23.976.
        /// </summary>
        [AWSProperty(Min = 1, Max = 2147483647)]
        public int? FramerateNumerator { get; set; }

        /// <summary>
        /// Checks to see if the FramerateNumerator property is set.
        /// </summary>
        internal bool IsSetFramerateNumerator() => this.FramerateNumerator.HasValue;

        /// <summary>
        /// Gets and sets the property GopSize. GOP Length (keyframe interval) in frames. Must
        /// be greater than zero.
        /// </summary>
        public double? GopSize { get; set; }

        /// <summary>
        /// Checks to see if the GopSize property is set.
        /// </summary>
        internal bool IsSetGopSize() => this.GopSize.HasValue;

        /// <summary>
        /// Gets and sets the property HrdBufferSize. Optional. Size of buffer (HRD buffer model)
        /// in bits. For example, enter five megabits as 5000000.
        /// </summary>
        [AWSProperty(Min = 0, Max = 47185920)]
        public int? HrdBufferSize { get; set; }

        /// <summary>
        /// Checks to see if the HrdBufferSize property is set.
        /// </summary>
        internal bool IsSetHrdBufferSize() => this.HrdBufferSize.HasValue;

        /// <summary>
        /// Gets and sets the property MaxBitrate. Ignore this setting unless you set qualityTuningLevel
        /// to MULTI_PASS. Optional. Specify the maximum bitrate in bits/second. For example,
        /// enter five megabits per second as 5000000. The default behavior uses twice the target
        /// bitrate as the maximum bitrate.
        /// </summary>
        [AWSProperty(Min = 1000, Max = 1152000000)]
        public int? MaxBitrate { get; set; }

        /// <summary>
        /// Checks to see if the MaxBitrate property is set.
        /// </summary>
        internal bool IsSetMaxBitrate() => this.MaxBitrate.HasValue;

        /// <summary>
        /// Gets and sets the property ParControl. Optional. Specify how the service determines
        /// the pixel aspect ratio (PAR) for this output. The default behavior, Follow source,
        /// uses the PAR from your input video for your output. To specify a different PAR in
        /// the console, choose any value other than Follow source. When you choose SPECIFIED
        /// for this setting, you must also specify values for the parNumerator and parDenominator
        /// settings.
        /// </summary>
        public Vp8ParControl ParControl { get; set; }

        /// <summary>
        /// Checks to see if the ParControl property is set.
        /// </summary>
        internal bool IsSetParControl() => this.ParControl != null;

        /// <summary>
        /// Gets and sets the property ParDenominator. Required when you set Pixel aspect ratio
        /// to SPECIFIED. On the console, this corresponds to any value other than Follow source.
        /// When you specify an output pixel aspect ratio (PAR) that is different from your input
        /// video PAR, provide your output PAR as a ratio. For example, for D1/DV NTSC widescreen,
        /// you would specify the ratio 40:33. In this example, the value for parDenominator is
        /// 33.
        /// </summary>
        [AWSProperty(Min = 1, Max = 2147483647)]
        public int? ParDenominator { get; set; }

        /// <summary>
        /// Checks to see if the ParDenominator property is set.
        /// </summary>
        internal bool IsSetParDenominator() => this.ParDenominator.HasValue;

        /// <summary>
        /// Gets and sets the property ParNumerator. Required when you set Pixel aspect ratio
        /// to SPECIFIED. On the console, this corresponds to any value other than Follow source.
        /// When you specify an output pixel aspect ratio (PAR) that is different from your input
        /// video PAR, provide your output PAR as a ratio. For example, for D1/DV NTSC widescreen,
        /// you would specify the ratio 40:33. In this example, the value for parNumerator is
        /// 40.
        /// </summary>
        [AWSProperty(Min = 1, Max = 2147483647)]
        public int? ParNumerator { get; set; }

        /// <summary>
        /// Checks to see if the ParNumerator property is set.
        /// </summary>
        internal bool IsSetParNumerator() => this.ParNumerator.HasValue;

        /// <summary>
        /// Gets and sets the property QualityTuningLevel. Optional. Use Quality tuning level
        /// to choose how you want to trade off encoding speed for output video quality. The default
        /// behavior is faster, lower quality, multi-pass encoding.
        /// </summary>
        public Vp8QualityTuningLevel QualityTuningLevel { get; set; }

        /// <summary>
        /// Checks to see if the QualityTuningLevel property is set.
        /// </summary>
        internal bool IsSetQualityTuningLevel() => this.QualityTuningLevel != null;

        /// <summary>
        /// Gets and sets the property RateControlMode. With the VP8 codec, you can use only the
        /// variable bitrate (VBR) rate control mode.
        /// </summary>
        public Vp8RateControlMode RateControlMode { get; set; }

        /// <summary>
        /// Checks to see if the RateControlMode property is set.
        /// </summary>
        internal bool IsSetRateControlMode() => this.RateControlMode != null;
    }
}
