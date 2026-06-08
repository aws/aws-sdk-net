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
    /// Mastering display color volume metadata (SMPTE ST 2086). Describes the color volume
    /// of the display used to master the content. Chromaticity coordinates are in units of
    /// 0.00002. Luminance values are in units of 0.0001 cd/m².
    /// </summary>
    public partial class MasteringDisplayColorVolume
    {
        private int? _bluePrimaryX;
        private int? _bluePrimaryY;
        private int? _greenPrimaryX;
        private int? _greenPrimaryY;
        private long? _maxLuminance;
        private long? _minLuminance;
        private int? _redPrimaryX;
        private int? _redPrimaryY;
        private int? _whitePointX;
        private int? _whitePointY;

        /// <summary>
        /// Gets and sets the property BluePrimaryX. Blue primary chromaticity x coordinate, in
        /// units of 0.00002.
        /// </summary>
        public int? BluePrimaryX
        {
            get { return this._bluePrimaryX; }
            set { this._bluePrimaryX = value; }
        }

        // Check to see if BluePrimaryX property is set
        internal bool IsSetBluePrimaryX()
        {
            return this._bluePrimaryX.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property BluePrimaryY. Blue primary chromaticity y coordinate, in
        /// units of 0.00002.
        /// </summary>
        public int? BluePrimaryY
        {
            get { return this._bluePrimaryY; }
            set { this._bluePrimaryY = value; }
        }

        // Check to see if BluePrimaryY property is set
        internal bool IsSetBluePrimaryY()
        {
            return this._bluePrimaryY.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property GreenPrimaryX. Green primary chromaticity x coordinate,
        /// in units of 0.00002.
        /// </summary>
        public int? GreenPrimaryX
        {
            get { return this._greenPrimaryX; }
            set { this._greenPrimaryX = value; }
        }

        // Check to see if GreenPrimaryX property is set
        internal bool IsSetGreenPrimaryX()
        {
            return this._greenPrimaryX.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property GreenPrimaryY. Green primary chromaticity y coordinate,
        /// in units of 0.00002.
        /// </summary>
        public int? GreenPrimaryY
        {
            get { return this._greenPrimaryY; }
            set { this._greenPrimaryY = value; }
        }

        // Check to see if GreenPrimaryY property is set
        internal bool IsSetGreenPrimaryY()
        {
            return this._greenPrimaryY.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property MaxLuminance. Maximum display mastering luminance, in units
        /// of 0.0001 cd/m².
        /// </summary>
        public long? MaxLuminance
        {
            get { return this._maxLuminance; }
            set { this._maxLuminance = value; }
        }

        // Check to see if MaxLuminance property is set
        internal bool IsSetMaxLuminance()
        {
            return this._maxLuminance.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property MinLuminance. Minimum display mastering luminance, in units
        /// of 0.0001 cd/m².
        /// </summary>
        public long? MinLuminance
        {
            get { return this._minLuminance; }
            set { this._minLuminance = value; }
        }

        // Check to see if MinLuminance property is set
        internal bool IsSetMinLuminance()
        {
            return this._minLuminance.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property RedPrimaryX. Red primary chromaticity x coordinate, in
        /// units of 0.00002.
        /// </summary>
        public int? RedPrimaryX
        {
            get { return this._redPrimaryX; }
            set { this._redPrimaryX = value; }
        }

        // Check to see if RedPrimaryX property is set
        internal bool IsSetRedPrimaryX()
        {
            return this._redPrimaryX.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property RedPrimaryY. Red primary chromaticity y coordinate, in
        /// units of 0.00002.
        /// </summary>
        public int? RedPrimaryY
        {
            get { return this._redPrimaryY; }
            set { this._redPrimaryY = value; }
        }

        // Check to see if RedPrimaryY property is set
        internal bool IsSetRedPrimaryY()
        {
            return this._redPrimaryY.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property WhitePointX. White point chromaticity x coordinate, in
        /// units of 0.00002.
        /// </summary>
        public int? WhitePointX
        {
            get { return this._whitePointX; }
            set { this._whitePointX = value; }
        }

        // Check to see if WhitePointX property is set
        internal bool IsSetWhitePointX()
        {
            return this._whitePointX.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property WhitePointY. White point chromaticity y coordinate, in
        /// units of 0.00002.
        /// </summary>
        public int? WhitePointY
        {
            get { return this._whitePointY; }
            set { this._whitePointY = value; }
        }

        // Check to see if WhitePointY property is set
        internal bool IsSetWhitePointY()
        {
            return this._whitePointY.HasValue; 
        }

    }
}