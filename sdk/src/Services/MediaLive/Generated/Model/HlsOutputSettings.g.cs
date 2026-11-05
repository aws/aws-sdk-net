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

namespace Amazon.MediaLive.Model
{
    /// <summary>
    /// Hls Output Settings
    /// </summary>
    public partial class HlsOutputSettings
    {
        /// <summary>
        /// Gets and sets the property H265PackagingType. Only applicable when this output is
        /// referencing an H.265 video description. Specifies whether MP4 segments should be packaged
        /// as HEV1 or HVC1.
        /// </summary>
        public HlsH265PackagingType H265PackagingType { get; set; }

        /// <summary>
        /// Checks to see if the H265PackagingType property is set.
        /// </summary>
        internal bool IsSetH265PackagingType() => this.H265PackagingType != null;

        /// <summary>
        /// Gets and sets the property HlsSettings. Settings regarding the underlying stream.
        /// These settings are different for audio-only outputs.
        /// </summary>
        [AWSProperty(Required = true)]
        public HlsSettings HlsSettings { get; set; }

        /// <summary>
        /// Checks to see if the HlsSettings property is set.
        /// </summary>
        internal bool IsSetHlsSettings() => this.HlsSettings != null;

        /// <summary>
        /// Gets and sets the property NameModifier. String concatenated to the end of the destination
        /// filename. Accepts \"Format Identifiers\":#formatIdentifierParameters.
        /// </summary>
        public string NameModifier { get; set; }

        /// <summary>
        /// Checks to see if the NameModifier property is set.
        /// </summary>
        internal bool IsSetNameModifier() => this.NameModifier != null;

        /// <summary>
        /// Gets and sets the property SegmentModifier. String concatenated to end of segment
        /// filenames.
        /// </summary>
        public string SegmentModifier { get; set; }

        /// <summary>
        /// Checks to see if the SegmentModifier property is set.
        /// </summary>
        internal bool IsSetSegmentModifier() => this.SegmentModifier != null;
    }
}
