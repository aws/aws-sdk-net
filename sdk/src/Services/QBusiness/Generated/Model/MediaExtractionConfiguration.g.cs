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
 * Do not modify this file. This file is generated from the smithy.json service model.
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

namespace Amazon.QBusiness.Model
{
    /// <summary>
    /// The configuration for extracting information from media in documents.
    /// </summary>
    public partial class MediaExtractionConfiguration
    {
        /// <summary>
        /// Gets and sets the property AudioExtractionConfiguration. 
        /// <para>
        /// Configuration settings for extracting and processing audio content from media files.
        /// </para>
        /// </summary>
        public AudioExtractionConfiguration AudioExtractionConfiguration { get; set; }

        /// <summary>
        /// Checks to see if the AudioExtractionConfiguration property is set.
        /// </summary>
        internal bool IsSetAudioExtractionConfiguration() => this.AudioExtractionConfiguration != null;

        /// <summary>
        /// Gets and sets the property ImageExtractionConfiguration. 
        /// <para>
        /// The configuration for extracting semantic meaning from images in documents. For more
        /// information, see <a href="https://docs.aws.amazon.com/amazonq/latest/qbusiness-ug/extracting-meaning-from-images.html">Extracting
        /// semantic meaning from images and visuals</a>. 
        /// </para>
        /// </summary>
        public ImageExtractionConfiguration ImageExtractionConfiguration { get; set; }

        /// <summary>
        /// Checks to see if the ImageExtractionConfiguration property is set.
        /// </summary>
        internal bool IsSetImageExtractionConfiguration() => this.ImageExtractionConfiguration != null;

        /// <summary>
        /// Gets and sets the property VideoExtractionConfiguration. 
        /// <para>
        /// Configuration settings for extracting and processing video content from media files.
        /// </para>
        /// </summary>
        public VideoExtractionConfiguration VideoExtractionConfiguration { get; set; }

        /// <summary>
        /// Checks to see if the VideoExtractionConfiguration property is set.
        /// </summary>
        internal bool IsSetVideoExtractionConfiguration() => this.VideoExtractionConfiguration != null;
    }
}
