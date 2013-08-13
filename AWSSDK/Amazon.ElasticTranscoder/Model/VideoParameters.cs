/*
 * Copyright 2010-2013 Amazon.com, Inc. or its affiliates. All Rights Reserved.
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
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;

namespace Amazon.ElasticTranscoder.Model
{
    /// <summary>
    /// 
    /// </summary>
    public class VideoParameters
    {
        
        private string codec;
        private Dictionary<string,string> codecOptions = new Dictionary<string,string>();
        private string keyframesMaxDist;
        private string fixedGOP;
        private string bitRate;
        private string frameRate;
        private string maxFrameRate;
        private string resolution;
        private string aspectRatio;
        private string maxWidth;
        private string maxHeight;
        private string displayAspectRatio;
        private string sizingPolicy;
        private string paddingPolicy;
        private List<PresetWatermark> watermarks = new List<PresetWatermark>();

        /// <summary>
        /// The video codec for the output file. Valid values include <c>H.264</c> and <c>vp8</c>. You can only specify <c>vp8</c> when the container
        /// type is <c>webm</c>.
        ///  
        /// <para>
        /// <b>Constraints:</b>
        /// <list type="definition">
        ///     <item>
        ///         <term>Pattern</term>
        ///         <description>(^H\.264$)|(^vp8$)</description>
        ///     </item>
        /// </list>
        /// </para>
        /// </summary>
        public string Codec
        {
            get { return this.codec; }
            set { this.codec = value; }
        }

        /// <summary>
        /// Sets the Codec property
        /// </summary>
        /// <param name="codec">The value to set for the Codec property </param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public VideoParameters WithCodec(string codec)
        {
            this.codec = codec;
            return this;
        }
            

        // Check to see if Codec property is set
        internal bool IsSetCodec()
        {
            return this.codec != null;
        }

        /// <summary>
        /// <b>Profile</b> The H.264 profile that you want to use for the output file. Elastic Transcoder supports the following profiles: <ul>
        /// <li><c>baseline</c>: The profile most commonly used for videoconferencing and for mobile applications.</li> <li><c>main</c>: The profile
        /// used for standard-definition digital TV broadcasts.</li> <li><c>high</c>: The profile used for high-definition digital TV broadcasts and for
        /// Blu-ray discs.</li> </ul> <b>Level (H.264 Only)</b> The H.264 level that you want to use for the output file. Elastic Transcoder supports
        /// the following levels: <c>1</c>, <c>1b</c>, <c>1.1</c>, <c>1.2</c>, <c>1.3</c>, <c>2</c>, <c>2.1</c>, <c>2.2</c>, <c>3</c>, <c>3.1</c>,
        /// <c>3.2</c>, <c>4</c>, <c>4.1</c> <b>MaxReferenceFrames (H.264 Only)</b> Applicable only when the value of Video:Codec is H.264. The maximum
        /// number of previously decoded frames to use as a reference for decoding future frames. Valid values are integers 0 through 16, but we
        /// recommend that you not use a value greater than the following: <c>Min(Floor(Maximum decoded picture buffer in macroblocks * 256 / (Width in
        /// pixels * Height in pixels)), 16)</c> where <i>Width in pixels</i> and <i>Height in pixels</i> represent either MaxWidth and MaxHeight, or
        /// Resolution. <i>Maximum decoded picture buffer in macroblocks</i> depends on the value of the <c>Level</c> object. See the list below. (A
        /// macroblock is a block of pixels measuring 16x16.) <ul> <li>1 - 396</li> <li>1b - 396</li> <li>1.1 - 900</li> <li>1.2 - 2376</li> <li>1.3 -
        /// 2376</li> <li>2 - 2376</li> <li>2.1 - 4752</li> <li>2.2 - 8100</li> <li>3 - 8100</li> <li>3.1 - 18000</li> <li>3.2 - 20480</li> <li>4 -
        /// 32768</li> <li>4.1 - 32768</li> </ul> <b>MaxBitRate</b> The maximum number of bits per second in a video buffer; the size of the buffer is
        /// specified by <c>BufferSize</c>. Specify a value between 16 and 62,500. You can reduce the bandwidth required to stream a video by reducing
        /// the maximum bit rate, but this also reduces the quality of the video. <b>BufferSize</b> The maximum number of bits in any x seconds of the
        /// output video. This window is commonly 10 seconds, the standard segment duration when youâ€™re using MPEG-TS for the container type of the
        /// output video. Specify an integer greater than 0. If you specify <c>MaxBitRate</c> and omit <c>BufferSize</c>, Elastic Transcoder sets
        /// <c>BufferSize</c> to 10 times the value of <c>MaxBitRate</c>.
        ///  
        /// <para>
        /// <b>Constraints:</b>
        /// <list type="definition">
        ///     <item>
        ///         <term>Length</term>
        ///         <description>0 - 30</description>
        ///     </item>
        /// </list>
        /// </para>
        /// </summary>
        public Dictionary<string,string> CodecOptions
        {
            get { return this.codecOptions; }
            set { this.codecOptions = value; }
        }

        /// <summary>
        /// Adds the KeyValuePairs to the CodecOptions dictionary.
        /// </summary>
        /// <param name="pairs">The pairs to be added to the CodecOptions dictionary.</param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public VideoParameters WithCodecOptions(params KeyValuePair<string, string>[] pairs)
        {
            foreach (KeyValuePair<string, string> pair in pairs)
            {
                this.CodecOptions[pair.Key] = pair.Value;
            }

            return this;
        }

        // Check to see if CodecOptions property is set
        internal bool IsSetCodecOptions()
        {
            return this.codecOptions != null;
        }

        /// <summary>
        /// The maximum number of frames between key frames. Key frames are fully encoded frames; the frames between key frames are encoded based, in
        /// part, on the content of the key frames. The value is an integer formatted as a string; valid values are between 1 (every frame is a key
        /// frame) and 100000, inclusive. A higher value results in higher compression but may also discernibly decrease video quality.
        ///  
        /// <para>
        /// <b>Constraints:</b>
        /// <list type="definition">
        ///     <item>
        ///         <term>Pattern</term>
        ///         <description>^\d{1,6}$</description>
        ///     </item>
        /// </list>
        /// </para>
        /// </summary>
        public string KeyframesMaxDist
        {
            get { return this.keyframesMaxDist; }
            set { this.keyframesMaxDist = value; }
        }

        /// <summary>
        /// Sets the KeyframesMaxDist property
        /// </summary>
        /// <param name="keyframesMaxDist">The value to set for the KeyframesMaxDist property </param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public VideoParameters WithKeyframesMaxDist(string keyframesMaxDist)
        {
            this.keyframesMaxDist = keyframesMaxDist;
            return this;
        }
            

        // Check to see if KeyframesMaxDist property is set
        internal bool IsSetKeyframesMaxDist()
        {
            return this.keyframesMaxDist != null;
        }

        /// <summary>
        /// Whether to use a fixed value for <c>FixedGOP</c>. Valid values are <c>true</c> and <c>false</c>: <ul> <li><c>true</c>: Elastic Transcoder
        /// uses the value of <c>KeyframesMaxDist</c> for the distance between key frames (the number of frames in a group of pictures, or GOP).</li>
        /// <li><c>false</c>: The distance between key frames can vary.</li> </ul>
        ///  
        /// <para>
        /// <b>Constraints:</b>
        /// <list type="definition">
        ///     <item>
        ///         <term>Pattern</term>
        ///         <description>(^true$)|(^false$)</description>
        ///     </item>
        /// </list>
        /// </para>
        /// </summary>
        public string FixedGOP
        {
            get { return this.fixedGOP; }
            set { this.fixedGOP = value; }
        }

        /// <summary>
        /// Sets the FixedGOP property
        /// </summary>
        /// <param name="fixedGOP">The value to set for the FixedGOP property </param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public VideoParameters WithFixedGOP(string fixedGOP)
        {
            this.fixedGOP = fixedGOP;
            return this;
        }
            

        // Check to see if FixedGOP property is set
        internal bool IsSetFixedGOP()
        {
            return this.fixedGOP != null;
        }

        /// <summary>
        /// The bit rate of the video stream in the output file, in kilobits/second. Valid values depend on the values of <c>Level</c> and
        /// <c>Profile</c>. If you specify <c>auto</c>, Elastic Transcoder uses the detected bit rate of the input source. If you specify a value other
        /// than <c>auto</c>, we recommend that you specify a value less than or equal to the maximum H.264-compliant value listed for your level and
        /// profile: <i>Level - Maximum video bit rate in kilobits/second (baseline and main Profile) : maximum video bit rate in kilobits/second (high
        /// Profile)</i> <ul> <li>1 - 64 : 80</li> <li>1b - 128 : 160</li> <li>1.1 - 192 : 240</li> <li>1.2 - 384 : 480</li> <li>1.3 - 768 : 960</li>
        /// <li>2 - 2000 : 2500</li> <li>3 - 10000 : 12500</li> <li>3.1 - 14000 : 17500</li> <li>3.2 - 20000 : 25000</li> <li>4 - 20000 : 25000</li>
        /// <li>4.1 - 50000 : 62500</li> </ul>
        ///  
        /// <para>
        /// <b>Constraints:</b>
        /// <list type="definition">
        ///     <item>
        ///         <term>Pattern</term>
        ///         <description>(^\d{2,5}$)|(^auto$)</description>
        ///     </item>
        /// </list>
        /// </para>
        /// </summary>
        public string BitRate
        {
            get { return this.bitRate; }
            set { this.bitRate = value; }
        }

        /// <summary>
        /// Sets the BitRate property
        /// </summary>
        /// <param name="bitRate">The value to set for the BitRate property </param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public VideoParameters WithBitRate(string bitRate)
        {
            this.bitRate = bitRate;
            return this;
        }
            

        // Check to see if BitRate property is set
        internal bool IsSetBitRate()
        {
            return this.bitRate != null;
        }

        /// <summary>
        /// The frames per second for the video stream in the output file. Valid values include: <c>auto</c>, <c>10</c>, <c>15</c>, <c>23.97</c>,
        /// <c>24</c>, <c>25</c>, <c>29.97</c>, <c>30</c>, <c>60</c> If you specify <c>auto</c>, Elastic Transcoder uses the detected frame rate of the
        /// input source. If you specify a frame rate, we recommend that you perform the following calculation: <c>Frame rate = maximum recommended
        /// decoding speed in luma samples/second / (width in pixels * height in pixels)</c> where: <ul> <li><i>width in pixels</i> and <i>height in
        /// pixels</i> represent the Resolution of the output video.</li> <li><i>maximum recommended decoding speed in Luma samples/second</i> is less
        /// than or equal to the maximum value listed in the following table, based on the value that you specified for Level.</li> </ul> The maximum
        /// recommended decoding speed in Luma samples/second for each level is described in the following list (<i>Level - Decoding speed</i>): <ul>
        /// <li>1 - 380160</li> <li>1b - 380160</li> <li>1.1 - 76800</li> <li>1.2 - 1536000</li> <li>1.3 - 3041280</li> <li>2 - 3041280</li> <li>2.1 -
        /// 5068800</li> <li>2.2 - 5184000</li> <li>3 - 10368000</li> <li>3.1 - 27648000</li> <li>3.2 - 55296000</li> <li>4 - 62914560</li> <li>4.1 -
        /// 62914560</li> </ul>
        ///  
        /// <para>
        /// <b>Constraints:</b>
        /// <list type="definition">
        ///     <item>
        ///         <term>Pattern</term>
        ///         <description>(^auto$)|(^10$)|(^15$)|(^23.97$)|(^24$)|(^25$)|(^29.97$)|(^30$)|(^60$)</description>
        ///     </item>
        /// </list>
        /// </para>
        /// </summary>
        public string FrameRate
        {
            get { return this.frameRate; }
            set { this.frameRate = value; }
        }

        /// <summary>
        /// Sets the FrameRate property
        /// </summary>
        /// <param name="frameRate">The value to set for the FrameRate property </param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public VideoParameters WithFrameRate(string frameRate)
        {
            this.frameRate = frameRate;
            return this;
        }
            

        // Check to see if FrameRate property is set
        internal bool IsSetFrameRate()
        {
            return this.frameRate != null;
        }

        /// <summary>
        /// If you specify <c>auto</c> for <c>FrameRate</c>, Elastic Transcoder uses the frame rate of the input video for the frame rate of the output
        /// video. Specify the maximum frame rate that you want Elastic Transcoder to use when the frame rate of the input video is greater than the
        /// desired maximum frame rate of the output video. Valid values include: <c>10</c>, <c>15</c>, <c>23.97</c>, <c>24</c>, <c>25</c>,
        /// <c>29.97</c>, <c>30</c>, <c>60</c>.
        ///  
        /// <para>
        /// <b>Constraints:</b>
        /// <list type="definition">
        ///     <item>
        ///         <term>Pattern</term>
        ///         <description>(^10$)|(^15$)|(^23.97$)|(^24$)|(^25$)|(^29.97$)|(^30$)|(^60$)</description>
        ///     </item>
        /// </list>
        /// </para>
        /// </summary>
        public string MaxFrameRate
        {
            get { return this.maxFrameRate; }
            set { this.maxFrameRate = value; }
        }

        /// <summary>
        /// Sets the MaxFrameRate property
        /// </summary>
        /// <param name="maxFrameRate">The value to set for the MaxFrameRate property </param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public VideoParameters WithMaxFrameRate(string maxFrameRate)
        {
            this.maxFrameRate = maxFrameRate;
            return this;
        }
            

        // Check to see if MaxFrameRate property is set
        internal bool IsSetMaxFrameRate()
        {
            return this.maxFrameRate != null;
        }

        /// <summary>
        /// <important> To better control resolution and aspect ratio of output videos, we recommend that you use the values <c>MaxWidth</c>,
        /// <c>MaxHeight</c>, <c>SizingPolicy</c>, <c>PaddingPolicy</c>, and <c>DisplayAspectRatio</c> instead of <c>Resolution</c> and
        /// <c>AspectRatio</c>. The two groups of settings are mutually exclusive. Do not use them together. </important> The width and height of the
        /// video in the output file, in pixels. Valid values are <c>auto</c> and <i>width</i> x <i>height</i>: <ul> <li><c>auto</c>: Elastic Transcoder
        /// attempts to preserve the width and height of the input file, subject to the following rules.</li> <li><c><i>width</i> x <i>height</i></c>:
        /// The width and height of the output video in pixels.</li> </ul> Note the following about specifying the width and height: <ul> <li>The width
        /// must be an even integer between 128 and 4096, inclusive.</li> <li>The height must be an even integer between 96 and 3072, inclusive.</li>
        /// <li>If you specify a resolution that is less than the resolution of the input file, Elastic Transcoder rescales the output file to the lower
        /// resolution.</li> <li>If you specify a resolution that is greater than the resolution of the input file, Elastic Transcoder rescales the
        /// output to the higher resolution.</li> <li>We recommend that you specify a resolution for which the product of width and height is less than
        /// or equal to the applicable value in the following list (<i>List - Max width x height value</i>):</li> <ul> <li>1 - 25344</li> <li>1b -
        /// 25344</li> <li>1.1 - 101376</li> <li>1.2 - 101376</li> <li>1.3 - 101376</li> <li>2 - 101376</li> <li>2.1 - 202752</li> <li>2.2 - 404720</li>
        /// <li>3 - 404720</li> <li>3.1 - 921600</li> <li>3.2 - 1310720</li> <li>4 - 2097152</li> <li>4.1 - 2097152</li> </ul> </ul>
        ///  
        /// <para>
        /// <b>Constraints:</b>
        /// <list type="definition">
        ///     <item>
        ///         <term>Pattern</term>
        ///         <description>(^auto$)|(^\d{1,5}x\d{1,5}$)</description>
        ///     </item>
        /// </list>
        /// </para>
        /// </summary>
        public string Resolution
        {
            get { return this.resolution; }
            set { this.resolution = value; }
        }

        /// <summary>
        /// Sets the Resolution property
        /// </summary>
        /// <param name="resolution">The value to set for the Resolution property </param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public VideoParameters WithResolution(string resolution)
        {
            this.resolution = resolution;
            return this;
        }
            

        // Check to see if Resolution property is set
        internal bool IsSetResolution()
        {
            return this.resolution != null;
        }

        /// <summary>
        /// <important> To better control resolution and aspect ratio of output videos, we recommend that you use the values <c>MaxWidth</c>,
        /// <c>MaxHeight</c>, <c>SizingPolicy</c>, <c>PaddingPolicy</c>, and <c>DisplayAspectRatio</c> instead of <c>Resolution</c> and
        /// <c>AspectRatio</c>. The two groups of settings are mutually exclusive. Do not use them together. </important> The display aspect ratio of
        /// the video in the output file. Valid values include: <c>auto</c>, <c>1:1</c>, <c>4:3</c>, <c>3:2</c>, <c>16:9</c> If you specify <c>auto</c>,
        /// Elastic Transcoder tries to preserve the aspect ratio of the input file. If you specify an aspect ratio for the output file that differs
        /// from aspect ratio of the input file, Elastic Transcoder adds pillarboxing (black bars on the sides) or letterboxing (black bars on the top
        /// and bottom) to maintain the aspect ratio of the active region of the video.
        ///  
        /// <para>
        /// <b>Constraints:</b>
        /// <list type="definition">
        ///     <item>
        ///         <term>Pattern</term>
        ///         <description>(^auto$)|(^1:1$)|(^4:3$)|(^3:2$)|(^16:9$)</description>
        ///     </item>
        /// </list>
        /// </para>
        /// </summary>
        public string AspectRatio
        {
            get { return this.aspectRatio; }
            set { this.aspectRatio = value; }
        }

        /// <summary>
        /// Sets the AspectRatio property
        /// </summary>
        /// <param name="aspectRatio">The value to set for the AspectRatio property </param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public VideoParameters WithAspectRatio(string aspectRatio)
        {
            this.aspectRatio = aspectRatio;
            return this;
        }
            

        // Check to see if AspectRatio property is set
        internal bool IsSetAspectRatio()
        {
            return this.aspectRatio != null;
        }

        /// <summary>
        /// The maximum width of the output video in pixels. If you specify <c>auto</c>, Elastic Transcoder uses 1920 (Full HD) as the default value. If
        /// you specify a numeric value, enter an even integer between 128 and 4096.
        ///  
        /// <para>
        /// <b>Constraints:</b>
        /// <list type="definition">
        ///     <item>
        ///         <term>Pattern</term>
        ///         <description>(^auto$)|(^\d{2,4}$)</description>
        ///     </item>
        /// </list>
        /// </para>
        /// </summary>
        public string MaxWidth
        {
            get { return this.maxWidth; }
            set { this.maxWidth = value; }
        }

        /// <summary>
        /// Sets the MaxWidth property
        /// </summary>
        /// <param name="maxWidth">The value to set for the MaxWidth property </param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public VideoParameters WithMaxWidth(string maxWidth)
        {
            this.maxWidth = maxWidth;
            return this;
        }
            

        // Check to see if MaxWidth property is set
        internal bool IsSetMaxWidth()
        {
            return this.maxWidth != null;
        }

        /// <summary>
        /// The maximum height of the output video in pixels. If you specify <c>auto</c>, Elastic Transcoder uses 1080 (Full HD) as the default value.
        /// If you specify a numeric value, enter an even integer between 96 and 3072.
        ///  
        /// <para>
        /// <b>Constraints:</b>
        /// <list type="definition">
        ///     <item>
        ///         <term>Pattern</term>
        ///         <description>(^auto$)|(^\d{2,4}$)</description>
        ///     </item>
        /// </list>
        /// </para>
        /// </summary>
        public string MaxHeight
        {
            get { return this.maxHeight; }
            set { this.maxHeight = value; }
        }

        /// <summary>
        /// Sets the MaxHeight property
        /// </summary>
        /// <param name="maxHeight">The value to set for the MaxHeight property </param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public VideoParameters WithMaxHeight(string maxHeight)
        {
            this.maxHeight = maxHeight;
            return this;
        }
            

        // Check to see if MaxHeight property is set
        internal bool IsSetMaxHeight()
        {
            return this.maxHeight != null;
        }

        /// <summary>
        /// The value that Elastic Transcoder adds to the metadata in the output file.
        ///  
        /// <para>
        /// <b>Constraints:</b>
        /// <list type="definition">
        ///     <item>
        ///         <term>Pattern</term>
        ///         <description>(^auto$)|(^1:1$)|(^4:3$)|(^3:2$)|(^16:9$)</description>
        ///     </item>
        /// </list>
        /// </para>
        /// </summary>
        public string DisplayAspectRatio
        {
            get { return this.displayAspectRatio; }
            set { this.displayAspectRatio = value; }
        }

        /// <summary>
        /// Sets the DisplayAspectRatio property
        /// </summary>
        /// <param name="displayAspectRatio">The value to set for the DisplayAspectRatio property </param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public VideoParameters WithDisplayAspectRatio(string displayAspectRatio)
        {
            this.displayAspectRatio = displayAspectRatio;
            return this;
        }
            

        // Check to see if DisplayAspectRatio property is set
        internal bool IsSetDisplayAspectRatio()
        {
            return this.displayAspectRatio != null;
        }

        /// <summary>
        /// Specify one of the following values to control scaling of the output video: <ul> <li><c>Fit</c>: Elastic Transcoder scales the output video
        /// so it matches the value that you specified in either <c>MaxWidth</c> or <c>MaxHeight</c> without exceeding the other value.</li>
        /// <li><c>Fill</c>: Elastic Transcoder scales the output video so it matches the value that you specified in either <c>MaxWidth</c> or
        /// <c>MaxHeight</c> and matches or exceeds the other value. Elastic Transcoder centers the output video and then crops it in the dimension (if
        /// any) that exceeds the maximum value.</li> <li><c>Stretch</c>: Elastic Transcoder stretches the output video to match the values that you
        /// specified for <c>MaxWidth</c> and <c>MaxHeight</c>. If the relative proportions of the input video and the output video are different, the
        /// output video will be distorted.</li> <li><c>Keep</c>: Elastic Transcoder does not scale the output video. If either dimension of the input
        /// video exceeds the values that you specified for <c>MaxWidth</c> and <c>MaxHeight</c>, Elastic Transcoder crops the output video.</li>
        /// <li><c>ShrinkToFit</c>: Elastic Transcoder scales the output video down so that its dimensions match the values that you specified for at
        /// least one of <c>MaxWidth</c> and <c>MaxHeight</c> without exceeding either value. If you specify this option, Elastic Transcoder does not
        /// scale the video up.</li> <li><c>ShrinkToFill</c>: Elastic Transcoder scales the output video down so that its dimensions match the values
        /// that you specified for at least one of <c>MaxWidth</c> and <c>MaxHeight</c> without dropping below either value. If you specify this option,
        /// Elastic Transcoder does not scale the video up.</li> </ul>
        ///  
        /// <para>
        /// <b>Constraints:</b>
        /// <list type="definition">
        ///     <item>
        ///         <term>Pattern</term>
        ///         <description>(^Fit$)|(^Fill$)|(^Stretch$)|(^Keep$)|(^ShrinkToFit$)|(^ShrinkToFill$)</description>
        ///     </item>
        /// </list>
        /// </para>
        /// </summary>
        public string SizingPolicy
        {
            get { return this.sizingPolicy; }
            set { this.sizingPolicy = value; }
        }

        /// <summary>
        /// Sets the SizingPolicy property
        /// </summary>
        /// <param name="sizingPolicy">The value to set for the SizingPolicy property </param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public VideoParameters WithSizingPolicy(string sizingPolicy)
        {
            this.sizingPolicy = sizingPolicy;
            return this;
        }
            

        // Check to see if SizingPolicy property is set
        internal bool IsSetSizingPolicy()
        {
            return this.sizingPolicy != null;
        }

        /// <summary>
        /// When you set <c>PaddingPolicy</c> to <c>Pad</c>, Elastic Transcoder may add black bars to the top and bottom and/or left and right sides of
        /// the output video to make the total size of the output video match the values that you specified for <c>MaxWidth</c> and <c>MaxHeight</c>.
        ///  
        /// <para>
        /// <b>Constraints:</b>
        /// <list type="definition">
        ///     <item>
        ///         <term>Pattern</term>
        ///         <description>(^Pad$)|(^NoPad$)</description>
        ///     </item>
        /// </list>
        /// </para>
        /// </summary>
        public string PaddingPolicy
        {
            get { return this.paddingPolicy; }
            set { this.paddingPolicy = value; }
        }

        /// <summary>
        /// Sets the PaddingPolicy property
        /// </summary>
        /// <param name="paddingPolicy">The value to set for the PaddingPolicy property </param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public VideoParameters WithPaddingPolicy(string paddingPolicy)
        {
            this.paddingPolicy = paddingPolicy;
            return this;
        }
            

        // Check to see if PaddingPolicy property is set
        internal bool IsSetPaddingPolicy()
        {
            return this.paddingPolicy != null;
        }

        /// <summary>
        /// Settings for the size, location, and opacity of graphics that you want Elastic Transcoder to overlay over videos that are transcoded using
        /// this preset. You can specify settings for up to four watermarks. Watermarks appear in the specified size and location, and with the
        /// specified opacity for the duration of the transcoded video. Watermarks can be in .png or .jpg format. If you want to display a watermark
        /// that is not rectangular, use the .png format, which supports transparency. When you create a job that uses this preset, you specify the .png
        /// or .jpg graphics that you want Elastic Transcoder to include in the transcoded videos. You can specify fewer graphics in the job than you
        /// specify watermark settings in the preset, which allows you to use the same preset for up to four watermarks that have different dimensions.
        ///  
        /// </summary>
        public List<PresetWatermark> Watermarks
        {
            get { return this.watermarks; }
            set { this.watermarks = value; }
        }
        /// <summary>
        /// Adds elements to the Watermarks collection
        /// </summary>
        /// <param name="watermarks">The values to add to the Watermarks collection </param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public VideoParameters WithWatermarks(params PresetWatermark[] watermarks)
        {
            foreach (PresetWatermark element in watermarks)
            {
                this.watermarks.Add(element);
            }

            return this;
        }

        /// <summary>
        /// Adds elements to the Watermarks collection
        /// </summary>
        /// <param name="watermarks">The values to add to the Watermarks collection </param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public VideoParameters WithWatermarks(IEnumerable<PresetWatermark> watermarks)
        {
            foreach (PresetWatermark element in watermarks)
            {
                this.watermarks.Add(element);
            }

            return this;
        }

        // Check to see if Watermarks property is set
        internal bool IsSetWatermarks()
        {
            return this.watermarks.Count > 0;
        }
    }
}
