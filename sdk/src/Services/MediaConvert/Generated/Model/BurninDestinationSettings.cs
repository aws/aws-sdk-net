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
    /// Burn-In Destination Settings.
    /// </summary>
    public partial class BurninDestinationSettings
    {
        private BurninSubtitleAlignment _alignment;
        private BurninSubtitleBackgroundColor _backgroundColor;
        private int? _backgroundOpacity;
        private BurninSubtitleFontColor _fontColor;
        private int? _fontOpacity;
        private int? _fontResolution;
        private FontScript _fontScript;
        private int? _fontSize;
        private BurninSubtitleOutlineColor _outlineColor;
        private int? _outlineSize;
        private BurninSubtitleShadowColor _shadowColor;
        private int? _shadowOpacity;
        private int? _shadowXOffset;
        private int? _shadowYOffset;
        private BurninSubtitleTeletextSpacing _teletextSpacing;
        private int? _xPosition;
        private int? _yPosition;

        /// <summary>
        /// Gets and sets the property Alignment.
        /// </summary>
        public BurninSubtitleAlignment Alignment
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
        /// Gets and sets the property BackgroundColor.
        /// </summary>
        public BurninSubtitleBackgroundColor BackgroundColor
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
        /// rectangle. 255 is opaque; 0 is transparent. Leaving this parameter blank is equivalent
        /// to setting it to 0 (transparent). All burn-in and DVB-Sub font settings must match.
        /// </summary>
        public int BackgroundOpacity
        {
            get { return this._backgroundOpacity.GetValueOrDefault(); }
            set { this._backgroundOpacity = value; }
        }

        // Check to see if BackgroundOpacity property is set
        internal bool IsSetBackgroundOpacity()
        {
            return this._backgroundOpacity.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property FontColor.
        /// </summary>
        public BurninSubtitleFontColor FontColor
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
        /// 255 is opaque; 0 is transparent.All burn-in and DVB-Sub font settings must match.
        /// </summary>
        public int FontOpacity
        {
            get { return this._fontOpacity.GetValueOrDefault(); }
            set { this._fontOpacity = value; }
        }

        // Check to see if FontOpacity property is set
        internal bool IsSetFontOpacity()
        {
            return this._fontOpacity.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property FontResolution. Font resolution in DPI (dots per inch);
        /// default is 96 dpi.All burn-in and DVB-Sub font settings must match.
        /// </summary>
        public int FontResolution
        {
            get { return this._fontResolution.GetValueOrDefault(); }
            set { this._fontResolution = value; }
        }

        // Check to see if FontResolution property is set
        internal bool IsSetFontResolution()
        {
            return this._fontResolution.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property FontScript. Provide the font script, using an ISO 15924
        /// script code, if the LanguageCode is not sufficient for determining the script type.
        /// Where LanguageCode or CustomLanguageCode is sufficient, use "AUTOMATIC" or leave unset.
        /// This is used to help determine the appropriate font for rendering burn-in captions.
        /// </summary>
        public FontScript FontScript
        {
            get { return this._fontScript; }
            set { this._fontScript = value; }
        }

        // Check to see if FontScript property is set
        internal bool IsSetFontScript()
        {
            return this._fontScript != null;
        }

        /// <summary>
        /// Gets and sets the property FontSize. A positive integer indicates the exact font size
        /// in points. Set to 0 for automatic font size selection. All burn-in and DVB-Sub font
        /// settings must match.
        /// </summary>
        public int FontSize
        {
            get { return this._fontSize.GetValueOrDefault(); }
            set { this._fontSize = value; }
        }

        // Check to see if FontSize property is set
        internal bool IsSetFontSize()
        {
            return this._fontSize.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property OutlineColor.
        /// </summary>
        public BurninSubtitleOutlineColor OutlineColor
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
        public int OutlineSize
        {
            get { return this._outlineSize.GetValueOrDefault(); }
            set { this._outlineSize = value; }
        }

        // Check to see if OutlineSize property is set
        internal bool IsSetOutlineSize()
        {
            return this._outlineSize.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property ShadowColor.
        /// </summary>
        public BurninSubtitleShadowColor ShadowColor
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
        /// is opaque; 0 is transparent. Leaving this parameter blank is equivalent to setting
        /// it to 0 (transparent). All burn-in and DVB-Sub font settings must match.
        /// </summary>
        public int ShadowOpacity
        {
            get { return this._shadowOpacity.GetValueOrDefault(); }
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
        /// 2 pixels to the left. All burn-in and DVB-Sub font settings must match.
        /// </summary>
        public int ShadowXOffset
        {
            get { return this._shadowXOffset.GetValueOrDefault(); }
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
        /// 2 pixels above the text. All burn-in and DVB-Sub font settings must match.
        /// </summary>
        public int ShadowYOffset
        {
            get { return this._shadowYOffset.GetValueOrDefault(); }
            set { this._shadowYOffset = value; }
        }

        // Check to see if ShadowYOffset property is set
        internal bool IsSetShadowYOffset()
        {
            return this._shadowYOffset.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property TeletextSpacing.
        /// </summary>
        public BurninSubtitleTeletextSpacing TeletextSpacing
        {
            get { return this._teletextSpacing; }
            set { this._teletextSpacing = value; }
        }

        // Check to see if TeletextSpacing property is set
        internal bool IsSetTeletextSpacing()
        {
            return this._teletextSpacing != null;
        }

        /// <summary>
        /// Gets and sets the property XPosition. Specifies the horizontal position of the caption
        /// relative to the left side of the output in pixels. A value of 10 would result in the
        /// captions starting 10 pixels from the left of the output. If no explicit x_position
        /// is provided, the horizontal caption position will be determined by the alignment parameter.
        /// This option is not valid for source captions that are STL, 608/embedded or teletext.
        /// These source settings are already pre-defined by the caption stream. All burn-in and
        /// DVB-Sub font settings must match.
        /// </summary>
        public int XPosition
        {
            get { return this._xPosition.GetValueOrDefault(); }
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
        /// starting 10 pixels from the top of the output. If no explicit y_position is provided,
        /// the caption will be positioned towards the bottom of the output. This option is not
        /// valid for source captions that are STL, 608/embedded or teletext. These source settings
        /// are already pre-defined by the caption stream. All burn-in and DVB-Sub font settings
        /// must match.
        /// </summary>
        public int YPosition
        {
            get { return this._yPosition.GetValueOrDefault(); }
            set { this._yPosition = value; }
        }

        // Check to see if YPosition property is set
        internal bool IsSetYPosition()
        {
            return this._yPosition.HasValue; 
        }

    }
}