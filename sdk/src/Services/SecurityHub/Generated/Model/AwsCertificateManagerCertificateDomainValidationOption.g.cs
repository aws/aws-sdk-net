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

namespace Amazon.SecurityHub.Model
{
    /// <summary>
    /// Contains information about one of the following:
    /// 
    ///  <ul> <li> 
    /// <para>
    /// The initial validation of each domain name that occurs as a result of the <c>RequestCertificate</c>
    /// request
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// The validation of each domain name in the certificate, as it pertains to Certificate
    /// Manager managed renewal
    /// </para>
    ///  </li> </ul>
    /// </summary>
    public partial class AwsCertificateManagerCertificateDomainValidationOption
    {
        /// <summary>
        /// Gets and sets the property DomainName. 
        /// <para>
        /// A fully qualified domain name (FQDN) in the certificate.
        /// </para>
        /// </summary>
        public string DomainName { get; set; }

        /// <summary>
        /// Checks to see if the DomainName property is set.
        /// </summary>
        internal bool IsSetDomainName() => this.DomainName != null;

        /// <summary>
        /// Gets and sets the property ResourceRecord. 
        /// <para>
        /// The CNAME record that is added to the DNS database for domain validation.
        /// </para>
        /// </summary>
        public AwsCertificateManagerCertificateResourceRecord ResourceRecord { get; set; }

        /// <summary>
        /// Checks to see if the ResourceRecord property is set.
        /// </summary>
        internal bool IsSetResourceRecord() => this.ResourceRecord != null;

        /// <summary>
        /// Gets and sets the property ValidationDomain. 
        /// <para>
        /// The domain name that Certificate Manager uses to send domain validation emails.
        /// </para>
        /// </summary>
        public string ValidationDomain { get; set; }

        /// <summary>
        /// Checks to see if the ValidationDomain property is set.
        /// </summary>
        internal bool IsSetValidationDomain() => this.ValidationDomain != null;

        /// <summary>
        /// Gets and sets the property ValidationEmails. 
        /// <para>
        /// A list of email addresses that Certificate Manager uses to send domain validation
        /// emails.
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
        /// The method used to validate the domain name.
        /// </para>
        /// </summary>
        public string ValidationMethod { get; set; }

        /// <summary>
        /// Checks to see if the ValidationMethod property is set.
        /// </summary>
        internal bool IsSetValidationMethod() => this.ValidationMethod != null;

        /// <summary>
        /// Gets and sets the property ValidationStatus. 
        /// <para>
        /// The validation status of the domain name.
        /// </para>
        /// </summary>
        public string ValidationStatus { get; set; }

        /// <summary>
        /// Checks to see if the ValidationStatus property is set.
        /// </summary>
        internal bool IsSetValidationStatus() => this.ValidationStatus != null;
    }
}
