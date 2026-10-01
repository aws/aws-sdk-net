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
    /// An object describing a Kinesis video stream.
    /// </summary>
    public partial class StreamInfo
    {
        /// <summary>
        /// Gets and sets the property CreationTime. 
        /// <para>
        /// A time stamp that indicates when the stream was created.
        /// </para>
        /// </summary>
        public DateTime? CreationTime { get; set; }

        /// <summary>
        /// Checks to see if the CreationTime property is set.
        /// </summary>
        internal bool IsSetCreationTime() => this.CreationTime.HasValue;

        /// <summary>
        /// Gets and sets the property DataRetentionInHours. 
        /// <para>
        /// How long the stream retains data, in hours.
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
        /// The name of the device that is associated with the stream.
        /// </para>
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
        /// The ID of the Key Management Service (KMS) key that Kinesis Video Streams uses to
        /// encrypt data on the stream.
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
        /// The <c>MediaType</c> of the stream. 
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 128)]
        public string MediaType { get; set; }

        /// <summary>
        /// Checks to see if the MediaType property is set.
        /// </summary>
        internal bool IsSetMediaType() => this.MediaType != null;

        /// <summary>
        /// Gets and sets the property Status. 
        /// <para>
        /// The status of the stream.
        /// </para>
        /// </summary>
        public Status Status { get; set; }

        /// <summary>
        /// Checks to see if the Status property is set.
        /// </summary>
        internal bool IsSetStatus() => this.Status != null;

        /// <summary>
        /// Gets and sets the property StreamARN. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the stream.
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
        /// The name of the stream.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 256)]
        public string StreamName { get; set; }

        /// <summary>
        /// Checks to see if the StreamName property is set.
        /// </summary>
        internal bool IsSetStreamName() => this.StreamName != null;

        /// <summary>
        /// Gets and sets the property Version. 
        /// <para>
        /// The version of the stream.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 64)]
        public string Version { get; set; }

        /// <summary>
        /// Checks to see if the Version property is set.
        /// </summary>
        internal bool IsSetVersion() => this.Version != null;
    }
}
