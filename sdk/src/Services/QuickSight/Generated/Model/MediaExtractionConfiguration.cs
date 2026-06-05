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
 * Do not modify this file. This file is generated from the quicksight-2018-04-01.normal.json service model.
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
namespace Amazon.QuickSight.Model
{
    /// <summary>
    /// The configuration for media extraction from knowledge base documents.
    /// </summary>
    public partial class MediaExtractionConfiguration
    {
        private AudioExtractionConfiguration _audioExtractionConfiguration;
        private ImageExtractionConfiguration _imageExtractionConfiguration;
        private VideoExtractionConfiguration _videoExtractionConfiguration;

        /// <summary>
        /// Gets and sets the property AudioExtractionConfiguration. 
        /// <para>
        /// The configuration for audio extraction.
        /// </para>
        /// </summary>
        public AudioExtractionConfiguration AudioExtractionConfiguration
        {
            get { return this._audioExtractionConfiguration; }
            set { this._audioExtractionConfiguration = value; }
        }

        // Check to see if AudioExtractionConfiguration property is set
        internal bool IsSetAudioExtractionConfiguration()
        {
            return this._audioExtractionConfiguration != null;
        }

        /// <summary>
        /// Gets and sets the property ImageExtractionConfiguration. 
        /// <para>
        /// The configuration for image extraction.
        /// </para>
        /// </summary>
        public ImageExtractionConfiguration ImageExtractionConfiguration
        {
            get { return this._imageExtractionConfiguration; }
            set { this._imageExtractionConfiguration = value; }
        }

        // Check to see if ImageExtractionConfiguration property is set
        internal bool IsSetImageExtractionConfiguration()
        {
            return this._imageExtractionConfiguration != null;
        }

        /// <summary>
        /// Gets and sets the property VideoExtractionConfiguration. 
        /// <para>
        /// The configuration for video extraction.
        /// </para>
        /// </summary>
        public VideoExtractionConfiguration VideoExtractionConfiguration
        {
            get { return this._videoExtractionConfiguration; }
            set { this._videoExtractionConfiguration = value; }
        }

        // Check to see if VideoExtractionConfiguration property is set
        internal bool IsSetVideoExtractionConfiguration()
        {
            return this._videoExtractionConfiguration != null;
        }

    }
}