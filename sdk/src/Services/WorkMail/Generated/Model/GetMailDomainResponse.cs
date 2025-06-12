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
 * Do not modify this file. This file is generated from the workmail-2017-10-01.normal.json service model.
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
namespace Amazon.WorkMail.Model
{
    /// <summary>
    /// This is the response object from the GetMailDomain operation.
    /// </summary>
    public partial class GetMailDomainResponse : AmazonWebServiceResponse
    {
        private DnsRecordVerificationStatus _dkimVerificationStatus;
        private bool? _isDefault;
        private bool? _isTestDomain;
        private DnsRecordVerificationStatus _ownershipVerificationStatus;
        private List<DnsRecord> _records = AWSConfigs.InitializeCollections ? new List<DnsRecord>() : null;

        /// <summary>
        /// Gets and sets the property DkimVerificationStatus. 
        /// <para>
        /// Indicates the status of a DKIM verification.
        /// </para>
        /// </summary>
        public DnsRecordVerificationStatus DkimVerificationStatus
        {
            get { return this._dkimVerificationStatus; }
            set { this._dkimVerificationStatus = value; }
        }

        // Check to see if DkimVerificationStatus property is set
        internal bool IsSetDkimVerificationStatus()
        {
            return this._dkimVerificationStatus != null;
        }

        /// <summary>
        /// Gets and sets the property IsDefault. 
        /// <para>
        /// Specifies whether the domain is the default domain for your organization.
        /// </para>
        /// </summary>
        public bool? IsDefault
        {
            get { return this._isDefault; }
            set { this._isDefault = value; }
        }

        // Check to see if IsDefault property is set
        internal bool IsSetIsDefault()
        {
            return this._isDefault.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property IsTestDomain. 
        /// <para>
        /// Specifies whether the domain is a test domain provided by WorkMail, or a custom domain.
        /// </para>
        /// </summary>
        public bool? IsTestDomain
        {
            get { return this._isTestDomain; }
            set { this._isTestDomain = value; }
        }

        // Check to see if IsTestDomain property is set
        internal bool IsSetIsTestDomain()
        {
            return this._isTestDomain.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property OwnershipVerificationStatus. 
        /// <para>
        ///  Indicates the status of the domain ownership verification.
        /// </para>
        /// </summary>
        public DnsRecordVerificationStatus OwnershipVerificationStatus
        {
            get { return this._ownershipVerificationStatus; }
            set { this._ownershipVerificationStatus = value; }
        }

        // Check to see if OwnershipVerificationStatus property is set
        internal bool IsSetOwnershipVerificationStatus()
        {
            return this._ownershipVerificationStatus != null;
        }

        /// <summary>
        /// Gets and sets the property Records. 
        /// <para>
        /// A list of the DNS records that WorkMail recommends adding in your DNS provider for
        /// the best user experience. The records configure your domain with DMARC, SPF, DKIM,
        /// and direct incoming email traffic to SES. See admin guide for more details.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<DnsRecord> Records
        {
            get { return this._records; }
            set { this._records = value; }
        }

        // Check to see if Records property is set
        internal bool IsSetRecords()
        {
            return this._records != null && (this._records.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

    }
}