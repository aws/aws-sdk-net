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

namespace Amazon.MediaLive.Model
{
    /// <summary>
    /// Burn In Destination Settings
    /// </summary>
    public partial class BurnInDestinationSettings
    {
        /// <summary>
        /// Gets and sets the property Alignment. If no explicit xPosition or yPosition is provided,
        /// setting alignment to centered will place the captions at the bottom center of the
        /// output. Similarly, setting a left alignment will align captions to the bottom left
        /// of the output. If x and y positions are given in conjunction with the alignment parameter,
        /// the font will be justified (either left or centered) relative to those coordinates.
        /// Selecting "smart" justification will left-justify live subtitles and center-justify
        /// pre-recorded subtitles. All burn-in and DVB-Sub font settings must match.
        /// </summary>
        public BurnInAlignment Alignment { get; set; }

        /// <summary>
        /// Checks to see if the Alignment property is set.
        /// </summary>
        internal bool IsSetAlignment() => this.Alignment != null;

        /// <summary>
        /// Gets and sets the property BackgroundColor. Specifies the color of the rectangle behind
        /// the captions. All burn-in and DVB-Sub font settings must match.
        /// </summary>
        public BurnInBackgroundColor BackgroundColor { get; set; }

        /// <summary>
        /// Checks to see if the BackgroundColor property is set.
        /// </summary>
        internal bool IsSetBackgroundColor() => this.BackgroundColor != null;

        /// <summary>
        /// Gets and sets the property BackgroundOpacity. Specifies the opacity of the background
        /// rectangle. 255 is opaque; 0 is transparent. Leaving this parameter out is equivalent
        /// to setting it to 0 (transparent). All burn-in and DVB-Sub font settings must match.
        /// </summary>
        public int? BackgroundOpacity { get; set; }

        /// <summary>
        /// Checks to see if the BackgroundOpacity property is set.
        /// </summary>
        internal bool IsSetBackgroundOpacity() => this.BackgroundOpacity.HasValue;

        /// <summary>
        /// Gets and sets the property Font. External font file used for caption burn-in. File
        /// extension must be 'ttf' or 'tte'. Although the user can select output fonts for many
        /// different types of input captions, embedded, STL and teletext sources use a strict
        /// grid system. Using external fonts with these caption sources could cause unexpected
        /// display of proportional fonts. All burn-in and DVB-Sub font settings must match.
        /// </summary>
        public InputLocation Font { get; set; }

        /// <summary>
        /// Checks to see if the Font property is set.
        /// </summary>
        internal bool IsSetFont() => this.Font != null;

        /// <summary>
        /// Gets and sets the property FontColor. Specifies the color of the burned-in captions.
        /// This option is not valid for source captions that are STL, 608/embedded or teletext.
        /// These source settings are already pre-defined by the caption stream. All burn-in and
        /// DVB-Sub font settings must match.
        /// </summary>
        public BurnInFontColor FontColor { get; set; }

        /// <summary>
        /// Checks to see if the FontColor property is set.
        /// </summary>
        internal bool IsSetFontColor() => this.FontColor != null;

        /// <summary>
        /// Gets and sets the property FontOpacity. Specifies the opacity of the burned-in captions.
        /// 255 is opaque; 0 is transparent. All burn-in and DVB-Sub font settings must match.
        /// </summary>
        public int? FontOpacity { get; set; }

        /// <summary>
        /// Checks to see if the FontOpacity property is set.
        /// </summary>
        internal bool IsSetFontOpacity() => this.FontOpacity.HasValue;

        /// <summary>
        /// Gets and sets the property FontResolution. Font resolution in DPI (dots per inch);
        /// default is 96 dpi. All burn-in and DVB-Sub font settings must match.
        /// </summary>
        public int? FontResolution { get; set; }

        /// <summary>
        /// Checks to see if the FontResolution property is set.
        /// </summary>
        internal bool IsSetFontResolution() => this.FontResolution.HasValue;

        /// <summary>
        /// Gets and sets the property FontSize. When set to 'auto' fontSize will scale depending
        /// on the size of the output. Giving a positive integer will specify the exact font size
        /// in points. All burn-in and DVB-Sub font settings must match.
        /// </summary>
        public string FontSize { get; set; }

        /// <summary>
        /// Checks to see if the FontSize property is set.
        /// </summary>
        internal bool IsSetFontSize() => this.FontSize != null;

        /// <summary>
        /// Gets and sets the property OutlineColor. Specifies font outline color. This option
        /// is not valid for source captions that are either 608/embedded or teletext. These source
        /// settings are already pre-defined by the caption stream. All burn-in and DVB-Sub font
        /// settings must match.
        /// </summary>
        public BurnInOutlineColor OutlineColor { get; set; }

        /// <summary>
        /// Checks to see if the OutlineColor property is set.
        /// </summary>
        internal bool IsSetOutlineColor() => this.OutlineColor != null;

        /// <summary>
        /// Gets and sets the property OutlineSize. Specifies font outline size in pixels. This
        /// option is not valid for source captions that are either 608/embedded or teletext.
        /// These source settings are already pre-defined by the caption stream. All burn-in and
        /// DVB-Sub font settings must match.
        /// </summary>
        public int? OutlineSize { get; set; }

        /// <summary>
        /// Checks to see if the OutlineSize property is set.
        /// </summary>
        internal bool IsSetOutlineSize() => this.OutlineSize.HasValue;

        /// <summary>
        /// Gets and sets the property ShadowColor. Specifies the color of the shadow cast by
        /// the captions. All burn-in and DVB-Sub font settings must match.
        /// </summary>
        public BurnInShadowColor ShadowColor { get; set; }

        /// <summary>
        /// Checks to see if the ShadowColor property is set.
        /// </summary>
        internal bool IsSetShadowColor() => this.ShadowColor != null;

        /// <summary>
        /// Gets and sets the property ShadowOpacity. Specifies the opacity of the shadow. 255
        /// is opaque; 0 is transparent. Leaving this parameter out is equivalent to setting it
        /// to 0 (transparent). All burn-in and DVB-Sub font settings must match.
        /// </summary>
        public int? ShadowOpacity { get; set; }

        /// <summary>
        /// Checks to see if the ShadowOpacity property is set.
        /// </summary>
        internal bool IsSetShadowOpacity() => this.ShadowOpacity.HasValue;

        /// <summary>
        /// Gets and sets the property ShadowXOffset. Specifies the horizontal offset of the shadow
        /// relative to the captions in pixels. A value of -2 would result in a shadow offset
        /// 2 pixels to the left. All burn-in and DVB-Sub font settings must match.
        /// </summary>
        public int? ShadowXOffset { get; set; }

        /// <summary>
        /// Checks to see if the ShadowXOffset property is set.
        /// </summary>
        internal bool IsSetShadowXOffset() => this.ShadowXOffset.HasValue;

        /// <summary>
        /// Gets and sets the property ShadowYOffset. Specifies the vertical offset of the shadow
        /// relative to the captions in pixels. A value of -2 would result in a shadow offset
        /// 2 pixels above the text. All burn-in and DVB-Sub font settings must match.
        /// </summary>
        public int? ShadowYOffset { get; set; }

        /// <summary>
        /// Checks to see if the ShadowYOffset property is set.
        /// </summary>
        internal bool IsSetShadowYOffset() => this.ShadowYOffset.HasValue;

        /// <summary>
        /// Gets and sets the property SubtitleRows. Applies only when the input captions are
        /// Teletext and the output captions are DVB-Sub or Burn-In. Choose the number of lines
        /// for the captions bitmap. The captions bitmap is 700 wide × 576 high and will be laid
        /// over the video. For example, a value of 16 divides the bitmap into 16 lines, with
        /// each line 36 pixels high (16 × 36 = 576). The default is 24 (24 pixels high). Enter
        /// the same number in every encode in every output that converts the same Teletext source
        /// to DVB-Sub or Burn-in.
        /// </summary>
        public BurnInDestinationSubtitleRows SubtitleRows { get; set; }

        /// <summary>
        /// Checks to see if the SubtitleRows property is set.
        /// </summary>
        internal bool IsSetSubtitleRows() => this.SubtitleRows != null;

        /// <summary>
        /// Gets and sets the property TeletextGridControl. Controls whether a fixed grid size
        /// will be used to generate the output subtitles bitmap. Only applicable for Teletext
        /// inputs and DVB-Sub/Burn-in outputs.
        /// </summary>
        public BurnInTeletextGridControl TeletextGridControl { get; set; }

        /// <summary>
        /// Checks to see if the TeletextGridControl property is set.
        /// </summary>
        internal bool IsSetTeletextGridControl() => this.TeletextGridControl != null;

        /// <summary>
        /// Gets and sets the property XPosition. Specifies the horizontal position of the caption
        /// relative to the left side of the output in pixels. A value of 10 would result in the
        /// captions starting 10 pixels from the left of the output. If no explicit xPosition
        /// is provided, the horizontal caption position will be determined by the alignment parameter.
        /// All burn-in and DVB-Sub font settings must match.
        /// </summary>
        public int? XPosition { get; set; }

        /// <summary>
        /// Checks to see if the XPosition property is set.
        /// </summary>
        internal bool IsSetXPosition() => this.XPosition.HasValue;

        /// <summary>
        /// Gets and sets the property YPosition. Specifies the vertical position of the caption
        /// relative to the top of the output in pixels. A value of 10 would result in the captions
        /// starting 10 pixels from the top of the output. If no explicit yPosition is provided,
        /// the caption will be positioned towards the bottom of the output. All burn-in and DVB-Sub
        /// font settings must match.
        /// </summary>
        public int? YPosition { get; set; }

        /// <summary>
        /// Checks to see if the YPosition property is set.
        /// </summary>
        internal bool IsSetYPosition() => this.YPosition.HasValue;
    }
}
