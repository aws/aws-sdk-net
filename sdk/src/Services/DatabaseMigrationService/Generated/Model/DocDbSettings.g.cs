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
    /// Provides information that defines a DocumentDB endpoint.
    /// </summary>
    public partial class DocDbSettings
    {
        /// <summary>
        /// Gets and sets the property DatabaseName. 
        /// <para>
        ///  The database name on the DocumentDB source endpoint. 
        /// </para>
        /// </summary>
        public string DatabaseName { get; set; }

        /// <summary>
        /// Checks to see if the DatabaseName property is set.
        /// </summary>
        internal bool IsSetDatabaseName() => this.DatabaseName != null;

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
        public int? DocsToInvestigate { get; set; }

        /// <summary>
        /// Checks to see if the DocsToInvestigate property is set.
        /// </summary>
        internal bool IsSetDocsToInvestigate() => this.DocsToInvestigate.HasValue;

        /// <summary>
        /// Gets and sets the property ExtractDocId. 
        /// <para>
        /// Specifies whether the document ID is added to the target table. Use this setting when
        /// <c>NestingLevel</c> is set to <c>"none"</c>. 
        /// </para>
        ///  
        /// <para>
        /// Set <c>ExtractDocId</c> to <c>true</c> when using <a href="https://www.mongodb.com/docs/manual/reference/method/Session.startTransaction/#mongodb-method-Session.startTransaction">multi-document
        /// transactions</a> with CDC. 
        /// </para>
        ///  
        /// <para>
        /// Default value is <c>false</c>.
        /// </para>
        /// </summary>
        public bool? ExtractDocId { get; set; }

        /// <summary>
        /// Checks to see if the ExtractDocId property is set.
        /// </summary>
        internal bool IsSetExtractDocId() => this.ExtractDocId.HasValue;

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
        public string KmsKeyId { get; set; }

        /// <summary>
        /// Checks to see if the KmsKeyId property is set.
        /// </summary>
        internal bool IsSetKmsKeyId() => this.KmsKeyId != null;

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
        public NestingLevelValue NestingLevel { get; set; }

        /// <summary>
        /// Checks to see if the NestingLevel property is set.
        /// </summary>
        internal bool IsSetNestingLevel() => this.NestingLevel != null;

        /// <summary>
        /// Gets and sets the property Password. 
        /// <para>
        ///  The password for the user account you use to access the DocumentDB source endpoint.
        /// 
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
        ///  The port value for the DocumentDB source endpoint. 
        /// </para>
        /// </summary>
        public int? Port { get; set; }

        /// <summary>
        /// Checks to see if the Port property is set.
        /// </summary>
        internal bool IsSetPort() => this.Port.HasValue;

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
        public bool? ReplicateShardCollections { get; set; }

        /// <summary>
        /// Checks to see if the ReplicateShardCollections property is set.
        /// </summary>
        internal bool IsSetReplicateShardCollections() => this.ReplicateShardCollections.HasValue;

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
        public string SecretsManagerAccessRoleArn { get; set; }

        /// <summary>
        /// Checks to see if the SecretsManagerAccessRoleArn property is set.
        /// </summary>
        internal bool IsSetSecretsManagerAccessRoleArn() => this.SecretsManagerAccessRoleArn != null;

        /// <summary>
        /// Gets and sets the property SecretsManagerSecretId. 
        /// <para>
        /// The full ARN, partial ARN, or friendly name of the <c>SecretsManagerSecret</c> that
        /// contains the DocumentDB endpoint connection details.
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
        ///  The name of the server on the DocumentDB source endpoint. 
        /// </para>
        /// </summary>
        public string ServerName { get; set; }

        /// <summary>
        /// Checks to see if the ServerName property is set.
        /// </summary>
        internal bool IsSetServerName() => this.ServerName != null;

        /// <summary>
        /// Gets and sets the property UseUpdateLookUp. 
        /// <para>
        /// If <c>true</c>, DMS retrieves the entire document from the DocumentDB source during
        /// migration. This may cause a migration failure if the server response exceeds bandwidth
        /// limits. To fetch only updates and deletes during migration, set this parameter to
        /// <c>false</c>.
        /// </para>
        /// </summary>
        public bool? UseUpdateLookUp { get; set; }

        /// <summary>
        /// Checks to see if the UseUpdateLookUp property is set.
        /// </summary>
        internal bool IsSetUseUpdateLookUp() => this.UseUpdateLookUp.HasValue;

        /// <summary>
        /// Gets and sets the property Username. 
        /// <para>
        /// The user name you use to access the DocumentDB source endpoint. 
        /// </para>
        /// </summary>
        public string Username { get; set; }

        /// <summary>
        /// Checks to see if the Username property is set.
        /// </summary>
        internal bool IsSetUsername() => this.Username != null;
    }
}
