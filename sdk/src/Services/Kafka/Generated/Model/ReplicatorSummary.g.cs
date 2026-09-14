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
    /// Information about a replicator.
    /// </summary>
    public partial class ReplicatorSummary
    {
        /// <summary>
        /// Gets and sets the property CreationTime. 
        /// <para>
        /// The time the replicator was created.
        /// </para>
        /// </summary>
        public DateTime? CreationTime { get; set; }

        /// <summary>
        /// Checks to see if the CreationTime property is set.
        /// </summary>
        internal bool IsSetCreationTime() => this.CreationTime.HasValue;

        /// <summary>
        /// Gets and sets the property CurrentVersion. 
        /// <para>
        /// The current version of the replicator.
        /// </para>
        /// </summary>
        public string CurrentVersion { get; set; }

        /// <summary>
        /// Checks to see if the CurrentVersion property is set.
        /// </summary>
        internal bool IsSetCurrentVersion() => this.CurrentVersion != null;

        /// <summary>
        /// Gets and sets the property IsReplicatorReference. 
        /// <para>
        /// Whether this resource is a replicator reference.
        /// </para>
        /// </summary>
        public bool? IsReplicatorReference { get; set; }

        /// <summary>
        /// Checks to see if the IsReplicatorReference property is set.
        /// </summary>
        internal bool IsSetIsReplicatorReference() => this.IsReplicatorReference.HasValue;

        /// <summary>
        /// Gets and sets the property KafkaClustersSummary. 
        /// <para>
        /// Kafka Clusters used in setting up sources / targets for replication.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<KafkaClusterSummary> KafkaClustersSummary { get; set; } = AWSConfigs.InitializeCollections ? new List<KafkaClusterSummary>() : null;

        /// <summary>
        /// Checks to see if the KafkaClustersSummary property is set.
        /// </summary>
        internal bool IsSetKafkaClustersSummary() => this.KafkaClustersSummary != null && (this.KafkaClustersSummary.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property ReplicationInfoSummaryList. 
        /// <para>
        /// A list of summarized information of replications between clusters.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<ReplicationInfoSummary> ReplicationInfoSummaryList { get; set; } = AWSConfigs.InitializeCollections ? new List<ReplicationInfoSummary>() : null;

        /// <summary>
        /// Checks to see if the ReplicationInfoSummaryList property is set.
        /// </summary>
        internal bool IsSetReplicationInfoSummaryList() => this.ReplicationInfoSummaryList != null && (this.ReplicationInfoSummaryList.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property ReplicatorArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the replicator.
        /// </para>
        /// </summary>
        public string ReplicatorArn { get; set; }

        /// <summary>
        /// Checks to see if the ReplicatorArn property is set.
        /// </summary>
        internal bool IsSetReplicatorArn() => this.ReplicatorArn != null;

        /// <summary>
        /// Gets and sets the property ReplicatorName. 
        /// <para>
        /// The name of the replicator.
        /// </para>
        /// </summary>
        public string ReplicatorName { get; set; }

        /// <summary>
        /// Checks to see if the ReplicatorName property is set.
        /// </summary>
        internal bool IsSetReplicatorName() => this.ReplicatorName != null;

        /// <summary>
        /// Gets and sets the property ReplicatorResourceArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the replicator resource in the region where the
        /// replicator was created.
        /// </para>
        /// </summary>
        public string ReplicatorResourceArn { get; set; }

        /// <summary>
        /// Checks to see if the ReplicatorResourceArn property is set.
        /// </summary>
        internal bool IsSetReplicatorResourceArn() => this.ReplicatorResourceArn != null;

        /// <summary>
        /// Gets and sets the property ReplicatorState. 
        /// <para>
        /// State of the replicator.
        /// </para>
        /// </summary>
        public ReplicatorState ReplicatorState { get; set; }

        /// <summary>
        /// Checks to see if the ReplicatorState property is set.
        /// </summary>
        internal bool IsSetReplicatorState() => this.ReplicatorState != null;
    }
}
