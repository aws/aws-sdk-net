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
 * Do not modify this file. This file is generated from the kinesisvideo-2017-09-30.normal.json service model.
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
    /// Container for the parameters to the UpdateStream operation.
    /// Updates stream metadata, such as the device name and media type.
    /// 
    ///  
    /// <para>
    /// You must provide the stream name or the Amazon Resource Name (ARN) of the stream.
    /// </para>
    ///  
    /// <para>
    /// To make sure that you have the latest version of the stream before updating it, you
    /// can specify the stream version. Kinesis Video Streams assigns a version to each stream.
    /// When you update a stream, Kinesis Video Streams assigns a new version number. To get
    /// the latest stream version, use the <c>DescribeStream</c> API. 
    /// </para>
    ///  
    /// <para>
    ///  <c>UpdateStream</c> is an asynchronous operation, and takes time to complete.
    /// </para>
    /// </summary>
    public partial class UpdateStreamRequest : AmazonKinesisVideoRequest
    {
        private string _currentVersion;
        private string _deviceName;
        private string _mediaType;
        private string _streamARN;
        private string _streamName;

        /// <summary>
        /// Gets and sets the property CurrentVersion. 
        /// <para>
        /// The version of the stream whose metadata you want to update.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=64)]
        public string CurrentVersion
        {
            get { return this._currentVersion; }
            set { this._currentVersion = value; }
        }

        // Check to see if CurrentVersion property is set
        internal bool IsSetCurrentVersion()
        {
            return this._currentVersion != null;
        }

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
        [AWSProperty(Min=1, Max=128)]
        public string DeviceName
        {
            get { return this._deviceName; }
            set { this._deviceName = value; }
        }

        // Check to see if DeviceName property is set
        internal bool IsSetDeviceName()
        {
            return this._deviceName != null;
        }

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
        [AWSProperty(Min=1, Max=128)]
        public string MediaType
        {
            get { return this._mediaType; }
            set { this._mediaType = value; }
        }

        // Check to see if MediaType property is set
        internal bool IsSetMediaType()
        {
            return this._mediaType != null;
        }

        /// <summary>
        /// Gets and sets the property StreamARN. 
        /// <para>
        /// The ARN of the stream whose metadata you want to update.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=1024)]
        public string StreamARN
        {
            get { return this._streamARN; }
            set { this._streamARN = value; }
        }

        // Check to see if StreamARN property is set
        internal bool IsSetStreamARN()
        {
            return this._streamARN != null;
        }

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
        [AWSProperty(Min=1, Max=256)]
        public string StreamName
        {
            get { return this._streamName; }
            set { this._streamName = value; }
        }

        // Check to see if StreamName property is set
        internal bool IsSetStreamName()
        {
            return this._streamName != null;
        }

    }
}