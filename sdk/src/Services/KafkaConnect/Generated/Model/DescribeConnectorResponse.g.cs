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

namespace Amazon.KafkaConnect.Model
{
    /// <summary>
    /// This is the response object from the DescribeConnector operation.
    /// </summary>
    public partial class DescribeConnectorResponse : AmazonWebServiceResponse
    {
        /// <summary>
        /// Gets and sets the property Capacity. 
        /// <para>
        /// Information about the capacity of the connector, whether it is auto scaled or provisioned.
        /// </para>
        /// </summary>
        public CapacityDescription Capacity { get; set; }

        /// <summary>
        /// Checks to see if the Capacity property is set.
        /// </summary>
        internal bool IsSetCapacity() => this.Capacity != null;

        /// <summary>
        /// Gets and sets the property ConnectorArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the connector.
        /// </para>
        /// </summary>
        public string ConnectorArn { get; set; }

        /// <summary>
        /// Checks to see if the ConnectorArn property is set.
        /// </summary>
        internal bool IsSetConnectorArn() => this.ConnectorArn != null;

        /// <summary>
        /// Gets and sets the property ConnectorConfiguration. 
        /// <para>
        /// A map of keys to values that represent the configuration for the connector.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Sensitive = true)]
        public Dictionary<string, string> ConnectorConfiguration { get; set; } = AWSConfigs.InitializeCollections ? new Dictionary<string, string>() : null;

        /// <summary>
        /// Checks to see if the ConnectorConfiguration property is set.
        /// </summary>
        internal bool IsSetConnectorConfiguration() => this.ConnectorConfiguration != null && (this.ConnectorConfiguration.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property ConnectorDescription. 
        /// <para>
        /// A summary description of the connector.
        /// </para>
        /// </summary>
        public string ConnectorDescription { get; set; }

        /// <summary>
        /// Checks to see if the ConnectorDescription property is set.
        /// </summary>
        internal bool IsSetConnectorDescription() => this.ConnectorDescription != null;

        /// <summary>
        /// Gets and sets the property ConnectorName. 
        /// <para>
        /// The name of the connector.
        /// </para>
        /// </summary>
        public string ConnectorName { get; set; }

        /// <summary>
        /// Checks to see if the ConnectorName property is set.
        /// </summary>
        internal bool IsSetConnectorName() => this.ConnectorName != null;

        /// <summary>
        /// Gets and sets the property ConnectorState. 
        /// <para>
        /// The state of the connector.
        /// </para>
        /// </summary>
        public ConnectorState ConnectorState { get; set; }

        /// <summary>
        /// Checks to see if the ConnectorState property is set.
        /// </summary>
        internal bool IsSetConnectorState() => this.ConnectorState != null;

        /// <summary>
        /// Gets and sets the property CreationTime. 
        /// <para>
        /// The time the connector was created.
        /// </para>
        /// </summary>
        public DateTime? CreationTime { get; set; }

        /// <summary>
        /// Checks to see if the CreationTime property is set.
        /// </summary>
        internal bool IsSetCreationTime() => this.CreationTime.HasValue;

        /// <summary>
        /// Gets and sets the property CurrentVersion. 
        /// <para>
        /// The current version of the connector.
        /// </para>
        /// </summary>
        public string CurrentVersion { get; set; }

        /// <summary>
        /// Checks to see if the CurrentVersion property is set.
        /// </summary>
        internal bool IsSetCurrentVersion() => this.CurrentVersion != null;

        /// <summary>
        /// Gets and sets the property KafkaCluster. 
        /// <para>
        /// The Apache Kafka cluster that the connector is connected to.
        /// </para>
        /// </summary>
        public KafkaClusterDescription KafkaCluster { get; set; }

        /// <summary>
        /// Checks to see if the KafkaCluster property is set.
        /// </summary>
        internal bool IsSetKafkaCluster() => this.KafkaCluster != null;

        /// <summary>
        /// Gets and sets the property KafkaClusterClientAuthentication. 
        /// <para>
        /// The type of client authentication used to connect to the Apache Kafka cluster. The
        /// value is NONE when no client authentication is used.
        /// </para>
        /// </summary>
        public KafkaClusterClientAuthenticationDescription KafkaClusterClientAuthentication { get; set; }

        /// <summary>
        /// Checks to see if the KafkaClusterClientAuthentication property is set.
        /// </summary>
        internal bool IsSetKafkaClusterClientAuthentication() => this.KafkaClusterClientAuthentication != null;

        /// <summary>
        /// Gets and sets the property KafkaClusterEncryptionInTransit. 
        /// <para>
        /// Details of encryption in transit to the Apache Kafka cluster.
        /// </para>
        /// </summary>
        public KafkaClusterEncryptionInTransitDescription KafkaClusterEncryptionInTransit { get; set; }

        /// <summary>
        /// Checks to see if the KafkaClusterEncryptionInTransit property is set.
        /// </summary>
        internal bool IsSetKafkaClusterEncryptionInTransit() => this.KafkaClusterEncryptionInTransit != null;

        /// <summary>
        /// Gets and sets the property KafkaConnectVersion. 
        /// <para>
        /// The version of Kafka Connect. It has to be compatible with both the Apache Kafka cluster's
        /// version and the plugins.
        /// </para>
        /// </summary>
        public string KafkaConnectVersion { get; set; }

        /// <summary>
        /// Checks to see if the KafkaConnectVersion property is set.
        /// </summary>
        internal bool IsSetKafkaConnectVersion() => this.KafkaConnectVersion != null;

        /// <summary>
        /// Gets and sets the property LogDelivery. 
        /// <para>
        /// Details about delivering logs to Amazon CloudWatch Logs.
        /// </para>
        /// </summary>
        public LogDeliveryDescription LogDelivery { get; set; }

        /// <summary>
        /// Checks to see if the LogDelivery property is set.
        /// </summary>
        internal bool IsSetLogDelivery() => this.LogDelivery != null;

        /// <summary>
        /// Gets and sets the property NetworkType. 
        /// <para>
        /// The network type of the connector. It gives connectors connectivity to either IPv4
        /// (IPV4) or IPv4 and IPv6 (DUAL) destinations. Defaults to IPV4.
        /// </para>
        /// </summary>
        public NetworkType NetworkType { get; set; }

        /// <summary>
        /// Checks to see if the NetworkType property is set.
        /// </summary>
        internal bool IsSetNetworkType() => this.NetworkType != null;

        /// <summary>
        /// Gets and sets the property Plugins. 
        /// <para>
        /// Specifies which plugins were used for this connector.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<PluginDescription> Plugins { get; set; } = AWSConfigs.InitializeCollections ? new List<PluginDescription>() : null;

        /// <summary>
        /// Checks to see if the Plugins property is set.
        /// </summary>
        internal bool IsSetPlugins() => this.Plugins != null && (this.Plugins.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property ServiceExecutionRoleArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the IAM role used by the connector to access Amazon
        /// Web Services resources.
        /// </para>
        /// </summary>
        public string ServiceExecutionRoleArn { get; set; }

        /// <summary>
        /// Checks to see if the ServiceExecutionRoleArn property is set.
        /// </summary>
        internal bool IsSetServiceExecutionRoleArn() => this.ServiceExecutionRoleArn != null;

        /// <summary>
        /// Gets and sets the property StateDescription. 
        /// <para>
        /// Details about the state of a connector.
        /// </para>
        /// </summary>
        public StateDescription StateDescription { get; set; }

        /// <summary>
        /// Checks to see if the StateDescription property is set.
        /// </summary>
        internal bool IsSetStateDescription() => this.StateDescription != null;

        /// <summary>
        /// Gets and sets the property WorkerConfiguration. 
        /// <para>
        /// Specifies which worker configuration was used for the connector.
        /// </para>
        /// </summary>
        public WorkerConfigurationDescription WorkerConfiguration { get; set; }

        /// <summary>
        /// Checks to see if the WorkerConfiguration property is set.
        /// </summary>
        internal bool IsSetWorkerConfiguration() => this.WorkerConfiguration != null;
    }
}
