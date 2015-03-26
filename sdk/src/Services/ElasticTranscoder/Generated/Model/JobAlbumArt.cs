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
    /// The .jpg or .png file associated with an audio file.
    /// </summary>
    public partial class JobAlbumArt
    {
        private List<Artwork> _artwork = new List<Artwork>();
        private string _mergePolicy;

        /// <summary>
        /// Gets and sets the property Artwork. 
        /// <para>
        /// The file to be used as album art. There can be multiple artworks associated with an
        /// audio file, to a maximum of 20. Valid formats are <code>.jpg</code> and <code>.png</code>
        /// </para>
        /// </summary>
        public List<Artwork> Artwork
        {
            get { return this._artwork; }
            set { this._artwork = value; }
        }

        // Check to see if Artwork property is set
        internal bool IsSetArtwork()
        {
            return this._artwork != null && this._artwork.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property MergePolicy. 
        /// <para>
        /// A policy that determines how Elastic Transcoder will handle the existence of multiple
        /// album artwork files.
        /// </para>
        ///  
        /// <para>
        ///  <ul> <li> <code>Replace:</code> The specified album art will replace any existing
        /// album art.</li> <li> <code>Prepend:</code> The specified album art will be placed
        /// in front of any existing album art.</li> <li> <code>Append:</code> The specified album
        /// art will be placed after any existing album art.</li> <li> <code>Fallback:</code>
        /// If the original input file contains artwork, Elastic Transcoder will use that artwork
        /// for the output. If the original input does not contain artwork, Elastic Transcoder
        /// will use the specified album art file.</li> </ul> 
        /// </para>
        /// </summary>
        public string MergePolicy
        {
            get { return this._mergePolicy; }
            set { this._mergePolicy = value; }
        }

        // Check to see if MergePolicy property is set
        internal bool IsSetMergePolicy()
        {
            return this._mergePolicy != null;
        }

    }
}