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
    /// The media stream that you want to add to the flow.
    /// </summary>
    public partial class AddMediaStreamRequest
    {
        /// <summary>
        /// Gets and sets the property Attributes. 
        /// <para>
        ///  The attributes that you want to assign to the new media stream.
        /// </para>
        /// </summary>
        public MediaStreamAttributesRequest Attributes { get; set; }

        /// <summary>
        /// Checks to see if the Attributes property is set.
        /// </summary>
        internal bool IsSetAttributes() => this.Attributes != null;

        /// <summary>
        /// Gets and sets the property ClockRate. 
        /// <para>
        ///  The sample rate (in Hz) for the stream. If the media stream type is video or ancillary
        /// data, set this value to 90000. If the media stream type is audio, set this value to
        /// either 48000 or 96000.
        /// </para>
        /// </summary>
        public int? ClockRate { get; set; }

        /// <summary>
        /// Checks to see if the ClockRate property is set.
        /// </summary>
        internal bool IsSetClockRate() => this.ClockRate.HasValue;

        /// <summary>
        /// Gets and sets the property Description. 
        /// <para>
        ///  A description that can help you quickly identify what your media stream is used for.
        /// </para>
        /// </summary>
        public string Description { get; set; }

        /// <summary>
        /// Checks to see if the Description property is set.
        /// </summary>
        internal bool IsSetDescription() => this.Description != null;

        /// <summary>
        /// Gets and sets the property MediaStreamId. 
        /// <para>
        ///  A unique identifier for the media stream. 
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public int? MediaStreamId { get; set; }

        /// <summary>
        /// Checks to see if the MediaStreamId property is set.
        /// </summary>
        internal bool IsSetMediaStreamId() => this.MediaStreamId.HasValue;

        /// <summary>
        /// Gets and sets the property MediaStreamName. 
        /// <para>
        ///  A name that helps you distinguish one media stream from another.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public string MediaStreamName { get; set; }

        /// <summary>
        /// Checks to see if the MediaStreamName property is set.
        /// </summary>
        internal bool IsSetMediaStreamName() => this.MediaStreamName != null;

        /// <summary>
        /// Gets and sets the property MediaStreamTags. 
        /// <para>
        ///  The key-value pairs that can be used to tag and organize the media stream. 
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public Dictionary<string, string> MediaStreamTags { get; set; } = AWSConfigs.InitializeCollections ? new Dictionary<string, string>() : null;

        /// <summary>
        /// Checks to see if the MediaStreamTags property is set.
        /// </summary>
        internal bool IsSetMediaStreamTags() => this.MediaStreamTags != null && (this.MediaStreamTags.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property MediaStreamType. 
        /// <para>
        ///  The type of media stream.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public MediaStreamType MediaStreamType { get; set; }

        /// <summary>
        /// Checks to see if the MediaStreamType property is set.
        /// </summary>
        internal bool IsSetMediaStreamType() => this.MediaStreamType != null;

        /// <summary>
        /// Gets and sets the property VideoFormat. 
        /// <para>
        ///  The resolution of the video.
        /// </para>
        /// </summary>
        public string VideoFormat { get; set; }

        /// <summary>
        /// Checks to see if the VideoFormat property is set.
        /// </summary>
        internal bool IsSetVideoFormat() => this.VideoFormat != null;
    }
}
