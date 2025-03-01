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
    /// Container for the parameters to the AttachLoadBalancerTlsCertificate operation.
    /// Attaches a Transport Layer Security (TLS) certificate to your load balancer. TLS is
    /// just an updated, more secure version of Secure Socket Layer (SSL).
    /// 
    ///  
    /// <para>
    /// Once you create and validate your certificate, you can attach it to your load balancer.
    /// You can also use this API to rotate the certificates on your account. Use the <c>AttachLoadBalancerTlsCertificate</c>
    /// action with the non-attached certificate, and it will replace the existing one and
    /// become the attached certificate.
    /// </para>
    ///  
    /// <para>
    /// The <c>AttachLoadBalancerTlsCertificate</c> operation supports tag-based access control
    /// via resource tags applied to the resource identified by <c>load balancer name</c>.
    /// For more information, see the <a href="https://docs.aws.amazon.com/lightsail/latest/userguide/amazon-lightsail-controlling-access-using-tags">Amazon
    /// Lightsail Developer Guide</a>.
    /// </para>
    /// </summary>
    public partial class AttachLoadBalancerTlsCertificateRequest : AmazonLightsailRequest
    {
        private string _certificateName;
        private string _loadBalancerName;

        /// <summary>
        /// Gets and sets the property CertificateName. 
        /// <para>
        /// The name of your SSL/TLS certificate.
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
        /// The name of the load balancer to which you want to associate the SSL/TLS certificate.
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

    }
}