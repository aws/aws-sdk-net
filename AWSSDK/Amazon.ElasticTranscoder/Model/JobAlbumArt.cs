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
    /// <para>The .jpg or .png file associated with an audio file.</para>
    /// </summary>
    public class JobAlbumArt
    {
        
        private string mergePolicy;
        private List<Artwork> artwork = new List<Artwork>();

        /// <summary>
        /// A policy that determines how Elastic Transcoder will handle the existence of multiple album artwork files. <ul> <li><c>Replace:</c> The
        /// specified album art will replace any existing album art.</li> <li><c>Prepend:</c> The specified album art will be placed in front of any
        /// existing album art.</li> <li><c>Append:</c> The specified album art will be placed after any existing album art.</li> <li><c>Fallback:</c>
        /// If the original input file contains artwork, Elastic Transcoder will use that artwork for the output. If the original input does not contain
        /// artwork, Elastic Transcoder will use the specified album art file.</li> </ul>
        ///  
        /// <para>
        /// <b>Constraints:</b>
        /// <list type="definition">
        ///     <item>
        ///         <term>Pattern</term>
        ///         <description>(^Replace$)|(^Prepend$)|(^Append$)|(^Fallback$)</description>
        ///     </item>
        /// </list>
        /// </para>
        /// </summary>
        public string MergePolicy
        {
            get { return this.mergePolicy; }
            set { this.mergePolicy = value; }
        }

        /// <summary>
        /// Sets the MergePolicy property
        /// </summary>
        /// <param name="mergePolicy">The value to set for the MergePolicy property </param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public JobAlbumArt WithMergePolicy(string mergePolicy)
        {
            this.mergePolicy = mergePolicy;
            return this;
        }
            

        // Check to see if MergePolicy property is set
        internal bool IsSetMergePolicy()
        {
            return this.mergePolicy != null;
        }

        /// <summary>
        /// The file to be used as album art. There can be multiple artworks associated with an audio file, to a maximum of 20. Valid formats are
        /// <c>.jpg</c> and <c>.png</c>
        ///  
        /// </summary>
        public List<Artwork> Artwork
        {
            get { return this.artwork; }
            set { this.artwork = value; }
        }
        /// <summary>
        /// Adds elements to the Artwork collection
        /// </summary>
        /// <param name="artwork">The values to add to the Artwork collection </param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public JobAlbumArt WithArtwork(params Artwork[] artwork)
        {
            foreach (Artwork element in artwork)
            {
                this.artwork.Add(element);
            }

            return this;
        }

        /// <summary>
        /// Adds elements to the Artwork collection
        /// </summary>
        /// <param name="artwork">The values to add to the Artwork collection </param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public JobAlbumArt WithArtwork(IEnumerable<Artwork> artwork)
        {
            foreach (Artwork element in artwork)
            {
                this.artwork.Add(element);
            }

            return this;
        }

        // Check to see if Artwork property is set
        internal bool IsSetArtwork()
        {
            return this.artwork.Count > 0;
        }
    }
}
