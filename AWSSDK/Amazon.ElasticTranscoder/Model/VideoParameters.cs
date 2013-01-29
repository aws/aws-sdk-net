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
        private string resolution;
        private string aspectRatio;

        /// <summary>
        /// The video codec for the output file. This value must be <c>H.264</c>.
        ///  
        /// <para>
        /// <b>Constraints:</b>
        /// <list type="definition">
        ///     <item>
        ///         <term>Pattern</term>
        ///         <description>(^H\.264$)</description>
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
        /// Blu-ray discs.</li> </ul> <b>Level</b> The H.264 level that you want to use for the output file. Elastic Transcoder supports the following
        /// levels: <c>1</c>, <c>1b</c>, <c>1.1</c>, <c>1.2</c>, <c>1.3</c>, <c>2</c>, <c>2.1</c>, <c>2.2</c>, <c>3</c>, <c>3.1</c>, <c>3.2</c>,
        /// <c>4</c>, <c>4.1</c> <b>MaxReferenceFrames</b> The maximum number of previously decoded frames to use as a reference for decoding future
        /// frames. Valid values are integers 0 through 16, but we recommend that you not use a value greater than the following: <c>Min(Floor(Maximum
        /// decoded picture buffer in macroblocks * 256 / (Width in pixels * Height in pixels)), 16)</c> where <i>Width in pixels</i> and <i>Height in
        /// pixels</i> represent the resolution of the output video and <i>Maximum decoded picture buffer in macroblocks</i> depends on the value of the
        /// <c>Level</c> object. (A macroblock is a block of pixels measuring 16x16.) Note that the calculation for maximum decoded picture buffer,
        /// which is similar to the calculation for maximum reference frames, uses macroblocks instead of pixels for the width and height of the video.
        /// To determine the value of maximum decoded picture buffer in macroblocks, see the following list (<i>Level</i> - <i>Maximum decoded picture
        /// buffer</i>): <ul> <li>1 - 396</li> <li>1b - 396</li> <li>1.1 - 900</li> <li>1.2 - 2376</li> <li>1.3 - 2376</li> <li>2 - 2376</li> <li>2.1 -
        /// 4752</li> <li>2.2 - 8100</li> <li>3 - 8100</li> <li>3.1 - 18000</li> <li>3.2 - 20480</li> <li>4 - 32768</li> <li>4.1 - 32768</li> </ul>
        ///  
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
        /// part, on the content of the key frames. The value is an integer formatted as a string; valid values are between 1 and 100000, inclusive. A
        /// higher value results in higher compression but may also discernibly decrease video quality.
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
        /// <c>Profile</c>. We recommend that you specify a value less than or equal to the maximum H.264-compliant value listed in the following list
        /// for your level and profile: <i>Level - Maximum video bit rate in kilobits/second (baseline and main Profile) : maximum video bit rate in
        /// kilobits/second (high Profile)</i> <ul> <li>1 - 64 : 80</li> <li>1b - 128 : 160</li> <li>1.1 - 192 : 240</li> <li>1.2 - 384 : 480</li>
        /// <li>1.3 - 768 : 960</li> <li>2 - 2000 : 2500</li> <li>3 - 10000 : 12500</li> <li>3.1 - 14000 : 17500</li> <li>3.2 - 20000 : 25000</li> <li>4
        /// - 20000 : 25000</li> <li>4.1 - 50000 : 62500</li> </ul>
        ///  
        /// <para>
        /// <b>Constraints:</b>
        /// <list type="definition">
        ///     <item>
        ///         <term>Pattern</term>
        ///         <description>^\d{2,5}$</description>
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
        /// The width and height of the video in the output file, in pixels. Valid values are <c>auto</c> and <i>width</i> x <i>height</i>: <ul>
        /// <li><c>auto</c>: Elastic Transcoder attempts to preserve the width and height of the input file, subject to the following rules.</li>
        /// <li><c><i>width</i> x <i>height</i></c>: The width and height of the output video in pixels.</li> </ul> Note the following about specifying
        /// the width and height: <ul> <li>The width must be an even integer between 128 and 4096, inclusive.</li> <li>The height must be an even
        /// integer between 96 and 3072, inclusive.</li> <li>If you specify a resolution that is less than the resolution of the input file, Elastic
        /// Transcoder rescales the output file to the lower resolution.</li> <li>If you specify a resolution that is greater than the resolution of the
        /// input file, Elastic Transcoder rescales the output to the higher resolution.</li> <li>We recommend that you specify a resolution for which
        /// the product of width and height is less than or equal to the applicable value in the following list (<i>List - Max width x height
        /// value</i>):</li> <ul> <li>1 - 25344</li> <li>1b - 25344</li> <li>1.1 - 101376</li> <li>1.2 - 101376</li> <li>1.3 - 101376</li> <li>2 -
        /// 101376</li> <li>2.1 - 202752</li> <li>2.2 - 404720</li> <li>3 - 404720</li> <li>3.1 - 921600</li> <li>3.2 - 1310720</li> <li>4 -
        /// 2097152</li> <li>4.1 - 2097152</li> </ul> </ul>
        ///  
        /// <para>
        /// <b>Constraints:</b>
        /// <list type="definition">
        ///     <item>
        ///         <term>Pattern</term>
        ///         <description>(^auto$)|(^\d+x\d+$)</description>
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
        /// The display aspect ratio of the video in the output file. Valid values include: <c>auto</c>, <c>1:1</c>, <c>4:3</c>, <c>3:2</c>, <c>16:9</c>
        /// If you specify <c>auto</c>, Elastic Transcoder tries to preserve the aspect ratio of the input file. If you specify an aspect ratio for the
        /// output file that differs from aspect ratio of the input file, Elastic Transcoder adds pillarboxing (black bars on the sides) or letterboxing
        /// (black bars on the top and bottom) to maintain the aspect ratio of the active region of the video.
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
    }
}
