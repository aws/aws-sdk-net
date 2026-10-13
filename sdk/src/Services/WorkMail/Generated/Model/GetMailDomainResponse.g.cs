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

namespace Amazon.WorkMail.Model
{
    /// <summary>
    /// This is the response object from the GetMailDomain operation.
    /// </summary>
    public partial class GetMailDomainResponse : AmazonWebServiceResponse
    {
        /// <summary>
        /// Gets and sets the property DkimVerificationStatus. 
        /// <para>
        /// Indicates the status of a DKIM verification.
        /// </para>
        /// </summary>
        public DnsRecordVerificationStatus DkimVerificationStatus { get; set; }

        /// <summary>
        /// Checks to see if the DkimVerificationStatus property is set.
        /// </summary>
        internal bool IsSetDkimVerificationStatus() => this.DkimVerificationStatus != null;

        /// <summary>
        /// Gets and sets the property IsDefault. 
        /// <para>
        /// Specifies whether the domain is the default domain for your organization.
        /// </para>
        /// </summary>
        public bool? IsDefault { get; set; }

        /// <summary>
        /// Checks to see if the IsDefault property is set.
        /// </summary>
        internal bool IsSetIsDefault() => this.IsDefault.HasValue;

        /// <summary>
        /// Gets and sets the property IsTestDomain. 
        /// <para>
        /// Specifies whether the domain is a test domain provided by WorkMail, or a custom domain.
        /// </para>
        /// </summary>
        public bool? IsTestDomain { get; set; }

        /// <summary>
        /// Checks to see if the IsTestDomain property is set.
        /// </summary>
        internal bool IsSetIsTestDomain() => this.IsTestDomain.HasValue;

        /// <summary>
        /// Gets and sets the property OwnershipVerificationStatus. 
        /// <para>
        ///  Indicates the status of the domain ownership verification.
        /// </para>
        /// </summary>
        public DnsRecordVerificationStatus OwnershipVerificationStatus { get; set; }

        /// <summary>
        /// Checks to see if the OwnershipVerificationStatus property is set.
        /// </summary>
        internal bool IsSetOwnershipVerificationStatus() => this.OwnershipVerificationStatus != null;

        /// <summary>
        /// Gets and sets the property Records. 
        /// <para>
        /// A list of the DNS records that WorkMail recommends adding in your DNS provider for
        /// the best user experience. The records configure your domain with DMARC, SPF, DKIM,
        /// and direct incoming email traffic to SES. See admin guide for more details.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<DnsRecord> Records { get; set; } = AWSConfigs.InitializeCollections ? new List<DnsRecord>() : null;

        /// <summary>
        /// Checks to see if the Records property is set.
        /// </summary>
        internal bool IsSetRecords() => this.Records != null && (this.Records.Count > 0 || !AWSConfigs.InitializeCollections);
    }
}
