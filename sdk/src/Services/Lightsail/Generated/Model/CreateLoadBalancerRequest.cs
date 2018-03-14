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
 * Do not modify this file. This file is generated from the lightsail-2016-11-28.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.Lightsail.Model
{
    /// <summary>
    /// Container for the parameters to the CreateLoadBalancer operation.
    /// Creates a Lightsail load balancer. To learn more about deciding whether to load balance
    /// your application, see <a href="https://lightsail.aws.amazon.com/ls/docs/how-to/article/configure-lightsail-instances-for-load-balancing">Configure
    /// your Lightsail instances for load balancing</a>. You can create up to 5 load balancers
    /// per AWS Region in your account.
    /// 
    ///  
    /// <para>
    /// When you create a load balancer, you can specify a unique name and port settings.
    /// To change additional load balancer settings, use the <code>UpdateLoadBalancerAttribute</code>
    /// operation.
    /// </para>
    /// </summary>
    public partial class CreateLoadBalancerRequest : AmazonLightsailRequest
    {
        private List<string> _certificateAlternativeNames = new List<string>();
        private string _certificateDomainName;
        private string _certificateName;
        private string _healthCheckPath;
        private int? _instancePort;
        private string _loadBalancerName;

        /// <summary>
        /// Gets and sets the property CertificateAlternativeNames. 
        /// <para>
        /// The optional alternative domains and subdomains to use with your SSL/TLS certificate
        /// (e.g., <code>www.example.com</code>, <code>example.com</code>, <code>m.example.com</code>,
        /// <code>blog.example.com</code>).
        /// </para>
        /// </summary>
        public List<string> CertificateAlternativeNames
        {
            get { return this._certificateAlternativeNames; }
            set { this._certificateAlternativeNames = value; }
        }

        // Check to see if CertificateAlternativeNames property is set
        internal bool IsSetCertificateAlternativeNames()
        {
            return this._certificateAlternativeNames != null && this._certificateAlternativeNames.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property CertificateDomainName. 
        /// <para>
        /// The domain name with which your certificate is associated (e.g., <code>example.com</code>).
        /// </para>
        ///  
        /// <para>
        /// If you specify <code>certificateDomainName</code>, then <code>certificateName</code>
        /// is required (and vice-versa).
        /// </para>
        /// </summary>
        public string CertificateDomainName
        {
            get { return this._certificateDomainName; }
            set { this._certificateDomainName = value; }
        }

        // Check to see if CertificateDomainName property is set
        internal bool IsSetCertificateDomainName()
        {
            return this._certificateDomainName != null;
        }

        /// <summary>
        /// Gets and sets the property CertificateName. 
        /// <para>
        /// The name of the SSL/TLS certificate.
        /// </para>
        ///  
        /// <para>
        /// If you specify <code>certificateName</code>, then <code>certificateDomainName</code>
        /// is required (and vice-versa).
        /// </para>
        /// </summary>
        public string CertificateName
        {
            get { return this._certificateName; }
            set { this._certificateName = value; }
        }

        // Check to see if CertificateName property is set
        internal bool IsSetCertificateName()
        {
            return this._certificateName != null;
        }

        /// <summary>
        /// Gets and sets the property HealthCheckPath. 
        /// <para>
        /// The path you provided to perform the load balancer health check. If you didn't specify
        /// a health check path, Lightsail uses the root path of your website (e.g., <code>"/"</code>).
        /// </para>
        ///  
        /// <para>
        /// You may want to specify a custom health check path other than the root of your application
        /// if your home page loads slowly or has a lot of media or scripting on it.
        /// </para>
        /// </summary>
        public string HealthCheckPath
        {
            get { return this._healthCheckPath; }
            set { this._healthCheckPath = value; }
        }

        // Check to see if HealthCheckPath property is set
        internal bool IsSetHealthCheckPath()
        {
            return this._healthCheckPath != null;
        }

        /// <summary>
        /// Gets and sets the property InstancePort. 
        /// <para>
        /// The instance port where you're creating your load balancer.
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
        /// Gets and sets the property LoadBalancerName. 
        /// <para>
        /// The name of your load balancer.
        /// </para>
        /// </summary>
        public string LoadBalancerName
        {
            get { return this._loadBalancerName; }
            set { this._loadBalancerName = value; }
        }

        // Check to see if LoadBalancerName property is set
        internal bool IsSetLoadBalancerName()
        {
            return this._loadBalancerName != null;
        }

    }
}