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
    /// Provides information that defines an Oracle endpoint.
    /// </summary>
    public partial class OracleSettings
    {
        /// <summary>
        /// Gets and sets the property AccessAlternateDirectly. 
        /// <para>
        /// Set this attribute to <c>false</c> in order to use the Binary Reader to capture change
        /// data for an Amazon RDS for Oracle as the source. This tells the DMS instance to not
        /// access redo logs through any specified path prefix replacement using direct file access.
        /// </para>
        /// </summary>
        public bool? AccessAlternateDirectly { get; set; }

        /// <summary>
        /// Checks to see if the AccessAlternateDirectly property is set.
        /// </summary>
        internal bool IsSetAccessAlternateDirectly() => this.AccessAlternateDirectly.HasValue;

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
        public bool? AddSupplementalLogging { get; set; }

        /// <summary>
        /// Checks to see if the AddSupplementalLogging property is set.
        /// </summary>
        internal bool IsSetAddSupplementalLogging() => this.AddSupplementalLogging.HasValue;

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
        public int? AdditionalArchivedLogDestId { get; set; }

        /// <summary>
        /// Checks to see if the AdditionalArchivedLogDestId property is set.
        /// </summary>
        internal bool IsSetAdditionalArchivedLogDestId() => this.AdditionalArchivedLogDestId.HasValue;

        /// <summary>
        /// Gets and sets the property AllowSelectNestedTables. 
        /// <para>
        /// Set this attribute to <c>true</c> to enable replication of Oracle tables containing
        /// columns that are nested tables or defined types.
        /// </para>
        /// </summary>
        public bool? AllowSelectNestedTables { get; set; }

        /// <summary>
        /// Checks to see if the AllowSelectNestedTables property is set.
        /// </summary>
        internal bool IsSetAllowSelectNestedTables() => this.AllowSelectNestedTables.HasValue;

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
        public int? ArchivedLogDestId { get; set; }

        /// <summary>
        /// Checks to see if the ArchivedLogDestId property is set.
        /// </summary>
        internal bool IsSetArchivedLogDestId() => this.ArchivedLogDestId.HasValue;

        /// <summary>
        /// Gets and sets the property ArchivedLogsOnly. 
        /// <para>
        /// When this field is set to <c>True</c>, DMS only accesses the archived redo logs. If
        /// the archived redo logs are stored on Automatic Storage Management (ASM) only, the
        /// DMS user account needs to be granted ASM privileges.
        /// </para>
        /// </summary>
        public bool? ArchivedLogsOnly { get; set; }

        /// <summary>
        /// Checks to see if the ArchivedLogsOnly property is set.
        /// </summary>
        internal bool IsSetArchivedLogsOnly() => this.ArchivedLogsOnly.HasValue;

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
        [AWSProperty(Sensitive = true)]
        public string AsmPassword { get; set; }

        /// <summary>
        /// Checks to see if the AsmPassword property is set.
        /// </summary>
        internal bool IsSetAsmPassword() => this.AsmPassword != null;

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
        public string AsmServer { get; set; }

        /// <summary>
        /// Checks to see if the AsmServer property is set.
        /// </summary>
        internal bool IsSetAsmServer() => this.AsmServer != null;

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
        public string AsmUser { get; set; }

        /// <summary>
        /// Checks to see if the AsmUser property is set.
        /// </summary>
        internal bool IsSetAsmUser() => this.AsmUser != null;

        /// <summary>
        /// Gets and sets the property AuthenticationMethod. 
        /// <para>
        /// Specifies the authentication method to be used with Oracle.
        /// </para>
        /// </summary>
        public OracleAuthenticationMethod AuthenticationMethod { get; set; }

        /// <summary>
        /// Checks to see if the AuthenticationMethod property is set.
        /// </summary>
        internal bool IsSetAuthenticationMethod() => this.AuthenticationMethod != null;

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
        public CharLengthSemantics CharLengthSemantics { get; set; }

        /// <summary>
        /// Checks to see if the CharLengthSemantics property is set.
        /// </summary>
        internal bool IsSetCharLengthSemantics() => this.CharLengthSemantics != null;

        /// <summary>
        /// Gets and sets the property ConvertTimestampWithZoneToUTC. 
        /// <para>
        /// When true, converts timestamps with the <c>timezone</c> datatype to their UTC value.
        /// </para>
        /// </summary>
        public bool? ConvertTimestampWithZoneToUTC { get; set; }

        /// <summary>
        /// Checks to see if the ConvertTimestampWithZoneToUTC property is set.
        /// </summary>
        internal bool IsSetConvertTimestampWithZoneToUTC() => this.ConvertTimestampWithZoneToUTC.HasValue;

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
        /// Gets and sets the property DirectPathNoLog. 
        /// <para>
        /// When set to <c>true</c>, this attribute helps to increase the commit rate on the Oracle
        /// target database by writing directly to tables and not writing a trail to database
        /// logs.
        /// </para>
        /// </summary>
        public bool? DirectPathNoLog { get; set; }

        /// <summary>
        /// Checks to see if the DirectPathNoLog property is set.
        /// </summary>
        internal bool IsSetDirectPathNoLog() => this.DirectPathNoLog.HasValue;

        /// <summary>
        /// Gets and sets the property DirectPathParallelLoad. 
        /// <para>
        /// When set to <c>true</c>, this attribute specifies a parallel load when <c>useDirectPathFullLoad</c>
        /// is set to <c>Y</c>. This attribute also only applies when you use the DMS parallel
        /// load feature. Note that the target table cannot have any constraints or indexes.
        /// </para>
        /// </summary>
        public bool? DirectPathParallelLoad { get; set; }

        /// <summary>
        /// Checks to see if the DirectPathParallelLoad property is set.
        /// </summary>
        internal bool IsSetDirectPathParallelLoad() => this.DirectPathParallelLoad.HasValue;

        /// <summary>
        /// Gets and sets the property EnableHomogenousTablespace. 
        /// <para>
        /// Set this attribute to enable homogenous tablespace replication and create existing
        /// tables or indexes under the same tablespace on the target.
        /// </para>
        /// </summary>
        public bool? EnableHomogenousTablespace { get; set; }

        /// <summary>
        /// Checks to see if the EnableHomogenousTablespace property is set.
        /// </summary>
        internal bool IsSetEnableHomogenousTablespace() => this.EnableHomogenousTablespace.HasValue;

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
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<int> ExtraArchivedLogDestIds { get; set; } = AWSConfigs.InitializeCollections ? new List<int>() : null;

        /// <summary>
        /// Checks to see if the ExtraArchivedLogDestIds property is set.
        /// </summary>
        internal bool IsSetExtraArchivedLogDestIds() => this.ExtraArchivedLogDestIds != null && (this.ExtraArchivedLogDestIds.Count > 0 || !AWSConfigs.InitializeCollections);

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
        public bool? FailTasksOnLobTruncation { get; set; }

        /// <summary>
        /// Checks to see if the FailTasksOnLobTruncation property is set.
        /// </summary>
        internal bool IsSetFailTasksOnLobTruncation() => this.FailTasksOnLobTruncation.HasValue;

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
        public int? NumberDatatypeScale { get; set; }

        /// <summary>
        /// Checks to see if the NumberDatatypeScale property is set.
        /// </summary>
        internal bool IsSetNumberDatatypeScale() => this.NumberDatatypeScale.HasValue;

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
        public int? OpenTransactionWindow { get; set; }

        /// <summary>
        /// Checks to see if the OpenTransactionWindow property is set.
        /// </summary>
        internal bool IsSetOpenTransactionWindow() => this.OpenTransactionWindow.HasValue;

        /// <summary>
        /// Gets and sets the property OraclePathPrefix. 
        /// <para>
        /// Set this string attribute to the required value in order to use the Binary Reader
        /// to capture change data for an Amazon RDS for Oracle as the source. This value specifies
        /// the default Oracle root used to access the redo logs.
        /// </para>
        /// </summary>
        public string OraclePathPrefix { get; set; }

        /// <summary>
        /// Checks to see if the OraclePathPrefix property is set.
        /// </summary>
        internal bool IsSetOraclePathPrefix() => this.OraclePathPrefix != null;

        /// <summary>
        /// Gets and sets the property ParallelAsmReadThreads. 
        /// <para>
        /// Set this attribute to change the number of threads that DMS configures to perform
        /// a change data capture (CDC) load using Oracle Automatic Storage Management (ASM).
        /// You can specify an integer value between 2 (the default) and 8 (the maximum). Use
        /// this attribute together with the <c>readAheadBlocks</c> attribute.
        /// </para>
        /// </summary>
        public int? ParallelAsmReadThreads { get; set; }

        /// <summary>
        /// Checks to see if the ParallelAsmReadThreads property is set.
        /// </summary>
        internal bool IsSetParallelAsmReadThreads() => this.ParallelAsmReadThreads.HasValue;

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
        /// Gets and sets the property Port. 
        /// <para>
        /// Endpoint TCP port.
        /// </para>
        /// </summary>
        public int? Port { get; set; }

        /// <summary>
        /// Checks to see if the Port property is set.
        /// </summary>
        internal bool IsSetPort() => this.Port.HasValue;

        /// <summary>
        /// Gets and sets the property ReadAheadBlocks. 
        /// <para>
        /// Set this attribute to change the number of read-ahead blocks that DMS configures to
        /// perform a change data capture (CDC) load using Oracle Automatic Storage Management
        /// (ASM). You can specify an integer value between 1000 (the default) and 200,000 (the
        /// maximum).
        /// </para>
        /// </summary>
        public int? ReadAheadBlocks { get; set; }

        /// <summary>
        /// Checks to see if the ReadAheadBlocks property is set.
        /// </summary>
        internal bool IsSetReadAheadBlocks() => this.ReadAheadBlocks.HasValue;

        /// <summary>
        /// Gets and sets the property ReadTableSpaceName. 
        /// <para>
        /// When set to <c>true</c>, this attribute supports tablespace replication.
        /// </para>
        /// </summary>
        public bool? ReadTableSpaceName { get; set; }

        /// <summary>
        /// Checks to see if the ReadTableSpaceName property is set.
        /// </summary>
        internal bool IsSetReadTableSpaceName() => this.ReadTableSpaceName.HasValue;

        /// <summary>
        /// Gets and sets the property ReplacePathPrefix. 
        /// <para>
        /// Set this attribute to true in order to use the Binary Reader to capture change data
        /// for an Amazon RDS for Oracle as the source. This setting tells DMS instance to replace
        /// the default Oracle root with the specified <c>usePathPrefix</c> setting to access
        /// the redo logs.
        /// </para>
        /// </summary>
        public bool? ReplacePathPrefix { get; set; }

        /// <summary>
        /// Checks to see if the ReplacePathPrefix property is set.
        /// </summary>
        internal bool IsSetReplacePathPrefix() => this.ReplacePathPrefix.HasValue;

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
        public int? RetryInterval { get; set; }

        /// <summary>
        /// Checks to see if the RetryInterval property is set.
        /// </summary>
        internal bool IsSetRetryInterval() => this.RetryInterval.HasValue;

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
        public string SecretsManagerAccessRoleArn { get; set; }

        /// <summary>
        /// Checks to see if the SecretsManagerAccessRoleArn property is set.
        /// </summary>
        internal bool IsSetSecretsManagerAccessRoleArn() => this.SecretsManagerAccessRoleArn != null;

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
        public string SecretsManagerOracleAsmAccessRoleArn { get; set; }

        /// <summary>
        /// Checks to see if the SecretsManagerOracleAsmAccessRoleArn property is set.
        /// </summary>
        internal bool IsSetSecretsManagerOracleAsmAccessRoleArn() => this.SecretsManagerOracleAsmAccessRoleArn != null;

        /// <summary>
        /// Gets and sets the property SecretsManagerOracleAsmSecretId. 
        /// <para>
        /// Required only if your Oracle endpoint uses Automatic Storage Management (ASM). The
        /// full ARN, partial ARN, or friendly name of the <c>SecretsManagerOracleAsmSecret</c>
        /// that contains the Oracle ASM connection details for the Oracle endpoint.
        /// </para>
        /// </summary>
        public string SecretsManagerOracleAsmSecretId { get; set; }

        /// <summary>
        /// Checks to see if the SecretsManagerOracleAsmSecretId property is set.
        /// </summary>
        internal bool IsSetSecretsManagerOracleAsmSecretId() => this.SecretsManagerOracleAsmSecretId != null;

        /// <summary>
        /// Gets and sets the property SecretsManagerSecretId. 
        /// <para>
        /// The full ARN, partial ARN, or friendly name of the <c>SecretsManagerSecret</c> that
        /// contains the Oracle endpoint connection details.
        /// </para>
        /// </summary>
        public string SecretsManagerSecretId { get; set; }

        /// <summary>
        /// Checks to see if the SecretsManagerSecretId property is set.
        /// </summary>
        internal bool IsSetSecretsManagerSecretId() => this.SecretsManagerSecretId != null;

        /// <summary>
        /// Gets and sets the property SecurityDbEncryption. 
        /// <para>
        /// For an Oracle source endpoint, the transparent data encryption (TDE) password required
        /// by DMS to access Oracle redo logs encrypted by TDE using Binary Reader. It is also
        /// the <c> <i>TDE_Password</i> </c> part of the comma-separated value you set to the
        /// <c>Password</c> request parameter when you create the endpoint. The <c>SecurityDbEncryption</c>
        /// setting is related to this <c>SecurityDbEncryptionName</c> setting. For more information,
        /// see <a href="https://docs.aws.amazon.com/dms/latest/userguide/CHAP_Source.Oracle.html#CHAP_Source.Oracle.Encryption">
        /// Supported encryption methods for using Oracle as a source for DMS </a> in the <i>Database
        /// Migration Service User Guide</i>. 
        /// </para>
        /// </summary>
        [AWSProperty(Sensitive = true)]
        public string SecurityDbEncryption { get; set; }

        /// <summary>
        /// Checks to see if the SecurityDbEncryption property is set.
        /// </summary>
        internal bool IsSetSecurityDbEncryption() => this.SecurityDbEncryption != null;

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
        public string SecurityDbEncryptionName { get; set; }

        /// <summary>
        /// Checks to see if the SecurityDbEncryptionName property is set.
        /// </summary>
        internal bool IsSetSecurityDbEncryptionName() => this.SecurityDbEncryptionName != null;

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
        public string ServerName { get; set; }

        /// <summary>
        /// Checks to see if the ServerName property is set.
        /// </summary>
        internal bool IsSetServerName() => this.ServerName != null;

        /// <summary>
        /// Gets and sets the property SpatialDataOptionToGeoJsonFunctionName. 
        /// <para>
        /// Use this attribute to convert <c>SDO_GEOMETRY</c> to <c>GEOJSON</c> format. By default,
        /// DMS calls the <c>SDO2GEOJSON</c> custom function if present and accessible. Or you
        /// can create your own custom function that mimics the operation of <c>SDOGEOJSON</c>
        /// and set <c>SpatialDataOptionToGeoJsonFunctionName</c> to call it instead. 
        /// </para>
        /// </summary>
        public string SpatialDataOptionToGeoJsonFunctionName { get; set; }

        /// <summary>
        /// Checks to see if the SpatialDataOptionToGeoJsonFunctionName property is set.
        /// </summary>
        internal bool IsSetSpatialDataOptionToGeoJsonFunctionName() => this.SpatialDataOptionToGeoJsonFunctionName != null;

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
        public int? StandbyDelayTime { get; set; }

        /// <summary>
        /// Checks to see if the StandbyDelayTime property is set.
        /// </summary>
        internal bool IsSetStandbyDelayTime() => this.StandbyDelayTime.HasValue;

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
        /// Gets and sets the property UseAlternateFolderForOnline. 
        /// <para>
        /// Set this attribute to <c>true</c> in order to use the Binary Reader to capture change
        /// data for an Amazon RDS for Oracle as the source. This tells the DMS instance to use
        /// any specified prefix replacement to access all online redo logs.
        /// </para>
        /// </summary>
        public bool? UseAlternateFolderForOnline { get; set; }

        /// <summary>
        /// Checks to see if the UseAlternateFolderForOnline property is set.
        /// </summary>
        internal bool IsSetUseAlternateFolderForOnline() => this.UseAlternateFolderForOnline.HasValue;

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
        public bool? UseBFile { get; set; }

        /// <summary>
        /// Checks to see if the UseBFile property is set.
        /// </summary>
        internal bool IsSetUseBFile() => this.UseBFile.HasValue;

        /// <summary>
        /// Gets and sets the property UseDirectPathFullLoad. 
        /// <para>
        /// Set this attribute to True to have DMS use a direct path full load. Specify this value
        /// to use the direct path protocol in the Oracle Call Interface (OCI). By using this
        /// OCI protocol, you can bulk-load Oracle target tables during a full load.
        /// </para>
        /// </summary>
        public bool? UseDirectPathFullLoad { get; set; }

        /// <summary>
        /// Checks to see if the UseDirectPathFullLoad property is set.
        /// </summary>
        internal bool IsSetUseDirectPathFullLoad() => this.UseDirectPathFullLoad.HasValue;

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
        public bool? UseLogminerReader { get; set; }

        /// <summary>
        /// Checks to see if the UseLogminerReader property is set.
        /// </summary>
        internal bool IsSetUseLogminerReader() => this.UseLogminerReader.HasValue;

        /// <summary>
        /// Gets and sets the property UsePathPrefix. 
        /// <para>
        /// Set this string attribute to the required value in order to use the Binary Reader
        /// to capture change data for an Amazon RDS for Oracle as the source. This value specifies
        /// the path prefix used to replace the default Oracle root to access the redo logs.
        /// </para>
        /// </summary>
        public string UsePathPrefix { get; set; }

        /// <summary>
        /// Checks to see if the UsePathPrefix property is set.
        /// </summary>
        internal bool IsSetUsePathPrefix() => this.UsePathPrefix != null;

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
