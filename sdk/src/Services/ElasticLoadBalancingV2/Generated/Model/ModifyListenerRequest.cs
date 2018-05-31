/*
 * Copyright 2010-2014 Amazon.com, Inc. or its affiliates. All Rights Reserved.
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

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.ElasticLoadBalancingV2.Model
{
    /// <summary>
    /// Container for the parameters to the ModifyListener operation.
    /// Modifies the specified properties of the specified listener.
    /// 
    ///  
    /// <para>
    /// Any properties that you do not specify retain their current values. However, changing
    /// the protocol from HTTPS to HTTP removes the security policy and SSL certificate properties.
    /// If you change the protocol from HTTP to HTTPS, you must add the security policy and
    /// server certificate.
    /// </para>
    /// </summary>
    public partial class ModifyListenerRequest : AmazonElasticLoadBalancingV2Request
    {
        private List<Certificate> _certificates = new List<Certificate>();
        private List<Action> _defaultActions = new List<Action>();
        private string _listenerArn;
        private int? _port;
        private ProtocolEnum _protocol;
        private string _sslPolicy;

        /// <summary>
        /// Gets and sets the property Certificates. 
        /// <para>
        /// [HTTPS listeners] The default SSL server certificate. You must provide exactly one
        /// certificate. To create a certificate list, use <a>AddListenerCertificates</a>.
        /// </para>
        /// </summary>
        public List<Certificate> Certificates
        {
            get { return this._certificates; }
            set { this._certificates = value; }
        }

        // Check to see if Certificates property is set
        internal bool IsSetCertificates()
        {
            return this._certificates != null && this._certificates.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property DefaultActions. 
        /// <para>
        /// The actions for the default rule. The rule must include one forward action.
        /// </para>
        ///  
        /// <para>
        /// If the action type is <code>forward</code>, you can specify a single target group.
        /// The protocol of the target group must be HTTP or HTTPS for an Application Load Balancer
        /// or TCP for a Network Load Balancer.
        /// </para>
        ///  
        /// <para>
        /// If the action type is <code>authenticate-oidc</code>, you can use an identity provider
        /// that is OpenID Connect (OIDC) compliant to authenticate users as they access your
        /// application.
        /// </para>
        ///  
        /// <para>
        /// If the action type is <code>authenticate-cognito</code>, you can use Amazon Cognito
        /// to authenticate users as they access your application.
        /// </para>
        /// </summary>
        public List<Action> DefaultActions
        {
            get { return this._defaultActions; }
            set { this._defaultActions = value; }
        }

        // Check to see if DefaultActions property is set
        internal bool IsSetDefaultActions()
        {
            return this._defaultActions != null && this._defaultActions.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property ListenerArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the listener.
        /// </para>
        /// </summary>
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
        /// Gets and sets the property Port. 
        /// <para>
        /// The port for connections from clients to the load balancer.
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
        /// Gets and sets the property Protocol. 
        /// <para>
        /// The protocol for connections from clients to the load balancer. Application Load Balancers
        /// support HTTP and HTTPS and Network Load Balancers support TCP.
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
        /// [HTTPS listeners] The security policy that defines which protocols and ciphers are
        /// supported. For more information, see <a href="http://docs.aws.amazon.com/elasticloadbalancing/latest/application/create-https-listener.html#describe-ssl-policies">Security
        /// Policies</a> in the <i>Application Load Balancers Guide</i>.
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