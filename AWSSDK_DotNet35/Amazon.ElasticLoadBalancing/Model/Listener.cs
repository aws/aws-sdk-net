/*
 * Copyright 2010-2013 Amazon.com, Inc. or its affiliates. All Rights Reserved.
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
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;

namespace Amazon.ElasticLoadBalancing.Model
{
    /// <summary>
    /// <para> The Listener data type. </para>
    /// </summary>
    public class Listener
    {
        
        private string protocol;
        private int? loadBalancerPort;
        private string instanceProtocol;
        private int? instancePort;
        private string sSLCertificateId;

        /// <summary>
        /// Default constructor for a new Listener object.  Callers should use the
        /// properties to initialize this object after creating it.
        /// </summary>
        public Listener() {}
    
        /// <summary>
        /// Constructs a new Listener object.
        /// Callers should use the properties initialize any additional object members.
        /// </summary>
        /// 
        /// <param name="protocol"> Specifies the load balancer transport protocol to use for routing - HTTP, HTTPS, TCP or SSL. This property cannot be
        /// modified for the life of the load balancer. </param>
        /// <param name="loadBalancerPort"> Specifies the external load balancer port number. This property cannot be modified for the life of the load
        /// balancer. </param>
        /// <param name="instancePort"> Specifies the TCP port on which the instance server is listening. This property cannot be modified for the life
        /// of the load balancer. </param>
        public Listener(string protocol, int loadBalancerPort, int instancePort)
        {
            this.protocol = protocol;
            this.loadBalancerPort = loadBalancerPort;
            this.instancePort = instancePort;
        }
    

        /// <summary>
        /// Specifies the load balancer transport protocol to use for routing - HTTP, HTTPS, TCP or SSL. This property cannot be modified for the life
        /// of the load balancer.
        ///  
        /// </summary>
        public string Protocol
        {
            get { return this.protocol; }
            set { this.protocol = value; }
        }

        // Check to see if Protocol property is set
        internal bool IsSetProtocol()
        {
            return this.protocol != null;
        }

        /// <summary>
        /// Specifies the external load balancer port number. This property cannot be modified for the life of the load balancer.
        ///  
        /// </summary>
        public int LoadBalancerPort
        {
            get { return this.loadBalancerPort ?? default(int); }
            set { this.loadBalancerPort = value; }
        }

        // Check to see if LoadBalancerPort property is set
        internal bool IsSetLoadBalancerPort()
        {
            return this.loadBalancerPort.HasValue;
        }

        /// <summary>
        /// Specifies the protocol to use for routing traffic to back-end instances - HTTP, HTTPS, TCP, or SSL. This property cannot be modified for the
        /// life of the load balancer. <note> If the front-end protocol is HTTP or HTTPS, <c>InstanceProtocol</c> has to be at the same protocol layer,
        /// i.e., HTTP or HTTPS. Likewise, if the front-end protocol is TCP or SSL, InstanceProtocol has to be TCP or SSL. </note> <note> If there is
        /// another listener with the same <c>InstancePort</c> whose <c>InstanceProtocol</c> is secure, i.e., HTTPS or SSL, the listener's
        /// <c>InstanceProtocol</c> has to be secure, i.e., HTTPS or SSL. If there is another listener with the same <c>InstancePort</c> whose
        /// <c>InstanceProtocol</c> is HTTP or TCP, the listener's <c>InstanceProtocol</c> must be either HTTP or TCP. </note>
        ///  
        /// </summary>
        public string InstanceProtocol
        {
            get { return this.instanceProtocol; }
            set { this.instanceProtocol = value; }
        }

        // Check to see if InstanceProtocol property is set
        internal bool IsSetInstanceProtocol()
        {
            return this.instanceProtocol != null;
        }

        /// <summary>
        /// Specifies the TCP port on which the instance server is listening. This property cannot be modified for the life of the load balancer.
        ///  
        /// <para>
        /// <b>Constraints:</b>
        /// <list type="definition">
        ///     <item>
        ///         <term>Range</term>
        ///         <description>1 - 65535</description>
        ///     </item>
        /// </list>
        /// </para>
        /// </summary>
        public int InstancePort
        {
            get { return this.instancePort ?? default(int); }
            set { this.instancePort = value; }
        }

        // Check to see if InstancePort property is set
        internal bool IsSetInstancePort()
        {
            return this.instancePort.HasValue;
        }

        /// <summary>
        /// The ARN string of the server certificate. To get the ARN of the server certificate, call the AWS Identity and Access Management <a
        /// href="http://docs.aws.amazon.com/IAM/latest/APIReference/index.html?API_UploadServerCertificate.html">UploadServerCertificate </a> API.
        ///  
        /// </summary>
        public string SSLCertificateId
        {
            get { return this.sSLCertificateId; }
            set { this.sSLCertificateId = value; }
        }

        // Check to see if SSLCertificateId property is set
        internal bool IsSetSSLCertificateId()
        {
            return this.sSLCertificateId != null;
        }
    }
}
