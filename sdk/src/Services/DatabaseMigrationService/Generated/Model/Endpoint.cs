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
    /// Describes an endpoint of a database instance in response to operations such as the
    /// following:
    /// 
    ///  <ul> <li> 
    /// <para>
    ///  <code>CreateEndpoint</code> 
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <code>DescribeEndpoint</code> 
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <code>DescribeEndpointTypes</code> 
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <code>ModifyEndpoint</code> 
    /// </para>
    ///  </li> </ul>
    /// </summary>
    public partial class Endpoint
    {
        private string _certificateArn;
        private string _databaseName;
        private DmsTransferSettings _dmsTransferSettings;
        private DocDbSettings _docDbSettings;
        private DynamoDbSettings _dynamoDbSettings;
        private ElasticsearchSettings _elasticsearchSettings;
        private string _endpointArn;
        private string _endpointIdentifier;
        private ReplicationEndpointTypeValue _endpointType;
        private string _engineDisplayName;
        private string _engineName;
        private string _externalId;
        private string _externalTableDefinition;
        private string _extraConnectionAttributes;
        private IBMDb2Settings _ibmDb2Settings;
        private KafkaSettings _kafkaSettings;
        private KinesisSettings _kinesisSettings;
        private string _kmsKeyId;
        private MicrosoftSQLServerSettings _microsoftSQLServerSettings;
        private MongoDbSettings _mongoDbSettings;
        private MySQLSettings _mySQLSettings;
        private NeptuneSettings _neptuneSettings;
        private OracleSettings _oracleSettings;
        private int? _port;
        private PostgreSQLSettings _postgreSQLSettings;
        private RedshiftSettings _redshiftSettings;
        private S3Settings _s3Settings;
        private string _serverName;
        private string _serviceAccessRoleArn;
        private DmsSslModeValue _sslMode;
        private string _status;
        private SybaseSettings _sybaseSettings;
        private string _username;

        /// <summary>
        /// Gets and sets the property CertificateArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) used for SSL connection to the endpoint.
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
        /// The name of the database at the endpoint.
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
        ///  <code>ServiceAccessRoleArn</code> - The IAM role that has permission to access the
        /// Amazon S3 bucket.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>BucketName</code> - The name of the S3 bucket to use.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>CompressionType</code> - An optional parameter to use GZIP to compress the
        /// target files. To use GZIP, set this value to <code>NONE</code> (the default). To keep
        /// the files uncompressed, don't use this value.
        /// </para>
        ///  </li> </ul> 
        /// <para>
        /// Shorthand syntax for these settings is as follows: <code>ServiceAccessRoleArn=string,BucketName=string,CompressionType=string</code>
        /// 
        /// </para>
        ///  
        /// <para>
        /// JSON syntax for these settings is as follows: <code>{ "ServiceAccessRoleArn": "string",
        /// "BucketName": "string", "CompressionType": "none"|"gzip" } </code> 
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
        /// The settings for the DynamoDB target endpoint. For more information, see the <code>DynamoDBSettings</code>
        /// structure.
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
        /// The settings for the Elasticsearch source endpoint. For more information, see the
        /// <code>ElasticsearchSettings</code> structure.
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
        /// Gets and sets the property EndpointArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) string that uniquely identifies the endpoint.
        /// </para>
        /// </summary>
        public string EndpointArn
        {
            get { return this._endpointArn; }
            set { this._endpointArn = value; }
        }

        // Check to see if EndpointArn property is set
        internal bool IsSetEndpointArn()
        {
            return this._endpointArn != null;
        }

        /// <summary>
        /// Gets and sets the property EndpointIdentifier. 
        /// <para>
        /// The database endpoint identifier. Identifiers must begin with a letter and must contain
        /// only ASCII letters, digits, and hyphens. They can't end with a hyphen or contain two
        /// consecutive hyphens.
        /// </para>
        /// </summary>
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
        /// Gets and sets the property EngineDisplayName. 
        /// <para>
        /// The expanded name for the engine name. For example, if the <code>EngineName</code>
        /// parameter is "aurora," this value would be "Amazon Aurora MySQL."
        /// </para>
        /// </summary>
        public string EngineDisplayName
        {
            get { return this._engineDisplayName; }
            set { this._engineDisplayName = value; }
        }

        // Check to see if EngineDisplayName property is set
        internal bool IsSetEngineDisplayName()
        {
            return this._engineDisplayName != null;
        }

        /// <summary>
        /// Gets and sets the property EngineName. 
        /// <para>
        /// The database engine name. Valid values, depending on the EndpointType, include <code>"mysql"</code>,
        /// <code>"oracle"</code>, <code>"postgres"</code>, <code>"mariadb"</code>, <code>"aurora"</code>,
        /// <code>"aurora-postgresql"</code>, <code>"redshift"</code>, <code>"s3"</code>, <code>"db2"</code>,
        /// <code>"azuredb"</code>, <code>"sybase"</code>, <code>"dynamodb"</code>, <code>"mongodb"</code>,
        /// <code>"kinesis"</code>, <code>"kafka"</code>, <code>"elasticsearch"</code>, <code>"documentdb"</code>,
        /// <code>"sqlserver"</code>, and <code>"neptune"</code>.
        /// </para>
        /// </summary>
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
        /// Gets and sets the property ExternalId. 
        /// <para>
        ///  Value returned by a call to CreateEndpoint that can be used for cross-account validation.
        /// Use it on a subsequent call to CreateEndpoint to create the endpoint with a cross-account.
        /// 
        /// </para>
        /// </summary>
        public string ExternalId
        {
            get { return this._externalId; }
            set { this._externalId = value; }
        }

        // Check to see if ExternalId property is set
        internal bool IsSetExternalId()
        {
            return this._externalId != null;
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
        /// Additional connection attributes used to connect to the endpoint.
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
        /// Gets and sets the property IBMDb2Settings. 
        /// <para>
        /// The settings for the IBM Db2 LUW source endpoint. For more information, see the <code>IBMDb2Settings</code>
        /// structure. 
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
        /// The settings for the Apache Kafka target endpoint. For more information, see the <code>KafkaSettings</code>
        /// structure.
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
        /// The settings for the Amazon Kinesis target endpoint. For more information, see the
        /// <code>KinesisSettings</code> structure.
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
        /// An AWS KMS key identifier that is used to encrypt the connection parameters for the
        /// endpoint.
        /// </para>
        ///  
        /// <para>
        /// If you don't specify a value for the <code>KmsKeyId</code> parameter, then AWS DMS
        /// uses your default encryption key.
        /// </para>
        ///  
        /// <para>
        /// AWS KMS creates the default encryption key for your AWS account. Your AWS account
        /// has a different default encryption key for each AWS Region.
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
        /// The settings for the Microsoft SQL Server source and target endpoint. For more information,
        /// see the <code>MicrosoftSQLServerSettings</code> structure.
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
        /// The settings for the MongoDB source endpoint. For more information, see the <code>MongoDbSettings</code>
        /// structure.
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
        /// The settings for the MySQL source and target endpoint. For more information, see the
        /// <code>MySQLSettings</code> structure.
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
        /// The settings for the Amazon Neptune target endpoint. For more information, see the
        /// <code>NeptuneSettings</code> structure.
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
        /// The settings for the Oracle source and target endpoint. For more information, see
        /// the <code>OracleSettings</code> structure.
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
        /// Gets and sets the property Port. 
        /// <para>
        /// The port value used to access the endpoint.
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
        /// The settings for the PostgreSQL source and target endpoint. For more information,
        /// see the <code>PostgreSQLSettings</code> structure.
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
        /// Gets and sets the property RedshiftSettings. 
        /// <para>
        /// Settings for the Amazon Redshift endpoint.
        /// </para>
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
        /// Gets and sets the property S3Settings. 
        /// <para>
        /// The settings for the S3 target endpoint. For more information, see the <code>S3Settings</code>
        /// structure.
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
        /// The name of the server at the endpoint.
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
        /// The Amazon Resource Name (ARN) used by the service access IAM role.
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
        /// The SSL mode used to connect to the endpoint. The default value is <code>none</code>.
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
        /// Gets and sets the property Status. 
        /// <para>
        /// The status of the endpoint.
        /// </para>
        /// </summary>
        public string Status
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
        /// Gets and sets the property SybaseSettings. 
        /// <para>
        /// The settings for the SAP ASE source and target endpoint. For more information, see
        /// the <code>SybaseSettings</code> structure.
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
        /// Gets and sets the property Username. 
        /// <para>
        /// The user name used to connect to the endpoint.
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