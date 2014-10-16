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
    /// Information about the file that you're transcoding.
    /// </summary>
    public partial class JobInput
    {
        private string _aspectRatio;
        private string _container;
        private string _frameRate;
        private string _interlaced;
        private string _key;
        private string _resolution;

        /// <summary>
        /// Gets and sets the property AspectRatio. 
        /// <para>
        ///  The aspect ratio of the input file. If you want Elastic Transcoder to automatically
        /// detect the aspect ratio of the input file, specify <code>auto</code>. If you want
        /// to specify the aspect ratio for the output file, enter one of the following values:
        /// 
        /// </para>
        ///  
        /// <para>
        ///  <code>1:1</code>, <code>4:3</code>, <code>3:2</code>, <code>16:9</code> 
        /// </para>
        ///  
        /// <para>
        ///  If you specify a value other than <code>auto</code>, Elastic Transcoder disables
        /// automatic detection of the aspect ratio. 
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
        /// Gets and sets the property Container. 
        /// <para>
        /// The container type for the input file. If you want Elastic Transcoder to automatically
        /// detect the container type of the input file, specify <code>auto</code>. If you want
        /// to specify the container type for the input file, enter one of the following values:
        /// 
        /// </para>
        ///  
        /// <para>
        ///  <code>3gp</code>, <code>aac</code>, <code>asf</code>, <code>avi</code>, <code>divx</code>,
        /// <code>flv</code>, <code>m4a</code>, <code>mkv</code>, <code>mov</code>, <code>mp3</code>,
        /// <code>mp4</code>, <code>mpeg</code>, <code>mpeg-ps</code>, <code>mpeg-ts</code>, <code>mxf</code>,
        /// <code>ogg</code>, <code>vob</code>, <code>wav</code>, <code>webm</code> 
        /// </para>
        /// </summary>
        public string Container
        {
            get { return this._container; }
            set { this._container = value; }
        }

        // Check to see if Container property is set
        internal bool IsSetContainer()
        {
            return this._container != null;
        }

        /// <summary>
        /// Gets and sets the property FrameRate. 
        /// <para>
        /// The frame rate of the input file. If you want Elastic Transcoder to automatically
        /// detect the frame rate of the input file, specify <code>auto</code>. If you want to
        /// specify the frame rate for the input file, enter one of the following values: 
        /// </para>
        ///  
        /// <para>
        ///  <code>10</code>, <code>15</code>, <code>23.97</code>, <code>24</code>, <code>25</code>,
        /// <code>29.97</code>, <code>30</code>, <code>60</code> 
        /// </para>
        ///  
        /// <para>
        /// If you specify a value other than <code>auto</code>, Elastic Transcoder disables automatic
        /// detection of the frame rate.
        /// </para>
        /// </summary>
        public string FrameRate
        {
            get { return this._frameRate; }
            set { this._frameRate = value; }
        }

        // Check to see if FrameRate property is set
        internal bool IsSetFrameRate()
        {
            return this._frameRate != null;
        }

        /// <summary>
        /// Gets and sets the property Interlaced. 
        /// <para>
        /// Whether the input file is interlaced. If you want Elastic Transcoder to automatically
        /// detect whether the input file is interlaced, specify <code>auto</code>. If you want
        /// to specify whether the input file is interlaced, enter one of the following values:
        /// </para>
        ///  
        /// <para>
        /// <code>true</code>, <code>false</code>
        /// </para>
        ///  
        /// <para>
        /// If you specify a value other than <code>auto</code>, Elastic Transcoder disables automatic
        /// detection of interlacing.
        /// </para>
        /// </summary>
        public string Interlaced
        {
            get { return this._interlaced; }
            set { this._interlaced = value; }
        }

        // Check to see if Interlaced property is set
        internal bool IsSetInterlaced()
        {
            return this._interlaced != null;
        }

        /// <summary>
        /// Gets and sets the property Key. 
        /// <para>
        ///  The name of the file to transcode. Elsewhere in the body of the JSON block is the
        /// the ID of the pipeline to use for processing the job. The <code>InputBucket</code>
        /// object in that pipeline tells Elastic Transcoder which Amazon S3 bucket to get the
        /// file from. 
        /// </para>
        ///  
        /// <para>
        /// If the file name includes a prefix, such as <code>cooking/lasagna.mpg</code>, include
        /// the prefix in the key. If the file isn't in the specified bucket, Elastic Transcoder
        /// returns an error.
        /// </para>
        /// </summary>
        public string Key
        {
            get { return this._key; }
            set { this._key = value; }
        }

        // Check to see if Key property is set
        internal bool IsSetKey()
        {
            return this._key != null;
        }

        /// <summary>
        /// Gets and sets the property Resolution. 
        /// <para>
        /// This value must be <code>auto</code>, which causes Elastic Transcoder to automatically
        /// detect the resolution of the input file.
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

    }
}