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
    /// Container for the parameters to the UpdateTopic operation. Updates the configuration
    /// of the specified topic.
    /// </summary>
    public partial class UpdateTopicRequest : AmazonKafkaRequest
    {
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
        /// Gets and sets the property Configs. 
        /// <para>
        /// The new topic configurations encoded as a Base64 string.
        /// </para>
        /// </summary>
        public string Configs { get; set; }

        /// <summary>
        /// Checks to see if the Configs property is set.
        /// </summary>
        internal bool IsSetConfigs() => this.Configs != null;

        /// <summary>
        /// Gets and sets the property PartitionCount. 
        /// <para>
        /// The new total number of partitions for the topic.
        /// </para>
        /// </summary>
        public int? PartitionCount { get; set; }

        /// <summary>
        /// Checks to see if the PartitionCount property is set.
        /// </summary>
        internal bool IsSetPartitionCount() => this.PartitionCount.HasValue;

        /// <summary>
        /// Gets and sets the property TopicName. 
        /// <para>
        /// The name of the topic to update configuration for.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public string TopicName { get; set; }

        /// <summary>
        /// Checks to see if the TopicName property is set.
        /// </summary>
        internal bool IsSetTopicName() => this.TopicName != null;
    }
}
