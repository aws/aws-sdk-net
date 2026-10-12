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
    /// Container for the parameters to the CreatePartner operation. Creates a new partner
    /// account in the AWS Partner Network with the specified details and configuration.
    /// </summary>
    public partial class CreatePartnerRequest : AmazonPartnerCentralAccountRequest
    {
        /// <summary>
        /// Gets and sets the property AllianceLeadContact. 
        /// <para>
        /// The primary contact person for alliance and partnership matters.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public AllianceLeadContact AllianceLeadContact { get; set; }

        /// <summary>
        /// Checks to see if the AllianceLeadContact property is set.
        /// </summary>
        internal bool IsSetAllianceLeadContact() => this.AllianceLeadContact != null;

        /// <summary>
        /// Gets and sets the property Catalog. 
        /// <para>
        /// The catalog identifier where the partner account will be created.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 64)]
        public string Catalog { get; set; }

        /// <summary>
        /// Checks to see if the Catalog property is set.
        /// </summary>
        internal bool IsSetCatalog() => this.Catalog != null;

        /// <summary>
        /// Gets and sets the property ClientToken. 
        /// <para>
        /// A unique, case-sensitive identifier that you provide to ensure the idempotency of
        /// the request.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 64)]
        public string ClientToken { get; set; }

        /// <summary>
        /// Checks to see if the ClientToken property is set.
        /// </summary>
        internal bool IsSetClientToken() => this.ClientToken != null;

        /// <summary>
        /// Gets and sets the property EmailVerificationCode. 
        /// <para>
        /// The verification code sent to the alliance lead contact's email to confirm account
        /// creation.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Sensitive = true, Min = 6, Max = 6)]
        public string EmailVerificationCode { get; set; }

        /// <summary>
        /// Checks to see if the EmailVerificationCode property is set.
        /// </summary>
        internal bool IsSetEmailVerificationCode() => this.EmailVerificationCode != null;

        /// <summary>
        /// Gets and sets the property LegalName. 
        /// <para>
        /// The legal name of the organization becoming a partner.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Sensitive = true, Min = 1, Max = 80)]
        public string LegalName { get; set; }

        /// <summary>
        /// Checks to see if the LegalName property is set.
        /// </summary>
        internal bool IsSetLegalName() => this.LegalName != null;

        /// <summary>
        /// Gets and sets the property PrimarySolutionType. 
        /// <para>
        /// The primary type of solution or service the partner provides (e.g., consulting, software,
        /// managed services).
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public PrimarySolutionType PrimarySolutionType { get; set; }

        /// <summary>
        /// Checks to see if the PrimarySolutionType property is set.
        /// </summary>
        internal bool IsSetPrimarySolutionType() => this.PrimarySolutionType != null;

        /// <summary>
        /// Gets and sets the property Tags. 
        /// <para>
        /// A list of tags to associate with the partner account for organization and billing
        /// purposes.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Max = 200)]
        public List<Tag> Tags { get; set; } = AWSConfigs.InitializeCollections ? new List<Tag>() : null;

        /// <summary>
        /// Checks to see if the Tags property is set.
        /// </summary>
        internal bool IsSetTags() => this.Tags != null && (this.Tags.Count > 0 || !AWSConfigs.InitializeCollections);
    }
}
