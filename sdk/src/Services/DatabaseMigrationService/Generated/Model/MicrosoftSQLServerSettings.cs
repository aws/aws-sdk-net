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
    /// Provides information that defines a Microsoft SQL Server endpoint.
    /// </summary>
    public partial class MicrosoftSQLServerSettings
    {
        private int? _bcpPacketSize;
        private string _controlTablesFileGroup;
        private string _databaseName;
        private string _password;
        private int? _port;
        private bool? _querySingleAlwaysOnNode;
        private bool? _readBackupOnly;
        private SafeguardPolicy _safeguardPolicy;
        private string _secretsManagerAccessRoleArn;
        private string _secretsManagerSecretId;
        private string _serverName;
        private bool? _trimSpaceInChar;
        private bool? _useBcpFullLoad;
        private string _username;
        private bool? _useThirdPartyBackupDevice;

        /// <summary>
        /// Gets and sets the property BcpPacketSize. 
        /// <para>
        /// The maximum size of the packets (in bytes) used to transfer data using BCP.
        /// </para>
        /// </summary>
        public int BcpPacketSize
        {
            get { return this._bcpPacketSize.GetValueOrDefault(); }
            set { this._bcpPacketSize = value; }
        }

        // Check to see if BcpPacketSize property is set
        internal bool IsSetBcpPacketSize()
        {
            return this._bcpPacketSize.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property ControlTablesFileGroup. 
        /// <para>
        /// Specifies a file group for the DMS internal tables. When the replication task starts,
        /// all the internal DMS control tables (awsdms_ apply_exception, awsdms_apply, awsdms_changes)
        /// are created for the specified file group.
        /// </para>
        /// </summary>
        public string ControlTablesFileGroup
        {
            get { return this._controlTablesFileGroup; }
            set { this._controlTablesFileGroup = value; }
        }

        // Check to see if ControlTablesFileGroup property is set
        internal bool IsSetControlTablesFileGroup()
        {
            return this._controlTablesFileGroup != null;
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
        /// Gets and sets the property QuerySingleAlwaysOnNode. 
        /// <para>
        /// Cleans and recreates table metadata information on the replication instance when a
        /// mismatch occurs. An example is a situation where running an alter DDL statement on
        /// a table might result in different information about the table cached in the replication
        /// instance.
        /// </para>
        /// </summary>
        public bool QuerySingleAlwaysOnNode
        {
            get { return this._querySingleAlwaysOnNode.GetValueOrDefault(); }
            set { this._querySingleAlwaysOnNode = value; }
        }

        // Check to see if QuerySingleAlwaysOnNode property is set
        internal bool IsSetQuerySingleAlwaysOnNode()
        {
            return this._querySingleAlwaysOnNode.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property ReadBackupOnly. 
        /// <para>
        /// When this attribute is set to <code>Y</code>, DMS only reads changes from transaction
        /// log backups and doesn't read from the active transaction log file during ongoing replication.
        /// Setting this parameter to <code>Y</code> enables you to control active transaction
        /// log file growth during full load and ongoing replication tasks. However, it can add
        /// some source latency to ongoing replication.
        /// </para>
        /// </summary>
        public bool ReadBackupOnly
        {
            get { return this._readBackupOnly.GetValueOrDefault(); }
            set { this._readBackupOnly = value; }
        }

        // Check to see if ReadBackupOnly property is set
        internal bool IsSetReadBackupOnly()
        {
            return this._readBackupOnly.HasValue; 
        }

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
        public SafeguardPolicy SafeguardPolicy
        {
            get { return this._safeguardPolicy; }
            set { this._safeguardPolicy = value; }
        }

        // Check to see if SafeguardPolicy property is set
        internal bool IsSetSafeguardPolicy()
        {
            return this._safeguardPolicy != null;
        }

        /// <summary>
        /// Gets and sets the property SecretsManagerAccessRoleArn. 
        /// <para>
        /// The full Amazon Resource Name (ARN) of the IAM role that specifies DMS as the trusted
        /// entity and grants the required permissions to access the value in <code>SecretsManagerSecret</code>.
        /// The role must allow the <code>iam:PassRole</code> action. <code>SecretsManagerSecret</code>
        /// has the value of the Amazon Web Services Secrets Manager secret that allows access
        /// to the SQL Server endpoint.
        /// </para>
        ///  <note> 
        /// <para>
        /// You can specify one of two sets of values for these permissions. You can specify the
        /// values for this setting and <code>SecretsManagerSecretId</code>. Or you can specify
        /// clear-text values for <code>UserName</code>, <code>Password</code>, <code>ServerName</code>,
        /// and <code>Port</code>. You can't specify both. For more information on creating this
        /// <code>SecretsManagerSecret</code> and the <code>SecretsManagerAccessRoleArn</code>
        /// and <code>SecretsManagerSecretId</code> required to access it, see <a href="https://docs.aws.amazon.com/dms/latest/userguide/CHAP_Security.html#security-iam-secretsmanager">Using
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
        /// The full ARN, partial ARN, or friendly name of the <code>SecretsManagerSecret</code>
        /// that contains the SQL Server endpoint connection details.
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
        /// Fully qualified domain name of the endpoint. For an Amazon RDS SQL Server instance,
        /// this is the output of <a href="https://docs.aws.amazon.com/AmazonRDS/latest/APIReference/API_DescribeDBInstances.html">DescribeDBInstances</a>,
        /// in the <code> <a href="https://docs.aws.amazon.com/AmazonRDS/latest/APIReference/API_Endpoint.html">Endpoint</a>.Address</code>
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
        /// Gets and sets the property TrimSpaceInChar. 
        /// <para>
        /// Use the <code>TrimSpaceInChar</code> source endpoint setting to trim data on CHAR
        /// and NCHAR data types during migration. The default value is <code>true</code>.
        /// </para>
        /// </summary>
        public bool TrimSpaceInChar
        {
            get { return this._trimSpaceInChar.GetValueOrDefault(); }
            set { this._trimSpaceInChar = value; }
        }

        // Check to see if TrimSpaceInChar property is set
        internal bool IsSetTrimSpaceInChar()
        {
            return this._trimSpaceInChar.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property UseBcpFullLoad. 
        /// <para>
        /// Use this to attribute to transfer data for full-load operations using BCP. When the
        /// target table contains an identity column that does not exist in the source table,
        /// you must disable the use BCP for loading table option.
        /// </para>
        /// </summary>
        public bool UseBcpFullLoad
        {
            get { return this._useBcpFullLoad.GetValueOrDefault(); }
            set { this._useBcpFullLoad = value; }
        }

        // Check to see if UseBcpFullLoad property is set
        internal bool IsSetUseBcpFullLoad()
        {
            return this._useBcpFullLoad.HasValue; 
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

        /// <summary>
        /// Gets and sets the property UseThirdPartyBackupDevice. 
        /// <para>
        /// When this attribute is set to <code>Y</code>, DMS processes third-party transaction
        /// log backups if they are created in native format.
        /// </para>
        /// </summary>
        public bool UseThirdPartyBackupDevice
        {
            get { return this._useThirdPartyBackupDevice.GetValueOrDefault(); }
            set { this._useThirdPartyBackupDevice = value; }
        }

        // Check to see if UseThirdPartyBackupDevice property is set
        internal bool IsSetUseThirdPartyBackupDevice()
        {
            return this._useThirdPartyBackupDevice.HasValue; 
        }

    }
}