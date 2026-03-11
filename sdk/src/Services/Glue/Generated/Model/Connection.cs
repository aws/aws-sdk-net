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

#pragma warning disable CS0612,CS0618,CS1570
namespace Amazon.Glue.Model
{
    /// <summary>
    /// Defines a connection to a data source.
    /// </summary>
    public partial class Connection
    {
        private Dictionary<string, string> _athenaProperties = AWSConfigs.InitializeCollections ? new Dictionary<string, string>() : null;
        private AuthenticationConfiguration _authenticationConfiguration;
        private List<string> _compatibleComputeEnvironments = AWSConfigs.InitializeCollections ? new List<string>() : null;
        private Dictionary<string, string> _connectionProperties = AWSConfigs.InitializeCollections ? new Dictionary<string, string>() : null;
        private int? _connectionSchemaVersion;
        private ConnectionType _connectionType;
        private DateTime? _creationTime;
        private string _description;
        private DateTime? _lastConnectionValidationTime;
        private string _lastUpdatedBy;
        private DateTime? _lastUpdatedTime;
        private List<string> _matchCriteria = AWSConfigs.InitializeCollections ? new List<string>() : null;
        private string _name;
        private PhysicalConnectionRequirements _physicalConnectionRequirements;
        private Dictionary<string, string> _pythonProperties = AWSConfigs.InitializeCollections ? new Dictionary<string, string>() : null;
        private Dictionary<string, string> _sparkProperties = AWSConfigs.InitializeCollections ? new Dictionary<string, string>() : null;
        private ConnectionStatus _status;
        private string _statusReason;

        /// <summary>
        /// Gets and sets the property AthenaProperties. 
        /// <para>
        /// Connection properties specific to the Athena compute environment.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public Dictionary<string, string> AthenaProperties
        {
            get { return this._athenaProperties; }
            set { this._athenaProperties = value; }
        }

        // Check to see if AthenaProperties property is set
        internal bool IsSetAthenaProperties()
        {
            return this._athenaProperties != null && (this._athenaProperties.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property AuthenticationConfiguration. 
        /// <para>
        /// The authentication properties of the connection.
        /// </para>
        /// </summary>
        public AuthenticationConfiguration AuthenticationConfiguration
        {
            get { return this._authenticationConfiguration; }
            set { this._authenticationConfiguration = value; }
        }

        // Check to see if AuthenticationConfiguration property is set
        internal bool IsSetAuthenticationConfiguration()
        {
            return this._authenticationConfiguration != null;
        }

        /// <summary>
        /// Gets and sets the property CompatibleComputeEnvironments. 
        /// <para>
        /// A list of compute environments compatible with the connection.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<string> CompatibleComputeEnvironments
        {
            get { return this._compatibleComputeEnvironments; }
            set { this._compatibleComputeEnvironments = value; }
        }

        // Check to see if CompatibleComputeEnvironments property is set
        internal bool IsSetCompatibleComputeEnvironments()
        {
            return this._compatibleComputeEnvironments != null && (this._compatibleComputeEnvironments.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property ConnectionProperties. 
        /// <para>
        /// These key-value pairs define parameters for the connection when using the version
        /// 1 Connection schema:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <c>HOST</c> - The host URI: either the fully qualified domain name (FQDN) or the
        /// IPv4 address of the database host.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>PORT</c> - The port number, between 1024 and 65535, of the port on which the database
        /// host is listening for database connections.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>USER_NAME</c> - The name under which to log in to the database. The value string
        /// for <c>USER_NAME</c> is "<c>USERNAME</c>".
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>PASSWORD</c> - A password, if one is used, for the user name.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>ENCRYPTED_PASSWORD</c> - When you enable connection password protection by setting
        /// <c>ConnectionPasswordEncryption</c> in the Data Catalog encryption settings, this
        /// field stores the encrypted password.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>JDBC_DRIVER_JAR_URI</c> - The Amazon Simple Storage Service (Amazon S3) path of
        /// the JAR file that contains the JDBC driver to use.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>JDBC_DRIVER_CLASS_NAME</c> - The class name of the JDBC driver to use.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>JDBC_ENGINE</c> - The name of the JDBC engine to use.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>JDBC_ENGINE_VERSION</c> - The version of the JDBC engine to use.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>CONFIG_FILES</c> - (Reserved for future use.)
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>INSTANCE_ID</c> - The instance ID to use.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>JDBC_CONNECTION_URL</c> - The URL for connecting to a JDBC data source.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>JDBC_ENFORCE_SSL</c> - A case-insensitive Boolean string (true, false) specifying
        /// whether Secure Sockets Layer (SSL) with hostname matching is enforced for the JDBC
        /// connection on the client. The default is false.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>CUSTOM_JDBC_CERT</c> - An Amazon S3 location specifying the customer's root certificate.
        /// Glue uses this root certificate to validate the customer’s certificate when connecting
        /// to the customer database. Glue only handles X.509 certificates. The certificate provided
        /// must be DER-encoded and supplied in Base64 encoding PEM format.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>SKIP_CUSTOM_JDBC_CERT_VALIDATION</c> - By default, this is <c>false</c>. Glue
        /// validates the Signature algorithm and Subject Public Key Algorithm for the customer
        /// certificate. The only permitted algorithms for the Signature algorithm are SHA256withRSA,
        /// SHA384withRSA or SHA512withRSA. For the Subject Public Key Algorithm, the key length
        /// must be at least 2048. You can set the value of this property to <c>true</c> to skip
        /// Glue’s validation of the customer certificate.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>CUSTOM_JDBC_CERT_STRING</c> - A custom JDBC certificate string which is used for
        /// domain match or distinguished name match to prevent a man-in-the-middle attack. In
        /// Oracle database, this is used as the <c>SSL_SERVER_CERT_DN</c>; in Microsoft SQL Server,
        /// this is used as the <c>hostNameInCertificate</c>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>CONNECTION_URL</c> - The URL for connecting to a general (non-JDBC) data source.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>SECRET_ID</c> - The secret ID used for the secret manager of credentials.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>CONNECTOR_URL</c> - The connector URL for a MARKETPLACE or CUSTOM connection.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>CONNECTOR_TYPE</c> - The connector type for a MARKETPLACE or CUSTOM connection.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>CONNECTOR_CLASS_NAME</c> - The connector class name for a MARKETPLACE or CUSTOM
        /// connection.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>KAFKA_BOOTSTRAP_SERVERS</c> - A comma-separated list of host and port pairs that
        /// are the addresses of the Apache Kafka brokers in a Kafka cluster to which a Kafka
        /// client will connect to and bootstrap itself.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>KAFKA_SSL_ENABLED</c> - Whether to enable or disable SSL on an Apache Kafka connection.
        /// Default value is "true".
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>KAFKA_CUSTOM_CERT</c> - The Amazon S3 URL for the private CA cert file (.pem format).
        /// The default is an empty string.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>KAFKA_SKIP_CUSTOM_CERT_VALIDATION</c> - Whether to skip the validation of the
        /// CA cert file or not. Glue validates for three algorithms: SHA256withRSA, SHA384withRSA
        /// and SHA512withRSA. Default value is "false".
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>KAFKA_CLIENT_KEYSTORE</c> - The Amazon S3 location of the client keystore file
        /// for Kafka client side authentication (Optional).
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>KAFKA_CLIENT_KEYSTORE_PASSWORD</c> - The password to access the provided keystore
        /// (Optional).
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>KAFKA_CLIENT_KEY_PASSWORD</c> - A keystore can consist of multiple keys, so this
        /// is the password to access the client key to be used with the Kafka server side key
        /// (Optional).
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>ENCRYPTED_KAFKA_CLIENT_KEYSTORE_PASSWORD</c> - The encrypted version of the Kafka
        /// client keystore password (if the user has the Glue encrypt passwords setting selected).
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>ENCRYPTED_KAFKA_CLIENT_KEY_PASSWORD</c> - The encrypted version of the Kafka client
        /// key password (if the user has the Glue encrypt passwords setting selected).
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>KAFKA_SASL_MECHANISM</c> - <c>"SCRAM-SHA-512"</c>, <c>"GSSAPI"</c>, <c>"AWS_MSK_IAM"</c>,
        /// or <c>"PLAIN"</c>. These are the supported <a href="https://www.iana.org/assignments/sasl-mechanisms/sasl-mechanisms.xhtml">SASL
        /// Mechanisms</a>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>KAFKA_SASL_PLAIN_USERNAME</c> - A plaintext username used to authenticate with
        /// the "PLAIN" mechanism.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>KAFKA_SASL_PLAIN_PASSWORD</c> - A plaintext password used to authenticate with
        /// the "PLAIN" mechanism.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>ENCRYPTED_KAFKA_SASL_PLAIN_PASSWORD</c> - The encrypted version of the Kafka SASL
        /// PLAIN password (if the user has the Glue encrypt passwords setting selected).
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>KAFKA_SASL_SCRAM_USERNAME</c> - A plaintext username used to authenticate with
        /// the "SCRAM-SHA-512" mechanism.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>KAFKA_SASL_SCRAM_PASSWORD</c> - A plaintext password used to authenticate with
        /// the "SCRAM-SHA-512" mechanism.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>ENCRYPTED_KAFKA_SASL_SCRAM_PASSWORD</c> - The encrypted version of the Kafka SASL
        /// SCRAM password (if the user has the Glue encrypt passwords setting selected).
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>KAFKA_SASL_SCRAM_SECRETS_ARN</c> - The Amazon Resource Name of a secret in Amazon
        /// Web Services Secrets Manager.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>KAFKA_SASL_GSSAPI_KEYTAB</c> - The S3 location of a Kerberos <c>keytab</c> file.
        /// A keytab stores long-term keys for one or more principals. For more information, see
        /// <a href="https://web.mit.edu/kerberos/krb5-latest/doc/basic/keytab_def.html">MIT Kerberos
        /// Documentation: Keytab</a>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>KAFKA_SASL_GSSAPI_KRB5_CONF</c> - The S3 location of a Kerberos <c>krb5.conf</c>
        /// file. A krb5.conf stores Kerberos configuration information, such as the location
        /// of the KDC server. For more information, see <a href="https://web.mit.edu/kerberos/krb5-1.12/doc/admin/conf_files/krb5_conf.html">MIT
        /// Kerberos Documentation: krb5.conf</a>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>KAFKA_SASL_GSSAPI_SERVICE</c> - The Kerberos service name, as set with <c>sasl.kerberos.service.name</c>
        /// in your <a href="https://kafka.apache.org/documentation/#brokerconfigs_sasl.kerberos.service.name">Kafka
        /// Configuration</a>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>KAFKA_SASL_GSSAPI_PRINCIPAL</c> - The name of the Kerberos princial used by Glue.
        /// For more information, see <a href="https://kafka.apache.org/documentation/#security_sasl_kerberos_clientconfig">Kafka
        /// Documentation: Configuring Kafka Brokers</a>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>ROLE_ARN</c> - The role to be used for running queries.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>REGION</c> - The Amazon Web Services Region where queries will be run.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>WORKGROUP_NAME</c> - The name of an Amazon Redshift serverless workgroup or Amazon
        /// Athena workgroup in which queries will run.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>CLUSTER_IDENTIFIER</c> - The cluster identifier of an Amazon Redshift cluster
        /// in which queries will run.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>DATABASE</c> - The Amazon Redshift database that you are connecting to.
        /// </para>
        ///  </li> </ul>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min=0, Max=100)]
        public Dictionary<string, string> ConnectionProperties
        {
            get { return this._connectionProperties; }
            set { this._connectionProperties = value; }
        }

        // Check to see if ConnectionProperties property is set
        internal bool IsSetConnectionProperties()
        {
            return this._connectionProperties != null && (this._connectionProperties.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property ConnectionSchemaVersion. 
        /// <para>
        /// The version of the connection schema for this connection. Version 2 supports properties
        /// for specific compute environments.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=2)]
        public int? ConnectionSchemaVersion
        {
            get { return this._connectionSchemaVersion; }
            set { this._connectionSchemaVersion = value; }
        }

        // Check to see if ConnectionSchemaVersion property is set
        internal bool IsSetConnectionSchemaVersion()
        {
            return this._connectionSchemaVersion.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property ConnectionType. 
        /// <para>
        /// The type of the connection. Currently, SFTP is not supported.
        /// </para>
        /// </summary>
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
        /// Gets and sets the property CreationTime. 
        /// <para>
        /// The timestamp of the time that this connection definition was created.
        /// </para>
        /// </summary>
        public DateTime? CreationTime
        {
            get { return this._creationTime; }
            set { this._creationTime = value; }
        }

        // Check to see if CreationTime property is set
        internal bool IsSetCreationTime()
        {
            return this._creationTime.HasValue; 
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
        /// Gets and sets the property LastConnectionValidationTime. 
        /// <para>
        /// A timestamp of the time this connection was last validated.
        /// </para>
        /// </summary>
        public DateTime? LastConnectionValidationTime
        {
            get { return this._lastConnectionValidationTime; }
            set { this._lastConnectionValidationTime = value; }
        }

        // Check to see if LastConnectionValidationTime property is set
        internal bool IsSetLastConnectionValidationTime()
        {
            return this._lastConnectionValidationTime.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property LastUpdatedBy. 
        /// <para>
        /// The user, group, or role that last updated this connection definition.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=255)]
        public string LastUpdatedBy
        {
            get { return this._lastUpdatedBy; }
            set { this._lastUpdatedBy = value; }
        }

        // Check to see if LastUpdatedBy property is set
        internal bool IsSetLastUpdatedBy()
        {
            return this._lastUpdatedBy != null;
        }

        /// <summary>
        /// Gets and sets the property LastUpdatedTime. 
        /// <para>
        /// The timestamp of the last time the connection definition was updated.
        /// </para>
        /// </summary>
        public DateTime? LastUpdatedTime
        {
            get { return this._lastUpdatedTime; }
            set { this._lastUpdatedTime = value; }
        }

        // Check to see if LastUpdatedTime property is set
        internal bool IsSetLastUpdatedTime()
        {
            return this._lastUpdatedTime.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property MatchCriteria. 
        /// <para>
        /// A list of criteria that can be used in selecting this connection.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
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
            return this._matchCriteria != null && (this._matchCriteria.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property Name. 
        /// <para>
        /// The name of the connection definition.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=255)]
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
        /// The physical connection requirements, such as virtual private cloud (VPC) and <c>SecurityGroup</c>,
        /// that are needed to make this connection successfully.
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

        /// <summary>
        /// Gets and sets the property PythonProperties. 
        /// <para>
        /// Connection properties specific to the Python compute environment.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public Dictionary<string, string> PythonProperties
        {
            get { return this._pythonProperties; }
            set { this._pythonProperties = value; }
        }

        // Check to see if PythonProperties property is set
        internal bool IsSetPythonProperties()
        {
            return this._pythonProperties != null && (this._pythonProperties.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property SparkProperties. 
        /// <para>
        /// Connection properties specific to the Spark compute environment.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public Dictionary<string, string> SparkProperties
        {
            get { return this._sparkProperties; }
            set { this._sparkProperties = value; }
        }

        // Check to see if SparkProperties property is set
        internal bool IsSetSparkProperties()
        {
            return this._sparkProperties != null && (this._sparkProperties.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property Status. 
        /// <para>
        /// The status of the connection. Can be one of: <c>READY</c>, <c>IN_PROGRESS</c>, or
        /// <c>FAILED</c>.
        /// </para>
        /// </summary>
        public ConnectionStatus Status
        {
            get { return this._status; }
            set { this._status = value; }
        }

        // Check to see if Status property is set
        internal bool IsSetStatus()
        {
            return this._status != null;
        }

        /// <summary>
        /// Gets and sets the property StatusReason. 
        /// <para>
        /// The reason for the connection status.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=16384)]
        public string StatusReason
        {
            get { return this._statusReason; }
            set { this._statusReason = value; }
        }

        // Check to see if StatusReason property is set
        internal bool IsSetStatusReason()
        {
            return this._statusReason != null;
        }

    }
}