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
 * Do not modify this file. This file is generated from the mediaconnect-2018-11-14.normal.json service model.
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
        private MemoryStream _thumbnail;
        private List<RouterInputMessage> _thumbnailMessages = AWSConfigs.InitializeCollections ? new List<RouterInputMessage>() : null;
        private string _timecode;
        private DateTime? _timestamp;

        /// <summary>
        /// Gets and sets the property Thumbnail. 
        /// <para>
        /// The thumbnail image, encoded as a Base64-encoded binary data object.
        /// </para>
        /// </summary>
        public MemoryStream Thumbnail
        {
            get { return this._thumbnail; }
            set { this._thumbnail = value; }
        }

        // Check to see if Thumbnail property is set
        internal bool IsSetThumbnail()
        {
            return this._thumbnail != null;
        }

        /// <summary>
        /// Gets and sets the property ThumbnailMessages. 
        /// <para>
        /// The messages associated with the router input thumbnail.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Required=true)]
        public List<RouterInputMessage> ThumbnailMessages
        {
            get { return this._thumbnailMessages; }
            set { this._thumbnailMessages = value; }
        }

        // Check to see if ThumbnailMessages property is set
        internal bool IsSetThumbnailMessages()
        {
            return this._thumbnailMessages != null && (this._thumbnailMessages.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property Timecode. 
        /// <para>
        /// The timecode associated with the thumbnail.
        /// </para>
        /// </summary>
        public string Timecode
        {
            get { return this._timecode; }
            set { this._timecode = value; }
        }

        // Check to see if Timecode property is set
        internal bool IsSetTimecode()
        {
            return this._timecode != null;
        }

        /// <summary>
        /// Gets and sets the property Timestamp. 
        /// <para>
        /// The timestamp associated with the thumbnail.
        /// </para>
        /// </summary>
        public DateTime? Timestamp
        {
            get { return this._timestamp; }
            set { this._timestamp = value; }
        }

        // Check to see if Timestamp property is set
        internal bool IsSetTimestamp()
        {
            return this._timestamp.HasValue; 
        }

    }
}