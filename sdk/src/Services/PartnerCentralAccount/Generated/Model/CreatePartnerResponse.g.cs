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

namespace Amazon.PartnerCentralAccount.Model
{
    /// <summary>
    /// This is the response object from the CreatePartner operation.
    /// </summary>
    public partial class CreatePartnerResponse : AmazonWebServiceResponse
    {
        /// <summary>
        /// Gets and sets the property AllianceLeadContact. 
        /// <para>
        /// The alliance lead contact information for the partner account.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public AllianceLeadContact AllianceLeadContact { get; set; }

        /// <summary>
        /// Checks to see if the AllianceLeadContact property is set.
        /// </summary>
        internal bool IsSetAllianceLeadContact() => this.AllianceLeadContact != null;

        /// <summary>
        /// Gets and sets the property Arn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the created partner account.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 200)]
        public string Arn { get; set; }

        /// <summary>
        /// Checks to see if the Arn property is set.
        /// </summary>
        internal bool IsSetArn() => this.Arn != null;

        /// <summary>
        /// Gets and sets the property AwsTrainingCertificationEmailDomains. 
        /// <para>
        /// The list of verified email domains associated with AWS training and certification
        /// credentials for the partner organization.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Max = 100)]
        public List<PartnerDomain> AwsTrainingCertificationEmailDomains { get; set; } = AWSConfigs.InitializeCollections ? new List<PartnerDomain>() : null;

        /// <summary>
        /// Checks to see if the AwsTrainingCertificationEmailDomains property is set.
        /// </summary>
        internal bool IsSetAwsTrainingCertificationEmailDomains() => this.AwsTrainingCertificationEmailDomains != null && (this.AwsTrainingCertificationEmailDomains.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property Catalog. 
        /// <para>
        /// The catalog identifier where the partner account was created.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 64)]
        public string Catalog { get; set; }

        /// <summary>
        /// Checks to see if the Catalog property is set.
        /// </summary>
        internal bool IsSetCatalog() => this.Catalog != null;

        /// <summary>
        /// Gets and sets the property CreatedAt. 
        /// <para>
        /// The timestamp when the partner account was created.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public DateTime? CreatedAt { get; set; }

        /// <summary>
        /// Checks to see if the CreatedAt property is set.
        /// </summary>
        internal bool IsSetCreatedAt() => this.CreatedAt.HasValue;

        /// <summary>
        /// Gets and sets the property Id. 
        /// <para>
        /// The unique identifier of the created partner account.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public string Id { get; set; }

        /// <summary>
        /// Checks to see if the Id property is set.
        /// </summary>
        internal bool IsSetId() => this.Id != null;

        /// <summary>
        /// Gets and sets the property LegalName. 
        /// <para>
        /// The legal name of the partner organization.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Sensitive = true, Min = 1, Max = 80)]
        public string LegalName { get; set; }

        /// <summary>
        /// Checks to see if the LegalName property is set.
        /// </summary>
        internal bool IsSetLegalName() => this.LegalName != null;

        /// <summary>
        /// Gets and sets the property Profile. 
        /// <para>
        /// The partner profile information including display name, description, and other public
        /// details.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public PartnerProfile Profile { get; set; }

        /// <summary>
        /// Checks to see if the Profile property is set.
        /// </summary>
        internal bool IsSetProfile() => this.Profile != null;
    }
}
