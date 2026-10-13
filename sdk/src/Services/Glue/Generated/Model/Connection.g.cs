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

namespace Amazon.Glue.Model
{
    /// <summary>
    /// Defines a connection to a data source.
    /// </summary>
    public partial class Connection
    {
        /// <summary>
        /// Gets and sets the property AthenaProperties. 
        /// <para>
        /// Connection properties specific to the Athena compute environment.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public Dictionary<string, string> AthenaProperties { get; set; } = AWSConfigs.InitializeCollections ? new Dictionary<string, string>() : null;

        /// <summary>
        /// Checks to see if the AthenaProperties property is set.
        /// </summary>
        internal bool IsSetAthenaProperties() => this.AthenaProperties != null && (this.AthenaProperties.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property AuthenticationConfiguration. 
        /// <para>
        /// The authentication properties of the connection.
        /// </para>
        /// </summary>
        public AuthenticationConfiguration AuthenticationConfiguration { get; set; }

        /// <summary>
        /// Checks to see if the AuthenticationConfiguration property is set.
        /// </summary>
        internal bool IsSetAuthenticationConfiguration() => this.AuthenticationConfiguration != null;

        /// <summary>
        /// Gets and sets the property CompatibleComputeEnvironments. 
        /// <para>
        /// A list of compute environments compatible with the connection.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<string> CompatibleComputeEnvironments { get; set; } = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Checks to see if the CompatibleComputeEnvironments property is set.
        /// </summary>
        internal bool IsSetCompatibleComputeEnvironments() => this.CompatibleComputeEnvironments != null && (this.CompatibleComputeEnvironments.Count > 0 || !AWSConfigs.InitializeCollections);

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
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min = 0, Max = 100)]
        public Dictionary<string, string> ConnectionProperties { get; set; } = AWSConfigs.InitializeCollections ? new Dictionary<string, string>() : null;

        /// <summary>
        /// Checks to see if the ConnectionProperties property is set.
        /// </summary>
        internal bool IsSetConnectionProperties() => this.ConnectionProperties != null && (this.ConnectionProperties.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property ConnectionSchemaVersion. 
        /// <para>
        /// The version of the connection schema for this connection. Version 2 supports properties
        /// for specific compute environments.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 2)]
        public int? ConnectionSchemaVersion { get; set; }

        /// <summary>
        /// Checks to see if the ConnectionSchemaVersion property is set.
        /// </summary>
        internal bool IsSetConnectionSchemaVersion() => this.ConnectionSchemaVersion.HasValue;

        /// <summary>
        /// Gets and sets the property ConnectionType. 
        /// <para>
        /// The type of the connection. Currently, SFTP is not supported.
        /// </para>
        /// </summary>
        public ConnectionType ConnectionType { get; set; }

        /// <summary>
        /// Checks to see if the ConnectionType property is set.
        /// </summary>
        internal bool IsSetConnectionType() => this.ConnectionType != null;

        /// <summary>
        /// Gets and sets the property CreationTime. 
        /// <para>
        /// The timestamp of the time that this connection definition was created.
        /// </para>
        /// </summary>
        public DateTime? CreationTime { get; set; }

        /// <summary>
        /// Checks to see if the CreationTime property is set.
        /// </summary>
        internal bool IsSetCreationTime() => this.CreationTime.HasValue;

        /// <summary>
        /// Gets and sets the property Description. 
        /// <para>
        /// The description of the connection.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 2048)]
        public string Description { get; set; }

        /// <summary>
        /// Checks to see if the Description property is set.
        /// </summary>
        internal bool IsSetDescription() => this.Description != null;

        /// <summary>
        /// Gets and sets the property LastConnectionValidationTime. 
        /// <para>
        /// A timestamp of the time this connection was last validated.
        /// </para>
        /// </summary>
        public DateTime? LastConnectionValidationTime { get; set; }

        /// <summary>
        /// Checks to see if the LastConnectionValidationTime property is set.
        /// </summary>
        internal bool IsSetLastConnectionValidationTime() => this.LastConnectionValidationTime.HasValue;

        /// <summary>
        /// Gets and sets the property LastUpdatedBy. 
        /// <para>
        /// The user, group, or role that last updated this connection definition.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 255)]
        public string LastUpdatedBy { get; set; }

        /// <summary>
        /// Checks to see if the LastUpdatedBy property is set.
        /// </summary>
        internal bool IsSetLastUpdatedBy() => this.LastUpdatedBy != null;

        /// <summary>
        /// Gets and sets the property LastUpdatedTime. 
        /// <para>
        /// The timestamp of the last time the connection definition was updated.
        /// </para>
        /// </summary>
        public DateTime? LastUpdatedTime { get; set; }

        /// <summary>
        /// Checks to see if the LastUpdatedTime property is set.
        /// </summary>
        internal bool IsSetLastUpdatedTime() => this.LastUpdatedTime.HasValue;

        /// <summary>
        /// Gets and sets the property MatchCriteria. 
        /// <para>
        /// A list of criteria that can be used in selecting this connection.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min = 0, Max = 10)]
        public List<string> MatchCriteria { get; set; } = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Checks to see if the MatchCriteria property is set.
        /// </summary>
        internal bool IsSetMatchCriteria() => this.MatchCriteria != null && (this.MatchCriteria.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property Name. 
        /// <para>
        /// The name of the connection definition.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 255)]
        public string Name { get; set; }

        /// <summary>
        /// Checks to see if the Name property is set.
        /// </summary>
        internal bool IsSetName() => this.Name != null;

        /// <summary>
        /// Gets and sets the property PhysicalConnectionRequirements. 
        /// <para>
        /// The physical connection requirements, such as virtual private cloud (VPC) and <c>SecurityGroup</c>,
        /// that are needed to make this connection successfully.
        /// </para>
        /// </summary>
        public PhysicalConnectionRequirements PhysicalConnectionRequirements { get; set; }

        /// <summary>
        /// Checks to see if the PhysicalConnectionRequirements property is set.
        /// </summary>
        internal bool IsSetPhysicalConnectionRequirements() => this.PhysicalConnectionRequirements != null;

        /// <summary>
        /// Gets and sets the property PythonProperties. 
        /// <para>
        /// Connection properties specific to the Python compute environment.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public Dictionary<string, string> PythonProperties { get; set; } = AWSConfigs.InitializeCollections ? new Dictionary<string, string>() : null;

        /// <summary>
        /// Checks to see if the PythonProperties property is set.
        /// </summary>
        internal bool IsSetPythonProperties() => this.PythonProperties != null && (this.PythonProperties.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property SparkProperties. 
        /// <para>
        /// Connection properties specific to the Spark compute environment.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public Dictionary<string, string> SparkProperties { get; set; } = AWSConfigs.InitializeCollections ? new Dictionary<string, string>() : null;

        /// <summary>
        /// Checks to see if the SparkProperties property is set.
        /// </summary>
        internal bool IsSetSparkProperties() => this.SparkProperties != null && (this.SparkProperties.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property Status. 
        /// <para>
        /// The status of the connection. Can be one of: <c>READY</c>, <c>IN_PROGRESS</c>, or
        /// <c>FAILED</c>.
        /// </para>
        /// </summary>
        public ConnectionStatus Status { get; set; }

        /// <summary>
        /// Checks to see if the Status property is set.
        /// </summary>
        internal bool IsSetStatus() => this.Status != null;

        /// <summary>
        /// Gets and sets the property StatusReason. 
        /// <para>
        /// The reason for the connection status.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 16384)]
        public string StatusReason { get; set; }

        /// <summary>
        /// Checks to see if the StatusReason property is set.
        /// </summary>
        internal bool IsSetStatusReason() => this.StatusReason != null;
    }
}
