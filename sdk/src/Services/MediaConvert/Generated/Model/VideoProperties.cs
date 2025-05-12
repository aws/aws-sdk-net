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
    /// Details about the media file's video track.
    /// </summary>
    public partial class VideoProperties
    {
        private int? _bitDepth;
        private long? _bitRate;
        private ColorPrimaries _colorPrimaries;
        private FrameRate _frameRate;
        private int? _height;
        private MatrixCoefficients _matrixCoefficients;
        private TransferCharacteristics _transferCharacteristics;
        private int? _width;

        /// <summary>
        /// Gets and sets the property BitDepth. The bit depth of the video track.
        /// </summary>
        public int? BitDepth
        {
            get { return this._bitDepth; }
            set { this._bitDepth = value; }
        }

        // Check to see if BitDepth property is set
        internal bool IsSetBitDepth()
        {
            return this._bitDepth.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property BitRate. The bit rate of the video track, in bits per second.
        /// </summary>
        public long? BitRate
        {
            get { return this._bitRate; }
            set { this._bitRate = value; }
        }

        // Check to see if BitRate property is set
        internal bool IsSetBitRate()
        {
            return this._bitRate.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property ColorPrimaries. The color space color primaries of the
        /// video track.
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
        /// Gets and sets the property FrameRate. The frame rate of the video or audio track.
        /// </summary>
        public FrameRate FrameRate
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
        /// Gets and sets the property Height. The height of the video track, in pixels.
        /// </summary>
        public int? Height
        {
            get { return this._height; }
            set { this._height = value; }
        }

        // Check to see if Height property is set
        internal bool IsSetHeight()
        {
            return this._height.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property MatrixCoefficients. The color space matrix coefficients
        /// of the video track.
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
        /// Gets and sets the property TransferCharacteristics. The color space transfer characteristics
        /// of the video track.
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
        /// Gets and sets the property Width. The width of the video track, in pixels.
        /// </summary>
        public int? Width
        {
            get { return this._width; }
            set { this._width = value; }
        }

        // Check to see if Width property is set
        internal bool IsSetWidth()
        {
            return this._width.HasValue; 
        }

    }
}