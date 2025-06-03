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

#pragma warning disable CS0612,CS0618,CS1570
namespace Amazon.DatabaseMigrationService.Model
{
    /// <summary>
    /// Provides information that defines a PostgreSQL endpoint.
    /// </summary>
    public partial class PostgreSQLSettings
    {
        private string _afterConnectScript;
        private PostgreSQLAuthenticationMethod _authenticationMethod;
        private string _babelfishDatabaseName;
        private bool? _captureDdls;
        private DatabaseMode _databaseMode;
        private string _databaseName;
        private string _ddlArtifactsSchema;
        private bool? _disableUnicodeSourceFilter;
        private int? _executeTimeout;
        private bool? _failTasksOnLobTruncation;
        private bool? _heartbeatEnable;
        private int? _heartbeatFrequency;
        private string _heartbeatSchema;
        private bool? _mapBooleanAsBoolean;
        private bool? _mapJsonbAsClob;
        private LongVarcharMappingType _mapLongVarcharAs;
        private int? _maxFileSize;
        private string _password;
        private PluginNameValue _pluginName;
        private int? _port;
        private string _secretsManagerAccessRoleArn;
        private string _secretsManagerSecretId;
        private string _serverName;
        private string _serviceAccessRoleArn;
        private string _slotName;
        private bool? _trimSpaceInChar;
        private string _username;

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
        public string AfterConnectScript
        {
            get { return this._afterConnectScript; }
            set { this._afterConnectScript = value; }
        }

        // Check to see if AfterConnectScript property is set
        internal bool IsSetAfterConnectScript()
        {
            return this._afterConnectScript != null;
        }

        /// <summary>
        /// Gets and sets the property AuthenticationMethod. 
        /// <para>
        /// This attribute allows you to specify the authentication method as "iam auth".
        /// </para>
        /// </summary>
        public PostgreSQLAuthenticationMethod AuthenticationMethod
        {
            get { return this._authenticationMethod; }
            set { this._authenticationMethod = value; }
        }

        // Check to see if AuthenticationMethod property is set
        internal bool IsSetAuthenticationMethod()
        {
            return this._authenticationMethod != null;
        }

        /// <summary>
        /// Gets and sets the property BabelfishDatabaseName. 
        /// <para>
        /// The Babelfish for Aurora PostgreSQL database name for the endpoint.
        /// </para>
        /// </summary>
        public string BabelfishDatabaseName
        {
            get { return this._babelfishDatabaseName; }
            set { this._babelfishDatabaseName = value; }
        }

        // Check to see if BabelfishDatabaseName property is set
        internal bool IsSetBabelfishDatabaseName()
        {
            return this._babelfishDatabaseName != null;
        }

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
        public bool? CaptureDdls
        {
            get { return this._captureDdls; }
            set { this._captureDdls = value; }
        }

        // Check to see if CaptureDdls property is set
        internal bool IsSetCaptureDdls()
        {
            return this._captureDdls.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property DatabaseMode. 
        /// <para>
        /// Specifies the default behavior of the replication's handling of PostgreSQL- compatible
        /// endpoints that require some additional configuration, such as Babelfish endpoints.
        /// </para>
        /// </summary>
        public DatabaseMode DatabaseMode
        {
            get { return this._databaseMode; }
            set { this._databaseMode = value; }
        }

        // Check to see if DatabaseMode property is set
        internal bool IsSetDatabaseMode()
        {
            return this._databaseMode != null;
        }

        /// <summary>
        /// Gets and sets the property DatabaseName. 
        /// <para>
        /// Database name for the endpoint.
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
        public string DdlArtifactsSchema
        {
            get { return this._ddlArtifactsSchema; }
            set { this._ddlArtifactsSchema = value; }
        }

        // Check to see if DdlArtifactsSchema property is set
        internal bool IsSetDdlArtifactsSchema()
        {
            return this._ddlArtifactsSchema != null;
        }

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
        public bool? DisableUnicodeSourceFilter
        {
            get { return this._disableUnicodeSourceFilter; }
            set { this._disableUnicodeSourceFilter = value; }
        }

        // Check to see if DisableUnicodeSourceFilter property is set
        internal bool IsSetDisableUnicodeSourceFilter()
        {
            return this._disableUnicodeSourceFilter.HasValue; 
        }

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
        public int? ExecuteTimeout
        {
            get { return this._executeTimeout; }
            set { this._executeTimeout = value; }
        }

        // Check to see if ExecuteTimeout property is set
        internal bool IsSetExecuteTimeout()
        {
            return this._executeTimeout.HasValue; 
        }

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
        public bool? FailTasksOnLobTruncation
        {
            get { return this._failTasksOnLobTruncation; }
            set { this._failTasksOnLobTruncation = value; }
        }

        // Check to see if FailTasksOnLobTruncation property is set
        internal bool IsSetFailTasksOnLobTruncation()
        {
            return this._failTasksOnLobTruncation.HasValue; 
        }

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
        public bool? HeartbeatEnable
        {
            get { return this._heartbeatEnable; }
            set { this._heartbeatEnable = value; }
        }

        // Check to see if HeartbeatEnable property is set
        internal bool IsSetHeartbeatEnable()
        {
            return this._heartbeatEnable.HasValue; 
        }

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
        public int? HeartbeatFrequency
        {
            get { return this._heartbeatFrequency; }
            set { this._heartbeatFrequency = value; }
        }

        // Check to see if HeartbeatFrequency property is set
        internal bool IsSetHeartbeatFrequency()
        {
            return this._heartbeatFrequency.HasValue; 
        }

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
        public string HeartbeatSchema
        {
            get { return this._heartbeatSchema; }
            set { this._heartbeatSchema = value; }
        }

        // Check to see if HeartbeatSchema property is set
        internal bool IsSetHeartbeatSchema()
        {
            return this._heartbeatSchema != null;
        }

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
        public bool? MapBooleanAsBoolean
        {
            get { return this._mapBooleanAsBoolean; }
            set { this._mapBooleanAsBoolean = value; }
        }

        // Check to see if MapBooleanAsBoolean property is set
        internal bool IsSetMapBooleanAsBoolean()
        {
            return this._mapBooleanAsBoolean.HasValue; 
        }

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
        public bool? MapJsonbAsClob
        {
            get { return this._mapJsonbAsClob; }
            set { this._mapJsonbAsClob = value; }
        }

        // Check to see if MapJsonbAsClob property is set
        internal bool IsSetMapJsonbAsClob()
        {
            return this._mapJsonbAsClob.HasValue; 
        }

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
        public LongVarcharMappingType MapLongVarcharAs
        {
            get { return this._mapLongVarcharAs; }
            set { this._mapLongVarcharAs = value; }
        }

        // Check to see if MapLongVarcharAs property is set
        internal bool IsSetMapLongVarcharAs()
        {
            return this._mapLongVarcharAs != null;
        }

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
        public int? MaxFileSize
        {
            get { return this._maxFileSize; }
            set { this._maxFileSize = value; }
        }

        // Check to see if MaxFileSize property is set
        internal bool IsSetMaxFileSize()
        {
            return this._maxFileSize.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Password. 
        /// <para>
        /// Endpoint connection password.
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
        /// Gets and sets the property PluginName. 
        /// <para>
        /// Specifies the plugin to use to create a replication slot.
        /// </para>
        ///  
        /// <para>
        /// The default value is <c>pglogical</c>.
        /// </para>
        /// </summary>
        public PluginNameValue PluginName
        {
            get { return this._pluginName; }
            set { this._pluginName = value; }
        }

        // Check to see if PluginName property is set
        internal bool IsSetPluginName()
        {
            return this._pluginName != null;
        }

        /// <summary>
        /// Gets and sets the property Port. 
        /// <para>
        /// Endpoint TCP port. The default is 5432.
        /// </para>
        /// </summary>
        public int? Port
        {
            get { return this._port; }
            set { this._port = value; }
        }

        // Check to see if Port property is set
        internal bool IsSetPort()
        {
            return this._port.HasValue; 
        }

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
        public string SecretsManagerAccessRoleArn
        {
            get { return this._secretsManagerAccessRoleArn; }
            set { this._secretsManagerAccessRoleArn = value; }
        }

        // Check to see if SecretsManagerAccessRoleArn property is set
        internal bool IsSetSecretsManagerAccessRoleArn()
        {
            return this._secretsManagerAccessRoleArn != null;
        }

        /// <summary>
        /// Gets and sets the property SecretsManagerSecretId. 
        /// <para>
        /// The full ARN, partial ARN, or friendly name of the <c>SecretsManagerSecret</c> that
        /// contains the PostgreSQL endpoint connection details.
        /// </para>
        /// </summary>
        public string SecretsManagerSecretId
        {
            get { return this._secretsManagerSecretId; }
            set { this._secretsManagerSecretId = value; }
        }

        // Check to see if SecretsManagerSecretId property is set
        internal bool IsSetSecretsManagerSecretId()
        {
            return this._secretsManagerSecretId != null;
        }

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
        /// The IAM role arn you can use to authenticate the connection to your endpoint. Ensure
        /// to include <c>iam:PassRole</c> and <c>rds-db:connect</c> actions in permission policy.
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
        public string SlotName
        {
            get { return this._slotName; }
            set { this._slotName = value; }
        }

        // Check to see if SlotName property is set
        internal bool IsSetSlotName()
        {
            return this._slotName != null;
        }

        /// <summary>
        /// Gets and sets the property TrimSpaceInChar. 
        /// <para>
        /// Use the <c>TrimSpaceInChar</c> source endpoint setting to trim data on CHAR and NCHAR
        /// data types during migration. The default value is <c>true</c>.
        /// </para>
        /// </summary>
        public bool? TrimSpaceInChar
        {
            get { return this._trimSpaceInChar; }
            set { this._trimSpaceInChar = value; }
        }

        // Check to see if TrimSpaceInChar property is set
        internal bool IsSetTrimSpaceInChar()
        {
            return this._trimSpaceInChar.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Username. 
        /// <para>
        /// Endpoint connection user name.
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