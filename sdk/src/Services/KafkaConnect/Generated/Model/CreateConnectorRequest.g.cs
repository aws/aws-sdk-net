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
    /// Container for the parameters to the CreateConnector operation. Creates a connector
    /// using the specified properties.
    /// </summary>
    public partial class CreateConnectorRequest : AmazonKafkaConnectRequest
    {
        /// <summary>
        /// Gets and sets the property Capacity. 
        /// <para>
        /// Information about the capacity allocated to the connector. Exactly one of the two
        /// properties must be specified.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public Capacity Capacity { get; set; }

        /// <summary>
        /// Checks to see if the Capacity property is set.
        /// </summary>
        internal bool IsSetCapacity() => this.Capacity != null;

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
        [AWSProperty(Required = true, Sensitive = true)]
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
        [AWSProperty(Min = 0, Max = 1024)]
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
        [AWSProperty(Required = true, Min = 1, Max = 128)]
        public string ConnectorName { get; set; }

        /// <summary>
        /// Checks to see if the ConnectorName property is set.
        /// </summary>
        internal bool IsSetConnectorName() => this.ConnectorName != null;

        /// <summary>
        /// Gets and sets the property KafkaCluster. 
        /// <para>
        /// Specifies which Apache Kafka cluster to connect to.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public KafkaCluster KafkaCluster { get; set; }

        /// <summary>
        /// Checks to see if the KafkaCluster property is set.
        /// </summary>
        internal bool IsSetKafkaCluster() => this.KafkaCluster != null;

        /// <summary>
        /// Gets and sets the property KafkaClusterClientAuthentication. 
        /// <para>
        /// Details of the client authentication used by the Apache Kafka cluster.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public KafkaClusterClientAuthentication KafkaClusterClientAuthentication { get; set; }

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
        [AWSProperty(Required = true)]
        public KafkaClusterEncryptionInTransit KafkaClusterEncryptionInTransit { get; set; }

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
        [AWSProperty(Required = true)]
        public string KafkaConnectVersion { get; set; }

        /// <summary>
        /// Checks to see if the KafkaConnectVersion property is set.
        /// </summary>
        internal bool IsSetKafkaConnectVersion() => this.KafkaConnectVersion != null;

        /// <summary>
        /// Gets and sets the property LogDelivery. 
        /// <para>
        /// Details about log delivery.
        /// </para>
        /// </summary>
        public LogDelivery LogDelivery { get; set; }

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
        /// Gets and sets the property Plugins. <important> 
        /// <para>
        /// Amazon MSK Connect does not currently support specifying multiple plugins as a list.
        /// To use more than one plugin for your connector, you can create a single custom plugin
        /// using a ZIP file that bundles multiple plugins together.
        /// </para>
        ///  </important> 
        /// <para>
        /// Specifies which plugin to use for the connector. You must specify a single-element
        /// list containing one <c>customPlugin</c> object.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Required = true)]
        public List<Plugin> Plugins { get; set; } = AWSConfigs.InitializeCollections ? new List<Plugin>() : null;

        /// <summary>
        /// Checks to see if the Plugins property is set.
        /// </summary>
        internal bool IsSetPlugins() => this.Plugins != null && (this.Plugins.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property ServiceExecutionRoleArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the IAM role used by the connector to access the
        /// Amazon Web Services resources that it needs. The types of resources depends on the
        /// logic of the connector. For example, a connector that has Amazon S3 as a destination
        /// must have permissions that allow it to write to the S3 destination bucket.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public string ServiceExecutionRoleArn { get; set; }

        /// <summary>
        /// Checks to see if the ServiceExecutionRoleArn property is set.
        /// </summary>
        internal bool IsSetServiceExecutionRoleArn() => this.ServiceExecutionRoleArn != null;

        /// <summary>
        /// Gets and sets the property Tags. 
        /// <para>
        /// The tags you want to attach to the connector.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min = 0, Max = 200)]
        public Dictionary<string, string> Tags { get; set; } = AWSConfigs.InitializeCollections ? new Dictionary<string, string>() : null;

        /// <summary>
        /// Checks to see if the Tags property is set.
        /// </summary>
        internal bool IsSetTags() => this.Tags != null && (this.Tags.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property WorkerConfiguration. 
        /// <para>
        /// Specifies which worker configuration to use with the connector.
        /// </para>
        /// </summary>
        public WorkerConfiguration WorkerConfiguration { get; set; }

        /// <summary>
        /// Checks to see if the WorkerConfiguration property is set.
        /// </summary>
        internal bool IsSetWorkerConfiguration() => this.WorkerConfiguration != null;
    }
}
