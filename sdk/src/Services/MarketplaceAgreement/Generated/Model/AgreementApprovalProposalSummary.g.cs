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

namespace Amazon.MarketplaceAgreement.Model
{
    /// <summary>
    /// A summary of the proposal received from the proposer.
    /// </summary>
    public partial class AgreementApprovalProposalSummary
    {
        /// <summary>
        /// Gets and sets the property OfferId. 
        /// <para>
        /// The unique identifier of the offer in AWS Marketplace.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 64)]
        public string OfferId { get; set; }

        /// <summary>
        /// Checks to see if the OfferId property is set.
        /// </summary>
        internal bool IsSetOfferId() => this.OfferId != null;

        /// <summary>
        /// Gets and sets the property OfferSetId. 
        /// <para>
        /// A unique identifier for the offer set containing this offer.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 50)]
        public string OfferSetId { get; set; }

        /// <summary>
        /// Checks to see if the OfferSetId property is set.
        /// </summary>
        internal bool IsSetOfferSetId() => this.OfferSetId != null;

        /// <summary>
        /// Gets and sets the property Resources. 
        /// <para>
        /// The list of resources involved in the agreement.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min = 0, Max = 100)]
        public List<AgreementApprovalResource> Resources { get; set; } = AWSConfigs.InitializeCollections ? new List<AgreementApprovalResource>() : null;

        /// <summary>
        /// Checks to see if the Resources property is set.
        /// </summary>
        internal bool IsSetResources() => this.Resources != null && (this.Resources.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property VisibilityScope. 
        /// <para>
        /// The visibility of the offer. Valid values are <c>PUBLIC</c> and <c>PRIVATE</c>.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public OfferVisibilityScope VisibilityScope { get; set; }

        /// <summary>
        /// Checks to see if the VisibilityScope property is set.
        /// </summary>
        internal bool IsSetVisibilityScope() => this.VisibilityScope != null;
    }
}
