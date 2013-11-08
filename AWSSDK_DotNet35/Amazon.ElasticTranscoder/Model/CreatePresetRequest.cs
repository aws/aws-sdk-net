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

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.ElasticTranscoder.Model
{
    /// <summary>
    /// Container for the parameters to the CreatePreset operation.
    /// <para>The CreatePreset operation creates a preset with settings that you specify.</para> <para><b>IMPORTANT:</b>Elastic Transcoder checks
    /// the CreatePreset settings to ensure that they meet Elastic Transcoder requirements and to determine whether they comply with H.264
    /// standards. If your settings are not valid for Elastic Transcoder, Elastic Transcoder returns an HTTP 400 response (ValidationException) and
    /// does not create the preset. If the settings are valid for Elastic Transcoder but aren't strictly compliant with the H.264 standard, Elastic
    /// Transcoder creates the preset and returns a warning message in the response. This helps you determine whether your settings comply with the
    /// H.264 standard while giving you greater flexibility with respect to the video that Elastic Transcoder produces.</para> <para>Elastic
    /// Transcoder uses the H.264 video-compression format. For more information, see the International Telecommunication Union publication
    /// <i>Recommendation ITU-T H.264: Advanced video coding for generic audiovisual services</i> .</para>
    /// </summary>
    public partial class CreatePresetRequest : AmazonElasticTranscoderRequest
    {
        private string name;
        private string description;
        private string container;
        private VideoParameters video;
        private AudioParameters audio;
        private Thumbnails thumbnails;


        /// <summary>
        /// The name of the preset. We recommend that the name be unique within the AWS account, but uniqueness is not enforced.
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
        public string Name
        {
            get { return this.name; }
            set { this.name = value; }
        }

        // Check to see if Name property is set
        internal bool IsSetName()
        {
            return this.name != null;
        }

        /// <summary>
        /// A description of the preset.
        ///  
        /// <para>
        /// <b>Constraints:</b>
        /// <list type="definition">
        ///     <item>
        ///         <term>Length</term>
        ///         <description>0 - 255</description>
        ///     </item>
        /// </list>
        /// </para>
        /// </summary>
        public string Description
        {
            get { return this.description; }
            set { this.description = value; }
        }

        // Check to see if Description property is set
        internal bool IsSetDescription()
        {
            return this.description != null;
        }

        /// <summary>
        /// The container type for the output file. Valid values include <c>mp3</c>, <c>mp4</c>, <c>ogg</c>, <c>ts</c>, and <c>webm</c>.
        ///  
        /// <para>
        /// <b>Constraints:</b>
        /// <list type="definition">
        ///     <item>
        ///         <term>Pattern</term>
        ///         <description>(^mp4$)|(^ts$)|(^webm$)|(^mp3$)|(^ogg$)</description>
        ///     </item>
        /// </list>
        /// </para>
        /// </summary>
        public string Container
        {
            get { return this.container; }
            set { this.container = value; }
        }

        // Check to see if Container property is set
        internal bool IsSetContainer()
        {
            return this.container != null;
        }

        /// <summary>
        /// A section of the request body that specifies the video parameters.
        ///  
        /// </summary>
        public VideoParameters Video
        {
            get { return this.video; }
            set { this.video = value; }
        }

        // Check to see if Video property is set
        internal bool IsSetVideo()
        {
            return this.video != null;
        }

        /// <summary>
        /// A section of the request body that specifies the audio parameters.
        ///  
        /// </summary>
        public AudioParameters Audio
        {
            get { return this.audio; }
            set { this.audio = value; }
        }

        // Check to see if Audio property is set
        internal bool IsSetAudio()
        {
            return this.audio != null;
        }

        /// <summary>
        /// A section of the request body that specifies the thumbnail parameters, if any.
        ///  
        /// </summary>
        public Thumbnails Thumbnails
        {
            get { return this.thumbnails; }
            set { this.thumbnails = value; }
        }

        // Check to see if Thumbnails property is set
        internal bool IsSetThumbnails()
        {
            return this.thumbnails != null;
        }

    }
}
    
