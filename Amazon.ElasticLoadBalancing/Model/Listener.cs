/*
 * Copyright 2010-2011 Amazon.com, Inc. or its affiliates. All Rights Reserved.
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
        private int? instancePort;
        private string sSLCertificateId;
        /// <summary>
        /// Default constructor for a new Listener object.  Callers should use the
        /// properties or fluent setter (With...) methods to initialize this object after creating it.
        /// </summary>
        public Listener() {}
    
        /// <summary>
        /// Constructs a new Listener object.
        /// Callers should use the properties or fluent setter (With...) methods to
        /// initialize any additional object members.
        /// </summary>
        /// 
        /// <param name="protocol"> Specifies the LoadBalancer transport protocol to use for routing - TCP or HTTP. This property cannot be modified for
        /// the life of the LoadBalancer. </param>
        /// <param name="loadBalancerPort"> Specifies the external LoadBalancer port number. This property cannot be modified for the life of the
        /// LoadBalancer. </param>
        /// <param name="instancePort"> Specifies the TCP port on which the instance server is listening. This property cannot be modified for the life
        /// of the LoadBalancer. </param>
        public Listener(string protocol, int loadBalancerPort, int instancePort) 
        {
            this.protocol = protocol;
            this.loadBalancerPort = loadBalancerPort;
            this.instancePort = instancePort;
        }
    

        /// <summary>
        /// Specifies the LoadBalancer transport protocol to use for routing - TCP or HTTP. This property cannot be modified for the life of the
        /// LoadBalancer.
        ///  
        /// </summary>
        public string Protocol
        {
            get { return this.protocol; }
            set { this.protocol = value; }
        }

        /// <summary>
        /// Sets the Protocol property
        /// </summary>
        /// <param name="protocol">The value to set for the Protocol property </param>
        /// <returns>this instance</returns>
        public Listener WithProtocol(string protocol)
        {
            this.protocol = protocol;
            return this;
        }
            

        // Check to see if Protocol property is set
        internal bool IsSetProtocol()
        {
            return this.protocol != null;       
        }

        /// <summary>
        /// Specifies the external LoadBalancer port number. This property cannot be modified for the life of the LoadBalancer.
        ///  
        /// </summary>
        public int LoadBalancerPort
        {
            get { return this.loadBalancerPort ?? default(int); }
            set { this.loadBalancerPort = value; }
        }

        /// <summary>
        /// Sets the LoadBalancerPort property
        /// </summary>
        /// <param name="loadBalancerPort">The value to set for the LoadBalancerPort property </param>
        /// <returns>this instance</returns>
        public Listener WithLoadBalancerPort(int loadBalancerPort)
        {
            this.loadBalancerPort = loadBalancerPort;
            return this;
        }
            

        // Check to see if LoadBalancerPort property is set
        internal bool IsSetLoadBalancerPort()
        {
            return this.loadBalancerPort.HasValue;       
        }

        /// <summary>
        /// Specifies the TCP port on which the instance server is listening. This property cannot be modified for the life of the LoadBalancer.
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

        /// <summary>
        /// Sets the InstancePort property
        /// </summary>
        /// <param name="instancePort">The value to set for the InstancePort property </param>
        /// <returns>this instance</returns>
        public Listener WithInstancePort(int instancePort)
        {
            this.instancePort = instancePort;
            return this;
        }
            

        // Check to see if InstancePort property is set
        internal bool IsSetInstancePort()
        {
            return this.instancePort.HasValue;       
        }

        /// <summary>
        /// The ID of the SSL certificate chain to use. For more information on SSL certificates, see <a
        /// href="http://docs.amazonwebservices.com/IAM/latest/UserGuide/index.html?ManagingCredentials.html"> Managing Keys and Certificates </a> in
        /// the AWS Identity and Access Management documentation.
        ///  
        /// </summary>
        public string SSLCertificateId
        {
            get { return this.sSLCertificateId; }
            set { this.sSLCertificateId = value; }
        }

        /// <summary>
        /// Sets the SSLCertificateId property
        /// </summary>
        /// <param name="sSLCertificateId">The value to set for the SSLCertificateId property </param>
        /// <returns>this instance</returns>
        public Listener WithSSLCertificateId(string sSLCertificateId)
        {
            this.sSLCertificateId = sSLCertificateId;
            return this;
        }
            

        // Check to see if SSLCertificateId property is set
        internal bool IsSetSSLCertificateId()
        {
            return this.sSLCertificateId != null;       
        }
    }
}
