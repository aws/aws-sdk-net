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
    /// Provides information that defines a DocumentDB endpoint.
    /// </summary>
    public partial class DocDbSettings
    {
        private string _databaseName;
        private int? _docsToInvestigate;
        private bool? _extractDocId;
        private string _kmsKeyId;
        private NestingLevelValue _nestingLevel;
        private string _password;
        private int? _port;
        private bool? _replicateShardCollections;
        private string _secretsManagerAccessRoleArn;
        private string _secretsManagerSecretId;
        private string _serverName;
        private string _username;
        private bool? _useUpdateLookUp;

        /// <summary>
        /// Gets and sets the property DatabaseName. 
        /// <para>
        ///  The database name on the DocumentDB source endpoint. 
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
        /// Gets and sets the property DocsToInvestigate. 
        /// <para>
        ///  Indicates the number of documents to preview to determine the document organization.
        /// Use this setting when <c>NestingLevel</c> is set to <c>"one"</c>. 
        /// </para>
        ///  
        /// <para>
        /// Must be a positive value greater than <c>0</c>. Default value is <c>1000</c>.
        /// </para>
        /// </summary>
        public int? DocsToInvestigate
        {
            get { return this._docsToInvestigate; }
            set { this._docsToInvestigate = value; }
        }

        // Check to see if DocsToInvestigate property is set
        internal bool IsSetDocsToInvestigate()
        {
            return this._docsToInvestigate.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property ExtractDocId. 
        /// <para>
        ///  Specifies the document ID. Use this setting when <c>NestingLevel</c> is set to <c>"none"</c>.
        /// 
        /// </para>
        ///  
        /// <para>
        /// Default value is <c>"false"</c>. 
        /// </para>
        /// </summary>
        public bool? ExtractDocId
        {
            get { return this._extractDocId; }
            set { this._extractDocId = value; }
        }

        // Check to see if ExtractDocId property is set
        internal bool IsSetExtractDocId()
        {
            return this._extractDocId.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property KmsKeyId. 
        /// <para>
        /// The KMS key identifier that is used to encrypt the content on the replication instance.
        /// If you don't specify a value for the <c>KmsKeyId</c> parameter, then DMS uses your
        /// default encryption key. KMS creates the default encryption key for your Amazon Web
        /// Services account. Your Amazon Web Services account has a different default encryption
        /// key for each Amazon Web Services Region.
        /// </para>
        /// </summary>
        public string KmsKeyId
        {
            get { return this._kmsKeyId; }
            set { this._kmsKeyId = value; }
        }

        // Check to see if KmsKeyId property is set
        internal bool IsSetKmsKeyId()
        {
            return this._kmsKeyId != null;
        }

        /// <summary>
        /// Gets and sets the property NestingLevel. 
        /// <para>
        ///  Specifies either document or table mode. 
        /// </para>
        ///  
        /// <para>
        /// Default value is <c>"none"</c>. Specify <c>"none"</c> to use document mode. Specify
        /// <c>"one"</c> to use table mode.
        /// </para>
        /// </summary>
        public NestingLevelValue NestingLevel
        {
            get { return this._nestingLevel; }
            set { this._nestingLevel = value; }
        }

        // Check to see if NestingLevel property is set
        internal bool IsSetNestingLevel()
        {
            return this._nestingLevel != null;
        }

        /// <summary>
        /// Gets and sets the property Password. 
        /// <para>
        ///  The password for the user account you use to access the DocumentDB source endpoint.
        /// 
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
        ///  The port value for the DocumentDB source endpoint. 
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
        /// Gets and sets the property ReplicateShardCollections. 
        /// <para>
        /// If <c>true</c>, DMS replicates data to shard collections. DMS only uses this setting
        /// if the target endpoint is a DocumentDB elastic cluster.
        /// </para>
        ///  
        /// <para>
        /// When this setting is <c>true</c>, note the following:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// You must set <c>TargetTablePrepMode</c> to <c>nothing</c>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// DMS automatically sets <c>useUpdateLookup</c> to <c>false</c>.
        /// </para>
        ///  </li> </ul>
        /// </summary>
        public bool? ReplicateShardCollections
        {
            get { return this._replicateShardCollections; }
            set { this._replicateShardCollections = value; }
        }

        // Check to see if ReplicateShardCollections property is set
        internal bool IsSetReplicateShardCollections()
        {
            return this._replicateShardCollections.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property SecretsManagerAccessRoleArn. 
        /// <para>
        /// The full Amazon Resource Name (ARN) of the IAM role that specifies DMS as the trusted
        /// entity and grants the required permissions to access the value in <c>SecretsManagerSecret</c>.
        /// The role must allow the <c>iam:PassRole</c> action. <c>SecretsManagerSecret</c> has
        /// the value of the Amazon Web Services Secrets Manager secret that allows access to
        /// the DocumentDB endpoint.
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
        /// contains the DocumentDB endpoint connection details.
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
        ///  The name of the server on the DocumentDB source endpoint. 
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
        /// Gets and sets the property Username. 
        /// <para>
        /// The user name you use to access the DocumentDB source endpoint. 
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
        /// Gets and sets the property UseUpdateLookUp. 
        /// <para>
        /// If <c>true</c>, DMS retrieves the entire document from the DocumentDB source during
        /// migration. This may cause a migration failure if the server response exceeds bandwidth
        /// limits. To fetch only updates and deletes during migration, set this parameter to
        /// <c>false</c>.
        /// </para>
        /// </summary>
        public bool? UseUpdateLookUp
        {
            get { return this._useUpdateLookUp; }
            set { this._useUpdateLookUp = value; }
        }

        // Check to see if UseUpdateLookUp property is set
        internal bool IsSetUseUpdateLookUp()
        {
            return this._useUpdateLookUp.HasValue; 
        }

    }
}