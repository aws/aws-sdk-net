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
    /// Settings related to video encoding of your output. The specific video settings depend
    /// on the video codec that you choose.
    /// </summary>
    public partial class VideoDescription
    {
        /// <summary>
        /// Gets and sets the property AfdSignaling. This setting only applies to H.264, H.265,
        /// and MPEG2 outputs. Use Insert AFD signaling to specify whether the service includes
        /// AFD values in the output video data and what those values are. * Choose None to remove
        /// all AFD values from this output. * Choose Fixed to ignore input AFD values and instead
        /// encode the value specified in the job. * Choose Auto to calculate output AFD values
        /// based on the input AFD scaler data.
        /// </summary>
        public AfdSignaling AfdSignaling { get; set; }

        /// <summary>
        /// Checks to see if the AfdSignaling property is set.
        /// </summary>
        internal bool IsSetAfdSignaling() => this.AfdSignaling != null;

        /// <summary>
        /// Gets and sets the property AntiAlias. The anti-alias filter is automatically applied
        /// to all outputs. The service no longer accepts the value DISABLED for AntiAlias. If
        /// you specify that in your job, the service will ignore the setting.
        /// </summary>
        public AntiAlias AntiAlias { get; set; }

        /// <summary>
        /// Checks to see if the AntiAlias property is set.
        /// </summary>
        internal bool IsSetAntiAlias() => this.AntiAlias != null;

        /// <summary>
        /// Gets and sets the property ChromaPositionMode. Specify the chroma sample positioning
        /// metadata for your H.264 or H.265 output. To have MediaConvert automatically determine
        /// chroma positioning: We recommend that you keep the default value, Auto. To specify
        /// center positioning: Choose Force center. To specify top left positioning: Choose Force
        /// top left.
        /// </summary>
        public ChromaPositionMode ChromaPositionMode { get; set; }

        /// <summary>
        /// Checks to see if the ChromaPositionMode property is set.
        /// </summary>
        internal bool IsSetChromaPositionMode() => this.ChromaPositionMode != null;

        /// <summary>
        /// Gets and sets the property CodecSettings. Video codec settings contains the group
        /// of settings related to video encoding. The settings in this group vary depending on
        /// the value that you choose for Video codec. For each codec enum that you choose, define
        /// the corresponding settings object. The following lists the codec enum, settings object
        /// pairs. * AV1, Av1Settings * AVC_INTRA, AvcIntraSettings * FRAME_CAPTURE, FrameCaptureSettings
        /// * GIF, GifSettings * H_264, H264Settings * H_265, H265Settings * MPEG2, Mpeg2Settings
        /// * PRORES, ProresSettings * UNCOMPRESSED, UncompressedSettings * VC3, Vc3Settings *
        /// VP8, Vp8Settings * VP9, Vp9Settings * XAVC, XavcSettings
        /// </summary>
        public VideoCodecSettings CodecSettings { get; set; }

        /// <summary>
        /// Checks to see if the CodecSettings property is set.
        /// </summary>
        internal bool IsSetCodecSettings() => this.CodecSettings != null;

        /// <summary>
        /// Gets and sets the property ColorMetadata. Choose Insert for this setting to include
        /// color metadata in this output. Choose Ignore to exclude color metadata from this output.
        /// If you don't specify a value, the service sets this to Insert by default.
        /// </summary>
        public ColorMetadata ColorMetadata { get; set; }

        /// <summary>
        /// Checks to see if the ColorMetadata property is set.
        /// </summary>
        internal bool IsSetColorMetadata() => this.ColorMetadata != null;

        /// <summary>
        /// Gets and sets the property Crop. Use Cropping selection to specify the video area
        /// that the service will include in the output video frame.
        /// </summary>
        public Rectangle Crop { get; set; }

        /// <summary>
        /// Checks to see if the Crop property is set.
        /// </summary>
        internal bool IsSetCrop() => this.Crop != null;

        /// <summary>
        /// Gets and sets the property DropFrameTimecode. Applies only to 29.97 fps outputs. When
        /// this feature is enabled, the service will use drop-frame timecode on outputs. If it
        /// is not possible to use drop-frame timecode, the system will fall back to non-drop-frame.
        /// This setting is enabled by default when Timecode insertion or Timecode track is enabled.
        /// </summary>
        public DropFrameTimecode DropFrameTimecode { get; set; }

        /// <summary>
        /// Checks to see if the DropFrameTimecode property is set.
        /// </summary>
        internal bool IsSetDropFrameTimecode() => this.DropFrameTimecode != null;

        /// <summary>
        /// Gets and sets the property FixedAfd. Applies only if you set AFD Signaling to Fixed.
        /// Use Fixed to specify a four-bit AFD value which the service will write on all frames
        /// of this video output.
        /// </summary>
        [AWSProperty(Min = 0, Max = 15)]
        public int? FixedAfd { get; set; }

        /// <summary>
        /// Checks to see if the FixedAfd property is set.
        /// </summary>
        internal bool IsSetFixedAfd() => this.FixedAfd.HasValue;

        /// <summary>
        /// Gets and sets the property Height. Use Height to define the video resolution height,
        /// in pixels, for this output. To use the same resolution as your input: Leave both Width
        /// and Height blank. To evenly scale from your input resolution: Leave Height blank and
        /// enter a value for Width. For example, if your input is 1920x1080 and you set Width
        /// to 1280, your output will be 1280x720.
        /// </summary>
        [AWSProperty(Min = 32, Max = 8192)]
        public int? Height { get; set; }

        /// <summary>
        /// Checks to see if the Height property is set.
        /// </summary>
        internal bool IsSetHeight() => this.Height.HasValue;

        /// <summary>
        /// Gets and sets the property Position. Use Selection placement to define the video area
        /// in your output frame. The area outside of the rectangle that you specify here is black.
        /// </summary>
        public Rectangle Position { get; set; }

        /// <summary>
        /// Checks to see if the Position property is set.
        /// </summary>
        internal bool IsSetPosition() => this.Position != null;

        /// <summary>
        /// Gets and sets the property RespondToAfd. Use Respond to AFD to specify how the service
        /// changes the video itself in response to AFD values in the input. * Choose Respond
        /// to clip the input video frame according to the AFD value, input display aspect ratio,
        /// and output display aspect ratio. * Choose Passthrough to include the input AFD values.
        /// Do not choose this when AfdSignaling is set to NONE. A preferred implementation of
        /// this workflow is to set RespondToAfd to and set AfdSignaling to AUTO. * Choose None
        /// to remove all input AFD values from this output.
        /// </summary>
        public RespondToAfd RespondToAfd { get; set; }

        /// <summary>
        /// Checks to see if the RespondToAfd property is set.
        /// </summary>
        internal bool IsSetRespondToAfd() => this.RespondToAfd != null;

        /// <summary>
        /// Gets and sets the property ScalingBehavior. Specify the video Scaling behavior when
        /// your output has a different resolution than your input. For more information, see
        /// https://docs.aws.amazon.com/mediaconvert/latest/ug/video-scaling.html Select Smart
        /// Cropping using Elemental Inference as your scaling behavior to have Elemental Inference
        /// automatically crop your video. Smart Crop requires a vertical output aspect ratio
        /// (1:1 is the widest aspect ratio supported).
        /// </summary>
        public ScalingBehavior ScalingBehavior { get; set; }

        /// <summary>
        /// Checks to see if the ScalingBehavior property is set.
        /// </summary>
        internal bool IsSetScalingBehavior() => this.ScalingBehavior != null;

        /// <summary>
        /// Gets and sets the property Sharpness. Use Sharpness setting to specify the strength
        /// of anti-aliasing. This setting changes the width of the anti-alias filter kernel used
        /// for scaling. Sharpness only applies if your output resolution is different from your
        /// input resolution. 0 is the softest setting, 100 the sharpest, and 50 recommended for
        /// most content.
        /// </summary>
        [AWSProperty(Min = 0, Max = 100)]
        public int? Sharpness { get; set; }

        /// <summary>
        /// Checks to see if the Sharpness property is set.
        /// </summary>
        internal bool IsSetSharpness() => this.Sharpness.HasValue;

        /// <summary>
        /// Gets and sets the property TimecodeInsertion. Applies only to H.264, H.265, MPEG2,
        /// and ProRes outputs. Only enable Timecode insertion when the input frame rate is identical
        /// to the output frame rate. To include timecodes in this output, set Timecode insertion
        /// to PIC_TIMING_SEI. To leave them out, set it to DISABLED. Default is DISABLED. When
        /// the service inserts timecodes in an output, by default, it uses any embedded timecodes
        /// from the input. If none are present, the service will set the timecode for the first
        /// output frame to zero. To change this default behavior, adjust the settings under Timecode
        /// configuration. In the console, these settings are located under Job > Job settings
        /// > Timecode configuration. Note - Timecode source under input settings does not affect
        /// the timecodes that are inserted in the output. Source under Job settings > Timecode
        /// configuration does.
        /// </summary>
        public VideoTimecodeInsertion TimecodeInsertion { get; set; }

        /// <summary>
        /// Checks to see if the TimecodeInsertion property is set.
        /// </summary>
        internal bool IsSetTimecodeInsertion() => this.TimecodeInsertion != null;

        /// <summary>
        /// Gets and sets the property TimecodeTrack. To include a timecode track in your MP4
        /// output: Choose Enabled. MediaConvert writes the timecode track in the Null Media Header
        /// box (NMHD), without any timecode text formatting information. You can also specify
        /// dropframe or non-dropframe timecode under the Drop Frame Timecode setting. To not
        /// include a timecode track: Keep the default value, Disabled.
        /// </summary>
        public TimecodeTrack TimecodeTrack { get; set; }

        /// <summary>
        /// Checks to see if the TimecodeTrack property is set.
        /// </summary>
        internal bool IsSetTimecodeTrack() => this.TimecodeTrack != null;

        /// <summary>
        /// Gets and sets the property VideoPreprocessors. Find additional transcoding features
        /// under Preprocessors. Enable the features at each output individually. These features
        /// are disabled by default.
        /// </summary>
        public VideoPreprocessor VideoPreprocessors { get; set; }

        /// <summary>
        /// Checks to see if the VideoPreprocessors property is set.
        /// </summary>
        internal bool IsSetVideoPreprocessors() => this.VideoPreprocessors != null;

        /// <summary>
        /// Gets and sets the property Width. Use Width to define the video resolution width,
        /// in pixels, for this output. To use the same resolution as your input: Leave both Width
        /// and Height blank. To evenly scale from your input resolution: Leave Width blank and
        /// enter a value for Height. For example, if your input is 1920x1080 and you set Height
        /// to 720, your output will be 1280x720.
        /// </summary>
        [AWSProperty(Min = 32, Max = 8192)]
        public int? Width { get; set; }

        /// <summary>
        /// Checks to see if the Width property is set.
        /// </summary>
        internal bool IsSetWidth() => this.Width.HasValue;
    }
}
