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
    /// Contains information about the status of ACM's <a href="http://docs.aws.amazon.com/http:/docs.aws.amazon.comacm/latest/userguide/acm-renewal.html">managed
    /// renewal</a> for the certificate. This structure exists only when the certificate type
    /// is <code>AMAZON_ISSUED</code>.
    /// </summary>
    public partial class RenewalSummary
    {
        private List<DomainValidation> _domainValidationOptions = new List<DomainValidation>();
        private RenewalStatus _renewalStatus;

        /// <summary>
        /// Gets and sets the property DomainValidationOptions. 
        /// <para>
        /// Contains information about the validation of each domain name in the certificate,
        /// as it pertains to ACM's <a href="http://docs.aws.amazon.com/http:/docs.aws.amazon.comacm/latest/userguide/acm-renewal.html">managed
        /// renewal</a>. This is different from the initial validation that occurs as a result
        /// of the <a>RequestCertificate</a> request. This field exists only when the certificate
        /// type is <code>AMAZON_ISSUED</code>.
        /// </para>
        /// </summary>
        public List<DomainValidation> DomainValidationOptions
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
        /// The status of ACM's <a href="http://docs.aws.amazon.com/http:/docs.aws.amazon.comacm/latest/userguide/acm-renewal.html">managed
        /// renewal</a> of the certificate.
        /// </para>
        /// </summary>
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

    }
}