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
 * Do not modify this file. This file is generated from the elastictranscoder-2012-09-25.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.ElasticTranscoder.Model
{
    /// <summary>
    /// Settings for the size, location, and opacity of graphics that you want Elastic Transcoder
    /// to overlay over videos that are transcoded using this preset. You can specify settings
    /// for up to four watermarks. Watermarks appear in the specified size and location, and
    /// with the specified opacity for the duration of the transcoded video.
    /// 
    ///  
    /// <para>
    /// Watermarks can be in .png or .jpg format. If you want to display a watermark that
    /// is not rectangular, use the .png format, which supports transparency.
    /// </para>
    ///  
    /// <para>
    /// When you create a job that uses this preset, you specify the .png or .jpg graphics
    /// that you want Elastic Transcoder to include in the transcoded videos. You can specify
    /// fewer graphics in the job than you specify watermark settings in the preset, which
    /// allows you to use the same preset for up to four watermarks that have different dimensions.
    /// </para>
    /// </summary>
    public partial class PresetWatermark
    {
        private string _horizontalAlign;
        private string _horizontalOffset;
        private string _id;
        private string _maxHeight;
        private string _maxWidth;
        private string _opacity;
        private string _sizingPolicy;
        private string _target;
        private string _verticalAlign;
        private string _verticalOffset;

        /// <summary>
        /// Gets and sets the property HorizontalAlign. 
        /// <para>
        /// The horizontal position of the watermark unless you specify a non-zero value for <code>HorizontalOffset</code>:
        /// <ul> <li> <b>Left</b>: The left edge of the watermark is aligned with the left border
        /// of the video.</li> <li> <b>Right</b>: The right edge of the watermark is aligned with
        /// the right border of the video.</li> <li> <b>Center</b>: The watermark is centered
        /// between the left and right borders.</li> </ul>
        /// </para>
        /// </summary>
        public string HorizontalAlign
        {
            get { return this._horizontalAlign; }
            set { this._horizontalAlign = value; }
        }

        // Check to see if HorizontalAlign property is set
        internal bool IsSetHorizontalAlign()
        {
            return this._horizontalAlign != null;
        }

        /// <summary>
        /// Gets and sets the property HorizontalOffset. 
        /// <para>
        /// The amount by which you want the horizontal position of the watermark to be offset
        /// from the position specified by HorizontalAlign: <ul> <li>number of pixels (px): The
        /// minimum value is 0 pixels, and the maximum value is the value of MaxWidth.</li> <li>integer
        /// percentage (%): The range of valid values is 0 to 100.</li> </ul>For example, if you
        /// specify Left for <code>HorizontalAlign</code> and 5px for <code>HorizontalOffset</code>,
        /// the left side of the watermark appears 5 pixels from the left border of the output
        /// video.
        /// </para>
        ///  
        /// <para>
        /// <code>HorizontalOffset</code> is only valid when the value of <code>HorizontalAlign</code>
        /// is <code>Left</code> or <code>Right</code>. If you specify an offset that causes the
        /// watermark to extend beyond the left or right border and Elastic Transcoder has not
        /// added black bars, the watermark is cropped. If Elastic Transcoder has added black
        /// bars, the watermark extends into the black bars. If the watermark extends beyond the
        /// black bars, it is cropped.
        /// </para>
        ///  
        /// <para>
        /// Use the value of <code>Target</code> to specify whether you want to include the black
        /// bars that are added by Elastic Transcoder, if any, in the offset calculation.
        /// </para>
        /// </summary>
        public string HorizontalOffset
        {
            get { return this._horizontalOffset; }
            set { this._horizontalOffset = value; }
        }

        // Check to see if HorizontalOffset property is set
        internal bool IsSetHorizontalOffset()
        {
            return this._horizontalOffset != null;
        }

        /// <summary>
        /// Gets and sets the property Id. A unique identifier for the settings for one watermark.
        /// The value of <code>Id</code> can be up to 40 characters long.
        /// </summary>
        public string Id
        {
            get { return this._id; }
            set { this._id = value; }
        }

        // Check to see if Id property is set
        internal bool IsSetId()
        {
            return this._id != null;
        }

        /// <summary>
        /// Gets and sets the property MaxHeight. 
        /// <para>
        /// The maximum height of the watermark in one of the following formats: <ul> <li>number
        /// of pixels (px): The minimum value is 16 pixels, and the maximum value is the value
        /// of <code>MaxHeight</code>.</li> <li>integer percentage (%): The range of valid values
        /// is 0 to 100. Use the value of <code>Target</code> to specify whether you want Elastic
        /// Transcoder to include the black bars that are added by Elastic Transcoder, if any,
        /// in the calculation.</li> </ul> If you specify the value in pixels, it must be less
        /// than or equal to the value of <code>MaxHeight</code>.
        /// </para>
        /// </summary>
        public string MaxHeight
        {
            get { return this._maxHeight; }
            set { this._maxHeight = value; }
        }

        // Check to see if MaxHeight property is set
        internal bool IsSetMaxHeight()
        {
            return this._maxHeight != null;
        }

        /// <summary>
        /// Gets and sets the property MaxWidth. 
        /// <para>
        /// The maximum width of the watermark in one of the following formats: <ul> <li>number
        /// of pixels (px): The minimum value is 16 pixels, and the maximum value is the value
        /// of <code>MaxWidth</code>.</li> <li>integer percentage (%): The range of valid values
        /// is 0 to 100. Use the value of <code>Target</code> to specify whether you want Elastic
        /// Transcoder to include the black bars that are added by Elastic Transcoder, if any,
        /// in the calculation.</li> If you specify the value in pixels, it must be less than
        /// or equal to the value of <code>MaxWidth</code>.</ul>
        /// </para>
        /// </summary>
        public string MaxWidth
        {
            get { return this._maxWidth; }
            set { this._maxWidth = value; }
        }

        // Check to see if MaxWidth property is set
        internal bool IsSetMaxWidth()
        {
            return this._maxWidth != null;
        }

        /// <summary>
        /// Gets and sets the property Opacity. 
        /// <para>
        /// A percentage that indicates how much you want a watermark to obscure the video in
        /// the location where it appears. Valid values are 0 (the watermark is invisible) to
        /// 100 (the watermark completely obscures the video in the specified location). The datatype
        /// of <code>Opacity</code> is float.
        /// </para>
        ///  
        /// <para>
        /// Elastic Transcoder supports transparent .png graphics. If you use a transparent .png,
        /// the transparent portion of the video appears as if you had specified a value of 0
        /// for <code>Opacity</code>. The .jpg file format doesn't support transparency.
        /// </para>
        /// </summary>
        public string Opacity
        {
            get { return this._opacity; }
            set { this._opacity = value; }
        }

        // Check to see if Opacity property is set
        internal bool IsSetOpacity()
        {
            return this._opacity != null;
        }

        /// <summary>
        /// Gets and sets the property SizingPolicy. 
        /// <para>
        /// A value that controls scaling of the watermark: <ul> <li> <b>Fit</b>: Elastic Transcoder
        /// scales the watermark so it matches the value that you specified in either <code>MaxWidth</code>
        /// or <code>MaxHeight</code> without exceeding the other value.</li> <li> <b>Stretch</b>:
        /// Elastic Transcoder stretches the watermark to match the values that you specified
        /// for <code>MaxWidth</code> and <code>MaxHeight</code>. If the relative proportions
        /// of the watermark and the values of <code>MaxWidth</code> and <code>MaxHeight</code>
        /// are different, the watermark will be distorted.</li> <li> <b>ShrinkToFit</b>: Elastic
        /// Transcoder scales the watermark down so that its dimensions match the values that
        /// you specified for at least one of <code>MaxWidth</code> and <code>MaxHeight</code>
        /// without exceeding either value. If you specify this option, Elastic Transcoder does
        /// not scale the watermark up.</li> </ul> 
        /// </para>
        /// </summary>
        public string SizingPolicy
        {
            get { return this._sizingPolicy; }
            set { this._sizingPolicy = value; }
        }

        // Check to see if SizingPolicy property is set
        internal bool IsSetSizingPolicy()
        {
            return this._sizingPolicy != null;
        }

        /// <summary>
        /// Gets and sets the property Target. 
        /// <para>
        /// A value that determines how Elastic Transcoder interprets values that you specified
        /// for <code>HorizontalOffset</code>, <code>VerticalOffset</code>, <code>MaxWidth</code>,
        /// and <code>MaxHeight</code>: <ul> <li> <b>Content</b>: <code>HorizontalOffset</code>
        /// and <code>VerticalOffset</code> values are calculated based on the borders of the
        /// video excluding black bars added by Elastic Transcoder, if any. In addition, <code>MaxWidth</code>
        /// and <code>MaxHeight</code>, if specified as a percentage, are calculated based on
        /// the borders of the video excluding black bars added by Elastic Transcoder, if any.</li>
        /// <li> <b>Frame</b>: <code>HorizontalOffset</code> and <code>VerticalOffset</code> values
        /// are calculated based on the borders of the video including black bars added by Elastic
        /// Transcoder, if any.</li> In addition, <code>MaxWidth</code> and <code>MaxHeight</code>,
        /// if specified as a percentage, are calculated based on the borders of the video including
        /// black bars added by Elastic Transcoder, if any.</ul>
        /// </para>
        /// </summary>
        public string Target
        {
            get { return this._target; }
            set { this._target = value; }
        }

        // Check to see if Target property is set
        internal bool IsSetTarget()
        {
            return this._target != null;
        }

        /// <summary>
        /// Gets and sets the property VerticalAlign. 
        /// <para>
        /// The vertical position of the watermark unless you specify a non-zero value for <code>VerticalOffset</code>:
        /// <ul> <li> <b>Top</b>: The top edge of the watermark is aligned with the top border
        /// of the video.</li> <li> <b>Bottom</b>: The bottom edge of the watermark is aligned
        /// with the bottom border of the video.</li> <li> <b>Center</b>: The watermark is centered
        /// between the top and bottom borders.</li> </ul>
        /// </para>
        /// </summary>
        public string VerticalAlign
        {
            get { return this._verticalAlign; }
            set { this._verticalAlign = value; }
        }

        // Check to see if VerticalAlign property is set
        internal bool IsSetVerticalAlign()
        {
            return this._verticalAlign != null;
        }

        /// <summary>
        /// Gets and sets the property VerticalOffset. <code>VerticalOffset</code> 
        /// <para>
        /// The amount by which you want the vertical position of the watermark to be offset from
        /// the position specified by VerticalAlign:<ul> <li>number of pixels (px): The minimum
        /// value is 0 pixels, and the maximum value is the value of <code>MaxHeight</code>.</li>
        /// <li>integer percentage (%): The range of valid values is 0 to 100.</li> </ul> For
        /// example, if you specify <code>Top</code> for <code>VerticalAlign</code> and <code>5px</code>
        /// for <code>VerticalOffset</code>, the top of the watermark appears 5 pixels from the
        /// top border of the output video.
        /// </para>
        ///  
        /// <para>
        /// <code>VerticalOffset</code> is only valid when the value of VerticalAlign is Top or
        /// Bottom.
        /// </para>
        ///  
        /// <para>
        /// If you specify an offset that causes the watermark to extend beyond the top or bottom
        /// border and Elastic Transcoder has not added black bars, the watermark is cropped.
        /// If Elastic Transcoder has added black bars, the watermark extends into the black bars.
        /// If the watermark extends beyond the black bars, it is cropped.
        /// </para>
        ///  
        /// <para>
        /// Use the value of <code>Target</code> to specify whether you want Elastic Transcoder
        /// to include the black bars that are added by Elastic Transcoder, if any, in the offset
        /// calculation.
        /// </para>
        /// </summary>
        public string VerticalOffset
        {
            get { return this._verticalOffset; }
            set { this._verticalOffset = value; }
        }

        // Check to see if VerticalOffset property is set
        internal bool IsSetVerticalOffset()
        {
            return this._verticalOffset != null;
        }

    }
}