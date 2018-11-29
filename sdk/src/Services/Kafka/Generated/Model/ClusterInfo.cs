/*
 * Copyright 2010-2014 Amazon.com, Inc. or its affiliates. All Rights Reserved.
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

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.Kafka.Model
{
    /// <summary>
    /// Returns information about a cluster.
    /// </summary>
    public partial class ClusterInfo
    {
        private BrokerNodeGroupInfo _brokerNodeGroupInfo;
        private string _clusterArn;
        private string _clusterName;
        private DateTime? _creationTime;
        private BrokerSoftwareInfo _currentBrokerSoftwareInfo;
        private string _currentVersion;
        private EncryptionInfo _encryptionInfo;
        private EnhancedMonitoring _enhancedMonitoring;
        private int? _numberOfBrokerNodes;
        private ClusterState _state;
        private string _zookeeperConnectString;

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
        public DateTime CreationTime
        {
            get { return this._creationTime.GetValueOrDefault(); }
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
        /// Information about the version of software currently deployed on the Kafka brokers
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
        /// Specifies which metrics are gathered for the MSK cluster. This property has three
        /// possible values: DEFAULT, PER_BROKER, and PER_TOPIC_PER_BROKER.
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
        /// Gets and sets the property NumberOfBrokerNodes. 
        /// <para>
        /// The number of Kafka broker nodes in the cluster.
        /// </para>
        /// </summary>
        public int NumberOfBrokerNodes
        {
            get { return this._numberOfBrokerNodes.GetValueOrDefault(); }
            set { this._numberOfBrokerNodes = value; }
        }

        // Check to see if NumberOfBrokerNodes property is set
        internal bool IsSetNumberOfBrokerNodes()
        {
            return this._numberOfBrokerNodes.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property State. 
        /// <para>
        /// The state of the cluster. The possible states are CREATING, ACTIVE, and FAILED.
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

    }
}