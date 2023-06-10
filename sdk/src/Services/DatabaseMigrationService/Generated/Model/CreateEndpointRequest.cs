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
 * Do not modify this file. This file is generated from the dms-2016-01-01.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.DatabaseMigrationService.Model
{
    /// <summary>
    /// Container for the parameters to the CreateEndpoint operation.
    /// Creates an endpoint using the provided settings.
    /// 
    ///  <note> 
    /// <para>
    /// For a MySQL source or target endpoint, don't explicitly specify the database using
    /// the <code>DatabaseName</code> request parameter on the <code>CreateEndpoint</code>
    /// API call. Specifying <code>DatabaseName</code> when you create a MySQL endpoint replicates
    /// all the task tables to this single database. For MySQL endpoints, you specify the
    /// database only when you specify the schema in the table-mapping rules of the DMS task.
    /// </para>
    ///  </note>
    /// </summary>
    public partial class CreateEndpointRequest : AmazonDatabaseMigrationServiceRequest
    {
        private string _certificateArn;
        private string _databaseName;
        private DmsTransferSettings _dmsTransferSettings;
        private DocDbSettings _docDbSettings;
        private DynamoDbSettings _dynamoDbSettings;
        private ElasticsearchSettings _elasticsearchSettings;
        private string _endpointIdentifier;
        private ReplicationEndpointTypeValue _endpointType;
        private string _engineName;
        private string _externalTableDefinition;
        private string _extraConnectionAttributes;
        private GcpMySQLSettings _gcpMySQLSettings;
        private IBMDb2Settings _ibmDb2Settings;
        private KafkaSettings _kafkaSettings;
        private KinesisSettings _kinesisSettings;
        private string _kmsKeyId;
        private MicrosoftSQLServerSettings _microsoftSQLServerSettings;
        private MongoDbSettings _mongoDbSettings;
        private MySQLSettings _mySQLSettings;
        private NeptuneSettings _neptuneSettings;
        private OracleSettings _oracleSettings;
        private string _password;
        private int? _port;
        private PostgreSQLSettings _postgreSQLSettings;
        private RedisSettings _redisSettings;
        private RedshiftSettings _redshiftSettings;
        private string _resourceIdentifier;
        private S3Settings _s3Settings;
        private string _serverName;
        private string _serviceAccessRoleArn;
        private DmsSslModeValue _sslMode;
        private SybaseSettings _sybaseSettings;
        private List<Tag> _tags = new List<Tag>();
        private string _username;

        /// <summary>
        /// Gets and sets the property CertificateArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) for the certificate.
        /// </para>
        /// </summary>
        public string CertificateArn
        {
            get { return this._certificateArn; }
            set { this._certificateArn = value; }
        }

        // Check to see if CertificateArn property is set
        internal bool IsSetCertificateArn()
        {
            return this._certificateArn != null;
        }

        /// <summary>
        /// Gets and sets the property DatabaseName. 
        /// <para>
        /// The name of the endpoint database. For a MySQL source or target endpoint, do not specify
        /// DatabaseName. To migrate to a specific database, use this setting and <code>targetDbType</code>.
        /// </para>
        /// </summary>
        public string DatabaseName
        {
            get { return this._databaseName; }
            set { this._databaseName = value; }
        }

        // Check to see if DatabaseName property is set
        internal bool IsSetDatabaseName()
        {
            return this._databaseName != null;
        }

        /// <summary>
        /// Gets and sets the property DmsTransferSettings. 
        /// <para>
        /// The settings in JSON format for the DMS transfer type of source endpoint. 
        /// </para>
        ///  
        /// <para>
        /// Possible settings include the following:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <code>ServiceAccessRoleArn</code> - The Amazon Resource Name (ARN) used by the service
        /// access IAM role. The role must allow the <code>iam:PassRole</code> action.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>BucketName</code> - The name of the S3 bucket to use.
        /// </para>
        ///  </li> </ul> 
        /// <para>
        /// Shorthand syntax for these settings is as follows: <code>ServiceAccessRoleArn=string,BucketName=string</code>
        /// 
        /// </para>
        ///  
        /// <para>
        /// JSON syntax for these settings is as follows: <code>{ "ServiceAccessRoleArn": "string",
        /// "BucketName": "string", } </code> 
        /// </para>
        /// </summary>
        public DmsTransferSettings DmsTransferSettings
        {
            get { return this._dmsTransferSettings; }
            set { this._dmsTransferSettings = value; }
        }

        // Check to see if DmsTransferSettings property is set
        internal bool IsSetDmsTransferSettings()
        {
            return this._dmsTransferSettings != null;
        }

        /// <summary>
        /// Gets and sets the property DocDbSettings.
        /// </summary>
        public DocDbSettings DocDbSettings
        {
            get { return this._docDbSettings; }
            set { this._docDbSettings = value; }
        }

        // Check to see if DocDbSettings property is set
        internal bool IsSetDocDbSettings()
        {
            return this._docDbSettings != null;
        }

        /// <summary>
        /// Gets and sets the property DynamoDbSettings. 
        /// <para>
        /// Settings in JSON format for the target Amazon DynamoDB endpoint. For information about
        /// other available settings, see <a href="https://docs.aws.amazon.com/dms/latest/userguide/CHAP_Target.DynamoDB.html#CHAP_Target.DynamoDB.ObjectMapping">Using
        /// Object Mapping to Migrate Data to DynamoDB</a> in the <i>Database Migration Service
        /// User Guide.</i> 
        /// </para>
        /// </summary>
        public DynamoDbSettings DynamoDbSettings
        {
            get { return this._dynamoDbSettings; }
            set { this._dynamoDbSettings = value; }
        }

        // Check to see if DynamoDbSettings property is set
        internal bool IsSetDynamoDbSettings()
        {
            return this._dynamoDbSettings != null;
        }

        /// <summary>
        /// Gets and sets the property ElasticsearchSettings. 
        /// <para>
        /// Settings in JSON format for the target OpenSearch endpoint. For more information about
        /// the available settings, see <a href="https://docs.aws.amazon.com/dms/latest/userguide/CHAP_Target.Elasticsearch.html#CHAP_Target.Elasticsearch.Configuration">Extra
        /// Connection Attributes When Using OpenSearch as a Target for DMS</a> in the <i>Database
        /// Migration Service User Guide</i>.
        /// </para>
        /// </summary>
        public ElasticsearchSettings ElasticsearchSettings
        {
            get { return this._elasticsearchSettings; }
            set { this._elasticsearchSettings = value; }
        }

        // Check to see if ElasticsearchSettings property is set
        internal bool IsSetElasticsearchSettings()
        {
            return this._elasticsearchSettings != null;
        }

        /// <summary>
        /// Gets and sets the property EndpointIdentifier. 
        /// <para>
        /// The database endpoint identifier. Identifiers must begin with a letter and must contain
        /// only ASCII letters, digits, and hyphens. They can't end with a hyphen, or contain
        /// two consecutive hyphens.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string EndpointIdentifier
        {
            get { return this._endpointIdentifier; }
            set { this._endpointIdentifier = value; }
        }

        // Check to see if EndpointIdentifier property is set
        internal bool IsSetEndpointIdentifier()
        {
            return this._endpointIdentifier != null;
        }

        /// <summary>
        /// Gets and sets the property EndpointType. 
        /// <para>
        /// The type of endpoint. Valid values are <code>source</code> and <code>target</code>.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public ReplicationEndpointTypeValue EndpointType
        {
            get { return this._endpointType; }
            set { this._endpointType = value; }
        }

        // Check to see if EndpointType property is set
        internal bool IsSetEndpointType()
        {
            return this._endpointType != null;
        }

        /// <summary>
        /// Gets and sets the property EngineName. 
        /// <para>
        /// The type of engine for the endpoint. Valid values, depending on the <code>EndpointType</code>
        /// value, include <code>"mysql"</code>, <code>"oracle"</code>, <code>"postgres"</code>,
        /// <code>"mariadb"</code>, <code>"aurora"</code>, <code>"aurora-postgresql"</code>, <code>"opensearch"</code>,
        /// <code>"redshift"</code>, <code>"s3"</code>, <code>"db2"</code>, <code>"db2-zos"</code>,
        /// <code>"azuredb"</code>, <code>"sybase"</code>, <code>"dynamodb"</code>, <code>"mongodb"</code>,
        /// <code>"kinesis"</code>, <code>"kafka"</code>, <code>"elasticsearch"</code>, <code>"docdb"</code>,
        /// <code>"sqlserver"</code>, <code>"neptune"</code>, and <code>"babelfish"</code>.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string EngineName
        {
            get { return this._engineName; }
            set { this._engineName = value; }
        }

        // Check to see if EngineName property is set
        internal bool IsSetEngineName()
        {
            return this._engineName != null;
        }

        /// <summary>
        /// Gets and sets the property ExternalTableDefinition. 
        /// <para>
        /// The external table definition. 
        /// </para>
        /// </summary>
        public string ExternalTableDefinition
        {
            get { return this._externalTableDefinition; }
            set { this._externalTableDefinition = value; }
        }

        // Check to see if ExternalTableDefinition property is set
        internal bool IsSetExternalTableDefinition()
        {
            return this._externalTableDefinition != null;
        }

        /// <summary>
        /// Gets and sets the property ExtraConnectionAttributes. 
        /// <para>
        /// Additional attributes associated with the connection. Each attribute is specified
        /// as a name-value pair associated by an equal sign (=). Multiple attributes are separated
        /// by a semicolon (;) with no additional white space. For information on the attributes
        /// available for connecting your source or target endpoint, see <a href="https://docs.aws.amazon.com/dms/latest/userguide/CHAP_Endpoints.html">Working
        /// with DMS Endpoints</a> in the <i>Database Migration Service User Guide.</i> 
        /// </para>
        /// </summary>
        public string ExtraConnectionAttributes
        {
            get { return this._extraConnectionAttributes; }
            set { this._extraConnectionAttributes = value; }
        }

        // Check to see if ExtraConnectionAttributes property is set
        internal bool IsSetExtraConnectionAttributes()
        {
            return this._extraConnectionAttributes != null;
        }

        /// <summary>
        /// Gets and sets the property GcpMySQLSettings. 
        /// <para>
        /// Settings in JSON format for the source GCP MySQL endpoint.
        /// </para>
        /// </summary>
        public GcpMySQLSettings GcpMySQLSettings
        {
            get { return this._gcpMySQLSettings; }
            set { this._gcpMySQLSettings = value; }
        }

        // Check to see if GcpMySQLSettings property is set
        internal bool IsSetGcpMySQLSettings()
        {
            return this._gcpMySQLSettings != null;
        }

        /// <summary>
        /// Gets and sets the property IBMDb2Settings. 
        /// <para>
        /// Settings in JSON format for the source IBM Db2 LUW endpoint. For information about
        /// other available settings, see <a href="https://docs.aws.amazon.com/dms/latest/userguide/CHAP_Source.DB2.html#CHAP_Source.DB2.ConnectionAttrib">Extra
        /// connection attributes when using Db2 LUW as a source for DMS</a> in the <i>Database
        /// Migration Service User Guide.</i> 
        /// </para>
        /// </summary>
        public IBMDb2Settings IBMDb2Settings
        {
            get { return this._ibmDb2Settings; }
            set { this._ibmDb2Settings = value; }
        }

        // Check to see if IBMDb2Settings property is set
        internal bool IsSetIBMDb2Settings()
        {
            return this._ibmDb2Settings != null;
        }

        /// <summary>
        /// Gets and sets the property KafkaSettings. 
        /// <para>
        /// Settings in JSON format for the target Apache Kafka endpoint. For more information
        /// about the available settings, see <a href="https://docs.aws.amazon.com/dms/latest/userguide/CHAP_Target.Kafka.html#CHAP_Target.Kafka.ObjectMapping">Using
        /// object mapping to migrate data to a Kafka topic</a> in the <i>Database Migration Service
        /// User Guide.</i> 
        /// </para>
        /// </summary>
        public KafkaSettings KafkaSettings
        {
            get { return this._kafkaSettings; }
            set { this._kafkaSettings = value; }
        }

        // Check to see if KafkaSettings property is set
        internal bool IsSetKafkaSettings()
        {
            return this._kafkaSettings != null;
        }

        /// <summary>
        /// Gets and sets the property KinesisSettings. 
        /// <para>
        /// Settings in JSON format for the target endpoint for Amazon Kinesis Data Streams. For
        /// more information about the available settings, see <a href="https://docs.aws.amazon.com/dms/latest/userguide/CHAP_Target.Kinesis.html#CHAP_Target.Kinesis.ObjectMapping">Using
        /// object mapping to migrate data to a Kinesis data stream</a> in the <i>Database Migration
        /// Service User Guide.</i> 
        /// </para>
        /// </summary>
        public KinesisSettings KinesisSettings
        {
            get { return this._kinesisSettings; }
            set { this._kinesisSettings = value; }
        }

        // Check to see if KinesisSettings property is set
        internal bool IsSetKinesisSettings()
        {
            return this._kinesisSettings != null;
        }

        /// <summary>
        /// Gets and sets the property KmsKeyId. 
        /// <para>
        /// An KMS key identifier that is used to encrypt the connection parameters for the endpoint.
        /// </para>
        ///  
        /// <para>
        /// If you don't specify a value for the <code>KmsKeyId</code> parameter, then DMS uses
        /// your default encryption key.
        /// </para>
        ///  
        /// <para>
        /// KMS creates the default encryption key for your Amazon Web Services account. Your
        /// Amazon Web Services account has a different default encryption key for each Amazon
        /// Web Services Region.
        /// </para>
        /// </summary>
        public string KmsKeyId
        {
            get { return this._kmsKeyId; }
            set { this._kmsKeyId = value; }
        }

        // Check to see if KmsKeyId property is set
        internal bool IsSetKmsKeyId()
        {
            return this._kmsKeyId != null;
        }

        /// <summary>
        /// Gets and sets the property MicrosoftSQLServerSettings. 
        /// <para>
        /// Settings in JSON format for the source and target Microsoft SQL Server endpoint. For
        /// information about other available settings, see <a href="https://docs.aws.amazon.com/dms/latest/userguide/CHAP_Source.SQLServer.html#CHAP_Source.SQLServer.ConnectionAttrib">Extra
        /// connection attributes when using SQL Server as a source for DMS</a> and <a href="https://docs.aws.amazon.com/dms/latest/userguide/CHAP_Target.SQLServer.html#CHAP_Target.SQLServer.ConnectionAttrib">
        /// Extra connection attributes when using SQL Server as a target for DMS</a> in the <i>Database
        /// Migration Service User Guide.</i> 
        /// </para>
        /// </summary>
        public MicrosoftSQLServerSettings MicrosoftSQLServerSettings
        {
            get { return this._microsoftSQLServerSettings; }
            set { this._microsoftSQLServerSettings = value; }
        }

        // Check to see if MicrosoftSQLServerSettings property is set
        internal bool IsSetMicrosoftSQLServerSettings()
        {
            return this._microsoftSQLServerSettings != null;
        }

        /// <summary>
        /// Gets and sets the property MongoDbSettings. 
        /// <para>
        /// Settings in JSON format for the source MongoDB endpoint. For more information about
        /// the available settings, see <a href="https://docs.aws.amazon.com/dms/latest/userguide/CHAP_Source.MongoDB.html#CHAP_Source.MongoDB.Configuration">Endpoint
        /// configuration settings when using MongoDB as a source for Database Migration Service</a>
        /// in the <i>Database Migration Service User Guide.</i> 
        /// </para>
        /// </summary>
        public MongoDbSettings MongoDbSettings
        {
            get { return this._mongoDbSettings; }
            set { this._mongoDbSettings = value; }
        }

        // Check to see if MongoDbSettings property is set
        internal bool IsSetMongoDbSettings()
        {
            return this._mongoDbSettings != null;
        }

        /// <summary>
        /// Gets and sets the property MySQLSettings. 
        /// <para>
        /// Settings in JSON format for the source and target MySQL endpoint. For information
        /// about other available settings, see <a href="https://docs.aws.amazon.com/dms/latest/userguide/CHAP_Source.MySQL.html#CHAP_Source.MySQL.ConnectionAttrib">Extra
        /// connection attributes when using MySQL as a source for DMS</a> and <a href="https://docs.aws.amazon.com/dms/latest/userguide/CHAP_Target.MySQL.html#CHAP_Target.MySQL.ConnectionAttrib">Extra
        /// connection attributes when using a MySQL-compatible database as a target for DMS</a>
        /// in the <i>Database Migration Service User Guide.</i> 
        /// </para>
        /// </summary>
        public MySQLSettings MySQLSettings
        {
            get { return this._mySQLSettings; }
            set { this._mySQLSettings = value; }
        }

        // Check to see if MySQLSettings property is set
        internal bool IsSetMySQLSettings()
        {
            return this._mySQLSettings != null;
        }

        /// <summary>
        /// Gets and sets the property NeptuneSettings. 
        /// <para>
        /// Settings in JSON format for the target Amazon Neptune endpoint. For more information
        /// about the available settings, see <a href="https://docs.aws.amazon.com/dms/latest/userguide/CHAP_Target.Neptune.html#CHAP_Target.Neptune.EndpointSettings">Specifying
        /// graph-mapping rules using Gremlin and R2RML for Amazon Neptune as a target</a> in
        /// the <i>Database Migration Service User Guide.</i> 
        /// </para>
        /// </summary>
        public NeptuneSettings NeptuneSettings
        {
            get { return this._neptuneSettings; }
            set { this._neptuneSettings = value; }
        }

        // Check to see if NeptuneSettings property is set
        internal bool IsSetNeptuneSettings()
        {
            return this._neptuneSettings != null;
        }

        /// <summary>
        /// Gets and sets the property OracleSettings. 
        /// <para>
        /// Settings in JSON format for the source and target Oracle endpoint. For information
        /// about other available settings, see <a href="https://docs.aws.amazon.com/dms/latest/userguide/CHAP_Source.Oracle.html#CHAP_Source.Oracle.ConnectionAttrib">Extra
        /// connection attributes when using Oracle as a source for DMS</a> and <a href="https://docs.aws.amazon.com/dms/latest/userguide/CHAP_Target.Oracle.html#CHAP_Target.Oracle.ConnectionAttrib">
        /// Extra connection attributes when using Oracle as a target for DMS</a> in the <i>Database
        /// Migration Service User Guide.</i> 
        /// </para>
        /// </summary>
        public OracleSettings OracleSettings
        {
            get { return this._oracleSettings; }
            set { this._oracleSettings = value; }
        }

        // Check to see if OracleSettings property is set
        internal bool IsSetOracleSettings()
        {
            return this._oracleSettings != null;
        }

        /// <summary>
        /// Gets and sets the property Password. 
        /// <para>
        /// The password to be used to log in to the endpoint database.
        /// </para>
        /// </summary>
        [AWSProperty(Sensitive=true)]
        public string Password
        {
            get { return this._password; }
            set { this._password = value; }
        }

        // Check to see if Password property is set
        internal bool IsSetPassword()
        {
            return this._password != null;
        }

        /// <summary>
        /// Gets and sets the property Port. 
        /// <para>
        /// The port used by the endpoint database.
        /// </para>
        /// </summary>
        public int Port
        {
            get { return this._port.GetValueOrDefault(); }
            set { this._port = value; }
        }

        // Check to see if Port property is set
        internal bool IsSetPort()
        {
            return this._port.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property PostgreSQLSettings. 
        /// <para>
        /// Settings in JSON format for the source and target PostgreSQL endpoint. For information
        /// about other available settings, see <a href="https://docs.aws.amazon.com/dms/latest/userguide/CHAP_Source.PostgreSQL.html#CHAP_Source.PostgreSQL.ConnectionAttrib">Extra
        /// connection attributes when using PostgreSQL as a source for DMS</a> and <a href="https://docs.aws.amazon.com/dms/latest/userguide/CHAP_Target.PostgreSQL.html#CHAP_Target.PostgreSQL.ConnectionAttrib">
        /// Extra connection attributes when using PostgreSQL as a target for DMS</a> in the <i>Database
        /// Migration Service User Guide.</i> 
        /// </para>
        /// </summary>
        public PostgreSQLSettings PostgreSQLSettings
        {
            get { return this._postgreSQLSettings; }
            set { this._postgreSQLSettings = value; }
        }

        // Check to see if PostgreSQLSettings property is set
        internal bool IsSetPostgreSQLSettings()
        {
            return this._postgreSQLSettings != null;
        }

        /// <summary>
        /// Gets and sets the property RedisSettings. 
        /// <para>
        /// Settings in JSON format for the target Redis endpoint.
        /// </para>
        /// </summary>
        public RedisSettings RedisSettings
        {
            get { return this._redisSettings; }
            set { this._redisSettings = value; }
        }

        // Check to see if RedisSettings property is set
        internal bool IsSetRedisSettings()
        {
            return this._redisSettings != null;
        }

        /// <summary>
        /// Gets and sets the property RedshiftSettings.
        /// </summary>
        public RedshiftSettings RedshiftSettings
        {
            get { return this._redshiftSettings; }
            set { this._redshiftSettings = value; }
        }

        // Check to see if RedshiftSettings property is set
        internal bool IsSetRedshiftSettings()
        {
            return this._redshiftSettings != null;
        }

        /// <summary>
        /// Gets and sets the property ResourceIdentifier. 
        /// <para>
        /// A friendly name for the resource identifier at the end of the <code>EndpointArn</code>
        /// response parameter that is returned in the created <code>Endpoint</code> object. The
        /// value for this parameter can have up to 31 characters. It can contain only ASCII letters,
        /// digits, and hyphen ('-'). Also, it can't end with a hyphen or contain two consecutive
        /// hyphens, and can only begin with a letter, such as <code>Example-App-ARN1</code>.
        /// For example, this value might result in the <code>EndpointArn</code> value <code>arn:aws:dms:eu-west-1:012345678901:rep:Example-App-ARN1</code>.
        /// If you don't specify a <code>ResourceIdentifier</code> value, DMS generates a default
        /// identifier value for the end of <code>EndpointArn</code>.
        /// </para>
        /// </summary>
        public string ResourceIdentifier
        {
            get { return this._resourceIdentifier; }
            set { this._resourceIdentifier = value; }
        }

        // Check to see if ResourceIdentifier property is set
        internal bool IsSetResourceIdentifier()
        {
            return this._resourceIdentifier != null;
        }

        /// <summary>
        /// Gets and sets the property S3Settings. 
        /// <para>
        /// Settings in JSON format for the target Amazon S3 endpoint. For more information about
        /// the available settings, see <a href="https://docs.aws.amazon.com/dms/latest/userguide/CHAP_Target.S3.html#CHAP_Target.S3.Configuring">Extra
        /// Connection Attributes When Using Amazon S3 as a Target for DMS</a> in the <i>Database
        /// Migration Service User Guide.</i> 
        /// </para>
        /// </summary>
        public S3Settings S3Settings
        {
            get { return this._s3Settings; }
            set { this._s3Settings = value; }
        }

        // Check to see if S3Settings property is set
        internal bool IsSetS3Settings()
        {
            return this._s3Settings != null;
        }

        /// <summary>
        /// Gets and sets the property ServerName. 
        /// <para>
        /// The name of the server where the endpoint database resides.
        /// </para>
        /// </summary>
        public string ServerName
        {
            get { return this._serverName; }
            set { this._serverName = value; }
        }

        // Check to see if ServerName property is set
        internal bool IsSetServerName()
        {
            return this._serverName != null;
        }

        /// <summary>
        /// Gets and sets the property ServiceAccessRoleArn. 
        /// <para>
        ///  The Amazon Resource Name (ARN) for the service access role that you want to use to
        /// create the endpoint. The role must allow the <code>iam:PassRole</code> action.
        /// </para>
        /// </summary>
        public string ServiceAccessRoleArn
        {
            get { return this._serviceAccessRoleArn; }
            set { this._serviceAccessRoleArn = value; }
        }

        // Check to see if ServiceAccessRoleArn property is set
        internal bool IsSetServiceAccessRoleArn()
        {
            return this._serviceAccessRoleArn != null;
        }

        /// <summary>
        /// Gets and sets the property SslMode. 
        /// <para>
        /// The Secure Sockets Layer (SSL) mode to use for the SSL connection. The default is
        /// <code>none</code> 
        /// </para>
        /// </summary>
        public DmsSslModeValue SslMode
        {
            get { return this._sslMode; }
            set { this._sslMode = value; }
        }

        // Check to see if SslMode property is set
        internal bool IsSetSslMode()
        {
            return this._sslMode != null;
        }

        /// <summary>
        /// Gets and sets the property SybaseSettings. 
        /// <para>
        /// Settings in JSON format for the source and target SAP ASE endpoint. For information
        /// about other available settings, see <a href="https://docs.aws.amazon.com/dms/latest/userguide/CHAP_Source.SAP.html#CHAP_Source.SAP.ConnectionAttrib">Extra
        /// connection attributes when using SAP ASE as a source for DMS</a> and <a href="https://docs.aws.amazon.com/dms/latest/userguide/CHAP_Target.SAP.html#CHAP_Target.SAP.ConnectionAttrib">Extra
        /// connection attributes when using SAP ASE as a target for DMS</a> in the <i>Database
        /// Migration Service User Guide.</i> 
        /// </para>
        /// </summary>
        public SybaseSettings SybaseSettings
        {
            get { return this._sybaseSettings; }
            set { this._sybaseSettings = value; }
        }

        // Check to see if SybaseSettings property is set
        internal bool IsSetSybaseSettings()
        {
            return this._sybaseSettings != null;
        }

        /// <summary>
        /// Gets and sets the property Tags. 
        /// <para>
        /// One or more tags to be assigned to the endpoint.
        /// </para>
        /// </summary>
        public List<Tag> Tags
        {
            get { return this._tags; }
            set { this._tags = value; }
        }

        // Check to see if Tags property is set
        internal bool IsSetTags()
        {
            return this._tags != null && this._tags.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property Username. 
        /// <para>
        /// The user name to be used to log in to the endpoint database.
        /// </para>
        /// </summary>
        public string Username
        {
            get { return this._username; }
            set { this._username = value; }
        }

        // Check to see if Username property is set
        internal bool IsSetUsername()
        {
            return this._username != null;
        }

    }
}