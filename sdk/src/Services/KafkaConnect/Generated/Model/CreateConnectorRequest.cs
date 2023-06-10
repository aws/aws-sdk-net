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
 * Do not modify this file. This file is generated from the kafkaconnect-2021-09-14.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.KafkaConnect.Model
{
    /// <summary>
    /// Container for the parameters to the CreateConnector operation.
    /// Creates a connector using the specified properties.
    /// </summary>
    public partial class CreateConnectorRequest : AmazonKafkaConnectRequest
    {
        private Capacity _capacity;
        private Dictionary<string, string> _connectorConfiguration = new Dictionary<string, string>();
        private string _connectorDescription;
        private string _connectorName;
        private KafkaCluster _kafkaCluster;
        private KafkaClusterClientAuthentication _kafkaClusterClientAuthentication;
        private KafkaClusterEncryptionInTransit _kafkaClusterEncryptionInTransit;
        private string _kafkaConnectVersion;
        private LogDelivery _logDelivery;
        private List<Plugin> _plugins = new List<Plugin>();
        private string _serviceExecutionRoleArn;
        private WorkerConfiguration _workerConfiguration;

        /// <summary>
        /// Gets and sets the property Capacity. 
        /// <para>
        /// Information about the capacity allocated to the connector. Exactly one of the two
        /// properties must be specified.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public Capacity Capacity
        {
            get { return this._capacity; }
            set { this._capacity = value; }
        }

        // Check to see if Capacity property is set
        internal bool IsSetCapacity()
        {
            return this._capacity != null;
        }

        /// <summary>
        /// Gets and sets the property ConnectorConfiguration. 
        /// <para>
        /// A map of keys to values that represent the configuration for the connector.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Sensitive=true)]
        public Dictionary<string, string> ConnectorConfiguration
        {
            get { return this._connectorConfiguration; }
            set { this._connectorConfiguration = value; }
        }

        // Check to see if ConnectorConfiguration property is set
        internal bool IsSetConnectorConfiguration()
        {
            return this._connectorConfiguration != null && this._connectorConfiguration.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property ConnectorDescription. 
        /// <para>
        /// A summary description of the connector.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=1024)]
        public string ConnectorDescription
        {
            get { return this._connectorDescription; }
            set { this._connectorDescription = value; }
        }

        // Check to see if ConnectorDescription property is set
        internal bool IsSetConnectorDescription()
        {
            return this._connectorDescription != null;
        }

        /// <summary>
        /// Gets and sets the property ConnectorName. 
        /// <para>
        /// The name of the connector.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=128)]
        public string ConnectorName
        {
            get { return this._connectorName; }
            set { this._connectorName = value; }
        }

        // Check to see if ConnectorName property is set
        internal bool IsSetConnectorName()
        {
            return this._connectorName != null;
        }

        /// <summary>
        /// Gets and sets the property KafkaCluster. 
        /// <para>
        /// Specifies which Apache Kafka cluster to connect to.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public KafkaCluster KafkaCluster
        {
            get { return this._kafkaCluster; }
            set { this._kafkaCluster = value; }
        }

        // Check to see if KafkaCluster property is set
        internal bool IsSetKafkaCluster()
        {
            return this._kafkaCluster != null;
        }

        /// <summary>
        /// Gets and sets the property KafkaClusterClientAuthentication. 
        /// <para>
        /// Details of the client authentication used by the Apache Kafka cluster.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public KafkaClusterClientAuthentication KafkaClusterClientAuthentication
        {
            get { return this._kafkaClusterClientAuthentication; }
            set { this._kafkaClusterClientAuthentication = value; }
        }

        // Check to see if KafkaClusterClientAuthentication property is set
        internal bool IsSetKafkaClusterClientAuthentication()
        {
            return this._kafkaClusterClientAuthentication != null;
        }

        /// <summary>
        /// Gets and sets the property KafkaClusterEncryptionInTransit. 
        /// <para>
        /// Details of encryption in transit to the Apache Kafka cluster.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public KafkaClusterEncryptionInTransit KafkaClusterEncryptionInTransit
        {
            get { return this._kafkaClusterEncryptionInTransit; }
            set { this._kafkaClusterEncryptionInTransit = value; }
        }

        // Check to see if KafkaClusterEncryptionInTransit property is set
        internal bool IsSetKafkaClusterEncryptionInTransit()
        {
            return this._kafkaClusterEncryptionInTransit != null;
        }

        /// <summary>
        /// Gets and sets the property KafkaConnectVersion. 
        /// <para>
        /// The version of Kafka Connect. It has to be compatible with both the Apache Kafka cluster's
        /// version and the plugins.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string KafkaConnectVersion
        {
            get { return this._kafkaConnectVersion; }
            set { this._kafkaConnectVersion = value; }
        }

        // Check to see if KafkaConnectVersion property is set
        internal bool IsSetKafkaConnectVersion()
        {
            return this._kafkaConnectVersion != null;
        }

        /// <summary>
        /// Gets and sets the property LogDelivery. 
        /// <para>
        /// Details about log delivery.
        /// </para>
        /// </summary>
        public LogDelivery LogDelivery
        {
            get { return this._logDelivery; }
            set { this._logDelivery = value; }
        }

        // Check to see if LogDelivery property is set
        internal bool IsSetLogDelivery()
        {
            return this._logDelivery != null;
        }

        /// <summary>
        /// Gets and sets the property Plugins. 
        /// <para>
        /// Specifies which plugins to use for the connector.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public List<Plugin> Plugins
        {
            get { return this._plugins; }
            set { this._plugins = value; }
        }

        // Check to see if Plugins property is set
        internal bool IsSetPlugins()
        {
            return this._plugins != null && this._plugins.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property ServiceExecutionRoleArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the IAM role used by the connector to access the
        /// Amazon Web Services resources that it needs. The types of resources depends on the
        /// logic of the connector. For example, a connector that has Amazon S3 as a destination
        /// must have permissions that allow it to write to the S3 destination bucket.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string ServiceExecutionRoleArn
        {
            get { return this._serviceExecutionRoleArn; }
            set { this._serviceExecutionRoleArn = value; }
        }

        // Check to see if ServiceExecutionRoleArn property is set
        internal bool IsSetServiceExecutionRoleArn()
        {
            return this._serviceExecutionRoleArn != null;
        }

        /// <summary>
        /// Gets and sets the property WorkerConfiguration. 
        /// <para>
        /// Specifies which worker configuration to use with the connector.
        /// </para>
        /// </summary>
        public WorkerConfiguration WorkerConfiguration
        {
            get { return this._workerConfiguration; }
            set { this._workerConfiguration = value; }
        }

        // Check to see if WorkerConfiguration property is set
        internal bool IsSetWorkerConfiguration()
        {
            return this._workerConfiguration != null;
        }

    }
}