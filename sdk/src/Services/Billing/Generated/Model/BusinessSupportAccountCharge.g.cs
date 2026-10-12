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

namespace Amazon.Billing.Model
{
    /// <summary>
    /// Business Support charges for a linked account.
    /// </summary>
    public partial class BusinessSupportAccountCharge
    {
        /// <summary>
        /// Gets and sets the property AccountId. 
        /// <para>
        /// The linked account ID.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public string AccountId { get; set; }

        /// <summary>
        /// Checks to see if the AccountId property is set.
        /// </summary>
        internal bool IsSetAccountId() => this.AccountId != null;

        /// <summary>
        /// Gets and sets the property SupportDiscount. 
        /// <para>
        /// The discount applied to the Business Support charge for this account, if any. This
        /// field is absent when no discount applies.
        /// </para>
        /// </summary>
        public BusinessSupportDiscount SupportDiscount { get; set; }

        /// <summary>
        /// Checks to see if the SupportDiscount property is set.
        /// </summary>
        internal bool IsSetSupportDiscount() => this.SupportDiscount != null;

        /// <summary>
        /// Gets and sets the property SupportEligibleSpendByService. 
        /// <para>
        /// The Support-eligible spend broken down by contributing service for this account.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Max = 50)]
        public List<BusinessSupportServiceSpend> SupportEligibleSpendByService { get; set; } = AWSConfigs.InitializeCollections ? new List<BusinessSupportServiceSpend>() : null;

        /// <summary>
        /// Checks to see if the SupportEligibleSpendByService property is set.
        /// </summary>
        internal bool IsSetSupportEligibleSpendByService() => this.SupportEligibleSpendByService != null && (this.SupportEligibleSpendByService.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property SupportPlanName. 
        /// <para>
        /// The Support plan name for this account. Valid values: <c>AWSSupportBusiness</c> (Business
        /// Support plan), <c>AWSSupportDeveloper</c> (Developer Support plan), <c>AWSSupportEssential</c>
        /// (Basic Support plan).
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public string SupportPlanName { get; set; }

        /// <summary>
        /// Checks to see if the SupportPlanName property is set.
        /// </summary>
        internal bool IsSetSupportPlanName() => this.SupportPlanName != null;

        /// <summary>
        /// Gets and sets the property TierCharges. 
        /// <para>
        /// The tier-level charges that make up the total Business Support charge for this account.
        /// Each tier represents a spend range with its own rate.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Max = 20)]
        public List<BusinessSupportTierCharge> TierCharges { get; set; } = AWSConfigs.InitializeCollections ? new List<BusinessSupportTierCharge>() : null;

        /// <summary>
        /// Checks to see if the TierCharges property is set.
        /// </summary>
        internal bool IsSetTierCharges() => this.TierCharges != null && (this.TierCharges.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property TotalCharge. 
        /// <para>
        /// The total Business Support charge amount for this account in the billing month.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public string TotalCharge { get; set; }

        /// <summary>
        /// Checks to see if the TotalCharge property is set.
        /// </summary>
        internal bool IsSetTotalCharge() => this.TotalCharge != null;

        /// <summary>
        /// Gets and sets the property TotalUsageBasis. 
        /// <para>
        /// The total Support-eligible spend used as the basis for calculating the Business Support
        /// charge for this account.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public string TotalUsageBasis { get; set; }

        /// <summary>
        /// Checks to see if the TotalUsageBasis property is set.
        /// </summary>
        internal bool IsSetTotalUsageBasis() => this.TotalUsageBasis != null;
    }
}
