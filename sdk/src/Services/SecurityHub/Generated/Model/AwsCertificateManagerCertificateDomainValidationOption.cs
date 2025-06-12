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
 * Do not modify this file. This file is generated from the securityhub-2018-10-26.normal.json service model.
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
        private string _domainName;
        private AwsCertificateManagerCertificateResourceRecord _resourceRecord;
        private string _validationDomain;
        private List<string> _validationEmails = AWSConfigs.InitializeCollections ? new List<string>() : null;
        private string _validationMethod;
        private string _validationStatus;

        /// <summary>
        /// Gets and sets the property DomainName. 
        /// <para>
        /// A fully qualified domain name (FQDN) in the certificate.
        /// </para>
        /// </summary>
        public string DomainName
        {
            get { return this._domainName; }
            set { this._domainName = value; }
        }

        // Check to see if DomainName property is set
        internal bool IsSetDomainName()
        {
            return this._domainName != null;
        }

        /// <summary>
        /// Gets and sets the property ResourceRecord. 
        /// <para>
        /// The CNAME record that is added to the DNS database for domain validation.
        /// </para>
        /// </summary>
        public AwsCertificateManagerCertificateResourceRecord ResourceRecord
        {
            get { return this._resourceRecord; }
            set { this._resourceRecord = value; }
        }

        // Check to see if ResourceRecord property is set
        internal bool IsSetResourceRecord()
        {
            return this._resourceRecord != null;
        }

        /// <summary>
        /// Gets and sets the property ValidationDomain. 
        /// <para>
        /// The domain name that Certificate Manager uses to send domain validation emails.
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

        /// <summary>
        /// Gets and sets the property ValidationEmails. 
        /// <para>
        /// A list of email addresses that Certificate Manager uses to send domain validation
        /// emails.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<string> ValidationEmails
        {
            get { return this._validationEmails; }
            set { this._validationEmails = value; }
        }

        // Check to see if ValidationEmails property is set
        internal bool IsSetValidationEmails()
        {
            return this._validationEmails != null && (this._validationEmails.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property ValidationMethod. 
        /// <para>
        /// The method used to validate the domain name.
        /// </para>
        /// </summary>
        public string ValidationMethod
        {
            get { return this._validationMethod; }
            set { this._validationMethod = value; }
        }

        // Check to see if ValidationMethod property is set
        internal bool IsSetValidationMethod()
        {
            return this._validationMethod != null;
        }

        /// <summary>
        /// Gets and sets the property ValidationStatus. 
        /// <para>
        /// The validation status of the domain name.
        /// </para>
        /// </summary>
        public string ValidationStatus
        {
            get { return this._validationStatus; }
            set { this._validationStatus = value; }
        }

        // Check to see if ValidationStatus property is set
        internal bool IsSetValidationStatus()
        {
            return this._validationStatus != null;
        }

    }
}