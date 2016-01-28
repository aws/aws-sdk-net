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
 * Do not modify this file. This file is generated from the acm-2015-12-08.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.CertificateManager.Model
{
    /// <summary>
    /// Container for the parameters to the ResendValidationEmail operation.
    /// Resends the email that requests domain ownership validation. The domain owner or
    /// an authorized representative must approve the ACM certificate before it can be issued.
    /// The certificate can be approved by clicking a link in the mail to navigate to the
    /// Amazon certificate approval website and then clicking <b>I Approve</b>. However, the
    /// validation email can be blocked by spam filters. Therefore, if you do not receive
    /// the original mail, you can request that the mail be resent within 72 hours of requesting
    /// the ACM certificate. If more than 72 hours have elapsed since your original request
    /// or since your last attempt to resend validation mail, you must request a new certificate.
    /// </summary>
    public partial class ResendValidationEmailRequest : AmazonCertificateManagerRequest
    {
        private string _certificateArn;
        private string _domain;
        private string _validationDomain;

        /// <summary>
        /// Gets and sets the property CertificateArn. 
        /// <para>
        ///  String that contains the ARN of the requested certificate. The certificate ARN is
        /// generated and returned by <a>RequestCertificate</a> as soon as the request is made.
        /// By default, using this parameter causes email to be sent to all top level domains
        /// you specified in the certificate request. 
        /// </para>
        ///  
        /// <para>
        ///  The ARN must be of the form: 
        /// </para>
        ///  
        /// <para>
        ///  <code>arn:aws:acm:us-east-1:123456789012:certificate/12345678-1234-1234-1234-123456789012</code>
        /// 
        /// </para>
        /// </summary>
        public string CertificateArn
        {
            get { return this._certificateArn; }
            set { this._certificateArn = value; }
        }

        // Check to see if CertificateArn property is set
        internal bool IsSetCertificateArn()
        {
            return this._certificateArn != null;
        }

        /// <summary>
        /// Gets and sets the property Domain. 
        /// <para>
        ///  The Fully Qualified Domain Name (FQDN) of the certificate that needs to be validated.
        /// 
        /// </para>
        /// </summary>
        public string Domain
        {
            get { return this._domain; }
            set { this._domain = value; }
        }

        // Check to see if Domain property is set
        internal bool IsSetDomain()
        {
            return this._domain != null;
        }

        /// <summary>
        /// Gets and sets the property ValidationDomain. 
        /// <para>
        ///  The base validation domain that will act as the suffix of the email addresses that
        /// are used to send the emails. This must be the same as the <code>Domain</code> value
        /// or a super domain of the <code>Domain</code> value. For example, if you requested
        /// a certificate for <code>site.subdomain.example.com</code> and specify a <b>ValidationDomain</b>
        /// of <code>subdomain.example.com</code>, ACM sends email to the domain registrant, technical
        /// contact, and administrative contact in WHOIS and the following five addresses: <ul>
        /// <li>admin@subdomain.example.com</li> <li>administrator@subdomain.example.com</li>
        /// <li>hostmaster@subdomain.example.com</li> <li>postmaster@subdomain.example.com</li>
        /// <li>webmaster@subdomain.example.com</li> </ul> 
        /// </para>
        /// </summary>
        public string ValidationDomain
        {
            get { return this._validationDomain; }
            set { this._validationDomain = value; }
        }

        // Check to see if ValidationDomain property is set
        internal bool IsSetValidationDomain()
        {
            return this._validationDomain != null;
        }

    }
}