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
    /// Container for the parameters to the CreateEndpoint operation. Creates an endpoint
    /// using the provided settings. <note> <para> For a MySQL source or target endpoint,
    /// don't explicitly specify the database using the <c>DatabaseName</c> request parameter
    /// on the <c>CreateEndpoint</c> API call. Specifying <c>DatabaseName</c> when you create
    /// a MySQL endpoint replicates all the task tables to this single database. For MySQL
    /// endpoints, you specify the database only when you specify the schema in the table-mapping
    /// rules of the DMS task. </para> </note>
    /// </summary>
    public partial class CreateEndpointRequest : AmazonDatabaseMigrationServiceRequest
    {
        /// <summary>
        /// Gets and sets the property CertificateArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) for the certificate.
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
        /// The name of the endpoint database. For a MySQL source or target endpoint, do not specify
        /// DatabaseName. To migrate to a specific database, use this setting and <c>targetDbType</c>.
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
        /// The settings in JSON format for the DMS transfer type of source endpoint. 
        /// </para>
        ///  
        /// <para>
        /// Possible settings include the following:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <c>ServiceAccessRoleArn</c> - The Amazon Resource Name (ARN) used by the service
        /// access IAM role. The role must allow the <c>iam:PassRole</c> action.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>BucketName</c> - The name of the S3 bucket to use.
        /// </para>
        ///  </li> </ul> 
        /// <para>
        /// Shorthand syntax for these settings is as follows: <c>ServiceAccessRoleArn=string,BucketName=string</c>
        /// 
        /// </para>
        ///  
        /// <para>
        /// JSON syntax for these settings is as follows: <c>{ "ServiceAccessRoleArn": "string",
        /// "BucketName": "string", } </c> 
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
        /// Settings in JSON format for the target Amazon DynamoDB endpoint. For information about
        /// other available settings, see <a href="https://docs.aws.amazon.com/dms/latest/userguide/CHAP_Target.DynamoDB.html#CHAP_Target.DynamoDB.ObjectMapping">Using
        /// Object Mapping to Migrate Data to DynamoDB</a> in the <i>Database Migration Service
        /// User Guide.</i> 
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
        /// Settings in JSON format for the target OpenSearch endpoint. For more information about
        /// the available settings, see <a href="https://docs.aws.amazon.com/dms/latest/userguide/CHAP_Target.Elasticsearch.html#CHAP_Target.Elasticsearch.Configuration">Extra
        /// Connection Attributes When Using OpenSearch as a Target for DMS</a> in the <i>Database
        /// Migration Service User Guide</i>.
        /// </para>
        /// </summary>
        public ElasticsearchSettings ElasticsearchSettings { get; set; }

        /// <summary>
        /// Checks to see if the ElasticsearchSettings property is set.
        /// </summary>
        internal bool IsSetElasticsearchSettings() => this.ElasticsearchSettings != null;

        /// <summary>
        /// Gets and sets the property EndpointIdentifier. 
        /// <para>
        /// The database endpoint identifier. Identifiers must begin with a letter and must contain
        /// only ASCII letters, digits, and hyphens. They can't end with a hyphen, or contain
        /// two consecutive hyphens.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
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
        [AWSProperty(Required = true)]
        public ReplicationEndpointTypeValue EndpointType { get; set; }

        /// <summary>
        /// Checks to see if the EndpointType property is set.
        /// </summary>
        internal bool IsSetEndpointType() => this.EndpointType != null;

        /// <summary>
        /// Gets and sets the property EngineName. 
        /// <para>
        /// The type of engine for the endpoint. Valid values, depending on the <c>EndpointType</c>
        /// value, include <c>"mysql"</c>, <c>"oracle"</c>, <c>"postgres"</c>, <c>"mariadb"</c>,
        /// <c>"aurora"</c>, <c>"aurora-postgresql"</c>, <c>"opensearch"</c>, <c>"redshift"</c>,
        /// <c>"s3"</c>, <c>"db2"</c>, <c>"db2-zos"</c>, <c>"azuredb"</c>, <c>"sybase"</c>, <c>"dynamodb"</c>,
        /// <c>"mongodb"</c>, <c>"kinesis"</c>, <c>"kafka"</c>, <c>"elasticsearch"</c>, <c>"docdb"</c>,
        /// <c>"sqlserver"</c>, <c>"neptune"</c>, <c>"babelfish"</c>, <c>redshift-serverless</c>,
        /// <c>aurora-serverless</c>, <c>aurora-postgresql-serverless</c>, <c>gcp-mysql</c>, <c>azure-sql-managed-instance</c>,
        /// <c>redis</c>, <c>dms-transfer</c>.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public string EngineName { get; set; }

        /// <summary>
        /// Checks to see if the EngineName property is set.
        /// </summary>
        internal bool IsSetEngineName() => this.EngineName != null;

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
        /// Additional attributes associated with the connection. Each attribute is specified
        /// as a name-value pair associated by an equal sign (=). Multiple attributes are separated
        /// by a semicolon (;) with no additional white space. For information on the attributes
        /// available for connecting your source or target endpoint, see <a href="https://docs.aws.amazon.com/dms/latest/userguide/CHAP_Endpoints.html">Working
        /// with DMS Endpoints</a> in the <i>Database Migration Service User Guide.</i> 
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
        /// Settings in JSON format for the source IBM Db2 LUW endpoint. For information about
        /// other available settings, see <a href="https://docs.aws.amazon.com/dms/latest/userguide/CHAP_Source.DB2.html#CHAP_Source.DB2.ConnectionAttrib">Extra
        /// connection attributes when using Db2 LUW as a source for DMS</a> in the <i>Database
        /// Migration Service User Guide.</i> 
        /// </para>
        /// </summary>
        public IBMDb2Settings IBMDb2Settings { get; set; }

        /// <summary>
        /// Checks to see if the IBMDb2Settings property is set.
        /// </summary>
        internal bool IsSetIBMDb2Settings() => this.IBMDb2Settings != null;

        /// <summary>
        /// Gets and sets the property KafkaSettings. 
        /// <para>
        /// Settings in JSON format for the target Apache Kafka endpoint. For more information
        /// about the available settings, see <a href="https://docs.aws.amazon.com/dms/latest/userguide/CHAP_Target.Kafka.html#CHAP_Target.Kafka.ObjectMapping">Using
        /// object mapping to migrate data to a Kafka topic</a> in the <i>Database Migration Service
        /// User Guide.</i> 
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
        /// Settings in JSON format for the target endpoint for Amazon Kinesis Data Streams. For
        /// more information about the available settings, see <a href="https://docs.aws.amazon.com/dms/latest/userguide/CHAP_Target.Kinesis.html#CHAP_Target.Kinesis.ObjectMapping">Using
        /// object mapping to migrate data to a Kinesis data stream</a> in the <i>Database Migration
        /// Service User Guide.</i> 
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
        /// Gets and sets the property MicrosoftSQLServerSettings. 
        /// <para>
        /// Settings in JSON format for the source and target Microsoft SQL Server endpoint. For
        /// information about other available settings, see <a href="https://docs.aws.amazon.com/dms/latest/userguide/CHAP_Source.SQLServer.html#CHAP_Source.SQLServer.ConnectionAttrib">Extra
        /// connection attributes when using SQL Server as a source for DMS</a> and <a href="https://docs.aws.amazon.com/dms/latest/userguide/CHAP_Target.SQLServer.html#CHAP_Target.SQLServer.ConnectionAttrib">
        /// Extra connection attributes when using SQL Server as a target for DMS</a> in the <i>Database
        /// Migration Service User Guide.</i> 
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
        /// Settings in JSON format for the source MongoDB endpoint. For more information about
        /// the available settings, see <a href="https://docs.aws.amazon.com/dms/latest/userguide/CHAP_Source.MongoDB.html#CHAP_Source.MongoDB.Configuration">Endpoint
        /// configuration settings when using MongoDB as a source for Database Migration Service</a>
        /// in the <i>Database Migration Service User Guide.</i> 
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
        /// Settings in JSON format for the source and target MySQL endpoint. For information
        /// about other available settings, see <a href="https://docs.aws.amazon.com/dms/latest/userguide/CHAP_Source.MySQL.html#CHAP_Source.MySQL.ConnectionAttrib">Extra
        /// connection attributes when using MySQL as a source for DMS</a> and <a href="https://docs.aws.amazon.com/dms/latest/userguide/CHAP_Target.MySQL.html#CHAP_Target.MySQL.ConnectionAttrib">Extra
        /// connection attributes when using a MySQL-compatible database as a target for DMS</a>
        /// in the <i>Database Migration Service User Guide.</i> 
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
        /// Settings in JSON format for the target Amazon Neptune endpoint. For more information
        /// about the available settings, see <a href="https://docs.aws.amazon.com/dms/latest/userguide/CHAP_Target.Neptune.html#CHAP_Target.Neptune.EndpointSettings">Specifying
        /// graph-mapping rules using Gremlin and R2RML for Amazon Neptune as a target</a> in
        /// the <i>Database Migration Service User Guide.</i> 
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
        /// Settings in JSON format for the source and target Oracle endpoint. For information
        /// about other available settings, see <a href="https://docs.aws.amazon.com/dms/latest/userguide/CHAP_Source.Oracle.html#CHAP_Source.Oracle.ConnectionAttrib">Extra
        /// connection attributes when using Oracle as a source for DMS</a> and <a href="https://docs.aws.amazon.com/dms/latest/userguide/CHAP_Target.Oracle.html#CHAP_Target.Oracle.ConnectionAttrib">
        /// Extra connection attributes when using Oracle as a target for DMS</a> in the <i>Database
        /// Migration Service User Guide.</i> 
        /// </para>
        /// </summary>
        public OracleSettings OracleSettings { get; set; }

        /// <summary>
        /// Checks to see if the OracleSettings property is set.
        /// </summary>
        internal bool IsSetOracleSettings() => this.OracleSettings != null;

        /// <summary>
        /// Gets and sets the property Password. 
        /// <para>
        /// The password to be used to log in to the endpoint database.
        /// </para>
        /// </summary>
        [AWSProperty(Sensitive = true)]
        public string Password { get; set; }

        /// <summary>
        /// Checks to see if the Password property is set.
        /// </summary>
        internal bool IsSetPassword() => this.Password != null;

        /// <summary>
        /// Gets and sets the property Port. 
        /// <para>
        /// The port used by the endpoint database.
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
        /// Settings in JSON format for the source and target PostgreSQL endpoint. For information
        /// about other available settings, see <a href="https://docs.aws.amazon.com/dms/latest/userguide/CHAP_Source.PostgreSQL.html#CHAP_Source.PostgreSQL.ConnectionAttrib">Extra
        /// connection attributes when using PostgreSQL as a source for DMS</a> and <a href="https://docs.aws.amazon.com/dms/latest/userguide/CHAP_Target.PostgreSQL.html#CHAP_Target.PostgreSQL.ConnectionAttrib">
        /// Extra connection attributes when using PostgreSQL as a target for DMS</a> in the <i>Database
        /// Migration Service User Guide.</i> 
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
        /// Settings in JSON format for the target Redis endpoint.
        /// </para>
        /// </summary>
        public RedisSettings RedisSettings { get; set; }

        /// <summary>
        /// Checks to see if the RedisSettings property is set.
        /// </summary>
        internal bool IsSetRedisSettings() => this.RedisSettings != null;

        /// <summary>
        /// Gets and sets the property RedshiftSettings.
        /// </summary>
        public RedshiftSettings RedshiftSettings { get; set; }

        /// <summary>
        /// Checks to see if the RedshiftSettings property is set.
        /// </summary>
        internal bool IsSetRedshiftSettings() => this.RedshiftSettings != null;

        /// <summary>
        /// Gets and sets the property ResourceIdentifier. 
        /// <para>
        /// A friendly name for the resource identifier at the end of the <c>EndpointArn</c> response
        /// parameter that is returned in the created <c>Endpoint</c> object. The value for this
        /// parameter can have up to 31 characters. It can contain only ASCII letters, digits,
        /// and hyphen ('-'). Also, it can't end with a hyphen or contain two consecutive hyphens,
        /// and can only begin with a letter, such as <c>Example-App-ARN1</c>. For example, this
        /// value might result in the <c>EndpointArn</c> value <c>arn:aws:dms:eu-west-1:012345678901:rep:Example-App-ARN1</c>.
        /// If you don't specify a <c>ResourceIdentifier</c> value, DMS generates a default identifier
        /// value for the end of <c>EndpointArn</c>.
        /// </para>
        /// </summary>
        public string ResourceIdentifier { get; set; }

        /// <summary>
        /// Checks to see if the ResourceIdentifier property is set.
        /// </summary>
        internal bool IsSetResourceIdentifier() => this.ResourceIdentifier != null;

        /// <summary>
        /// Gets and sets the property S3Settings. 
        /// <para>
        /// Settings in JSON format for the target Amazon S3 endpoint. For more information about
        /// the available settings, see <a href="https://docs.aws.amazon.com/dms/latest/userguide/CHAP_Target.S3.html#CHAP_Target.S3.Configuring">Extra
        /// Connection Attributes When Using Amazon S3 as a Target for DMS</a> in the <i>Database
        /// Migration Service User Guide.</i> 
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
        /// The name of the server where the endpoint database resides.
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
        ///  The Amazon Resource Name (ARN) for the service access role that you want to use to
        /// create the endpoint. The role must allow the <c>iam:PassRole</c> action.
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
        /// The Secure Sockets Layer (SSL) mode to use for the SSL connection. The default is
        /// <c>none</c> 
        /// </para>
        /// </summary>
        public DmsSslModeValue SslMode { get; set; }

        /// <summary>
        /// Checks to see if the SslMode property is set.
        /// </summary>
        internal bool IsSetSslMode() => this.SslMode != null;

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
        public SybaseSettings SybaseSettings { get; set; }

        /// <summary>
        /// Checks to see if the SybaseSettings property is set.
        /// </summary>
        internal bool IsSetSybaseSettings() => this.SybaseSettings != null;

        /// <summary>
        /// Gets and sets the property Tags. 
        /// <para>
        /// One or more tags to be assigned to the endpoint.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<Tag> Tags { get; set; } = AWSConfigs.InitializeCollections ? new List<Tag>() : null;

        /// <summary>
        /// Checks to see if the Tags property is set.
        /// </summary>
        internal bool IsSetTags() => this.Tags != null && (this.Tags.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property TimestreamSettings. 
        /// <para>
        /// Settings in JSON format for the target Amazon Timestream endpoint.
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
        /// The user name to be used to log in to the endpoint database.
        /// </para>
        /// </summary>
        public string Username { get; set; }

        /// <summary>
        /// Checks to see if the Username property is set.
        /// </summary>
        internal bool IsSetUsername() => this.Username != null;
    }
}
