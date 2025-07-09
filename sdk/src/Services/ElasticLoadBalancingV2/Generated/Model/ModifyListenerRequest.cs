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
 * Do not modify this file. This file is generated from the elasticloadbalancingv2-2015-12-01.normal.json service model.
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
namespace Amazon.ElasticLoadBalancingV2.Model
{
    /// <summary>
    /// Container for the parameters to the ModifyListener operation.
    /// Replaces the specified properties of the specified listener. Any properties that you
    /// do not specify remain unchanged.
    /// 
    ///  
    /// <para>
    /// Changing the protocol from HTTPS to HTTP, or from TLS to TCP, removes the security
    /// policy and default certificate properties. If you change the protocol from HTTP to
    /// HTTPS, or from TCP to TLS, you must add the security policy and default certificate
    /// properties.
    /// </para>
    ///  
    /// <para>
    /// To add an item to a list, remove an item from a list, or update an item in a list,
    /// you must provide the entire list. For example, to add an action, specify a list with
    /// the current actions plus the new action.
    /// </para>
    /// </summary>
    public partial class ModifyListenerRequest : AmazonElasticLoadBalancingV2Request
    {
        private List<string> _alpnPolicy = AWSConfigs.InitializeCollections ? new List<string>() : null;
        private List<Certificate> _certificates = AWSConfigs.InitializeCollections ? new List<Certificate>() : null;
        private List<Action> _defaultActions = AWSConfigs.InitializeCollections ? new List<Action>() : null;
        private string _listenerArn;
        private MutualAuthenticationAttributes _mutualAuthentication;
        private int? _port;
        private ProtocolEnum _protocol;
        private string _sslPolicy;

        /// <summary>
        /// Gets and sets the property AlpnPolicy. 
        /// <para>
        /// [TLS listeners] The name of the Application-Layer Protocol Negotiation (ALPN) policy.
        /// You can specify one policy name. The following are the possible values:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <c>HTTP1Only</c> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>HTTP2Only</c> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>HTTP2Optional</c> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>HTTP2Preferred</c> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>None</c> 
        /// </para>
        ///  </li> </ul> 
        /// <para>
        /// For more information, see <a href="https://docs.aws.amazon.com/elasticloadbalancing/latest/network/load-balancer-listeners.html#alpn-policies">ALPN
        /// policies</a> in the <i>Network Load Balancers Guide</i>.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<string> AlpnPolicy
        {
            get { return this._alpnPolicy; }
            set { this._alpnPolicy = value; }
        }

        // Check to see if AlpnPolicy property is set
        internal bool IsSetAlpnPolicy()
        {
            return this._alpnPolicy != null && (this._alpnPolicy.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property Certificates. 
        /// <para>
        /// [HTTPS and TLS listeners] The default certificate for the listener. You must provide
        /// exactly one certificate. Set <c>CertificateArn</c> to the certificate ARN but do not
        /// set <c>IsDefault</c>.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<Certificate> Certificates
        {
            get { return this._certificates; }
            set { this._certificates = value; }
        }

        // Check to see if Certificates property is set
        internal bool IsSetCertificates()
        {
            return this._certificates != null && (this._certificates.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property DefaultActions. 
        /// <para>
        /// The actions for the default rule.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<Action> DefaultActions
        {
            get { return this._defaultActions; }
            set { this._defaultActions = value; }
        }

        // Check to see if DefaultActions property is set
        internal bool IsSetDefaultActions()
        {
            return this._defaultActions != null && (this._defaultActions.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property ListenerArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the listener.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string ListenerArn
        {
            get { return this._listenerArn; }
            set { this._listenerArn = value; }
        }

        // Check to see if ListenerArn property is set
        internal bool IsSetListenerArn()
        {
            return this._listenerArn != null;
        }

        /// <summary>
        /// Gets and sets the property MutualAuthentication. 
        /// <para>
        /// The mutual authentication configuration information.
        /// </para>
        /// </summary>
        public MutualAuthenticationAttributes MutualAuthentication
        {
            get { return this._mutualAuthentication; }
            set { this._mutualAuthentication = value; }
        }

        // Check to see if MutualAuthentication property is set
        internal bool IsSetMutualAuthentication()
        {
            return this._mutualAuthentication != null;
        }

        /// <summary>
        /// Gets and sets the property Port. 
        /// <para>
        /// The port for connections from clients to the load balancer. You can't specify a port
        /// for a Gateway Load Balancer.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=65535)]
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
        /// Gets and sets the property Protocol. 
        /// <para>
        /// The protocol for connections from clients to the load balancer. Application Load Balancers
        /// support the HTTP and HTTPS protocols. Network Load Balancers support the TCP, TLS,
        /// UDP, and TCP_UDP protocols. You can’t change the protocol to UDP or TCP_UDP if dual-stack
        /// mode is enabled. You can't specify a protocol for a Gateway Load Balancer.
        /// </para>
        /// </summary>
        public ProtocolEnum Protocol
        {
            get { return this._protocol; }
            set { this._protocol = value; }
        }

        // Check to see if Protocol property is set
        internal bool IsSetProtocol()
        {
            return this._protocol != null;
        }

        /// <summary>
        /// Gets and sets the property SslPolicy. 
        /// <para>
        /// [HTTPS and TLS listeners] The security policy that defines which protocols and ciphers
        /// are supported.
        /// </para>
        ///  
        /// <para>
        /// For more information, see <a href="https://docs.aws.amazon.com/elasticloadbalancing/latest/application/describe-ssl-policies.html">Security
        /// policies</a> in the <i>Application Load Balancers Guide</i> or <a href="https://docs.aws.amazon.com/elasticloadbalancing/latest/network/describe-ssl-policies.html">Security
        /// policies</a> in the <i>Network Load Balancers Guide</i>.
        /// </para>
        /// </summary>
        public string SslPolicy
        {
            get { return this._sslPolicy; }
            set { this._sslPolicy = value; }
        }

        // Check to see if SslPolicy property is set
        internal bool IsSetSslPolicy()
        {
            return this._sslPolicy != null;
        }

    }
}