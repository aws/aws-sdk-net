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

namespace Amazon.ElasticLoadBalancingV2.Model
{
    /// <summary>
    /// Information about a listener.
    /// </summary>
    public partial class Listener
    {
        /// <summary>
        /// Gets and sets the property AlpnPolicy. 
        /// <para>
        /// [TLS listener] The name of the Application-Layer Protocol Negotiation (ALPN) policy.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<string> AlpnPolicy { get; set; } = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Checks to see if the AlpnPolicy property is set.
        /// </summary>
        internal bool IsSetAlpnPolicy() => this.AlpnPolicy != null && (this.AlpnPolicy.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property Certificates. 
        /// <para>
        /// [HTTPS or TLS listener] The default certificate for the listener.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<Certificate> Certificates { get; set; } = AWSConfigs.InitializeCollections ? new List<Certificate>() : null;

        /// <summary>
        /// Checks to see if the Certificates property is set.
        /// </summary>
        internal bool IsSetCertificates() => this.Certificates != null && (this.Certificates.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property DefaultActions. 
        /// <para>
        /// The default actions for the listener.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<Action> DefaultActions { get; set; } = AWSConfigs.InitializeCollections ? new List<Action>() : null;

        /// <summary>
        /// Checks to see if the DefaultActions property is set.
        /// </summary>
        internal bool IsSetDefaultActions() => this.DefaultActions != null && (this.DefaultActions.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property ListenerArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the listener.
        /// </para>
        /// </summary>
        public string ListenerArn { get; set; }

        /// <summary>
        /// Checks to see if the ListenerArn property is set.
        /// </summary>
        internal bool IsSetListenerArn() => this.ListenerArn != null;

        /// <summary>
        /// Gets and sets the property LoadBalancerArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the load balancer.
        /// </para>
        /// </summary>
        public string LoadBalancerArn { get; set; }

        /// <summary>
        /// Checks to see if the LoadBalancerArn property is set.
        /// </summary>
        internal bool IsSetLoadBalancerArn() => this.LoadBalancerArn != null;

        /// <summary>
        /// Gets and sets the property MutualAuthentication. 
        /// <para>
        /// The mutual authentication configuration information.
        /// </para>
        /// </summary>
        public MutualAuthenticationAttributes MutualAuthentication { get; set; }

        /// <summary>
        /// Checks to see if the MutualAuthentication property is set.
        /// </summary>
        internal bool IsSetMutualAuthentication() => this.MutualAuthentication != null;

        /// <summary>
        /// Gets and sets the property Port. 
        /// <para>
        /// The port on which the load balancer is listening.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 65535)]
        public int? Port { get; set; }

        /// <summary>
        /// Checks to see if the Port property is set.
        /// </summary>
        internal bool IsSetPort() => this.Port.HasValue;

        /// <summary>
        /// Gets and sets the property Protocol. 
        /// <para>
        /// The protocol for connections from clients to the load balancer.
        /// </para>
        /// </summary>
        public ProtocolEnum Protocol { get; set; }

        /// <summary>
        /// Checks to see if the Protocol property is set.
        /// </summary>
        internal bool IsSetProtocol() => this.Protocol != null;

        /// <summary>
        /// Gets and sets the property SslPolicy. 
        /// <para>
        /// [HTTPS or TLS listener] The security policy that defines which protocols and ciphers
        /// are supported.
        /// </para>
        /// </summary>
        public string SslPolicy { get; set; }

        /// <summary>
        /// Checks to see if the SslPolicy property is set.
        /// </summary>
        internal bool IsSetSslPolicy() => this.SslPolicy != null;
    }
}
