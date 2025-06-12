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
    /// The details of the thumbnail, including thumbnail base64 string, timecode and the
    /// time when thumbnail was generated.
    /// </summary>
    public partial class ThumbnailDetails
    {
        private string _flowArn;
        private string _thumbnail;
        private List<MessageDetail> _thumbnailMessages = AWSConfigs.InitializeCollections ? new List<MessageDetail>() : null;
        private string _timecode;
        private DateTime? _timestamp;

        /// <summary>
        /// Gets and sets the property FlowArn. 
        /// <para>
        ///  The ARN of the flow that DescribeFlowSourceThumbnail was performed on.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string FlowArn
        {
            get { return this._flowArn; }
            set { this._flowArn = value; }
        }

        // Check to see if FlowArn property is set
        internal bool IsSetFlowArn()
        {
            return this._flowArn != null;
        }

        /// <summary>
        /// Gets and sets the property Thumbnail. 
        /// <para>
        /// Thumbnail Base64 string. 
        /// </para>
        /// </summary>
        public string Thumbnail
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
        ///  Status code and messages about the flow source thumbnail.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Required=true)]
        public List<MessageDetail> ThumbnailMessages
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
        ///  Timecode of thumbnail.
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
        ///  The timestamp of when thumbnail was generated.
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