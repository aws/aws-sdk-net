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
 * Do not modify this file. This file is generated from the securityhub-2018-10-26.normal.json service model.
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
namespace Amazon.SecurityHub.Model
{
    /// <summary>
    /// Information about a load balancer listener.
    /// </summary>
    public partial class AwsElbLoadBalancerListener
    {
        private int? _instancePort;
        private string _instanceProtocol;
        private int? _loadBalancerPort;
        private string _protocol;
        private string _sslCertificateId;

        /// <summary>
        /// Gets and sets the property InstancePort. 
        /// <para>
        /// The port on which the instance is listening.
        /// </para>
        /// </summary>
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
        /// The protocol to use to route traffic to instances.
        /// </para>
        ///  
        /// <para>
        /// Valid values: <c>HTTP</c> | <c>HTTPS</c> | <c>TCP</c> | <c>SSL</c> 
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
        /// The port on which the load balancer is listening.
        /// </para>
        ///  
        /// <para>
        /// On EC2-VPC, you can specify any port from the range 1-65535.
        /// </para>
        ///  
        /// <para>
        /// On EC2-Classic, you can specify any port from the following list: 25, 80, 443, 465,
        /// 587, 1024-65535.
        /// </para>
        /// </summary>
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
        /// The load balancer transport protocol to use for routing.
        /// </para>
        ///  
        /// <para>
        /// Valid values: <c>HTTP</c> | <c>HTTPS</c> | <c>TCP</c> | <c>SSL</c> 
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
        /// Gets and sets the property SslCertificateId. 
        /// <para>
        /// The ARN of the server certificate.
        /// </para>
        /// </summary>
        public string SslCertificateId
        {
            get { return this._sslCertificateId; }
            set { this._sslCertificateId = value; }
        }

        // Check to see if SslCertificateId property is set
        internal bool IsSetSslCertificateId()
        {
            return this._sslCertificateId != null;
        }

    }
}