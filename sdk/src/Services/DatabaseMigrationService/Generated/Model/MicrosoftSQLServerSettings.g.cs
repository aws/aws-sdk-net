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
    /// Provides information that defines a Microsoft SQL Server endpoint.
    /// </summary>
    public partial class MicrosoftSQLServerSettings
    {
        /// <summary>
        /// Gets and sets the property AuthenticationMethod. 
        /// <para>
        /// Specifies the authentication method to be used with Microsoft SQL Server.
        /// </para>
        /// </summary>
        public SqlServerAuthenticationMethod AuthenticationMethod { get; set; }

        /// <summary>
        /// Checks to see if the AuthenticationMethod property is set.
        /// </summary>
        internal bool IsSetAuthenticationMethod() => this.AuthenticationMethod != null;

        /// <summary>
        /// Gets and sets the property BcpPacketSize. 
        /// <para>
        /// The maximum size of the packets (in bytes) used to transfer data using BCP.
        /// </para>
        /// </summary>
        public int? BcpPacketSize { get; set; }

        /// <summary>
        /// Checks to see if the BcpPacketSize property is set.
        /// </summary>
        internal bool IsSetBcpPacketSize() => this.BcpPacketSize.HasValue;

        /// <summary>
        /// Gets and sets the property ControlTablesFileGroup. 
        /// <para>
        /// Specifies a file group for the DMS internal tables. When the replication task starts,
        /// all the internal DMS control tables (awsdms_ apply_exception, awsdms_apply, awsdms_changes)
        /// are created for the specified file group.
        /// </para>
        /// </summary>
        public string ControlTablesFileGroup { get; set; }

        /// <summary>
        /// Checks to see if the ControlTablesFileGroup property is set.
        /// </summary>
        internal bool IsSetControlTablesFileGroup() => this.ControlTablesFileGroup != null;

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
        /// Gets and sets the property ForceLobLookup. 
        /// <para>
        /// Forces LOB lookup on inline LOB.
        /// </para>
        /// </summary>
        public bool? ForceLobLookup { get; set; }

        /// <summary>
        /// Checks to see if the ForceLobLookup property is set.
        /// </summary>
        internal bool IsSetForceLobLookup() => this.ForceLobLookup.HasValue;

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
        /// Gets and sets the property QuerySingleAlwaysOnNode. 
        /// <para>
        /// Cleans and recreates table metadata information on the replication instance when a
        /// mismatch occurs. An example is a situation where running an alter DDL statement on
        /// a table might result in different information about the table cached in the replication
        /// instance.
        /// </para>
        /// </summary>
        public bool? QuerySingleAlwaysOnNode { get; set; }

        /// <summary>
        /// Checks to see if the QuerySingleAlwaysOnNode property is set.
        /// </summary>
        internal bool IsSetQuerySingleAlwaysOnNode() => this.QuerySingleAlwaysOnNode.HasValue;

        /// <summary>
        /// Gets and sets the property ReadBackupOnly. 
        /// <para>
        /// When this attribute is set to <c>Y</c>, DMS only reads changes from transaction log
        /// backups and doesn't read from the active transaction log file during ongoing replication.
        /// Setting this parameter to <c>Y</c> enables you to control active transaction log file
        /// growth during full load and ongoing replication tasks. However, it can add some source
        /// latency to ongoing replication.
        /// </para>
        /// </summary>
        public bool? ReadBackupOnly { get; set; }

        /// <summary>
        /// Checks to see if the ReadBackupOnly property is set.
        /// </summary>
        internal bool IsSetReadBackupOnly() => this.ReadBackupOnly.HasValue;

        /// <summary>
        /// Gets and sets the property SafeguardPolicy. 
        /// <para>
        /// Use this attribute to minimize the need to access the backup log and enable DMS to
        /// prevent truncation using one of the following two methods.
        /// </para>
        ///  
        /// <para>
        ///  <i>Start transactions in the database:</i> This is the default method. When this
        /// method is used, DMS prevents TLOG truncation by mimicking a transaction in the database.
        /// As long as such a transaction is open, changes that appear after the transaction started
        /// aren't truncated. If you need Microsoft Replication to be enabled in your database,
        /// then you must choose this method.
        /// </para>
        ///  
        /// <para>
        ///  <i>Exclusively use sp_repldone within a single task</i>: When this method is used,
        /// DMS reads the changes and then uses sp_repldone to mark the TLOG transactions as ready
        /// for truncation. Although this method doesn't involve any transactional activities,
        /// it can only be used when Microsoft Replication isn't running. Also, when using this
        /// method, only one DMS task can access the database at any given time. Therefore, if
        /// you need to run parallel DMS tasks against the same database, use the default method.
        /// </para>
        /// </summary>
        public SafeguardPolicy SafeguardPolicy { get; set; }

        /// <summary>
        /// Checks to see if the SafeguardPolicy property is set.
        /// </summary>
        internal bool IsSetSafeguardPolicy() => this.SafeguardPolicy != null;

        /// <summary>
        /// Gets and sets the property SecretsManagerAccessRoleArn. 
        /// <para>
        /// The full Amazon Resource Name (ARN) of the IAM role that specifies DMS as the trusted
        /// entity and grants the required permissions to access the value in <c>SecretsManagerSecret</c>.
        /// The role must allow the <c>iam:PassRole</c> action. <c>SecretsManagerSecret</c> has
        /// the value of the Amazon Web Services Secrets Manager secret that allows access to
        /// the SQL Server endpoint.
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
        /// contains the SQL Server endpoint connection details.
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
        /// Fully qualified domain name of the endpoint. For an Amazon RDS SQL Server instance,
        /// this is the output of <a href="https://docs.aws.amazon.com/AmazonRDS/latest/APIReference/API_DescribeDBInstances.html">DescribeDBInstances</a>,
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
        /// Gets and sets the property TlogAccessMode. 
        /// <para>
        /// Indicates the mode used to fetch CDC data.
        /// </para>
        /// </summary>
        public TlogAccessMode TlogAccessMode { get; set; }

        /// <summary>
        /// Checks to see if the TlogAccessMode property is set.
        /// </summary>
        internal bool IsSetTlogAccessMode() => this.TlogAccessMode != null;

        /// <summary>
        /// Gets and sets the property TrimSpaceInChar. 
        /// <para>
        /// Use the <c>TrimSpaceInChar</c> source endpoint setting to right-trim data on CHAR
        /// and NCHAR data types during migration. Setting <c>TrimSpaceInChar</c> does not left-trim
        /// data. The default value is <c>true</c>.
        /// </para>
        /// </summary>
        public bool? TrimSpaceInChar { get; set; }

        /// <summary>
        /// Checks to see if the TrimSpaceInChar property is set.
        /// </summary>
        internal bool IsSetTrimSpaceInChar() => this.TrimSpaceInChar.HasValue;

        /// <summary>
        /// Gets and sets the property UseBcpFullLoad. 
        /// <para>
        /// Use this to attribute to transfer data for full-load operations using BCP. When the
        /// target table contains an identity column that does not exist in the source table,
        /// you must disable the use BCP for loading table option.
        /// </para>
        /// </summary>
        public bool? UseBcpFullLoad { get; set; }

        /// <summary>
        /// Checks to see if the UseBcpFullLoad property is set.
        /// </summary>
        internal bool IsSetUseBcpFullLoad() => this.UseBcpFullLoad.HasValue;

        /// <summary>
        /// Gets and sets the property UseThirdPartyBackupDevice. 
        /// <para>
        /// When this attribute is set to <c>Y</c>, DMS processes third-party transaction log
        /// backups if they are created in native format.
        /// </para>
        /// </summary>
        public bool? UseThirdPartyBackupDevice { get; set; }

        /// <summary>
        /// Checks to see if the UseThirdPartyBackupDevice property is set.
        /// </summary>
        internal bool IsSetUseThirdPartyBackupDevice() => this.UseThirdPartyBackupDevice.HasValue;

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
