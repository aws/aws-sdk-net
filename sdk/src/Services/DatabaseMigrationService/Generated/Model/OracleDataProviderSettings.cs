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
    /// Provides information that defines an Oracle data provider.
    /// </summary>
    public partial class OracleDataProviderSettings
    {
        private string _asmServer;
        private string _certificateArn;
        private string _databaseName;
        private int? _port;
        private string _s3AccessRoleArn;
        private string _s3Path;
        private string _secretsManagerOracleAsmAccessRoleArn;
        private string _secretsManagerOracleAsmSecretId;
        private string _secretsManagerSecurityDbEncryptionAccessRoleArn;
        private string _secretsManagerSecurityDbEncryptionSecretId;
        private string _serverName;
        private DmsSslModeValue _sslMode;

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
        /// Gets and sets the property CertificateArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the certificate used for SSL connection.
        /// </para>
        /// </summary>
        public string CertificateArn
        {
            get { return this._certificateArn; }
            set { this._certificateArn = value; }
        }

        // Check to see if CertificateArn property is set
        internal bool IsSetCertificateArn()
        {
            return this._certificateArn != null;
        }

        /// <summary>
        /// Gets and sets the property DatabaseName. 
        /// <para>
        /// The database name on the Oracle data provider.
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
        /// Gets and sets the property Port. 
        /// <para>
        /// The port value for the Oracle data provider.
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
        /// Gets and sets the property S3AccessRoleArn. 
        /// <para>
        /// The ARN for the role the application uses to access its Amazon S3 bucket.
        /// </para>
        /// </summary>
        public string S3AccessRoleArn
        {
            get { return this._s3AccessRoleArn; }
            set { this._s3AccessRoleArn = value; }
        }

        // Check to see if S3AccessRoleArn property is set
        internal bool IsSetS3AccessRoleArn()
        {
            return this._s3AccessRoleArn != null;
        }

        /// <summary>
        /// Gets and sets the property S3Path. 
        /// <para>
        /// The path for the Amazon S3 bucket that the application uses for accessing the user-defined
        /// schema.
        /// </para>
        /// </summary>
        public string S3Path
        {
            get { return this._s3Path; }
            set { this._s3Path = value; }
        }

        // Check to see if S3Path property is set
        internal bool IsSetS3Path()
        {
            return this._s3Path != null;
        }

        /// <summary>
        /// Gets and sets the property SecretsManagerOracleAsmAccessRoleArn. 
        /// <para>
        /// The ARN of the IAM role that provides access to the secret in Secrets Manager that
        /// contains the Oracle ASM connection details.
        /// </para>
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
        /// The identifier of the secret in Secrets Manager that contains the Oracle ASM connection
        /// details.
        /// </para>
        ///  
        /// <para>
        /// Required only if your data provider uses the Oracle ASM server.
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
        /// Gets and sets the property SecretsManagerSecurityDbEncryptionAccessRoleArn. 
        /// <para>
        /// The ARN of the IAM role that provides access to the secret in Secrets Manager that
        /// contains the TDE password.
        /// </para>
        /// </summary>
        public string SecretsManagerSecurityDbEncryptionAccessRoleArn
        {
            get { return this._secretsManagerSecurityDbEncryptionAccessRoleArn; }
            set { this._secretsManagerSecurityDbEncryptionAccessRoleArn = value; }
        }

        // Check to see if SecretsManagerSecurityDbEncryptionAccessRoleArn property is set
        internal bool IsSetSecretsManagerSecurityDbEncryptionAccessRoleArn()
        {
            return this._secretsManagerSecurityDbEncryptionAccessRoleArn != null;
        }

        /// <summary>
        /// Gets and sets the property SecretsManagerSecurityDbEncryptionSecretId. 
        /// <para>
        /// The identifier of the secret in Secrets Manager that contains the transparent data
        /// encryption (TDE) password. DMS requires this password to access Oracle redo logs encrypted
        /// by TDE using Binary Reader.
        /// </para>
        /// </summary>
        public string SecretsManagerSecurityDbEncryptionSecretId
        {
            get { return this._secretsManagerSecurityDbEncryptionSecretId; }
            set { this._secretsManagerSecurityDbEncryptionSecretId = value; }
        }

        // Check to see if SecretsManagerSecurityDbEncryptionSecretId property is set
        internal bool IsSetSecretsManagerSecurityDbEncryptionSecretId()
        {
            return this._secretsManagerSecurityDbEncryptionSecretId != null;
        }

        /// <summary>
        /// Gets and sets the property ServerName. 
        /// <para>
        /// The name of the Oracle server.
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
        /// Gets and sets the property SslMode. 
        /// <para>
        /// The SSL mode used to connect to the Oracle data provider. The default value is <c>none</c>.
        /// </para>
        /// </summary>
        public DmsSslModeValue SslMode
        {
            get { return this._sslMode; }
            set { this._sslMode = value; }
        }

        // Check to see if SslMode property is set
        internal bool IsSetSslMode()
        {
            return this._sslMode != null;
        }

    }
}