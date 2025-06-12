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
    /// Information about cluster attributes that can be updated via update APIs.
    /// </summary>
    public partial class MutableClusterInfo
    {
        private BrokerCountUpdateInfo _brokerCountUpdateInfo;
        private List<BrokerEBSVolumeInfo> _brokerEBSVolumeInfo = AWSConfigs.InitializeCollections ? new List<BrokerEBSVolumeInfo>() : null;
        private ClientAuthentication _clientAuthentication;
        private ConfigurationInfo _configurationInfo;
        private ConnectivityInfo _connectivityInfo;
        private EncryptionInfo _encryptionInfo;
        private EnhancedMonitoring _enhancedMonitoring;
        private string _instanceType;
        private string _kafkaVersion;
        private LoggingInfo _loggingInfo;
        private int? _numberOfBrokerNodes;
        private OpenMonitoring _openMonitoring;
        private StorageMode _storageMode;

        /// <summary>
        /// Gets and sets the property BrokerCountUpdateInfo.             
        /// <para>
        /// Describes brokers being changed during a broker count update.
        /// </para>
        /// </summary>
        public BrokerCountUpdateInfo BrokerCountUpdateInfo
        {
            get { return this._brokerCountUpdateInfo; }
            set { this._brokerCountUpdateInfo = value; }
        }

        // Check to see if BrokerCountUpdateInfo property is set
        internal bool IsSetBrokerCountUpdateInfo()
        {
            return this._brokerCountUpdateInfo != null;
        }

        /// <summary>
        /// Gets and sets the property BrokerEBSVolumeInfo.             
        /// <para>
        /// Specifies the size of the EBS volume and the ID of the associated broker.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<BrokerEBSVolumeInfo> BrokerEBSVolumeInfo
        {
            get { return this._brokerEBSVolumeInfo; }
            set { this._brokerEBSVolumeInfo = value; }
        }

        // Check to see if BrokerEBSVolumeInfo property is set
        internal bool IsSetBrokerEBSVolumeInfo()
        {
            return this._brokerEBSVolumeInfo != null && (this._brokerEBSVolumeInfo.Count > 0 || !AWSConfigs.InitializeCollections); 
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
        /// Information about the changes in the configuration of the brokers.
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
        /// Gets and sets the property ConnectivityInfo.             
        /// <para>
        /// Information about the broker access configuration.
        /// </para>
        /// </summary>
        public ConnectivityInfo ConnectivityInfo
        {
            get { return this._connectivityInfo; }
            set { this._connectivityInfo = value; }
        }

        // Check to see if ConnectivityInfo property is set
        internal bool IsSetConnectivityInfo()
        {
            return this._connectivityInfo != null;
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
        /// Specifies which Apache Kafka metrics Amazon MSK gathers and sends to Amazon CloudWatch
        /// for this cluster.
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
        /// Gets and sets the property InstanceType.             
        /// <para>
        /// Information about the Amazon MSK broker type.
        /// </para>
        /// </summary>
        [AWSProperty(Min=5, Max=32)]
        public string InstanceType
        {
            get { return this._instanceType; }
            set { this._instanceType = value; }
        }

        // Check to see if InstanceType property is set
        internal bool IsSetInstanceType()
        {
            return this._instanceType != null;
        }

        /// <summary>
        /// Gets and sets the property KafkaVersion.             
        /// <para>
        /// The Apache Kafka version.
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
        /// Gets and sets the property LoggingInfo.             
        /// <para>
        /// You can configure your MSK cluster to send broker logs to different destination types.
        /// This is a container for the configuration details related to broker logs.
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