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
 * Do not modify this file. This file is generated from the elastictranscoder-2012-09-25.normal.json service model.
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
namespace Amazon.ElasticTranscoder.Model
{
    /// <summary>
    /// Thumbnails for videos.
    /// </summary>
    public partial class Thumbnails
    {
        private string _aspectRatio;
        private string _format;
        private string _interval;
        private string _maxHeight;
        private string _maxWidth;
        private string _paddingPolicy;
        private string _resolution;
        private string _sizingPolicy;

        /// <summary>
        /// Gets and sets the property AspectRatio. <important> 
        /// <para>
        /// To better control resolution and aspect ratio of thumbnails, we recommend that you
        /// use the values <c>MaxWidth</c>, <c>MaxHeight</c>, <c>SizingPolicy</c>, and <c>PaddingPolicy</c>
        /// instead of <c>Resolution</c> and <c>AspectRatio</c>. The two groups of settings are
        /// mutually exclusive. Do not use them together.
        /// </para>
        ///  </important> 
        /// <para>
        /// The aspect ratio of thumbnails. Valid values include:
        /// </para>
        ///  
        /// <para>
        ///  <c>auto</c>, <c>1:1</c>, <c>4:3</c>, <c>3:2</c>, <c>16:9</c> 
        /// </para>
        ///  
        /// <para>
        /// If you specify <c>auto</c>, Elastic Transcoder tries to preserve the aspect ratio
        /// of the video in the output file.
        /// </para>
        /// </summary>
        public string AspectRatio
        {
            get { return this._aspectRatio; }
            set { this._aspectRatio = value; }
        }

        // Check to see if AspectRatio property is set
        internal bool IsSetAspectRatio()
        {
            return this._aspectRatio != null;
        }

        /// <summary>
        /// Gets and sets the property Format. 
        /// <para>
        /// The format of thumbnails, if any. Valid values are <c>jpg</c> and <c>png</c>. 
        /// </para>
        ///  
        /// <para>
        /// You specify whether you want Elastic Transcoder to create thumbnails when you create
        /// a job.
        /// </para>
        /// </summary>
        public string Format
        {
            get { return this._format; }
            set { this._format = value; }
        }

        // Check to see if Format property is set
        internal bool IsSetFormat()
        {
            return this._format != null;
        }

        /// <summary>
        /// Gets and sets the property Interval. 
        /// <para>
        /// The approximate number of seconds between thumbnails. Specify an integer value.
        /// </para>
        /// </summary>
        public string Interval
        {
            get { return this._interval; }
            set { this._interval = value; }
        }

        // Check to see if Interval property is set
        internal bool IsSetInterval()
        {
            return this._interval != null;
        }

        /// <summary>
        /// Gets and sets the property MaxHeight. 
        /// <para>
        /// The maximum height of thumbnails in pixels. If you specify auto, Elastic Transcoder
        /// uses 1080 (Full HD) as the default value. If you specify a numeric value, enter an
        /// even integer between 32 and 3072.
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
        /// The maximum width of thumbnails in pixels. If you specify auto, Elastic Transcoder
        /// uses 1920 (Full HD) as the default value. If you specify a numeric value, enter an
        /// even integer between 32 and 4096.
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
        /// Gets and sets the property PaddingPolicy. 
        /// <para>
        /// When you set <c>PaddingPolicy</c> to <c>Pad</c>, Elastic Transcoder may add black
        /// bars to the top and bottom and/or left and right sides of thumbnails to make the total
        /// size of the thumbnails match the values that you specified for thumbnail <c>MaxWidth</c>
        /// and <c>MaxHeight</c> settings.
        /// </para>
        /// </summary>
        public string PaddingPolicy
        {
            get { return this._paddingPolicy; }
            set { this._paddingPolicy = value; }
        }

        // Check to see if PaddingPolicy property is set
        internal bool IsSetPaddingPolicy()
        {
            return this._paddingPolicy != null;
        }

        /// <summary>
        /// Gets and sets the property Resolution. <important> 
        /// <para>
        /// To better control resolution and aspect ratio of thumbnails, we recommend that you
        /// use the values <c>MaxWidth</c>, <c>MaxHeight</c>, <c>SizingPolicy</c>, and <c>PaddingPolicy</c>
        /// instead of <c>Resolution</c> and <c>AspectRatio</c>. The two groups of settings are
        /// mutually exclusive. Do not use them together.
        /// </para>
        ///  </important> 
        /// <para>
        /// The width and height of thumbnail files in pixels. Specify a value in the format <c>
        /// <i>width</i> </c> x <c> <i>height</i> </c> where both values are even integers. The
        /// values cannot exceed the width and height that you specified in the <c>Video:Resolution</c>
        /// object.
        /// </para>
        /// </summary>
        public string Resolution
        {
            get { return this._resolution; }
            set { this._resolution = value; }
        }

        // Check to see if Resolution property is set
        internal bool IsSetResolution()
        {
            return this._resolution != null;
        }

        /// <summary>
        /// Gets and sets the property SizingPolicy. 
        /// <para>
        /// Specify one of the following values to control scaling of thumbnails:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <c>Fit</c>: Elastic Transcoder scales thumbnails so they match the value that you
        /// specified in thumbnail MaxWidth or MaxHeight settings without exceeding the other
        /// value. 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>Fill</c>: Elastic Transcoder scales thumbnails so they match the value that you
        /// specified in thumbnail <c>MaxWidth</c> or <c>MaxHeight</c> settings and matches or
        /// exceeds the other value. Elastic Transcoder centers the image in thumbnails and then
        /// crops in the dimension (if any) that exceeds the maximum value.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>Stretch</c>: Elastic Transcoder stretches thumbnails to match the values that
        /// you specified for thumbnail <c>MaxWidth</c> and <c>MaxHeight</c> settings. If the
        /// relative proportions of the input video and thumbnails are different, the thumbnails
        /// will be distorted.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>Keep</c>: Elastic Transcoder does not scale thumbnails. If either dimension of
        /// the input video exceeds the values that you specified for thumbnail <c>MaxWidth</c>
        /// and <c>MaxHeight</c> settings, Elastic Transcoder crops the thumbnails.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>ShrinkToFit</c>: Elastic Transcoder scales thumbnails down so that their dimensions
        /// match the values that you specified for at least one of thumbnail <c>MaxWidth</c>
        /// and <c>MaxHeight</c> without exceeding either value. If you specify this option, Elastic
        /// Transcoder does not scale thumbnails up.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>ShrinkToFill</c>: Elastic Transcoder scales thumbnails down so that their dimensions
        /// match the values that you specified for at least one of <c>MaxWidth</c> and <c>MaxHeight</c>
        /// without dropping below either value. If you specify this option, Elastic Transcoder
        /// does not scale thumbnails up.
        /// </para>
        ///  </li> </ul>
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

    }
}