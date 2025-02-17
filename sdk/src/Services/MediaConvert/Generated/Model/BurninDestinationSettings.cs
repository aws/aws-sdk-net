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
    /// Burn-in is a captions delivery method, rather than a captions format. Burn-in writes
    /// the captions directly on your video frames, replacing pixels of video content with
    /// the captions. Set up burn-in captions in the same output as your video. For more information,
    /// see https://docs.aws.amazon.com/mediaconvert/latest/ug/burn-in-output-captions.html.
    /// </summary>
    public partial class BurninDestinationSettings
    {
        private BurninSubtitleAlignment _alignment;
        private BurninSubtitleApplyFontColor _applyFontColor;
        private BurninSubtitleBackgroundColor _backgroundColor;
        private int? _backgroundOpacity;
        private BurninSubtitleFallbackFont _fallbackFont;
        private BurninSubtitleFontColor _fontColor;
        private string _fontFileBold;
        private string _fontFileBoldItalic;
        private string _fontFileItalic;
        private string _fontFileRegular;
        private int? _fontOpacity;
        private int? _fontResolution;
        private FontScript _fontScript;
        private int? _fontSize;
        private string _hexFontColor;
        private BurninSubtitleOutlineColor _outlineColor;
        private int? _outlineSize;
        private RemoveRubyReserveAttributes _removeRubyReserveAttributes;
        private BurninSubtitleShadowColor _shadowColor;
        private int? _shadowOpacity;
        private int? _shadowXOffset;
        private int? _shadowYOffset;
        private BurnInSubtitleStylePassthrough _stylePassthrough;
        private BurninSubtitleTeletextSpacing _teletextSpacing;
        private int? _xPosition;
        private int? _yPosition;

        /// <summary>
        /// Gets and sets the property Alignment. Specify the alignment of your captions. If no
        /// explicit x_position is provided, setting alignment to centered will placethe captions
        /// at the bottom center of the output. Similarly, setting a left alignment willalign
        /// captions to the bottom left of the output. If x and y positions are given in conjunction
        /// with the alignment parameter, the font will be justified (either left or centered)
        /// relative to those coordinates.
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
        /// Gets and sets the property ApplyFontColor. Ignore this setting unless Style passthrough
        /// is set to Enabled and Font color set to Black, Yellow, Red, Green, Blue, or Hex. Use
        /// Apply font color for additional font color controls. When you choose White text only,
        /// or leave blank, your font color setting only applies to white text in your input captions.
        /// For example, if your font color setting is Yellow, and your input captions have red
        /// and white text, your output captions will have red and yellow text. When you choose
        /// ALL_TEXT, your font color setting applies to all of your output captions text.
        /// </summary>
        public BurninSubtitleApplyFontColor ApplyFontColor
        {
            get { return this._applyFontColor; }
            set { this._applyFontColor = value; }
        }

        // Check to see if ApplyFontColor property is set
        internal bool IsSetApplyFontColor()
        {
            return this._applyFontColor != null;
        }

        /// <summary>
        /// Gets and sets the property BackgroundColor. Specify the color of the rectangle behind
        /// the captions. Leave background color blank and set Style passthrough to enabled to
        /// use the background color data from your input captions, if present.
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
        /// Gets and sets the property BackgroundOpacity. Specify the opacity of the background
        /// rectangle. Enter a value from 0 to 255, where 0 is transparent and 255 is opaque.
        /// If Style passthrough is set to enabled, leave blank to pass through the background
        /// style information in your input captions to your output captions. If Style passthrough
        /// is set to disabled, leave blank to use a value of 0 and remove all backgrounds from
        /// your output captions.
        /// </summary>
        [AWSProperty(Min=0, Max=255)]
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
        /// Gets and sets the property FallbackFont. Specify the font that you want the service
        /// to use for your burn in captions when your input captions specify a font that MediaConvert
        /// doesn't support. When you set Fallback font to best match, or leave blank, MediaConvert
        /// uses a supported font that most closely matches the font that your input captions
        /// specify. When there are multiple unsupported fonts in your input captions, MediaConvert
        /// matches each font with the supported font that matches best. When you explicitly choose
        /// a replacement font, MediaConvert uses that font to replace all unsupported fonts from
        /// your input.
        /// </summary>
        public BurninSubtitleFallbackFont FallbackFont
        {
            get { return this._fallbackFont; }
            set { this._fallbackFont = value; }
        }

        // Check to see if FallbackFont property is set
        internal bool IsSetFallbackFont()
        {
            return this._fallbackFont != null;
        }

        /// <summary>
        /// Gets and sets the property FontColor. Specify the color of the burned-in captions
        /// text. Leave Font color blank and set Style passthrough to enabled to use the font
        /// color data from your input captions, if present.
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
        /// Gets and sets the property FontFileBold. Specify a bold TrueType font file to use
        /// when rendering your output captions. Enter an S3, HTTP, or HTTPS URL. When you do,
        /// you must also separately specify a regular, an italic, and a bold italic font file.
        /// </summary>
        public string FontFileBold
        {
            get { return this._fontFileBold; }
            set { this._fontFileBold = value; }
        }

        // Check to see if FontFileBold property is set
        internal bool IsSetFontFileBold()
        {
            return this._fontFileBold != null;
        }

        /// <summary>
        /// Gets and sets the property FontFileBoldItalic. Specify a bold italic TrueType font
        /// file to use when rendering your output captions.Enter an S3, HTTP, or HTTPS URL.When
        /// you do, you must also separately specify a regular, a bold, and an italic font file.
        /// </summary>
        public string FontFileBoldItalic
        {
            get { return this._fontFileBoldItalic; }
            set { this._fontFileBoldItalic = value; }
        }

        // Check to see if FontFileBoldItalic property is set
        internal bool IsSetFontFileBoldItalic()
        {
            return this._fontFileBoldItalic != null;
        }

        /// <summary>
        /// Gets and sets the property FontFileItalic. Specify an italic TrueType font file to
        /// use when rendering your output captions. Enter an S3, HTTP, or HTTPS URL. When you
        /// do, you must also separately specify a regular, a bold, and a bold italic font file.
        /// </summary>
        public string FontFileItalic
        {
            get { return this._fontFileItalic; }
            set { this._fontFileItalic = value; }
        }

        // Check to see if FontFileItalic property is set
        internal bool IsSetFontFileItalic()
        {
            return this._fontFileItalic != null;
        }

        /// <summary>
        /// Gets and sets the property FontFileRegular. Specify a regular TrueType font file to
        /// use when rendering your output captions. Enter an S3, HTTP, or HTTPS URL. When you
        /// do, you must also separately specify a bold, an italic, and a bold italic font file.
        /// </summary>
        public string FontFileRegular
        {
            get { return this._fontFileRegular; }
            set { this._fontFileRegular = value; }
        }

        // Check to see if FontFileRegular property is set
        internal bool IsSetFontFileRegular()
        {
            return this._fontFileRegular != null;
        }

        /// <summary>
        /// Gets and sets the property FontOpacity. Specify the opacity of the burned-in captions.
        /// 255 is opaque; 0 is transparent.
        /// </summary>
        [AWSProperty(Min=0, Max=255)]
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
        /// Gets and sets the property FontResolution. Specify the Font resolution in DPI (dots
        /// per inch).
        /// </summary>
        [AWSProperty(Min=96, Max=600)]
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
        /// Gets and sets the property FontScript. Set Font script to Automatically determined,
        /// or leave blank, to automatically determine the font script in your input captions.
        /// Otherwise, set to Simplified Chinese (HANS) or Traditional Chinese (HANT) if your
        /// input font script uses Simplified or Traditional Chinese.
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
        /// Gets and sets the property FontSize. Specify the Font size in pixels. Must be a positive
        /// integer. Set to 0, or leave blank, for automatic font size.
        /// </summary>
        [AWSProperty(Min=0, Max=96)]
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
        /// Gets and sets the property HexFontColor. Ignore this setting unless your Font color
        /// is set to Hex. Enter either six or eight hexidecimal digits, representing red, green,
        /// and blue, with two optional extra digits for alpha. For example a value of 1122AABB
        /// is a red value of 0x11, a green value of 0x22, a blue value of 0xAA, and an alpha
        /// value of 0xBB.
        /// </summary>
        [AWSProperty(Min=6, Max=8)]
        public string HexFontColor
        {
            get { return this._hexFontColor; }
            set { this._hexFontColor = value; }
        }

        // Check to see if HexFontColor property is set
        internal bool IsSetHexFontColor()
        {
            return this._hexFontColor != null;
        }

        /// <summary>
        /// Gets and sets the property OutlineColor. Specify font outline color. Leave Outline
        /// color blank and set Style passthrough to enabled to use the font outline color data
        /// from your input captions, if present.
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
        /// Gets and sets the property OutlineSize. Specify the Outline size of the caption text,
        /// in pixels. Leave Outline size blank and set Style passthrough to enabled to use the
        /// outline size data from your input captions, if present.
        /// </summary>
        [AWSProperty(Min=0, Max=10)]
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
        /// Gets and sets the property RemoveRubyReserveAttributes. Optionally remove any tts:rubyReserve
        /// attributes present in your input, that do   not have a tts:ruby attribute in the same
        /// element, from your output. Use if your vertical Japanese output captions have alignment
        /// issues. To remove ruby reserve attributes when present: Choose Enabled. To not remove
        /// any ruby reserve attributes: Keep the default value, Disabled.
        /// </summary>
        public RemoveRubyReserveAttributes RemoveRubyReserveAttributes
        {
            get { return this._removeRubyReserveAttributes; }
            set { this._removeRubyReserveAttributes = value; }
        }

        // Check to see if RemoveRubyReserveAttributes property is set
        internal bool IsSetRemoveRubyReserveAttributes()
        {
            return this._removeRubyReserveAttributes != null;
        }

        /// <summary>
        /// Gets and sets the property ShadowColor. Specify the color of the shadow cast by the
        /// captions. Leave Shadow color blank and set Style passthrough to enabled to use the
        /// shadow color data from your input captions, if present.
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
        /// Gets and sets the property ShadowOpacity. Specify the opacity of the shadow. Enter
        /// a value from 0 to 255, where 0 is transparent and 255 is opaque. If Style passthrough
        /// is set to Enabled, leave Shadow opacity blank to pass through the shadow style information
        /// in your input captions to your output captions. If Style passthrough is set to disabled,
        /// leave blank to use a value of 0 and remove all shadows from your output captions.
        /// </summary>
        [AWSProperty(Min=0, Max=255)]
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
        /// Gets and sets the property ShadowXOffset. Specify the horizontal offset of the shadow,
        /// relative to the captions in pixels. A value of -2 would result in a shadow offset
        /// 2 pixels to the left.
        /// </summary>
        [AWSProperty(Min=-2147483648, Max=2147483647)]
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
        /// Gets and sets the property ShadowYOffset. Specify the vertical offset of the shadow
        /// relative to the captions in pixels. A value of -2 would result in a shadow offset
        /// 2 pixels above the text. Leave Shadow y-offset blank and set Style passthrough to
        /// enabled to use the shadow y-offset data from your input captions, if present.
        /// </summary>
        [AWSProperty(Min=-2147483648, Max=2147483647)]
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
        /// Gets and sets the property StylePassthrough. To use the available style, color, and
        /// position information from your input captions: Set Style passthrough to Enabled. Note
        /// that MediaConvert uses default settings for any missing style or position information
        /// in your input captions To ignore the style and position information from your input
        /// captions and use default settings: Leave blank or keep the default value, Disabled.
        /// Default settings include white text with black outlining, bottom-center positioning,
        /// and automatic sizing. Whether you set Style passthrough to enabled or not, you can
        /// also choose to manually override any of the individual style and position settings.
        /// You can also override any fonts by manually specifying custom font files.
        /// </summary>
        public BurnInSubtitleStylePassthrough StylePassthrough
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
        /// Gets and sets the property TeletextSpacing. Specify whether the text spacing in your
        /// captions is set by the captions grid, or varies depending on letter width. Choose
        /// fixed grid to conform to the spacing specified in the captions file more accurately.
        /// Choose proportional to make the text easier to read for closed captions.
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
        /// Gets and sets the property XPosition. Specify the horizontal position of the captions,
        /// relative to the left side of the output in pixels. A value of 10 would result in the
        /// captions starting 10 pixels from the left of the output. If no explicit x_position
        /// is provided, the horizontal caption position will be determined by the alignment parameter.
        /// </summary>
        [AWSProperty(Min=0, Max=2147483647)]
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
        /// Gets and sets the property YPosition. Specify the vertical position of the captions,
        /// relative to the top of the output in pixels. A value of 10 would result in the captions
        /// starting 10 pixels from the top of the output. If no explicit y_position is provided,
        /// the caption will be positioned towards the bottom of the output.
        /// </summary>
        [AWSProperty(Min=0, Max=2147483647)]
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