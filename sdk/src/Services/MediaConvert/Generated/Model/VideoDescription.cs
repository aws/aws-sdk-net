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
    /// Settings related to video encoding of your output. The specific video settings depend
    /// on the video codec that you choose. When you work directly in your JSON job specification,
    /// include one instance of Video description (VideoDescription) per output.
    /// </summary>
    public partial class VideoDescription
    {
        private AfdSignaling _afdSignaling;
        private AntiAlias _antiAlias;
        private VideoCodecSettings _codecSettings;
        private ColorMetadata _colorMetadata;
        private Rectangle _crop;
        private DropFrameTimecode _dropFrameTimecode;
        private int? _fixedAfd;
        private int? _height;
        private Rectangle _position;
        private RespondToAfd _respondToAfd;
        private ScalingBehavior _scalingBehavior;
        private int? _sharpness;
        private VideoTimecodeInsertion _timecodeInsertion;
        private VideoPreprocessor _videoPreprocessors;
        private int? _width;

        /// <summary>
        /// Gets and sets the property AfdSignaling. This setting only applies to H.264, H.265,
        /// and MPEG2 outputs. Use Insert AFD signaling (AfdSignaling) to specify whether the
        /// service includes AFD values in the output video data and what those values are. *
        /// Choose None to remove all AFD values from this output. * Choose Fixed to ignore input
        /// AFD values and instead encode the value specified in the job. * Choose Auto to calculate
        /// output AFD values based on the input AFD scaler data.
        /// </summary>
        public AfdSignaling AfdSignaling
        {
            get { return this._afdSignaling; }
            set { this._afdSignaling = value; }
        }

        // Check to see if AfdSignaling property is set
        internal bool IsSetAfdSignaling()
        {
            return this._afdSignaling != null;
        }

        /// <summary>
        /// Gets and sets the property AntiAlias. The anti-alias filter is automatically applied
        /// to all outputs. The service no longer accepts the value DISABLED for AntiAlias. If
        /// you specify that in your job, the service will ignore the setting.
        /// </summary>
        public AntiAlias AntiAlias
        {
            get { return this._antiAlias; }
            set { this._antiAlias = value; }
        }

        // Check to see if AntiAlias property is set
        internal bool IsSetAntiAlias()
        {
            return this._antiAlias != null;
        }

        /// <summary>
        /// Gets and sets the property CodecSettings. Video codec settings, (CodecSettings) under
        /// (VideoDescription), contains the group of settings related to video encoding. The
        /// settings in this group vary depending on the value that you choose for Video codec
        /// (Codec). For each codec enum that you choose, define the corresponding settings object.
        /// The following lists the codec enum, settings object pairs. * AV1, Av1Settings * AVC_INTRA,
        /// AvcIntraSettings * FRAME_CAPTURE, FrameCaptureSettings * H_264, H264Settings * H_265,
        /// H265Settings * MPEG2, Mpeg2Settings * PRORES, ProresSettings * VC3, Vc3Settings *
        /// VP8, Vp8Settings * VP9, Vp9Settings * XAVC, XavcSettings
        /// </summary>
        public VideoCodecSettings CodecSettings
        {
            get { return this._codecSettings; }
            set { this._codecSettings = value; }
        }

        // Check to see if CodecSettings property is set
        internal bool IsSetCodecSettings()
        {
            return this._codecSettings != null;
        }

        /// <summary>
        /// Gets and sets the property ColorMetadata. Choose Insert (INSERT) for this setting
        /// to include color metadata in this output. Choose Ignore (IGNORE) to exclude color
        /// metadata from this output. If you don't specify a value, the service sets this to
        /// Insert by default.
        /// </summary>
        public ColorMetadata ColorMetadata
        {
            get { return this._colorMetadata; }
            set { this._colorMetadata = value; }
        }

        // Check to see if ColorMetadata property is set
        internal bool IsSetColorMetadata()
        {
            return this._colorMetadata != null;
        }

        /// <summary>
        /// Gets and sets the property Crop. Use Cropping selection (crop) to specify the video
        /// area that the service will include in the output video frame.
        /// </summary>
        public Rectangle Crop
        {
            get { return this._crop; }
            set { this._crop = value; }
        }

        // Check to see if Crop property is set
        internal bool IsSetCrop()
        {
            return this._crop != null;
        }

        /// <summary>
        /// Gets and sets the property DropFrameTimecode. Applies only to 29.97 fps outputs. When
        /// this feature is enabled, the service will use drop-frame timecode on outputs. If it
        /// is not possible to use drop-frame timecode, the system will fall back to non-drop-frame.
        /// This setting is enabled by default when Timecode insertion (TimecodeInsertion) is
        /// enabled.
        /// </summary>
        public DropFrameTimecode DropFrameTimecode
        {
            get { return this._dropFrameTimecode; }
            set { this._dropFrameTimecode = value; }
        }

        // Check to see if DropFrameTimecode property is set
        internal bool IsSetDropFrameTimecode()
        {
            return this._dropFrameTimecode != null;
        }

        /// <summary>
        /// Gets and sets the property FixedAfd. Applies only if you set AFD Signaling(AfdSignaling)
        /// to Fixed (FIXED). Use Fixed (FixedAfd) to specify a four-bit AFD value which the service
        /// will write on all frames of this video output.
        /// </summary>
        [AWSProperty(Min=0, Max=15)]
        public int FixedAfd
        {
            get { return this._fixedAfd.GetValueOrDefault(); }
            set { this._fixedAfd = value; }
        }

        // Check to see if FixedAfd property is set
        internal bool IsSetFixedAfd()
        {
            return this._fixedAfd.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Height. Use the Height (Height) setting to define the video
        /// resolution height for this output. Specify in pixels. If you don't provide a value
        /// here, the service will use the input height.
        /// </summary>
        [AWSProperty(Min=32, Max=8192)]
        public int Height
        {
            get { return this._height.GetValueOrDefault(); }
            set { this._height = value; }
        }

        // Check to see if Height property is set
        internal bool IsSetHeight()
        {
            return this._height.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Position. Use Selection placement (position) to define
        /// the video area in your output frame. The area outside of the rectangle that you specify
        /// here is black.
        /// </summary>
        public Rectangle Position
        {
            get { return this._position; }
            set { this._position = value; }
        }

        // Check to see if Position property is set
        internal bool IsSetPosition()
        {
            return this._position != null;
        }

        /// <summary>
        /// Gets and sets the property RespondToAfd. Use Respond to AFD (RespondToAfd) to specify
        /// how the service changes the video itself in response to AFD values in the input. *
        /// Choose Respond to clip the input video frame according to the AFD value, input display
        /// aspect ratio, and output display aspect ratio. * Choose Passthrough to include the
        /// input AFD values. Do not choose this when AfdSignaling is set to (NONE). A preferred
        /// implementation of this workflow is to set RespondToAfd to (NONE) and set AfdSignaling
        /// to (AUTO). * Choose None to remove all input AFD values from this output.
        /// </summary>
        public RespondToAfd RespondToAfd
        {
            get { return this._respondToAfd; }
            set { this._respondToAfd = value; }
        }

        // Check to see if RespondToAfd property is set
        internal bool IsSetRespondToAfd()
        {
            return this._respondToAfd != null;
        }

        /// <summary>
        /// Gets and sets the property ScalingBehavior. Specify how the service handles outputs
        /// that have a different aspect ratio from the input aspect ratio. Choose Stretch to
        /// output (STRETCH_TO_OUTPUT) to have the service stretch your video image to fit. Keep
        /// the setting Default (DEFAULT) to have the service letterbox your video instead. This
        /// setting overrides any value that you specify for the setting Selection placement (position)
        /// in this output.
        /// </summary>
        public ScalingBehavior ScalingBehavior
        {
            get { return this._scalingBehavior; }
            set { this._scalingBehavior = value; }
        }

        // Check to see if ScalingBehavior property is set
        internal bool IsSetScalingBehavior()
        {
            return this._scalingBehavior != null;
        }

        /// <summary>
        /// Gets and sets the property Sharpness. Use Sharpness (Sharpness) setting to specify
        /// the strength of anti-aliasing. This setting changes the width of the anti-alias filter
        /// kernel used for scaling. Sharpness only applies if your output resolution is different
        /// from your input resolution. 0 is the softest setting, 100 the sharpest, and 50 recommended
        /// for most content.
        /// </summary>
        [AWSProperty(Min=0, Max=100)]
        public int Sharpness
        {
            get { return this._sharpness.GetValueOrDefault(); }
            set { this._sharpness = value; }
        }

        // Check to see if Sharpness property is set
        internal bool IsSetSharpness()
        {
            return this._sharpness.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property TimecodeInsertion. Applies only to H.264, H.265, MPEG2,
        /// and ProRes outputs. Only enable Timecode insertion when the input frame rate is identical
        /// to the output frame rate. To include timecodes in this output, set Timecode insertion
        /// (VideoTimecodeInsertion) to PIC_TIMING_SEI. To leave them out, set it to DISABLED.
        /// Default is DISABLED. When the service inserts timecodes in an output, by default,
        /// it uses any embedded timecodes from the input. If none are present, the service will
        /// set the timecode for the first output frame to zero. To change this default behavior,
        /// adjust the settings under Timecode configuration (TimecodeConfig). In the console,
        /// these settings are located under Job > Job settings > Timecode configuration. Note
        /// - Timecode source under input settings (InputTimecodeSource) does not affect the timecodes
        /// that are inserted in the output. Source under Job settings > Timecode configuration
        /// (TimecodeSource) does.
        /// </summary>
        public VideoTimecodeInsertion TimecodeInsertion
        {
            get { return this._timecodeInsertion; }
            set { this._timecodeInsertion = value; }
        }

        // Check to see if TimecodeInsertion property is set
        internal bool IsSetTimecodeInsertion()
        {
            return this._timecodeInsertion != null;
        }

        /// <summary>
        /// Gets and sets the property VideoPreprocessors. Find additional transcoding features
        /// under Preprocessors (VideoPreprocessors). Enable the features at each output individually.
        /// These features are disabled by default.
        /// </summary>
        public VideoPreprocessor VideoPreprocessors
        {
            get { return this._videoPreprocessors; }
            set { this._videoPreprocessors = value; }
        }

        // Check to see if VideoPreprocessors property is set
        internal bool IsSetVideoPreprocessors()
        {
            return this._videoPreprocessors != null;
        }

        /// <summary>
        /// Gets and sets the property Width. Use Width (Width) to define the video resolution
        /// width, in pixels, for this output. If you don't provide a value here, the service
        /// will use the input width.
        /// </summary>
        [AWSProperty(Min=32, Max=8192)]
        public int Width
        {
            get { return this._width.GetValueOrDefault(); }
            set { this._width = value; }
        }

        // Check to see if Width property is set
        internal bool IsSetWidth()
        {
            return this._width.HasValue; 
        }

    }
}