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
 * Do not modify this file. This file is generated from the elasticloadbalancing-2012-06-01.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.ElasticLoadBalancing.Model
{
    /// <summary>
    /// The Listener data type.
    /// </summary>
    public partial class Listener
    {
        private int? _instancePort;
        private string _instanceProtocol;
        private int? _loadBalancerPort;
        private string _protocol;
        private string _sSLCertificateId;

        /// <summary>
        /// Empty constructor used to set  properties independently even when a simple constructor is available
        /// </summary>
        public Listener() { }

        /// <summary>
        /// Instantiates Listener with the parameterized properties
        /// </summary>
        /// <param name="protocol"> Specifies the load balancer transport protocol to use for routing - HTTP, HTTPS, TCP or SSL. This property cannot be modified for the life of the load balancer. </param>
        /// <param name="loadBalancerPort"> Specifies the external load balancer port number. This property cannot be modified for the life of the load balancer. </param>
        /// <param name="instancePort"> Specifies the TCP port on which the instance server is listening. This property cannot be modified for the life of the load balancer. </param>
        public Listener(string protocol, int loadBalancerPort, int instancePort)
        {
            _protocol = protocol;
            _loadBalancerPort = loadBalancerPort;
            _instancePort = instancePort;
        }

        /// <summary>
        /// Gets and sets the property InstancePort. 
        /// <para>
        ///  Specifies the TCP port on which the instance server is listening. This property cannot
        /// be modified for the life of the load balancer. 
        /// </para>
        /// </summary>
        public int InstancePort
        {
            get { return this._instancePort.GetValueOrDefault(); }
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
        ///  Specifies the protocol to use for routing traffic to back-end instances - HTTP, HTTPS,
        /// TCP, or SSL. This property cannot be modified for the life of the load balancer. 
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
        ///  Specifies the external load balancer port number. This property cannot be modified
        /// for the life of the load balancer. 
        /// </para>
        /// </summary>
        public int LoadBalancerPort
        {
            get { return this._loadBalancerPort.GetValueOrDefault(); }
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
        ///  Specifies the load balancer transport protocol to use for routing - HTTP, HTTPS,
        /// TCP or SSL. This property cannot be modified for the life of the load balancer. 
        /// </para>
        /// </summary>
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
        ///  The ARN string of the server certificate. To get the ARN of the server certificate,
        /// call the AWS Identity and Access Management <a href="http://docs.aws.amazon.com/IAM/latest/APIReference/index.html?API_UploadServerCertificate.html">UploadServerCertificate
        /// </a> API. 
        /// </para>
        /// </summary>
        public string SSLCertificateId
        {
            get { return this._sSLCertificateId; }
            set { this._sSLCertificateId = value; }
        }

        // Check to see if SSLCertificateId property is set
        internal bool IsSetSSLCertificateId()
        {
            return this._sSLCertificateId != null;
        }

    }
}