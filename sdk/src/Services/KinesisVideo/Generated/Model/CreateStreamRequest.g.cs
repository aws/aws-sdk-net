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
    /// Container for the parameters to the CreateStream operation. Creates a new Kinesis
    /// video stream. <para> When you create a new stream, Kinesis Video Streams assigns it
    /// a version number. When you change the stream's metadata, Kinesis Video Streams updates
    /// the version. </para> <para> <c>CreateStream</c> is an asynchronous operation. </para>
    /// <para> For information about how the service works, see <a href="https://docs.aws.amazon.com/kinesisvideostreams/latest/dg/how-it-works.html">How
    /// it Works</a>. </para> <para> You must have permissions for the <c>KinesisVideo:CreateStream</c>
    /// action. </para>
    /// </summary>
    public partial class CreateStreamRequest : AmazonKinesisVideoRequest
    {
        /// <summary>
        /// Gets and sets the property DataRetentionInHours. 
        /// <para>
        /// The number of hours that you want to retain the data in the stream. Kinesis Video
        /// Streams retains the data in a data store that is associated with the stream.
        /// </para>
        ///  
        /// <para>
        /// The default value is 0, indicating that the stream does not persist data. The minimum
        /// is 1 hour.
        /// </para>
        ///  
        /// <para>
        /// When the <c>DataRetentionInHours</c> value is 0, consumers can still consume the fragments
        /// that remain in the service host buffer, which has a retention time limit of 5 minutes
        /// and a retention memory limit of 200 MB. Fragments are removed from the buffer when
        /// either limit is reached.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0)]
        public int? DataRetentionInHours { get; set; }

        /// <summary>
        /// Checks to see if the DataRetentionInHours property is set.
        /// </summary>
        internal bool IsSetDataRetentionInHours() => this.DataRetentionInHours.HasValue;

        /// <summary>
        /// Gets and sets the property DeviceName. 
        /// <para>
        /// The name of the device that is writing to the stream. 
        /// </para>
        ///  <note> 
        /// <para>
        /// In the current implementation, Kinesis Video Streams doesn't use this name.
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
        /// Gets and sets the property KmsKeyId. 
        /// <para>
        /// The ID of the Key Management Service (KMS) key that you want Kinesis Video Streams
        /// to use to encrypt stream data.
        /// </para>
        ///  
        /// <para>
        /// If no key ID is specified, the default, Kinesis Video-managed key (<c>aws/kinesisvideo</c>)
        /// is used.
        /// </para>
        ///  
        /// <para>
        ///  For more information, see <a href="https://docs.aws.amazon.com/kms/latest/APIReference/API_DescribeKey.html#API_DescribeKey_RequestParameters">DescribeKey</a>.
        /// 
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 2048)]
        public string KmsKeyId { get; set; }

        /// <summary>
        /// Checks to see if the KmsKeyId property is set.
        /// </summary>
        internal bool IsSetKmsKeyId() => this.KmsKeyId != null;

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
        [AWSProperty(Min = 1, Max = 128)]
        public string MediaType { get; set; }

        /// <summary>
        /// Checks to see if the MediaType property is set.
        /// </summary>
        internal bool IsSetMediaType() => this.MediaType != null;

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
        [AWSProperty(Required = true, Min = 1, Max = 256)]
        public string StreamName { get; set; }

        /// <summary>
        /// Checks to see if the StreamName property is set.
        /// </summary>
        internal bool IsSetStreamName() => this.StreamName != null;

        /// <summary>
        /// Gets and sets the property StreamStorageConfiguration. 
        /// <para>
        /// The configuration for the stream's storage, including the default storage tier for
        /// stream data. This configuration determines how stream data is stored and accessed,
        /// with different tiers offering varying levels of performance and cost optimization.
        /// </para>
        ///  
        /// <para>
        /// If not specified, the stream will use the default storage configuration with HOT tier
        /// for optimal performance.
        /// </para>
        /// </summary>
        public StreamStorageConfiguration StreamStorageConfiguration { get; set; }

        /// <summary>
        /// Checks to see if the StreamStorageConfiguration property is set.
        /// </summary>
        internal bool IsSetStreamStorageConfiguration() => this.StreamStorageConfiguration != null;

        /// <summary>
        /// Gets and sets the property Tags. 
        /// <para>
        /// A list of tags to associate with the specified stream. Each tag is a key-value pair
        /// (the value is optional).
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min = 1, Max = 50)]
        public Dictionary<string, string> Tags { get; set; } = AWSConfigs.InitializeCollections ? new Dictionary<string, string>() : null;

        /// <summary>
        /// Checks to see if the Tags property is set.
        /// </summary>
        internal bool IsSetTags() => this.Tags != null && (this.Tags.Count > 0 || !AWSConfigs.InitializeCollections);
    }
}
