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

namespace Amazon.KinesisVideo.Model
{
    /// <summary>
    /// Container for the parameters to the UpdateStream operation. Updates stream metadata,
    /// such as the device name and media type. <para> You must provide the stream name or
    /// the Amazon Resource Name (ARN) of the stream. </para> <para> To make sure that you
    /// have the latest version of the stream before updating it, you can specify the stream
    /// version. Kinesis Video Streams assigns a version to each stream. When you update a
    /// stream, Kinesis Video Streams assigns a new version number. To get the latest stream
    /// version, use the <c>DescribeStream</c> API. </para> <para> <c>UpdateStream</c> is
    /// an asynchronous operation, and takes time to complete. </para>
    /// </summary>
    public partial class UpdateStreamRequest : AmazonKinesisVideoRequest
    {
        /// <summary>
        /// Gets and sets the property CurrentVersion. 
        /// <para>
        /// The version of the stream whose metadata you want to update.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 64)]
        public string CurrentVersion { get; set; }

        /// <summary>
        /// Checks to see if the CurrentVersion property is set.
        /// </summary>
        internal bool IsSetCurrentVersion() => this.CurrentVersion != null;

        /// <summary>
        /// Gets and sets the property DeviceName. 
        /// <para>
        /// The name of the device that is writing to the stream. 
        /// </para>
        ///  <note> 
        /// <para>
        ///  In the current implementation, Kinesis Video Streams does not use this name. 
        /// </para>
        ///  </note>
        /// </summary>
        [AWSProperty(Min = 1, Max = 128)]
        public string DeviceName { get; set; }

        /// <summary>
        /// Checks to see if the DeviceName property is set.
        /// </summary>
        internal bool IsSetDeviceName() => this.DeviceName != null;

        /// <summary>
        /// Gets and sets the property MediaType. 
        /// <para>
        /// The stream's media type. Use <c>MediaType</c> to specify the type of content that
        /// the stream contains to the consumers of the stream. For more information about media
        /// types, see <a href="http://www.iana.org/assignments/media-types/media-types.xhtml">Media
        /// Types</a>. If you choose to specify the <c>MediaType</c>, see <a href="https://tools.ietf.org/html/rfc6838#section-4.2">Naming
        /// Requirements</a>.
        /// </para>
        ///  
        /// <para>
        /// To play video on the console, you must specify the correct video type. For example,
        /// if the video in the stream is H.264, specify <c>video/h264</c> as the <c>MediaType</c>.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 128)]
        public string MediaType { get; set; }

        /// <summary>
        /// Checks to see if the MediaType property is set.
        /// </summary>
        internal bool IsSetMediaType() => this.MediaType != null;

        /// <summary>
        /// Gets and sets the property StreamARN. 
        /// <para>
        /// The ARN of the stream whose metadata you want to update.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 1024)]
        public string StreamARN { get; set; }

        /// <summary>
        /// Checks to see if the StreamARN property is set.
        /// </summary>
        internal bool IsSetStreamARN() => this.StreamARN != null;

        /// <summary>
        /// Gets and sets the property StreamName. 
        /// <para>
        /// The name of the stream whose metadata you want to update.
        /// </para>
        ///  
        /// <para>
        /// The stream name is an identifier for the stream, and must be unique for each account
        /// and region.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 256)]
        public string StreamName { get; set; }

        /// <summary>
        /// Checks to see if the StreamName property is set.
        /// </summary>
        internal bool IsSetStreamName() => this.StreamName != null;
    }
}
