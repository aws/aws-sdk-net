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

namespace Amazon.Kafka.Model
{
    /// <summary>
    /// Container for the parameters to the CreateChannel operation. Creates a Channel that
    /// streams records from an Amazon MSK Express cluster topic to Amazon S3 or Apache Iceberg.
    /// </summary>
    public partial class CreateChannelRequest : AmazonKafkaRequest
    {
        /// <summary>
        /// Gets and sets the property ChannelName. 
        /// <para>
        /// The name of the channel. Must be unique within the cluster.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public string ChannelName { get; set; }

        /// <summary>
        /// Checks to see if the ChannelName property is set.
        /// </summary>
        internal bool IsSetChannelName() => this.ChannelName != null;

        /// <summary>
        /// Gets and sets the property ClusterArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) that uniquely identifies the cluster.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public string ClusterArn { get; set; }

        /// <summary>
        /// Checks to see if the ClusterArn property is set.
        /// </summary>
        internal bool IsSetClusterArn() => this.ClusterArn != null;

        /// <summary>
        /// Gets and sets the property EncryptionConfiguration. 
        /// <para>
        /// The encryption configuration applied to the channel.
        /// </para>
        /// </summary>
        public EncryptionConfiguration EncryptionConfiguration { get; set; }

        /// <summary>
        /// Checks to see if the EncryptionConfiguration property is set.
        /// </summary>
        internal bool IsSetEncryptionConfiguration() => this.EncryptionConfiguration != null;

        /// <summary>
        /// Gets and sets the property IcebergDestinationConfiguration. 
        /// <para>
        /// The Apache Iceberg destination for the channel. Mutually exclusive with s3DestinationConfiguration.
        /// </para>
        /// </summary>
        public IcebergDestinationConfiguration IcebergDestinationConfiguration { get; set; }

        /// <summary>
        /// Checks to see if the IcebergDestinationConfiguration property is set.
        /// </summary>
        internal bool IsSetIcebergDestinationConfiguration() => this.IcebergDestinationConfiguration != null;

        /// <summary>
        /// Gets and sets the property LoggingInfo. 
        /// <para>
        /// The destinations to which the channel publishes operational logs.
        /// </para>
        /// </summary>
        public ChannelLoggingInfo LoggingInfo { get; set; }

        /// <summary>
        /// Checks to see if the LoggingInfo property is set.
        /// </summary>
        internal bool IsSetLoggingInfo() => this.LoggingInfo != null;

        /// <summary>
        /// Gets and sets the property S3DestinationConfiguration. 
        /// <para>
        /// The Amazon S3 destination for the channel. Mutually exclusive with icebergDestinationConfiguration.
        /// </para>
        /// </summary>
        public S3DestinationConfiguration S3DestinationConfiguration { get; set; }

        /// <summary>
        /// Checks to see if the S3DestinationConfiguration property is set.
        /// </summary>
        internal bool IsSetS3DestinationConfiguration() => this.S3DestinationConfiguration != null;

        /// <summary>
        /// Gets and sets the property Tags. 
        /// <para>
        /// The tags attached to the channel.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public Dictionary<string, string> Tags { get; set; } = AWSConfigs.InitializeCollections ? new Dictionary<string, string>() : null;

        /// <summary>
        /// Checks to see if the Tags property is set.
        /// </summary>
        internal bool IsSetTags() => this.Tags != null && (this.Tags.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property TopicConfigurationList. 
        /// <para>
        /// The list of topic configurations for the channel. Currently exactly one topic must
        /// be specified.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Required = true)]
        public List<TopicConfiguration> TopicConfigurationList { get; set; } = AWSConfigs.InitializeCollections ? new List<TopicConfiguration>() : null;

        /// <summary>
        /// Checks to see if the TopicConfigurationList property is set.
        /// </summary>
        internal bool IsSetTopicConfigurationList() => this.TopicConfigurationList != null && (this.TopicConfigurationList.Count > 0 || !AWSConfigs.InitializeCollections);
    }
}
