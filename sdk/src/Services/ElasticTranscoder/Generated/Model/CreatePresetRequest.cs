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
    /// Container for the parameters to the CreatePreset operation.
    /// The CreatePreset operation creates a preset with settings that you specify.
    /// 
    ///  <important> 
    /// <para>
    /// Elastic Transcoder checks the CreatePreset settings to ensure that they meet Elastic
    /// Transcoder requirements and to determine whether they comply with H.264 standards.
    /// If your settings are not valid for Elastic Transcoder, Elastic Transcoder returns
    /// an HTTP 400 response (<c>ValidationException</c>) and does not create the preset.
    /// If the settings are valid for Elastic Transcoder but aren't strictly compliant with
    /// the H.264 standard, Elastic Transcoder creates the preset and returns a warning message
    /// in the response. This helps you determine whether your settings comply with the H.264
    /// standard while giving you greater flexibility with respect to the video that Elastic
    /// Transcoder produces.
    /// </para>
    ///  </important> 
    /// <para>
    /// Elastic Transcoder uses the H.264 video-compression format. For more information,
    /// see the International Telecommunication Union publication <i>Recommendation ITU-T
    /// H.264: Advanced video coding for generic audiovisual services</i>.
    /// </para>
    /// </summary>
    public partial class CreatePresetRequest : AmazonElasticTranscoderRequest
    {
        private AudioParameters _audio;
        private string _container;
        private string _description;
        private string _name;
        private Thumbnails _thumbnails;
        private VideoParameters _video;

        /// <summary>
        /// Gets and sets the property Audio. 
        /// <para>
        /// A section of the request body that specifies the audio parameters.
        /// </para>
        /// </summary>
        public AudioParameters Audio
        {
            get { return this._audio; }
            set { this._audio = value; }
        }

        // Check to see if Audio property is set
        internal bool IsSetAudio()
        {
            return this._audio != null;
        }

        /// <summary>
        /// Gets and sets the property Container. 
        /// <para>
        /// The container type for the output file. Valid values include <c>flac</c>, <c>flv</c>,
        /// <c>fmp4</c>, <c>gif</c>, <c>mp3</c>, <c>mp4</c>, <c>mpg</c>, <c>mxf</c>, <c>oga</c>,
        /// <c>ogg</c>, <c>ts</c>, and <c>webm</c>.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
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
        /// Gets and sets the property Description. 
        /// <para>
        /// A description of the preset.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=255)]
        public string Description
        {
            get { return this._description; }
            set { this._description = value; }
        }

        // Check to see if Description property is set
        internal bool IsSetDescription()
        {
            return this._description != null;
        }

        /// <summary>
        /// Gets and sets the property Name. 
        /// <para>
        /// The name of the preset. We recommend that the name be unique within the AWS account,
        /// but uniqueness is not enforced.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=40)]
        public string Name
        {
            get { return this._name; }
            set { this._name = value; }
        }

        // Check to see if Name property is set
        internal bool IsSetName()
        {
            return this._name != null;
        }

        /// <summary>
        /// Gets and sets the property Thumbnails. 
        /// <para>
        /// A section of the request body that specifies the thumbnail parameters, if any.
        /// </para>
        /// </summary>
        public Thumbnails Thumbnails
        {
            get { return this._thumbnails; }
            set { this._thumbnails = value; }
        }

        // Check to see if Thumbnails property is set
        internal bool IsSetThumbnails()
        {
            return this._thumbnails != null;
        }

        /// <summary>
        /// Gets and sets the property Video. 
        /// <para>
        /// A section of the request body that specifies the video parameters.
        /// </para>
        /// </summary>
        public VideoParameters Video
        {
            get { return this._video; }
            set { this._video = value; }
        }

        // Check to see if Video property is set
        internal bool IsSetVideo()
        {
            return this._video != null;
        }

    }
}