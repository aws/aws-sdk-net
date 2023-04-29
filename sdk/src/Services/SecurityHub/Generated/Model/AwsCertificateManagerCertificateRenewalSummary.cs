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

namespace Amazon.SecurityHub.Model
{
    /// <summary>
    /// Contains information about the Certificate Manager managed renewal for an <code>AMAZON_ISSUED</code>
    /// certificate.
    /// </summary>
    public partial class AwsCertificateManagerCertificateRenewalSummary
    {
        private List<AwsCertificateManagerCertificateDomainValidationOption> _domainValidationOptions = new List<AwsCertificateManagerCertificateDomainValidationOption>();
        private string _renewalStatus;
        private string _renewalStatusReason;
        private string _updatedAt;

        /// <summary>
        /// Gets and sets the property DomainValidationOptions. 
        /// <para>
        /// Information about the validation of each domain name in the certificate, as it pertains
        /// to Certificate Manager managed renewal. Provided only when the certificate type is
        /// <code>AMAZON_ISSUED</code>.
        /// </para>
        /// </summary>
        public List<AwsCertificateManagerCertificateDomainValidationOption> DomainValidationOptions
        {
            get { return this._domainValidationOptions; }
            set { this._domainValidationOptions = value; }
        }

        // Check to see if DomainValidationOptions property is set
        internal bool IsSetDomainValidationOptions()
        {
            return this._domainValidationOptions != null && this._domainValidationOptions.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property RenewalStatus. 
        /// <para>
        /// The status of the Certificate Manager managed renewal of the certificate.
        /// </para>
        ///  
        /// <para>
        /// Valid values: <code>PENDING_AUTO_RENEWAL</code> | <code>PENDING_VALIDATION</code>
        /// | <code>SUCCESS</code> | <code>FAILED</code> 
        /// </para>
        /// </summary>
        public string RenewalStatus
        {
            get { return this._renewalStatus; }
            set { this._renewalStatus = value; }
        }

        // Check to see if RenewalStatus property is set
        internal bool IsSetRenewalStatus()
        {
            return this._renewalStatus != null;
        }

        /// <summary>
        /// Gets and sets the property RenewalStatusReason. 
        /// <para>
        /// The reason that a renewal request was unsuccessful. This attribute is used only when
        /// <code>RenewalStatus</code> is <code>FAILED</code>.
        /// </para>
        ///  
        /// <para>
        /// Valid values: <code>NO_AVAILABLE_CONTACTS</code> | <code>ADDITIONAL_VERIFICATION_REQUIRED</code>
        /// | <code>DOMAIN_NOT_ALLOWED</code> | <code>INVALID_PUBLIC_DOMAIN</code> | <code>DOMAIN_VALIDATION_DENIED</code>
        /// | <code>CAA_ERROR</code> | <code>PCA_LIMIT_EXCEEDED</code> | <code>PCA_INVALID_ARN</code>
        /// | <code>PCA_INVALID_STATE</code> | <code>PCA_REQUEST_FAILED</code> | <code>PCA_NAME_CONSTRAINTS_VALIDATION</code>
        /// | <code>PCA_RESOURCE_NOT_FOUND</code> | <code>PCA_INVALID_ARGS</code> | <code>PCA_INVALID_DURATION</code>
        /// | <code>PCA_ACCESS_DENIED</code> | <code>SLR_NOT_FOUND</code> | <code>OTHER</code>
        /// 
        /// </para>
        /// </summary>
        public string RenewalStatusReason
        {
            get { return this._renewalStatusReason; }
            set { this._renewalStatusReason = value; }
        }

        // Check to see if RenewalStatusReason property is set
        internal bool IsSetRenewalStatusReason()
        {
            return this._renewalStatusReason != null;
        }

        /// <summary>
        /// Gets and sets the property UpdatedAt. 
        /// <para>
        /// Indicates when the renewal summary was last updated.
        /// </para>
        ///  
        /// <para>
        /// Uses the <code>date-time</code> format specified in <a href="https://tools.ietf.org/html/rfc3339#section-5.6">RFC
        /// 3339 section 5.6, Internet Date/Time Format</a>. The value cannot contain spaces,
        /// and date and time should be separated by <code>T</code>. For example, <code>2020-03-22T13:22:13.933Z</code>.
        /// </para>
        /// </summary>
        public string UpdatedAt
        {
            get { return this._updatedAt; }
            set { this._updatedAt = value; }
        }

        // Check to see if UpdatedAt property is set
        internal bool IsSetUpdatedAt()
        {
            return this._updatedAt != null;
        }

    }
}