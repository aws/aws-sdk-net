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
    /// A media stream represents one component of your content, such as video, audio, or
    /// ancillary data. After you add a media stream to your flow, you can associate it with
    /// sources and outputs that use the ST 2110 JPEG XS or CDI protocol.
    /// </summary>
    public partial class MediaStream
    {
        /// <summary>
        /// Gets and sets the property Attributes. 
        /// <para>
        ///  Attributes that are related to the media stream.
        /// </para>
        /// </summary>
        public MediaStreamAttributes Attributes { get; set; }

        /// <summary>
        /// Checks to see if the Attributes property is set.
        /// </summary>
        internal bool IsSetAttributes() => this.Attributes != null;

        /// <summary>
        /// Gets and sets the property ClockRate. 
        /// <para>
        ///  The sample rate for the stream. This value is measured in Hz.
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
        /// Gets and sets the property Fmt. 
        /// <para>
        ///  The format type number (sometimes referred to as RTP payload type) of the media stream.
        /// MediaConnect assigns this value to the media stream. For ST 2110 JPEG XS outputs,
        /// you need to provide this value to the receiver.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public int? Fmt { get; set; }

        /// <summary>
        /// Checks to see if the Fmt property is set.
        /// </summary>
        internal bool IsSetFmt() => this.Fmt.HasValue;

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
