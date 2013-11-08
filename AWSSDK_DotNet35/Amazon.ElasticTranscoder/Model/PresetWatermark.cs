/*
 * Copyright 2010-2013 Amazon.com, Inc. or its affiliates. All Rights Reserved.
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
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;

namespace Amazon.ElasticTranscoder.Model
{
    /// <summary>
    /// <para>Settings for the size, location, and opacity of graphics that you want Elastic Transcoder to overlay over videos that are transcoded
    /// using this preset. You can specify settings for up to four watermarks. Watermarks appear in the specified size and location, and with the
    /// specified opacity for the duration of the transcoded video.</para> <para>Watermarks can be in .png or .jpg format. If you want to display a
    /// watermark that is not rectangular, use the .png format, which supports transparency.</para> <para>When you create a job that uses this
    /// preset, you specify the .png or .jpg graphics that you want Elastic Transcoder to include in the transcoded videos. You can specify fewer
    /// graphics in the job than you specify watermark settings in the preset, which allows you to use the same preset for up to four watermarks
    /// that have different dimensions.</para>
    /// </summary>
    public class PresetWatermark
    {
        
        private string id;
        private string maxWidth;
        private string maxHeight;
        private string sizingPolicy;
        private string horizontalAlign;
        private string horizontalOffset;
        private string verticalAlign;
        private string verticalOffset;
        private string opacity;
        private string target;


        /// <summary>
        /// A unique identifier for the settings for one watermark. The value of <c>Id</c> can be up to 40 characters long.
        ///  
        /// <para>
        /// <b>Constraints:</b>
        /// <list type="definition">
        ///     <item>
        ///         <term>Length</term>
        ///         <description>1 - 40</description>
        ///     </item>
        /// </list>
        /// </para>
        /// </summary>
        public string Id
        {
            get { return this.id; }
            set { this.id = value; }
        }

        // Check to see if Id property is set
        internal bool IsSetId()
        {
            return this.id != null;
        }

        /// <summary>
        /// The maximum width of the watermark in one of the following formats: <ul> <li>number of pixels (px): The minimum value is 16 pixels, and the
        /// maximum value is the value of <c>MaxWidth</c>.</li> <li>integer percentage (%): The range of valid values is 0 to 100. Use the value of
        /// <c>Target</c> to specify whether you want Elastic Transcoder to include the black bars that are added by Elastic Transcoder, if any, in the
        /// calculation.</li> If you specify the value in pixels, it must be less than or equal to the value of <c>MaxWidth</c>.</ul>
        ///  
        /// <para>
        /// <b>Constraints:</b>
        /// <list type="definition">
        ///     <item>
        ///         <term>Pattern</term>
        ///         <description>(^\d{1,3}([.]\d{0,5})?%$)|(^\d{2,4}?px$)</description>
        ///     </item>
        /// </list>
        /// </para>
        /// </summary>
        public string MaxWidth
        {
            get { return this.maxWidth; }
            set { this.maxWidth = value; }
        }

        // Check to see if MaxWidth property is set
        internal bool IsSetMaxWidth()
        {
            return this.maxWidth != null;
        }

        /// <summary>
        /// The maximum height of the watermark in one of the following formats: <ul> <li>number of pixels (px): The minimum value is 16 pixels, and the
        /// maximum value is the value of <c>MaxHeight</c>.</li> <li>integer percentage (%): The range of valid values is 0 to 100. Use the value of
        /// <c>Target</c> to specify whether you want Elastic Transcoder to include the black bars that are added by Elastic Transcoder, if any, in the
        /// calculation.</li> </ul> If you specify the value in pixels, it must be less than or equal to the value of <c>MaxHeight</c>.
        ///  
        /// <para>
        /// <b>Constraints:</b>
        /// <list type="definition">
        ///     <item>
        ///         <term>Pattern</term>
        ///         <description>(^\d{1,3}([.]\d{0,5})?%$)|(^\d{2,4}?px$)</description>
        ///     </item>
        /// </list>
        /// </para>
        /// </summary>
        public string MaxHeight
        {
            get { return this.maxHeight; }
            set { this.maxHeight = value; }
        }

        // Check to see if MaxHeight property is set
        internal bool IsSetMaxHeight()
        {
            return this.maxHeight != null;
        }

        /// <summary>
        /// A value that controls scaling of the watermark: <ul> <li><b>Fit</b>: Elastic Transcoder scales the watermark so it matches the value that
        /// you specified in either <c>MaxWidth</c> or <c>MaxHeight</c> without exceeding the other value.</li> <li><b>Stretch</b>: Elastic Transcoder
        /// stretches the watermark to match the values that you specified for <c>MaxWidth</c> and <c>MaxHeight</c>. If the relative proportions of the
        /// watermark and the values of <c>MaxWidth</c> and <c>MaxHeight</c> are different, the watermark will be distorted.</li>
        /// <li><b>ShrinkToFit</b>: Elastic Transcoder scales the watermark down so that its dimensions match the values that you specified for at least
        /// one of <c>MaxWidth</c> and <c>MaxHeight</c> without exceeding either value. If you specify this option, Elastic Transcoder does not scale
        /// the watermark up.</li></ul>
        ///  
        /// <para>
        /// <b>Constraints:</b>
        /// <list type="definition">
        ///     <item>
        ///         <term>Pattern</term>
        ///         <description>(^Fit$)|(^Stretch$)|(^ShrinkToFit$)</description>
        ///     </item>
        /// </list>
        /// </para>
        /// </summary>
        public string SizingPolicy
        {
            get { return this.sizingPolicy; }
            set { this.sizingPolicy = value; }
        }

        // Check to see if SizingPolicy property is set
        internal bool IsSetSizingPolicy()
        {
            return this.sizingPolicy != null;
        }

        /// <summary>
        /// The horizontal position of the watermark unless you specify a non-zero value for <c>HorizontalOffset</c>: <ul> <li><b>Left</b>: The left
        /// edge of the watermark is aligned with the left border of the video.</li> <li><b>Right</b>: The right edge of the watermark is aligned with
        /// the right border of the video.</li> <li><b>Center</b>: The watermark is centered between the left and right borders.</li></ul>
        ///  
        /// <para>
        /// <b>Constraints:</b>
        /// <list type="definition">
        ///     <item>
        ///         <term>Pattern</term>
        ///         <description>(^Left$)|(^Right$)|(^Center$)</description>
        ///     </item>
        /// </list>
        /// </para>
        /// </summary>
        public string HorizontalAlign
        {
            get { return this.horizontalAlign; }
            set { this.horizontalAlign = value; }
        }

        // Check to see if HorizontalAlign property is set
        internal bool IsSetHorizontalAlign()
        {
            return this.horizontalAlign != null;
        }

        /// <summary>
        /// The amount by which you want the horizontal position of the watermark to be offset from the position specified by HorizontalAlign: <ul>
        /// <li>number of pixels (px): The minimum value is 0 pixels, and the maximum value is the value of MaxWidth.</li> <li>integer percentage (%):
        /// The range of valid values is 0 to 100.</li> </ul>For example, if you specify Left for <c>HorizontalAlign</c> and 5px for
        /// <c>HorizontalOffset</c>, the left side of the watermark appears 5 pixels from the left border of the output video. <c>HorizontalOffset</c>
        /// is only valid when the value of <c>HorizontalAlign</c> is <c>Left</c> or <c>Right</c>. If you specify an offset that causes the watermark to
        /// extend beyond the left or right border and Elastic Transcoder has not added black bars, the watermark is cropped. If Elastic Transcoder has
        /// added black bars, the watermark extends into the black bars. If the watermark extends beyond the black bars, it is cropped. Use the value of
        /// <c>Target</c> to specify whether you want to include the black bars that are added by Elastic Transcoder, if any, in the offset calculation.
        ///  
        /// <para>
        /// <b>Constraints:</b>
        /// <list type="definition">
        ///     <item>
        ///         <term>Pattern</term>
        ///         <description>(^\d{1,3}([.]\d{0,5})?%$)|(^\d{2,4}?px$)</description>
        ///     </item>
        /// </list>
        /// </para>
        /// </summary>
        public string HorizontalOffset
        {
            get { return this.horizontalOffset; }
            set { this.horizontalOffset = value; }
        }

        // Check to see if HorizontalOffset property is set
        internal bool IsSetHorizontalOffset()
        {
            return this.horizontalOffset != null;
        }

        /// <summary>
        /// The vertical position of the watermark unless you specify a non-zero value for <c>VerticalOffset</c>: <ul> <li><b>Top</b>: The top edge of
        /// the watermark is aligned with the top border of the video.</li> <li><b>Bottom</b>: The bottom edge of the watermark is aligned with the
        /// bottom border of the video.</li> <li><b>Center</b>: The watermark is centered between the top and bottom borders.</li></ul>
        ///  
        /// <para>
        /// <b>Constraints:</b>
        /// <list type="definition">
        ///     <item>
        ///         <term>Pattern</term>
        ///         <description>(^Top$)|(^Bottom$)|(^Center$)</description>
        ///     </item>
        /// </list>
        /// </para>
        /// </summary>
        public string VerticalAlign
        {
            get { return this.verticalAlign; }
            set { this.verticalAlign = value; }
        }

        // Check to see if VerticalAlign property is set
        internal bool IsSetVerticalAlign()
        {
            return this.verticalAlign != null;
        }

        /// <summary>
        /// <c>VerticalOffset</c> The amount by which you want the vertical position of the watermark to be offset from the position specified by
        /// VerticalAlign:<ul> <li>number of pixels (px): The minimum value is 0 pixels, and the maximum value is the value of <c>MaxHeight</c>.</li>
        /// <li>integer percentage (%): The range of valid values is 0 to 100.</li> </ul> For example, if you specify <c>Top</c> for
        /// <c>VerticalAlign</c> and <c>5px</c> for <c>VerticalOffset</c>, the top of the watermark appears 5 pixels from the top border of the output
        /// video. <c>VerticalOffset</c> is only valid when the value of VerticalAlign is Top or Bottom. If you specify an offset that causes the
        /// watermark to extend beyond the top or bottom border and Elastic Transcoder has not added black bars, the watermark is cropped. If Elastic
        /// Transcoder has added black bars, the watermark extends into the black bars. If the watermark extends beyond the black bars, it is cropped.
        /// Use the value of <c>Target</c> to specify whether you want Elastic Transcoder to include the black bars that are added by Elastic
        /// Transcoder, if any, in the offset calculation.
        ///  
        /// <para>
        /// <b>Constraints:</b>
        /// <list type="definition">
        ///     <item>
        ///         <term>Pattern</term>
        ///         <description>(^\d{1,3}([.]\d{0,5})?%$)|(^\d{2,4}?px$)</description>
        ///     </item>
        /// </list>
        /// </para>
        /// </summary>
        public string VerticalOffset
        {
            get { return this.verticalOffset; }
            set { this.verticalOffset = value; }
        }

        // Check to see if VerticalOffset property is set
        internal bool IsSetVerticalOffset()
        {
            return this.verticalOffset != null;
        }

        /// <summary>
        /// A percentage that indicates how much you want a watermark to obscure the video in the location where it appears. Valid values are 0 (the
        /// watermark is invisible) to 100 (the watermark completely obscures the video in the specified location). The datatype of <c>Opacity</c> is
        /// float. Elastic Transcoder supports transparent .png graphics. If you use a transparent .png, the transparent portion of the video appears as
        /// if you had specified a value of 0 for <c>Opacity</c>. The .jpg file format doesn't support transparency.
        ///  
        /// <para>
        /// <b>Constraints:</b>
        /// <list type="definition">
        ///     <item>
        ///         <term>Pattern</term>
        ///         <description>^\d{1,3}([.]\d{0,20})?$</description>
        ///     </item>
        /// </list>
        /// </para>
        /// </summary>
        public string Opacity
        {
            get { return this.opacity; }
            set { this.opacity = value; }
        }

        // Check to see if Opacity property is set
        internal bool IsSetOpacity()
        {
            return this.opacity != null;
        }

        /// <summary>
        /// A value that determines how Elastic Transcoder interprets values that you specified for <c>HorizontalOffset</c>, <c>VerticalOffset</c>,
        /// <c>MaxWidth</c>, and <c>MaxHeight</c>: <ul><li><b>Content</b>: <c>HorizontalOffset</c> and <c>VerticalOffset</c> values are calculated based
        /// on the borders of the video excluding black bars added by Elastic Transcoder, if any. In addition, <c>MaxWidth</c> and <c>MaxHeight</c>, if
        /// specified as a percentage, are calculated based on the borders of the video excluding black bars added by Elastic Transcoder, if any.</li>
        /// <li><b>Frame</b>: <c>HorizontalOffset</c> and <c>VerticalOffset</c> values are calculated based on the borders of the video including black
        /// bars added by Elastic Transcoder, if any.</li> In addition, <c>MaxWidth</c> and <c>MaxHeight</c>, if specified as a percentage, are
        /// calculated based on the borders of the video including black bars added by Elastic Transcoder, if any.</ul>
        ///  
        /// <para>
        /// <b>Constraints:</b>
        /// <list type="definition">
        ///     <item>
        ///         <term>Pattern</term>
        ///         <description>(^Content$)|(^Frame$)</description>
        ///     </item>
        /// </list>
        /// </para>
        /// </summary>
        public string Target
        {
            get { return this.target; }
            set { this.target = value; }
        }

        // Check to see if Target property is set
        internal bool IsSetTarget()
        {
            return this.target != null;
        }
    }
}
