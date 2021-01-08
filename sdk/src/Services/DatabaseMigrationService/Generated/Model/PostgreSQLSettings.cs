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
    /// Provides information that defines a PostgreSQL endpoint.
    /// </summary>
    public partial class PostgreSQLSettings
    {
        private string _afterConnectScript;
        private bool? _captureDdls;
        private string _databaseName;
        private string _ddlArtifactsSchema;
        private int? _executeTimeout;
        private bool? _failTasksOnLobTruncation;
        private int? _maxFileSize;
        private string _password;
        private int? _port;
        private string _secretsManagerAccessRoleArn;
        private string _secretsManagerSecretId;
        private string _serverName;
        private string _slotName;
        private string _username;

        /// <summary>
        /// Gets and sets the property AfterConnectScript. 
        /// <para>
        /// For use with change data capture (CDC) only, this attribute has AWS DMS bypass foreign
        /// keys and user triggers to reduce the time it takes to bulk load data.
        /// </para>
        ///  
        /// <para>
        /// Example: <code>afterConnectScript=SET session_replication_role='replica'</code> 
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
        /// Gets and sets the property CaptureDdls. 
        /// <para>
        /// To capture DDL events, AWS DMS creates various artifacts in the PostgreSQL database
        /// when the task starts. You can later remove these artifacts.
        /// </para>
        ///  
        /// <para>
        /// If this value is set to <code>N</code>, you don't have to create tables or triggers
        /// on the source database.
        /// </para>
        /// </summary>
        public bool CaptureDdls
        {
            get { return this._captureDdls.GetValueOrDefault(); }
            set { this._captureDdls = value; }
        }

        // Check to see if CaptureDdls property is set
        internal bool IsSetCaptureDdls()
        {
            return this._captureDdls.HasValue; 
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
        /// Example: <code>ddlArtifactsSchema=xyzddlschema;</code> 
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
        /// Gets and sets the property ExecuteTimeout. 
        /// <para>
        /// Sets the client statement timeout for the PostgreSQL instance, in seconds. The default
        /// value is 60 seconds.
        /// </para>
        ///  
        /// <para>
        /// Example: <code>executeTimeout=100;</code> 
        /// </para>
        /// </summary>
        public int ExecuteTimeout
        {
            get { return this._executeTimeout.GetValueOrDefault(); }
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
        /// When set to <code>true</code>, this value causes a task to fail if the actual size
        /// of a LOB column is greater than the specified <code>LobMaxSize</code>.
        /// </para>
        ///  
        /// <para>
        /// If task is set to Limited LOB mode and this option is set to true, the task fails
        /// instead of truncating the LOB data.
        /// </para>
        /// </summary>
        public bool FailTasksOnLobTruncation
        {
            get { return this._failTasksOnLobTruncation.GetValueOrDefault(); }
            set { this._failTasksOnLobTruncation = value; }
        }

        // Check to see if FailTasksOnLobTruncation property is set
        internal bool IsSetFailTasksOnLobTruncation()
        {
            return this._failTasksOnLobTruncation.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property MaxFileSize. 
        /// <para>
        /// Specifies the maximum size (in KB) of any .csv file used to transfer data to PostgreSQL.
        /// </para>
        ///  
        /// <para>
        /// Example: <code>maxFileSize=512</code> 
        /// </para>
        /// </summary>
        public int MaxFileSize
        {
            get { return this._maxFileSize.GetValueOrDefault(); }
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
        /// Gets and sets the property SecretsManagerAccessRoleArn. 
        /// <para>
        /// The full Amazon Resource Name (ARN) of the IAM role that specifies AWS DMS as the
        /// trusted entity and grants the required permissions to access the value in <code>SecretsManagerSecret</code>.
        /// <code>SecretsManagerSecret</code> has the value of the AWS Secrets Manager secret
        /// that allows access to the PostgreSQL endpoint.
        /// </para>
        ///  <note> 
        /// <para>
        /// You can specify one of two sets of values for these permissions. You can specify the
        /// values for this setting and <code>SecretsManagerSecretId</code>. Or you can specify
        /// clear-text values for <code>UserName</code>, <code>Password</code>, <code>ServerName</code>,
        /// and <code>Port</code>. You can't specify both. For more information on creating this
        /// <code>SecretsManagerSecret</code> and the <code>SecretsManagerAccessRoleArn</code>
        /// and <code>SecretsManagerSecretId</code> required to access it, see <a href="https://docs.aws.amazon.com/https:/docs.aws.amazon.com/dms/latest/userguide/CHAP_Security.html#security-iam-secretsmanager">Using
        /// secrets to access AWS Database Migration Service resources</a> in the <i>AWS Database
        /// Migration Service User Guide</i>.
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
        /// that contains the PostgreSQL endpoint connection details.
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
        /// Fully qualified domain name of the endpoint.
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
        /// Gets and sets the property SlotName. 
        /// <para>
        /// Sets the name of a previously created logical replication slot for a CDC load of the
        /// PostgreSQL source instance.
        /// </para>
        ///  
        /// <para>
        /// When used with the AWS DMS API <code>CdcStartPosition</code> request parameter, this
        /// attribute also enables using native CDC start points.
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