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
    /// Provides information that defines an Oracle data provider.
    /// </summary>
    public partial class OracleDataProviderSettings
    {
        /// <summary>
        /// Gets and sets the property AsmServer. 
        /// <para>
        /// The address of your Oracle Automatic Storage Management (ASM) server. You can set
        /// this value from the <c>asm_server</c> value. You set <c>asm_server</c> as part of
        /// the extra connection attribute string to access an Oracle server with Binary Reader
        /// that uses ASM. For more information, see <a href="https://docs.aws.amazon.com/dms/latest/userguide/CHAP_Source.Oracle.html#dms/latest/userguide/CHAP_Source.Oracle.html#CHAP_Source.Oracle.CDC.Configuration">Configuration
        /// for change data capture (CDC) on an Oracle source database</a>.
        /// </para>
        /// </summary>
        public string AsmServer { get; set; }

        /// <summary>
        /// Checks to see if the AsmServer property is set.
        /// </summary>
        internal bool IsSetAsmServer() => this.AsmServer != null;

        /// <summary>
        /// Gets and sets the property CertificateArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the certificate used for SSL connection.
        /// </para>
        /// </summary>
        public string CertificateArn { get; set; }

        /// <summary>
        /// Checks to see if the CertificateArn property is set.
        /// </summary>
        internal bool IsSetCertificateArn() => this.CertificateArn != null;

        /// <summary>
        /// Gets and sets the property DatabaseName. 
        /// <para>
        /// The database name on the Oracle data provider.
        /// </para>
        /// </summary>
        public string DatabaseName { get; set; }

        /// <summary>
        /// Checks to see if the DatabaseName property is set.
        /// </summary>
        internal bool IsSetDatabaseName() => this.DatabaseName != null;

        /// <summary>
        /// Gets and sets the property Port. 
        /// <para>
        /// The port value for the Oracle data provider.
        /// </para>
        /// </summary>
        public int? Port { get; set; }

        /// <summary>
        /// Checks to see if the Port property is set.
        /// </summary>
        internal bool IsSetPort() => this.Port.HasValue;

        /// <summary>
        /// Gets and sets the property S3AccessRoleArn. 
        /// <para>
        /// The ARN for the role the application uses to access its Amazon S3 bucket.
        /// </para>
        /// </summary>
        public string S3AccessRoleArn { get; set; }

        /// <summary>
        /// Checks to see if the S3AccessRoleArn property is set.
        /// </summary>
        internal bool IsSetS3AccessRoleArn() => this.S3AccessRoleArn != null;

        /// <summary>
        /// Gets and sets the property S3Path. 
        /// <para>
        /// The path for the Amazon S3 bucket that the application uses for accessing the user-defined
        /// schema.
        /// </para>
        /// </summary>
        public string S3Path { get; set; }

        /// <summary>
        /// Checks to see if the S3Path property is set.
        /// </summary>
        internal bool IsSetS3Path() => this.S3Path != null;

        /// <summary>
        /// Gets and sets the property SecretsManagerOracleAsmAccessRoleArn. 
        /// <para>
        /// The ARN of the IAM role that provides access to the secret in Secrets Manager that
        /// contains the Oracle ASM connection details.
        /// </para>
        /// </summary>
        public string SecretsManagerOracleAsmAccessRoleArn { get; set; }

        /// <summary>
        /// Checks to see if the SecretsManagerOracleAsmAccessRoleArn property is set.
        /// </summary>
        internal bool IsSetSecretsManagerOracleAsmAccessRoleArn() => this.SecretsManagerOracleAsmAccessRoleArn != null;

        /// <summary>
        /// Gets and sets the property SecretsManagerOracleAsmSecretId. 
        /// <para>
        /// The identifier of the secret in Secrets Manager that contains the Oracle ASM connection
        /// details.
        /// </para>
        ///  
        /// <para>
        /// Required only if your data provider uses the Oracle ASM server.
        /// </para>
        /// </summary>
        public string SecretsManagerOracleAsmSecretId { get; set; }

        /// <summary>
        /// Checks to see if the SecretsManagerOracleAsmSecretId property is set.
        /// </summary>
        internal bool IsSetSecretsManagerOracleAsmSecretId() => this.SecretsManagerOracleAsmSecretId != null;

        /// <summary>
        /// Gets and sets the property SecretsManagerSecurityDbEncryptionAccessRoleArn. 
        /// <para>
        /// The ARN of the IAM role that provides access to the secret in Secrets Manager that
        /// contains the TDE password.
        /// </para>
        /// </summary>
        public string SecretsManagerSecurityDbEncryptionAccessRoleArn { get; set; }

        /// <summary>
        /// Checks to see if the SecretsManagerSecurityDbEncryptionAccessRoleArn property is set.
        /// </summary>
        internal bool IsSetSecretsManagerSecurityDbEncryptionAccessRoleArn() => this.SecretsManagerSecurityDbEncryptionAccessRoleArn != null;

        /// <summary>
        /// Gets and sets the property SecretsManagerSecurityDbEncryptionSecretId. 
        /// <para>
        /// The identifier of the secret in Secrets Manager that contains the transparent data
        /// encryption (TDE) password. DMS requires this password to access Oracle redo logs encrypted
        /// by TDE using Binary Reader.
        /// </para>
        /// </summary>
        public string SecretsManagerSecurityDbEncryptionSecretId { get; set; }

        /// <summary>
        /// Checks to see if the SecretsManagerSecurityDbEncryptionSecretId property is set.
        /// </summary>
        internal bool IsSetSecretsManagerSecurityDbEncryptionSecretId() => this.SecretsManagerSecurityDbEncryptionSecretId != null;

        /// <summary>
        /// Gets and sets the property ServerName. 
        /// <para>
        /// The name of the Oracle server.
        /// </para>
        /// </summary>
        public string ServerName { get; set; }

        /// <summary>
        /// Checks to see if the ServerName property is set.
        /// </summary>
        internal bool IsSetServerName() => this.ServerName != null;

        /// <summary>
        /// Gets and sets the property SslMode. 
        /// <para>
        /// The SSL mode used to connect to the Oracle data provider. The default value is <c>none</c>.
        /// </para>
        /// </summary>
        public DmsSslModeValue SslMode { get; set; }

        /// <summary>
        /// Checks to see if the SslMode property is set.
        /// </summary>
        internal bool IsSetSslMode() => this.SslMode != null;
    }
}
