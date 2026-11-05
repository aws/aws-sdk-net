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
    /// Container for the parameters to the ModifyEndpoint operation. Modifies the specified
    /// endpoint. <note> <para> For a MySQL source or target endpoint, don't explicitly specify
    /// the database using the <c>DatabaseName</c> request parameter on the <c>ModifyEndpoint</c>
    /// API call. Specifying <c>DatabaseName</c> when you modify a MySQL endpoint replicates
    /// all the task tables to this single database. For MySQL endpoints, you specify the
    /// database only when you specify the schema in the table-mapping rules of the DMS task.
    /// </para> </note>
    /// </summary>
    public partial class ModifyEndpointRequest : AmazonDatabaseMigrationServiceRequest
    {
        /// <summary>
        /// Gets and sets the property CertificateArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the certificate used for SSL connection.
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
        /// DatabaseName.
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
        /// Attributes include the following:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// serviceAccessRoleArn - The Amazon Resource Name (ARN) used by the service access IAM
        /// role. The role must allow the <c>iam:PassRole</c> action.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// BucketName - The name of the S3 bucket to use.
        /// </para>
        ///  </li> </ul> 
        /// <para>
        /// Shorthand syntax for these settings is as follows: <c>ServiceAccessRoleArn=string
        /// ,BucketName=string</c> 
        /// </para>
        ///  
        /// <para>
        /// JSON syntax for these settings is as follows: <c>{ "ServiceAccessRoleArn": "string",
        /// "BucketName": "string"} </c> 
        /// </para>
        /// </summary>
        public DmsTransferSettings DmsTransferSettings { get; set; }

        /// <summary>
        /// Checks to see if the DmsTransferSettings property is set.
        /// </summary>
        internal bool IsSetDmsTransferSettings() => this.DmsTransferSettings != null;

        /// <summary>
        /// Gets and sets the property DocDbSettings. 
        /// <para>
        /// Settings in JSON format for the source DocumentDB endpoint. For more information about
        /// the available settings, see the configuration properties section in <a href="https://docs.aws.amazon.com/dms/latest/userguide/CHAP_Source.DocumentDB.html">
        /// Using DocumentDB as a Target for Database Migration Service </a> in the <i>Database
        /// Migration Service User Guide.</i> 
        /// </para>
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
        /// Migration Service User Guide.</i> 
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
        [AWSProperty(Required = true)]
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
        /// Gets and sets the property EngineName. 
        /// <para>
        /// The database engine name. Valid values, depending on the EndpointType, include <c>"mysql"</c>,
        /// <c>"oracle"</c>, <c>"postgres"</c>, <c>"mariadb"</c>, <c>"aurora"</c>, <c>"aurora-postgresql"</c>,
        /// <c>"redshift"</c>, <c>"s3"</c>, <c>"db2"</c>, <c>"db2-zos"</c>, <c>"azuredb"</c>,
        /// <c>"sybase"</c>, <c>"dynamodb"</c>, <c>"mongodb"</c>, <c>"kinesis"</c>, <c>"kafka"</c>,
        /// <c>"elasticsearch"</c>, <c>"documentdb"</c>, <c>"sqlserver"</c>, <c>"neptune"</c>,
        /// and <c>"babelfish"</c>.
        /// </para>
        /// </summary>
        public string EngineName { get; set; }

        /// <summary>
        /// Checks to see if the EngineName property is set.
        /// </summary>
        internal bool IsSetEngineName() => this.EngineName != null;

        /// <summary>
        /// Gets and sets the property ExactSettings. 
        /// <para>
        /// If this attribute is Y, the current call to <c>ModifyEndpoint</c> replaces all existing
        /// endpoint settings with the exact settings that you specify in this call. If this attribute
        /// is N, the current call to <c>ModifyEndpoint</c> does two things: 
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// It replaces any endpoint settings that already exist with new values, for settings
        /// with the same names.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// It creates new endpoint settings that you specify in the call, for settings with different
        /// names. 
        /// </para>
        ///  </li> </ul> 
        /// <para>
        /// For example, if you call <c>create-endpoint ... --endpoint-settings '{"a":1}' ...</c>,
        /// the endpoint has the following endpoint settings: <c>'{"a":1}'</c>. If you then call
        /// <c>modify-endpoint ... --endpoint-settings '{"b":2}' ...</c> for the same endpoint,
        /// the endpoint has the following settings: <c>'{"a":1,"b":2}'</c>. 
        /// </para>
        ///  
        /// <para>
        /// However, suppose that you follow this with a call to <c>modify-endpoint ... --endpoint-settings
        /// '{"b":2}' --exact-settings ...</c> for that same endpoint again. Then the endpoint
        /// has the following settings: <c>'{"b":2}'</c>. All existing settings are replaced with
        /// the exact settings that you specify. 
        /// </para>
        /// </summary>
        public bool? ExactSettings { get; set; }

        /// <summary>
        /// Checks to see if the ExactSettings property is set.
        /// </summary>
        internal bool IsSetExactSettings() => this.ExactSettings.HasValue;

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
        /// Additional attributes associated with the connection. To reset this parameter, pass
        /// the empty string ("") as an argument.
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
        /// the available settings, see the configuration properties section in <a href="https://docs.aws.amazon.com/dms/latest/userguide/CHAP_Source.MongoDB.html#CHAP_Source.MongoDB.Configuration">Endpoint
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
        /// The password to be used to login to the endpoint database.
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
        /// Settings in JSON format for the Redis target endpoint.
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
        ///  The Amazon Resource Name (ARN) for the IAM role you want to use to modify the endpoint.
        /// The role must allow the <c>iam:PassRole</c> action.
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
        /// The user name to be used to login to the endpoint database.
        /// </para>
        /// </summary>
        public string Username { get; set; }

        /// <summary>
        /// Checks to see if the Username property is set.
        /// </summary>
        internal bool IsSetUsername() => this.Username != null;
    }
}
