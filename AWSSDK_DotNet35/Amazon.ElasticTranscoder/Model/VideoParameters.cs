/*
 * Copyright 2010-2014 Amazon.com, Inc. or its affiliates. All Rights Reserved.
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

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.ElasticTranscoder.Model
{
    /// <summary>
    /// The <code>VideoParameters</code> structure.
    /// </summary>
    public partial class VideoParameters
    {
        private string _aspectRatio;
        private string _bitRate;
        private string _codec;
        private Dictionary<string, string> _codecOptions = new Dictionary<string, string>();
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
        private List<PresetWatermark> _watermarks = new List<PresetWatermark>();


        /// <summary>
        /// Gets and sets the property AspectRatio. <important>            
        /// <para>
        /// To better control resolution and aspect ratio of output videos, we recommend that
        /// you                use the values <code>MaxWidth</code>, <code>MaxHeight</code>, 
        ///                   <code>SizingPolicy</code>, <code>PaddingPolicy</code>, and     
        ///               <code>DisplayAspectRatio</code> instead of <code>Resolution</code> and
        ///                    <code>AspectRatio</code>. The two groups of settings are mutually
        /// exclusive. Do                not use them together.
        /// </para>
        ///         </important>        
        /// <para>
        /// The display aspect ratio of the video in the output file. Valid values include:
        /// </para>
        ///         
        /// <para>
        /// <code>auto</code>, <code>1:1</code>, <code>4:3</code>, <code>3:2</code>,         
        ///       <code>16:9</code>
        /// </para>
        ///         
        /// <para>
        /// If you specify <code>auto</code>, Elastic Transcoder tries to preserve the aspect
        /// ratio of the input            file.
        /// </para>
        ///         
        /// <para>
        /// If you specify an aspect ratio for the output file that differs from aspect ratio
        /// of the            input file, Elastic Transcoder adds pillarboxing (black bars on
        /// the sides) or letterboxing (black bars            on the top and bottom) to maintain
        /// the aspect ratio of the active region of the            video.
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
        ///            depend on the values of <code>Level</code> and <code>Profile</code>. If
        /// you specify                <code>auto</code>, Elastic Transcoder uses the detected
        /// bit rate of the input source. If you            specify a value other than <code>auto</code>,
        /// we recommend that you specify a value less            than or equal to the maximum
        /// H.264-compliant value listed for your level and            profile:
        /// </para>
        ///         
        /// <para>
        ///             <i>Level - Maximum video bit rate in kilobits/second (baseline and main
        /// Profile) :                maximum video bit rate in kilobits/second (high Profile)</i>
        ///        
        /// </para>
        ///         <ul>            <li>1 - 64 : 80</li>            <li>1b - 128 : 160</li>  
        ///          <li>1.1 - 192 : 240</li>            <li>1.2 - 384 : 480</li>            <li>1.3
        /// - 768 : 960</li>            <li>2 - 2000 : 2500</li>            <li>3 - 10000 : 12500</li>
        ///            <li>3.1 - 14000 : 17500</li>            <li>3.2 - 20000 : 25000</li>  
        ///          <li>4 - 20000 : 25000</li>            <li>4.1 - 50000 : 62500</li>      
        ///  </ul>
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
        /// The video codec for the output file. Valid values include <code>H.264</code> and 
        ///               <code>vp8</code>. You can only specify <code>vp8</code> when the container
        /// type is                <code>webm</code>.
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
        ///             <b>Profile</b>        
        /// </para>
        ///         
        /// <para>
        /// The H.264 profile that you want to use for the output file. Elastic Transcoder supports
        /// the following            profiles:
        /// </para>
        ///         <ul>            <li><code>baseline</code>: The profile most commonly used
        /// for videoconferencing and for                mobile applications.</li>           
        /// <li><code>main</code>: The profile used for standard-definition digital TV       
        ///         broadcasts.</li>            <li><code>high</code>: The profile used for high-definition
        /// digital TV broadcasts and                for Blu-ray discs.</li>        </ul>    
        ///    
        /// <para>
        ///             <b>Level (H.264 Only)</b>        
        /// </para>
        ///         
        /// <para>
        /// The H.264 level that you want to use for the output file. Elastic Transcoder supports
        /// the following            levels:
        /// </para>
        ///         
        /// <para>
        /// <code>1</code>, <code>1b</code>, <code>1.1</code>, <code>1.2</code>, <code>1.3</code>,
        ///                <code>2</code>, <code>2.1</code>, <code>2.2</code>, <code>3</code>,
        ///            <code>3.1</code>, <code>3.2</code>, <code>4</code>, <code>4.1</code>
        /// </para>
        ///         
        /// <para>
        ///             <b>MaxReferenceFrames (H.264 Only)</b>        
        /// </para>
        ///         
        /// <para>
        /// Applicable only when the value of Video:Codec is H.264. The maximum number of previously
        ///            decoded frames to use as a reference for decoding future frames. Valid
        /// values are            integers 0 through 16, but we recommend that you not use a value
        /// greater than the            following:
        /// </para>
        ///         
        /// <para>
        ///             <code>Min(Floor(Maximum decoded picture buffer in macroblocks * 256 /
        /// (Width in pixels *                Height in pixels)), 16)</code>        
        /// </para>
        ///         
        /// <para>
        /// where <i>Width in pixels</i> and <i>Height in pixels</i> represent either MaxWidth
        /// and            MaxHeight, or Resolution. <i>Maximum decoded picture buffer in macroblocks</i>
        /// depends            on the value of the <code>Level</code> object. See the list below.
        /// (A macroblock is a            block of pixels measuring 16x16.) 
        /// </para>
        ///         <ul>            <li>1 - 396</li>            <li>1b - 396</li>            <li>1.1
        /// - 900</li>            <li>1.2 - 2376</li>            <li>1.3 - 2376</li>         
        ///   <li>2 - 2376</li>            <li>2.1 - 4752</li>            <li>2.2 - 8100</li>
        ///            <li>3 - 8100</li>            <li>3.1 - 18000</li>            <li>3.2 -
        /// 20480</li>            <li>4 - 32768</li>            <li>4.1 - 32768</li>        </ul>
        ///        
        /// <para>
        ///             <b>MaxBitRate</b>        
        /// </para>
        ///         
        /// <para>
        /// The maximum number of bits per second in a video buffer; the size of the buffer is
        ///            specified by <code>BufferSize</code>. Specify a value between 16 and 62,500.
        /// You can            reduce the bandwidth required to stream a video by reducing the
        /// maximum bit rate, but            this also reduces the quality of the video.
        /// </para>
        ///         
        /// <para>
        ///             <b>BufferSize</b>        
        /// </para>
        ///         
        /// <para>
        /// The maximum number of bits in any x seconds of the output video. This window is commonly
        ///            10 seconds, the standard segment duration when you're using MPEG-TS for
        /// the container            type of the output video. Specify an integer greater than
        /// 0. If you specify                <code>MaxBitRate</code> and omit <code>BufferSize</code>,
        /// Elastic Transcoder sets                <code>BufferSize</code> to 10 times the value
        /// of <code>MaxBitRate</code>.
        /// </para>
        /// </summary>
        public Dictionary<string, string> CodecOptions
        {
            get { return this._codecOptions; }
            set { this._codecOptions = value; }
        }

        // Check to see if CodecOptions property is set
        internal bool IsSetCodecOptions()
        {
            return this._codecOptions != null && this._codecOptions.Count > 0; 
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
        /// Whether to use a fixed value for <code>FixedGOP</code>. Valid values are         
        ///       <code>true</code> and <code>false</code>:
        /// </para>
        ///         <ul>            <li><code>true</code>: Elastic Transcoder uses the value of
        /// <code>KeyframesMaxDist</code> for the                distance between key frames (the
        /// number of frames in a group of pictures, or                GOP).</li>            <li><code>false</code>:
        /// The distance between key frames can vary.</li>        </ul>
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
        /// <code>auto</code>, <code>10</code>, <code>15</code>, <code>23.97</code>, <code>24</code>,
        ///                <code>25</code>, <code>29.97</code>, <code>30</code>, <code>60</code>
        /// </para>
        ///         
        /// <para>
        /// If you specify <code>auto</code>, Elastic Transcoder uses the detected frame rate
        /// of the input source.            If you specify a frame rate, we recommend that you
        /// perform the following            calculation:
        /// </para>
        ///         
        /// <para>
        ///             <code>Frame rate = maximum recommended decoding speed in luma samples/second
        /// / (width in                pixels * height in pixels)</code>        
        /// </para>
        ///         
        /// <para>
        /// where:
        /// </para>
        ///         <ul>            <li><i>width in pixels</i> and <i>height in pixels</i> represent
        /// the Resolution of the                output video.</li>            <li><i>maximum
        /// recommended decoding speed in Luma samples/second</i> is less than or            
        ///    equal to the maximum value listed in the following table, based on the value that
        ///                you specified for Level.</li>        </ul>        
        /// <para>
        /// The maximum recommended decoding speed in Luma samples/second for each level is described
        ///            in the following list (<i>Level - Decoding speed</i>):
        /// </para>
        ///         <ul>            <li>1 - 380160</li>            <li>1b - 380160</li>      
        ///      <li>1.1 - 76800</li>            <li>1.2 - 1536000</li>            <li>1.3 - 3041280</li>
        ///            <li>2 - 3041280</li>            <li>2.1 - 5068800</li>            <li>2.2
        /// - 5184000</li>            <li>3 - 10368000</li>            <li>3.1 - 27648000</li>
        ///            <li>3.2 - 55296000</li>            <li>4 - 62914560</li>            <li>4.1
        /// - 62914560</li>        </ul>
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
        /// The maximum number of frames between key frames. Key frames are fully encoded frames;
        /// the            frames between key frames are encoded based, in part, on the content
        /// of the key frames.            The value is an integer formatted as a string; valid
        /// values are between 1 (every frame            is a key frame) and 100000, inclusive.
        /// A higher value results in higher compression but            may also discernibly decrease
        /// video quality.
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
        /// If you specify <code>auto</code> for <code>FrameRate</code>, Elastic Transcoder uses
        /// the frame rate of            the input video for the frame rate of the output video.
        /// Specify the maximum frame rate            that you want Elastic Transcoder to use
        /// when the frame rate of the input video is greater than the            desired maximum
        /// frame rate of the output video. Valid values include: <code>10</code>,           
        ///     <code>15</code>, <code>23.97</code>, <code>24</code>, <code>25</code>,       
        ///         <code>29.97</code>, <code>30</code>, <code>60</code>.
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
        /// The maximum height of the output video in pixels. If you specify <code>auto</code>,
        /// Elastic Transcoder            uses 1080 (Full HD) as the default value. If you specify
        /// a numeric value, enter an even            integer between 96 and 3072.
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
        ///  The maximum width of the output video in pixels. If you specify <code>auto</code>,
        /// Elastic Transcoder            uses 1920 (Full HD) as the default value. If you specify
        /// a numeric value, enter an even            integer between 128 and 4096. 
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
        /// When you set <code>PaddingPolicy</code> to <code>Pad</code>, Elastic Transcoder may
        /// add black bars to            the top and bottom and/or left and right sides of the
        /// output video to make the total            size of the output video match the values
        /// that you specified for <code>MaxWidth</code>            and <code>MaxHeight</code>.
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
        /// you                use the values <code>MaxWidth</code>, <code>MaxHeight</code>, 
        ///                   <code>SizingPolicy</code>, <code>PaddingPolicy</code>, and     
        ///               <code>DisplayAspectRatio</code> instead of <code>Resolution</code> and
        ///                    <code>AspectRatio</code>. The two groups of settings are mutually
        /// exclusive. Do                not use them together.
        /// </para>
        ///         </important>        
        /// <para>
        /// The width and height of the video in the output file, in pixels. Valid values are
        ///                <code>auto</code> and <i>width</i> x <i>height</i>:
        /// </para>
        ///         <ul>            <li><code>auto</code>: Elastic Transcoder attempts to preserve
        /// the width and height of the input file,                subject to the following rules.</li>
        ///            <li><code><i>width</i> x <i>height</i></code>: The width and height of
        /// the output video                in pixels.</li>        </ul>        
        /// <para>
        /// Note the following about specifying the width and height:
        /// </para>
        ///         <ul>            <li>The width must be an even integer between 128 and 4096,
        /// inclusive.</li>            <li>The height must be an even integer between 96 and 3072,
        /// inclusive.</li>            <li>If you specify a resolution that is less than the resolution
        /// of the input file, Elastic Transcoder                rescales the output file to the
        /// lower resolution.</li>            <li>If you specify a resolution that is greater
        /// than the resolution of the input file,                Elastic Transcoder rescales
        /// the output to the higher resolution.</li>            <li>We recommend that you specify
        /// a resolution for which the product of width and height                is less than
        /// or equal to the applicable value in the following list (<i>List - Max            
        ///        width x height value</i>):</li>            <ul>                <li>1 - 25344</li>
        ///                <li>1b - 25344</li>                <li>1.1 - 101376</li>          
        ///      <li>1.2 - 101376</li>                <li>1.3 - 101376</li>                <li>2
        /// - 101376</li>                <li>2.1 - 202752</li>                <li>2.2 - 404720</li>
        ///                <li>3 - 404720</li>                <li>3.1 - 921600</li>          
        ///      <li>3.2 - 1310720</li>                <li>4 - 2097152</li>                <li>4.1
        /// - 2097152</li>            </ul>        </ul>
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
        ///         
        /// <para>
        ///             <ul>                <li><code>Fit</code>: Elastic Transcoder scales the
        /// output video so it matches the value that you                    specified in either
        /// <code>MaxWidth</code> or <code>MaxHeight</code> without                    exceeding
        /// the other value.</li>                <li><code>Fill</code>: Elastic Transcoder scales
        /// the output video so it matches the value that you                    specified in
        /// either <code>MaxWidth</code> or <code>MaxHeight</code> and matches               
        ///     or exceeds the other value. Elastic Transcoder centers the output video and then
        /// crops it in                    the dimension (if any) that exceeds the maximum value.</li>
        ///                <li><code>Stretch</code>: Elastic Transcoder stretches the output video
        /// to match the values that                    you specified for <code>MaxWidth</code>
        /// and <code>MaxHeight</code>. If the                    relative proportions of the
        /// input video and the output video are different, the                    output video
        /// will be distorted.</li>                <li><code>Keep</code>: Elastic Transcoder does
        /// not scale the output video. If either                    dimension of the input video
        /// exceeds the values that you specified for                        <code>MaxWidth</code>
        /// and <code>MaxHeight</code>, Elastic Transcoder crops the output                  
        ///  video.</li>                <li><code>ShrinkToFit</code>: Elastic Transcoder scales
        /// the output video down so that its                    dimensions match the values that
        /// you specified for at least one of                        <code>MaxWidth</code> and
        /// <code>MaxHeight</code> without exceeding either                    value. If you specify
        /// this option, Elastic Transcoder does not scale the video up.</li>                <li><code>ShrinkToFill</code>:
        /// Elastic Transcoder scales the output video down so that its                    dimensions
        /// match the values that you specified for at least one of                        <code>MaxWidth</code>
        /// and <code>MaxHeight</code> without dropping below                    either value.
        /// If you specify this option, Elastic Transcoder does not scale the video up.</li> 
        ///           </ul>        
        /// </para>
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
        /// to overlay            over videos that are transcoded using this preset. You can specify
        /// settings for up to            four watermarks. Watermarks appear in the specified
        /// size and location, and with the            specified opacity for the duration of the
        /// transcoded video.
        /// </para>
        ///         
        /// <para>
        /// Watermarks can be in .png or .jpg format. If you want to display a watermark that
        /// is not            rectangular, use the .png format, which supports transparency.
        /// </para>
        ///         
        /// <para>
        /// When you create a job that uses this preset, you specify the .png or .jpg graphics
        /// that            you want Elastic Transcoder to include in the transcoded videos. You
        /// can specify fewer            graphics in the job than you specify watermark settings
        /// in the preset, which allows you            to use the same preset for up to four watermarks
        /// that have different dimensions.
        /// </para>
        /// </summary>
        public List<PresetWatermark> Watermarks
        {
            get { return this._watermarks; }
            set { this._watermarks = value; }
        }

        // Check to see if Watermarks property is set
        internal bool IsSetWatermarks()
        {
            return this._watermarks != null && this._watermarks.Count > 0; 
        }

    }
}