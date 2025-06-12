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
 * Do not modify this file. This file is generated from the lightsail-2016-11-28.normal.json service model.
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
namespace Amazon.Lightsail.Model
{
    /// <summary>
    /// Describes the status of a SSL/TLS certificate renewal managed by Amazon Lightsail.
    /// </summary>
    public partial class RenewalSummary
    {
        private List<DomainValidationRecord> _domainValidationRecords = AWSConfigs.InitializeCollections ? new List<DomainValidationRecord>() : null;
        private RenewalStatus _renewalStatus;
        private string _renewalStatusReason;
        private DateTime? _updatedAt;

        /// <summary>
        /// Gets and sets the property DomainValidationRecords. 
        /// <para>
        /// An array of objects that describe the domain validation records of the certificate.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<DomainValidationRecord> DomainValidationRecords
        {
            get { return this._domainValidationRecords; }
            set { this._domainValidationRecords = value; }
        }

        // Check to see if DomainValidationRecords property is set
        internal bool IsSetDomainValidationRecords()
        {
            return this._domainValidationRecords != null && (this._domainValidationRecords.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property RenewalStatus. 
        /// <para>
        /// The renewal status of the certificate.
        /// </para>
        ///  
        /// <para>
        /// The following renewal status are possible:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <b> <c>PendingAutoRenewal</c> </b> - Lightsail is attempting to automatically validate
        /// the domain names of the certificate. No further action is required. 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <b> <c>PendingValidation</c> </b> - Lightsail couldn't automatically validate one
        /// or more domain names of the certificate. You must take action to validate these domain
        /// names or the certificate won't be renewed. Check to make sure your certificate's domain
        /// validation records exist in your domain's DNS, and that your certificate remains in
        /// use.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <b> <c>Success</c> </b> - All domain names in the certificate are validated, and
        /// Lightsail renewed the certificate. No further action is required. 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <b> <c>Failed</c> </b> - One or more domain names were not validated before the certificate
        /// expired, and Lightsail did not renew the certificate. You can request a new certificate
        /// using the <c>CreateCertificate</c> action.
        /// </para>
        ///  </li> </ul>
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

        /// <summary>
        /// Gets and sets the property RenewalStatusReason. 
        /// <para>
        /// The reason for the renewal status of the certificate.
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
        /// The timestamp when the certificate was last updated.
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