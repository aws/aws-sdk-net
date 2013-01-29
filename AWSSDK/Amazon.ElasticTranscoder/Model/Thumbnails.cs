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
    /// 
    /// </summary>
    public class Thumbnails
    {
        
        private string format;
        private string interval;
        private string resolution;
        private string aspectRatio;

        /// <summary>
        /// The format of thumbnails, if any. Valid values are <c>jpg</c> and <c>png</c>. You specify whether you want Elastic Transcoder to create
        /// thumbnails when you create a job.
        ///  
        /// <para>
        /// <b>Constraints:</b>
        /// <list type="definition">
        ///     <item>
        ///         <term>Pattern</term>
        ///         <description>(^png$)</description>
        ///     </item>
        /// </list>
        /// </para>
        /// </summary>
        public string Format
        {
            get { return this.format; }
            set { this.format = value; }
        }

        /// <summary>
        /// Sets the Format property
        /// </summary>
        /// <param name="format">The value to set for the Format property </param>
        /// <returns>this instance</returns>
        public Thumbnails WithFormat(string format)
        {
            this.format = format;
            return this;
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
        ///         <description>^\d+$</description>
        ///     </item>
        /// </list>
        /// </para>
        /// </summary>
        public string Interval
        {
            get { return this.interval; }
            set { this.interval = value; }
        }

        /// <summary>
        /// Sets the Interval property
        /// </summary>
        /// <param name="interval">The value to set for the Interval property </param>
        /// <returns>this instance</returns>
        public Thumbnails WithInterval(string interval)
        {
            this.interval = interval;
            return this;
        }
            

        // Check to see if Interval property is set
        internal bool IsSetInterval()
        {
            return this.interval != null;
        }

        /// <summary>
        /// The width and height of thumbnail files in pixels. Specify a value in the format <c><i>width</i></c> x <c><i>height</i></c> where both
        /// values are even integers. The values cannot exceed the width and height that you specified in the <c>Video:Resolution</c> object.
        ///  
        /// <para>
        /// <b>Constraints:</b>
        /// <list type="definition">
        ///     <item>
        ///         <term>Pattern</term>
        ///         <description>^\d+x\d+$</description>
        ///     </item>
        /// </list>
        /// </para>
        /// </summary>
        public string Resolution
        {
            get { return this.resolution; }
            set { this.resolution = value; }
        }

        /// <summary>
        /// Sets the Resolution property
        /// </summary>
        /// <param name="resolution">The value to set for the Resolution property </param>
        /// <returns>this instance</returns>
        public Thumbnails WithResolution(string resolution)
        {
            this.resolution = resolution;
            return this;
        }
            

        // Check to see if Resolution property is set
        internal bool IsSetResolution()
        {
            return this.resolution != null;
        }

        /// <summary>
        /// The aspect ratio of thumbnails. Valid values include: <c>auto</c>, <c>1:1</c>, <c>4:3</c>, <c>3:2</c>, <c>16:9</c> If you specify
        /// <c>auto</c>, Elastic Transcoder tries to preserve the aspect ratio of the video in the output file.
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

        /// <summary>
        /// Sets the AspectRatio property
        /// </summary>
        /// <param name="aspectRatio">The value to set for the AspectRatio property </param>
        /// <returns>this instance</returns>
        public Thumbnails WithAspectRatio(string aspectRatio)
        {
            this.aspectRatio = aspectRatio;
            return this;
        }
            

        // Check to see if AspectRatio property is set
        internal bool IsSetAspectRatio()
        {
            return this.aspectRatio != null;
        }
    }
}
