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
    /// Container for the parameters to the CreateStream operation.
    /// Creates a new Kinesis video stream. 
    /// 
    ///  
    /// <para>
    /// When you create a new stream, Kinesis Video Streams assigns it a version number. When
    /// you change the stream's metadata, Kinesis Video Streams updates the version. 
    /// </para>
    ///  
    /// <para>
    ///  <c>CreateStream</c> is an asynchronous operation.
    /// </para>
    ///  
    /// <para>
    /// For information about how the service works, see <a href="https://docs.aws.amazon.com/kinesisvideostreams/latest/dg/how-it-works.html">How
    /// it Works</a>. 
    /// </para>
    ///  
    /// <para>
    /// You must have permissions for the <c>KinesisVideo:CreateStream</c> action.
    /// </para>
    /// </summary>
    public partial class CreateStreamRequest : AmazonKinesisVideoRequest
    {
        private int? _dataRetentionInHours;
        private string _deviceName;
        private string _kmsKeyId;
        private string _mediaType;
        private string _streamName;
        private Dictionary<string, string> _tags = AWSConfigs.InitializeCollections ? new Dictionary<string, string>() : null;

        /// <summary>
        /// Gets and sets the property DataRetentionInHours. 
        /// <para>
        /// The number of hours that you want to retain the data in the stream. Kinesis Video
        /// Streams retains the data in a data store that is associated with the stream.
        /// </para>
        ///  
        /// <para>
        /// The default value is 0, indicating that the stream does not persist data.
        /// </para>
        ///  
        /// <para>
        /// When the <c>DataRetentionInHours</c> value is 0, consumers can still consume the fragments
        /// that remain in the service host buffer, which has a retention time limit of 5 minutes
        /// and a retention memory limit of 200 MB. Fragments are removed from the buffer when
        /// either limit is reached.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0)]
        public int? DataRetentionInHours
        {
            get { return this._dataRetentionInHours; }
            set { this._dataRetentionInHours = value; }
        }

        // Check to see if DataRetentionInHours property is set
        internal bool IsSetDataRetentionInHours()
        {
            return this._dataRetentionInHours.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property DeviceName. 
        /// <para>
        /// The name of the device that is writing to the stream. 
        /// </para>
        ///  <note> 
        /// <para>
        /// In the current implementation, Kinesis Video Streams does not use this name.
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
        /// Gets and sets the property KmsKeyId. 
        /// <para>
        /// The ID of the Key Management Service (KMS) key that you want Kinesis Video Streams
        /// to use to encrypt stream data.
        /// </para>
        ///  
        /// <para>
        /// If no key ID is specified, the default, Kinesis Video-managed key (<c>Amazon Web Services/kinesisvideo</c>)
        /// is used.
        /// </para>
        ///  
        /// <para>
        ///  For more information, see <a href="https://docs.aws.amazon.com/kms/latest/APIReference/API_DescribeKey.html#API_DescribeKey_RequestParameters">DescribeKey</a>.
        /// 
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=2048)]
        public string KmsKeyId
        {
            get { return this._kmsKeyId; }
            set { this._kmsKeyId = value; }
        }

        // Check to see if KmsKeyId property is set
        internal bool IsSetKmsKeyId()
        {
            return this._kmsKeyId != null;
        }

        /// <summary>
        /// Gets and sets the property MediaType. 
        /// <para>
        /// The media type of the stream. Consumers of the stream can use this information when
        /// processing the stream. For more information about media types, see <a href="http://www.iana.org/assignments/media-types/media-types.xhtml">Media
        /// Types</a>. If you choose to specify the <c>MediaType</c>, see <a href="https://tools.ietf.org/html/rfc6838#section-4.2">Naming
        /// Requirements</a> for guidelines.
        /// </para>
        ///  
        /// <para>
        /// Example valid values include "video/h264" and "video/h264,audio/aac".
        /// </para>
        ///  
        /// <para>
        /// This parameter is optional; the default value is <c>null</c> (or empty in JSON).
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
        /// Gets and sets the property StreamName. 
        /// <para>
        /// A name for the stream that you are creating.
        /// </para>
        ///  
        /// <para>
        /// The stream name is an identifier for the stream, and must be unique for each account
        /// and region.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=256)]
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

        /// <summary>
        /// Gets and sets the property Tags. 
        /// <para>
        /// A list of tags to associate with the specified stream. Each tag is a key-value pair
        /// (the value is optional).
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min=1, Max=50)]
        public Dictionary<string, string> Tags
        {
            get { return this._tags; }
            set { this._tags = value; }
        }

        // Check to see if Tags property is set
        internal bool IsSetTags()
        {
            return this._tags != null && (this._tags.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

    }
}