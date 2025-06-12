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
    /// Contains information about the Certificate Manager managed renewal for an <c>AMAZON_ISSUED</c>
    /// certificate.
    /// </summary>
    public partial class AwsCertificateManagerCertificateRenewalSummary
    {
        private List<AwsCertificateManagerCertificateDomainValidationOption> _domainValidationOptions = AWSConfigs.InitializeCollections ? new List<AwsCertificateManagerCertificateDomainValidationOption>() : null;
        private string _renewalStatus;
        private string _renewalStatusReason;
        private string _updatedAt;

        /// <summary>
        /// Gets and sets the property DomainValidationOptions. 
        /// <para>
        /// Information about the validation of each domain name in the certificate, as it pertains
        /// to Certificate Manager managed renewal. Provided only when the certificate type is
        /// <c>AMAZON_ISSUED</c>.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<AwsCertificateManagerCertificateDomainValidationOption> DomainValidationOptions
        {
            get { return this._domainValidationOptions; }
            set { this._domainValidationOptions = value; }
        }

        // Check to see if DomainValidationOptions property is set
        internal bool IsSetDomainValidationOptions()
        {
            return this._domainValidationOptions != null && (this._domainValidationOptions.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property RenewalStatus. 
        /// <para>
        /// The status of the Certificate Manager managed renewal of the certificate.
        /// </para>
        ///  
        /// <para>
        /// Valid values: <c>PENDING_AUTO_RENEWAL</c> | <c>PENDING_VALIDATION</c> | <c>SUCCESS</c>
        /// | <c>FAILED</c> 
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
        /// <c>RenewalStatus</c> is <c>FAILED</c>.
        /// </para>
        ///  
        /// <para>
        /// Valid values: <c>NO_AVAILABLE_CONTACTS</c> | <c>ADDITIONAL_VERIFICATION_REQUIRED</c>
        /// | <c>DOMAIN_NOT_ALLOWED</c> | <c>INVALID_PUBLIC_DOMAIN</c> | <c>DOMAIN_VALIDATION_DENIED</c>
        /// | <c>CAA_ERROR</c> | <c>PCA_LIMIT_EXCEEDED</c> | <c>PCA_INVALID_ARN</c> | <c>PCA_INVALID_STATE</c>
        /// | <c>PCA_REQUEST_FAILED</c> | <c>PCA_NAME_CONSTRAINTS_VALIDATION</c> | <c>PCA_RESOURCE_NOT_FOUND</c>
        /// | <c>PCA_INVALID_ARGS</c> | <c>PCA_INVALID_DURATION</c> | <c>PCA_ACCESS_DENIED</c>
        /// | <c>SLR_NOT_FOUND</c> | <c>OTHER</c> 
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
        /// For more information about the validation and formatting of timestamp fields in Security
        /// Hub, see <a href="https://docs.aws.amazon.com/securityhub/1.0/APIReference/Welcome.html#timestamps">Timestamps</a>.
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