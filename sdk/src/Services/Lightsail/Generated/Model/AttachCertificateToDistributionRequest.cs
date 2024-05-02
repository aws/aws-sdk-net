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
    /// Container for the parameters to the AttachCertificateToDistribution operation.
    /// Attaches an SSL/TLS certificate to your Amazon Lightsail content delivery network
    /// (CDN) distribution.
    /// 
    ///  
    /// <para>
    /// After the certificate is attached, your distribution accepts HTTPS traffic for all
    /// of the domains that are associated with the certificate.
    /// </para>
    ///  
    /// <para>
    /// Use the <c>CreateCertificate</c> action to create a certificate that you can attach
    /// to your distribution.
    /// </para>
    ///  <important> 
    /// <para>
    /// Only certificates created in the <c>us-east-1</c> Amazon Web Services Region can be
    /// attached to Lightsail distributions. Lightsail distributions are global resources
    /// that can reference an origin in any Amazon Web Services Region, and distribute its
    /// content globally. However, all distributions are located in the <c>us-east-1</c> Region.
    /// </para>
    ///  </important>
    /// </summary>
    public partial class AttachCertificateToDistributionRequest : AmazonLightsailRequest
    {
        private string _certificateName;
        private string _distributionName;

        /// <summary>
        /// Gets and sets the property CertificateName. 
        /// <para>
        /// The name of the certificate to attach to a distribution.
        /// </para>
        ///  
        /// <para>
        /// Only certificates with a status of <c>ISSUED</c> can be attached to a distribution.
        /// </para>
        ///  
        /// <para>
        /// Use the <c>GetCertificates</c> action to get a list of certificate names that you
        /// can specify.
        /// </para>
        ///  <note> 
        /// <para>
        /// This is the name of the certificate resource type and is used only to reference the
        /// certificate in other API actions. It can be different than the domain name of the
        /// certificate. For example, your certificate name might be <c>WordPress-Blog-Certificate</c>
        /// and the domain name of the certificate might be <c>example.com</c>.
        /// </para>
        ///  </note>
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
        /// Gets and sets the property DistributionName. 
        /// <para>
        /// The name of the distribution that the certificate will be attached to.
        /// </para>
        ///  
        /// <para>
        /// Use the <c>GetDistributions</c> action to get a list of distribution names that you
        /// can specify.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string DistributionName
        {
            get { return this._distributionName; }
            set { this._distributionName = value; }
        }

        // Check to see if DistributionName property is set
        internal bool IsSetDistributionName()
        {
            return this._distributionName != null;
        }

    }
}