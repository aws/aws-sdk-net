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
    /// Defines a connection to a data source.
    /// </summary>
    public partial class Connection
    {
        private Dictionary<string, string> _connectionProperties = new Dictionary<string, string>();
        private ConnectionType _connectionType;
        private DateTime? _creationTime;
        private string _description;
        private string _lastUpdatedBy;
        private DateTime? _lastUpdatedTime;
        private List<string> _matchCriteria = new List<string>();
        private string _name;
        private PhysicalConnectionRequirements _physicalConnectionRequirements;

        /// <summary>
        /// Gets and sets the property ConnectionProperties. 
        /// <para>
        /// These key-value pairs define parameters for the connection:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <code>HOST</code> - The host URI: either the fully qualified domain name (FQDN) or
        /// the IPv4 address of the database host.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>PORT</code> - The port number, between 1024 and 65535, of the port on which
        /// the database host is listening for database connections.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>USER_NAME</code> - The name under which to log in to the database. The value
        /// string for <code>USER_NAME</code> is "<code>USERNAME</code>".
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>PASSWORD</code> - A password, if one is used, for the user name.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>ENCRYPTED_PASSWORD</code> - When you enable connection password protection
        /// by setting <code>ConnectionPasswordEncryption</code> in the Data Catalog encryption
        /// settings, this field stores the encrypted password.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>JDBC_DRIVER_JAR_URI</code> - The Amazon Simple Storage Service (Amazon S3)
        /// path of the JAR file that contains the JDBC driver to use.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>JDBC_DRIVER_CLASS_NAME</code> - The class name of the JDBC driver to use.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>JDBC_ENGINE</code> - The name of the JDBC engine to use.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>JDBC_ENGINE_VERSION</code> - The version of the JDBC engine to use.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>CONFIG_FILES</code> - (Reserved for future use.)
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>INSTANCE_ID</code> - The instance ID to use.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>JDBC_CONNECTION_URL</code> - The URL for connecting to a JDBC data source.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>JDBC_ENFORCE_SSL</code> - A Boolean string (true, false) specifying whether
        /// Secure Sockets Layer (SSL) with hostname matching is enforced for the JDBC connection
        /// on the client. The default is false.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>CUSTOM_JDBC_CERT</code> - An Amazon S3 location specifying the customer's root
        /// certificate. Glue uses this root certificate to validate the customer’s certificate
        /// when connecting to the customer database. Glue only handles X.509 certificates. The
        /// certificate provided must be DER-encoded and supplied in Base64 encoding PEM format.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>SKIP_CUSTOM_JDBC_CERT_VALIDATION</code> - By default, this is <code>false</code>.
        /// Glue validates the Signature algorithm and Subject Public Key Algorithm for the customer
        /// certificate. The only permitted algorithms for the Signature algorithm are SHA256withRSA,
        /// SHA384withRSA or SHA512withRSA. For the Subject Public Key Algorithm, the key length
        /// must be at least 2048. You can set the value of this property to <code>true</code>
        /// to skip Glue’s validation of the customer certificate.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>CUSTOM_JDBC_CERT_STRING</code> - A custom JDBC certificate string which is
        /// used for domain match or distinguished name match to prevent a man-in-the-middle attack.
        /// In Oracle database, this is used as the <code>SSL_SERVER_CERT_DN</code>; in Microsoft
        /// SQL Server, this is used as the <code>hostNameInCertificate</code>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>CONNECTION_URL</code> - The URL for connecting to a general (non-JDBC) data
        /// source.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>SECRET_ID</code> - The secret ID used for the secret manager of credentials.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>CONNECTOR_URL</code> - The connector URL for a MARKETPLACE or CUSTOM connection.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>CONNECTOR_TYPE</code> - The connector type for a MARKETPLACE or CUSTOM connection.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>CONNECTOR_CLASS_NAME</code> - The connector class name for a MARKETPLACE or
        /// CUSTOM connection.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>KAFKA_BOOTSTRAP_SERVERS</code> - A comma-separated list of host and port pairs
        /// that are the addresses of the Apache Kafka brokers in a Kafka cluster to which a Kafka
        /// client will connect to and bootstrap itself.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>KAFKA_SSL_ENABLED</code> - Whether to enable or disable SSL on an Apache Kafka
        /// connection. Default value is "true".
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>KAFKA_CUSTOM_CERT</code> - The Amazon S3 URL for the private CA cert file (.pem
        /// format). The default is an empty string.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>KAFKA_SKIP_CUSTOM_CERT_VALIDATION</code> - Whether to skip the validation of
        /// the CA cert file or not. Glue validates for three algorithms: SHA256withRSA, SHA384withRSA
        /// and SHA512withRSA. Default value is "false".
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>KAFKA_CLIENT_KEYSTORE</code> - The Amazon S3 location of the client keystore
        /// file for Kafka client side authentication (Optional).
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>KAFKA_CLIENT_KEYSTORE_PASSWORD</code> - The password to access the provided
        /// keystore (Optional).
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>KAFKA_CLIENT_KEY_PASSWORD</code> - A keystore can consist of multiple keys,
        /// so this is the password to access the client key to be used with the Kafka server
        /// side key (Optional).
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>ENCRYPTED_KAFKA_CLIENT_KEYSTORE_PASSWORD</code> - The encrypted version of
        /// the Kafka client keystore password (if the user has the Glue encrypt passwords setting
        /// selected).
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>ENCRYPTED_KAFKA_CLIENT_KEY_PASSWORD</code> - The encrypted version of the Kafka
        /// client key password (if the user has the Glue encrypt passwords setting selected).
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>KAFKA_SASL_MECHANISM</code> - <code>"SCRAM-SHA-512"</code>, <code>"GSSAPI"</code>,
        /// or <code>"AWS_MSK_IAM"</code>. These are the supported <a href="https://www.iana.org/assignments/sasl-mechanisms/sasl-mechanisms.xhtml">SASL
        /// Mechanisms</a>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>KAFKA_SASL_SCRAM_USERNAME</code> - A plaintext username used to authenticate
        /// with the "SCRAM-SHA-512" mechanism.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>KAFKA_SASL_SCRAM_PASSWORD</code> - A plaintext password used to authenticate
        /// with the "SCRAM-SHA-512" mechanism.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>ENCRYPTED_KAFKA_SASL_SCRAM_PASSWORD</code> - The encrypted version of the Kafka
        /// SASL SCRAM password (if the user has the Glue encrypt passwords setting selected).
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>KAFKA_SASL_GSSAPI_KEYTAB</code> - The S3 location of a Kerberos <code>keytab</code>
        /// file. A keytab stores long-term keys for one or more principals. For more information,
        /// see <a href="https://web.mit.edu/kerberos/krb5-latest/doc/basic/keytab_def.html">MIT
        /// Kerberos Documentation: Keytab</a>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>KAFKA_SASL_GSSAPI_KRB5_CONF</code> - The S3 location of a Kerberos <code>krb5.conf</code>
        /// file. A krb5.conf stores Kerberos configuration information, such as the location
        /// of the KDC server. For more information, see <a href="https://web.mit.edu/kerberos/krb5-1.12/doc/admin/conf_files/krb5_conf.html">MIT
        /// Kerberos Documentation: krb5.conf</a>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>KAFKA_SASL_GSSAPI_SERVICE</code> - The Kerberos service name, as set with <code>sasl.kerberos.service.name</code>
        /// in your <a href="https://kafka.apache.org/documentation/#brokerconfigs_sasl.kerberos.service.name">Kafka
        /// Configuration</a>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>KAFKA_SASL_GSSAPI_PRINCIPAL</code> - The name of the Kerberos princial used
        /// by Glue. For more information, see <a href="https://kafka.apache.org/documentation/#security_sasl_kerberos_clientconfig">Kafka
        /// Documentation: Configuring Kafka Brokers</a>.
        /// </para>
        ///  </li> </ul>
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
            return this._connectionProperties != null && this._connectionProperties.Count > 0; 
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
        /// The time that this connection definition was created.
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
        /// The last time that this connection definition was updated.
        /// </para>
        /// </summary>
        public DateTime LastUpdatedTime
        {
            get { return this._lastUpdatedTime.GetValueOrDefault(); }
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
        /// A map of physical connection requirements, such as virtual private cloud (VPC) and
        /// <code>SecurityGroup</code>, that are needed to make this connection successfully.
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