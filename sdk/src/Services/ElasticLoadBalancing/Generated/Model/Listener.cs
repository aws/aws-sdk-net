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
 * Do not modify this file. This file is generated from the elasticloadbalancing-2012-06-01.normal.json service model.
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
namespace Amazon.ElasticLoadBalancing.Model
{
    /// <summary>
    /// Information about a listener.
    /// 
    ///  
    /// <para>
    /// For information about the protocols and the ports supported by Elastic Load Balancing,
    /// see <a href="https://docs.aws.amazon.com/elasticloadbalancing/latest/classic/elb-listener-config.html">Listeners
    /// for Your Classic Load Balancer</a> in the <i>Classic Load Balancers Guide</i>.
    /// </para>
    /// </summary>
    public partial class Listener
    {
        private int? _instancePort;
        private string _instanceProtocol;
        private int? _loadBalancerPort;
        private string _protocol;
        private string _sslCertificateId;

        /// <summary>
        /// Empty constructor used to set  properties independently even when a simple constructor is available
        /// </summary>
        public Listener() { }

        /// <summary>
        /// Instantiates Listener with the parameterized properties
        /// </summary>
        /// <param name="protocol">The load balancer transport protocol to use for routing: HTTP, HTTPS, TCP, or SSL.</param>
        /// <param name="loadBalancerPort">The port on which the load balancer is listening. On EC2-VPC, you can specify any port from the range 1-65535. On EC2-Classic, you can specify any port from the following list: 25, 80, 443, 465, 587, 1024-65535.</param>
        /// <param name="instancePort">The port on which the instance is listening.</param>
        public Listener(string protocol, int? loadBalancerPort, int? instancePort)
        {
            _protocol = protocol;
            _loadBalancerPort = loadBalancerPort;
            _instancePort = instancePort;
        }

        /// <summary>
        /// Gets and sets the property InstancePort. 
        /// <para>
        /// The port on which the instance is listening.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=65535)]
        public int? InstancePort
        {
            get { return this._instancePort; }
            set { this._instancePort = value; }
        }

        // Check to see if InstancePort property is set
        internal bool IsSetInstancePort()
        {
            return this._instancePort.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property InstanceProtocol. 
        /// <para>
        /// The protocol to use for routing traffic to instances: HTTP, HTTPS, TCP, or SSL.
        /// </para>
        ///  
        /// <para>
        /// If the front-end protocol is TCP or SSL, the back-end protocol must be TCP or SSL.
        /// If the front-end protocol is HTTP or HTTPS, the back-end protocol must be HTTP or
        /// HTTPS.
        /// </para>
        ///  
        /// <para>
        /// If there is another listener with the same <c>InstancePort</c> whose <c>InstanceProtocol</c>
        /// is secure, (HTTPS or SSL), the listener's <c>InstanceProtocol</c> must also be secure.
        /// </para>
        ///  
        /// <para>
        /// If there is another listener with the same <c>InstancePort</c> whose <c>InstanceProtocol</c>
        /// is HTTP or TCP, the listener's <c>InstanceProtocol</c> must be HTTP or TCP.
        /// </para>
        /// </summary>
        public string InstanceProtocol
        {
            get { return this._instanceProtocol; }
            set { this._instanceProtocol = value; }
        }

        // Check to see if InstanceProtocol property is set
        internal bool IsSetInstanceProtocol()
        {
            return this._instanceProtocol != null;
        }

        /// <summary>
        /// Gets and sets the property LoadBalancerPort. 
        /// <para>
        /// The port on which the load balancer is listening. On EC2-VPC, you can specify any
        /// port from the range 1-65535. On EC2-Classic, you can specify any port from the following
        /// list: 25, 80, 443, 465, 587, 1024-65535.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public int? LoadBalancerPort
        {
            get { return this._loadBalancerPort; }
            set { this._loadBalancerPort = value; }
        }

        // Check to see if LoadBalancerPort property is set
        internal bool IsSetLoadBalancerPort()
        {
            return this._loadBalancerPort.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Protocol. 
        /// <para>
        /// The load balancer transport protocol to use for routing: HTTP, HTTPS, TCP, or SSL.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string Protocol
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
        /// Gets and sets the property SSLCertificateId. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the server certificate.
        /// </para>
        /// </summary>
        public string SSLCertificateId
        {
            get { return this._sslCertificateId; }
            set { this._sslCertificateId = value; }
        }

        // Check to see if SSLCertificateId property is set
        internal bool IsSetSSLCertificateId()
        {
            return this._sslCertificateId != null;
        }

    }
}