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
    /// Returns information about a cluster.
    /// </summary>
    public partial class ClusterInfo
    {
        private string _activeOperationArn;
        private BrokerNodeGroupInfo _brokerNodeGroupInfo;
        private ClientAuthentication _clientAuthentication;
        private string _clusterArn;
        private string _clusterName;
        private DateTime? _creationTime;
        private BrokerSoftwareInfo _currentBrokerSoftwareInfo;
        private string _currentVersion;
        private CustomerActionStatus _customerActionStatus;
        private EncryptionInfo _encryptionInfo;
        private EnhancedMonitoring _enhancedMonitoring;
        private LoggingInfo _loggingInfo;
        private int? _numberOfBrokerNodes;
        private OpenMonitoring _openMonitoring;
        private ClusterState _state;
        private StateInfo _stateInfo;
        private StorageMode _storageMode;
        private Dictionary<string, string> _tags = AWSConfigs.InitializeCollections ? new Dictionary<string, string>() : null;
        private string _zookeeperConnectString;
        private string _zookeeperConnectStringTls;

        /// <summary>
        /// Gets and sets the property ActiveOperationArn.             
        /// <para>
        /// Arn of active cluster operation.
        /// </para>
        /// </summary>
        public string ActiveOperationArn
        {
            get { return this._activeOperationArn; }
            set { this._activeOperationArn = value; }
        }

        // Check to see if ActiveOperationArn property is set
        internal bool IsSetActiveOperationArn()
        {
            return this._activeOperationArn != null;
        }

        /// <summary>
        /// Gets and sets the property BrokerNodeGroupInfo.             
        /// <para>
        /// Information about the broker nodes.
        /// </para>
        /// </summary>
        public BrokerNodeGroupInfo BrokerNodeGroupInfo
        {
            get { return this._brokerNodeGroupInfo; }
            set { this._brokerNodeGroupInfo = value; }
        }

        // Check to see if BrokerNodeGroupInfo property is set
        internal bool IsSetBrokerNodeGroupInfo()
        {
            return this._brokerNodeGroupInfo != null;
        }

        /// <summary>
        /// Gets and sets the property ClientAuthentication.             
        /// <para>
        /// Includes all client authentication information.
        /// </para>
        /// </summary>
        public ClientAuthentication ClientAuthentication
        {
            get { return this._clientAuthentication; }
            set { this._clientAuthentication = value; }
        }

        // Check to see if ClientAuthentication property is set
        internal bool IsSetClientAuthentication()
        {
            return this._clientAuthentication != null;
        }

        /// <summary>
        /// Gets and sets the property ClusterArn.             
        /// <para>
        /// The Amazon Resource Name (ARN) that uniquely identifies the cluster.
        /// </para>
        /// </summary>
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
        /// Gets and sets the property ClusterName.             
        /// <para>
        /// The name of the cluster.
        /// </para>
        /// </summary>
        public string ClusterName
        {
            get { return this._clusterName; }
            set { this._clusterName = value; }
        }

        // Check to see if ClusterName property is set
        internal bool IsSetClusterName()
        {
            return this._clusterName != null;
        }

        /// <summary>
        /// Gets and sets the property CreationTime.             
        /// <para>
        /// The time when the cluster was created.
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
        /// Gets and sets the property CurrentBrokerSoftwareInfo.             
        /// <para>
        /// Information about the version of software currently deployed on the Apache Kafka brokers
        /// in the cluster.
        /// </para>
        /// </summary>
        public BrokerSoftwareInfo CurrentBrokerSoftwareInfo
        {
            get { return this._currentBrokerSoftwareInfo; }
            set { this._currentBrokerSoftwareInfo = value; }
        }

        // Check to see if CurrentBrokerSoftwareInfo property is set
        internal bool IsSetCurrentBrokerSoftwareInfo()
        {
            return this._currentBrokerSoftwareInfo != null;
        }

        /// <summary>
        /// Gets and sets the property CurrentVersion.             
        /// <para>
        /// The current version of the MSK cluster.
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
        /// Gets and sets the property CustomerActionStatus.             
        /// <para>
        /// Determines if there is an action required from the customer.
        /// </para>
        /// </summary>
        public CustomerActionStatus CustomerActionStatus
        {
            get { return this._customerActionStatus; }
            set { this._customerActionStatus = value; }
        }

        // Check to see if CustomerActionStatus property is set
        internal bool IsSetCustomerActionStatus()
        {
            return this._customerActionStatus != null;
        }

        /// <summary>
        /// Gets and sets the property EncryptionInfo.             
        /// <para>
        /// Includes all encryption-related information.
        /// </para>
        /// </summary>
        public EncryptionInfo EncryptionInfo
        {
            get { return this._encryptionInfo; }
            set { this._encryptionInfo = value; }
        }

        // Check to see if EncryptionInfo property is set
        internal bool IsSetEncryptionInfo()
        {
            return this._encryptionInfo != null;
        }

        /// <summary>
        /// Gets and sets the property EnhancedMonitoring.             
        /// <para>
        /// Specifies which metrics are gathered for the MSK cluster. This property has the following
        /// possible values: DEFAULT, PER_BROKER, PER_TOPIC_PER_BROKER, and PER_TOPIC_PER_PARTITION.
        /// For a list of the metrics associated with each of these levels of monitoring, see
        /// <a href="https://docs.aws.amazon.com/msk/latest/developerguide/monitoring.html">Monitoring</a>.
        /// </para>
        /// </summary>
        public EnhancedMonitoring EnhancedMonitoring
        {
            get { return this._enhancedMonitoring; }
            set { this._enhancedMonitoring = value; }
        }

        // Check to see if EnhancedMonitoring property is set
        internal bool IsSetEnhancedMonitoring()
        {
            return this._enhancedMonitoring != null;
        }

        /// <summary>
        /// Gets and sets the property LoggingInfo.
        /// </summary>
        public LoggingInfo LoggingInfo
        {
            get { return this._loggingInfo; }
            set { this._loggingInfo = value; }
        }

        // Check to see if LoggingInfo property is set
        internal bool IsSetLoggingInfo()
        {
            return this._loggingInfo != null;
        }

        /// <summary>
        /// Gets and sets the property NumberOfBrokerNodes.             
        /// <para>
        /// The number of broker nodes in the cluster.
        /// </para>
        /// </summary>
        public int? NumberOfBrokerNodes
        {
            get { return this._numberOfBrokerNodes; }
            set { this._numberOfBrokerNodes = value; }
        }

        // Check to see if NumberOfBrokerNodes property is set
        internal bool IsSetNumberOfBrokerNodes()
        {
            return this._numberOfBrokerNodes.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property OpenMonitoring.             
        /// <para>
        /// Settings for open monitoring using Prometheus.
        /// </para>
        /// </summary>
        public OpenMonitoring OpenMonitoring
        {
            get { return this._openMonitoring; }
            set { this._openMonitoring = value; }
        }

        // Check to see if OpenMonitoring property is set
        internal bool IsSetOpenMonitoring()
        {
            return this._openMonitoring != null;
        }

        /// <summary>
        /// Gets and sets the property State.             
        /// <para>
        /// The state of the cluster. The possible states are ACTIVE, CREATING, DELETING, FAILED,
        /// HEALING, MAINTENANCE, REBOOTING_BROKER, and UPDATING.
        /// </para>
        /// </summary>
        public ClusterState State
        {
            get { return this._state; }
            set { this._state = value; }
        }

        // Check to see if State property is set
        internal bool IsSetState()
        {
            return this._state != null;
        }

        /// <summary>
        /// Gets and sets the property StateInfo.
        /// </summary>
        public StateInfo StateInfo
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
        /// Gets and sets the property StorageMode.             
        /// <para>
        /// This controls storage mode for supported storage tiers.
        /// </para>
        /// </summary>
        public StorageMode StorageMode
        {
            get { return this._storageMode; }
            set { this._storageMode = value; }
        }

        // Check to see if StorageMode property is set
        internal bool IsSetStorageMode()
        {
            return this._storageMode != null;
        }

        /// <summary>
        /// Gets and sets the property Tags.             
        /// <para>
        /// Tags attached to the cluster.
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

        /// <summary>
        /// Gets and sets the property ZookeeperConnectString.             
        /// <para>
        /// The connection string to use to connect to the Apache ZooKeeper cluster.
        /// </para>
        /// </summary>
        public string ZookeeperConnectString
        {
            get { return this._zookeeperConnectString; }
            set { this._zookeeperConnectString = value; }
        }

        // Check to see if ZookeeperConnectString property is set
        internal bool IsSetZookeeperConnectString()
        {
            return this._zookeeperConnectString != null;
        }

        /// <summary>
        /// Gets and sets the property ZookeeperConnectStringTls.             
        /// <para>
        /// The connection string to use to connect to zookeeper cluster on Tls port.
        /// </para>
        /// </summary>
        public string ZookeeperConnectStringTls
        {
            get { return this._zookeeperConnectStringTls; }
            set { this._zookeeperConnectStringTls = value; }
        }

        // Check to see if ZookeeperConnectStringTls property is set
        internal bool IsSetZookeeperConnectStringTls()
        {
            return this._zookeeperConnectStringTls != null;
        }

    }
}