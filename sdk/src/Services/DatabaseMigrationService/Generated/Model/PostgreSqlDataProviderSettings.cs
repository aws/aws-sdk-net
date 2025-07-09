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
    /// Provides information that defines a PostgreSQL data provider.
    /// </summary>
    public partial class PostgreSqlDataProviderSettings
    {
        private string _certificateArn;
        private string _databaseName;
        private int? _port;
        private string _s3AccessRoleArn;
        private string _s3Path;
        private string _serverName;
        private DmsSslModeValue _sslMode;

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
        /// The database name on the PostgreSQL data provider.
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
        /// The port value for the PostgreSQL data provider.
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
        /// Gets and sets the property ServerName. 
        /// <para>
        /// The name of the PostgreSQL server.
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
        /// The SSL mode used to connect to the PostgreSQL data provider. The default value is
        /// <c>none</c>.
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