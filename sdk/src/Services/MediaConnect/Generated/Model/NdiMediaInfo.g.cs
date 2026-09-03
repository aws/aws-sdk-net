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

namespace Amazon.MediaConnect.Model
{
    /// <summary>
    /// Metadata about the audio and video media that is part of the NDI® source content.
    /// This includes details about the individual media streams.
    /// </summary>
    public partial class NdiMediaInfo
    {
        /// <summary>
        /// Gets and sets the property Streams. 
        /// <para>
        ///  A list of the individual media streams that make up the NDI source. This includes
        /// details about each stream's codec, resolution, frame rate, audio channels, and other
        /// parameters. 
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Required = true)]
        public List<NdiMediaStreamInfo> Streams { get; set; } = AWSConfigs.InitializeCollections ? new List<NdiMediaStreamInfo>() : null;

        /// <summary>
        /// Checks to see if the Streams property is set.
        /// </summary>
        internal bool IsSetStreams() => this.Streams != null && (this.Streams.Count > 0 || !AWSConfigs.InitializeCollections);
    }
}
