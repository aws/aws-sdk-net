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
    /// The details of a thumbnail associated with a router input, including the thumbnail
    /// messages, the thumbnail image, the timecode, and the timestamp.
    /// </summary>
    public partial class RouterInputThumbnailDetails
    {
        /// <summary>
        /// Gets and sets the property Thumbnail. 
        /// <para>
        /// The thumbnail image, encoded as a Base64-encoded binary data object.
        /// </para>
        /// </summary>
        public MemoryStream Thumbnail { get; set; }

        /// <summary>
        /// Checks to see if the Thumbnail property is set.
        /// </summary>
        internal bool IsSetThumbnail() => this.Thumbnail != null;

        /// <summary>
        /// Gets and sets the property ThumbnailMessages. 
        /// <para>
        /// The messages associated with the router input thumbnail.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Required = true)]
        public List<RouterInputMessage> ThumbnailMessages { get; set; } = AWSConfigs.InitializeCollections ? new List<RouterInputMessage>() : null;

        /// <summary>
        /// Checks to see if the ThumbnailMessages property is set.
        /// </summary>
        internal bool IsSetThumbnailMessages() => this.ThumbnailMessages != null && (this.ThumbnailMessages.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property Timecode. 
        /// <para>
        /// The timecode associated with the thumbnail.
        /// </para>
        /// </summary>
        public string Timecode { get; set; }

        /// <summary>
        /// Checks to see if the Timecode property is set.
        /// </summary>
        internal bool IsSetTimecode() => this.Timecode != null;

        /// <summary>
        /// Gets and sets the property Timestamp. 
        /// <para>
        /// The timestamp associated with the thumbnail.
        /// </para>
        /// </summary>
        public DateTime? Timestamp { get; set; }

        /// <summary>
        /// Checks to see if the Timestamp property is set.
        /// </summary>
        internal bool IsSetTimestamp() => this.Timestamp.HasValue;
    }
}
