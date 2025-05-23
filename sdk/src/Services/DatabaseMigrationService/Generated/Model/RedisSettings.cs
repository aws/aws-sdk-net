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
    /// Provides information that defines a Redis target endpoint.
    /// </summary>
    public partial class RedisSettings
    {
        private string _authPassword;
        private RedisAuthTypeValue _authType;
        private string _authUserName;
        private int? _port;
        private string _serverName;
        private string _sslCaCertificateArn;
        private SslSecurityProtocolValue _sslSecurityProtocol;

        /// <summary>
        /// Gets and sets the property AuthPassword. 
        /// <para>
        /// The password provided with the <c>auth-role</c> and <c>auth-token</c> options of the
        /// <c>AuthType</c> setting for a Redis target endpoint.
        /// </para>
        /// </summary>
        [AWSProperty(Sensitive=true)]
        public string AuthPassword
        {
            get { return this._authPassword; }
            set { this._authPassword = value; }
        }

        // Check to see if AuthPassword property is set
        internal bool IsSetAuthPassword()
        {
            return this._authPassword != null;
        }

        /// <summary>
        /// Gets and sets the property AuthType. 
        /// <para>
        /// The type of authentication to perform when connecting to a Redis target. Options include
        /// <c>none</c>, <c>auth-token</c>, and <c>auth-role</c>. The <c>auth-token</c> option
        /// requires an <c>AuthPassword</c> value to be provided. The <c>auth-role</c> option
        /// requires <c>AuthUserName</c> and <c>AuthPassword</c> values to be provided.
        /// </para>
        /// </summary>
        public RedisAuthTypeValue AuthType
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
        /// Gets and sets the property AuthUserName. 
        /// <para>
        /// The user name provided with the <c>auth-role</c> option of the <c>AuthType</c> setting
        /// for a Redis target endpoint.
        /// </para>
        /// </summary>
        public string AuthUserName
        {
            get { return this._authUserName; }
            set { this._authUserName = value; }
        }

        // Check to see if AuthUserName property is set
        internal bool IsSetAuthUserName()
        {
            return this._authUserName != null;
        }

        /// <summary>
        /// Gets and sets the property Port. 
        /// <para>
        /// Transmission Control Protocol (TCP) port for the endpoint.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
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
        /// Gets and sets the property ServerName. 
        /// <para>
        /// Fully qualified domain name of the endpoint.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
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
        /// Gets and sets the property SslCaCertificateArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) for the certificate authority (CA) that DMS uses to
        /// connect to your Redis target endpoint.
        /// </para>
        /// </summary>
        public string SslCaCertificateArn
        {
            get { return this._sslCaCertificateArn; }
            set { this._sslCaCertificateArn = value; }
        }

        // Check to see if SslCaCertificateArn property is set
        internal bool IsSetSslCaCertificateArn()
        {
            return this._sslCaCertificateArn != null;
        }

        /// <summary>
        /// Gets and sets the property SslSecurityProtocol. 
        /// <para>
        /// The connection to a Redis target endpoint using Transport Layer Security (TLS). Valid
        /// values include <c>plaintext</c> and <c>ssl-encryption</c>. The default is <c>ssl-encryption</c>.
        /// The <c>ssl-encryption</c> option makes an encrypted connection. Optionally, you can
        /// identify an Amazon Resource Name (ARN) for an SSL certificate authority (CA) using
        /// the <c>SslCaCertificateArn </c>setting. If an ARN isn't given for a CA, DMS uses the
        /// Amazon root CA.
        /// </para>
        ///  
        /// <para>
        /// The <c>plaintext</c> option doesn't provide Transport Layer Security (TLS) encryption
        /// for traffic between endpoint and database.
        /// </para>
        /// </summary>
        public SslSecurityProtocolValue SslSecurityProtocol
        {
            get { return this._sslSecurityProtocol; }
            set { this._sslSecurityProtocol = value; }
        }

        // Check to see if SslSecurityProtocol property is set
        internal bool IsSetSslSecurityProtocol()
        {
            return this._sslSecurityProtocol != null;
        }

    }
}