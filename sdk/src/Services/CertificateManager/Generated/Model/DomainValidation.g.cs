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
 * Do not modify this file. This file is generated from the smithy.json service model.
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

namespace Amazon.CertificateManager.Model
{
    /// <summary>
    /// Contains information about the validation of each domain name in the certificate.
    /// </summary>
    public partial class DomainValidation
    {
        /// <summary>
        /// Gets and sets the property DomainName. 
        /// <para>
        /// A fully qualified domain name (FQDN) in the certificate. For example, <c>www.example.com</c>
        /// or <c>example.com</c>. 
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 253)]
        public string DomainName { get; set; }

        /// <summary>
        /// Checks to see if the DomainName property is set.
        /// </summary>
        internal bool IsSetDomainName() => this.DomainName != null;

        /// <summary>
        /// Gets and sets the property HttpRedirect. 
        /// <para>
        /// Contains information for HTTP-based domain validation of certificates requested through
        /// Amazon CloudFront and issued by ACM. This field exists only when the certificate type
        /// is <c>AMAZON_ISSUED</c> and the validation method is <c>HTTP</c>.
        /// </para>
        /// </summary>
        public HttpRedirect HttpRedirect { get; set; }

        /// <summary>
        /// Checks to see if the HttpRedirect property is set.
        /// </summary>
        internal bool IsSetHttpRedirect() => this.HttpRedirect != null;

        /// <summary>
        /// Gets and sets the property ResourceRecord. 
        /// <para>
        /// Contains the CNAME record that you add to your DNS database for domain validation.
        /// For more information, see <a href="https://docs.aws.amazon.com/acm/latest/userguide/gs-acm-validate-dns.html">Use
        /// DNS to Validate Domain Ownership</a>.
        /// </para>
        ///  <note> 
        /// <para>
        /// The CNAME information that you need does not include the name of your domain. If you
        /// include your domain name in the DNS database CNAME record, validation fails. For example,
        /// if the name is <c>_a79865eb4cd1a6ab990a45779b4e0b96.yourdomain.com</c>, only <c>_a79865eb4cd1a6ab990a45779b4e0b96</c>
        /// must be used.
        /// </para>
        ///  </note>
        /// </summary>
        public ResourceRecord ResourceRecord { get; set; }

        /// <summary>
        /// Checks to see if the ResourceRecord property is set.
        /// </summary>
        internal bool IsSetResourceRecord() => this.ResourceRecord != null;

        /// <summary>
        /// Gets and sets the property ValidationDomain. 
        /// <para>
        /// The domain name that ACM used to send domain validation emails.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 253)]
        public string ValidationDomain { get; set; }

        /// <summary>
        /// Checks to see if the ValidationDomain property is set.
        /// </summary>
        internal bool IsSetValidationDomain() => this.ValidationDomain != null;

        /// <summary>
        /// Gets and sets the property ValidationEmails. 
        /// <para>
        /// A list of email addresses that ACM used to send domain validation emails.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<string> ValidationEmails { get; set; } = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Checks to see if the ValidationEmails property is set.
        /// </summary>
        internal bool IsSetValidationEmails() => this.ValidationEmails != null && (this.ValidationEmails.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property ValidationMethod. 
        /// <para>
        /// Specifies the domain validation method.
        /// </para>
        /// </summary>
        public ValidationMethod ValidationMethod { get; set; }

        /// <summary>
        /// Checks to see if the ValidationMethod property is set.
        /// </summary>
        internal bool IsSetValidationMethod() => this.ValidationMethod != null;

        /// <summary>
        /// Gets and sets the property ValidationStatus. 
        /// <para>
        /// The validation status of the domain name. This can be one of the following values:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <c>PENDING_VALIDATION</c> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code/>SUCCESS
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code/>FAILED
        /// </para>
        ///  </li> </ul>
        /// </summary>
        public DomainStatus ValidationStatus { get; set; }

        /// <summary>
        /// Checks to see if the ValidationStatus property is set.
        /// </summary>
        internal bool IsSetValidationStatus() => this.ValidationStatus != null;
    }
}
