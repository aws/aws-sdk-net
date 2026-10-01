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
    /// Provisioned cluster request.
    /// </summary>
    public partial class ProvisionedRequest
    {
        /// <summary>
        /// Gets and sets the property BrokerNodeGroupInfo. 
        /// <para>
        /// Information about the brokers.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
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
        /// Gets and sets the property ConfigurationInfo. 
        /// <para>
        /// Represents the configuration that you want Amazon MSK to use for the brokers in a
        /// cluster.
        /// </para>
        /// </summary>
        public ConfigurationInfo ConfigurationInfo { get; set; }

        /// <summary>
        /// Checks to see if the ConfigurationInfo property is set.
        /// </summary>
        internal bool IsSetConfigurationInfo() => this.ConfigurationInfo != null;

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
        /// Specifies the level of monitoring for the MSK cluster. The possible values are DEFAULT,
        /// PER_BROKER, PER_TOPIC_PER_BROKER, and PER_TOPIC_PER_PARTITION.
        /// </para>
        /// </summary>
        public EnhancedMonitoring EnhancedMonitoring { get; set; }

        /// <summary>
        /// Checks to see if the EnhancedMonitoring property is set.
        /// </summary>
        internal bool IsSetEnhancedMonitoring() => this.EnhancedMonitoring != null;

        /// <summary>
        /// Gets and sets the property KafkaVersion. 
        /// <para>
        /// The Apache Kafka version that you want for the cluster.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 128)]
        public string KafkaVersion { get; set; }

        /// <summary>
        /// Checks to see if the KafkaVersion property is set.
        /// </summary>
        internal bool IsSetKafkaVersion() => this.KafkaVersion != null;

        /// <summary>
        /// Gets and sets the property LoggingInfo. 
        /// <para>
        /// Log delivery information for the cluster.
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
        [AWSProperty(Required = true, Min = 1, Max = 15)]
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
        public OpenMonitoringInfo OpenMonitoring { get; set; }

        /// <summary>
        /// Checks to see if the OpenMonitoring property is set.
        /// </summary>
        internal bool IsSetOpenMonitoring() => this.OpenMonitoring != null;

        /// <summary>
        /// Gets and sets the property Rebalancing. 
        /// <para>
        /// Specifies if intelligent rebalancing is turned on for your MSK Provisioned cluster
        /// with Express brokers. For all new Express-based clusters that you create, intelligent
        /// rebalancing is turned on by default.
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
    }
}
