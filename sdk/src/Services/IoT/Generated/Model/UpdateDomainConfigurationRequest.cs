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
 * Do not modify this file. This file is generated from the iot-2015-05-28.normal.json service model.
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
namespace Amazon.IoT.Model
{
    /// <summary>
    /// Container for the parameters to the UpdateDomainConfiguration operation.
    /// Updates values stored in the domain configuration. Domain configurations for default
    /// endpoints can't be updated.
    /// 
    ///  
    /// <para>
    /// Requires permission to access the <a href="https://docs.aws.amazon.com/service-authorization/latest/reference/list_awsiot.html#awsiot-actions-as-permissions">UpdateDomainConfiguration</a>
    /// action.
    /// </para>
    /// </summary>
    public partial class UpdateDomainConfigurationRequest : AmazonIoTRequest
    {
        private ApplicationProtocol _applicationProtocol;
        private AuthenticationType _authenticationType;
        private AuthorizerConfig _authorizerConfig;
        private ClientCertificateConfig _clientCertificateConfig;
        private string _domainConfigurationName;
        private DomainConfigurationStatus _domainConfigurationStatus;
        private bool? _removeAuthorizerConfig;
        private ServerCertificateConfig _serverCertificateConfig;
        private TlsConfig _tlsConfig;

        /// <summary>
        /// Gets and sets the property ApplicationProtocol. 
        /// <para>
        /// An enumerated string that speciﬁes the application-layer protocol.
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <c>SECURE_MQTT</c> - MQTT over TLS.
        /// </para>
        ///  </li> </ul> <ul> <li> 
        /// <para>
        ///  <c>MQTT_WSS</c> - MQTT over WebSocket.
        /// </para>
        ///  </li> </ul> <ul> <li> 
        /// <para>
        ///  <c>HTTPS</c> - HTTP over TLS.
        /// </para>
        ///  </li> </ul> <ul> <li> 
        /// <para>
        ///  <c>DEFAULT</c> - Use a combination of port and Application Layer Protocol Negotiation
        /// (ALPN) to specify application_layer protocol. For more information, see <a href="https://docs.aws.amazon.com/iot/latest/developerguide/protocols.html">Device
        /// communication protocols</a>.
        /// </para>
        ///  </li> </ul>
        /// </summary>
        public ApplicationProtocol ApplicationProtocol
        {
            get { return this._applicationProtocol; }
            set { this._applicationProtocol = value; }
        }

        // Check to see if ApplicationProtocol property is set
        internal bool IsSetApplicationProtocol()
        {
            return this._applicationProtocol != null;
        }

        /// <summary>
        /// Gets and sets the property AuthenticationType. 
        /// <para>
        /// An enumerated string that speciﬁes the authentication type.
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <c>CUSTOM_AUTH_X509</c> - Use custom authentication and authorization with additional
        /// details from the X.509 client certificate.
        /// </para>
        ///  </li> </ul> <ul> <li> 
        /// <para>
        ///  <c>CUSTOM_AUTH</c> - Use custom authentication and authorization. For more information,
        /// see <a href="https://docs.aws.amazon.com/iot/latest/developerguide/custom-authentication.html">Custom
        /// authentication and authorization</a>.
        /// </para>
        ///  </li> </ul> <ul> <li> 
        /// <para>
        ///  <c>AWS_X509</c> - Use X.509 client certificates without custom authentication and
        /// authorization. For more information, see <a href="https://docs.aws.amazon.com/iot/latest/developerguide/x509-client-certs.html">X.509
        /// client certificates</a>.
        /// </para>
        ///  </li> </ul> <ul> <li> 
        /// <para>
        ///  <c>AWS_SIGV4</c> - Use Amazon Web Services Signature Version 4. For more information,
        /// see <a href="https://docs.aws.amazon.com/iot/latest/developerguide/custom-authentication.html">IAM
        /// users, groups, and roles</a>.
        /// </para>
        ///  </li> </ul> <ul> <li> 
        /// <para>
        ///  <c>DEFAULT </c> - Use a combination of port and Application Layer Protocol Negotiation
        /// (ALPN) to specify authentication type. For more information, see <a href="https://docs.aws.amazon.com/iot/latest/developerguide/protocols.html">Device
        /// communication protocols</a>.
        /// </para>
        ///  </li> </ul>
        /// </summary>
        public AuthenticationType AuthenticationType
        {
            get { return this._authenticationType; }
            set { this._authenticationType = value; }
        }

        // Check to see if AuthenticationType property is set
        internal bool IsSetAuthenticationType()
        {
            return this._authenticationType != null;
        }

        /// <summary>
        /// Gets and sets the property AuthorizerConfig. 
        /// <para>
        /// An object that specifies the authorization service for a domain.
        /// </para>
        /// </summary>
        public AuthorizerConfig AuthorizerConfig
        {
            get { return this._authorizerConfig; }
            set { this._authorizerConfig = value; }
        }

        // Check to see if AuthorizerConfig property is set
        internal bool IsSetAuthorizerConfig()
        {
            return this._authorizerConfig != null;
        }

        /// <summary>
        /// Gets and sets the property ClientCertificateConfig. 
        /// <para>
        /// An object that speciﬁes the client certificate conﬁguration for a domain.
        /// </para>
        /// </summary>
        public ClientCertificateConfig ClientCertificateConfig
        {
            get { return this._clientCertificateConfig; }
            set { this._clientCertificateConfig = value; }
        }

        // Check to see if ClientCertificateConfig property is set
        internal bool IsSetClientCertificateConfig()
        {
            return this._clientCertificateConfig != null;
        }

        /// <summary>
        /// Gets and sets the property DomainConfigurationName. 
        /// <para>
        /// The name of the domain configuration to be updated.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=128)]
        public string DomainConfigurationName
        {
            get { return this._domainConfigurationName; }
            set { this._domainConfigurationName = value; }
        }

        // Check to see if DomainConfigurationName property is set
        internal bool IsSetDomainConfigurationName()
        {
            return this._domainConfigurationName != null;
        }

        /// <summary>
        /// Gets and sets the property DomainConfigurationStatus. 
        /// <para>
        /// The status to which the domain configuration should be updated.
        /// </para>
        /// </summary>
        public DomainConfigurationStatus DomainConfigurationStatus
        {
            get { return this._domainConfigurationStatus; }
            set { this._domainConfigurationStatus = value; }
        }

        // Check to see if DomainConfigurationStatus property is set
        internal bool IsSetDomainConfigurationStatus()
        {
            return this._domainConfigurationStatus != null;
        }

        /// <summary>
        /// Gets and sets the property RemoveAuthorizerConfig. 
        /// <para>
        /// Removes the authorization configuration from a domain.
        /// </para>
        /// </summary>
        public bool? RemoveAuthorizerConfig
        {
            get { return this._removeAuthorizerConfig; }
            set { this._removeAuthorizerConfig = value; }
        }

        // Check to see if RemoveAuthorizerConfig property is set
        internal bool IsSetRemoveAuthorizerConfig()
        {
            return this._removeAuthorizerConfig.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property ServerCertificateConfig. 
        /// <para>
        /// The server certificate configuration.
        /// </para>
        /// </summary>
        public ServerCertificateConfig ServerCertificateConfig
        {
            get { return this._serverCertificateConfig; }
            set { this._serverCertificateConfig = value; }
        }

        // Check to see if ServerCertificateConfig property is set
        internal bool IsSetServerCertificateConfig()
        {
            return this._serverCertificateConfig != null;
        }

        /// <summary>
        /// Gets and sets the property TlsConfig. 
        /// <para>
        /// An object that specifies the TLS configuration for a domain.
        /// </para>
        /// </summary>
        public TlsConfig TlsConfig
        {
            get { return this._tlsConfig; }
            set { this._tlsConfig = value; }
        }

        // Check to see if TlsConfig property is set
        internal bool IsSetTlsConfig()
        {
            return this._tlsConfig != null;
        }

    }
}