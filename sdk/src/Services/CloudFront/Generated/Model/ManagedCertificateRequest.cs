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
 * Do not modify this file. This file is generated from the cloudfront-2020-05-31.normal.json service model.
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
namespace Amazon.CloudFront.Model
{
    /// <summary>
    /// An object that represents the request for the Amazon CloudFront managed ACM certificate.
    /// </summary>
    public partial class ManagedCertificateRequest
    {
        private CertificateTransparencyLoggingPreference _certificateTransparencyLoggingPreference;
        private string _primaryDomainName;
        private ValidationTokenHost _validationTokenHost;

        /// <summary>
        /// Gets and sets the property CertificateTransparencyLoggingPreference. 
        /// <para>
        /// You can opt out of certificate transparency logging by specifying the <c>disabled</c>
        /// option. Opt in by specifying <c>enabled</c>. For more information, see <a href="https://docs.aws.amazon.com/acm/latest/userguide/acm-concepts.html#concept-transparency">Certificate
        /// Transparency Logging </a> in the <i>Certificate Manager User Guide</i>.
        /// </para>
        /// </summary>
        public CertificateTransparencyLoggingPreference CertificateTransparencyLoggingPreference
        {
            get { return this._certificateTransparencyLoggingPreference; }
            set { this._certificateTransparencyLoggingPreference = value; }
        }

        // Check to see if CertificateTransparencyLoggingPreference property is set
        internal bool IsSetCertificateTransparencyLoggingPreference()
        {
            return this._certificateTransparencyLoggingPreference != null;
        }

        /// <summary>
        /// Gets and sets the property PrimaryDomainName. 
        /// <para>
        /// The primary domain name associated with the CloudFront managed ACM certificate.
        /// </para>
        /// </summary>
        public string PrimaryDomainName
        {
            get { return this._primaryDomainName; }
            set { this._primaryDomainName = value; }
        }

        // Check to see if PrimaryDomainName property is set
        internal bool IsSetPrimaryDomainName()
        {
            return this._primaryDomainName != null;
        }

        /// <summary>
        /// Gets and sets the property ValidationTokenHost. 
        /// <para>
        /// Specify how the HTTP validation token will be served when requesting the CloudFront
        /// managed ACM certificate.
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// For <c>cloudfront</c>, CloudFront will automatically serve the validation token. Choose
        /// this mode if you can point the domain's DNS to CloudFront immediately.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// For <c>self-hosted</c>, you serve the validation token from your existing infrastructure.
        /// Choose this mode when you need to maintain current traffic flow while your certificate
        /// is being issued. You can place the validation token at the well-known path on your
        /// existing web server, wait for ACM to validate and issue the certificate, and then
        /// update your DNS to point to CloudFront.
        /// </para>
        ///  </li> </ul>
        /// </summary>
        [AWSProperty(Required=true)]
        public ValidationTokenHost ValidationTokenHost
        {
            get { return this._validationTokenHost; }
            set { this._validationTokenHost = value; }
        }

        // Check to see if ValidationTokenHost property is set
        internal bool IsSetValidationTokenHost()
        {
            return this._validationTokenHost != null;
        }

    }
}