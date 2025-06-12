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
 * Do not modify this file. This file is generated from the elastictranscoder-2012-09-25.normal.json service model.
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
namespace Amazon.ElasticTranscoder.Model
{
    /// <summary>
    /// The <c>VideoParameters</c> structure.
    /// </summary>
    public partial class VideoParameters
    {
        private string _aspectRatio;
        private string _bitRate;
        private string _codec;
        private Dictionary<string, string> _codecOptions = AWSConfigs.InitializeCollections ? new Dictionary<string, string>() : null;
        private string _displayAspectRatio;
        private string _fixedGOP;
        private string _frameRate;
        private string _keyframesMaxDist;
        private string _maxFrameRate;
        private string _maxHeight;
        private string _maxWidth;
        private string _paddingPolicy;
        private string _resolution;
        private string _sizingPolicy;
        private List<PresetWatermark> _watermarks = AWSConfigs.InitializeCollections ? new List<PresetWatermark>() : null;

        /// <summary>
        /// Gets and sets the property AspectRatio. <important> 
        /// <para>
        /// To better control resolution and aspect ratio of output videos, we recommend that
        /// you use the values <c>MaxWidth</c>, <c>MaxHeight</c>, <c>SizingPolicy</c>, <c>PaddingPolicy</c>,
        /// and <c>DisplayAspectRatio</c> instead of <c>Resolution</c> and <c>AspectRatio</c>.
        /// The two groups of settings are mutually exclusive. Do not use them together.
        /// </para>
        ///  </important> 
        /// <para>
        /// The display aspect ratio of the video in the output file. Valid values include:
        /// </para>
        ///  
        /// <para>
        ///  <c>auto</c>, <c>1:1</c>, <c>4:3</c>, <c>3:2</c>, <c>16:9</c> 
        /// </para>
        ///  
        /// <para>
        /// If you specify <c>auto</c>, Elastic Transcoder tries to preserve the aspect ratio
        /// of the input file.
        /// </para>
        ///  
        /// <para>
        /// If you specify an aspect ratio for the output file that differs from aspect ratio
        /// of the input file, Elastic Transcoder adds pillarboxing (black bars on the sides)
        /// or letterboxing (black bars on the top and bottom) to maintain the aspect ratio of
        /// the active region of the video.
        /// </para>
        /// </summary>
        public string AspectRatio
        {
            get { return this._aspectRatio; }
            set { this._aspectRatio = value; }
        }

        // Check to see if AspectRatio property is set
        internal bool IsSetAspectRatio()
        {
            return this._aspectRatio != null;
        }

        /// <summary>
        /// Gets and sets the property BitRate. 
        /// <para>
        /// The bit rate of the video stream in the output file, in kilobits/second. Valid values
        /// depend on the values of <c>Level</c> and <c>Profile</c>. If you specify <c>auto</c>,
        /// Elastic Transcoder uses the detected bit rate of the input source. If you specify
        /// a value other than <c>auto</c>, we recommend that you specify a value less than or
        /// equal to the maximum H.264-compliant value listed for your level and profile:
        /// </para>
        ///  
        /// <para>
        ///  <i>Level - Maximum video bit rate in kilobits/second (baseline and main Profile)
        /// : maximum video bit rate in kilobits/second (high Profile)</i> 
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// 1 - 64 : 80
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// 1b - 128 : 160
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// 1.1 - 192 : 240
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// 1.2 - 384 : 480
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// 1.3 - 768 : 960
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// 2 - 2000 : 2500
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// 3 - 10000 : 12500
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// 3.1 - 14000 : 17500
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// 3.2 - 20000 : 25000
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// 4 - 20000 : 25000
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// 4.1 - 50000 : 62500
        /// </para>
        ///  </li> </ul>
        /// </summary>
        public string BitRate
        {
            get { return this._bitRate; }
            set { this._bitRate = value; }
        }

        // Check to see if BitRate property is set
        internal bool IsSetBitRate()
        {
            return this._bitRate != null;
        }

        /// <summary>
        /// Gets and sets the property Codec. 
        /// <para>
        /// The video codec for the output file. Valid values include <c>gif</c>, <c>H.264</c>,
        /// <c>mpeg2</c>, <c>vp8</c>, and <c>vp9</c>. You can only specify <c>vp8</c> and <c>vp9</c>
        /// when the container type is <c>webm</c>, <c>gif</c> when the container type is <c>gif</c>,
        /// and <c>mpeg2</c> when the container type is <c>mpg</c>.
        /// </para>
        /// </summary>
        public string Codec
        {
            get { return this._codec; }
            set { this._codec = value; }
        }

        // Check to see if Codec property is set
        internal bool IsSetCodec()
        {
            return this._codec != null;
        }

        /// <summary>
        /// Gets and sets the property CodecOptions. 
        /// <para>
        ///  <b>Profile (H.264/VP8/VP9 Only)</b> 
        /// </para>
        ///  
        /// <para>
        /// The H.264 profile that you want to use for the output file. Elastic Transcoder supports
        /// the following profiles:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <c>baseline</c>: The profile most commonly used for videoconferencing and for mobile
        /// applications.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>main</c>: The profile used for standard-definition digital TV broadcasts.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>high</c>: The profile used for high-definition digital TV broadcasts and for Blu-ray
        /// discs.
        /// </para>
        ///  </li> </ul> 
        /// <para>
        ///  <b>Level (H.264 Only)</b> 
        /// </para>
        ///  
        /// <para>
        /// The H.264 level that you want to use for the output file. Elastic Transcoder supports
        /// the following levels:
        /// </para>
        ///  
        /// <para>
        ///  <c>1</c>, <c>1b</c>, <c>1.1</c>, <c>1.2</c>, <c>1.3</c>, <c>2</c>, <c>2.1</c>, <c>2.2</c>,
        /// <c>3</c>, <c>3.1</c>, <c>3.2</c>, <c>4</c>, <c>4.1</c> 
        /// </para>
        ///  
        /// <para>
        ///  <b>MaxReferenceFrames (H.264 Only)</b> 
        /// </para>
        ///  
        /// <para>
        /// Applicable only when the value of Video:Codec is H.264. The maximum number of previously
        /// decoded frames to use as a reference for decoding future frames. Valid values are
        /// integers 0 through 16, but we recommend that you not use a value greater than the
        /// following:
        /// </para>
        ///  
        /// <para>
        ///  <c>Min(Floor(Maximum decoded picture buffer in macroblocks * 256 / (Width in pixels
        /// * Height in pixels)), 16)</c> 
        /// </para>
        ///  
        /// <para>
        /// where <i>Width in pixels</i> and <i>Height in pixels</i> represent either MaxWidth
        /// and MaxHeight, or Resolution. <i>Maximum decoded picture buffer in macroblocks</i>
        /// depends on the value of the <c>Level</c> object. See the list below. (A macroblock
        /// is a block of pixels measuring 16x16.) 
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// 1 - 396
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// 1b - 396
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// 1.1 - 900
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// 1.2 - 2376
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// 1.3 - 2376
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// 2 - 2376
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// 2.1 - 4752
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// 2.2 - 8100
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// 3 - 8100
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// 3.1 - 18000
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// 3.2 - 20480
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// 4 - 32768
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// 4.1 - 32768
        /// </para>
        ///  </li> </ul> 
        /// <para>
        ///  <b>MaxBitRate (Optional, H.264/MPEG2/VP8/VP9 only)</b> 
        /// </para>
        ///  
        /// <para>
        /// The maximum number of bits per second in a video buffer; the size of the buffer is
        /// specified by <c>BufferSize</c>. Specify a value between 16 and 62,500. You can reduce
        /// the bandwidth required to stream a video by reducing the maximum bit rate, but this
        /// also reduces the quality of the video.
        /// </para>
        ///  
        /// <para>
        ///  <b>BufferSize (Optional, H.264/MPEG2/VP8/VP9 only)</b> 
        /// </para>
        ///  
        /// <para>
        /// The maximum number of bits in any x seconds of the output video. This window is commonly
        /// 10 seconds, the standard segment duration when you're using FMP4 or MPEG-TS for the
        /// container type of the output video. Specify an integer greater than 0. If you specify
        /// <c>MaxBitRate</c> and omit <c>BufferSize</c>, Elastic Transcoder sets <c>BufferSize</c>
        /// to 10 times the value of <c>MaxBitRate</c>.
        /// </para>
        ///  
        /// <para>
        ///  <b>InterlacedMode (Optional, H.264/MPEG2 Only)</b> 
        /// </para>
        ///  
        /// <para>
        /// The interlace mode for the output video.
        /// </para>
        ///  
        /// <para>
        /// Interlaced video is used to double the perceived frame rate for a video by interlacing
        /// two fields (one field on every other line, the other field on the other lines) so
        /// that the human eye registers multiple pictures per frame. Interlacing reduces the
        /// bandwidth required for transmitting a video, but can result in blurred images and
        /// flickering.
        /// </para>
        ///  
        /// <para>
        /// Valid values include <c>Progressive</c> (no interlacing, top to bottom), <c>TopFirst</c>
        /// (top field first), <c>BottomFirst</c> (bottom field first), and <c>Auto</c>.
        /// </para>
        ///  
        /// <para>
        /// If <c>InterlaceMode</c> is not specified, Elastic Transcoder uses <c>Progressive</c>
        /// for the output. If <c>Auto</c> is specified, Elastic Transcoder interlaces the output.
        /// </para>
        ///  
        /// <para>
        ///  <b>ColorSpaceConversionMode (Optional, H.264/MPEG2 Only)</b> 
        /// </para>
        ///  
        /// <para>
        /// The color space conversion Elastic Transcoder applies to the output video. Color spaces
        /// are the algorithms used by the computer to store information about how to render color.
        /// <c>Bt.601</c> is the standard for standard definition video, while <c>Bt.709</c> is
        /// the standard for high definition video.
        /// </para>
        ///  
        /// <para>
        /// Valid values include <c>None</c>, <c>Bt709toBt601</c>, <c>Bt601toBt709</c>, and <c>Auto</c>.
        /// </para>
        ///  
        /// <para>
        /// If you chose <c>Auto</c> for <c>ColorSpaceConversionMode</c> and your output is interlaced,
        /// your frame rate is one of <c>23.97</c>, <c>24</c>, <c>25</c>, <c>29.97</c>, <c>50</c>,
        /// or <c>60</c>, your <c>SegmentDuration</c> is null, and you are using one of the resolution
        /// changes from the list below, Elastic Transcoder applies the following color space
        /// conversions:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <i>Standard to HD, 720x480 to 1920x1080</i> - Elastic Transcoder applies <c>Bt601ToBt709</c>
        /// 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <i>Standard to HD, 720x576 to 1920x1080</i> - Elastic Transcoder applies <c>Bt601ToBt709</c>
        /// 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <i>HD to Standard, 1920x1080 to 720x480</i> - Elastic Transcoder applies <c>Bt709ToBt601</c>
        /// 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <i>HD to Standard, 1920x1080 to 720x576</i> - Elastic Transcoder applies <c>Bt709ToBt601</c>
        /// 
        /// </para>
        ///  </li> </ul> <note> 
        /// <para>
        /// Elastic Transcoder may change the behavior of the <c>ColorspaceConversionMode</c>
        /// <c>Auto</c> mode in the future. All outputs in a playlist must use the same <c>ColorSpaceConversionMode</c>.
        /// </para>
        ///  </note> 
        /// <para>
        /// If you do not specify a <c>ColorSpaceConversionMode</c>, Elastic Transcoder does not
        /// change the color space of a file. If you are unsure what <c>ColorSpaceConversionMode</c>
        /// was applied to your output file, you can check the <c>AppliedColorSpaceConversion</c>
        /// parameter included in your job response. If your job does not have an <c>AppliedColorSpaceConversion</c>
        /// in its response, no <c>ColorSpaceConversionMode</c> was applied.
        /// </para>
        ///  
        /// <para>
        ///  <b>ChromaSubsampling</b> 
        /// </para>
        ///  
        /// <para>
        /// The sampling pattern for the chroma (color) channels of the output video. Valid values
        /// include <c>yuv420p</c> and <c>yuv422p</c>.
        /// </para>
        ///  
        /// <para>
        ///  <c>yuv420p</c> samples the chroma information of every other horizontal and every
        /// other vertical line, <c>yuv422p</c> samples the color information of every horizontal
        /// line and every other vertical line.
        /// </para>
        ///  
        /// <para>
        ///  <b>LoopCount (Gif Only)</b> 
        /// </para>
        ///  
        /// <para>
        /// The number of times you want the output gif to loop. Valid values include <c>Infinite</c>
        /// and integers between <c>0</c> and <c>100</c>, inclusive.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Max=30)]
        public Dictionary<string, string> CodecOptions
        {
            get { return this._codecOptions; }
            set { this._codecOptions = value; }
        }

        // Check to see if CodecOptions property is set
        internal bool IsSetCodecOptions()
        {
            return this._codecOptions != null && (this._codecOptions.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property DisplayAspectRatio. 
        /// <para>
        /// The value that Elastic Transcoder adds to the metadata in the output file.
        /// </para>
        /// </summary>
        public string DisplayAspectRatio
        {
            get { return this._displayAspectRatio; }
            set { this._displayAspectRatio = value; }
        }

        // Check to see if DisplayAspectRatio property is set
        internal bool IsSetDisplayAspectRatio()
        {
            return this._displayAspectRatio != null;
        }

        /// <summary>
        /// Gets and sets the property FixedGOP. 
        /// <para>
        /// Applicable only when the value of Video:Codec is one of <c>H.264</c>, <c>MPEG2</c>,
        /// or <c>VP8</c>.
        /// </para>
        ///  
        /// <para>
        /// Whether to use a fixed value for <c>FixedGOP</c>. Valid values are <c>true</c> and
        /// <c>false</c>:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <c>true</c>: Elastic Transcoder uses the value of <c>KeyframesMaxDist</c> for the
        /// distance between key frames (the number of frames in a group of pictures, or GOP).
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>false</c>: The distance between key frames can vary.
        /// </para>
        ///  </li> </ul> <important> 
        /// <para>
        ///  <c>FixedGOP</c> must be set to <c>true</c> for <c>fmp4</c> containers.
        /// </para>
        ///  </important>
        /// </summary>
        public string FixedGOP
        {
            get { return this._fixedGOP; }
            set { this._fixedGOP = value; }
        }

        // Check to see if FixedGOP property is set
        internal bool IsSetFixedGOP()
        {
            return this._fixedGOP != null;
        }

        /// <summary>
        /// Gets and sets the property FrameRate. 
        /// <para>
        /// The frames per second for the video stream in the output file. Valid values include:
        /// </para>
        ///  
        /// <para>
        ///  <c>auto</c>, <c>10</c>, <c>15</c>, <c>23.97</c>, <c>24</c>, <c>25</c>, <c>29.97</c>,
        /// <c>30</c>, <c>60</c> 
        /// </para>
        ///  
        /// <para>
        /// If you specify <c>auto</c>, Elastic Transcoder uses the detected frame rate of the
        /// input source. If you specify a frame rate, we recommend that you perform the following
        /// calculation:
        /// </para>
        ///  
        /// <para>
        ///  <c>Frame rate = maximum recommended decoding speed in luma samples/second / (width
        /// in pixels * height in pixels)</c> 
        /// </para>
        ///  
        /// <para>
        /// where:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <i>width in pixels</i> and <i>height in pixels</i> represent the Resolution of the
        /// output video.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <i>maximum recommended decoding speed in Luma samples/second</i> is less than or
        /// equal to the maximum value listed in the following table, based on the value that
        /// you specified for Level.
        /// </para>
        ///  </li> </ul> 
        /// <para>
        /// The maximum recommended decoding speed in Luma samples/second for each level is described
        /// in the following list (<i>Level - Decoding speed</i>):
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// 1 - 380160
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// 1b - 380160
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// 1.1 - 76800
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// 1.2 - 1536000
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// 1.3 - 3041280
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// 2 - 3041280
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// 2.1 - 5068800
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// 2.2 - 5184000
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// 3 - 10368000
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// 3.1 - 27648000
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// 3.2 - 55296000
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// 4 - 62914560
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// 4.1 - 62914560
        /// </para>
        ///  </li> </ul>
        /// </summary>
        public string FrameRate
        {
            get { return this._frameRate; }
            set { this._frameRate = value; }
        }

        // Check to see if FrameRate property is set
        internal bool IsSetFrameRate()
        {
            return this._frameRate != null;
        }

        /// <summary>
        /// Gets and sets the property KeyframesMaxDist. 
        /// <para>
        /// Applicable only when the value of Video:Codec is one of <c>H.264</c>, <c>MPEG2</c>,
        /// or <c>VP8</c>.
        /// </para>
        ///  
        /// <para>
        /// The maximum number of frames between key frames. Key frames are fully encoded frames;
        /// the frames between key frames are encoded based, in part, on the content of the key
        /// frames. The value is an integer formatted as a string; valid values are between 1
        /// (every frame is a key frame) and 100000, inclusive. A higher value results in higher
        /// compression but may also discernibly decrease video quality.
        /// </para>
        ///  
        /// <para>
        /// For <c>Smooth</c> outputs, the <c>FrameRate</c> must have a constant ratio to the
        /// <c>KeyframesMaxDist</c>. This allows <c>Smooth</c> playlists to switch between different
        /// quality levels while the file is being played.
        /// </para>
        ///  
        /// <para>
        /// For example, an input file can have a <c>FrameRate</c> of 30 with a <c>KeyframesMaxDist</c>
        /// of 90. The output file then needs to have a ratio of 1:3. Valid outputs would have
        /// <c>FrameRate</c> of 30, 25, and 10, and <c>KeyframesMaxDist</c> of 90, 75, and 30,
        /// respectively.
        /// </para>
        ///  
        /// <para>
        /// Alternately, this can be achieved by setting <c>FrameRate</c> to auto and having the
        /// same values for <c>MaxFrameRate</c> and <c>KeyframesMaxDist</c>.
        /// </para>
        /// </summary>
        public string KeyframesMaxDist
        {
            get { return this._keyframesMaxDist; }
            set { this._keyframesMaxDist = value; }
        }

        // Check to see if KeyframesMaxDist property is set
        internal bool IsSetKeyframesMaxDist()
        {
            return this._keyframesMaxDist != null;
        }

        /// <summary>
        /// Gets and sets the property MaxFrameRate. 
        /// <para>
        /// If you specify <c>auto</c> for <c>FrameRate</c>, Elastic Transcoder uses the frame
        /// rate of the input video for the frame rate of the output video. Specify the maximum
        /// frame rate that you want Elastic Transcoder to use when the frame rate of the input
        /// video is greater than the desired maximum frame rate of the output video. Valid values
        /// include: <c>10</c>, <c>15</c>, <c>23.97</c>, <c>24</c>, <c>25</c>, <c>29.97</c>, <c>30</c>,
        /// <c>60</c>.
        /// </para>
        /// </summary>
        public string MaxFrameRate
        {
            get { return this._maxFrameRate; }
            set { this._maxFrameRate = value; }
        }

        // Check to see if MaxFrameRate property is set
        internal bool IsSetMaxFrameRate()
        {
            return this._maxFrameRate != null;
        }

        /// <summary>
        /// Gets and sets the property MaxHeight. 
        /// <para>
        /// The maximum height of the output video in pixels. If you specify <c>auto</c>, Elastic
        /// Transcoder uses 1080 (Full HD) as the default value. If you specify a numeric value,
        /// enter an even integer between 96 and 3072.
        /// </para>
        /// </summary>
        public string MaxHeight
        {
            get { return this._maxHeight; }
            set { this._maxHeight = value; }
        }

        // Check to see if MaxHeight property is set
        internal bool IsSetMaxHeight()
        {
            return this._maxHeight != null;
        }

        /// <summary>
        /// Gets and sets the property MaxWidth. 
        /// <para>
        ///  The maximum width of the output video in pixels. If you specify <c>auto</c>, Elastic
        /// Transcoder uses 1920 (Full HD) as the default value. If you specify a numeric value,
        /// enter an even integer between 128 and 4096. 
        /// </para>
        /// </summary>
        public string MaxWidth
        {
            get { return this._maxWidth; }
            set { this._maxWidth = value; }
        }

        // Check to see if MaxWidth property is set
        internal bool IsSetMaxWidth()
        {
            return this._maxWidth != null;
        }

        /// <summary>
        /// Gets and sets the property PaddingPolicy. 
        /// <para>
        /// When you set <c>PaddingPolicy</c> to <c>Pad</c>, Elastic Transcoder may add black
        /// bars to the top and bottom and/or left and right sides of the output video to make
        /// the total size of the output video match the values that you specified for <c>MaxWidth</c>
        /// and <c>MaxHeight</c>.
        /// </para>
        /// </summary>
        public string PaddingPolicy
        {
            get { return this._paddingPolicy; }
            set { this._paddingPolicy = value; }
        }

        // Check to see if PaddingPolicy property is set
        internal bool IsSetPaddingPolicy()
        {
            return this._paddingPolicy != null;
        }

        /// <summary>
        /// Gets and sets the property Resolution. <important> 
        /// <para>
        /// To better control resolution and aspect ratio of output videos, we recommend that
        /// you use the values <c>MaxWidth</c>, <c>MaxHeight</c>, <c>SizingPolicy</c>, <c>PaddingPolicy</c>,
        /// and <c>DisplayAspectRatio</c> instead of <c>Resolution</c> and <c>AspectRatio</c>.
        /// The two groups of settings are mutually exclusive. Do not use them together.
        /// </para>
        ///  </important> 
        /// <para>
        /// The width and height of the video in the output file, in pixels. Valid values are
        /// <c>auto</c> and <i>width</i> x <i>height</i>:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <c>auto</c>: Elastic Transcoder attempts to preserve the width and height of the
        /// input file, subject to the following rules.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c> <i>width</i> x <i>height</i> </c>: The width and height of the output video in
        /// pixels.
        /// </para>
        ///  </li> </ul> 
        /// <para>
        /// Note the following about specifying the width and height:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// The width must be an even integer between 128 and 4096, inclusive.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// The height must be an even integer between 96 and 3072, inclusive.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// If you specify a resolution that is less than the resolution of the input file, Elastic
        /// Transcoder rescales the output file to the lower resolution.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// If you specify a resolution that is greater than the resolution of the input file,
        /// Elastic Transcoder rescales the output to the higher resolution.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// We recommend that you specify a resolution for which the product of width and height
        /// is less than or equal to the applicable value in the following list (<i>List - Max
        /// width x height value</i>):
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// 1 - 25344
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// 1b - 25344
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// 1.1 - 101376
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// 1.2 - 101376
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// 1.3 - 101376
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// 2 - 101376
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// 2.1 - 202752
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// 2.2 - 404720
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// 3 - 404720
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// 3.1 - 921600
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// 3.2 - 1310720
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// 4 - 2097152
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// 4.1 - 2097152
        /// </para>
        ///  </li> </ul> </li> </ul>
        /// </summary>
        public string Resolution
        {
            get { return this._resolution; }
            set { this._resolution = value; }
        }

        // Check to see if Resolution property is set
        internal bool IsSetResolution()
        {
            return this._resolution != null;
        }

        /// <summary>
        /// Gets and sets the property SizingPolicy. 
        /// <para>
        /// Specify one of the following values to control scaling of the output video:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <c>Fit</c>: Elastic Transcoder scales the output video so it matches the value that
        /// you specified in either <c>MaxWidth</c> or <c>MaxHeight</c> without exceeding the
        /// other value.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>Fill</c>: Elastic Transcoder scales the output video so it matches the value that
        /// you specified in either <c>MaxWidth</c> or <c>MaxHeight</c> and matches or exceeds
        /// the other value. Elastic Transcoder centers the output video and then crops it in
        /// the dimension (if any) that exceeds the maximum value.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>Stretch</c>: Elastic Transcoder stretches the output video to match the values
        /// that you specified for <c>MaxWidth</c> and <c>MaxHeight</c>. If the relative proportions
        /// of the input video and the output video are different, the output video will be distorted.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>Keep</c>: Elastic Transcoder does not scale the output video. If either dimension
        /// of the input video exceeds the values that you specified for <c>MaxWidth</c> and <c>MaxHeight</c>,
        /// Elastic Transcoder crops the output video.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>ShrinkToFit</c>: Elastic Transcoder scales the output video down so that its dimensions
        /// match the values that you specified for at least one of <c>MaxWidth</c> and <c>MaxHeight</c>
        /// without exceeding either value. If you specify this option, Elastic Transcoder does
        /// not scale the video up.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>ShrinkToFill</c>: Elastic Transcoder scales the output video down so that its
        /// dimensions match the values that you specified for at least one of <c>MaxWidth</c>
        /// and <c>MaxHeight</c> without dropping below either value. If you specify this option,
        /// Elastic Transcoder does not scale the video up.
        /// </para>
        ///  </li> </ul>
        /// </summary>
        public string SizingPolicy
        {
            get { return this._sizingPolicy; }
            set { this._sizingPolicy = value; }
        }

        // Check to see if SizingPolicy property is set
        internal bool IsSetSizingPolicy()
        {
            return this._sizingPolicy != null;
        }

        /// <summary>
        /// Gets and sets the property Watermarks. 
        /// <para>
        /// Settings for the size, location, and opacity of graphics that you want Elastic Transcoder
        /// to overlay over videos that are transcoded using this preset. You can specify settings
        /// for up to four watermarks. Watermarks appear in the specified size and location, and
        /// with the specified opacity for the duration of the transcoded video.
        /// </para>
        ///  
        /// <para>
        /// Watermarks can be in .png or .jpg format. If you want to display a watermark that
        /// is not rectangular, use the .png format, which supports transparency.
        /// </para>
        ///  
        /// <para>
        /// When you create a job that uses this preset, you specify the .png or .jpg graphics
        /// that you want Elastic Transcoder to include in the transcoded videos. You can specify
        /// fewer graphics in the job than you specify watermark settings in the preset, which
        /// allows you to use the same preset for up to four watermarks that have different dimensions.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<PresetWatermark> Watermarks
        {
            get { return this._watermarks; }
            set { this._watermarks = value; }
        }

        // Check to see if Watermarks property is set
        internal bool IsSetWatermarks()
        {
            return this._watermarks != null && (this._watermarks.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

    }
}