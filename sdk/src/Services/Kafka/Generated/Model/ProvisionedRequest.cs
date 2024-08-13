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
    /// Provisioned cluster request.
    /// </summary>
    public partial class ProvisionedRequest
    {
        private BrokerNodeGroupInfo _brokerNodeGroupInfo;
        private ClientAuthentication _clientAuthentication;
        private ConfigurationInfo _configurationInfo;
        private EncryptionInfo _encryptionInfo;
        private EnhancedMonitoring _enhancedMonitoring;
        private string _kafkaVersion;
        private LoggingInfo _loggingInfo;
        private int? _numberOfBrokerNodes;
        private OpenMonitoringInfo _openMonitoring;
        private StorageMode _storageMode;

        /// <summary>
        /// Gets and sets the property BrokerNodeGroupInfo.             
        /// <para>
        /// Information about the brokers.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
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
        /// Gets and sets the property ConfigurationInfo.             
        /// <para>
        /// Represents the configuration that you want Amazon MSK to use for the brokers in a
        /// cluster.
        /// </para>
        /// </summary>
        public ConfigurationInfo ConfigurationInfo
        {
            get { return this._configurationInfo; }
            set { this._configurationInfo = value; }
        }

        // Check to see if ConfigurationInfo property is set
        internal bool IsSetConfigurationInfo()
        {
            return this._configurationInfo != null;
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
        /// PER_BROKER, PER_TOPIC_PER_BROKER, and PER_TOPIC_PER_PARTITION.
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
        /// The Apache Kafka version that you want for the cluster.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=128)]
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
        /// Gets and sets the property LoggingInfo.             
        /// <para>
        /// Log delivery information for the cluster.
        /// </para>
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
        [AWSProperty(Required=true, Min=1, Max=15)]
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
        /// The settings for open monitoring.
        /// </para>
        /// </summary>
        public OpenMonitoringInfo OpenMonitoring
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

    }
}