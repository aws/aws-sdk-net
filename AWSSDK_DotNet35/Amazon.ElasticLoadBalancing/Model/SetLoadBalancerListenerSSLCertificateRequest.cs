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
    /// certificate that was used on the same load balancer and port. </para> <para>For more information on updating your SSL certificate, see <a
    /// href="http://docs.aws.amazon.com/ElasticLoadBalancing/latest/DeveloperGuide/US_UpdatingLoadBalancerSSL.html" >Updating an SSL Certificate
    /// for a Load Balancer</a> in the <i>Elastic Load Balancing Developer Guide</i> .</para>
    /// </summary>
    public partial class SetLoadBalancerListenerSSLCertificateRequest : AmazonElasticLoadBalancingRequest
    {
        private string loadBalancerName;
        private int? loadBalancerPort;
        private string sSLCertificateId;

        /// <summary>
        /// Default constructor for a new SetLoadBalancerListenerSSLCertificateRequest object.  Callers should use the
        /// properties to initialize this object after creating it.
        /// </summary>
        public SetLoadBalancerListenerSSLCertificateRequest() {}
    
        /// <summary>
        /// Constructs a new SetLoadBalancerListenerSSLCertificateRequest object.
        /// Callers should use the properties initialize any additional object members.
        /// </summary>
        /// 
        /// <param name="loadBalancerName"> The name of the load balancer. </param>
        /// <param name="loadBalancerPort"> The port that uses the specified SSL certificate. </param>
        /// <param name="sSLCertificateId"> The Amazon Resource Number (ARN) of the SSL certificate chain to use. For more information on SSL
        /// certificates, see <a href="http://docs.aws.amazon.com/IAM/latest/UserGuide/ManagingServerCerts.html"> Managing Server Certificates</a> in
        /// the <i>AWS Identity and Access Management User Guide</i>. </param>
        public SetLoadBalancerListenerSSLCertificateRequest(string loadBalancerName, int loadBalancerPort, string sSLCertificateId)
        {
            this.loadBalancerName = loadBalancerName;
            this.loadBalancerPort = loadBalancerPort;
            this.sSLCertificateId = sSLCertificateId;
        }
    

        /// <summary>
        /// The name of the load balancer.
        ///  
        /// </summary>
        public string LoadBalancerName
        {
            get { return this.loadBalancerName; }
            set { this.loadBalancerName = value; }
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

        // Check to see if LoadBalancerPort property is set
        internal bool IsSetLoadBalancerPort()
        {
            return this.loadBalancerPort.HasValue;
        }

        /// <summary>
        /// The Amazon Resource Number (ARN) of the SSL certificate chain to use. For more information on SSL certificates, see <a
        /// href="http://docs.aws.amazon.com/IAM/latest/UserGuide/ManagingServerCerts.html"> Managing Server Certificates</a> in the <i>AWS Identity and
        /// Access Management User Guide</i>.
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
    
