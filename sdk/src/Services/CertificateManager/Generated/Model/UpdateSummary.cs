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
    /// Contains information about the most recent certificate update, such as a domain validation
    /// method migration. This structure is returned as part of the <a>CertificateDetail</a>
    /// response from <a>DescribeCertificate</a>.
    /// </summary>
    public partial class UpdateSummary
    {
        private DomainValidationMethodUpdateSummary _domainValidationMethodUpdateSummary;
        private DateTime? _requestedAt;
        private UpdateStatus _status;
        private UpdateType _type;
        private DateTime? _updatedAt;

        /// <summary>
        /// Gets and sets the property DomainValidationMethodUpdateSummary. 
        /// <para>
        /// Contains information about a domain validation method migration, including the previous
        /// and target validation methods.
        /// </para>
        /// </summary>
        public DomainValidationMethodUpdateSummary DomainValidationMethodUpdateSummary
        {
            get { return this._domainValidationMethodUpdateSummary; }
            set { this._domainValidationMethodUpdateSummary = value; }
        }

        // Check to see if DomainValidationMethodUpdateSummary property is set
        internal bool IsSetDomainValidationMethodUpdateSummary()
        {
            return this._domainValidationMethodUpdateSummary != null;
        }

        /// <summary>
        /// Gets and sets the property RequestedAt. 
        /// <para>
        /// The time at which the certificate update was requested.
        /// </para>
        /// </summary>
        public DateTime? RequestedAt
        {
            get { return this._requestedAt; }
            set { this._requestedAt = value; }
        }

        // Check to see if RequestedAt property is set
        internal bool IsSetRequestedAt()
        {
            return this._requestedAt.HasValue; 
        }

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
        public UpdateStatus Status
        {
            get { return this._status; }
            set { this._status = value; }
        }

        // Check to see if Status property is set
        internal bool IsSetStatus()
        {
            return this._status != null;
        }

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
        public UpdateType Type
        {
            get { return this._type; }
            set { this._type = value; }
        }

        // Check to see if Type property is set
        internal bool IsSetType()
        {
            return this._type != null;
        }

        /// <summary>
        /// Gets and sets the property UpdatedAt. 
        /// <para>
        /// The time at which the certificate update status was last changed.
        /// </para>
        /// </summary>
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