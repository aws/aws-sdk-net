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
    /// Settings related to TTML captions. TTML is a sidecar format that holds captions in
    /// a file that is separate from the video container. Set up sidecar captions in the same
    /// output group, but different output from your video. For more information, see https://docs.aws.amazon.com/mediaconvert/latest/ug/ttml-and-webvtt-output-captions.html.
    /// </summary>
    public partial class TtmlDestinationSettings
    {
        /// <summary>
        /// Gets and sets the property BackgroundColor. Specify the color of the rectangle behind
        /// the captions. If Style passthrough is set to enabled, leave blank or set to Auto to
        /// pass through the background color from your input captions. If Style passthrough is
        /// set to disabled, leave blank or set to Auto to use the default black.
        /// </summary>
        public TtmlBackgroundColor BackgroundColor { get; set; }

        /// <summary>
        /// Checks to see if the BackgroundColor property is set.
        /// </summary>
        internal bool IsSetBackgroundColor() => this.BackgroundColor != null;

        /// <summary>
        /// Gets and sets the property BackgroundOpacity. Specify the opacity of the background
        /// rectangle. Enter a value from 0 to 255, where 0 is transparent and 255 is opaque.
        /// If Style passthrough is set to enabled, leave blank to pass through the background
        /// style information in your input captions to your output captions. If Style passthrough
        /// is set to disabled and backgroundColor is set, leave blank to use a value of 255 (opaque).
        /// </summary>
        [AWSProperty(Min = 0, Max = 255)]
        public int? BackgroundOpacity { get; set; }

        /// <summary>
        /// Checks to see if the BackgroundOpacity property is set.
        /// </summary>
        internal bool IsSetBackgroundOpacity() => this.BackgroundOpacity.HasValue;

        /// <summary>
        /// Gets and sets the property FontColor. Specify the color of the captions text. If Style
        /// passthrough is set to enabled, leave blank or set to Auto to pass through the font
        /// color from your input captions. If Style passthrough is set to disabled, leave blank
        /// or set to Auto to use the default white.
        /// </summary>
        public TtmlFontColor FontColor { get; set; }

        /// <summary>
        /// Checks to see if the FontColor property is set.
        /// </summary>
        internal bool IsSetFontColor() => this.FontColor != null;

        /// <summary>
        /// Gets and sets the property FontOpacity. Specify the opacity of the captions. Enter
        /// a value from 0 to 255, where 0 is transparent and 255 is opaque. If Style passthrough
        /// is set to enabled, leave blank to pass through the font opacity information in your
        /// input captions to your output captions. If Style passthrough is set to disabled and
        /// fontColor is set, leave blank to use a value of 255 (opaque).
        /// </summary>
        [AWSProperty(Min = 0, Max = 255)]
        public int? FontOpacity { get; set; }

        /// <summary>
        /// Checks to see if the FontOpacity property is set.
        /// </summary>
        internal bool IsSetFontOpacity() => this.FontOpacity.HasValue;

        /// <summary>
        /// Gets and sets the property FontSize. Specify the Font size in pixels. Must be a positive
        /// integer. Set to 0, or leave blank, for automatic font size.
        /// </summary>
        [AWSProperty(Min = 0, Max = 96)]
        public int? FontSize { get; set; }

        /// <summary>
        /// Checks to see if the FontSize property is set.
        /// </summary>
        internal bool IsSetFontSize() => this.FontSize.HasValue;

        /// <summary>
        /// Gets and sets the property FontStyle. Specify the font style of the caption text.
        /// If Style passthrough is set to enabled, leave blank to pass through the font style
        /// from your input captions. If Style passthrough is set to disabled, leave blank to
        /// use the default normal style.
        /// </summary>
        public TtmlFontStyle FontStyle { get; set; }

        /// <summary>
        /// Checks to see if the FontStyle property is set.
        /// </summary>
        internal bool IsSetFontStyle() => this.FontStyle != null;

        /// <summary>
        /// Gets and sets the property FontWeight. Specify the font weight of the caption text.
        /// If Style passthrough is set to enabled, leave blank to pass through the font weight
        /// from your input captions. If Style passthrough is set to disabled, leave blank to
        /// use the default normal weight.
        /// </summary>
        public TtmlFontWeight FontWeight { get; set; }

        /// <summary>
        /// Checks to see if the FontWeight property is set.
        /// </summary>
        internal bool IsSetFontWeight() => this.FontWeight != null;

        /// <summary>
        /// Gets and sets the property StylePassthrough. Pass through style and position information
        /// from a TTML-like input source (TTML, IMSC, SMPTE-TT) to the TTML output.
        /// </summary>
        public TtmlStylePassthrough StylePassthrough { get; set; }

        /// <summary>
        /// Checks to see if the StylePassthrough property is set.
        /// </summary>
        internal bool IsSetStylePassthrough() => this.StylePassthrough != null;

        /// <summary>
        /// Gets and sets the property TextDecoration. Specify the text decoration of the caption
        /// text. If Style passthrough is set to enabled, leave blank to pass through the text
        /// decoration from your input captions. If Style passthrough is set to disabled, leave
        /// blank to use the default of none.
        /// </summary>
        public TtmlTextDecoration TextDecoration { get; set; }

        /// <summary>
        /// Checks to see if the TextDecoration property is set.
        /// </summary>
        internal bool IsSetTextDecoration() => this.TextDecoration != null;
    }
}
