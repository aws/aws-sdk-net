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
 * Do not modify this file. This file is generated from the billing-2023-09-07.normal.json service model.
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
        private string _accountId;
        private BusinessSupportDiscount _supportDiscount;
        private List<BusinessSupportServiceSpend> _supportEligibleSpendByService = AWSConfigs.InitializeCollections ? new List<BusinessSupportServiceSpend>() : null;
        private string _supportPlanName;
        private List<BusinessSupportTierCharge> _tierCharges = AWSConfigs.InitializeCollections ? new List<BusinessSupportTierCharge>() : null;
        private string _totalCharge;
        private string _totalUsageBasis;

        /// <summary>
        /// Gets and sets the property AccountId. 
        /// <para>
        /// The linked account ID.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string AccountId
        {
            get { return this._accountId; }
            set { this._accountId = value; }
        }

        // Check to see if AccountId property is set
        internal bool IsSetAccountId()
        {
            return this._accountId != null;
        }

        /// <summary>
        /// Gets and sets the property SupportDiscount. 
        /// <para>
        /// The discount applied to the Business Support charge for this account, if any. This
        /// field is absent when no discount applies.
        /// </para>
        /// </summary>
        public BusinessSupportDiscount SupportDiscount
        {
            get { return this._supportDiscount; }
            set { this._supportDiscount = value; }
        }

        // Check to see if SupportDiscount property is set
        internal bool IsSetSupportDiscount()
        {
            return this._supportDiscount != null;
        }

        /// <summary>
        /// Gets and sets the property SupportEligibleSpendByService. 
        /// <para>
        /// The Support-eligible spend broken down by contributing service for this account.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min=0, Max=50)]
        public List<BusinessSupportServiceSpend> SupportEligibleSpendByService
        {
            get { return this._supportEligibleSpendByService; }
            set { this._supportEligibleSpendByService = value; }
        }

        // Check to see if SupportEligibleSpendByService property is set
        internal bool IsSetSupportEligibleSpendByService()
        {
            return this._supportEligibleSpendByService != null && (this._supportEligibleSpendByService.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property SupportPlanName. 
        /// <para>
        /// The Support plan name for this account. Valid values: <c>AWSSupportBusiness</c> (Business
        /// Support plan), <c>AWSSupportDeveloper</c> (Developer Support plan), <c>AWSSupportEssential</c>
        /// (Basic Support plan).
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string SupportPlanName
        {
            get { return this._supportPlanName; }
            set { this._supportPlanName = value; }
        }

        // Check to see if SupportPlanName property is set
        internal bool IsSetSupportPlanName()
        {
            return this._supportPlanName != null;
        }

        /// <summary>
        /// Gets and sets the property TierCharges. 
        /// <para>
        /// The tier-level charges that make up the total Business Support charge for this account.
        /// Each tier represents a spend range with its own rate.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min=0, Max=20)]
        public List<BusinessSupportTierCharge> TierCharges
        {
            get { return this._tierCharges; }
            set { this._tierCharges = value; }
        }

        // Check to see if TierCharges property is set
        internal bool IsSetTierCharges()
        {
            return this._tierCharges != null && (this._tierCharges.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property TotalCharge. 
        /// <para>
        /// The total Business Support charge amount for this account in the billing month.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string TotalCharge
        {
            get { return this._totalCharge; }
            set { this._totalCharge = value; }
        }

        // Check to see if TotalCharge property is set
        internal bool IsSetTotalCharge()
        {
            return this._totalCharge != null;
        }

        /// <summary>
        /// Gets and sets the property TotalUsageBasis. 
        /// <para>
        /// The total Support-eligible spend used as the basis for calculating the Business Support
        /// charge for this account.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string TotalUsageBasis
        {
            get { return this._totalUsageBasis; }
            set { this._totalUsageBasis = value; }
        }

        // Check to see if TotalUsageBasis property is set
        internal bool IsSetTotalUsageBasis()
        {
            return this._totalUsageBasis != null;
        }

    }
}