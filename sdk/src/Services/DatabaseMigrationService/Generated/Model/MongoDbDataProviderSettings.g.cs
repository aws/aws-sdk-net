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
    /// Provides information that defines a MongoDB data provider.
    /// </summary>
    public partial class MongoDbDataProviderSettings
    {
        /// <summary>
        /// Gets and sets the property AuthMechanism. 
        /// <para>
        /// The authentication method for connecting to the data provider. Valid values are DEFAULT,
        /// MONGODB_CR, or SCRAM_SHA_1.
        /// </para>
        /// </summary>
        public AuthMechanismValue AuthMechanism { get; set; }

        /// <summary>
        /// Checks to see if the AuthMechanism property is set.
        /// </summary>
        internal bool IsSetAuthMechanism() => this.AuthMechanism != null;

        /// <summary>
        /// Gets and sets the property AuthSource. 
        /// <para>
        ///  The MongoDB database name. This setting isn't used when <c>AuthType</c> is set to
        /// <c>"no"</c>. 
        /// </para>
        ///  
        /// <para>
        /// The default is <c>"admin"</c>.
        /// </para>
        /// </summary>
        public string AuthSource { get; set; }

        /// <summary>
        /// Checks to see if the AuthSource property is set.
        /// </summary>
        internal bool IsSetAuthSource() => this.AuthSource != null;

        /// <summary>
        /// Gets and sets the property AuthType. 
        /// <para>
        /// The authentication type for the database connection. Valid values are PASSWORD or
        /// NO.
        /// </para>
        /// </summary>
        public AuthTypeValue AuthType { get; set; }

        /// <summary>
        /// Checks to see if the AuthType property is set.
        /// </summary>
        internal bool IsSetAuthType() => this.AuthType != null;

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
        /// The database name on the MongoDB data provider.
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
        /// The port value for the MongoDB data provider.
        /// </para>
        /// </summary>
        public int? Port { get; set; }

        /// <summary>
        /// Checks to see if the Port property is set.
        /// </summary>
        internal bool IsSetPort() => this.Port.HasValue;

        /// <summary>
        /// Gets and sets the property ServerName. 
        /// <para>
        /// The name of the MongoDB server.
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
        /// The SSL mode used to connect to the MongoDB data provider. The default value is <c>none</c>.
        /// </para>
        /// </summary>
        public DmsSslModeValue SslMode { get; set; }

        /// <summary>
        /// Checks to see if the SslMode property is set.
        /// </summary>
        internal bool IsSetSslMode() => this.SslMode != null;
    }
}
