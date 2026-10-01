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
    /// Information about cluster attributes that can be updated via update APIs.
    /// </summary>
    public partial class MutableClusterInfo
    {
        /// <summary>
        /// Gets and sets the property BrokerCountUpdateInfo. 
        /// <para>
        /// Describes brokers being changed during a broker count update.
        /// </para>
        /// </summary>
        public BrokerCountUpdateInfo BrokerCountUpdateInfo { get; set; }

        /// <summary>
        /// Checks to see if the BrokerCountUpdateInfo property is set.
        /// </summary>
        internal bool IsSetBrokerCountUpdateInfo() => this.BrokerCountUpdateInfo != null;

        /// <summary>
        /// Gets and sets the property BrokerEBSVolumeInfo. 
        /// <para>
        /// Specifies the size of the EBS volume and the ID of the associated broker.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<BrokerEBSVolumeInfo> BrokerEBSVolumeInfo { get; set; } = AWSConfigs.InitializeCollections ? new List<BrokerEBSVolumeInfo>() : null;

        /// <summary>
        /// Checks to see if the BrokerEBSVolumeInfo property is set.
        /// </summary>
        internal bool IsSetBrokerEBSVolumeInfo() => this.BrokerEBSVolumeInfo != null && (this.BrokerEBSVolumeInfo.Count > 0 || !AWSConfigs.InitializeCollections);

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
        /// Gets and sets the property ConfigurationInfo. 
        /// <para>
        /// Information about the changes in the configuration of the brokers.
        /// </para>
        /// </summary>
        public ConfigurationInfo ConfigurationInfo { get; set; }

        /// <summary>
        /// Checks to see if the ConfigurationInfo property is set.
        /// </summary>
        internal bool IsSetConfigurationInfo() => this.ConfigurationInfo != null;

        /// <summary>
        /// Gets and sets the property ConnectivityInfo. 
        /// <para>
        /// Information about the broker access configuration.
        /// </para>
        /// </summary>
        public ConnectivityInfo ConnectivityInfo { get; set; }

        /// <summary>
        /// Checks to see if the ConnectivityInfo property is set.
        /// </summary>
        internal bool IsSetConnectivityInfo() => this.ConnectivityInfo != null;

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
        /// Specifies which Apache Kafka metrics Amazon MSK gathers and sends to Amazon CloudWatch
        /// for this cluster.
        /// </para>
        /// </summary>
        public EnhancedMonitoring EnhancedMonitoring { get; set; }

        /// <summary>
        /// Checks to see if the EnhancedMonitoring property is set.
        /// </summary>
        internal bool IsSetEnhancedMonitoring() => this.EnhancedMonitoring != null;

        /// <summary>
        /// Gets and sets the property InstanceType. 
        /// <para>
        /// Information about the Amazon MSK broker type.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 5, Max = 32)]
        public string InstanceType { get; set; }

        /// <summary>
        /// Checks to see if the InstanceType property is set.
        /// </summary>
        internal bool IsSetInstanceType() => this.InstanceType != null;

        /// <summary>
        /// Gets and sets the property KafkaVersion. 
        /// <para>
        /// The Apache Kafka version.
        /// </para>
        /// </summary>
        public string KafkaVersion { get; set; }

        /// <summary>
        /// Checks to see if the KafkaVersion property is set.
        /// </summary>
        internal bool IsSetKafkaVersion() => this.KafkaVersion != null;

        /// <summary>
        /// Gets and sets the property LoggingInfo. 
        /// <para>
        /// You can configure your MSK cluster to send broker logs to different destination types.
        /// This is a container for the configuration details related to broker logs.
        /// </para>
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
        /// The settings for open monitoring.
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
        /// Describes the intelligent rebalancing configuration of an MSK Provisioned cluster
        /// with Express brokers.
        /// </para>
        /// </summary>
        public Rebalancing Rebalancing { get; set; }

        /// <summary>
        /// Checks to see if the Rebalancing property is set.
        /// </summary>
        internal bool IsSetRebalancing() => this.Rebalancing != null;

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
        /// Gets and sets the property ZookeeperAccess. 
        /// <para>
        /// Access control settings for zookeeper
        /// </para>
        /// </summary>
        public ZookeeperAccess ZookeeperAccess { get; set; }

        /// <summary>
        /// Checks to see if the ZookeeperAccess property is set.
        /// </summary>
        internal bool IsSetZookeeperAccess() => this.ZookeeperAccess != null;
    }
}
