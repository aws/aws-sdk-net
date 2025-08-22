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
 * Do not modify this file. This file is generated from the medialive-2017-10-14.normal.json service model.
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
        private BurnInAlignment _alignment;
        private BurnInBackgroundColor _backgroundColor;
        private int? _backgroundOpacity;
        private InputLocation _font;
        private BurnInFontColor _fontColor;
        private int? _fontOpacity;
        private int? _fontResolution;
        private string _fontSize;
        private BurnInOutlineColor _outlineColor;
        private int? _outlineSize;
        private BurnInShadowColor _shadowColor;
        private int? _shadowOpacity;
        private int? _shadowXOffset;
        private int? _shadowYOffset;
        private BurnInDestinationSubtitleRows _subtitleRows;
        private BurnInTeletextGridControl _teletextGridControl;
        private int? _xPosition;
        private int? _yPosition;

        /// <summary>
        /// Gets and sets the property Alignment. If no explicit xPosition or yPosition is provided,
        /// setting alignment to centered will place the captions at the bottom center of the
        /// output. Similarly, setting a left alignment will align captions to the bottom left
        /// of the output. If x and y positions are given in conjunction with the alignment parameter,
        /// the font will be justified (either left or centered) relative to those coordinates.
        /// Selecting "smart" justification will left-justify live subtitles and center-justify
        /// pre-recorded subtitles.  All burn-in and DVB-Sub font settings must match.
        /// </summary>
        public BurnInAlignment Alignment
        {
            get { return this._alignment; }
            set { this._alignment = value; }
        }

        // Check to see if Alignment property is set
        internal bool IsSetAlignment()
        {
            return this._alignment != null;
        }

        /// <summary>
        /// Gets and sets the property BackgroundColor. Specifies the color of the rectangle behind
        /// the captions.  All burn-in and DVB-Sub font settings must match.
        /// </summary>
        public BurnInBackgroundColor BackgroundColor
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
        /// Gets and sets the property BackgroundOpacity. Specifies the opacity of the background
        /// rectangle. 255 is opaque; 0 is transparent. Leaving this parameter out is equivalent
        /// to setting it to 0 (transparent).  All burn-in and DVB-Sub font settings must match.
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
        /// Gets and sets the property Font. External font file used for caption burn-in. File
        /// extension must be 'ttf' or 'tte'.  Although the user can select output fonts for many
        /// different types of input captions,  embedded, STL and teletext sources use a strict
        /// grid system. Using external fonts with these caption sources could cause unexpected
        /// display of proportional fonts.  All burn-in and DVB-Sub font settings must match.
        /// </summary>
        public InputLocation Font
        {
            get { return this._font; }
            set { this._font = value; }
        }

        // Check to see if Font property is set
        internal bool IsSetFont()
        {
            return this._font != null;
        }

        /// <summary>
        /// Gets and sets the property FontColor. Specifies the color of the burned-in captions.
        ///  This option is not valid for source captions that are STL, 608/embedded or teletext.
        ///  These source settings are already pre-defined by the caption stream.  All burn-in
        /// and DVB-Sub font settings must match.
        /// </summary>
        public BurnInFontColor FontColor
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
        /// Gets and sets the property FontOpacity. Specifies the opacity of the burned-in captions.
        /// 255 is opaque; 0 is transparent.  All burn-in and DVB-Sub font settings must match.
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
        /// Gets and sets the property FontResolution. Font resolution in DPI (dots per inch);
        /// default is 96 dpi.  All burn-in and DVB-Sub font settings must match.
        /// </summary>
        [AWSProperty(Min=96, Max=600)]
        public int? FontResolution
        {
            get { return this._fontResolution; }
            set { this._fontResolution = value; }
        }

        // Check to see if FontResolution property is set
        internal bool IsSetFontResolution()
        {
            return this._fontResolution.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property FontSize. When set to 'auto' fontSize will scale depending
        /// on the size of the output.  Giving a positive integer will specify the exact font
        /// size in points.  All burn-in and DVB-Sub font settings must match.
        /// </summary>
        public string FontSize
        {
            get { return this._fontSize; }
            set { this._fontSize = value; }
        }

        // Check to see if FontSize property is set
        internal bool IsSetFontSize()
        {
            return this._fontSize != null;
        }

        /// <summary>
        /// Gets and sets the property OutlineColor. Specifies font outline color. This option
        /// is not valid for source captions that are either 608/embedded or teletext. These source
        /// settings are already pre-defined by the caption stream. All burn-in and DVB-Sub font
        /// settings must match.
        /// </summary>
        public BurnInOutlineColor OutlineColor
        {
            get { return this._outlineColor; }
            set { this._outlineColor = value; }
        }

        // Check to see if OutlineColor property is set
        internal bool IsSetOutlineColor()
        {
            return this._outlineColor != null;
        }

        /// <summary>
        /// Gets and sets the property OutlineSize. Specifies font outline size in pixels. This
        /// option is not valid for source captions that are either 608/embedded or teletext.
        /// These source settings are already pre-defined by the caption stream. All burn-in and
        /// DVB-Sub font settings must match.
        /// </summary>
        [AWSProperty(Min=0, Max=10)]
        public int? OutlineSize
        {
            get { return this._outlineSize; }
            set { this._outlineSize = value; }
        }

        // Check to see if OutlineSize property is set
        internal bool IsSetOutlineSize()
        {
            return this._outlineSize.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property ShadowColor. Specifies the color of the shadow cast by
        /// the captions.  All burn-in and DVB-Sub font settings must match.
        /// </summary>
        public BurnInShadowColor ShadowColor
        {
            get { return this._shadowColor; }
            set { this._shadowColor = value; }
        }

        // Check to see if ShadowColor property is set
        internal bool IsSetShadowColor()
        {
            return this._shadowColor != null;
        }

        /// <summary>
        /// Gets and sets the property ShadowOpacity. Specifies the opacity of the shadow. 255
        /// is opaque; 0 is transparent. Leaving this parameter out is equivalent to setting it
        /// to 0 (transparent).  All burn-in and DVB-Sub font settings must match.
        /// </summary>
        [AWSProperty(Min=0, Max=255)]
        public int? ShadowOpacity
        {
            get { return this._shadowOpacity; }
            set { this._shadowOpacity = value; }
        }

        // Check to see if ShadowOpacity property is set
        internal bool IsSetShadowOpacity()
        {
            return this._shadowOpacity.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property ShadowXOffset. Specifies the horizontal offset of the shadow
        /// relative to the captions in pixels. A value of -2 would result in a shadow offset
        /// 2 pixels to the left.  All burn-in and DVB-Sub font settings must match.
        /// </summary>
        public int? ShadowXOffset
        {
            get { return this._shadowXOffset; }
            set { this._shadowXOffset = value; }
        }

        // Check to see if ShadowXOffset property is set
        internal bool IsSetShadowXOffset()
        {
            return this._shadowXOffset.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property ShadowYOffset. Specifies the vertical offset of the shadow
        /// relative to the captions in pixels. A value of -2 would result in a shadow offset
        /// 2 pixels above the text.  All burn-in and DVB-Sub font settings must match.
        /// </summary>
        public int? ShadowYOffset
        {
            get { return this._shadowYOffset; }
            set { this._shadowYOffset = value; }
        }

        // Check to see if ShadowYOffset property is set
        internal bool IsSetShadowYOffset()
        {
            return this._shadowYOffset.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property SubtitleRows. Applies only when the input captions are
        /// Teletext and the output captions are DVB-Sub or Burn-In. Choose the number of lines
        /// for the captions bitmap. The captions bitmap is 700 wide × 576 high and will be laid
        /// over the video. For example, a value of 16 divides the bitmap into 16 lines, with
        /// each line 36 pixels high (16 × 36 = 576). The default is 24 (24 pixels high). Enter
        /// the same number in every encode in every output that converts the same Teletext source
        /// to DVB-Sub or Burn-in.
        /// </summary>
        public BurnInDestinationSubtitleRows SubtitleRows
        {
            get { return this._subtitleRows; }
            set { this._subtitleRows = value; }
        }

        // Check to see if SubtitleRows property is set
        internal bool IsSetSubtitleRows()
        {
            return this._subtitleRows != null;
        }

        /// <summary>
        /// Gets and sets the property TeletextGridControl. Controls whether a fixed grid size
        /// will be used to generate the output subtitles bitmap. Only applicable for Teletext
        /// inputs and DVB-Sub/Burn-in outputs.
        /// </summary>
        public BurnInTeletextGridControl TeletextGridControl
        {
            get { return this._teletextGridControl; }
            set { this._teletextGridControl = value; }
        }

        // Check to see if TeletextGridControl property is set
        internal bool IsSetTeletextGridControl()
        {
            return this._teletextGridControl != null;
        }

        /// <summary>
        /// Gets and sets the property XPosition. Specifies the horizontal position of the caption
        /// relative to the left side of the output in pixels. A value of 10 would result in the
        /// captions starting 10 pixels from the left of the output. If no explicit xPosition
        /// is provided, the horizontal caption position will be determined by the alignment parameter.
        ///  All burn-in and DVB-Sub font settings must match.
        /// </summary>
        [AWSProperty(Min=0)]
        public int? XPosition
        {
            get { return this._xPosition; }
            set { this._xPosition = value; }
        }

        // Check to see if XPosition property is set
        internal bool IsSetXPosition()
        {
            return this._xPosition.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property YPosition. Specifies the vertical position of the caption
        /// relative to the top of the output in pixels. A value of 10 would result in the captions
        /// starting 10 pixels from the top of the output. If no explicit yPosition is provided,
        /// the caption will be positioned towards the bottom of the output.  All burn-in and
        /// DVB-Sub font settings must match.
        /// </summary>
        [AWSProperty(Min=0)]
        public int? YPosition
        {
            get { return this._yPosition; }
            set { this._yPosition = value; }
        }

        // Check to see if YPosition property is set
        internal bool IsSetYPosition()
        {
            return this._yPosition.HasValue; 
        }

    }
}