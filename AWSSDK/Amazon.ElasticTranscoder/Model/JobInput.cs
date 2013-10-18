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
    /// <para>Information about the file that you're transcoding.</para>
    /// </summary>
    public class JobInput
    {
        
        private string key;
        private string frameRate;
        private string resolution;
        private string aspectRatio;
        private string interlaced;
        private string container;

        /// <summary>
        /// The name of the file to transcode. Elsewhere in the body of the JSON block is the the ID of the pipeline to use for processing the job. The
        /// <c>InputBucket</c> object in that pipeline tells Elastic Transcoder which Amazon S3 bucket to get the file from. If the file name includes a
        /// prefix, such as <c>cooking/lasagna.mpg</c>, include the prefix in the key. If the file isn't in the specified bucket, Elastic Transcoder
        /// returns an error.
        ///  
        /// <para>
        /// <b>Constraints:</b>
        /// <list type="definition">
        ///     <item>
        ///         <term>Length</term>
        ///         <description>1 - 255</description>
        ///     </item>
        /// </list>
        /// </para>
        /// </summary>
        public string Key
        {
            get { return this.key; }
            set { this.key = value; }
        }

        /// <summary>
        /// Sets the Key property
        /// </summary>
        /// <param name="key">The value to set for the Key property </param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public JobInput WithKey(string key)
        {
            this.key = key;
            return this;
        }
            

        // Check to see if Key property is set
        internal bool IsSetKey()
        {
            return this.key != null;
        }

        /// <summary>
        /// The frame rate of the input file. If you want Elastic Transcoder to automatically detect the frame rate of the input file, specify
        /// <c>auto</c>. If you want to specify the frame rate for the input file, enter one of the following values: <c>10</c>, <c>15</c>,
        /// <c>23.97</c>, <c>24</c>, <c>25</c>, <c>29.97</c>, <c>30</c>, <c>60</c> If you specify a value other than <c>auto</c>, Elastic Transcoder
        /// disables automatic detection of the frame rate.
        ///  
        /// <para>
        /// <b>Constraints:</b>
        /// <list type="definition">
        ///     <item>
        ///         <term>Pattern</term>
        ///         <description>(^auto$)|(^10$)|(^15$)|(^23.97$)|(^24$)|(^25$)|(^29.97$)|(^30$)|(^50$)|(^60$)</description>
        ///     </item>
        /// </list>
        /// </para>
        /// </summary>
        public string FrameRate
        {
            get { return this.frameRate; }
            set { this.frameRate = value; }
        }

        /// <summary>
        /// Sets the FrameRate property
        /// </summary>
        /// <param name="frameRate">The value to set for the FrameRate property </param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public JobInput WithFrameRate(string frameRate)
        {
            this.frameRate = frameRate;
            return this;
        }
            

        // Check to see if FrameRate property is set
        internal bool IsSetFrameRate()
        {
            return this.frameRate != null;
        }

        /// <summary>
        /// This value must be <c>auto</c>, which causes Elastic Transcoder to automatically detect the resolution of the input file.
        ///  
        /// <para>
        /// <b>Constraints:</b>
        /// <list type="definition">
        ///     <item>
        ///         <term>Pattern</term>
        ///         <description>(^auto$)|(^\d{1,5}x\d{1,5}$)</description>
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
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public JobInput WithResolution(string resolution)
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
        /// The aspect ratio of the input file. If you want Elastic Transcoder to automatically detect the aspect ratio of the input file, specify
        /// <c>auto</c>. If you want to specify the aspect ratio for the output file, enter one of the following values: <c>1:1</c>, <c>4:3</c>,
        /// <c>3:2</c>, <c>16:9</c> If you specify a value other than <c>auto</c>, Elastic Transcoder disables automatic detection of the aspect ratio.
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
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public JobInput WithAspectRatio(string aspectRatio)
        {
            this.aspectRatio = aspectRatio;
            return this;
        }
            

        // Check to see if AspectRatio property is set
        internal bool IsSetAspectRatio()
        {
            return this.aspectRatio != null;
        }

        /// <summary>
        /// Whether the input file is interlaced. If you want Elastic Transcoder to automatically detect whether the input file is interlaced, specify
        /// <c>auto</c>. If you want to specify whether the input file is interlaced, enter one of the following values: <c>true</c>, <c>false</c> If
        /// you specify a value other than <c>auto</c>, Elastic Transcoder disables automatic detection of interlacing.
        ///  
        /// <para>
        /// <b>Constraints:</b>
        /// <list type="definition">
        ///     <item>
        ///         <term>Pattern</term>
        ///         <description>(^auto$)|(^true$)|(^false$)</description>
        ///     </item>
        /// </list>
        /// </para>
        /// </summary>
        public string Interlaced
        {
            get { return this.interlaced; }
            set { this.interlaced = value; }
        }

        /// <summary>
        /// Sets the Interlaced property
        /// </summary>
        /// <param name="interlaced">The value to set for the Interlaced property </param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public JobInput WithInterlaced(string interlaced)
        {
            this.interlaced = interlaced;
            return this;
        }
            

        // Check to see if Interlaced property is set
        internal bool IsSetInterlaced()
        {
            return this.interlaced != null;
        }

        /// <summary>
        /// The container type for the input file. If you want Elastic Transcoder to automatically detect the container type of the input file, specify
        /// <c>auto</c>. If you want to specify the container type for the input file, enter one of the following values: <c>3gp</c>, <c>aac</c>,
        /// <c>asf</c>, <c>avi</c>, <c>divx</c>, <c>flv</c>, <c>m4a</c>, <c>mkv</c>, <c>mov</c>, <c>mp3</c>, <c>mp4</c>, <c>mpeg</c>, <c>mpeg-ps</c>,
        /// <c>mpeg-ts</c>, <c>mxf</c>, <c>ogg</c>, <c>vob</c>, <c>wav</c>, <c>webm</c>
        ///  
        /// <para>
        /// <b>Constraints:</b>
        /// <list type="definition">
        ///     <item>
        ///         <term>Pattern</term>
        ///         <description>(^auto$)|(^3gp$)|(^asf$)|(^avi$)|(^divx$)|(^flv$)|(^mkv$)|(^mov$)|(^mp4$)|(^mpeg$)|(^mpeg-ps$)|(^mpeg-ts$)|(^mxf$)|(^ogg$)|(^ts$)|(^vob$)|(^wav$)|(^webm$)|(^mp3$)|(^m4a$)|(^aac$)</description>
        ///     </item>
        /// </list>
        /// </para>
        /// </summary>
        public string Container
        {
            get { return this.container; }
            set { this.container = value; }
        }

        /// <summary>
        /// Sets the Container property
        /// </summary>
        /// <param name="container">The value to set for the Container property </param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public JobInput WithContainer(string container)
        {
            this.container = container;
            return this;
        }
            

        // Check to see if Container property is set
        internal bool IsSetContainer()
        {
            return this.container != null;
        }
    }
}
