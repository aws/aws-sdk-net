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
    /// Settings in JSON format for the source GCP MySQL endpoint.
    /// </summary>
    public partial class GcpMySQLSettings
    {
        private string _afterConnectScript;
        private bool? _cleanSourceMetadataOnMismatch;
        private string _databaseName;
        private int? _eventsPollInterval;
        private int? _maxFileSize;
        private int? _parallelLoadThreads;
        private string _password;
        private int? _port;
        private string _secretsManagerAccessRoleArn;
        private string _secretsManagerSecretId;
        private string _serverName;
        private string _serverTimezone;
        private TargetDbType _targetDbType;
        private string _username;

        /// <summary>
        /// Gets and sets the property AfterConnectScript. 
        /// <para>
        /// Specifies a script to run immediately after DMS connects to the endpoint. The migration
        /// task continues running regardless if the SQL statement succeeds or fails.
        /// </para>
        ///  
        /// <para>
        /// For this parameter, provide the code of the script itself, not the name of a file
        /// containing the script. 
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
        /// Gets and sets the property CleanSourceMetadataOnMismatch. 
        /// <para>
        /// Cleans and recreates table metadata information on the replication instance when a
        /// mismatch occurs. For example, in a situation where running an alter DDL on the table
        /// could result in different information about the table cached in the replication instance.
        /// 
        /// </para>
        /// </summary>
        public bool? CleanSourceMetadataOnMismatch
        {
            get { return this._cleanSourceMetadataOnMismatch; }
            set { this._cleanSourceMetadataOnMismatch = value; }
        }

        // Check to see if CleanSourceMetadataOnMismatch property is set
        internal bool IsSetCleanSourceMetadataOnMismatch()
        {
            return this._cleanSourceMetadataOnMismatch.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property DatabaseName. 
        /// <para>
        /// Database name for the endpoint. For a MySQL source or target endpoint, don't explicitly
        /// specify the database using the <c>DatabaseName</c> request parameter on either the
        /// <c>CreateEndpoint</c> or <c>ModifyEndpoint</c> API call. Specifying <c>DatabaseName</c>
        /// when you create or modify a MySQL endpoint replicates all the task tables to this
        /// single database. For MySQL endpoints, you specify the database only when you specify
        /// the schema in the table-mapping rules of the DMS task. 
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
        /// Gets and sets the property EventsPollInterval. 
        /// <para>
        /// Specifies how often to check the binary log for new changes/events when the database
        /// is idle. The default is five seconds.
        /// </para>
        ///  
        /// <para>
        /// Example: <c>eventsPollInterval=5;</c> 
        /// </para>
        ///  
        /// <para>
        /// In the example, DMS checks for changes in the binary logs every five seconds. 
        /// </para>
        /// </summary>
        public int? EventsPollInterval
        {
            get { return this._eventsPollInterval; }
            set { this._eventsPollInterval = value; }
        }

        // Check to see if EventsPollInterval property is set
        internal bool IsSetEventsPollInterval()
        {
            return this._eventsPollInterval.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property MaxFileSize. 
        /// <para>
        /// Specifies the maximum size (in KB) of any .csv file used to transfer data to a MySQL-compatible
        /// database.
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
        /// Gets and sets the property ParallelLoadThreads. 
        /// <para>
        /// Improves performance when loading data into the MySQL-compatible target database.
        /// Specifies how many threads to use to load the data into the MySQL-compatible target
        /// database. Setting a large number of threads can have an adverse effect on database
        /// performance, because a separate connection is required for each thread. The default
        /// is one.
        /// </para>
        ///  
        /// <para>
        /// Example: <c>parallelLoadThreads=1</c> 
        /// </para>
        /// </summary>
        public int? ParallelLoadThreads
        {
            get { return this._parallelLoadThreads; }
            set { this._parallelLoadThreads = value; }
        }

        // Check to see if ParallelLoadThreads property is set
        internal bool IsSetParallelLoadThreads()
        {
            return this._parallelLoadThreads.HasValue; 
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
        /// Gets and sets the property SecretsManagerAccessRoleArn. 
        /// <para>
        /// The full Amazon Resource Name (ARN) of the IAM role that specifies DMS as the trusted
        /// entity and grants the required permissions to access the value in <c>SecretsManagerSecret.</c>
        /// The role must allow the <c>iam:PassRole</c> action. <c>SecretsManagerSecret</c> has
        /// the value of the Amazon Web Services Secrets Manager secret that allows access to
        /// the MySQL endpoint.
        /// </para>
        ///  <note> 
        /// <para>
        /// You can specify one of two sets of values for these permissions. You can specify the
        /// values for this setting and <c>SecretsManagerSecretId</c>. Or you can specify clear-text
        /// values for <c>UserName</c>, <c>Password</c>, <c>ServerName</c>, and <c>Port</c>. You
        /// can't specify both. For more information on creating this <c>SecretsManagerSecret</c>
        /// and the <c>SecretsManagerAccessRoleArn</c> and <c>SecretsManagerSecretId</c> required
        /// to access it, see <a href="https://docs.aws.amazon.com/dms/latest/userguide/CHAP_Security.html#security-iam-secretsmanager">Using
        /// secrets to access Database Migration Service resources</a> in the Database Migration
        /// Service User Guide. 
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
        /// contains the MySQL endpoint connection details. 
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
        /// The MySQL host name.
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
        /// Gets and sets the property ServerTimezone. 
        /// <para>
        /// Specifies the time zone for the source MySQL database.
        /// </para>
        ///  
        /// <para>
        /// Example: <c>serverTimezone=US/Pacific;</c> 
        /// </para>
        ///  
        /// <para>
        /// Note: Do not enclose time zones in single quotes.
        /// </para>
        /// </summary>
        public string ServerTimezone
        {
            get { return this._serverTimezone; }
            set { this._serverTimezone = value; }
        }

        // Check to see if ServerTimezone property is set
        internal bool IsSetServerTimezone()
        {
            return this._serverTimezone != null;
        }

        /// <summary>
        /// Gets and sets the property TargetDbType. 
        /// <para>
        /// Specifies where to migrate source tables on the target, either to a single database
        /// or multiple databases.
        /// </para>
        ///  
        /// <para>
        /// Example: <c>targetDbType=MULTIPLE_DATABASES</c> 
        /// </para>
        /// </summary>
        public TargetDbType TargetDbType
        {
            get { return this._targetDbType; }
            set { this._targetDbType = value; }
        }

        // Check to see if TargetDbType property is set
        internal bool IsSetTargetDbType()
        {
            return this._targetDbType != null;
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