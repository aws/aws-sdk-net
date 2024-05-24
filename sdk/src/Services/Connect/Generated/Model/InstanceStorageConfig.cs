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
 * Do not modify this file. This file is generated from the connect-2017-08-08.normal.json service model.
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
        private string _associationId;
        private KinesisFirehoseConfig _kinesisFirehoseConfig;
        private KinesisStreamConfig _kinesisStreamConfig;
        private KinesisVideoStreamConfig _kinesisVideoStreamConfig;
        private S3Config _s3Config;
        private StorageType _storageType;

        /// <summary>
        /// Gets and sets the property AssociationId. 
        /// <para>
        /// The existing association identifier that uniquely identifies the resource type and
        /// storage config for the given instance ID.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=100)]
        public string AssociationId
        {
            get { return this._associationId; }
            set { this._associationId = value; }
        }

        // Check to see if AssociationId property is set
        internal bool IsSetAssociationId()
        {
            return this._associationId != null;
        }

        /// <summary>
        /// Gets and sets the property KinesisFirehoseConfig. 
        /// <para>
        /// The configuration of the Kinesis Firehose delivery stream.
        /// </para>
        /// </summary>
        public KinesisFirehoseConfig KinesisFirehoseConfig
        {
            get { return this._kinesisFirehoseConfig; }
            set { this._kinesisFirehoseConfig = value; }
        }

        // Check to see if KinesisFirehoseConfig property is set
        internal bool IsSetKinesisFirehoseConfig()
        {
            return this._kinesisFirehoseConfig != null;
        }

        /// <summary>
        /// Gets and sets the property KinesisStreamConfig. 
        /// <para>
        /// The configuration of the Kinesis data stream.
        /// </para>
        /// </summary>
        public KinesisStreamConfig KinesisStreamConfig
        {
            get { return this._kinesisStreamConfig; }
            set { this._kinesisStreamConfig = value; }
        }

        // Check to see if KinesisStreamConfig property is set
        internal bool IsSetKinesisStreamConfig()
        {
            return this._kinesisStreamConfig != null;
        }

        /// <summary>
        /// Gets and sets the property KinesisVideoStreamConfig. 
        /// <para>
        /// The configuration of the Kinesis video stream.
        /// </para>
        /// </summary>
        public KinesisVideoStreamConfig KinesisVideoStreamConfig
        {
            get { return this._kinesisVideoStreamConfig; }
            set { this._kinesisVideoStreamConfig = value; }
        }

        // Check to see if KinesisVideoStreamConfig property is set
        internal bool IsSetKinesisVideoStreamConfig()
        {
            return this._kinesisVideoStreamConfig != null;
        }

        /// <summary>
        /// Gets and sets the property S3Config. 
        /// <para>
        /// The S3 bucket configuration.
        /// </para>
        /// </summary>
        public S3Config S3Config
        {
            get { return this._s3Config; }
            set { this._s3Config = value; }
        }

        // Check to see if S3Config property is set
        internal bool IsSetS3Config()
        {
            return this._s3Config != null;
        }

        /// <summary>
        /// Gets and sets the property StorageType. 
        /// <para>
        /// A valid storage type.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public StorageType StorageType
        {
            get { return this._storageType; }
            set { this._storageType = value; }
        }

        // Check to see if StorageType property is set
        internal bool IsSetStorageType()
        {
            return this._storageType != null;
        }

    }
}