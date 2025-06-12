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
    /// The .jpg or .png file associated with an audio file.
    /// </summary>
    public partial class JobAlbumArt
    {
        private List<Artwork> _artwork = AWSConfigs.InitializeCollections ? new List<Artwork>() : null;
        private string _mergePolicy;

        /// <summary>
        /// Gets and sets the property Artwork. 
        /// <para>
        /// The file to be used as album art. There can be multiple artworks associated with an
        /// audio file, to a maximum of 20. Valid formats are <c>.jpg</c> and <c>.png</c> 
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<Artwork> Artwork
        {
            get { return this._artwork; }
            set { this._artwork = value; }
        }

        // Check to see if Artwork property is set
        internal bool IsSetArtwork()
        {
            return this._artwork != null && (this._artwork.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property MergePolicy. 
        /// <para>
        /// A policy that determines how Elastic Transcoder handles the existence of multiple
        /// album artwork files.
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <c>Replace:</c> The specified album art replaces any existing album art.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>Prepend:</c> The specified album art is placed in front of any existing album
        /// art.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>Append:</c> The specified album art is placed after any existing album art.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>Fallback:</c> If the original input file contains artwork, Elastic Transcoder
        /// uses that artwork for the output. If the original input does not contain artwork,
        /// Elastic Transcoder uses the specified album art file.
        /// </para>
        ///  </li> </ul>
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