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
    /// Container for the parameters to the CreateLoadBalancerTlsCertificate operation.
    /// Creates a Lightsail load balancer TLS certificate.
    /// 
    ///  
    /// <para>
    /// TLS is just an updated, more secure version of Secure Socket Layer (SSL).
    /// </para>
    /// </summary>
    public partial class CreateLoadBalancerTlsCertificateRequest : AmazonLightsailRequest
    {
        private List<string> _certificateAlternativeNames = new List<string>();
        private string _certificateDomainName;
        private string _certificateName;
        private string _loadBalancerName;

        /// <summary>
        /// Gets and sets the property CertificateAlternativeNames. 
        /// <para>
        /// An array of strings listing alternative domain names for your TLS/SSL certificate.
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
        /// The domain name (e.g., <code>example.com</code>) for your TLS/SSL certificate.
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
        /// The TLS/SSL certificate name.
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
        /// Gets and sets the property LoadBalancerName. 
        /// <para>
        /// The load balancer name where you want to create the TLS/SSL certificate.
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