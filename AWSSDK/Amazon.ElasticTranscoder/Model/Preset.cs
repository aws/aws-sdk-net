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
    public class Preset
    {
        
        private string id;
        private string name;
        private string description;
        private string container;
        private AudioParameters audio;
        private VideoParameters video;
        private Thumbnails thumbnails;
        private string type;

        /// <summary>
        /// Identifier for the new preset. You use this value to get settings for the preset or to delete it.
        ///  
        /// <para>
        /// <b>Constraints:</b>
        /// <list type="definition">
        ///     <item>
        ///         <term>Pattern</term>
        ///         <description>^\d{13}-\w{6}$</description>
        ///     </item>
        /// </list>
        /// </para>
        /// </summary>
        public string Id
        {
            get { return this.id; }
            set { this.id = value; }
        }

        /// <summary>
        /// Sets the Id property
        /// </summary>
        /// <param name="id">The value to set for the Id property </param>
        /// <returns>this instance</returns>
        public Preset WithId(string id)
        {
            this.id = id;
            return this;
        }
            

        // Check to see if Id property is set
        internal bool IsSetId()
        {
            return this.id != null;
        }

        /// <summary>
        /// The name of the preset.
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

        /// <summary>
        /// Sets the Name property
        /// </summary>
        /// <param name="name">The value to set for the Name property </param>
        /// <returns>this instance</returns>
        public Preset WithName(string name)
        {
            this.name = name;
            return this;
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

        /// <summary>
        /// Sets the Description property
        /// </summary>
        /// <param name="description">The value to set for the Description property </param>
        /// <returns>this instance</returns>
        public Preset WithDescription(string description)
        {
            this.description = description;
            return this;
        }
            

        // Check to see if Description property is set
        internal bool IsSetDescription()
        {
            return this.description != null;
        }

        /// <summary>
        /// The container type for the output file. This value must be <c>mp4</c>.
        ///  
        /// <para>
        /// <b>Constraints:</b>
        /// <list type="definition">
        ///     <item>
        ///         <term>Pattern</term>
        ///         <description>^mp4$</description>
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
        public Preset WithContainer(string container)
        {
            this.container = container;
            return this;
        }
            

        // Check to see if Container property is set
        internal bool IsSetContainer()
        {
            return this.container != null;
        }

        /// <summary>
        /// A section of the response body that provides information about the audio preset values.
        ///  
        /// </summary>
        public AudioParameters Audio
        {
            get { return this.audio; }
            set { this.audio = value; }
        }

        /// <summary>
        /// Sets the Audio property
        /// </summary>
        /// <param name="audio">The value to set for the Audio property </param>
        /// <returns>this instance</returns>
        public Preset WithAudio(AudioParameters audio)
        {
            this.audio = audio;
            return this;
        }
            

        // Check to see if Audio property is set
        internal bool IsSetAudio()
        {
            return this.audio != null;
        }

        /// <summary>
        /// A section of the response body that provides information about the video preset values.
        ///  
        /// </summary>
        public VideoParameters Video
        {
            get { return this.video; }
            set { this.video = value; }
        }

        /// <summary>
        /// Sets the Video property
        /// </summary>
        /// <param name="video">The value to set for the Video property </param>
        /// <returns>this instance</returns>
        public Preset WithVideo(VideoParameters video)
        {
            this.video = video;
            return this;
        }
            

        // Check to see if Video property is set
        internal bool IsSetVideo()
        {
            return this.video != null;
        }

        /// <summary>
        /// A section of the response body that provides information about the thumbnail preset values, if any.
        ///  
        /// </summary>
        public Thumbnails Thumbnails
        {
            get { return this.thumbnails; }
            set { this.thumbnails = value; }
        }

        /// <summary>
        /// Sets the Thumbnails property
        /// </summary>
        /// <param name="thumbnails">The value to set for the Thumbnails property </param>
        /// <returns>this instance</returns>
        public Preset WithThumbnails(Thumbnails thumbnails)
        {
            this.thumbnails = thumbnails;
            return this;
        }
            

        // Check to see if Thumbnails property is set
        internal bool IsSetThumbnails()
        {
            return this.thumbnails != null;
        }

        /// <summary>
        /// Whether the preset is a default preset provided by Elastic Transcoder (<c>System</c>) or a preset that you have defined (<c>Custom</c>).
        ///  
        /// <para>
        /// <b>Constraints:</b>
        /// <list type="definition">
        ///     <item>
        ///         <term>Pattern</term>
        ///         <description>(^System$)|(^Custom$)</description>
        ///     </item>
        /// </list>
        /// </para>
        /// </summary>
        public string Type
        {
            get { return this.type; }
            set { this.type = value; }
        }

        /// <summary>
        /// Sets the Type property
        /// </summary>
        /// <param name="type">The value to set for the Type property </param>
        /// <returns>this instance</returns>
        public Preset WithType(string type)
        {
            this.type = type;
            return this;
        }
            

        // Check to see if Type property is set
        internal bool IsSetType()
        {
            return this.type != null;
        }
    }
}
