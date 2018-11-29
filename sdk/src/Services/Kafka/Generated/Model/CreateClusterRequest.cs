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
    /// Container for the parameters to the CreateCluster operation.
    /// Creates a new MSK cluster.
    /// </summary>
    public partial class CreateClusterRequest : AmazonKafkaRequest
    {
        private BrokerNodeGroupInfo _brokerNodeGroupInfo;
        private string _clusterName;
        private EncryptionInfo _encryptionInfo;
        private EnhancedMonitoring _enhancedMonitoring;
        private string _kafkaVersion;
        private int? _numberOfBrokerNodes;

        /// <summary>
        /// Gets and sets the property BrokerNodeGroupInfo. 
        /// <para>
        /// Information about the broker nodes in the cluster.
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
        /// Specifies the level of monitoring for the MSK cluster. The possible values are DEFAULT,
        /// PER_BROKER, and PER_TOPIC_PER_BROKER.
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
        /// Gets and sets the property KafkaVersion. 
        /// <para>
        /// The version of Apache Kafka.
        /// </para>
        /// </summary>
        public string KafkaVersion
        {
            get { return this._kafkaVersion; }
            set { this._kafkaVersion = value; }
        }

        // Check to see if KafkaVersion property is set
        internal bool IsSetKafkaVersion()
        {
            return this._kafkaVersion != null;
        }

        /// <summary>
        /// Gets and sets the property NumberOfBrokerNodes. 
        /// <para>
        /// The number of Kafka broker nodes in the Amazon MSK cluster.
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

    }
}