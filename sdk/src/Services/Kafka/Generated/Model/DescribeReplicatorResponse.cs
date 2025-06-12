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
    /// This is the response object from the DescribeReplicator operation.
    /// </summary>
    public partial class DescribeReplicatorResponse : AmazonWebServiceResponse
    {
        private DateTime? _creationTime;
        private string _currentVersion;
        private bool? _isReplicatorReference;
        private List<KafkaClusterDescription> _kafkaClusters = AWSConfigs.InitializeCollections ? new List<KafkaClusterDescription>() : null;
        private List<ReplicationInfoDescription> _replicationInfoList = AWSConfigs.InitializeCollections ? new List<ReplicationInfoDescription>() : null;
        private string _replicatorArn;
        private string _replicatorDescription;
        private string _replicatorName;
        private string _replicatorResourceArn;
        private ReplicatorState _replicatorState;
        private string _serviceExecutionRoleArn;
        private ReplicationStateInfo _stateInfo;
        private Dictionary<string, string> _tags = AWSConfigs.InitializeCollections ? new Dictionary<string, string>() : null;

        /// <summary>
        /// Gets and sets the property CreationTime. 
        /// <para>
        /// The time when the replicator was created.
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
        /// The current version number of the replicator.
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
        /// Gets and sets the property KafkaClusters. 
        /// <para>
        /// Kafka Clusters used in setting up sources / targets for replication.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<KafkaClusterDescription> KafkaClusters
        {
            get { return this._kafkaClusters; }
            set { this._kafkaClusters = value; }
        }

        // Check to see if KafkaClusters property is set
        internal bool IsSetKafkaClusters()
        {
            return this._kafkaClusters != null && (this._kafkaClusters.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property ReplicationInfoList. 
        /// <para>
        /// A list of replication configurations, where each configuration targets a given source
        /// cluster to target cluster replication flow.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<ReplicationInfoDescription> ReplicationInfoList
        {
            get { return this._replicationInfoList; }
            set { this._replicationInfoList = value; }
        }

        // Check to see if ReplicationInfoList property is set
        internal bool IsSetReplicationInfoList()
        {
            return this._replicationInfoList != null && (this._replicationInfoList.Count > 0 || !AWSConfigs.InitializeCollections); 
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
        /// Gets and sets the property ReplicatorDescription. 
        /// <para>
        /// The description of the replicator.
        /// </para>
        /// </summary>
        public string ReplicatorDescription
        {
            get { return this._replicatorDescription; }
            set { this._replicatorDescription = value; }
        }

        // Check to see if ReplicatorDescription property is set
        internal bool IsSetReplicatorDescription()
        {
            return this._replicatorDescription != null;
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

        /// <summary>
        /// Gets and sets the property ServiceExecutionRoleArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the IAM role used by the replicator to access resources
        /// in the customer's account (e.g source and target clusters)
        /// </para>
        /// </summary>
        public string ServiceExecutionRoleArn
        {
            get { return this._serviceExecutionRoleArn; }
            set { this._serviceExecutionRoleArn = value; }
        }

        // Check to see if ServiceExecutionRoleArn property is set
        internal bool IsSetServiceExecutionRoleArn()
        {
            return this._serviceExecutionRoleArn != null;
        }

        /// <summary>
        /// Gets and sets the property StateInfo. 
        /// <para>
        /// Details about the state of the replicator.
        /// </para>
        /// </summary>
        public ReplicationStateInfo StateInfo
        {
            get { return this._stateInfo; }
            set { this._stateInfo = value; }
        }

        // Check to see if StateInfo property is set
        internal bool IsSetStateInfo()
        {
            return this._stateInfo != null;
        }

        /// <summary>
        /// Gets and sets the property Tags. 
        /// <para>
        /// List of tags attached to the Replicator.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public Dictionary<string, string> Tags
        {
            get { return this._tags; }
            set { this._tags = value; }
        }

        // Check to see if Tags property is set
        internal bool IsSetTags()
        {
            return this._tags != null && (this._tags.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

    }
}