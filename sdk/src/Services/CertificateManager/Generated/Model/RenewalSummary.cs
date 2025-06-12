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
 * Do not modify this file. This file is generated from the acm-2015-12-08.normal.json service model.
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
    /// Contains information about the status of ACM's <a href="https://docs.aws.amazon.com/acm/latest/userguide/acm-renewal.html">managed
    /// renewal</a> for the certificate. This structure exists only when the certificate type
    /// is <c>AMAZON_ISSUED</c>.
    /// </summary>
    public partial class RenewalSummary
    {
        private List<DomainValidation> _domainValidationOptions = AWSConfigs.InitializeCollections ? new List<DomainValidation>() : null;
        private RenewalStatus _renewalStatus;
        private FailureReason _renewalStatusReason;
        private DateTime? _updatedAt;

        /// <summary>
        /// Gets and sets the property DomainValidationOptions. 
        /// <para>
        /// Contains information about the validation of each domain name in the certificate,
        /// as it pertains to ACM's <a href="https://docs.aws.amazon.com/acm/latest/userguide/acm-renewal.html">managed
        /// renewal</a>. This is different from the initial validation that occurs as a result
        /// of the <a>RequestCertificate</a> request. This field exists only when the certificate
        /// type is <c>AMAZON_ISSUED</c>.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=1000)]
        public List<DomainValidation> DomainValidationOptions
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
        /// The status of ACM's <a href="https://docs.aws.amazon.com/acm/latest/userguide/acm-renewal.html">managed
        /// renewal</a> of the certificate.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public RenewalStatus RenewalStatus
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
        /// The reason that a renewal request was unsuccessful.
        /// </para>
        /// </summary>
        public FailureReason RenewalStatusReason
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
        /// The time at which the renewal summary was last updated.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public DateTime? UpdatedAt
        {
            get { return this._updatedAt; }
            set { this._updatedAt = value; }
        }

        // Check to see if UpdatedAt property is set
        internal bool IsSetUpdatedAt()
        {
            return this._updatedAt.HasValue; 
        }

    }
}