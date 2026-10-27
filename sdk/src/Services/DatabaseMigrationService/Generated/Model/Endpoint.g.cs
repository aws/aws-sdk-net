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

namespace Amazon.DatabaseMigrationService.Model
{
    /// <summary>
    /// Describes an endpoint of a database instance in response to operations such as the
    /// following:
    /// 
    ///  <ul> <li> 
    /// <para>
    ///  <c>CreateEndpoint</c> 
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <c>DescribeEndpoint</c> 
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <c>ModifyEndpoint</c> 
    /// </para>
    ///  </li> </ul>
    /// </summary>
    public partial class Endpoint
    {
        /// <summary>
        /// Gets and sets the property CertificateArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) used for SSL connection to the endpoint.
        /// </para>
        /// </summary>
        public string CertificateArn { get; set; }

        /// <summary>
        /// Checks to see if the CertificateArn property is set.
        /// </summary>
        internal bool IsSetCertificateArn() => this.CertificateArn != null;

        /// <summary>
        /// Gets and sets the property DatabaseName. 
        /// <para>
        /// The name of the database at the endpoint.
        /// </para>
        /// </summary>
        public string DatabaseName { get; set; }

        /// <summary>
        /// Checks to see if the DatabaseName property is set.
        /// </summary>
        internal bool IsSetDatabaseName() => this.DatabaseName != null;

        /// <summary>
        /// Gets and sets the property DmsTransferSettings. 
        /// <para>
        /// The settings for the DMS Transfer type source. For more information, see the DmsTransferSettings
        /// structure. 
        /// </para>
        /// </summary>
        public DmsTransferSettings DmsTransferSettings { get; set; }

        /// <summary>
        /// Checks to see if the DmsTransferSettings property is set.
        /// </summary>
        internal bool IsSetDmsTransferSettings() => this.DmsTransferSettings != null;

        /// <summary>
        /// Gets and sets the property DocDbSettings.
        /// </summary>
        public DocDbSettings DocDbSettings { get; set; }

        /// <summary>
        /// Checks to see if the DocDbSettings property is set.
        /// </summary>
        internal bool IsSetDocDbSettings() => this.DocDbSettings != null;

        /// <summary>
        /// Gets and sets the property DynamoDbSettings. 
        /// <para>
        /// The settings for the DynamoDB target endpoint. For more information, see the <c>DynamoDBSettings</c>
        /// structure.
        /// </para>
        /// </summary>
        public DynamoDbSettings DynamoDbSettings { get; set; }

        /// <summary>
        /// Checks to see if the DynamoDbSettings property is set.
        /// </summary>
        internal bool IsSetDynamoDbSettings() => this.DynamoDbSettings != null;

        /// <summary>
        /// Gets and sets the property ElasticsearchSettings. 
        /// <para>
        /// The settings for the OpenSearch source endpoint. For more information, see the <c>ElasticsearchSettings</c>
        /// structure.
        /// </para>
        /// </summary>
        public ElasticsearchSettings ElasticsearchSettings { get; set; }

        /// <summary>
        /// Checks to see if the ElasticsearchSettings property is set.
        /// </summary>
        internal bool IsSetElasticsearchSettings() => this.ElasticsearchSettings != null;

        /// <summary>
        /// Gets and sets the property EndpointArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) string that uniquely identifies the endpoint.
        /// </para>
        /// </summary>
        public string EndpointArn { get; set; }

        /// <summary>
        /// Checks to see if the EndpointArn property is set.
        /// </summary>
        internal bool IsSetEndpointArn() => this.EndpointArn != null;

        /// <summary>
        /// Gets and sets the property EndpointIdentifier. 
        /// <para>
        /// The database endpoint identifier. Identifiers must begin with a letter and must contain
        /// only ASCII letters, digits, and hyphens. They can't end with a hyphen or contain two
        /// consecutive hyphens.
        /// </para>
        /// </summary>
        public string EndpointIdentifier { get; set; }

        /// <summary>
        /// Checks to see if the EndpointIdentifier property is set.
        /// </summary>
        internal bool IsSetEndpointIdentifier() => this.EndpointIdentifier != null;

        /// <summary>
        /// Gets and sets the property EndpointType. 
        /// <para>
        /// The type of endpoint. Valid values are <c>source</c> and <c>target</c>.
        /// </para>
        /// </summary>
        public ReplicationEndpointTypeValue EndpointType { get; set; }

        /// <summary>
        /// Checks to see if the EndpointType property is set.
        /// </summary>
        internal bool IsSetEndpointType() => this.EndpointType != null;

        /// <summary>
        /// Gets and sets the property EngineDisplayName. 
        /// <para>
        /// The expanded name for the engine name. For example, if the <c>EngineName</c> parameter
        /// is "aurora", this value would be "Amazon Aurora MySQL".
        /// </para>
        /// </summary>
        public string EngineDisplayName { get; set; }

        /// <summary>
        /// Checks to see if the EngineDisplayName property is set.
        /// </summary>
        internal bool IsSetEngineDisplayName() => this.EngineDisplayName != null;

        /// <summary>
        /// Gets and sets the property EngineName. 
        /// <para>
        /// The database engine name. Valid values, depending on the EndpointType, include <c>"mysql"</c>,
        /// <c>"oracle"</c>, <c>"postgres"</c>, <c>"mariadb"</c>, <c>"aurora"</c>, <c>"aurora-postgresql"</c>,
        /// <c>"redshift"</c>, <c>"redshift-serverless"</c>, <c>"s3"</c>, <c>"db2"</c>, <c>"db2-zos"</c>,
        /// <c>"azuredb"</c>, <c>"sybase"</c>, <c>"dynamodb"</c>, <c>"mongodb"</c>, <c>"kinesis"</c>,
        /// <c>"kafka"</c>, <c>"elasticsearch"</c>, <c>"documentdb"</c>, <c>"sqlserver"</c>, <c>"neptune"</c>,
        /// and <c>"babelfish"</c>.
        /// </para>
        /// </summary>
        public string EngineName { get; set; }

        /// <summary>
        /// Checks to see if the EngineName property is set.
        /// </summary>
        internal bool IsSetEngineName() => this.EngineName != null;

        /// <summary>
        /// Gets and sets the property ExternalId. 
        /// <para>
        ///  Value returned by a call to CreateEndpoint that can be used for cross-account validation.
        /// Use it on a subsequent call to CreateEndpoint to create the endpoint with a cross-account.
        /// 
        /// </para>
        /// </summary>
        public string ExternalId { get; set; }

        /// <summary>
        /// Checks to see if the ExternalId property is set.
        /// </summary>
        internal bool IsSetExternalId() => this.ExternalId != null;

        /// <summary>
        /// Gets and sets the property ExternalTableDefinition. 
        /// <para>
        /// The external table definition.
        /// </para>
        /// </summary>
        public string ExternalTableDefinition { get; set; }

        /// <summary>
        /// Checks to see if the ExternalTableDefinition property is set.
        /// </summary>
        internal bool IsSetExternalTableDefinition() => this.ExternalTableDefinition != null;

        /// <summary>
        /// Gets and sets the property ExtraConnectionAttributes. 
        /// <para>
        /// Additional connection attributes used to connect to the endpoint.
        /// </para>
        /// </summary>
        public string ExtraConnectionAttributes { get; set; }

        /// <summary>
        /// Checks to see if the ExtraConnectionAttributes property is set.
        /// </summary>
        internal bool IsSetExtraConnectionAttributes() => this.ExtraConnectionAttributes != null;

        /// <summary>
        /// Gets and sets the property GcpMySQLSettings. 
        /// <para>
        /// Settings in JSON format for the source GCP MySQL endpoint.
        /// </para>
        /// </summary>
        public GcpMySQLSettings GcpMySQLSettings { get; set; }

        /// <summary>
        /// Checks to see if the GcpMySQLSettings property is set.
        /// </summary>
        internal bool IsSetGcpMySQLSettings() => this.GcpMySQLSettings != null;

        /// <summary>
        /// Gets and sets the property IBMDb2Settings. 
        /// <para>
        /// The settings for the IBM Db2 LUW source endpoint. For more information, see the <c>IBMDb2Settings</c>
        /// structure. 
        /// </para>
        /// </summary>
        public IBMDb2Settings IBMDb2Settings { get; set; }

        /// <summary>
        /// Checks to see if the IBMDb2Settings property is set.
        /// </summary>
        internal bool IsSetIBMDb2Settings() => this.IBMDb2Settings != null;

        /// <summary>
        /// Gets and sets the property IsReadOnly. 
        /// <para>
        /// Indicates whether the endpoint is read-only. When set to <c>true</c>, this endpoint
        /// is managed by DMS as part of a zero-ETL integration and cannot be modified or deleted
        /// directly. You can only modify or delete read-only endpoints through their associated
        /// zero-ETL integration.
        /// </para>
        /// </summary>
        public bool? IsReadOnly { get; set; }

        /// <summary>
        /// Checks to see if the IsReadOnly property is set.
        /// </summary>
        internal bool IsSetIsReadOnly() => this.IsReadOnly.HasValue;

        /// <summary>
        /// Gets and sets the property KafkaSettings. 
        /// <para>
        /// The settings for the Apache Kafka target endpoint. For more information, see the <c>KafkaSettings</c>
        /// structure.
        /// </para>
        /// </summary>
        public KafkaSettings KafkaSettings { get; set; }

        /// <summary>
        /// Checks to see if the KafkaSettings property is set.
        /// </summary>
        internal bool IsSetKafkaSettings() => this.KafkaSettings != null;

        /// <summary>
        /// Gets and sets the property KinesisSettings. 
        /// <para>
        /// The settings for the Amazon Kinesis target endpoint. For more information, see the
        /// <c>KinesisSettings</c> structure.
        /// </para>
        /// </summary>
        public KinesisSettings KinesisSettings { get; set; }

        /// <summary>
        /// Checks to see if the KinesisSettings property is set.
        /// </summary>
        internal bool IsSetKinesisSettings() => this.KinesisSettings != null;

        /// <summary>
        /// Gets and sets the property KmsKeyId. 
        /// <para>
        /// An KMS key identifier that is used to encrypt the connection parameters for the endpoint.
        /// </para>
        ///  
        /// <para>
        /// If you don't specify a value for the <c>KmsKeyId</c> parameter, then DMS uses your
        /// default encryption key.
        /// </para>
        ///  
        /// <para>
        /// KMS creates the default encryption key for your Amazon Web Services account. Your
        /// Amazon Web Services account has a different default encryption key for each Amazon
        /// Web Services Region.
        /// </para>
        /// </summary>
        public string KmsKeyId { get; set; }

        /// <summary>
        /// Checks to see if the KmsKeyId property is set.
        /// </summary>
        internal bool IsSetKmsKeyId() => this.KmsKeyId != null;

        /// <summary>
        /// Gets and sets the property LakehouseSettings. 
        /// <para>
        /// Settings in JSON format for the target Lakehouse endpoint. This parameter applies
        /// to endpoints that are automatically created by DMS for a Lakehouse data warehouse
        /// as part of a zero-ETL integration.
        /// </para>
        /// </summary>
        public LakehouseSettings LakehouseSettings { get; set; }

        /// <summary>
        /// Checks to see if the LakehouseSettings property is set.
        /// </summary>
        internal bool IsSetLakehouseSettings() => this.LakehouseSettings != null;

        /// <summary>
        /// Gets and sets the property MicrosoftSQLServerSettings. 
        /// <para>
        /// The settings for the Microsoft SQL Server source and target endpoint. For more information,
        /// see the <c>MicrosoftSQLServerSettings</c> structure.
        /// </para>
        /// </summary>
        public MicrosoftSQLServerSettings MicrosoftSQLServerSettings { get; set; }

        /// <summary>
        /// Checks to see if the MicrosoftSQLServerSettings property is set.
        /// </summary>
        internal bool IsSetMicrosoftSQLServerSettings() => this.MicrosoftSQLServerSettings != null;

        /// <summary>
        /// Gets and sets the property MongoDbSettings. 
        /// <para>
        /// The settings for the MongoDB source endpoint. For more information, see the <c>MongoDbSettings</c>
        /// structure.
        /// </para>
        /// </summary>
        public MongoDbSettings MongoDbSettings { get; set; }

        /// <summary>
        /// Checks to see if the MongoDbSettings property is set.
        /// </summary>
        internal bool IsSetMongoDbSettings() => this.MongoDbSettings != null;

        /// <summary>
        /// Gets and sets the property MySQLSettings. 
        /// <para>
        /// The settings for the MySQL source and target endpoint. For more information, see the
        /// <c>MySQLSettings</c> structure.
        /// </para>
        /// </summary>
        public MySQLSettings MySQLSettings { get; set; }

        /// <summary>
        /// Checks to see if the MySQLSettings property is set.
        /// </summary>
        internal bool IsSetMySQLSettings() => this.MySQLSettings != null;

        /// <summary>
        /// Gets and sets the property NeptuneSettings. 
        /// <para>
        /// The settings for the Amazon Neptune target endpoint. For more information, see the
        /// <c>NeptuneSettings</c> structure.
        /// </para>
        /// </summary>
        public NeptuneSettings NeptuneSettings { get; set; }

        /// <summary>
        /// Checks to see if the NeptuneSettings property is set.
        /// </summary>
        internal bool IsSetNeptuneSettings() => this.NeptuneSettings != null;

        /// <summary>
        /// Gets and sets the property OracleSettings. 
        /// <para>
        /// The settings for the Oracle source and target endpoint. For more information, see
        /// the <c>OracleSettings</c> structure.
        /// </para>
        /// </summary>
        public OracleSettings OracleSettings { get; set; }

        /// <summary>
        /// Checks to see if the OracleSettings property is set.
        /// </summary>
        internal bool IsSetOracleSettings() => this.OracleSettings != null;

        /// <summary>
        /// Gets and sets the property Port. 
        /// <para>
        /// The port value used to access the endpoint.
        /// </para>
        /// </summary>
        public int? Port { get; set; }

        /// <summary>
        /// Checks to see if the Port property is set.
        /// </summary>
        internal bool IsSetPort() => this.Port.HasValue;

        /// <summary>
        /// Gets and sets the property PostgreSQLSettings. 
        /// <para>
        /// The settings for the PostgreSQL source and target endpoint. For more information,
        /// see the <c>PostgreSQLSettings</c> structure.
        /// </para>
        /// </summary>
        public PostgreSQLSettings PostgreSQLSettings { get; set; }

        /// <summary>
        /// Checks to see if the PostgreSQLSettings property is set.
        /// </summary>
        internal bool IsSetPostgreSQLSettings() => this.PostgreSQLSettings != null;

        /// <summary>
        /// Gets and sets the property RedisSettings. 
        /// <para>
        /// The settings for the Redis target endpoint. For more information, see the <c>RedisSettings</c>
        /// structure.
        /// </para>
        /// </summary>
        public RedisSettings RedisSettings { get; set; }

        /// <summary>
        /// Checks to see if the RedisSettings property is set.
        /// </summary>
        internal bool IsSetRedisSettings() => this.RedisSettings != null;

        /// <summary>
        /// Gets and sets the property RedshiftSettings. 
        /// <para>
        /// Settings for the Amazon Redshift endpoint.
        /// </para>
        /// </summary>
        public RedshiftSettings RedshiftSettings { get; set; }

        /// <summary>
        /// Checks to see if the RedshiftSettings property is set.
        /// </summary>
        internal bool IsSetRedshiftSettings() => this.RedshiftSettings != null;

        /// <summary>
        /// Gets and sets the property S3Settings. 
        /// <para>
        /// The settings for the S3 target endpoint. For more information, see the <c>S3Settings</c>
        /// structure.
        /// </para>
        /// </summary>
        public S3Settings S3Settings { get; set; }

        /// <summary>
        /// Checks to see if the S3Settings property is set.
        /// </summary>
        internal bool IsSetS3Settings() => this.S3Settings != null;

        /// <summary>
        /// Gets and sets the property ServerName. 
        /// <para>
        /// The name of the server at the endpoint.
        /// </para>
        /// </summary>
        public string ServerName { get; set; }

        /// <summary>
        /// Checks to see if the ServerName property is set.
        /// </summary>
        internal bool IsSetServerName() => this.ServerName != null;

        /// <summary>
        /// Gets and sets the property ServiceAccessRoleArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) used by the service to access the IAM role. The role
        /// must allow the <c>iam:PassRole</c> action.
        /// </para>
        /// </summary>
        public string ServiceAccessRoleArn { get; set; }

        /// <summary>
        /// Checks to see if the ServiceAccessRoleArn property is set.
        /// </summary>
        internal bool IsSetServiceAccessRoleArn() => this.ServiceAccessRoleArn != null;

        /// <summary>
        /// Gets and sets the property SslMode. 
        /// <para>
        /// The SSL mode used to connect to the endpoint. The default value is <c>none</c>.
        /// </para>
        /// </summary>
        public DmsSslModeValue SslMode { get; set; }

        /// <summary>
        /// Checks to see if the SslMode property is set.
        /// </summary>
        internal bool IsSetSslMode() => this.SslMode != null;

        /// <summary>
        /// Gets and sets the property Status. 
        /// <para>
        /// The status of the endpoint.
        /// </para>
        /// </summary>
        public string Status { get; set; }

        /// <summary>
        /// Checks to see if the Status property is set.
        /// </summary>
        internal bool IsSetStatus() => this.Status != null;

        /// <summary>
        /// Gets and sets the property SybaseSettings. 
        /// <para>
        /// The settings for the SAP ASE source and target endpoint. For more information, see
        /// the <c>SybaseSettings</c> structure.
        /// </para>
        /// </summary>
        public SybaseSettings SybaseSettings { get; set; }

        /// <summary>
        /// Checks to see if the SybaseSettings property is set.
        /// </summary>
        internal bool IsSetSybaseSettings() => this.SybaseSettings != null;

        /// <summary>
        /// Gets and sets the property TimestreamSettings. 
        /// <para>
        /// The settings for the Amazon Timestream target endpoint. For more information, see
        /// the <c>TimestreamSettings</c> structure.
        /// </para>
        /// </summary>
        public TimestreamSettings TimestreamSettings { get; set; }

        /// <summary>
        /// Checks to see if the TimestreamSettings property is set.
        /// </summary>
        internal bool IsSetTimestreamSettings() => this.TimestreamSettings != null;

        /// <summary>
        /// Gets and sets the property Username. 
        /// <para>
        /// The user name used to connect to the endpoint.
        /// </para>
        /// </summary>
        public string Username { get; set; }

        /// <summary>
        /// Checks to see if the Username property is set.
        /// </summary>
        internal bool IsSetUsername() => this.Username != null;
    }
}
