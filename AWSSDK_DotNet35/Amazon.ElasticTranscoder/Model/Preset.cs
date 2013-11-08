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
    /// <para>Presets are templates that contain most of the settings for transcoding media files from one format to another. Elastic Transcoder
    /// includes some default presets for common formats, for example, several iPod and iPhone versions. You can also create your own presets for
    /// formats that aren't included among the default presets. You specify which preset you want to use when you create a job.</para>
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
        /// A section of the response body that provides information about the audio preset values.
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
        /// A section of the response body that provides information about the video preset values.
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
        /// A section of the response body that provides information about the thumbnail preset values, if any.
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

        // Check to see if Type property is set
        internal bool IsSetType()
        {
            return this.type != null;
        }
    }
}
