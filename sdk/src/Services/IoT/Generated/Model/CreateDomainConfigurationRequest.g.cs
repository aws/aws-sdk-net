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

namespace Amazon.IoT.Model
{
    /// <summary>
    /// Container for the parameters to the CreateDomainConfiguration operation. Creates a
    /// domain configuration. <para> Requires permission to access the <a href="https://docs.aws.amazon.com/service-authorization/latest/reference/list_awsiot.html#awsiot-actions-as-permissions">CreateDomainConfiguration</a>
    /// action. </para>
    /// </summary>
    public partial class CreateDomainConfigurationRequest : AmazonIoTRequest
    {
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
        public ApplicationProtocol ApplicationProtocol { get; set; }

        /// <summary>
        /// Checks to see if the ApplicationProtocol property is set.
        /// </summary>
        internal bool IsSetApplicationProtocol() => this.ApplicationProtocol != null;

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
        ///  <c>DEFAULT</c> - Use a combination of port and Application Layer Protocol Negotiation
        /// (ALPN) to specify authentication type. For more information, see <a href="https://docs.aws.amazon.com/iot/latest/developerguide/protocols.html">Device
        /// communication protocols</a>.
        /// </para>
        ///  </li> </ul>
        /// </summary>
        public AuthenticationType AuthenticationType { get; set; }

        /// <summary>
        /// Checks to see if the AuthenticationType property is set.
        /// </summary>
        internal bool IsSetAuthenticationType() => this.AuthenticationType != null;

        /// <summary>
        /// Gets and sets the property AuthorizerConfig. 
        /// <para>
        /// An object that specifies the authorization service for a domain.
        /// </para>
        /// </summary>
        public AuthorizerConfig AuthorizerConfig { get; set; }

        /// <summary>
        /// Checks to see if the AuthorizerConfig property is set.
        /// </summary>
        internal bool IsSetAuthorizerConfig() => this.AuthorizerConfig != null;

        /// <summary>
        /// Gets and sets the property ClientCertificateConfig. 
        /// <para>
        /// An object that speciﬁes the client certificate conﬁguration for a domain.
        /// </para>
        /// </summary>
        public ClientCertificateConfig ClientCertificateConfig { get; set; }

        /// <summary>
        /// Checks to see if the ClientCertificateConfig property is set.
        /// </summary>
        internal bool IsSetClientCertificateConfig() => this.ClientCertificateConfig != null;

        /// <summary>
        /// Gets and sets the property DomainConfigurationName. 
        /// <para>
        /// The name of the domain configuration. This value must be unique to a region.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 128)]
        public string DomainConfigurationName { get; set; }

        /// <summary>
        /// Checks to see if the DomainConfigurationName property is set.
        /// </summary>
        internal bool IsSetDomainConfigurationName() => this.DomainConfigurationName != null;

        /// <summary>
        /// Gets and sets the property DomainName. 
        /// <para>
        /// The name of the domain.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 253)]
        public string DomainName { get; set; }

        /// <summary>
        /// Checks to see if the DomainName property is set.
        /// </summary>
        internal bool IsSetDomainName() => this.DomainName != null;

        /// <summary>
        /// Gets and sets the property ServerCertificateArns. 
        /// <para>
        /// The ARNs of the certificates that IoT passes to the device during the TLS handshake.
        /// Currently you can specify only one certificate ARN. This value is not required for
        /// Amazon Web Services-managed domains.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min = 0, Max = 1)]
        public List<string> ServerCertificateArns { get; set; } = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Checks to see if the ServerCertificateArns property is set.
        /// </summary>
        internal bool IsSetServerCertificateArns() => this.ServerCertificateArns != null && (this.ServerCertificateArns.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property ServerCertificateConfig. 
        /// <para>
        /// The server certificate configuration.
        /// </para>
        /// </summary>
        public ServerCertificateConfig ServerCertificateConfig { get; set; }

        /// <summary>
        /// Checks to see if the ServerCertificateConfig property is set.
        /// </summary>
        internal bool IsSetServerCertificateConfig() => this.ServerCertificateConfig != null;

        /// <summary>
        /// Gets and sets the property ServiceType. 
        /// <para>
        /// The type of service delivered by the endpoint.
        /// </para>
        ///  <note> 
        /// <para>
        /// Amazon Web Services IoT Core currently supports only the <c>DATA</c> service type.
        /// </para>
        ///  </note>
        /// </summary>
        public ServiceType ServiceType { get; set; }

        /// <summary>
        /// Checks to see if the ServiceType property is set.
        /// </summary>
        internal bool IsSetServiceType() => this.ServiceType != null;

        /// <summary>
        /// Gets and sets the property Tags. 
        /// <para>
        /// Metadata which can be used to manage the domain configuration.
        /// </para>
        ///  <note> 
        /// <para>
        /// For URI Request parameters use format: ...key1=value1&amp;key2=value2...
        /// </para>
        ///  
        /// <para>
        /// For the CLI command-line parameter use format: &amp;&amp;tags "key1=value1&amp;key2=value2..."
        /// </para>
        ///  
        /// <para>
        /// For the cli-input-json file use format: "tags": "key1=value1&amp;key2=value2..."
        /// </para>
        ///  </note>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<Tag> Tags { get; set; } = AWSConfigs.InitializeCollections ? new List<Tag>() : null;

        /// <summary>
        /// Checks to see if the Tags property is set.
        /// </summary>
        internal bool IsSetTags() => this.Tags != null && (this.Tags.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property TlsConfig. 
        /// <para>
        /// An object that specifies the TLS configuration for a domain.
        /// </para>
        /// </summary>
        public TlsConfig TlsConfig { get; set; }

        /// <summary>
        /// Checks to see if the TlsConfig property is set.
        /// </summary>
        internal bool IsSetTlsConfig() => this.TlsConfig != null;

        /// <summary>
        /// Gets and sets the property ValidationCertificateArn. 
        /// <para>
        /// The certificate used to validate the server certificate and prove domain name ownership.
        /// This certificate must be signed by a public certificate authority. This value is not
        /// required for Amazon Web Services-managed domains.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 2048)]
        public string ValidationCertificateArn { get; set; }

        /// <summary>
        /// Checks to see if the ValidationCertificateArn property is set.
        /// </summary>
        internal bool IsSetValidationCertificateArn() => this.ValidationCertificateArn != null;
    }
}
