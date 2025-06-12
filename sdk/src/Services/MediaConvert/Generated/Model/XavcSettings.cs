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
    /// Required when you set Codec to the value XAVC.
    /// </summary>
    public partial class XavcSettings
    {
        private XavcAdaptiveQuantization _adaptiveQuantization;
        private XavcEntropyEncoding _entropyEncoding;
        private XavcFramerateControl _framerateControl;
        private XavcFramerateConversionAlgorithm _framerateConversionAlgorithm;
        private int? _framerateDenominator;
        private int? _framerateNumerator;
        private List<string> _perFrameMetrics = AWSConfigs.InitializeCollections ? new List<string>() : null;
        private XavcProfile _profile;
        private XavcSlowPal _slowPal;
        private int? _softness;
        private XavcSpatialAdaptiveQuantization _spatialAdaptiveQuantization;
        private XavcTemporalAdaptiveQuantization _temporalAdaptiveQuantization;
        private Xavc4kIntraCbgProfileSettings _xavc4kIntraCbgProfileSettings;
        private Xavc4kIntraVbrProfileSettings _xavc4kIntraVbrProfileSettings;
        private Xavc4kProfileSettings _xavc4kProfileSettings;
        private XavcHdIntraCbgProfileSettings _xavcHdIntraCbgProfileSettings;
        private XavcHdProfileSettings _xavcHdProfileSettings;

        /// <summary>
        /// Gets and sets the property AdaptiveQuantization. Keep the default value, Auto, for
        /// this setting to have MediaConvert automatically apply the best types of quantization
        /// for your video content. When you want to apply your quantization settings manually,
        /// you must set Adaptive quantization to a value other than Auto. Use this setting to
        /// specify the strength of any adaptive quantization filters that you enable. If you
        /// don't want MediaConvert to do any adaptive quantization in this transcode, set Adaptive
        /// quantization to Off. Related settings: The value that you choose here applies to the
        /// following settings: Flicker adaptive quantization (flickerAdaptiveQuantization), Spatial
        /// adaptive quantization, and Temporal adaptive quantization.
        /// </summary>
        public XavcAdaptiveQuantization AdaptiveQuantization
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
        /// Gets and sets the property EntropyEncoding. Optional. Choose a specific entropy encoding
        /// mode only when you want to override XAVC recommendations. If you choose the value
        /// auto, MediaConvert uses the mode that the XAVC file format specifies given this output's
        /// operating point.
        /// </summary>
        public XavcEntropyEncoding EntropyEncoding
        {
            get { return this._entropyEncoding; }
            set { this._entropyEncoding = value; }
        }

        // Check to see if EntropyEncoding property is set
        internal bool IsSetEntropyEncoding()
        {
            return this._entropyEncoding != null;
        }

        /// <summary>
        /// Gets and sets the property FramerateControl. If you are using the console, use the
        /// Frame rate setting to specify the frame rate for this output. If you want to keep
        /// the same frame rate as the input video, choose Follow source. If you want to do frame
        /// rate conversion, choose a frame rate from the dropdown list. The framerates shown
        /// in the dropdown list are decimal approximations of fractions.
        /// </summary>
        public XavcFramerateControl FramerateControl
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
        public XavcFramerateConversionAlgorithm FramerateConversionAlgorithm
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
        /// value as a decimal number for Frame rate. In this example, specify 23.976.
        /// </summary>
        [AWSProperty(Min=1, Max=1001)]
        public int? FramerateDenominator
        {
            get { return this._framerateDenominator; }
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
        [AWSProperty(Min=24, Max=60000)]
        public int? FramerateNumerator
        {
            get { return this._framerateNumerator; }
            set { this._framerateNumerator = value; }
        }

        // Check to see if FramerateNumerator property is set
        internal bool IsSetFramerateNumerator()
        {
            return this._framerateNumerator.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property PerFrameMetrics. Optionally choose one or more per frame
        /// metric reports to generate along with your output. You can use these metrics to analyze
        /// your video output according to one or more commonly used image quality metrics. You
        /// can specify per frame metrics for output groups or for individual outputs. When you
        /// do, MediaConvert writes a CSV (Comma-Separated Values) file to your S3 output destination,
        /// named after the output name and metric type. For example: videofile_PSNR.csv Jobs
        /// that generate per frame metrics will take longer to complete, depending on the resolution
        /// and complexity of your output. For example, some 4K jobs might take up to twice as
        /// long to complete. Note that when analyzing the video quality of your output, or when
        /// comparing the video quality of multiple different outputs, we generally also recommend
        /// a detailed visual review in a controlled environment. You can choose from the following
        /// per frame metrics: * PSNR: Peak Signal-to-Noise Ratio * SSIM: Structural Similarity
        /// Index Measure * MS_SSIM: Multi-Scale Similarity Index Measure * PSNR_HVS: Peak Signal-to-Noise
        /// Ratio, Human Visual System * VMAF: Video Multi-Method Assessment Fusion * QVBR: Quality-Defined
        /// Variable Bitrate. This option is only available when your output uses the QVBR rate
        /// control mode.
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<string> PerFrameMetrics
        {
            get { return this._perFrameMetrics; }
            set { this._perFrameMetrics = value; }
        }

        // Check to see if PerFrameMetrics property is set
        internal bool IsSetPerFrameMetrics()
        {
            return this._perFrameMetrics != null && (this._perFrameMetrics.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property Profile. Specify the XAVC profile for this output. For
        /// more information, see the Sony documentation at https://www.xavc-info.org/. Note that
        /// MediaConvert doesn't support the interlaced video XAVC operating points for XAVC_HD_INTRA_CBG.
        /// To create an interlaced XAVC output, choose the profile XAVC_HD.
        /// </summary>
        public XavcProfile Profile
        {
            get { return this._profile; }
            set { this._profile = value; }
        }

        // Check to see if Profile property is set
        internal bool IsSetProfile()
        {
            return this._profile != null;
        }

        /// <summary>
        /// Gets and sets the property SlowPal. Ignore this setting unless your input frame rate
        /// is 23.976 or 24 frames per second (fps). Enable slow PAL to create a 25 fps output
        /// by relabeling the video frames and resampling your audio. Note that enabling this
        /// setting will slightly reduce the duration of your video. Related settings: You must
        /// also set Frame rate to 25.
        /// </summary>
        public XavcSlowPal SlowPal
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
        /// Gets and sets the property Softness. Ignore this setting unless your downstream workflow
        /// requires that you specify it explicitly. Otherwise, we recommend that you adjust the
        /// softness of your output by using a lower value for the setting Sharpness or by enabling
        /// a noise reducer filter. The Softness setting specifies the quantization matrices that
        /// the encoder uses. Keep the default value, 0, for flat quantization. Choose the value
        /// 1 or 16 to use the default JVT softening quantization matricies from the H.264 specification.
        /// Choose a value from 17 to 128 to use planar interpolation. Increasing values from
        /// 17 to 128 result in increasing reduction of high-frequency data. The value 128 results
        /// in the softest video.
        /// </summary>
        [AWSProperty(Min=0, Max=128)]
        public int? Softness
        {
            get { return this._softness; }
            set { this._softness = value; }
        }

        // Check to see if Softness property is set
        internal bool IsSetSoftness()
        {
            return this._softness.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property SpatialAdaptiveQuantization. The best way to set up adaptive
        /// quantization is to keep the default value, Auto, for the setting Adaptive quantization.
        /// When you do so, MediaConvert automatically applies the best types of quantization
        /// for your video content. Include this setting in your JSON job specification only when
        /// you choose to change the default value for Adaptive quantization. For this setting,
        /// keep the default value, Enabled, to adjust quantization within each frame based on
        /// spatial variation of content complexity. When you enable this feature, the encoder
        /// uses fewer bits on areas that can sustain more distortion with no noticeable visual
        /// degradation and uses more bits on areas where any small distortion will be noticeable.
        /// For example, complex textured blocks are encoded with fewer bits and smooth textured
        /// blocks are encoded with more bits. Enabling this feature will almost always improve
        /// your video quality. Note, though, that this feature doesn't take into account where
        /// the viewer's attention is likely to be. If viewers are likely to be focusing their
        /// attention on a part of the screen with a lot of complex texture, you might choose
        /// to disable this feature. Related setting: When you enable spatial adaptive quantization,
        /// set the value for Adaptive quantization depending on your content. For homogeneous
        /// content, such as cartoons and video games, set it to Low. For content with a wider
        /// variety of textures, set it to High or Higher.
        /// </summary>
        public XavcSpatialAdaptiveQuantization SpatialAdaptiveQuantization
        {
            get { return this._spatialAdaptiveQuantization; }
            set { this._spatialAdaptiveQuantization = value; }
        }

        // Check to see if SpatialAdaptiveQuantization property is set
        internal bool IsSetSpatialAdaptiveQuantization()
        {
            return this._spatialAdaptiveQuantization != null;
        }

        /// <summary>
        /// Gets and sets the property TemporalAdaptiveQuantization. The best way to set up adaptive
        /// quantization is to keep the default value, Auto, for the setting Adaptive quantization.
        /// When you do so, MediaConvert automatically applies the best types of quantization
        /// for your video content. Include this setting in your JSON job specification only when
        /// you choose to change the default value for Adaptive quantization. For this setting,
        /// keep the default value, Enabled, to adjust quantization within each frame based on
        /// temporal variation of content complexity. When you enable this feature, the encoder
        /// uses fewer bits on areas of the frame that aren't moving and uses more bits on complex
        /// objects with sharp edges that move a lot. For example, this feature improves the readability
        /// of text tickers on newscasts and scoreboards on sports matches. Enabling this feature
        /// will almost always improve your video quality. Note, though, that this feature doesn't
        /// take into account where the viewer's attention is likely to be. If viewers are likely
        /// to be focusing their attention on a part of the screen that doesn't have moving objects
        /// with sharp edges, such as sports athletes' faces, you might choose to disable this
        /// feature. Related setting: When you enable temporal adaptive quantization, adjust the
        /// strength of the filter with the setting Adaptive quantization.
        /// </summary>
        public XavcTemporalAdaptiveQuantization TemporalAdaptiveQuantization
        {
            get { return this._temporalAdaptiveQuantization; }
            set { this._temporalAdaptiveQuantization = value; }
        }

        // Check to see if TemporalAdaptiveQuantization property is set
        internal bool IsSetTemporalAdaptiveQuantization()
        {
            return this._temporalAdaptiveQuantization != null;
        }

        /// <summary>
        /// Gets and sets the property Xavc4kIntraCbgProfileSettings. Required when you set Profile
        /// to the value XAVC_4K_INTRA_CBG.
        /// </summary>
        public Xavc4kIntraCbgProfileSettings Xavc4kIntraCbgProfileSettings
        {
            get { return this._xavc4kIntraCbgProfileSettings; }
            set { this._xavc4kIntraCbgProfileSettings = value; }
        }

        // Check to see if Xavc4kIntraCbgProfileSettings property is set
        internal bool IsSetXavc4kIntraCbgProfileSettings()
        {
            return this._xavc4kIntraCbgProfileSettings != null;
        }

        /// <summary>
        /// Gets and sets the property Xavc4kIntraVbrProfileSettings. Required when you set Profile
        /// to the value XAVC_4K_INTRA_VBR.
        /// </summary>
        public Xavc4kIntraVbrProfileSettings Xavc4kIntraVbrProfileSettings
        {
            get { return this._xavc4kIntraVbrProfileSettings; }
            set { this._xavc4kIntraVbrProfileSettings = value; }
        }

        // Check to see if Xavc4kIntraVbrProfileSettings property is set
        internal bool IsSetXavc4kIntraVbrProfileSettings()
        {
            return this._xavc4kIntraVbrProfileSettings != null;
        }

        /// <summary>
        /// Gets and sets the property Xavc4kProfileSettings. Required when you set Profile to
        /// the value XAVC_4K.
        /// </summary>
        public Xavc4kProfileSettings Xavc4kProfileSettings
        {
            get { return this._xavc4kProfileSettings; }
            set { this._xavc4kProfileSettings = value; }
        }

        // Check to see if Xavc4kProfileSettings property is set
        internal bool IsSetXavc4kProfileSettings()
        {
            return this._xavc4kProfileSettings != null;
        }

        /// <summary>
        /// Gets and sets the property XavcHdIntraCbgProfileSettings. Required when you set Profile
        /// to the value XAVC_HD_INTRA_CBG.
        /// </summary>
        public XavcHdIntraCbgProfileSettings XavcHdIntraCbgProfileSettings
        {
            get { return this._xavcHdIntraCbgProfileSettings; }
            set { this._xavcHdIntraCbgProfileSettings = value; }
        }

        // Check to see if XavcHdIntraCbgProfileSettings property is set
        internal bool IsSetXavcHdIntraCbgProfileSettings()
        {
            return this._xavcHdIntraCbgProfileSettings != null;
        }

        /// <summary>
        /// Gets and sets the property XavcHdProfileSettings. Required when you set Profile to
        /// the value XAVC_HD.
        /// </summary>
        public XavcHdProfileSettings XavcHdProfileSettings
        {
            get { return this._xavcHdProfileSettings; }
            set { this._xavcHdProfileSettings = value; }
        }

        // Check to see if XavcHdProfileSettings property is set
        internal bool IsSetXavcHdProfileSettings()
        {
            return this._xavcHdProfileSettings != null;
        }

    }
}