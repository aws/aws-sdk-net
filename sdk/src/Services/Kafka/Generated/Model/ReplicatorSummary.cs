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
    /// Information about a replicator.
    /// </summary>
    public partial class ReplicatorSummary
    {
        private DateTime? _creationTime;
        private string _currentVersion;
        private bool? _isReplicatorReference;
        private List<KafkaClusterSummary> _kafkaClustersSummary = AWSConfigs.InitializeCollections ? new List<KafkaClusterSummary>() : null;
        private List<ReplicationInfoSummary> _replicationInfoSummaryList = AWSConfigs.InitializeCollections ? new List<ReplicationInfoSummary>() : null;
        private string _replicatorArn;
        private string _replicatorName;
        private string _replicatorResourceArn;
        private ReplicatorState _replicatorState;

        /// <summary>
        /// Gets and sets the property CreationTime. 
        /// <para>
        /// The time the replicator was created.
        /// </para>
        /// </summary>
        public DateTime? CreationTime
        {
            get { return this._creationTime; }
            set { this._creationTime = value; }
        }

        // Check to see if CreationTime property is set
        internal bool IsSetCreationTime()
        {
            return this._creationTime.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property CurrentVersion. 
        /// <para>
        /// The current version of the replicator.
        /// </para>
        /// </summary>
        public string CurrentVersion
        {
            get { return this._currentVersion; }
            set { this._currentVersion = value; }
        }

        // Check to see if CurrentVersion property is set
        internal bool IsSetCurrentVersion()
        {
            return this._currentVersion != null;
        }

        /// <summary>
        /// Gets and sets the property IsReplicatorReference. 
        /// <para>
        /// Whether this resource is a replicator reference.
        /// </para>
        /// </summary>
        public bool? IsReplicatorReference
        {
            get { return this._isReplicatorReference; }
            set { this._isReplicatorReference = value; }
        }

        // Check to see if IsReplicatorReference property is set
        internal bool IsSetIsReplicatorReference()
        {
            return this._isReplicatorReference.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property KafkaClustersSummary. 
        /// <para>
        /// Kafka Clusters used in setting up sources / targets for replication.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<KafkaClusterSummary> KafkaClustersSummary
        {
            get { return this._kafkaClustersSummary; }
            set { this._kafkaClustersSummary = value; }
        }

        // Check to see if KafkaClustersSummary property is set
        internal bool IsSetKafkaClustersSummary()
        {
            return this._kafkaClustersSummary != null && (this._kafkaClustersSummary.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property ReplicationInfoSummaryList. 
        /// <para>
        /// A list of summarized information of replications between clusters.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<ReplicationInfoSummary> ReplicationInfoSummaryList
        {
            get { return this._replicationInfoSummaryList; }
            set { this._replicationInfoSummaryList = value; }
        }

        // Check to see if ReplicationInfoSummaryList property is set
        internal bool IsSetReplicationInfoSummaryList()
        {
            return this._replicationInfoSummaryList != null && (this._replicationInfoSummaryList.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property ReplicatorArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the replicator.
        /// </para>
        /// </summary>
        public string ReplicatorArn
        {
            get { return this._replicatorArn; }
            set { this._replicatorArn = value; }
        }

        // Check to see if ReplicatorArn property is set
        internal bool IsSetReplicatorArn()
        {
            return this._replicatorArn != null;
        }

        /// <summary>
        /// Gets and sets the property ReplicatorName. 
        /// <para>
        /// The name of the replicator.
        /// </para>
        /// </summary>
        public string ReplicatorName
        {
            get { return this._replicatorName; }
            set { this._replicatorName = value; }
        }

        // Check to see if ReplicatorName property is set
        internal bool IsSetReplicatorName()
        {
            return this._replicatorName != null;
        }

        /// <summary>
        /// Gets and sets the property ReplicatorResourceArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the replicator resource in the region where the
        /// replicator was created.
        /// </para>
        /// </summary>
        public string ReplicatorResourceArn
        {
            get { return this._replicatorResourceArn; }
            set { this._replicatorResourceArn = value; }
        }

        // Check to see if ReplicatorResourceArn property is set
        internal bool IsSetReplicatorResourceArn()
        {
            return this._replicatorResourceArn != null;
        }

        /// <summary>
        /// Gets and sets the property ReplicatorState. 
        /// <para>
        /// State of the replicator.
        /// </para>
        /// </summary>
        public ReplicatorState ReplicatorState
        {
            get { return this._replicatorState; }
            set { this._replicatorState = value; }
        }

        // Check to see if ReplicatorState property is set
        internal bool IsSetReplicatorState()
        {
            return this._replicatorState != null;
        }

    }
}