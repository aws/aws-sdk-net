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
 * Do not modify this file. This file is generated from the kafka-2018-11-14.normal.json service model.
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
namespace Amazon.Kafka.Model
{
    /// <summary>
    /// Container for the parameters to the UpdateChannel operation.
    /// Updates the destination configuration of an existing channel. Exactly one of icebergDestinationUpdate
    /// or s3DestinationUpdate must be supplied.
    /// </summary>
    public partial class UpdateChannelRequest : AmazonKafkaRequest
    {
        private string _channelArn;
        private string _clusterArn;
        private IcebergDestinationUpdate _icebergDestinationUpdate;
        private S3DestinationUpdate _s3DestinationUpdate;

        /// <summary>
        /// Gets and sets the property ChannelArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) that uniquely identifies the channel.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string ChannelArn
        {
            get { return this._channelArn; }
            set { this._channelArn = value; }
        }

        // Check to see if ChannelArn property is set
        internal bool IsSetChannelArn()
        {
            return this._channelArn != null;
        }

        /// <summary>
        /// Gets and sets the property ClusterArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) that uniquely identifies the cluster.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string ClusterArn
        {
            get { return this._clusterArn; }
            set { this._clusterArn = value; }
        }

        // Check to see if ClusterArn property is set
        internal bool IsSetClusterArn()
        {
            return this._clusterArn != null;
        }

        /// <summary>
        /// Gets and sets the property IcebergDestinationUpdate. 
        /// <para>
        /// Updates fields on an Apache Iceberg destination. Use only when the channel was created
        /// with an Iceberg destination.
        /// </para>
        /// </summary>
        public IcebergDestinationUpdate IcebergDestinationUpdate
        {
            get { return this._icebergDestinationUpdate; }
            set { this._icebergDestinationUpdate = value; }
        }

        // Check to see if IcebergDestinationUpdate property is set
        internal bool IsSetIcebergDestinationUpdate()
        {
            return this._icebergDestinationUpdate != null;
        }

        /// <summary>
        /// Gets and sets the property S3DestinationUpdate. 
        /// <para>
        /// Updates fields on an Amazon S3 destination. Use only when the channel was created
        /// with an Amazon S3 destination.
        /// </para>
        /// </summary>
        public S3DestinationUpdate S3DestinationUpdate
        {
            get { return this._s3DestinationUpdate; }
            set { this._s3DestinationUpdate = value; }
        }

        // Check to see if S3DestinationUpdate property is set
        internal bool IsSetS3DestinationUpdate()
        {
            return this._s3DestinationUpdate != null;
        }

    }
}