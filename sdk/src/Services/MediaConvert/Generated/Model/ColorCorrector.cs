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

/*
 * Do not modify this file. This file is generated from the mediaconvert-2017-08-29.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.MediaConvert.Model
{
    /// <summary>
    /// Settings for color correction.
    /// </summary>
    public partial class ColorCorrector
    {
        private int? _brightness;
        private ColorSpaceConversion _colorSpaceConversion;
        private int? _contrast;
        private Hdr10Metadata _hdr10Metadata;
        private int? _hue;
        private int? _saturation;

        /// <summary>
        /// Gets and sets the property Brightness. Brightness level.
        /// </summary>
        public int Brightness
        {
            get { return this._brightness.GetValueOrDefault(); }
            set { this._brightness = value; }
        }

        // Check to see if Brightness property is set
        internal bool IsSetBrightness()
        {
            return this._brightness.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property ColorSpaceConversion.
        /// </summary>
        public ColorSpaceConversion ColorSpaceConversion
        {
            get { return this._colorSpaceConversion; }
            set { this._colorSpaceConversion = value; }
        }

        // Check to see if ColorSpaceConversion property is set
        internal bool IsSetColorSpaceConversion()
        {
            return this._colorSpaceConversion != null;
        }

        /// <summary>
        /// Gets and sets the property Contrast. Contrast level.
        /// </summary>
        public int Contrast
        {
            get { return this._contrast.GetValueOrDefault(); }
            set { this._contrast = value; }
        }

        // Check to see if Contrast property is set
        internal bool IsSetContrast()
        {
            return this._contrast.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Hdr10Metadata.
        /// </summary>
        public Hdr10Metadata Hdr10Metadata
        {
            get { return this._hdr10Metadata; }
            set { this._hdr10Metadata = value; }
        }

        // Check to see if Hdr10Metadata property is set
        internal bool IsSetHdr10Metadata()
        {
            return this._hdr10Metadata != null;
        }

        /// <summary>
        /// Gets and sets the property Hue. Hue in degrees.
        /// </summary>
        public int Hue
        {
            get { return this._hue.GetValueOrDefault(); }
            set { this._hue = value; }
        }

        // Check to see if Hue property is set
        internal bool IsSetHue()
        {
            return this._hue.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Saturation. Saturation level.
        /// </summary>
        public int Saturation
        {
            get { return this._saturation.GetValueOrDefault(); }
            set { this._saturation = value; }
        }

        // Check to see if Saturation property is set
        internal bool IsSetSaturation()
        {
            return this._saturation.HasValue; 
        }

    }
}