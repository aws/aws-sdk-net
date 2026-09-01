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
    /// Settings related to TTML captions. TTML is a sidecar format that holds captions in
    /// a file that is separate from the video container. Set up sidecar captions in the same
    /// output group, but different output from your video. For more information, see https://docs.aws.amazon.com/mediaconvert/latest/ug/ttml-and-webvtt-output-captions.html.
    /// </summary>
    public partial class TtmlDestinationSettings
    {
        private TtmlBackgroundColor _backgroundColor;
        private int? _backgroundOpacity;
        private TtmlFontColor _fontColor;
        private int? _fontOpacity;
        private int? _fontSize;
        private TtmlFontStyle _fontStyle;
        private TtmlFontWeight _fontWeight;
        private TtmlStylePassthrough _stylePassthrough;
        private TtmlTextDecoration _textDecoration;

        /// <summary>
        /// Gets and sets the property BackgroundColor. Specify the color of the rectangle behind
        /// the captions. If Style passthrough is set to enabled, leave blank or set to Auto to
        /// pass through the background color from your input captions. If Style passthrough is
        /// set to disabled, leave blank or set to Auto to use the default black.
        /// </summary>
        public TtmlBackgroundColor BackgroundColor
        {
            get { return this._backgroundColor; }
            set { this._backgroundColor = value; }
        }

        // Check to see if BackgroundColor property is set
        internal bool IsSetBackgroundColor()
        {
            return this._backgroundColor != null;
        }

        /// <summary>
        /// Gets and sets the property BackgroundOpacity. Specify the opacity of the background
        /// rectangle. Enter a value from 0 to 255, where 0 is transparent and 255 is opaque.
        /// If Style passthrough is set to enabled, leave blank to pass through the background
        /// style information in your input captions to your output captions. If Style passthrough
        /// is set to disabled and backgroundColor is set, leave blank to use a value of 255 (opaque).
        /// </summary>
        [AWSProperty(Min=0, Max=255)]
        public int? BackgroundOpacity
        {
            get { return this._backgroundOpacity; }
            set { this._backgroundOpacity = value; }
        }

        // Check to see if BackgroundOpacity property is set
        internal bool IsSetBackgroundOpacity()
        {
            return this._backgroundOpacity.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property FontColor. Specify the color of the captions text. If Style
        /// passthrough is set to enabled, leave blank or set to Auto to pass through the font
        /// color from your input captions. If Style passthrough is set to disabled, leave blank
        /// or set to Auto to use the default white.
        /// </summary>
        public TtmlFontColor FontColor
        {
            get { return this._fontColor; }
            set { this._fontColor = value; }
        }

        // Check to see if FontColor property is set
        internal bool IsSetFontColor()
        {
            return this._fontColor != null;
        }

        /// <summary>
        /// Gets and sets the property FontOpacity. Specify the opacity of the captions. Enter
        /// a value from 0 to 255, where 0 is transparent and 255 is opaque. If Style passthrough
        /// is set to enabled, leave blank to pass through the font opacity information in your
        /// input captions to your output captions. If Style passthrough is set to disabled and
        /// fontColor is set, leave blank to use a value of 255 (opaque).
        /// </summary>
        [AWSProperty(Min=0, Max=255)]
        public int? FontOpacity
        {
            get { return this._fontOpacity; }
            set { this._fontOpacity = value; }
        }

        // Check to see if FontOpacity property is set
        internal bool IsSetFontOpacity()
        {
            return this._fontOpacity.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property FontSize. Specify the Font size in pixels. Must be a positive
        /// integer. Set to 0, or leave blank, for automatic font size.
        /// </summary>
        [AWSProperty(Min=0, Max=96)]
        public int? FontSize
        {
            get { return this._fontSize; }
            set { this._fontSize = value; }
        }

        // Check to see if FontSize property is set
        internal bool IsSetFontSize()
        {
            return this._fontSize.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property FontStyle. Specify the font style of the caption text.
        /// If Style passthrough is set to enabled, leave blank to pass through the font style
        /// from your input captions. If Style passthrough is set to disabled, leave blank to
        /// use the default normal style.
        /// </summary>
        public TtmlFontStyle FontStyle
        {
            get { return this._fontStyle; }
            set { this._fontStyle = value; }
        }

        // Check to see if FontStyle property is set
        internal bool IsSetFontStyle()
        {
            return this._fontStyle != null;
        }

        /// <summary>
        /// Gets and sets the property FontWeight. Specify the font weight of the caption text.
        /// If Style passthrough is set to enabled, leave blank to pass through the font weight
        /// from your input captions. If Style passthrough is set to disabled, leave blank to
        /// use the default normal weight.
        /// </summary>
        public TtmlFontWeight FontWeight
        {
            get { return this._fontWeight; }
            set { this._fontWeight = value; }
        }

        // Check to see if FontWeight property is set
        internal bool IsSetFontWeight()
        {
            return this._fontWeight != null;
        }

        /// <summary>
        /// Gets and sets the property StylePassthrough. Pass through style and position information
        /// from a TTML-like input source (TTML, IMSC, SMPTE-TT) to the TTML output.
        /// </summary>
        public TtmlStylePassthrough StylePassthrough
        {
            get { return this._stylePassthrough; }
            set { this._stylePassthrough = value; }
        }

        // Check to see if StylePassthrough property is set
        internal bool IsSetStylePassthrough()
        {
            return this._stylePassthrough != null;
        }

        /// <summary>
        /// Gets and sets the property TextDecoration. Specify the text decoration of the caption
        /// text. If Style passthrough is set to enabled, leave blank to pass through the text
        /// decoration from your input captions. If Style passthrough is set to disabled, leave
        /// blank to use the default of none.
        /// </summary>
        public TtmlTextDecoration TextDecoration
        {
            get { return this._textDecoration; }
            set { this._textDecoration = value; }
        }

        // Check to see if TextDecoration property is set
        internal bool IsSetTextDecoration()
        {
            return this._textDecoration != null;
        }

    }
}