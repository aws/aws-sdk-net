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
    /// Provides information that defines a PostgreSQL endpoint.
    /// </summary>
    public partial class PostgreSQLSettings
    {
        /// <summary>
        /// Gets and sets the property AfterConnectScript. 
        /// <para>
        /// For use with change data capture (CDC) only, this attribute has DMS bypass foreign
        /// keys and user triggers to reduce the time it takes to bulk load data.
        /// </para>
        ///  
        /// <para>
        /// Example: <c>afterConnectScript=SET session_replication_role='replica'</c> 
        /// </para>
        /// </summary>
        public string AfterConnectScript { get; set; }

        /// <summary>
        /// Checks to see if the AfterConnectScript property is set.
        /// </summary>
        internal bool IsSetAfterConnectScript() => this.AfterConnectScript != null;

        /// <summary>
        /// Gets and sets the property AuthenticationMethod. 
        /// <para>
        /// This attribute allows you to specify the authentication method as "iam auth".
        /// </para>
        /// </summary>
        public PostgreSQLAuthenticationMethod AuthenticationMethod { get; set; }

        /// <summary>
        /// Checks to see if the AuthenticationMethod property is set.
        /// </summary>
        internal bool IsSetAuthenticationMethod() => this.AuthenticationMethod != null;

        /// <summary>
        /// Gets and sets the property BabelfishDatabaseName. 
        /// <para>
        /// The Babelfish for Aurora PostgreSQL database name for the endpoint.
        /// </para>
        /// </summary>
        public string BabelfishDatabaseName { get; set; }

        /// <summary>
        /// Checks to see if the BabelfishDatabaseName property is set.
        /// </summary>
        internal bool IsSetBabelfishDatabaseName() => this.BabelfishDatabaseName != null;

        /// <summary>
        /// Gets and sets the property CaptureDdls. 
        /// <para>
        /// To capture DDL events, DMS creates various artifacts in the PostgreSQL database when
        /// the task starts. You can later remove these artifacts.
        /// </para>
        ///  
        /// <para>
        /// The default value is <c>true</c>.
        /// </para>
        ///  
        /// <para>
        /// If this value is set to <c>N</c>, you don't have to create tables or triggers on the
        /// source database.
        /// </para>
        /// </summary>
        public bool? CaptureDdls { get; set; }

        /// <summary>
        /// Checks to see if the CaptureDdls property is set.
        /// </summary>
        internal bool IsSetCaptureDdls() => this.CaptureDdls.HasValue;

        /// <summary>
        /// Gets and sets the property DatabaseMode. 
        /// <para>
        /// Specifies the default behavior of the replication's handling of PostgreSQL- compatible
        /// endpoints that require some additional configuration, such as Babelfish endpoints.
        /// </para>
        /// </summary>
        public DatabaseMode DatabaseMode { get; set; }

        /// <summary>
        /// Checks to see if the DatabaseMode property is set.
        /// </summary>
        internal bool IsSetDatabaseMode() => this.DatabaseMode != null;

        /// <summary>
        /// Gets and sets the property DatabaseName. 
        /// <para>
        /// Database name for the endpoint.
        /// </para>
        /// </summary>
        public string DatabaseName { get; set; }

        /// <summary>
        /// Checks to see if the DatabaseName property is set.
        /// </summary>
        internal bool IsSetDatabaseName() => this.DatabaseName != null;

        /// <summary>
        /// Gets and sets the property DdlArtifactsSchema. 
        /// <para>
        /// The schema in which the operational DDL database artifacts are created.
        /// </para>
        ///  
        /// <para>
        /// The default value is <c>public</c>.
        /// </para>
        ///  
        /// <para>
        /// Example: <c>ddlArtifactsSchema=xyzddlschema;</c> 
        /// </para>
        /// </summary>
        public string DdlArtifactsSchema { get; set; }

        /// <summary>
        /// Checks to see if the DdlArtifactsSchema property is set.
        /// </summary>
        internal bool IsSetDdlArtifactsSchema() => this.DdlArtifactsSchema != null;

        /// <summary>
        /// Gets and sets the property DisableUnicodeSourceFilter. 
        /// <para>
        /// Disables the Unicode source filter with PostgreSQL, for values passed into the Selection
        /// rule filter on Source Endpoint column values. By default DMS performs source filter
        /// comparisons using a Unicode string which can cause look ups to ignore the indexes
        /// in the text columns and slow down migrations.
        /// </para>
        ///  
        /// <para>
        /// Unicode support should only be disabled when using a selection rule filter is on a
        /// text column in the Source database that is indexed.
        /// </para>
        /// </summary>
        public bool? DisableUnicodeSourceFilter { get; set; }

        /// <summary>
        /// Checks to see if the DisableUnicodeSourceFilter property is set.
        /// </summary>
        internal bool IsSetDisableUnicodeSourceFilter() => this.DisableUnicodeSourceFilter.HasValue;

        /// <summary>
        /// Gets and sets the property ExecuteTimeout. 
        /// <para>
        /// Sets the client statement timeout for the PostgreSQL instance, in seconds. The default
        /// value is 60 seconds.
        /// </para>
        ///  
        /// <para>
        /// Example: <c>executeTimeout=100;</c> 
        /// </para>
        /// </summary>
        public int? ExecuteTimeout { get; set; }

        /// <summary>
        /// Checks to see if the ExecuteTimeout property is set.
        /// </summary>
        internal bool IsSetExecuteTimeout() => this.ExecuteTimeout.HasValue;

        /// <summary>
        /// Gets and sets the property FailTasksOnLobTruncation. 
        /// <para>
        /// When set to <c>true</c>, this value causes a task to fail if the actual size of a
        /// LOB column is greater than the specified <c>LobMaxSize</c>.
        /// </para>
        ///  
        /// <para>
        /// The default value is <c>false</c>.
        /// </para>
        ///  
        /// <para>
        /// If task is set to Limited LOB mode and this option is set to true, the task fails
        /// instead of truncating the LOB data.
        /// </para>
        /// </summary>
        public bool? FailTasksOnLobTruncation { get; set; }

        /// <summary>
        /// Checks to see if the FailTasksOnLobTruncation property is set.
        /// </summary>
        internal bool IsSetFailTasksOnLobTruncation() => this.FailTasksOnLobTruncation.HasValue;

        /// <summary>
        /// Gets and sets the property HeartbeatEnable. 
        /// <para>
        /// The write-ahead log (WAL) heartbeat feature mimics a dummy transaction. By doing this,
        /// it prevents idle logical replication slots from holding onto old WAL logs, which can
        /// result in storage full situations on the source. This heartbeat keeps <c>restart_lsn</c>
        /// moving and prevents storage full scenarios.
        /// </para>
        ///  
        /// <para>
        /// The default value is <c>false</c>.
        /// </para>
        /// </summary>
        public bool? HeartbeatEnable { get; set; }

        /// <summary>
        /// Checks to see if the HeartbeatEnable property is set.
        /// </summary>
        internal bool IsSetHeartbeatEnable() => this.HeartbeatEnable.HasValue;

        /// <summary>
        /// Gets and sets the property HeartbeatFrequency. 
        /// <para>
        /// Sets the WAL heartbeat frequency (in minutes).
        /// </para>
        ///  
        /// <para>
        /// The default value is 5 minutes.
        /// </para>
        /// </summary>
        public int? HeartbeatFrequency { get; set; }

        /// <summary>
        /// Checks to see if the HeartbeatFrequency property is set.
        /// </summary>
        internal bool IsSetHeartbeatFrequency() => this.HeartbeatFrequency.HasValue;

        /// <summary>
        /// Gets and sets the property HeartbeatSchema. 
        /// <para>
        /// Sets the schema in which the heartbeat artifacts are created.
        /// </para>
        ///  
        /// <para>
        /// The default value is <c>public</c>.
        /// </para>
        /// </summary>
        public string HeartbeatSchema { get; set; }

        /// <summary>
        /// Checks to see if the HeartbeatSchema property is set.
        /// </summary>
        internal bool IsSetHeartbeatSchema() => this.HeartbeatSchema != null;

        /// <summary>
        /// Gets and sets the property MapBooleanAsBoolean. 
        /// <para>
        /// When true, lets PostgreSQL migrate the boolean type as boolean. By default, PostgreSQL
        /// migrates booleans as <c>varchar(5)</c>. You must set this setting on both the source
        /// and target endpoints for it to take effect.
        /// </para>
        ///  
        /// <para>
        /// The default value is <c>false</c>.
        /// </para>
        /// </summary>
        public bool? MapBooleanAsBoolean { get; set; }

        /// <summary>
        /// Checks to see if the MapBooleanAsBoolean property is set.
        /// </summary>
        internal bool IsSetMapBooleanAsBoolean() => this.MapBooleanAsBoolean.HasValue;

        /// <summary>
        /// Gets and sets the property MapJsonbAsClob. 
        /// <para>
        /// When true, DMS migrates JSONB values as CLOB.
        /// </para>
        ///  
        /// <para>
        /// The default value is <c>false</c>.
        /// </para>
        /// </summary>
        public bool? MapJsonbAsClob { get; set; }

        /// <summary>
        /// Checks to see if the MapJsonbAsClob property is set.
        /// </summary>
        internal bool IsSetMapJsonbAsClob() => this.MapJsonbAsClob.HasValue;

        /// <summary>
        /// Gets and sets the property MapLongVarcharAs. 
        /// <para>
        /// Sets what datatype to map LONG values as.
        /// </para>
        ///  
        /// <para>
        /// The default value is <c>wstring</c>.
        /// </para>
        /// </summary>
        public LongVarcharMappingType MapLongVarcharAs { get; set; }

        /// <summary>
        /// Checks to see if the MapLongVarcharAs property is set.
        /// </summary>
        internal bool IsSetMapLongVarcharAs() => this.MapLongVarcharAs != null;

        /// <summary>
        /// Gets and sets the property MaxFileSize. 
        /// <para>
        /// Specifies the maximum size (in KB) of any .csv file used to transfer data to PostgreSQL.
        /// </para>
        ///  
        /// <para>
        /// The default value is 32,768 KB (32 MB).
        /// </para>
        ///  
        /// <para>
        /// Example: <c>maxFileSize=512</c> 
        /// </para>
        /// </summary>
        public int? MaxFileSize { get; set; }

        /// <summary>
        /// Checks to see if the MaxFileSize property is set.
        /// </summary>
        internal bool IsSetMaxFileSize() => this.MaxFileSize.HasValue;

        /// <summary>
        /// Gets and sets the property Password. 
        /// <para>
        /// Endpoint connection password.
        /// </para>
        /// </summary>
        [AWSProperty(Sensitive = true)]
        public string Password { get; set; }

        /// <summary>
        /// Checks to see if the Password property is set.
        /// </summary>
        internal bool IsSetPassword() => this.Password != null;

        /// <summary>
        /// Gets and sets the property PluginName. 
        /// <para>
        /// Specifies the plugin to use to create a replication slot.
        /// </para>
        ///  
        /// <para>
        /// The default value is <c>pglogical</c>.
        /// </para>
        /// </summary>
        public PluginNameValue PluginName { get; set; }

        /// <summary>
        /// Checks to see if the PluginName property is set.
        /// </summary>
        internal bool IsSetPluginName() => this.PluginName != null;

        /// <summary>
        /// Gets and sets the property Port. 
        /// <para>
        /// Endpoint TCP port. The default is 5432.
        /// </para>
        /// </summary>
        public int? Port { get; set; }

        /// <summary>
        /// Checks to see if the Port property is set.
        /// </summary>
        internal bool IsSetPort() => this.Port.HasValue;

        /// <summary>
        /// Gets and sets the property SecretsManagerAccessRoleArn. 
        /// <para>
        /// The full Amazon Resource Name (ARN) of the IAM role that specifies DMS as the trusted
        /// entity and grants the required permissions to access the value in <c>SecretsManagerSecret</c>.
        /// The role must allow the <c>iam:PassRole</c> action. <c>SecretsManagerSecret</c> has
        /// the value of the Amazon Web Services Secrets Manager secret that allows access to
        /// the PostgreSQL endpoint.
        /// </para>
        ///  <note> 
        /// <para>
        /// You can specify one of two sets of values for these permissions. You can specify the
        /// values for this setting and <c>SecretsManagerSecretId</c>. Or you can specify clear-text
        /// values for <c>UserName</c>, <c>Password</c>, <c>ServerName</c>, and <c>Port</c>. You
        /// can't specify both. For more information on creating this <c>SecretsManagerSecret</c>
        /// and the <c>SecretsManagerAccessRoleArn</c> and <c>SecretsManagerSecretId</c> required
        /// to access it, see <a href="https://docs.aws.amazon.com/dms/latest/userguide/CHAP_Security.html#security-iam-secretsmanager">Using
        /// secrets to access Database Migration Service resources</a> in the <i>Database Migration
        /// Service User Guide</i>.
        /// </para>
        ///  </note>
        /// </summary>
        public string SecretsManagerAccessRoleArn { get; set; }

        /// <summary>
        /// Checks to see if the SecretsManagerAccessRoleArn property is set.
        /// </summary>
        internal bool IsSetSecretsManagerAccessRoleArn() => this.SecretsManagerAccessRoleArn != null;

        /// <summary>
        /// Gets and sets the property SecretsManagerSecretId. 
        /// <para>
        /// The full ARN, partial ARN, or friendly name of the <c>SecretsManagerSecret</c> that
        /// contains the PostgreSQL endpoint connection details.
        /// </para>
        /// </summary>
        public string SecretsManagerSecretId { get; set; }

        /// <summary>
        /// Checks to see if the SecretsManagerSecretId property is set.
        /// </summary>
        internal bool IsSetSecretsManagerSecretId() => this.SecretsManagerSecretId != null;

        /// <summary>
        /// Gets and sets the property ServerName. 
        /// <para>
        /// The host name of the endpoint database. 
        /// </para>
        ///  
        /// <para>
        /// For an Amazon RDS PostgreSQL instance, this is the output of <a href="https://docs.aws.amazon.com/AmazonRDS/latest/APIReference/API_DescribeDBInstances.html">DescribeDBInstances</a>,
        /// in the <c> <a href="https://docs.aws.amazon.com/AmazonRDS/latest/APIReference/API_Endpoint.html">Endpoint</a>.Address</c>
        /// field.
        /// </para>
        ///  
        /// <para>
        /// For an Aurora PostgreSQL instance, this is the output of <a href="https://docs.aws.amazon.com/AmazonRDS/latest/APIReference/API_DescribeDBClusters.html">DescribeDBClusters</a>,
        /// in the <c>Endpoint</c> field.
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
        /// The IAM role arn you can use to authenticate the connection to your endpoint. Ensure
        /// to include <c>iam:PassRole</c> and <c>rds-db:connect</c> actions in permission policy.
        /// </para>
        /// </summary>
        public string ServiceAccessRoleArn { get; set; }

        /// <summary>
        /// Checks to see if the ServiceAccessRoleArn property is set.
        /// </summary>
        internal bool IsSetServiceAccessRoleArn() => this.ServiceAccessRoleArn != null;

        /// <summary>
        /// Gets and sets the property SlotName. 
        /// <para>
        /// Sets the name of a previously created logical replication slot for a change data capture
        /// (CDC) load of the PostgreSQL source instance. 
        /// </para>
        ///  
        /// <para>
        /// When used with the <c>CdcStartPosition</c> request parameter for the DMS API , this
        /// attribute also makes it possible to use native CDC start points. DMS verifies that
        /// the specified logical replication slot exists before starting the CDC load task. It
        /// also verifies that the task was created with a valid setting of <c>CdcStartPosition</c>.
        /// If the specified slot doesn't exist or the task doesn't have a valid <c>CdcStartPosition</c>
        /// setting, DMS raises an error.
        /// </para>
        ///  
        /// <para>
        /// For more information about setting the <c>CdcStartPosition</c> request parameter,
        /// see <a href="https://docs.aws.amazon.com/dms/latest/userguide/CHAP_Task.CDC.html#CHAP_Task.CDC.StartPoint.Native">Determining
        /// a CDC native start point</a> in the <i>Database Migration Service User Guide</i>.
        /// For more information about using <c>CdcStartPosition</c>, see <a href="https://docs.aws.amazon.com/dms/latest/APIReference/API_CreateReplicationTask.html">CreateReplicationTask</a>,
        /// <a href="https://docs.aws.amazon.com/dms/latest/APIReference/API_StartReplicationTask.html">StartReplicationTask</a>,
        /// and <a href="https://docs.aws.amazon.com/dms/latest/APIReference/API_ModifyReplicationTask.html">ModifyReplicationTask</a>.
        /// </para>
        /// </summary>
        public string SlotName { get; set; }

        /// <summary>
        /// Checks to see if the SlotName property is set.
        /// </summary>
        internal bool IsSetSlotName() => this.SlotName != null;

        /// <summary>
        /// Gets and sets the property TrimSpaceInChar. 
        /// <para>
        /// Use the <c>TrimSpaceInChar</c> source endpoint setting to trim data on CHAR and NCHAR
        /// data types during migration. The default value is <c>true</c>.
        /// </para>
        /// </summary>
        public bool? TrimSpaceInChar { get; set; }

        /// <summary>
        /// Checks to see if the TrimSpaceInChar property is set.
        /// </summary>
        internal bool IsSetTrimSpaceInChar() => this.TrimSpaceInChar.HasValue;

        /// <summary>
        /// Gets and sets the property Username. 
        /// <para>
        /// Endpoint connection user name.
        /// </para>
        /// </summary>
        public string Username { get; set; }

        /// <summary>
        /// Checks to see if the Username property is set.
        /// </summary>
        internal bool IsSetUsername() => this.Username != null;
    }
}
