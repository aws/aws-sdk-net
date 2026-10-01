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
    /// Container for details about different types of media sources (image, audio, or video).
    /// </summary>
    public partial class SourceDetails
    {
        /// <summary>
        /// Gets and sets the property AudioSourceDetails. 
        /// <para>
        /// Details specific to audio content within the source.
        /// </para>
        /// </summary>
        public AudioSourceDetails AudioSourceDetails { get; set; }

        /// <summary>
        /// Checks to see if the AudioSourceDetails property is set.
        /// </summary>
        internal bool IsSetAudioSourceDetails() => this.AudioSourceDetails != null;

        /// <summary>
        /// Gets and sets the property ImageSourceDetails. 
        /// <para>
        /// Details specific to image content within the source.
        /// </para>
        /// </summary>
        public ImageSourceDetails ImageSourceDetails { get; set; }

        /// <summary>
        /// Checks to see if the ImageSourceDetails property is set.
        /// </summary>
        internal bool IsSetImageSourceDetails() => this.ImageSourceDetails != null;

        /// <summary>
        /// Gets and sets the property VideoSourceDetails. 
        /// <para>
        /// Details specific to video content within the source.
        /// </para>
        /// </summary>
        public VideoSourceDetails VideoSourceDetails { get; set; }

        /// <summary>
        /// Checks to see if the VideoSourceDetails property is set.
        /// </summary>
        internal bool IsSetVideoSourceDetails() => this.VideoSourceDetails != null;
    }
}
