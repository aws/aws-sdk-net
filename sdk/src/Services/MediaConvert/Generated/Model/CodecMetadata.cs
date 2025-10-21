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
    /// Codec-specific parameters parsed from the video essence headers. This information
    /// provides detailed technical specifications about how the video was encoded, including
    /// profile settings, resolution details, and color space information that can help you
    /// understand the source video characteristics and make informed encoding decisions.
    /// </summary>
    public partial class CodecMetadata
    {
        private int? _bitDepth;
        private string _chromaSubsampling;
        private FrameRate _codedFrameRate;
        private ColorPrimaries _colorPrimaries;
        private int? _height;
        private string _level;
        private MatrixCoefficients _matrixCoefficients;
        private string _profile;
        private string _scanType;
        private TransferCharacteristics _transferCharacteristics;
        private int? _width;

        /// <summary>
        /// Gets and sets the property BitDepth. The number of bits used per color component in
        /// the video essence such as 8, 10, or 12 bits. Standard range (SDR) video typically
        /// uses 8-bit, while 10-bit is common for high dynamic range (HDR).
        /// </summary>
        public int BitDepth
        {
            get { return this._bitDepth.GetValueOrDefault(); }
            set { this._bitDepth = value; }
        }

        // Check to see if BitDepth property is set
        internal bool IsSetBitDepth()
        {
            return this._bitDepth.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property ChromaSubsampling. The chroma subsampling format used in
        /// the video encoding, such as "4:2:0" or "4:4:4". This describes how color information
        /// is sampled relative to brightness information. Different subsampling ratios affect
        /// video quality and file size, with "4:4:4" providing the highest color fidelity and
        /// "4:2:0" being most common for standard video.
        /// </summary>
        public string ChromaSubsampling
        {
            get { return this._chromaSubsampling; }
            set { this._chromaSubsampling = value; }
        }

        // Check to see if ChromaSubsampling property is set
        internal bool IsSetChromaSubsampling()
        {
            return this._chromaSubsampling != null;
        }

        /// <summary>
        /// Gets and sets the property CodedFrameRate. The frame rate of the video or audio track,
        /// expressed as a fraction with numerator and denominator values.
        /// </summary>
        public FrameRate CodedFrameRate
        {
            get { return this._codedFrameRate; }
            set { this._codedFrameRate = value; }
        }

        // Check to see if CodedFrameRate property is set
        internal bool IsSetCodedFrameRate()
        {
            return this._codedFrameRate != null;
        }

        /// <summary>
        /// Gets and sets the property ColorPrimaries. The color space primaries of the video
        /// track, defining the red, green, and blue color coordinates used for the video. This
        /// information helps ensure accurate color reproduction during playback and transcoding.
        /// </summary>
        public ColorPrimaries ColorPrimaries
        {
            get { return this._colorPrimaries; }
            set { this._colorPrimaries = value; }
        }

        // Check to see if ColorPrimaries property is set
        internal bool IsSetColorPrimaries()
        {
            return this._colorPrimaries != null;
        }

        /// <summary>
        /// Gets and sets the property Height. The height in pixels as coded by the codec. This
        /// represents the actual encoded video height as specified in the video stream headers.
        /// </summary>
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
        /// Gets and sets the property Level. The codec level or tier that specifies the maximum
        /// processing requirements and capabilities. Levels define constraints such as maximum
        /// bit rate, frame rate, and resolution.
        /// </summary>
        public string Level
        {
            get { return this._level; }
            set { this._level = value; }
        }

        // Check to see if Level property is set
        internal bool IsSetLevel()
        {
            return this._level != null;
        }

        /// <summary>
        /// Gets and sets the property MatrixCoefficients. The color space matrix coefficients
        /// of the video track, defining how RGB color values are converted to and from YUV color
        /// space. This affects color accuracy during encoding and decoding processes.
        /// </summary>
        public MatrixCoefficients MatrixCoefficients
        {
            get { return this._matrixCoefficients; }
            set { this._matrixCoefficients = value; }
        }

        // Check to see if MatrixCoefficients property is set
        internal bool IsSetMatrixCoefficients()
        {
            return this._matrixCoefficients != null;
        }

        /// <summary>
        /// Gets and sets the property Profile. The codec profile used to encode the video. Profiles
        /// define specific feature sets and capabilities within a codec standard. For example,
        /// H.264 profiles include Baseline, Main, and High, each supporting different encoding
        /// features and complexity levels.
        /// </summary>
        public string Profile
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
        /// Gets and sets the property ScanType. The scanning method specified in the video essence,
        /// indicating whether the video uses progressive or interlaced scanning.
        /// </summary>
        public string ScanType
        {
            get { return this._scanType; }
            set { this._scanType = value; }
        }

        // Check to see if ScanType property is set
        internal bool IsSetScanType()
        {
            return this._scanType != null;
        }

        /// <summary>
        /// Gets and sets the property TransferCharacteristics. The color space transfer characteristics
        /// of the video track, defining the relationship between linear light values and the
        /// encoded signal values. This affects brightness and contrast reproduction.
        /// </summary>
        public TransferCharacteristics TransferCharacteristics
        {
            get { return this._transferCharacteristics; }
            set { this._transferCharacteristics = value; }
        }

        // Check to see if TransferCharacteristics property is set
        internal bool IsSetTransferCharacteristics()
        {
            return this._transferCharacteristics != null;
        }

        /// <summary>
        /// Gets and sets the property Width. The width in pixels as coded by the codec. This
        /// represents the actual encoded video width as specified in the video stream headers.
        /// </summary>
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