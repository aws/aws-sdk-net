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
    /// Returns information about a cluster.
    /// </summary>
    public partial class ClusterInfo
    {
        /// <summary>
        /// Gets and sets the property ActiveOperationArn. 
        /// <para>
        /// Arn of active cluster operation.
        /// </para>
        /// </summary>
        public string ActiveOperationArn { get; set; }

        /// <summary>
        /// Checks to see if the ActiveOperationArn property is set.
        /// </summary>
        internal bool IsSetActiveOperationArn() => this.ActiveOperationArn != null;

        /// <summary>
        /// Gets and sets the property BrokerNodeGroupInfo. 
        /// <para>
        /// Information about the broker nodes.
        /// </para>
        /// </summary>
        public BrokerNodeGroupInfo BrokerNodeGroupInfo { get; set; }

        /// <summary>
        /// Checks to see if the BrokerNodeGroupInfo property is set.
        /// </summary>
        internal bool IsSetBrokerNodeGroupInfo() => this.BrokerNodeGroupInfo != null;

        /// <summary>
        /// Gets and sets the property ClientAuthentication. 
        /// <para>
        /// Includes all client authentication information.
        /// </para>
        /// </summary>
        public ClientAuthentication ClientAuthentication { get; set; }

        /// <summary>
        /// Checks to see if the ClientAuthentication property is set.
        /// </summary>
        internal bool IsSetClientAuthentication() => this.ClientAuthentication != null;

        /// <summary>
        /// Gets and sets the property ClusterArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) that uniquely identifies the cluster.
        /// </para>
        /// </summary>
        public string ClusterArn { get; set; }

        /// <summary>
        /// Checks to see if the ClusterArn property is set.
        /// </summary>
        internal bool IsSetClusterArn() => this.ClusterArn != null;

        /// <summary>
        /// Gets and sets the property ClusterName. 
        /// <para>
        /// The name of the cluster.
        /// </para>
        /// </summary>
        public string ClusterName { get; set; }

        /// <summary>
        /// Checks to see if the ClusterName property is set.
        /// </summary>
        internal bool IsSetClusterName() => this.ClusterName != null;

        /// <summary>
        /// Gets and sets the property CreationTime. 
        /// <para>
        /// The time when the cluster was created.
        /// </para>
        /// </summary>
        public DateTime? CreationTime { get; set; }

        /// <summary>
        /// Checks to see if the CreationTime property is set.
        /// </summary>
        internal bool IsSetCreationTime() => this.CreationTime.HasValue;

        /// <summary>
        /// Gets and sets the property CurrentBrokerSoftwareInfo. 
        /// <para>
        /// Information about the version of software currently deployed on the Apache Kafka brokers
        /// in the cluster.
        /// </para>
        /// </summary>
        public BrokerSoftwareInfo CurrentBrokerSoftwareInfo { get; set; }

        /// <summary>
        /// Checks to see if the CurrentBrokerSoftwareInfo property is set.
        /// </summary>
        internal bool IsSetCurrentBrokerSoftwareInfo() => this.CurrentBrokerSoftwareInfo != null;

        /// <summary>
        /// Gets and sets the property CurrentVersion. 
        /// <para>
        /// The current version of the MSK cluster.
        /// </para>
        /// </summary>
        public string CurrentVersion { get; set; }

        /// <summary>
        /// Checks to see if the CurrentVersion property is set.
        /// </summary>
        internal bool IsSetCurrentVersion() => this.CurrentVersion != null;

        /// <summary>
        /// Gets and sets the property CustomerActionStatus. 
        /// <para>
        /// Determines if there is an action required from the customer.
        /// </para>
        /// </summary>
        public CustomerActionStatus CustomerActionStatus { get; set; }

        /// <summary>
        /// Checks to see if the CustomerActionStatus property is set.
        /// </summary>
        internal bool IsSetCustomerActionStatus() => this.CustomerActionStatus != null;

        /// <summary>
        /// Gets and sets the property EncryptionInfo. 
        /// <para>
        /// Includes all encryption-related information.
        /// </para>
        /// </summary>
        public EncryptionInfo EncryptionInfo { get; set; }

        /// <summary>
        /// Checks to see if the EncryptionInfo property is set.
        /// </summary>
        internal bool IsSetEncryptionInfo() => this.EncryptionInfo != null;

        /// <summary>
        /// Gets and sets the property EnhancedMonitoring. 
        /// <para>
        /// Specifies which metrics are gathered for the MSK cluster. This property has the following
        /// possible values: DEFAULT, PER_BROKER, PER_TOPIC_PER_BROKER, and PER_TOPIC_PER_PARTITION.
        /// For a list of the metrics associated with each of these levels of monitoring, see
        /// <a href="https://docs.aws.amazon.com/msk/latest/developerguide/monitoring.html">Monitoring</a>.
        /// </para>
        /// </summary>
        public EnhancedMonitoring EnhancedMonitoring { get; set; }

        /// <summary>
        /// Checks to see if the EnhancedMonitoring property is set.
        /// </summary>
        internal bool IsSetEnhancedMonitoring() => this.EnhancedMonitoring != null;

        /// <summary>
        /// Gets and sets the property LoggingInfo.
        /// </summary>
        public LoggingInfo LoggingInfo { get; set; }

        /// <summary>
        /// Checks to see if the LoggingInfo property is set.
        /// </summary>
        internal bool IsSetLoggingInfo() => this.LoggingInfo != null;

        /// <summary>
        /// Gets and sets the property NumberOfBrokerNodes. 
        /// <para>
        /// The number of broker nodes in the cluster.
        /// </para>
        /// </summary>
        public int? NumberOfBrokerNodes { get; set; }

        /// <summary>
        /// Checks to see if the NumberOfBrokerNodes property is set.
        /// </summary>
        internal bool IsSetNumberOfBrokerNodes() => this.NumberOfBrokerNodes.HasValue;

        /// <summary>
        /// Gets and sets the property OpenMonitoring. 
        /// <para>
        /// Settings for open monitoring using Prometheus.
        /// </para>
        /// </summary>
        public OpenMonitoring OpenMonitoring { get; set; }

        /// <summary>
        /// Checks to see if the OpenMonitoring property is set.
        /// </summary>
        internal bool IsSetOpenMonitoring() => this.OpenMonitoring != null;

        /// <summary>
        /// Gets and sets the property Rebalancing. 
        /// <para>
        /// Contains information about intelligent rebalancing for new MSK Provisioned clusters
        /// with Express brokers. By default, intelligent rebalancing status is ACTIVE.
        /// </para>
        /// </summary>
        public Rebalancing Rebalancing { get; set; }

        /// <summary>
        /// Checks to see if the Rebalancing property is set.
        /// </summary>
        internal bool IsSetRebalancing() => this.Rebalancing != null;

        /// <summary>
        /// Gets and sets the property State. 
        /// <para>
        /// The state of the cluster. The possible states are ACTIVE, CREATING, DELETING, FAILED,
        /// HEALING, MAINTENANCE, REBOOTING_BROKER, and UPDATING.
        /// </para>
        /// </summary>
        public ClusterState State { get; set; }

        /// <summary>
        /// Checks to see if the State property is set.
        /// </summary>
        internal bool IsSetState() => this.State != null;

        /// <summary>
        /// Gets and sets the property StateInfo.
        /// </summary>
        public StateInfo StateInfo { get; set; }

        /// <summary>
        /// Checks to see if the StateInfo property is set.
        /// </summary>
        internal bool IsSetStateInfo() => this.StateInfo != null;

        /// <summary>
        /// Gets and sets the property StorageMode. 
        /// <para>
        /// This controls storage mode for supported storage tiers.
        /// </para>
        /// </summary>
        public StorageMode StorageMode { get; set; }

        /// <summary>
        /// Checks to see if the StorageMode property is set.
        /// </summary>
        internal bool IsSetStorageMode() => this.StorageMode != null;

        /// <summary>
        /// Gets and sets the property Tags. 
        /// <para>
        /// Tags attached to the cluster.
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
        /// Gets and sets the property ZookeeperConnectString. 
        /// <para>
        /// The connection string to use to connect to the Apache ZooKeeper cluster.
        /// </para>
        /// </summary>
        public string ZookeeperConnectString { get; set; }

        /// <summary>
        /// Checks to see if the ZookeeperConnectString property is set.
        /// </summary>
        internal bool IsSetZookeeperConnectString() => this.ZookeeperConnectString != null;

        /// <summary>
        /// Gets and sets the property ZookeeperConnectStringTls. 
        /// <para>
        /// The connection string to use to connect to zookeeper cluster on Tls port.
        /// </para>
        /// </summary>
        public string ZookeeperConnectStringTls { get; set; }

        /// <summary>
        /// Checks to see if the ZookeeperConnectStringTls property is set.
        /// </summary>
        internal bool IsSetZookeeperConnectStringTls() => this.ZookeeperConnectStringTls != null;
    }
}
