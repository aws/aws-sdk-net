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
    /// Provides information that defines an Oracle endpoint.
    /// </summary>
    public partial class OracleSettings
    {
        private bool? _accessAlternateDirectly;
        private int? _additionalArchivedLogDestId;
        private bool? _addSupplementalLogging;
        private bool? _allowSelectNestedTables;
        private int? _archivedLogDestId;
        private bool? _archivedLogsOnly;
        private string _asmPassword;
        private string _asmServer;
        private string _asmUser;
        private OracleAuthenticationMethod _authenticationMethod;
        private CharLengthSemantics _charLengthSemantics;
        private bool? _convertTimestampWithZoneToUTC;
        private string _databaseName;
        private bool? _directPathNoLog;
        private bool? _directPathParallelLoad;
        private bool? _enableHomogenousTablespace;
        private List<int> _extraArchivedLogDestIds = AWSConfigs.InitializeCollections ? new List<int>() : null;
        private bool? _failTasksOnLobTruncation;
        private int? _numberDatatypeScale;
        private int? _openTransactionWindow;
        private string _oraclePathPrefix;
        private int? _parallelAsmReadThreads;
        private string _password;
        private int? _port;
        private int? _readAheadBlocks;
        private bool? _readTableSpaceName;
        private bool? _replacePathPrefix;
        private int? _retryInterval;
        private string _secretsManagerAccessRoleArn;
        private string _secretsManagerOracleAsmAccessRoleArn;
        private string _secretsManagerOracleAsmSecretId;
        private string _secretsManagerSecretId;
        private string _securityDbEncryption;
        private string _securityDbEncryptionName;
        private string _serverName;
        private string _spatialDataOptionToGeoJsonFunctionName;
        private int? _standbyDelayTime;
        private bool? _trimSpaceInChar;
        private bool? _useAlternateFolderForOnline;
        private bool? _useBFile;
        private bool? _useDirectPathFullLoad;
        private bool? _useLogminerReader;
        private string _usePathPrefix;
        private string _username;

        /// <summary>
        /// Gets and sets the property AccessAlternateDirectly. 
        /// <para>
        /// Set this attribute to <c>false</c> in order to use the Binary Reader to capture change
        /// data for an Amazon RDS for Oracle as the source. This tells the DMS instance to not
        /// access redo logs through any specified path prefix replacement using direct file access.
        /// </para>
        /// </summary>
        public bool? AccessAlternateDirectly
        {
            get { return this._accessAlternateDirectly; }
            set { this._accessAlternateDirectly = value; }
        }

        // Check to see if AccessAlternateDirectly property is set
        internal bool IsSetAccessAlternateDirectly()
        {
            return this._accessAlternateDirectly.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property AdditionalArchivedLogDestId. 
        /// <para>
        /// Set this attribute with <c>ArchivedLogDestId</c> in a primary/ standby setup. This
        /// attribute is useful in the case of a switchover. In this case, DMS needs to know which
        /// destination to get archive redo logs from to read changes. This need arises because
        /// the previous primary instance is now a standby instance after switchover.
        /// </para>
        ///  
        /// <para>
        /// Although DMS supports the use of the Oracle <c>RESETLOGS</c> option to open the database,
        /// never use <c>RESETLOGS</c> unless necessary. For additional information about <c>RESETLOGS</c>,
        /// see <a href="https://docs.oracle.com/en/database/oracle/oracle-database/19/bradv/rman-data-repair-concepts.html#GUID-1805CCF7-4AF2-482D-B65A-998192F89C2B">RMAN
        /// Data Repair Concepts</a> in the <i>Oracle Database Backup and Recovery User's Guide</i>.
        /// </para>
        /// </summary>
        public int? AdditionalArchivedLogDestId
        {
            get { return this._additionalArchivedLogDestId; }
            set { this._additionalArchivedLogDestId = value; }
        }

        // Check to see if AdditionalArchivedLogDestId property is set
        internal bool IsSetAdditionalArchivedLogDestId()
        {
            return this._additionalArchivedLogDestId.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property AddSupplementalLogging. 
        /// <para>
        /// Set this attribute to set up table-level supplemental logging for the Oracle database.
        /// This attribute enables PRIMARY KEY supplemental logging on all tables selected for
        /// a migration task.
        /// </para>
        ///  
        /// <para>
        /// If you use this option, you still need to enable database-level supplemental logging.
        /// </para>
        /// </summary>
        public bool? AddSupplementalLogging
        {
            get { return this._addSupplementalLogging; }
            set { this._addSupplementalLogging = value; }
        }

        // Check to see if AddSupplementalLogging property is set
        internal bool IsSetAddSupplementalLogging()
        {
            return this._addSupplementalLogging.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property AllowSelectNestedTables. 
        /// <para>
        /// Set this attribute to <c>true</c> to enable replication of Oracle tables containing
        /// columns that are nested tables or defined types.
        /// </para>
        /// </summary>
        public bool? AllowSelectNestedTables
        {
            get { return this._allowSelectNestedTables; }
            set { this._allowSelectNestedTables = value; }
        }

        // Check to see if AllowSelectNestedTables property is set
        internal bool IsSetAllowSelectNestedTables()
        {
            return this._allowSelectNestedTables.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property ArchivedLogDestId. 
        /// <para>
        /// Specifies the ID of the destination for the archived redo logs. This value should
        /// be the same as a number in the dest_id column of the v$archived_log view. If you work
        /// with an additional redo log destination, use the <c>AdditionalArchivedLogDestId</c>
        /// option to specify the additional destination ID. Doing this improves performance by
        /// ensuring that the correct logs are accessed from the outset.
        /// </para>
        /// </summary>
        public int? ArchivedLogDestId
        {
            get { return this._archivedLogDestId; }
            set { this._archivedLogDestId = value; }
        }

        // Check to see if ArchivedLogDestId property is set
        internal bool IsSetArchivedLogDestId()
        {
            return this._archivedLogDestId.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property ArchivedLogsOnly. 
        /// <para>
        /// When this field is set to <c>True</c>, DMS only accesses the archived redo logs. If
        /// the archived redo logs are stored on Automatic Storage Management (ASM) only, the
        /// DMS user account needs to be granted ASM privileges.
        /// </para>
        /// </summary>
        public bool? ArchivedLogsOnly
        {
            get { return this._archivedLogsOnly; }
            set { this._archivedLogsOnly = value; }
        }

        // Check to see if ArchivedLogsOnly property is set
        internal bool IsSetArchivedLogsOnly()
        {
            return this._archivedLogsOnly.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property AsmPassword. 
        /// <para>
        /// For an Oracle source endpoint, your Oracle Automatic Storage Management (ASM) password.
        /// You can set this value from the <c> <i>asm_user_password</i> </c> value. You set this
        /// value as part of the comma-separated value that you set to the <c>Password</c> request
        /// parameter when you create the endpoint to access transaction logs using Binary Reader.
        /// For more information, see <a href="https://docs.aws.amazon.com/dms/latest/userguide/CHAP_Source.Oracle.html#dms/latest/userguide/CHAP_Source.Oracle.html#CHAP_Source.Oracle.CDC.Configuration">Configuration
        /// for change data capture (CDC) on an Oracle source database</a>.
        /// </para>
        /// </summary>
        [AWSProperty(Sensitive=true)]
        public string AsmPassword
        {
            get { return this._asmPassword; }
            set { this._asmPassword = value; }
        }

        // Check to see if AsmPassword property is set
        internal bool IsSetAsmPassword()
        {
            return this._asmPassword != null;
        }

        /// <summary>
        /// Gets and sets the property AsmServer. 
        /// <para>
        /// For an Oracle source endpoint, your ASM server address. You can set this value from
        /// the <c>asm_server</c> value. You set <c>asm_server</c> as part of the extra connection
        /// attribute string to access an Oracle server with Binary Reader that uses ASM. For
        /// more information, see <a href="https://docs.aws.amazon.com/dms/latest/userguide/CHAP_Source.Oracle.html#dms/latest/userguide/CHAP_Source.Oracle.html#CHAP_Source.Oracle.CDC.Configuration">Configuration
        /// for change data capture (CDC) on an Oracle source database</a>.
        /// </para>
        /// </summary>
        public string AsmServer
        {
            get { return this._asmServer; }
            set { this._asmServer = value; }
        }

        // Check to see if AsmServer property is set
        internal bool IsSetAsmServer()
        {
            return this._asmServer != null;
        }

        /// <summary>
        /// Gets and sets the property AsmUser. 
        /// <para>
        /// For an Oracle source endpoint, your ASM user name. You can set this value from the
        /// <c>asm_user</c> value. You set <c>asm_user</c> as part of the extra connection attribute
        /// string to access an Oracle server with Binary Reader that uses ASM. For more information,
        /// see <a href="https://docs.aws.amazon.com/dms/latest/userguide/CHAP_Source.Oracle.html#dms/latest/userguide/CHAP_Source.Oracle.html#CHAP_Source.Oracle.CDC.Configuration">Configuration
        /// for change data capture (CDC) on an Oracle source database</a>.
        /// </para>
        /// </summary>
        public string AsmUser
        {
            get { return this._asmUser; }
            set { this._asmUser = value; }
        }

        // Check to see if AsmUser property is set
        internal bool IsSetAsmUser()
        {
            return this._asmUser != null;
        }

        /// <summary>
        /// Gets and sets the property AuthenticationMethod. 
        /// <para>
        /// Specifies the authentication method to be used with Oracle.
        /// </para>
        /// </summary>
        public OracleAuthenticationMethod AuthenticationMethod
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
        /// Gets and sets the property CharLengthSemantics. 
        /// <para>
        /// Specifies whether the length of a character column is in bytes or in characters. To
        /// indicate that the character column length is in characters, set this attribute to
        /// <c>CHAR</c>. Otherwise, the character column length is in bytes.
        /// </para>
        ///  
        /// <para>
        /// Example: <c>charLengthSemantics=CHAR;</c> 
        /// </para>
        /// </summary>
        public CharLengthSemantics CharLengthSemantics
        {
            get { return this._charLengthSemantics; }
            set { this._charLengthSemantics = value; }
        }

        // Check to see if CharLengthSemantics property is set
        internal bool IsSetCharLengthSemantics()
        {
            return this._charLengthSemantics != null;
        }

        /// <summary>
        /// Gets and sets the property ConvertTimestampWithZoneToUTC. 
        /// <para>
        /// When true, converts timestamps with the <c>timezone</c> datatype to their UTC value.
        /// </para>
        /// </summary>
        public bool? ConvertTimestampWithZoneToUTC
        {
            get { return this._convertTimestampWithZoneToUTC; }
            set { this._convertTimestampWithZoneToUTC = value; }
        }

        // Check to see if ConvertTimestampWithZoneToUTC property is set
        internal bool IsSetConvertTimestampWithZoneToUTC()
        {
            return this._convertTimestampWithZoneToUTC.HasValue; 
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
        /// Gets and sets the property DirectPathNoLog. 
        /// <para>
        /// When set to <c>true</c>, this attribute helps to increase the commit rate on the Oracle
        /// target database by writing directly to tables and not writing a trail to database
        /// logs.
        /// </para>
        /// </summary>
        public bool? DirectPathNoLog
        {
            get { return this._directPathNoLog; }
            set { this._directPathNoLog = value; }
        }

        // Check to see if DirectPathNoLog property is set
        internal bool IsSetDirectPathNoLog()
        {
            return this._directPathNoLog.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property DirectPathParallelLoad. 
        /// <para>
        /// When set to <c>true</c>, this attribute specifies a parallel load when <c>useDirectPathFullLoad</c>
        /// is set to <c>Y</c>. This attribute also only applies when you use the DMS parallel
        /// load feature. Note that the target table cannot have any constraints or indexes.
        /// </para>
        /// </summary>
        public bool? DirectPathParallelLoad
        {
            get { return this._directPathParallelLoad; }
            set { this._directPathParallelLoad = value; }
        }

        // Check to see if DirectPathParallelLoad property is set
        internal bool IsSetDirectPathParallelLoad()
        {
            return this._directPathParallelLoad.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property EnableHomogenousTablespace. 
        /// <para>
        /// Set this attribute to enable homogenous tablespace replication and create existing
        /// tables or indexes under the same tablespace on the target.
        /// </para>
        /// </summary>
        public bool? EnableHomogenousTablespace
        {
            get { return this._enableHomogenousTablespace; }
            set { this._enableHomogenousTablespace = value; }
        }

        // Check to see if EnableHomogenousTablespace property is set
        internal bool IsSetEnableHomogenousTablespace()
        {
            return this._enableHomogenousTablespace.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property ExtraArchivedLogDestIds. 
        /// <para>
        /// Specifies the IDs of one more destinations for one or more archived redo logs. These
        /// IDs are the values of the <c>dest_id</c> column in the <c>v$archived_log</c> view.
        /// Use this setting with the <c>archivedLogDestId</c> extra connection attribute in a
        /// primary-to-single setup or a primary-to-multiple-standby setup. 
        /// </para>
        ///  
        /// <para>
        /// This setting is useful in a switchover when you use an Oracle Data Guard database
        /// as a source. In this case, DMS needs information about what destination to get archive
        /// redo logs from to read changes. DMS needs this because after the switchover the previous
        /// primary is a standby instance. For example, in a primary-to-single standby setup you
        /// might apply the following settings. 
        /// </para>
        ///  
        /// <para>
        ///  <c>archivedLogDestId=1; ExtraArchivedLogDestIds=[2]</c> 
        /// </para>
        ///  
        /// <para>
        /// In a primary-to-multiple-standby setup, you might apply the following settings.
        /// </para>
        ///  
        /// <para>
        ///  <c>archivedLogDestId=1; ExtraArchivedLogDestIds=[2,3,4]</c> 
        /// </para>
        ///  
        /// <para>
        /// Although DMS supports the use of the Oracle <c>RESETLOGS</c> option to open the database,
        /// never use <c>RESETLOGS</c> unless it's necessary. For more information about <c>RESETLOGS</c>,
        /// see <a href="https://docs.oracle.com/en/database/oracle/oracle-database/19/bradv/rman-data-repair-concepts.html#GUID-1805CCF7-4AF2-482D-B65A-998192F89C2B">
        /// RMAN Data Repair Concepts</a> in the <i>Oracle Database Backup and Recovery User's
        /// Guide</i>.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<int> ExtraArchivedLogDestIds
        {
            get { return this._extraArchivedLogDestIds; }
            set { this._extraArchivedLogDestIds = value; }
        }

        // Check to see if ExtraArchivedLogDestIds property is set
        internal bool IsSetExtraArchivedLogDestIds()
        {
            return this._extraArchivedLogDestIds != null && (this._extraArchivedLogDestIds.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property FailTasksOnLobTruncation. 
        /// <para>
        /// When set to <c>true</c>, this attribute causes a task to fail if the actual size of
        /// an LOB column is greater than the specified <c>LobMaxSize</c>.
        /// </para>
        ///  
        /// <para>
        /// If a task is set to limited LOB mode and this option is set to <c>true</c>, the task
        /// fails instead of truncating the LOB data.
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
        /// Gets and sets the property NumberDatatypeScale. 
        /// <para>
        /// Specifies the number scale. You can select a scale up to 38, or you can select FLOAT.
        /// By default, the NUMBER data type is converted to precision 38, scale 10.
        /// </para>
        ///  
        /// <para>
        /// Example: <c>numberDataTypeScale=12</c> 
        /// </para>
        /// </summary>
        public int? NumberDatatypeScale
        {
            get { return this._numberDatatypeScale; }
            set { this._numberDatatypeScale = value; }
        }

        // Check to see if NumberDatatypeScale property is set
        internal bool IsSetNumberDatatypeScale()
        {
            return this._numberDatatypeScale.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property OpenTransactionWindow. 
        /// <para>
        /// The timeframe in minutes to check for open transactions for a CDC-only task.
        /// </para>
        ///  
        /// <para>
        /// You can specify an integer value between 0 (the default) and 240 (the maximum). 
        /// </para>
        ///  <note> 
        /// <para>
        /// This parameter is only valid in DMS version 3.5.0 and later.
        /// </para>
        ///  </note>
        /// </summary>
        public int? OpenTransactionWindow
        {
            get { return this._openTransactionWindow; }
            set { this._openTransactionWindow = value; }
        }

        // Check to see if OpenTransactionWindow property is set
        internal bool IsSetOpenTransactionWindow()
        {
            return this._openTransactionWindow.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property OraclePathPrefix. 
        /// <para>
        /// Set this string attribute to the required value in order to use the Binary Reader
        /// to capture change data for an Amazon RDS for Oracle as the source. This value specifies
        /// the default Oracle root used to access the redo logs.
        /// </para>
        /// </summary>
        public string OraclePathPrefix
        {
            get { return this._oraclePathPrefix; }
            set { this._oraclePathPrefix = value; }
        }

        // Check to see if OraclePathPrefix property is set
        internal bool IsSetOraclePathPrefix()
        {
            return this._oraclePathPrefix != null;
        }

        /// <summary>
        /// Gets and sets the property ParallelAsmReadThreads. 
        /// <para>
        /// Set this attribute to change the number of threads that DMS configures to perform
        /// a change data capture (CDC) load using Oracle Automatic Storage Management (ASM).
        /// You can specify an integer value between 2 (the default) and 8 (the maximum). Use
        /// this attribute together with the <c>readAheadBlocks</c> attribute.
        /// </para>
        /// </summary>
        public int? ParallelAsmReadThreads
        {
            get { return this._parallelAsmReadThreads; }
            set { this._parallelAsmReadThreads = value; }
        }

        // Check to see if ParallelAsmReadThreads property is set
        internal bool IsSetParallelAsmReadThreads()
        {
            return this._parallelAsmReadThreads.HasValue; 
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
        /// Gets and sets the property Port. 
        /// <para>
        /// Endpoint TCP port.
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
        /// Gets and sets the property ReadAheadBlocks. 
        /// <para>
        /// Set this attribute to change the number of read-ahead blocks that DMS configures to
        /// perform a change data capture (CDC) load using Oracle Automatic Storage Management
        /// (ASM). You can specify an integer value between 1000 (the default) and 200,000 (the
        /// maximum).
        /// </para>
        /// </summary>
        public int? ReadAheadBlocks
        {
            get { return this._readAheadBlocks; }
            set { this._readAheadBlocks = value; }
        }

        // Check to see if ReadAheadBlocks property is set
        internal bool IsSetReadAheadBlocks()
        {
            return this._readAheadBlocks.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property ReadTableSpaceName. 
        /// <para>
        /// When set to <c>true</c>, this attribute supports tablespace replication.
        /// </para>
        /// </summary>
        public bool? ReadTableSpaceName
        {
            get { return this._readTableSpaceName; }
            set { this._readTableSpaceName = value; }
        }

        // Check to see if ReadTableSpaceName property is set
        internal bool IsSetReadTableSpaceName()
        {
            return this._readTableSpaceName.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property ReplacePathPrefix. 
        /// <para>
        /// Set this attribute to true in order to use the Binary Reader to capture change data
        /// for an Amazon RDS for Oracle as the source. This setting tells DMS instance to replace
        /// the default Oracle root with the specified <c>usePathPrefix</c> setting to access
        /// the redo logs.
        /// </para>
        /// </summary>
        public bool? ReplacePathPrefix
        {
            get { return this._replacePathPrefix; }
            set { this._replacePathPrefix = value; }
        }

        // Check to see if ReplacePathPrefix property is set
        internal bool IsSetReplacePathPrefix()
        {
            return this._replacePathPrefix.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property RetryInterval. 
        /// <para>
        /// Specifies the number of seconds that the system waits before resending a query.
        /// </para>
        ///  
        /// <para>
        /// Example: <c>retryInterval=6;</c> 
        /// </para>
        /// </summary>
        public int? RetryInterval
        {
            get { return this._retryInterval; }
            set { this._retryInterval = value; }
        }

        // Check to see if RetryInterval property is set
        internal bool IsSetRetryInterval()
        {
            return this._retryInterval.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property SecretsManagerAccessRoleArn. 
        /// <para>
        /// The full Amazon Resource Name (ARN) of the IAM role that specifies DMS as the trusted
        /// entity and grants the required permissions to access the value in <c>SecretsManagerSecret</c>.
        /// The role must allow the <c>iam:PassRole</c> action. <c>SecretsManagerSecret</c> has
        /// the value of the Amazon Web Services Secrets Manager secret that allows access to
        /// the Oracle endpoint.
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
        /// Gets and sets the property SecretsManagerOracleAsmAccessRoleArn. 
        /// <para>
        /// Required only if your Oracle endpoint uses Automatic Storage Management (ASM). The
        /// full ARN of the IAM role that specifies DMS as the trusted entity and grants the required
        /// permissions to access the <c>SecretsManagerOracleAsmSecret</c>. This <c>SecretsManagerOracleAsmSecret</c>
        /// has the secret value that allows access to the Oracle ASM of the endpoint.
        /// </para>
        ///  <note> 
        /// <para>
        /// You can specify one of two sets of values for these permissions. You can specify the
        /// values for this setting and <c>SecretsManagerOracleAsmSecretId</c>. Or you can specify
        /// clear-text values for <c>AsmUser</c>, <c>AsmPassword</c>, and <c>AsmServerName</c>.
        /// You can't specify both. For more information on creating this <c>SecretsManagerOracleAsmSecret</c>
        /// and the <c>SecretsManagerOracleAsmAccessRoleArn</c> and <c>SecretsManagerOracleAsmSecretId</c>
        /// required to access it, see <a href="https://docs.aws.amazon.com/dms/latest/userguide/CHAP_Security.html#security-iam-secretsmanager">Using
        /// secrets to access Database Migration Service resources</a> in the <i>Database Migration
        /// Service User Guide</i>.
        /// </para>
        ///  </note>
        /// </summary>
        public string SecretsManagerOracleAsmAccessRoleArn
        {
            get { return this._secretsManagerOracleAsmAccessRoleArn; }
            set { this._secretsManagerOracleAsmAccessRoleArn = value; }
        }

        // Check to see if SecretsManagerOracleAsmAccessRoleArn property is set
        internal bool IsSetSecretsManagerOracleAsmAccessRoleArn()
        {
            return this._secretsManagerOracleAsmAccessRoleArn != null;
        }

        /// <summary>
        /// Gets and sets the property SecretsManagerOracleAsmSecretId. 
        /// <para>
        /// Required only if your Oracle endpoint uses Automatic Storage Management (ASM). The
        /// full ARN, partial ARN, or friendly name of the <c>SecretsManagerOracleAsmSecret</c>
        /// that contains the Oracle ASM connection details for the Oracle endpoint.
        /// </para>
        /// </summary>
        public string SecretsManagerOracleAsmSecretId
        {
            get { return this._secretsManagerOracleAsmSecretId; }
            set { this._secretsManagerOracleAsmSecretId = value; }
        }

        // Check to see if SecretsManagerOracleAsmSecretId property is set
        internal bool IsSetSecretsManagerOracleAsmSecretId()
        {
            return this._secretsManagerOracleAsmSecretId != null;
        }

        /// <summary>
        /// Gets and sets the property SecretsManagerSecretId. 
        /// <para>
        /// The full ARN, partial ARN, or friendly name of the <c>SecretsManagerSecret</c> that
        /// contains the Oracle endpoint connection details.
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
        /// Gets and sets the property SecurityDbEncryption. 
        /// <para>
        /// For an Oracle source endpoint, the transparent data encryption (TDE) password required
        /// by AWM DMS to access Oracle redo logs encrypted by TDE using Binary Reader. It is
        /// also the <c> <i>TDE_Password</i> </c> part of the comma-separated value you set to
        /// the <c>Password</c> request parameter when you create the endpoint. The <c>SecurityDbEncryptian</c>
        /// setting is related to this <c>SecurityDbEncryptionName</c> setting. For more information,
        /// see <a href="https://docs.aws.amazon.com/dms/latest/userguide/CHAP_Source.Oracle.html#CHAP_Source.Oracle.Encryption">
        /// Supported encryption methods for using Oracle as a source for DMS </a> in the <i>Database
        /// Migration Service User Guide</i>. 
        /// </para>
        /// </summary>
        [AWSProperty(Sensitive=true)]
        public string SecurityDbEncryption
        {
            get { return this._securityDbEncryption; }
            set { this._securityDbEncryption = value; }
        }

        // Check to see if SecurityDbEncryption property is set
        internal bool IsSetSecurityDbEncryption()
        {
            return this._securityDbEncryption != null;
        }

        /// <summary>
        /// Gets and sets the property SecurityDbEncryptionName. 
        /// <para>
        /// For an Oracle source endpoint, the name of a key used for the transparent data encryption
        /// (TDE) of the columns and tablespaces in an Oracle source database that is encrypted
        /// using TDE. The key value is the value of the <c>SecurityDbEncryption</c> setting.
        /// For more information on setting the key name value of <c>SecurityDbEncryptionName</c>,
        /// see the information and example for setting the <c>securityDbEncryptionName</c> extra
        /// connection attribute in <a href="https://docs.aws.amazon.com/dms/latest/userguide/CHAP_Source.Oracle.html#CHAP_Source.Oracle.Encryption">
        /// Supported encryption methods for using Oracle as a source for DMS </a> in the <i>Database
        /// Migration Service User Guide</i>.
        /// </para>
        /// </summary>
        public string SecurityDbEncryptionName
        {
            get { return this._securityDbEncryptionName; }
            set { this._securityDbEncryptionName = value; }
        }

        // Check to see if SecurityDbEncryptionName property is set
        internal bool IsSetSecurityDbEncryptionName()
        {
            return this._securityDbEncryptionName != null;
        }

        /// <summary>
        /// Gets and sets the property ServerName. 
        /// <para>
        /// Fully qualified domain name of the endpoint.
        /// </para>
        ///  
        /// <para>
        /// For an Amazon RDS Oracle instance, this is the output of <a href="https://docs.aws.amazon.com/AmazonRDS/latest/APIReference/API_DescribeDBInstances.html">DescribeDBInstances</a>,
        /// in the <c> <a href="https://docs.aws.amazon.com/AmazonRDS/latest/APIReference/API_Endpoint.html">Endpoint</a>.Address</c>
        /// field.
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
        /// Gets and sets the property SpatialDataOptionToGeoJsonFunctionName. 
        /// <para>
        /// Use this attribute to convert <c>SDO_GEOMETRY</c> to <c>GEOJSON</c> format. By default,
        /// DMS calls the <c>SDO2GEOJSON</c> custom function if present and accessible. Or you
        /// can create your own custom function that mimics the operation of <c>SDOGEOJSON</c>
        /// and set <c>SpatialDataOptionToGeoJsonFunctionName</c> to call it instead. 
        /// </para>
        /// </summary>
        public string SpatialDataOptionToGeoJsonFunctionName
        {
            get { return this._spatialDataOptionToGeoJsonFunctionName; }
            set { this._spatialDataOptionToGeoJsonFunctionName = value; }
        }

        // Check to see if SpatialDataOptionToGeoJsonFunctionName property is set
        internal bool IsSetSpatialDataOptionToGeoJsonFunctionName()
        {
            return this._spatialDataOptionToGeoJsonFunctionName != null;
        }

        /// <summary>
        /// Gets and sets the property StandbyDelayTime. 
        /// <para>
        /// Use this attribute to specify a time in minutes for the delay in standby sync. If
        /// the source is an Oracle Active Data Guard standby database, use this attribute to
        /// specify the time lag between primary and standby databases.
        /// </para>
        ///  
        /// <para>
        /// In DMS, you can create an Oracle CDC task that uses an Active Data Guard standby instance
        /// as a source for replicating ongoing changes. Doing this eliminates the need to connect
        /// to an active database that might be in production.
        /// </para>
        /// </summary>
        public int? StandbyDelayTime
        {
            get { return this._standbyDelayTime; }
            set { this._standbyDelayTime = value; }
        }

        // Check to see if StandbyDelayTime property is set
        internal bool IsSetStandbyDelayTime()
        {
            return this._standbyDelayTime.HasValue; 
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
        /// Gets and sets the property UseAlternateFolderForOnline. 
        /// <para>
        /// Set this attribute to <c>true</c> in order to use the Binary Reader to capture change
        /// data for an Amazon RDS for Oracle as the source. This tells the DMS instance to use
        /// any specified prefix replacement to access all online redo logs.
        /// </para>
        /// </summary>
        public bool? UseAlternateFolderForOnline
        {
            get { return this._useAlternateFolderForOnline; }
            set { this._useAlternateFolderForOnline = value; }
        }

        // Check to see if UseAlternateFolderForOnline property is set
        internal bool IsSetUseAlternateFolderForOnline()
        {
            return this._useAlternateFolderForOnline.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property UseBFile. 
        /// <para>
        /// Set this attribute to True to capture change data using the Binary Reader utility.
        /// Set <c>UseLogminerReader</c> to False to set this attribute to True. To use Binary
        /// Reader with Amazon RDS for Oracle as the source, you set additional attributes. For
        /// more information about using this setting with Oracle Automatic Storage Management
        /// (ASM), see <a href="https://docs.aws.amazon.com/dms/latest/userguide/CHAP_Source.Oracle.html#CHAP_Source.Oracle.CDC">
        /// Using Oracle LogMiner or DMS Binary Reader for CDC</a>.
        /// </para>
        /// </summary>
        public bool? UseBFile
        {
            get { return this._useBFile; }
            set { this._useBFile = value; }
        }

        // Check to see if UseBFile property is set
        internal bool IsSetUseBFile()
        {
            return this._useBFile.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property UseDirectPathFullLoad. 
        /// <para>
        /// Set this attribute to True to have DMS use a direct path full load. Specify this value
        /// to use the direct path protocol in the Oracle Call Interface (OCI). By using this
        /// OCI protocol, you can bulk-load Oracle target tables during a full load.
        /// </para>
        /// </summary>
        public bool? UseDirectPathFullLoad
        {
            get { return this._useDirectPathFullLoad; }
            set { this._useDirectPathFullLoad = value; }
        }

        // Check to see if UseDirectPathFullLoad property is set
        internal bool IsSetUseDirectPathFullLoad()
        {
            return this._useDirectPathFullLoad.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property UseLogminerReader. 
        /// <para>
        /// Set this attribute to True to capture change data using the Oracle LogMiner utility
        /// (the default). Set this attribute to False if you want to access the redo logs as
        /// a binary file. When you set <c>UseLogminerReader</c> to False, also set <c>UseBfile</c>
        /// to True. For more information on this setting and using Oracle ASM, see <a href="https://docs.aws.amazon.com/dms/latest/userguide/CHAP_Source.Oracle.html#CHAP_Source.Oracle.CDC">
        /// Using Oracle LogMiner or DMS Binary Reader for CDC</a> in the <i>DMS User Guide</i>.
        /// </para>
        /// </summary>
        public bool? UseLogminerReader
        {
            get { return this._useLogminerReader; }
            set { this._useLogminerReader = value; }
        }

        // Check to see if UseLogminerReader property is set
        internal bool IsSetUseLogminerReader()
        {
            return this._useLogminerReader.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property UsePathPrefix. 
        /// <para>
        /// Set this string attribute to the required value in order to use the Binary Reader
        /// to capture change data for an Amazon RDS for Oracle as the source. This value specifies
        /// the path prefix used to replace the default Oracle root to access the redo logs.
        /// </para>
        /// </summary>
        public string UsePathPrefix
        {
            get { return this._usePathPrefix; }
            set { this._usePathPrefix = value; }
        }

        // Check to see if UsePathPrefix property is set
        internal bool IsSetUsePathPrefix()
        {
            return this._usePathPrefix != null;
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