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
    /// <para>Thumbnails for videos.</para>
    /// </summary>
    public class Thumbnails
    {
        
        private string format;
        private string interval;
        private string resolution;
        private string aspectRatio;
        private string maxWidth;
        private string maxHeight;
        private string sizingPolicy;
        private string paddingPolicy;


        /// <summary>
        /// The format of thumbnails, if any. Valid values are <c>jpg</c> and <c>png</c>. You specify whether you want Elastic Transcoder to create
        /// thumbnails when you create a job.
        ///  
        /// <para>
        /// <b>Constraints:</b>
        /// <list type="definition">
        ///     <item>
        ///         <term>Pattern</term>
        ///         <description>(^jpg$)|(^png$)</description>
        ///     </item>
        /// </list>
        /// </para>
        /// </summary>
        public string Format
        {
            get { return this.format; }
            set { this.format = value; }
        }

        // Check to see if Format property is set
        internal bool IsSetFormat()
        {
            return this.format != null;
        }

        /// <summary>
        /// The number of seconds between thumbnails. Specify an integer value.
        ///  
        /// <para>
        /// <b>Constraints:</b>
        /// <list type="definition">
        ///     <item>
        ///         <term>Pattern</term>
        ///         <description>^\d{1,5}$</description>
        ///     </item>
        /// </list>
        /// </para>
        /// </summary>
        public string Interval
        {
            get { return this.interval; }
            set { this.interval = value; }
        }

        // Check to see if Interval property is set
        internal bool IsSetInterval()
        {
            return this.interval != null;
        }

        /// <summary>
        /// <important> To better control resolution and aspect ratio of thumbnails, we recommend that you use the values <c>MaxWidth</c>,
        /// <c>MaxHeight</c>, <c>SizingPolicy</c>, and <c>PaddingPolicy</c> instead of <c>Resolution</c> and <c>AspectRatio</c>. The two groups of
        /// settings are mutually exclusive. Do not use them together. </important> The width and height of thumbnail files in pixels. Specify a value
        /// in the format <c><i>width</i></c> x <c><i>height</i></c> where both values are even integers. The values cannot exceed the width and height
        /// that you specified in the <c>Video:Resolution</c> object.
        ///  
        /// <para>
        /// <b>Constraints:</b>
        /// <list type="definition">
        ///     <item>
        ///         <term>Pattern</term>
        ///         <description>^\d{1,5}x\d{1,5}$</description>
        ///     </item>
        /// </list>
        /// </para>
        /// </summary>
        public string Resolution
        {
            get { return this.resolution; }
            set { this.resolution = value; }
        }

        // Check to see if Resolution property is set
        internal bool IsSetResolution()
        {
            return this.resolution != null;
        }

        /// <summary>
        /// <important> To better control resolution and aspect ratio of thumbnails, we recommend that you use the values <c>MaxWidth</c>,
        /// <c>MaxHeight</c>, <c>SizingPolicy</c>, and <c>PaddingPolicy</c> instead of <c>Resolution</c> and <c>AspectRatio</c>. The two groups of
        /// settings are mutually exclusive. Do not use them together. </important> The aspect ratio of thumbnails. Valid values include: <c>auto</c>,
        /// <c>1:1</c>, <c>4:3</c>, <c>3:2</c>, <c>16:9</c> If you specify <c>auto</c>, Elastic Transcoder tries to preserve the aspect ratio of the
        /// video in the output file.
        ///  
        /// <para>
        /// <b>Constraints:</b>
        /// <list type="definition">
        ///     <item>
        ///         <term>Pattern</term>
        ///         <description>(^auto$)|(^1:1$)|(^4:3$)|(^3:2$)|(^16:9$)</description>
        ///     </item>
        /// </list>
        /// </para>
        /// </summary>
        public string AspectRatio
        {
            get { return this.aspectRatio; }
            set { this.aspectRatio = value; }
        }

        // Check to see if AspectRatio property is set
        internal bool IsSetAspectRatio()
        {
            return this.aspectRatio != null;
        }

        /// <summary>
        /// The maximum width of thumbnails in pixels. If you specify auto, Elastic Transcoder uses 1920 (Full HD) as the default value. If you specify
        /// a numeric value, enter an even integer between 32 and 4096.
        ///  
        /// <para>
        /// <b>Constraints:</b>
        /// <list type="definition">
        ///     <item>
        ///         <term>Pattern</term>
        ///         <description>(^auto$)|(^\d{2,4}$)</description>
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
        /// The maximum height of thumbnails in pixels. If you specify auto, Elastic Transcoder uses 1080 (Full HD) as the default value. If you specify
        /// a numeric value, enter an even integer between 32 and 3072.
        ///  
        /// <para>
        /// <b>Constraints:</b>
        /// <list type="definition">
        ///     <item>
        ///         <term>Pattern</term>
        ///         <description>(^auto$)|(^\d{2,4}$)</description>
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
        /// Specify one of the following values to control scaling of thumbnails: <ul> <li><c>Fit</c>: Elastic Transcoder scales thumbnails so they
        /// match the value that you specified in thumbnail MaxWidth or MaxHeight settings without exceeding the other value. </li> <li><c>Fill</c>:
        /// Elastic Transcoder scales thumbnails so they match the value that you specified in thumbnail <c>MaxWidth</c> or <c>MaxHeight</c> settings
        /// and matches or exceeds the other value. Elastic Transcoder centers the image in thumbnails and then crops in the dimension (if any) that
        /// exceeds the maximum value.</li> <li><c>Stretch</c>: Elastic Transcoder stretches thumbnails to match the values that you specified for
        /// thumbnail <c>MaxWidth</c> and <c>MaxHeight</c> settings. If the relative proportions of the input video and thumbnails are different, the
        /// thumbnails will be distorted.</li> <li><c>Keep</c>: Elastic Transcoder does not scale thumbnails. If either dimension of the input video
        /// exceeds the values that you specified for thumbnail <c>MaxWidth</c> and <c>MaxHeight</c> settings, Elastic Transcoder crops the
        /// thumbnails.</li> <li><c>ShrinkToFit</c>: Elastic Transcoder scales thumbnails down so that their dimensions match the values that you
        /// specified for at least one of thumbnail <c>MaxWidth</c> and <c>MaxHeight</c> without exceeding either value. If you specify this option,
        /// Elastic Transcoder does not scale thumbnails up.</li> <li><c>ShrinkToFill</c>: Elastic Transcoder scales thumbnails down so that their
        /// dimensions match the values that you specified for at least one of <c>MaxWidth</c> and <c>MaxHeight</c> without dropping below either value.
        /// If you specify this option, Elastic Transcoder does not scale thumbnails up.</li> </ul>
        ///  
        /// <para>
        /// <b>Constraints:</b>
        /// <list type="definition">
        ///     <item>
        ///         <term>Pattern</term>
        ///         <description>(^Fit$)|(^Fill$)|(^Stretch$)|(^Keep$)|(^ShrinkToFit$)|(^ShrinkToFill$)</description>
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
        /// When you set <c>PaddingPolicy</c> to <c>Pad</c>, Elastic Transcoder may add black bars to the top and bottom and/or left and right sides of
        /// thumbnails to make the total size of the thumbnails match the values that you specified for thumbnail <c>MaxWidth</c> and <c>MaxHeight</c>
        /// settings.
        ///  
        /// <para>
        /// <b>Constraints:</b>
        /// <list type="definition">
        ///     <item>
        ///         <term>Pattern</term>
        ///         <description>(^Pad$)|(^NoPad$)</description>
        ///     </item>
        /// </list>
        /// </para>
        /// </summary>
        public string PaddingPolicy
        {
            get { return this.paddingPolicy; }
            set { this.paddingPolicy = value; }
        }

        // Check to see if PaddingPolicy property is set
        internal bool IsSetPaddingPolicy()
        {
            return this.paddingPolicy != null;
        }
    }
}
