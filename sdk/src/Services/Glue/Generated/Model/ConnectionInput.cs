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
 * Do not modify this file. This file is generated from the glue-2017-03-31.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.Glue.Model
{
    /// <summary>
    /// A structure that is used to specify a connection to create or update.
    /// </summary>
    public partial class ConnectionInput
    {
        private Dictionary<string, string> _connectionProperties = new Dictionary<string, string>();
        private ConnectionType _connectionType;
        private string _description;
        private List<string> _matchCriteria = new List<string>();
        private string _name;
        private PhysicalConnectionRequirements _physicalConnectionRequirements;

        /// <summary>
        /// Gets and sets the property ConnectionProperties. 
        /// <para>
        /// These key-value pairs define parameters for the connection.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=0, Max=100)]
        public Dictionary<string, string> ConnectionProperties
        {
            get { return this._connectionProperties; }
            set { this._connectionProperties = value; }
        }

        // Check to see if ConnectionProperties property is set
        internal bool IsSetConnectionProperties()
        {
            return this._connectionProperties != null && this._connectionProperties.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property ConnectionType. 
        /// <para>
        /// The type of the connection. Currently, these types are supported:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <code>JDBC</code> - Designates a connection to a database through Java Database Connectivity
        /// (JDBC).
        /// </para>
        ///  
        /// <para>
        ///  <code>JDBC</code> Connections use the following ConnectionParameters.
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// Required: All of (<code>HOST</code>, <code>PORT</code>, <code>JDBC_ENGINE</code>)
        /// or <code>JDBC_CONNECTION_URL</code>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Required: All of (<code>USERNAME</code>, <code>PASSWORD</code>) or <code>SECRET_ID</code>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Optional: <code>JDBC_ENFORCE_SSL</code>, <code>CUSTOM_JDBC_CERT</code>, <code>CUSTOM_JDBC_CERT_STRING</code>,
        /// <code>SKIP_CUSTOM_JDBC_CERT_VALIDATION</code>. These parameters are used to configure
        /// SSL with JDBC.
        /// </para>
        ///  </li> </ul> </li> <li> 
        /// <para>
        ///  <code>KAFKA</code> - Designates a connection to an Apache Kafka streaming platform.
        /// </para>
        ///  
        /// <para>
        ///  <code>KAFKA</code> Connections use the following ConnectionParameters.
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// Required: <code>KAFKA_BOOTSTRAP_SERVERS</code>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Optional: <code>KAFKA_SSL_ENABLED</code>, <code>KAFKA_CUSTOM_CERT</code>, <code>KAFKA_SKIP_CUSTOM_CERT_VALIDATION</code>.
        /// These parameters are used to configure SSL with <code>KAFKA</code>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Optional: <code>KAFKA_CLIENT_KEYSTORE</code>, <code>KAFKA_CLIENT_KEYSTORE_PASSWORD</code>,
        /// <code>KAFKA_CLIENT_KEY_PASSWORD</code>, <code>ENCRYPTED_KAFKA_CLIENT_KEYSTORE_PASSWORD</code>,
        /// <code>ENCRYPTED_KAFKA_CLIENT_KEY_PASSWORD</code>. These parameters are used to configure
        /// TLS client configuration with SSL in <code>KAFKA</code>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Optional: <code>KAFKA_SASL_MECHANISM</code>. Can be specified as <code>SCRAM-SHA-512</code>,
        /// <code>GSSAPI</code>, or <code>AWS_MSK_IAM</code>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Optional: <code>KAFKA_SASL_SCRAM_USERNAME</code>, <code>KAFKA_SASL_SCRAM_PASSWORD</code>,
        /// <code>ENCRYPTED_KAFKA_SASL_SCRAM_PASSWORD</code>. These parameters are used to configure
        /// SASL/SCRAM-SHA-512 authentication with <code>KAFKA</code>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Optional: <code>KAFKA_SASL_GSSAPI_KEYTAB</code>, <code>KAFKA_SASL_GSSAPI_KRB5_CONF</code>,
        /// <code>KAFKA_SASL_GSSAPI_SERVICE</code>, <code>KAFKA_SASL_GSSAPI_PRINCIPAL</code>.
        /// These parameters are used to configure SASL/GSSAPI authentication with <code>KAFKA</code>.
        /// </para>
        ///  </li> </ul> </li> <li> 
        /// <para>
        ///  <code>MONGODB</code> - Designates a connection to a MongoDB document database.
        /// </para>
        ///  
        /// <para>
        ///  <code>MONGODB</code> Connections use the following ConnectionParameters.
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// Required: <code>CONNECTION_URL</code>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Required: All of (<code>USERNAME</code>, <code>PASSWORD</code>) or <code>SECRET_ID</code>.
        /// </para>
        ///  </li> </ul> </li> <li> 
        /// <para>
        ///  <code>NETWORK</code> - Designates a network connection to a data source within an
        /// Amazon Virtual Private Cloud environment (Amazon VPC).
        /// </para>
        ///  
        /// <para>
        ///  <code>NETWORK</code> Connections do not require ConnectionParameters. Instead, provide
        /// a PhysicalConnectionRequirements.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>MARKETPLACE</code> - Uses configuration settings contained in a connector purchased
        /// from Amazon Web Services Marketplace to read from and write to data stores that are
        /// not natively supported by Glue.
        /// </para>
        ///  
        /// <para>
        ///  <code>MARKETPLACE</code> Connections use the following ConnectionParameters.
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// Required: <code>CONNECTOR_TYPE</code>, <code>CONNECTOR_URL</code>, <code>CONNECTOR_CLASS_NAME</code>,
        /// <code>CONNECTION_URL</code>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Required for <code>JDBC</code> <code>CONNECTOR_TYPE</code> connections: All of (<code>USERNAME</code>,
        /// <code>PASSWORD</code>) or <code>SECRET_ID</code>.
        /// </para>
        ///  </li> </ul> </li> <li> 
        /// <para>
        ///  <code>CUSTOM</code> - Uses configuration settings contained in a custom connector
        /// to read from and write to data stores that are not natively supported by Glue.
        /// </para>
        ///  </li> </ul> 
        /// <para>
        ///  <code>SFTP</code> is not supported.
        /// </para>
        ///  
        /// <para>
        /// For more information about how optional ConnectionProperties are used to configure
        /// features in Glue, consult <a href="https://docs.aws.amazon.com/glue/latest/dg/connection-defining.html">Glue
        /// connection properties</a>.
        /// </para>
        ///  
        /// <para>
        /// For more information about how optional ConnectionProperties are used to configure
        /// features in Glue Studio, consult <a href="https://docs.aws.amazon.com/glue/latest/ug/connectors-chapter.html">Using
        /// connectors and connections</a>.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public ConnectionType ConnectionType
        {
            get { return this._connectionType; }
            set { this._connectionType = value; }
        }

        // Check to see if ConnectionType property is set
        internal bool IsSetConnectionType()
        {
            return this._connectionType != null;
        }

        /// <summary>
        /// Gets and sets the property Description. 
        /// <para>
        /// The description of the connection.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=2048)]
        public string Description
        {
            get { return this._description; }
            set { this._description = value; }
        }

        // Check to see if Description property is set
        internal bool IsSetDescription()
        {
            return this._description != null;
        }

        /// <summary>
        /// Gets and sets the property MatchCriteria. 
        /// <para>
        /// A list of criteria that can be used in selecting this connection.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=10)]
        public List<string> MatchCriteria
        {
            get { return this._matchCriteria; }
            set { this._matchCriteria = value; }
        }

        // Check to see if MatchCriteria property is set
        internal bool IsSetMatchCriteria()
        {
            return this._matchCriteria != null && this._matchCriteria.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property Name. 
        /// <para>
        /// The name of the connection. Connection will not function as expected without a name.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=255)]
        public string Name
        {
            get { return this._name; }
            set { this._name = value; }
        }

        // Check to see if Name property is set
        internal bool IsSetName()
        {
            return this._name != null;
        }

        /// <summary>
        /// Gets and sets the property PhysicalConnectionRequirements. 
        /// <para>
        /// A map of physical connection requirements, such as virtual private cloud (VPC) and
        /// <code>SecurityGroup</code>, that are needed to successfully make this connection.
        /// </para>
        /// </summary>
        public PhysicalConnectionRequirements PhysicalConnectionRequirements
        {
            get { return this._physicalConnectionRequirements; }
            set { this._physicalConnectionRequirements = value; }
        }

        // Check to see if PhysicalConnectionRequirements property is set
        internal bool IsSetPhysicalConnectionRequirements()
        {
            return this._physicalConnectionRequirements != null;
        }

    }
}