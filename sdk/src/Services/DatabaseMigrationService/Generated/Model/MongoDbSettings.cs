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
    /// Provides information that defines a MongoDB endpoint.
    /// </summary>
    public partial class MongoDbSettings
    {
        private AuthMechanismValue _authMechanism;
        private string _authSource;
        private AuthTypeValue _authType;
        private string _databaseName;
        private string _docsToInvestigate;
        private string _extractDocId;
        private string _kmsKeyId;
        private NestingLevelValue _nestingLevel;
        private string _password;
        private int? _port;
        private string _secretsManagerAccessRoleArn;
        private string _secretsManagerSecretId;
        private string _serverName;
        private string _username;

        /// <summary>
        /// Gets and sets the property AuthMechanism. 
        /// <para>
        ///  The authentication mechanism you use to access the MongoDB source endpoint.
        /// </para>
        ///  
        /// <para>
        /// For the default value, in MongoDB version 2.x, <code>"default"</code> is <code>"mongodb_cr"</code>.
        /// For MongoDB version 3.x or later, <code>"default"</code> is <code>"scram_sha_1"</code>.
        /// This setting isn't used when <code>AuthType</code> is set to <code>"no"</code>.
        /// </para>
        /// </summary>
        public AuthMechanismValue AuthMechanism
        {
            get { return this._authMechanism; }
            set { this._authMechanism = value; }
        }

        // Check to see if AuthMechanism property is set
        internal bool IsSetAuthMechanism()
        {
            return this._authMechanism != null;
        }

        /// <summary>
        /// Gets and sets the property AuthSource. 
        /// <para>
        ///  The MongoDB database name. This setting isn't used when <code>AuthType</code> is
        /// set to <code>"no"</code>. 
        /// </para>
        ///  
        /// <para>
        /// The default is <code>"admin"</code>.
        /// </para>
        /// </summary>
        public string AuthSource
        {
            get { return this._authSource; }
            set { this._authSource = value; }
        }

        // Check to see if AuthSource property is set
        internal bool IsSetAuthSource()
        {
            return this._authSource != null;
        }

        /// <summary>
        /// Gets and sets the property AuthType. 
        /// <para>
        ///  The authentication type you use to access the MongoDB source endpoint.
        /// </para>
        ///  
        /// <para>
        /// When when set to <code>"no"</code>, user name and password parameters are not used
        /// and can be empty. 
        /// </para>
        /// </summary>
        public AuthTypeValue AuthType
        {
            get { return this._authType; }
            set { this._authType = value; }
        }

        // Check to see if AuthType property is set
        internal bool IsSetAuthType()
        {
            return this._authType != null;
        }

        /// <summary>
        /// Gets and sets the property DatabaseName. 
        /// <para>
        ///  The database name on the MongoDB source endpoint. 
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
        /// Use this setting when <code>NestingLevel</code> is set to <code>"one"</code>. 
        /// </para>
        ///  
        /// <para>
        /// Must be a positive value greater than <code>0</code>. Default value is <code>1000</code>.
        /// </para>
        /// </summary>
        public string DocsToInvestigate
        {
            get { return this._docsToInvestigate; }
            set { this._docsToInvestigate = value; }
        }

        // Check to see if DocsToInvestigate property is set
        internal bool IsSetDocsToInvestigate()
        {
            return this._docsToInvestigate != null;
        }

        /// <summary>
        /// Gets and sets the property ExtractDocId. 
        /// <para>
        ///  Specifies the document ID. Use this setting when <code>NestingLevel</code> is set
        /// to <code>"none"</code>. 
        /// </para>
        ///  
        /// <para>
        /// Default value is <code>"false"</code>. 
        /// </para>
        /// </summary>
        public string ExtractDocId
        {
            get { return this._extractDocId; }
            set { this._extractDocId = value; }
        }

        // Check to see if ExtractDocId property is set
        internal bool IsSetExtractDocId()
        {
            return this._extractDocId != null;
        }

        /// <summary>
        /// Gets and sets the property KmsKeyId. 
        /// <para>
        /// The AWS KMS key identifier that is used to encrypt the content on the replication
        /// instance. If you don't specify a value for the <code>KmsKeyId</code> parameter, then
        /// AWS DMS uses your default encryption key. AWS KMS creates the default encryption key
        /// for your AWS account. Your AWS account has a different default encryption key for
        /// each AWS Region.
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
        /// Default value is <code>"none"</code>. Specify <code>"none"</code> to use document
        /// mode. Specify <code>"one"</code> to use table mode.
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
        ///  The password for the user account you use to access the MongoDB source endpoint.
        /// 
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
        ///  The port value for the MongoDB source endpoint. 
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
        /// that allows access to the MongoDB endpoint.
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
        /// that contains the MongoDB endpoint connection details.
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
        ///  The name of the server on the MongoDB source endpoint. 
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
        /// The user name you use to access the MongoDB source endpoint. 
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