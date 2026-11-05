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
    /// Contains per-domain validation information for a certificate. This structure is returned
    /// as a member of the <a>ListCertificateDomainValidations</a> response.
    /// </summary>
    public partial class DomainValidationSummary
    {
        /// <summary>
        /// Gets and sets the property ActiveValidationConfiguration. 
        /// <para>
        /// The validation configuration currently in effect for this domain. This reflects the
        /// validation method that ACM is currently using to validate domain ownership (for example,
        /// email or DNS).
        /// </para>
        /// </summary>
        public ValidationConfiguration ActiveValidationConfiguration { get; set; }

        /// <summary>
        /// Checks to see if the ActiveValidationConfiguration property is set.
        /// </summary>
        internal bool IsSetActiveValidationConfiguration() => this.ActiveValidationConfiguration != null;

        /// <summary>
        /// Gets and sets the property DomainName. 
        /// <para>
        /// The fully qualified domain name (FQDN) in the certificate for which this validation
        /// summary applies.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 253)]
        public string DomainName { get; set; }

        /// <summary>
        /// Checks to see if the DomainName property is set.
        /// </summary>
        internal bool IsSetDomainName() => this.DomainName != null;

        /// <summary>
        /// Gets and sets the property RequestedValidationConfiguration. 
        /// <para>
        /// The validation configuration for a pending validation method migration. This field
        /// is present only when a migration is in progress (for example, from email to DNS validation).
        /// It contains the target validation method, the current validation status, and the validation
        /// challenge details (such as the CNAME record to add to your DNS configuration).
        /// </para>
        /// </summary>
        public ValidationConfiguration RequestedValidationConfiguration { get; set; }

        /// <summary>
        /// Checks to see if the RequestedValidationConfiguration property is set.
        /// </summary>
        internal bool IsSetRequestedValidationConfiguration() => this.RequestedValidationConfiguration != null;
    }
}
