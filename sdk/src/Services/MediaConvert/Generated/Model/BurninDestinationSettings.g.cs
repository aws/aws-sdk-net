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
    /// Burn-in is a captions delivery method, rather than a captions format. Burn-in writes
    /// the captions directly on your video frames, replacing pixels of video content with
    /// the captions. Set up burn-in captions in the same output as your video. For more information,
    /// see https://docs.aws.amazon.com/mediaconvert/latest/ug/burn-in-output-captions.html.
    /// </summary>
    public partial class BurninDestinationSettings
    {
        /// <summary>
        /// Gets and sets the property Alignment. Specify the alignment of your captions. If no
        /// explicit x_position is provided, setting alignment to centered will placethe captions
        /// at the bottom center of the output. Similarly, setting a left alignment willalign
        /// captions to the bottom left of the output. If x and y positions are given in conjunction
        /// with the alignment parameter, the font will be justified (either left or centered)
        /// relative to those coordinates.
        /// </summary>
        public BurninSubtitleAlignment Alignment { get; set; }

        /// <summary>
        /// Checks to see if the Alignment property is set.
        /// </summary>
        internal bool IsSetAlignment() => this.Alignment != null;

        /// <summary>
        /// Gets and sets the property ApplyFontColor. Ignore this setting unless Style passthrough
        /// is set to Enabled and Font color set to Black, Yellow, Red, Green, Blue, or Hex. Use
        /// Apply font color for additional font color controls. When you choose White text only,
        /// or leave blank, your font color setting only applies to white text in your input captions.
        /// For example, if your font color setting is Yellow, and your input captions have red
        /// and white text, your output captions will have red and yellow text. When you choose
        /// ALL_TEXT, your font color setting applies to all of your output captions text.
        /// </summary>
        public BurninSubtitleApplyFontColor ApplyFontColor { get; set; }

        /// <summary>
        /// Checks to see if the ApplyFontColor property is set.
        /// </summary>
        internal bool IsSetApplyFontColor() => this.ApplyFontColor != null;

        /// <summary>
        /// Gets and sets the property BackgroundColor. Specify the color of the rectangle behind
        /// the captions. Leave background color blank and set Style passthrough to enabled to
        /// use the background color data from your input captions, if present.
        /// </summary>
        public BurninSubtitleBackgroundColor BackgroundColor { get; set; }

        /// <summary>
        /// Checks to see if the BackgroundColor property is set.
        /// </summary>
        internal bool IsSetBackgroundColor() => this.BackgroundColor != null;

        /// <summary>
        /// Gets and sets the property BackgroundOpacity. Specify the opacity of the background
        /// rectangle. Enter a value from 0 to 255, where 0 is transparent and 255 is opaque.
        /// If Style passthrough is set to enabled, leave blank to pass through the background
        /// style information in your input captions to your output captions. If Style passthrough
        /// is set to disabled, leave blank to use a value of 0 and remove all backgrounds from
        /// your output captions.
        /// </summary>
        [AWSProperty(Min = 0, Max = 255)]
        public int? BackgroundOpacity { get; set; }

        /// <summary>
        /// Checks to see if the BackgroundOpacity property is set.
        /// </summary>
        internal bool IsSetBackgroundOpacity() => this.BackgroundOpacity.HasValue;

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
        public BurninSubtitleFallbackFont FallbackFont { get; set; }

        /// <summary>
        /// Checks to see if the FallbackFont property is set.
        /// </summary>
        internal bool IsSetFallbackFont() => this.FallbackFont != null;

        /// <summary>
        /// Gets and sets the property FontColor. Specify the color of the burned-in captions
        /// text. Leave Font color blank and set Style passthrough to enabled to use the font
        /// color data from your input captions, if present.
        /// </summary>
        public BurninSubtitleFontColor FontColor { get; set; }

        /// <summary>
        /// Checks to see if the FontColor property is set.
        /// </summary>
        internal bool IsSetFontColor() => this.FontColor != null;

        /// <summary>
        /// Gets and sets the property FontFileBold. Specify a bold TrueType font file to use
        /// when rendering your output captions. Enter an S3, HTTP, or HTTPS URL. When you do,
        /// you must also separately specify a regular, an italic, and a bold italic font file.
        /// </summary>
        public string FontFileBold { get; set; }

        /// <summary>
        /// Checks to see if the FontFileBold property is set.
        /// </summary>
        internal bool IsSetFontFileBold() => this.FontFileBold != null;

        /// <summary>
        /// Gets and sets the property FontFileBoldItalic. Specify a bold italic TrueType font
        /// file to use when rendering your output captions. Enter an S3, HTTP, or HTTPS URL.
        /// When you do, you must also separately specify a regular, a bold, and an italic font
        /// file.
        /// </summary>
        public string FontFileBoldItalic { get; set; }

        /// <summary>
        /// Checks to see if the FontFileBoldItalic property is set.
        /// </summary>
        internal bool IsSetFontFileBoldItalic() => this.FontFileBoldItalic != null;

        /// <summary>
        /// Gets and sets the property FontFileItalic. Specify an italic TrueType font file to
        /// use when rendering your output captions. Enter an S3, HTTP, or HTTPS URL. When you
        /// do, you must also separately specify a regular, a bold, and a bold italic font file.
        /// </summary>
        public string FontFileItalic { get; set; }

        /// <summary>
        /// Checks to see if the FontFileItalic property is set.
        /// </summary>
        internal bool IsSetFontFileItalic() => this.FontFileItalic != null;

        /// <summary>
        /// Gets and sets the property FontFileRegular. Specify a regular TrueType font file to
        /// use when rendering your output captions. Enter an S3, HTTP, or HTTPS URL. When you
        /// do, you must also separately specify a bold, an italic, and a bold italic font file.
        /// </summary>
        public string FontFileRegular { get; set; }

        /// <summary>
        /// Checks to see if the FontFileRegular property is set.
        /// </summary>
        internal bool IsSetFontFileRegular() => this.FontFileRegular != null;

        /// <summary>
        /// Gets and sets the property FontOpacity. Specify the opacity of the burned-in captions.
        /// 255 is opaque; 0 is transparent.
        /// </summary>
        [AWSProperty(Min = 0, Max = 255)]
        public int? FontOpacity { get; set; }

        /// <summary>
        /// Checks to see if the FontOpacity property is set.
        /// </summary>
        internal bool IsSetFontOpacity() => this.FontOpacity.HasValue;

        /// <summary>
        /// Gets and sets the property FontResolution. Specify the Font resolution in DPI (dots
        /// per inch).
        /// </summary>
        [AWSProperty(Min = 96, Max = 600)]
        public int? FontResolution { get; set; }

        /// <summary>
        /// Checks to see if the FontResolution property is set.
        /// </summary>
        internal bool IsSetFontResolution() => this.FontResolution.HasValue;

        /// <summary>
        /// Gets and sets the property FontScript. Set Font script to Automatically determined,
        /// or leave blank, to automatically determine the font script in your input captions.
        /// Otherwise, set to Simplified Chinese (HANS) or Traditional Chinese (HANT) if your
        /// input font script uses Simplified or Traditional Chinese.
        /// </summary>
        public FontScript FontScript { get; set; }

        /// <summary>
        /// Checks to see if the FontScript property is set.
        /// </summary>
        internal bool IsSetFontScript() => this.FontScript != null;

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
        /// Gets and sets the property HexFontColor. Ignore this setting unless your Font color
        /// is set to Hex. Enter either six or eight hexidecimal digits, representing red, green,
        /// and blue, with two optional extra digits for alpha. For example a value of 1122AABB
        /// is a red value of 0x11, a green value of 0x22, a blue value of 0xAA, and an alpha
        /// value of 0xBB.
        /// </summary>
        [AWSProperty(Min = 6, Max = 8)]
        public string HexFontColor { get; set; }

        /// <summary>
        /// Checks to see if the HexFontColor property is set.
        /// </summary>
        internal bool IsSetHexFontColor() => this.HexFontColor != null;

        /// <summary>
        /// Gets and sets the property OutlineColor. Specify font outline color. Leave Outline
        /// color blank and set Style passthrough to enabled to use the font outline color data
        /// from your input captions, if present.
        /// </summary>
        public BurninSubtitleOutlineColor OutlineColor { get; set; }

        /// <summary>
        /// Checks to see if the OutlineColor property is set.
        /// </summary>
        internal bool IsSetOutlineColor() => this.OutlineColor != null;

        /// <summary>
        /// Gets and sets the property OutlineSize. Specify the Outline size of the caption text,
        /// in pixels. Leave Outline size blank and set Style passthrough to enabled to use the
        /// outline size data from your input captions, if present.
        /// </summary>
        [AWSProperty(Min = 0, Max = 10)]
        public int? OutlineSize { get; set; }

        /// <summary>
        /// Checks to see if the OutlineSize property is set.
        /// </summary>
        internal bool IsSetOutlineSize() => this.OutlineSize.HasValue;

        /// <summary>
        /// Gets and sets the property RemoveRubyReserveAttributes. Optionally remove any tts:rubyReserve
        /// attributes present in your input, that do not have a tts:ruby attribute in the same
        /// element, from your output. Use if your vertical Japanese output captions have alignment
        /// issues. To remove ruby reserve attributes when present: Choose Enabled. To not remove
        /// any ruby reserve attributes: Keep the default value, Disabled.
        /// </summary>
        public RemoveRubyReserveAttributes RemoveRubyReserveAttributes { get; set; }

        /// <summary>
        /// Checks to see if the RemoveRubyReserveAttributes property is set.
        /// </summary>
        internal bool IsSetRemoveRubyReserveAttributes() => this.RemoveRubyReserveAttributes != null;

        /// <summary>
        /// Gets and sets the property ShadowColor. Specify the color of the shadow cast by the
        /// captions. Leave Shadow color blank and set Style passthrough to enabled to use the
        /// shadow color data from your input captions, if present.
        /// </summary>
        public BurninSubtitleShadowColor ShadowColor { get; set; }

        /// <summary>
        /// Checks to see if the ShadowColor property is set.
        /// </summary>
        internal bool IsSetShadowColor() => this.ShadowColor != null;

        /// <summary>
        /// Gets and sets the property ShadowOpacity. Specify the opacity of the shadow. Enter
        /// a value from 0 to 255, where 0 is transparent and 255 is opaque. If Style passthrough
        /// is set to Enabled, leave Shadow opacity blank to pass through the shadow style information
        /// in your input captions to your output captions. If Style passthrough is set to disabled,
        /// leave blank to use a value of 0 and remove all shadows from your output captions.
        /// </summary>
        [AWSProperty(Min = 0, Max = 255)]
        public int? ShadowOpacity { get; set; }

        /// <summary>
        /// Checks to see if the ShadowOpacity property is set.
        /// </summary>
        internal bool IsSetShadowOpacity() => this.ShadowOpacity.HasValue;

        /// <summary>
        /// Gets and sets the property ShadowXOffset. Specify the horizontal offset of the shadow,
        /// relative to the captions in pixels. A value of -2 would result in a shadow offset
        /// 2 pixels to the left.
        /// </summary>
        [AWSProperty(Min = -2147483648, Max = 2147483647)]
        public int? ShadowXOffset { get; set; }

        /// <summary>
        /// Checks to see if the ShadowXOffset property is set.
        /// </summary>
        internal bool IsSetShadowXOffset() => this.ShadowXOffset.HasValue;

        /// <summary>
        /// Gets and sets the property ShadowYOffset. Specify the vertical offset of the shadow
        /// relative to the captions in pixels. A value of -2 would result in a shadow offset
        /// 2 pixels above the text. Leave Shadow y-offset blank and set Style passthrough to
        /// enabled to use the shadow y-offset data from your input captions, if present.
        /// </summary>
        [AWSProperty(Min = -2147483648, Max = 2147483647)]
        public int? ShadowYOffset { get; set; }

        /// <summary>
        /// Checks to see if the ShadowYOffset property is set.
        /// </summary>
        internal bool IsSetShadowYOffset() => this.ShadowYOffset.HasValue;

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
        public BurnInSubtitleStylePassthrough StylePassthrough { get; set; }

        /// <summary>
        /// Checks to see if the StylePassthrough property is set.
        /// </summary>
        internal bool IsSetStylePassthrough() => this.StylePassthrough != null;

        /// <summary>
        /// Gets and sets the property TeletextSpacing. Specify whether the text spacing in your
        /// captions is set by the captions grid, or varies depending on letter width. Choose
        /// fixed grid to conform to the spacing specified in the captions file more accurately.
        /// Choose proportional to make the text easier to read for closed captions.
        /// </summary>
        public BurninSubtitleTeletextSpacing TeletextSpacing { get; set; }

        /// <summary>
        /// Checks to see if the TeletextSpacing property is set.
        /// </summary>
        internal bool IsSetTeletextSpacing() => this.TeletextSpacing != null;

        /// <summary>
        /// Gets and sets the property XPosition. Specify the horizontal position of the captions,
        /// relative to the left side of the output in pixels. A value of 10 would result in the
        /// captions starting 10 pixels from the left of the output. If no explicit x_position
        /// is provided, the horizontal caption position will be determined by the alignment parameter.
        /// </summary>
        [AWSProperty(Min = 0, Max = 2147483647)]
        public int? XPosition { get; set; }

        /// <summary>
        /// Checks to see if the XPosition property is set.
        /// </summary>
        internal bool IsSetXPosition() => this.XPosition.HasValue;

        /// <summary>
        /// Gets and sets the property YPosition. Specify the vertical position of the captions,
        /// relative to the top of the output in pixels. A value of 10 would result in the captions
        /// starting 10 pixels from the top of the output. If no explicit y_position is provided,
        /// the caption will be positioned towards the bottom of the output.
        /// </summary>
        [AWSProperty(Min = 0, Max = 2147483647)]
        public int? YPosition { get; set; }

        /// <summary>
        /// Checks to see if the YPosition property is set.
        /// </summary>
        internal bool IsSetYPosition() => this.YPosition.HasValue;
    }
}
