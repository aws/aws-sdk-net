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
 * Do not modify this file. This file is generated from the lightsail-2016-11-28.normal.json service model.
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
namespace Amazon.Lightsail.Model
{
    /// <summary>
    /// Container for the parameters to the CreateLoadBalancer operation.
    /// Creates a Lightsail load balancer. To learn more about deciding whether to load balance
    /// your application, see <a href="https://docs.aws.amazon.com/lightsail/latest/userguide/configure-lightsail-instances-for-load-balancing">Configure
    /// your Lightsail instances for load balancing</a>. You can create up to 5 load balancers
    /// per AWS Region in your account.
    /// 
    ///  
    /// <para>
    /// When you create a load balancer, you can specify a unique name and port settings.
    /// To change additional load balancer settings, use the <c>UpdateLoadBalancerAttribute</c>
    /// operation.
    /// </para>
    ///  
    /// <para>
    /// The <c>create load balancer</c> operation supports tag-based access control via request
    /// tags. For more information, see the <a href="https://docs.aws.amazon.com/lightsail/latest/userguide/amazon-lightsail-controlling-access-using-tags">Amazon
    /// Lightsail Developer Guide</a>.
    /// </para>
    /// </summary>
    public partial class CreateLoadBalancerRequest : AmazonLightsailRequest
    {
        private List<string> _certificateAlternativeNames = AWSConfigs.InitializeCollections ? new List<string>() : null;
        private string _certificateDomainName;
        private string _certificateName;
        private string _healthCheckPath;
        private int? _instancePort;
        private IpAddressType _ipAddressType;
        private string _loadBalancerName;
        private List<Tag> _tags = AWSConfigs.InitializeCollections ? new List<Tag>() : null;
        private string _tlsPolicyName;

        /// <summary>
        /// Gets and sets the property CertificateAlternativeNames. 
        /// <para>
        /// The optional alternative domains and subdomains to use with your SSL/TLS certificate
        /// (<c>www.example.com</c>, <c>example.com</c>, <c>m.example.com</c>, <c>blog.example.com</c>).
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<string> CertificateAlternativeNames
        {
            get { return this._certificateAlternativeNames; }
            set { this._certificateAlternativeNames = value; }
        }

        // Check to see if CertificateAlternativeNames property is set
        internal bool IsSetCertificateAlternativeNames()
        {
            return this._certificateAlternativeNames != null && (this._certificateAlternativeNames.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property CertificateDomainName. 
        /// <para>
        /// The domain name with which your certificate is associated (<c>example.com</c>).
        /// </para>
        ///  
        /// <para>
        /// If you specify <c>certificateDomainName</c>, then <c>certificateName</c> is required
        /// (and vice-versa).
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
        /// If you specify <c>certificateName</c>, then <c>certificateDomainName</c> is required
        /// (and vice-versa).
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
        /// a health check path, Lightsail uses the root path of your website (<c>"/"</c>).
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
        [AWSProperty(Required=true, Min=-1, Max=65535)]
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
        /// Gets and sets the property IpAddressType. 
        /// <para>
        /// The IP address type for the load balancer.
        /// </para>
        ///  
        /// <para>
        /// The possible values are <c>ipv4</c> for IPv4 only, <c>ipv6</c> for IPv6 only, and
        /// <c>dualstack</c> for IPv4 and IPv6.
        /// </para>
        ///  
        /// <para>
        /// The default value is <c>dualstack</c>.
        /// </para>
        /// </summary>
        public IpAddressType IpAddressType
        {
            get { return this._ipAddressType; }
            set { this._ipAddressType = value; }
        }

        // Check to see if IpAddressType property is set
        internal bool IsSetIpAddressType()
        {
            return this._ipAddressType != null;
        }

        /// <summary>
        /// Gets and sets the property LoadBalancerName. 
        /// <para>
        /// The name of your load balancer.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
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

        /// <summary>
        /// Gets and sets the property Tags. 
        /// <para>
        /// The tag keys and optional values to add to the resource during create.
        /// </para>
        ///  
        /// <para>
        /// Use the <c>TagResource</c> action to tag a resource after it's created.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<Tag> Tags
        {
            get { return this._tags; }
            set { this._tags = value; }
        }

        // Check to see if Tags property is set
        internal bool IsSetTags()
        {
            return this._tags != null && (this._tags.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property TlsPolicyName. 
        /// <para>
        /// The name of the TLS policy to apply to the load balancer.
        /// </para>
        ///  
        /// <para>
        /// Use the <a href="https://docs.aws.amazon.com/lightsail/2016-11-28/api-reference/API_GetLoadBalancerTlsPolicies.html">GetLoadBalancerTlsPolicies</a>
        /// action to get a list of TLS policy names that you can specify.
        /// </para>
        ///  
        /// <para>
        /// For more information about load balancer TLS policies, see <a href="https://docs.aws.amazon.com/lightsail/latest/userguide/amazon-lightsail-configure-load-balancer-tls-security-policy">Configuring
        /// TLS security policies on your Amazon Lightsail load balancers</a> in the <i>Amazon
        /// Lightsail Developer Guide</i>.
        /// </para>
        /// </summary>
        public string TlsPolicyName
        {
            get { return this._tlsPolicyName; }
            set { this._tlsPolicyName = value; }
        }

        // Check to see if TlsPolicyName property is set
        internal bool IsSetTlsPolicyName()
        {
            return this._tlsPolicyName != null;
        }

    }
}