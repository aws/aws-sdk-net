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

namespace Amazon.Connect.Model
{
    /// <summary>
    /// The storage configuration for the instance.
    /// </summary>
    public partial class InstanceStorageConfig
    {
        /// <summary>
        /// Gets and sets the property AssociationId. 
        /// <para>
        /// The existing association identifier that uniquely identifies the resource type and
        /// storage config for the given instance ID.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 100)]
        public string AssociationId { get; set; }

        /// <summary>
        /// Checks to see if the AssociationId property is set.
        /// </summary>
        internal bool IsSetAssociationId() => this.AssociationId != null;

        /// <summary>
        /// Gets and sets the property KinesisFirehoseConfig. 
        /// <para>
        /// The configuration of the Kinesis Firehose delivery stream.
        /// </para>
        /// </summary>
        public KinesisFirehoseConfig KinesisFirehoseConfig { get; set; }

        /// <summary>
        /// Checks to see if the KinesisFirehoseConfig property is set.
        /// </summary>
        internal bool IsSetKinesisFirehoseConfig() => this.KinesisFirehoseConfig != null;

        /// <summary>
        /// Gets and sets the property KinesisStreamConfig. 
        /// <para>
        /// The configuration of the Kinesis data stream.
        /// </para>
        /// </summary>
        public KinesisStreamConfig KinesisStreamConfig { get; set; }

        /// <summary>
        /// Checks to see if the KinesisStreamConfig property is set.
        /// </summary>
        internal bool IsSetKinesisStreamConfig() => this.KinesisStreamConfig != null;

        /// <summary>
        /// Gets and sets the property KinesisVideoStreamConfig. 
        /// <para>
        /// The configuration of the Kinesis video stream.
        /// </para>
        /// </summary>
        public KinesisVideoStreamConfig KinesisVideoStreamConfig { get; set; }

        /// <summary>
        /// Checks to see if the KinesisVideoStreamConfig property is set.
        /// </summary>
        internal bool IsSetKinesisVideoStreamConfig() => this.KinesisVideoStreamConfig != null;

        /// <summary>
        /// Gets and sets the property S3Config. 
        /// <para>
        /// The S3 bucket configuration.
        /// </para>
        /// </summary>
        public S3Config S3Config { get; set; }

        /// <summary>
        /// Checks to see if the S3Config property is set.
        /// </summary>
        internal bool IsSetS3Config() => this.S3Config != null;

        /// <summary>
        /// Gets and sets the property StorageType. 
        /// <para>
        /// A valid storage type.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public StorageType StorageType { get; set; }

        /// <summary>
        /// Checks to see if the StorageType property is set.
        /// </summary>
        internal bool IsSetStorageType() => this.StorageType != null;
    }
}
