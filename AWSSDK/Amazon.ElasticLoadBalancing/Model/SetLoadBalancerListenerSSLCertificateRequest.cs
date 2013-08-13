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

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.ElasticLoadBalancing.Model
{
    /// <summary>
    /// Container for the parameters to the SetLoadBalancerListenerSSLCertificate operation.
    /// <para> Sets the certificate that terminates the specified listener's SSL connections. The specified certificate replaces any prior
    /// certificate that was used on the same LoadBalancer and port. </para> <para>For information on using SetLoadBalancerListenerSSLCertificate,
    /// go to Using the Query API in <i>Updating an SSL Certificate for a Load Balancer</i> section of the <i>Elastic Load Balancing Developer
    /// Guide</i> .</para>
    /// </summary>
    /// <seealso cref="Amazon.ElasticLoadBalancing.AmazonElasticLoadBalancing.SetLoadBalancerListenerSSLCertificate"/>
    public class SetLoadBalancerListenerSSLCertificateRequest : AmazonWebServiceRequest
    {
        private string loadBalancerName;
        private int? loadBalancerPort;
        private string sSLCertificateId;
        /// <summary>
        /// Default constructor for a new SetLoadBalancerListenerSSLCertificateRequest object.  Callers should use the
        /// properties or fluent setter (With...) methods to initialize this object after creating it.
        /// </summary>
        public SetLoadBalancerListenerSSLCertificateRequest() {}
    
        /// <summary>
        /// Constructs a new SetLoadBalancerListenerSSLCertificateRequest object.
        /// Callers should use the properties or fluent setter (With...) methods to
        /// initialize any additional object members.
        /// </summary>
        /// 
        /// <param name="loadBalancerName"> The name of the the LoadBalancer. </param>
        /// <param name="loadBalancerPort"> The port that uses the specified SSL certificate. </param>
        /// <param name="sSLCertificateId"> The ID of the SSL certificate chain to use. For more information on SSL certificates, see <a
        /// href="http://docs.amazonwebservices.com/IAM/latest/UserGuide/ManagingServerCerts.html"> Managing Server Certificates </a> in the AWS
        /// Identity and Access Management documentation. </param>
        public SetLoadBalancerListenerSSLCertificateRequest(string loadBalancerName, int loadBalancerPort, string sSLCertificateId) 
        {
            this.loadBalancerName = loadBalancerName;
            this.loadBalancerPort = loadBalancerPort;
            this.sSLCertificateId = sSLCertificateId;
        }
    

        /// <summary>
        /// The name of the the LoadBalancer.
        ///  
        /// </summary>
        public string LoadBalancerName
        {
            get { return this.loadBalancerName; }
            set { this.loadBalancerName = value; }
        }

        /// <summary>
        /// Sets the LoadBalancerName property
        /// </summary>
        /// <param name="loadBalancerName">The value to set for the LoadBalancerName property </param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public SetLoadBalancerListenerSSLCertificateRequest WithLoadBalancerName(string loadBalancerName)
        {
            this.loadBalancerName = loadBalancerName;
            return this;
        }
            

        // Check to see if LoadBalancerName property is set
        internal bool IsSetLoadBalancerName()
        {
            return this.loadBalancerName != null;       
        }

        /// <summary>
        /// The port that uses the specified SSL certificate.
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
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public SetLoadBalancerListenerSSLCertificateRequest WithLoadBalancerPort(int loadBalancerPort)
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
        /// The ID of the SSL certificate chain to use. For more information on SSL certificates, see <a
        /// href="http://docs.amazonwebservices.com/IAM/latest/UserGuide/ManagingServerCerts.html"> Managing Server Certificates </a> in the AWS
        /// Identity and Access Management documentation.
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
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public SetLoadBalancerListenerSSLCertificateRequest WithSSLCertificateId(string sSLCertificateId)
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
    
