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
    /// Presets are templates that contain most of the settings for transcoding media files
    /// from            one format to another. Elastic Transcoder includes some default presets
    /// for common formats, for            example, several iPod and iPhone versions. You
    /// can also create your own presets for            formats that aren't included among
    /// the default presets. You specify which preset you            want to use when you
    /// create a job.
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


        /// <summary>
        /// Sets the Arn property
        /// </summary>
        /// <param name="arn">The value to set for the Arn property </param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public Preset WithArn(string arn)
        {
            this._arn = arn;
            return this;
        }

        // Check to see if Arn property is set
        internal bool IsSetArn()
        {
            return this._arn != null;
        }


        /// <summary>
        /// Gets and sets the property Audio. 
        /// <para>
        /// A section of the response body that provides information about the audio preset  
        ///          values.
        /// </para>
        /// </summary>
        public AudioParameters Audio
        {
            get { return this._audio; }
            set { this._audio = value; }
        }


        /// <summary>
        /// Sets the Audio property
        /// </summary>
        /// <param name="audio">The value to set for the Audio property </param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public Preset WithAudio(AudioParameters audio)
        {
            this._audio = audio;
            return this;
        }

        // Check to see if Audio property is set
        internal bool IsSetAudio()
        {
            return this._audio != null;
        }


        /// <summary>
        /// Gets and sets the property Container. 
        /// <para>
        /// The container type for the output file. Valid values include <code>mp3</code>,   
        ///         <code>mp4</code>, <code>ogg</code>, <code>ts</code>, and <code>webm</code>.
        /// </para>
        /// </summary>
        public string Container
        {
            get { return this._container; }
            set { this._container = value; }
        }


        /// <summary>
        /// Sets the Container property
        /// </summary>
        /// <param name="container">The value to set for the Container property </param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public Preset WithContainer(string container)
        {
            this._container = container;
            return this;
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
        public string Description
        {
            get { return this._description; }
            set { this._description = value; }
        }


        /// <summary>
        /// Sets the Description property
        /// </summary>
        /// <param name="description">The value to set for the Description property </param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public Preset WithDescription(string description)
        {
            this._description = description;
            return this;
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
        /// to            delete it.
        /// </para>
        /// </summary>
        public string Id
        {
            get { return this._id; }
            set { this._id = value; }
        }


        /// <summary>
        /// Sets the Id property
        /// </summary>
        /// <param name="id">The value to set for the Id property </param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public Preset WithId(string id)
        {
            this._id = id;
            return this;
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
        public string Name
        {
            get { return this._name; }
            set { this._name = value; }
        }


        /// <summary>
        /// Sets the Name property
        /// </summary>
        /// <param name="name">The value to set for the Name property </param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public Preset WithName(string name)
        {
            this._name = name;
            return this;
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
        ///            values, if any.
        /// </para>
        /// </summary>
        public Thumbnails Thumbnails
        {
            get { return this._thumbnails; }
            set { this._thumbnails = value; }
        }


        /// <summary>
        /// Sets the Thumbnails property
        /// </summary>
        /// <param name="thumbnails">The value to set for the Thumbnails property </param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public Preset WithThumbnails(Thumbnails thumbnails)
        {
            this._thumbnails = thumbnails;
            return this;
        }

        // Check to see if Thumbnails property is set
        internal bool IsSetThumbnails()
        {
            return this._thumbnails != null;
        }


        /// <summary>
        /// Gets and sets the property Type. 
        /// <para>
        /// Whether the preset is a default preset provided by Elastic Transcoder            
        ///    (<code>System</code>) or a preset that you have defined (<code>Custom</code>).
        /// </para>
        /// </summary>
        public string Type
        {
            get { return this._type; }
            set { this._type = value; }
        }


        /// <summary>
        /// Sets the Type property
        /// </summary>
        /// <param name="type">The value to set for the Type property </param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public Preset WithType(string type)
        {
            this._type = type;
            return this;
        }

        // Check to see if Type property is set
        internal bool IsSetType()
        {
            return this._type != null;
        }


        /// <summary>
        /// Gets and sets the property Video. 
        /// <para>
        /// A section of the response body that provides information about the video preset  
        ///          values.
        /// </para>
        /// </summary>
        public VideoParameters Video
        {
            get { return this._video; }
            set { this._video = value; }
        }


        /// <summary>
        /// Sets the Video property
        /// </summary>
        /// <param name="video">The value to set for the Video property </param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public Preset WithVideo(VideoParameters video)
        {
            this._video = video;
            return this;
        }

        // Check to see if Video property is set
        internal bool IsSetVideo()
        {
            return this._video != null;
        }

    }
}