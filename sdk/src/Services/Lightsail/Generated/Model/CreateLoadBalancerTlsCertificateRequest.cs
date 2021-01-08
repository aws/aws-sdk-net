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

namespace Amazon.Lightsail.Model
{
    /// <summary>
    /// Container for the parameters to the CreateLoadBalancerTlsCertificate operation.
    /// Creates a Lightsail load balancer TLS certificate.
    /// 
    ///  
    /// <para>
    /// TLS is just an updated, more secure version of Secure Socket Layer (SSL).
    /// </para>
    ///  
    /// <para>
    /// The <code>CreateLoadBalancerTlsCertificate</code> operation supports tag-based access
    /// control via resource tags applied to the resource identified by <code>load balancer
    /// name</code>. For more information, see the <a href="https://lightsail.aws.amazon.com/ls/docs/en/articles/amazon-lightsail-controlling-access-using-tags">Lightsail
    /// Dev Guide</a>.
    /// </para>
    /// </summary>
    public partial class CreateLoadBalancerTlsCertificateRequest : AmazonLightsailRequest
    {
        private List<string> _certificateAlternativeNames = new List<string>();
        private string _certificateDomainName;
        private string _certificateName;
        private string _loadBalancerName;
        private List<Tag> _tags = new List<Tag>();

        /// <summary>
        /// Gets and sets the property CertificateAlternativeNames. 
        /// <para>
        /// An array of strings listing alternative domains and subdomains for your SSL/TLS certificate.
        /// Lightsail will de-dupe the names for you. You can have a maximum of 9 alternative
        /// names (in addition to the 1 primary domain). We do not support wildcards (e.g., <code>*.example.com</code>).
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
        /// The domain name (e.g., <code>example.com</code>) for your SSL/TLS certificate.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
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
        /// The SSL/TLS certificate name.
        /// </para>
        ///  
        /// <para>
        /// You can have up to 10 certificates in your account at one time. Each Lightsail load
        /// balancer can have up to 2 certificates associated with it at one time. There is also
        /// an overall limit to the number of certificates that can be issue in a 365-day period.
        /// For more information, see <a href="http://docs.aws.amazon.com/acm/latest/userguide/acm-limits.html">Limits</a>.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
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
        /// Gets and sets the property LoadBalancerName. 
        /// <para>
        /// The load balancer name where you want to create the SSL/TLS certificate.
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
        /// Use the <code>TagResource</code> action to tag a resource after it's created.
        /// </para>
        /// </summary>
        public List<Tag> Tags
        {
            get { return this._tags; }
            set { this._tags = value; }
        }

        // Check to see if Tags property is set
        internal bool IsSetTags()
        {
            return this._tags != null && this._tags.Count > 0; 
        }

    }
}