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
    /// Contains information about the most recent certificate update, such as a domain validation
    /// method migration. This structure is returned as part of the <a>CertificateDetail</a>
    /// response from <a>DescribeCertificate</a>.
    /// </summary>
    public partial class UpdateSummary
    {
        /// <summary>
        /// Gets and sets the property DomainValidationMethodUpdateSummary. 
        /// <para>
        /// Contains information about a domain validation method migration, including the previous
        /// and target validation methods.
        /// </para>
        /// </summary>
        public DomainValidationMethodUpdateSummary DomainValidationMethodUpdateSummary { get; set; }

        /// <summary>
        /// Checks to see if the DomainValidationMethodUpdateSummary property is set.
        /// </summary>
        internal bool IsSetDomainValidationMethodUpdateSummary() => this.DomainValidationMethodUpdateSummary != null;

        /// <summary>
        /// Gets and sets the property RequestedAt. 
        /// <para>
        /// The time at which the certificate update was requested.
        /// </para>
        /// </summary>
        public DateTime? RequestedAt { get; set; }

        /// <summary>
        /// Checks to see if the RequestedAt property is set.
        /// </summary>
        internal bool IsSetRequestedAt() => this.RequestedAt.HasValue;

        /// <summary>
        /// Gets and sets the property Status. 
        /// <para>
        /// The status of the certificate update. The following are valid values:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <c>PENDING_DOMAIN_VALIDATION</c> – The certificate update is waiting for domain ownership
        /// validation to complete.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>SUCCESS</c> – The certificate was updated successfully.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>FAILED</c> – The certificate update failed.
        /// </para>
        ///  </li> </ul>
        /// </summary>
        public UpdateStatus Status { get; set; }

        /// <summary>
        /// Checks to see if the Status property is set.
        /// </summary>
        internal bool IsSetStatus() => this.Status != null;

        /// <summary>
        /// Gets and sets the property Type. 
        /// <para>
        /// The type of update that was requested for the certificate. The following are valid
        /// values:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <c>DOMAIN_VALIDATION_METHOD</c> – The update changes the domain validation method
        /// for the certificate.
        /// </para>
        ///  </li> </ul>
        /// </summary>
        public UpdateType Type { get; set; }

        /// <summary>
        /// Checks to see if the Type property is set.
        /// </summary>
        internal bool IsSetType() => this.Type != null;

        /// <summary>
        /// Gets and sets the property UpdatedAt. 
        /// <para>
        /// The time at which the certificate update status was last changed.
        /// </para>
        /// </summary>
        public DateTime? UpdatedAt { get; set; }

        /// <summary>
        /// Checks to see if the UpdatedAt property is set.
        /// </summary>
        internal bool IsSetUpdatedAt() => this.UpdatedAt.HasValue;
    }
}
