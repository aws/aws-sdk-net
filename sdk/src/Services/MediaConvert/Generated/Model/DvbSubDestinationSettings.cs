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

namespace Amazon.MediaConvert.Model
{
    /// <summary>
    /// Settings related to DVB-Sub captions. Set up DVB-Sub captions in the same output as
    /// your video. For more information, see https://docs.aws.amazon.com/mediaconvert/latest/ug/dvb-sub-output-captions.html.
    /// When you work directly in your JSON job specification, include this object and any
    /// required children when you set destinationType to DVB_SUB.
    /// </summary>
    public partial class DvbSubDestinationSettings
    {
        private DvbSubtitleAlignment _alignment;
        private DvbSubtitleApplyFontColor _applyFontColor;
        private DvbSubtitleBackgroundColor _backgroundColor;
        private int? _backgroundOpacity;
        private DvbddsHandling _ddsHandling;
        private int? _ddsXCoordinate;
        private int? _ddsYCoordinate;
        private DvbSubSubtitleFallbackFont _fallbackFont;
        private DvbSubtitleFontColor _fontColor;
        private int? _fontOpacity;
        private int? _fontResolution;
        private FontScript _fontScript;
        private int? _fontSize;
        private int? _height;
        private string _hexFontColor;
        private DvbSubtitleOutlineColor _outlineColor;
        private int? _outlineSize;
        private DvbSubtitleShadowColor _shadowColor;
        private int? _shadowOpacity;
        private int? _shadowXOffset;
        private int? _shadowYOffset;
        private DvbSubtitleStylePassthrough _stylePassthrough;
        private DvbSubtitlingType _subtitlingType;
        private DvbSubtitleTeletextSpacing _teletextSpacing;
        private int? _width;
        private int? _xPosition;
        private int? _yPosition;

        /// <summary>
        /// Gets and sets the property Alignment. Specify the alignment of your captions. If no
        /// explicit x_position is provided, setting alignment to centered will placethe captions
        /// at the bottom center of the output. Similarly, setting a left alignment willalign
        /// captions to the bottom left of the output. If x and y positions are given in conjunction
        /// with the alignment parameter, the font will be justified (either left or centered)
        /// relative to those coordinates. Within your job settings, all of your DVB-Sub settings
        /// must be identical.
        /// </summary>
        public DvbSubtitleAlignment Alignment
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
        /// Gets and sets the property ApplyFontColor. Ignore this setting unless Style Passthrough
        /// (StylePassthrough) is set to Enabled and Font color (FontColor) set to Black, Yellow,
        /// Red, Green, Blue, or Hex. Use Apply font color (ApplyFontColor) for additional font
        /// color controls. When you choose White text only (WHITE_TEXT_ONLY), or leave blank,
        /// your font color setting only applies to white text in your input captions. For example,
        /// if your font color setting is Yellow, and your input captions have red and white text,
        /// your output captions will have red and yellow text. When you choose ALL_TEXT, your
        /// font color setting applies to all of your output captions text.
        /// </summary>
        public DvbSubtitleApplyFontColor ApplyFontColor
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
        /// the captions. Leave background color (BackgroundColor) blank and set Style passthrough
        /// (StylePassthrough) to enabled to use the background color data from your input captions,
        /// if present.
        /// </summary>
        public DvbSubtitleBackgroundColor BackgroundColor
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
        /// If Style passthrough (StylePassthrough) is set to enabled, leave blank to pass through
        /// the background style information in your input captions to your output captions. If
        /// Style passthrough is set to disabled, leave blank to use a value of 0 and remove all
        /// backgrounds from your output captions. Within your job settings, all of your DVB-Sub
        /// settings must be identical.
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
        /// Gets and sets the property DdsHandling. Specify how MediaConvert handles the display
        /// definition segment (DDS). To exclude the DDS from this set of captions: Keep the default,
        /// None. To include the DDS: Choose Specified. When you do, also specify the offset coordinates
        /// of the display window with DDS x-coordinate and DDS y-coordinate. To include the DDS,
        /// but not include display window data: Choose No display window. When you do, you can
        /// write position metadata to the page composition segment (PCS) with DDS x-coordinate
        /// and DDS y-coordinate. For video resolutions with a height of 576 pixels or less, MediaConvert
        /// doesn't include the DDS, regardless of the value you choose for DDS handling. All
        /// burn-in and DVB-Sub font settings must match.
        /// </summary>
        public DvbddsHandling DdsHandling
        {
            get { return this._ddsHandling; }
            set { this._ddsHandling = value; }
        }

        // Check to see if DdsHandling property is set
        internal bool IsSetDdsHandling()
        {
            return this._ddsHandling != null;
        }

        /// <summary>
        /// Gets and sets the property DdsXCoordinate. Use this setting, along with DDS y-coordinate
        /// (ddsYCoordinate), to specify the upper left corner of the display definition segment
        /// (DDS) display window. With this setting, specify the distance, in pixels, between
        /// the left side of the frame and the left side of the DDS display window. Keep the default
        /// value, 0, to have MediaConvert automatically choose this offset. Related setting:
        /// When you use this setting, you must set DDS handling (ddsHandling) to a value other
        /// than None (NONE). MediaConvert uses these values to determine whether to write page
        /// position data to the DDS or to the page composition segment (PCS). All burn-in and
        /// DVB-Sub font settings must match.
        /// </summary>
        [AWSProperty(Min=0, Max=2147483647)]
        public int DdsXCoordinate
        {
            get { return this._ddsXCoordinate.GetValueOrDefault(); }
            set { this._ddsXCoordinate = value; }
        }

        // Check to see if DdsXCoordinate property is set
        internal bool IsSetDdsXCoordinate()
        {
            return this._ddsXCoordinate.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property DdsYCoordinate. Use this setting, along with DDS x-coordinate
        /// (ddsXCoordinate), to specify the upper left corner of the display definition segment
        /// (DDS) display window. With this setting, specify the distance, in pixels, between
        /// the top of the frame and the top of the DDS display window. Keep the default value,
        /// 0, to have MediaConvert automatically choose this offset. Related setting: When you
        /// use this setting, you must set DDS handling (ddsHandling) to a value other than None
        /// (NONE). MediaConvert uses these values to determine whether to write page position
        /// data to the DDS or to the page composition segment (PCS). All burn-in and DVB-Sub
        /// font settings must match.
        /// </summary>
        [AWSProperty(Min=0, Max=2147483647)]
        public int DdsYCoordinate
        {
            get { return this._ddsYCoordinate.GetValueOrDefault(); }
            set { this._ddsYCoordinate = value; }
        }

        // Check to see if DdsYCoordinate property is set
        internal bool IsSetDdsYCoordinate()
        {
            return this._ddsYCoordinate.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property FallbackFont. Specify the font that you want the service
        /// to use for your burn in captions when your input captions specify a font that MediaConvert
        /// doesn't support. When you set Fallback font (FallbackFont) to best match (BEST_MATCH),
        /// or leave blank, MediaConvert uses a supported font that most closely matches the font
        /// that your input captions specify. When there are multiple unsupported fonts in your
        /// input captions, MediaConvert matches each font with the supported font that matches
        /// best. When you explicitly choose a replacement font, MediaConvert uses that font to
        /// replace all unsupported fonts from your input.
        /// </summary>
        public DvbSubSubtitleFallbackFont FallbackFont
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
        /// Gets and sets the property FontColor. Specify the color of the captions text. Leave
        /// Font color (FontColor) blank and set Style passthrough (StylePassthrough) to enabled
        /// to use the font color data from your input captions, if present. Within your job settings,
        /// all of your DVB-Sub settings must be identical.
        /// </summary>
        public DvbSubtitleFontColor FontColor
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
        /// Gets and sets the property FontOpacity. Specify the opacity of the burned-in captions.
        /// 255 is opaque; 0 is transparent.Within your job settings, all of your DVB-Sub settings
        /// must be identical.
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
        /// Gets and sets the property FontResolution. Specify the Font resolution (FontResolution)
        /// in DPI (dots per inch).Within your job settings, all of your DVB-Sub settings must
        /// be identical.
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
        /// Gets and sets the property FontScript. Set Font script (FontScript) to Automatically
        /// determined (AUTOMATIC), or leave blank, to automatically determine the font script
        /// in your input captions. Otherwise, set to Simplified Chinese (HANS) or Traditional
        /// Chinese (HANT) if your input font script uses Simplified or Traditional Chinese. Within
        /// your job settings, all of your DVB-Sub settings must be identical.
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
        /// Gets and sets the property FontSize. Specify the Font size (FontSize) in pixels. Must
        /// be a positive integer. Set to 0, or leave blank, for automatic font size. Within your
        /// job settings, all of your DVB-Sub settings must be identical.
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
        /// Gets and sets the property Height. Specify the height, in pixels, of this set of DVB-Sub
        /// captions. The default value is 576 pixels. Related setting: When you use this setting,
        /// you must set DDS handling (ddsHandling) to a value other than None (NONE). All burn-in
        /// and DVB-Sub font settings must match.
        /// </summary>
        [AWSProperty(Min=1, Max=2147483647)]
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
        /// color (OutlineColor) blank and set Style passthrough (StylePassthrough) to enabled
        /// to use the font outline color data from your input captions, if present. Within your
        /// job settings, all of your DVB-Sub settings must be identical.
        /// </summary>
        public DvbSubtitleOutlineColor OutlineColor
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
        /// Gets and sets the property OutlineSize. Specify the Outline size (OutlineSize) of
        /// the caption text, in pixels. Leave Outline size blank and set Style passthrough (StylePassthrough)
        /// to enabled to use the outline size data from your input captions, if present. Within
        /// your job settings, all of your DVB-Sub settings must be identical.
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
        /// Gets and sets the property ShadowColor. Specify the color of the shadow cast by the
        /// captions. Leave Shadow color (ShadowColor) blank and set Style passthrough (StylePassthrough)
        /// to enabled to use the shadow color data from your input captions, if present. Within
        /// your job settings, all of your DVB-Sub settings must be identical.
        /// </summary>
        public DvbSubtitleShadowColor ShadowColor
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
        /// (StylePassthrough) is set to Enabled, leave Shadow opacity (ShadowOpacity) blank to
        /// pass through the shadow style information in your input captions to your output captions.
        /// If Style passthrough is set to disabled, leave blank to use a value of 0 and remove
        /// all shadows from your output captions. Within your job settings, all of your DVB-Sub
        /// settings must be identical.
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
        /// 2 pixels to the left. Within your job settings, all of your DVB-Sub settings must
        /// be identical.
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
        /// 2 pixels above the text. Leave Shadow y-offset (ShadowYOffset) blank and set Style
        /// passthrough (StylePassthrough) to enabled to use the shadow y-offset data from your
        /// input captions, if present. Within your job settings, all of your DVB-Sub settings
        /// must be identical.
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
        /// Gets and sets the property StylePassthrough. Set Style passthrough (StylePassthrough)
        /// to ENABLED to use the available style, color, and position information from your input
        /// captions. MediaConvert uses default settings for any missing style and position information
        /// in your input captions. Set Style passthrough to DISABLED, or leave blank, to ignore
        /// the style and position information from your input captions and use default settings:
        /// white text with black outlining, bottom-center positioning, and automatic sizing.
        /// Whether you set Style passthrough to enabled or not, you can also choose to manually
        /// override any of the individual style and position settings.
        /// </summary>
        public DvbSubtitleStylePassthrough StylePassthrough
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
        /// Gets and sets the property SubtitlingType. Specify whether your DVB subtitles are
        /// standard or for hearing impaired. Choose hearing impaired if your subtitles include
        /// audio descriptions and dialogue. Choose standard if your subtitles include only dialogue.
        /// </summary>
        public DvbSubtitlingType SubtitlingType
        {
            get { return this._subtitlingType; }
            set { this._subtitlingType = value; }
        }

        // Check to see if SubtitlingType property is set
        internal bool IsSetSubtitlingType()
        {
            return this._subtitlingType != null;
        }

        /// <summary>
        /// Gets and sets the property TeletextSpacing. Specify whether the Text spacing (TeletextSpacing)
        /// in your captions is set by the captions grid, or varies depending on letter width.
        /// Choose fixed grid (FIXED_GRID) to conform to the spacing specified in the captions
        /// file more accurately. Choose proportional (PROPORTIONAL) to make the text easier to
        /// read for closed captions. Within your job settings, all of your DVB-Sub settings must
        /// be identical.
        /// </summary>
        public DvbSubtitleTeletextSpacing TeletextSpacing
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
        /// Gets and sets the property Width. Specify the width, in pixels, of this set of DVB-Sub
        /// captions. The default value is 720 pixels. Related setting: When you use this setting,
        /// you must set DDS handling (ddsHandling) to a value other than None (NONE). All burn-in
        /// and DVB-Sub font settings must match.
        /// </summary>
        [AWSProperty(Min=1, Max=2147483647)]
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

        /// <summary>
        /// Gets and sets the property XPosition. Specify the horizontal position (XPosition)
        /// of the captions, relative to the left side of the outputin pixels. A value of 10 would
        /// result in the captions starting 10 pixels from the left ofthe output. If no explicit
        /// x_position is provided, the horizontal caption position will bedetermined by the alignment
        /// parameter. Within your job settings, all of your DVB-Sub settings must be identical.
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
        /// Gets and sets the property YPosition. Specify the vertical position (YPosition) of
        /// the captions, relative to the top of the output in pixels. A value of 10 would result
        /// in the captions starting 10 pixels from the top of the output. If no explicit y_position
        /// is provided, the caption will be positioned towards the bottom of the output. Within
        /// your job settings, all of your DVB-Sub settings must be identical.
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