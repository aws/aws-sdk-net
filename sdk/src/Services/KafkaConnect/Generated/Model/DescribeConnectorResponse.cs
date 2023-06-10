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
    /// This is the response object from the DescribeConnector operation.
    /// </summary>
    public partial class DescribeConnectorResponse : AmazonWebServiceResponse
    {
        private CapacityDescription _capacity;
        private string _connectorArn;
        private Dictionary<string, string> _connectorConfiguration = new Dictionary<string, string>();
        private string _connectorDescription;
        private string _connectorName;
        private ConnectorState _connectorState;
        private DateTime? _creationTime;
        private string _currentVersion;
        private KafkaClusterDescription _kafkaCluster;
        private KafkaClusterClientAuthenticationDescription _kafkaClusterClientAuthentication;
        private KafkaClusterEncryptionInTransitDescription _kafkaClusterEncryptionInTransit;
        private string _kafkaConnectVersion;
        private LogDeliveryDescription _logDelivery;
        private List<PluginDescription> _plugins = new List<PluginDescription>();
        private string _serviceExecutionRoleArn;
        private StateDescription _stateDescription;
        private WorkerConfigurationDescription _workerConfiguration;

        /// <summary>
        /// Gets and sets the property Capacity. 
        /// <para>
        /// Information about the capacity of the connector, whether it is auto scaled or provisioned.
        /// </para>
        /// </summary>
        public CapacityDescription Capacity
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
        /// Gets and sets the property ConnectorArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the connector.
        /// </para>
        /// </summary>
        public string ConnectorArn
        {
            get { return this._connectorArn; }
            set { this._connectorArn = value; }
        }

        // Check to see if ConnectorArn property is set
        internal bool IsSetConnectorArn()
        {
            return this._connectorArn != null;
        }

        /// <summary>
        /// Gets and sets the property ConnectorConfiguration. 
        /// <para>
        /// A map of keys to values that represent the configuration for the connector.
        /// </para>
        /// </summary>
        [AWSProperty(Sensitive=true)]
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
        /// Gets and sets the property ConnectorState. 
        /// <para>
        /// The state of the connector.
        /// </para>
        /// </summary>
        public ConnectorState ConnectorState
        {
            get { return this._connectorState; }
            set { this._connectorState = value; }
        }

        // Check to see if ConnectorState property is set
        internal bool IsSetConnectorState()
        {
            return this._connectorState != null;
        }

        /// <summary>
        /// Gets and sets the property CreationTime. 
        /// <para>
        /// The time the connector was created.
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
        /// Gets and sets the property CurrentVersion. 
        /// <para>
        /// The current version of the connector.
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
        /// Gets and sets the property KafkaCluster. 
        /// <para>
        /// The Apache Kafka cluster that the connector is connected to.
        /// </para>
        /// </summary>
        public KafkaClusterDescription KafkaCluster
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
        /// The type of client authentication used to connect to the Apache Kafka cluster. The
        /// value is NONE when no client authentication is used.
        /// </para>
        /// </summary>
        public KafkaClusterClientAuthenticationDescription KafkaClusterClientAuthentication
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
        public KafkaClusterEncryptionInTransitDescription KafkaClusterEncryptionInTransit
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
        /// Details about delivering logs to Amazon CloudWatch Logs.
        /// </para>
        /// </summary>
        public LogDeliveryDescription LogDelivery
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
        /// Specifies which plugins were used for this connector.
        /// </para>
        /// </summary>
        public List<PluginDescription> Plugins
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
        /// The Amazon Resource Name (ARN) of the IAM role used by the connector to access Amazon
        /// Web Services resources.
        /// </para>
        /// </summary>
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
        /// Gets and sets the property StateDescription. 
        /// <para>
        /// Details about the state of a connector.
        /// </para>
        /// </summary>
        public StateDescription StateDescription
        {
            get { return this._stateDescription; }
            set { this._stateDescription = value; }
        }

        // Check to see if StateDescription property is set
        internal bool IsSetStateDescription()
        {
            return this._stateDescription != null;
        }

        /// <summary>
        /// Gets and sets the property WorkerConfiguration. 
        /// <para>
        /// Specifies which worker configuration was used for the connector.
        /// </para>
        /// </summary>
        public WorkerConfigurationDescription WorkerConfiguration
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