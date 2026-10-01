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
    /// Container for the parameters to the CreateReplicator operation. Creates the replicator.
    /// </summary>
    public partial class CreateReplicatorRequest : AmazonKafkaRequest
    {
        /// <summary>
        /// Gets and sets the property Description. 
        /// <para>
        /// A summary description of the replicator.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 1024)]
        public string Description { get; set; }

        /// <summary>
        /// Checks to see if the Description property is set.
        /// </summary>
        internal bool IsSetDescription() => this.Description != null;

        /// <summary>
        /// Gets and sets the property KafkaClusters. 
        /// <para>
        /// Kafka Clusters to use in setting up sources / targets for replication.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Required = true)]
        public List<KafkaCluster> KafkaClusters { get; set; } = AWSConfigs.InitializeCollections ? new List<KafkaCluster>() : null;

        /// <summary>
        /// Checks to see if the KafkaClusters property is set.
        /// </summary>
        internal bool IsSetKafkaClusters() => this.KafkaClusters != null && (this.KafkaClusters.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property LogDelivery. 
        /// <para>
        /// Configuration for delivering replicator logs to customer destinations.
        /// </para>
        /// </summary>
        public LogDelivery LogDelivery { get; set; }

        /// <summary>
        /// Checks to see if the LogDelivery property is set.
        /// </summary>
        internal bool IsSetLogDelivery() => this.LogDelivery != null;

        /// <summary>
        /// Gets and sets the property ReplicationInfoList. 
        /// <para>
        /// A list of replication configurations, where each configuration targets a given source
        /// cluster to target cluster replication flow.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Required = true)]
        public List<ReplicationInfo> ReplicationInfoList { get; set; } = AWSConfigs.InitializeCollections ? new List<ReplicationInfo>() : null;

        /// <summary>
        /// Checks to see if the ReplicationInfoList property is set.
        /// </summary>
        internal bool IsSetReplicationInfoList() => this.ReplicationInfoList != null && (this.ReplicationInfoList.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property ReplicatorName. 
        /// <para>
        /// The name of the replicator. Alpha-numeric characters with '-' are allowed.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 128)]
        public string ReplicatorName { get; set; }

        /// <summary>
        /// Checks to see if the ReplicatorName property is set.
        /// </summary>
        internal bool IsSetReplicatorName() => this.ReplicatorName != null;

        /// <summary>
        /// Gets and sets the property ServiceExecutionRoleArn. 
        /// <para>
        /// The ARN of the IAM role used by the replicator to access resources in the customer's
        /// account (e.g source and target clusters)
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public string ServiceExecutionRoleArn { get; set; }

        /// <summary>
        /// Checks to see if the ServiceExecutionRoleArn property is set.
        /// </summary>
        internal bool IsSetServiceExecutionRoleArn() => this.ServiceExecutionRoleArn != null;

        /// <summary>
        /// Gets and sets the property Tags. 
        /// <para>
        /// List of tags to attach to created Replicator.
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
    }
}
