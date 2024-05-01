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
    /// Presets are templates that contain most of the settings for transcoding media files
    /// from one format to another. Elastic Transcoder includes some default presets for common
    /// formats, for example, several iPod and iPhone versions. You can also create your own
    /// presets for formats that aren't included among the default presets. You specify which
    /// preset you want to use when you create a job.
    /// </summary>
    public partial class Preset
    {
        private string _arn;
        private AudioParameters _audio;
        private string _container;
        private string _description;
        private string _id;
        private string _name;
        private Thumbnails _thumbnails;
        private string _type;
        private VideoParameters _video;

        /// <summary>
        /// Gets and sets the property Arn. 
        /// <para>
        /// The Amazon Resource Name (ARN) for the preset.
        /// </para>
        /// </summary>
        public string Arn
        {
            get { return this._arn; }
            set { this._arn = value; }
        }

        // Check to see if Arn property is set
        internal bool IsSetArn()
        {
            return this._arn != null;
        }

        /// <summary>
        /// Gets and sets the property Audio. 
        /// <para>
        /// A section of the response body that provides information about the audio preset values.
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
        /// Gets and sets the property Id. 
        /// <para>
        /// Identifier for the new preset. You use this value to get settings for the preset or
        /// to delete it.
        /// </para>
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
        /// Gets and sets the property Name. 
        /// <para>
        /// The name of the preset.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=40)]
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
        /// A section of the response body that provides information about the thumbnail preset
        /// values, if any.
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
        /// Gets and sets the property Type. 
        /// <para>
        /// Whether the preset is a default preset provided by Elastic Transcoder (<c>System</c>)
        /// or a preset that you have defined (<c>Custom</c>).
        /// </para>
        /// </summary>
        public string Type
        {
            get { return this._type; }
            set { this._type = value; }
        }

        // Check to see if Type property is set
        internal bool IsSetType()
        {
            return this._type != null;
        }

        /// <summary>
        /// Gets and sets the property Video. 
        /// <para>
        /// A section of the response body that provides information about the video preset values.
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