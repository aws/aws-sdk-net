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
    /// Detailed information about an Amazon Web Services credit, including its identifier,
    /// type, monetary amounts, applicable products, sharing configuration, and current enabled
    /// status.
    /// </summary>
    public partial class CreditData
    {
        /// <summary>
        /// Gets and sets the property AccountHasCreditSharingEnabled. 
        /// <para>
        /// Whether the owning account has account-level credit sharing turned on.
        /// </para>
        /// </summary>
        public bool? AccountHasCreditSharingEnabled { get; set; }

        /// <summary>
        /// Checks to see if the AccountHasCreditSharingEnabled property is set.
        /// </summary>
        internal bool IsSetAccountHasCreditSharingEnabled() => this.AccountHasCreditSharingEnabled.HasValue;

        /// <summary>
        /// Gets and sets the property AccountId. 
        /// <para>
        /// The Amazon Web Services account ID that owns the credit.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public string AccountId { get; set; }

        /// <summary>
        /// Checks to see if the AccountId property is set.
        /// </summary>
        internal bool IsSetAccountId() => this.AccountId != null;

        /// <summary>
        /// Gets and sets the property ApplicableProductNames. 
        /// <para>
        /// The names of Amazon Web Services services this credit applies to.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Max = 1000)]
        public List<string> ApplicableProductNames { get; set; } = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Checks to see if the ApplicableProductNames property is set.
        /// </summary>
        internal bool IsSetApplicableProductNames() => this.ApplicableProductNames != null && (this.ApplicableProductNames.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property ApplicationType. 
        /// <para>
        /// When the credit is applied during bill computation. Valid values: <c>BEFORE_CROSS_SERVICE_DISCOUNTS</c>,
        /// <c>AFTER_DISCOUNTS</c>.
        /// </para>
        /// </summary>
        public ApplicationType ApplicationType { get; set; }

        /// <summary>
        /// Checks to see if the ApplicationType property is set.
        /// </summary>
        internal bool IsSetApplicationType() => this.ApplicationType != null;

        /// <summary>
        /// Gets and sets the property CostCategoryArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the Cost Category controlling the credit's sharing
        /// scope. Present only when <c>creditSharingType</c> is <c>COST_CATEGORY_RULE</c>.
        /// </para>
        /// </summary>
        public string CostCategoryArn { get; set; }

        /// <summary>
        /// Checks to see if the CostCategoryArn property is set.
        /// </summary>
        internal bool IsSetCostCategoryArn() => this.CostCategoryArn != null;

        /// <summary>
        /// Gets and sets the property CreditConsoleVisibility. 
        /// <para>
        /// The display configuration for the credit in the Amazon Web Services Billing console.
        /// </para>
        /// </summary>
        public string CreditConsoleVisibility { get; set; }

        /// <summary>
        /// Checks to see if the CreditConsoleVisibility property is set.
        /// </summary>
        internal bool IsSetCreditConsoleVisibility() => this.CreditConsoleVisibility != null;

        /// <summary>
        /// Gets and sets the property CreditId. 
        /// <para>
        /// The unique identifier for the credit.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 32)]
        public string CreditId { get; set; }

        /// <summary>
        /// Checks to see if the CreditId property is set.
        /// </summary>
        internal bool IsSetCreditId() => this.CreditId != null;

        /// <summary>
        /// Gets and sets the property CreditSharingType. 
        /// <para>
        /// The sharing configuration for the credit. Valid values: <c>DEFAULT</c>, <c>DISABLED</c>,
        /// <c>CUSTOM</c>, <c>COST_CATEGORY_RULE</c>.
        /// </para>
        /// </summary>
        public CreditSharingType CreditSharingType { get; set; }

        /// <summary>
        /// Checks to see if the CreditSharingType property is set.
        /// </summary>
        internal bool IsSetCreditSharingType() => this.CreditSharingType != null;

        /// <summary>
        /// Gets and sets the property CreditStatus. 
        /// <para>
        /// Whether the credit participates in billing runs. Valid values: <c>ENABLED</c>, <c>DISABLED</c>.
        /// </para>
        /// </summary>
        public CreditStatus CreditStatus { get; set; }

        /// <summary>
        /// Checks to see if the CreditStatus property is set.
        /// </summary>
        internal bool IsSetCreditStatus() => this.CreditStatus != null;

        /// <summary>
        /// Gets and sets the property CreditType. 
        /// <para>
        /// The type of credit. Examples: <c>Promotion</c>, <c>Refund</c>, <c>TrueUp</c>.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public string CreditType { get; set; }

        /// <summary>
        /// Checks to see if the CreditType property is set.
        /// </summary>
        internal bool IsSetCreditType() => this.CreditType != null;

        /// <summary>
        /// Gets and sets the property Description. 
        /// <para>
        /// A human-readable description of the credit.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public string Description { get; set; }

        /// <summary>
        /// Checks to see if the Description property is set.
        /// </summary>
        internal bool IsSetDescription() => this.Description != null;

        /// <summary>
        /// Gets and sets the property EndDate. 
        /// <para>
        /// The date the credit expires, as Unix epoch seconds.
        /// </para>
        /// </summary>
        public DateTime? EndDate { get; set; }

        /// <summary>
        /// Checks to see if the EndDate property is set.
        /// </summary>
        internal bool IsSetEndDate() => this.EndDate.HasValue;

        /// <summary>
        /// Gets and sets the property EstimatedAmount. 
        /// <para>
        /// The estimated remaining balance, including in-flight (open) bills that have not yet
        /// been finalized.
        /// </para>
        /// </summary>
        public Amount EstimatedAmount { get; set; }

        /// <summary>
        /// Checks to see if the EstimatedAmount property is set.
        /// </summary>
        internal bool IsSetEstimatedAmount() => this.EstimatedAmount != null;

        /// <summary>
        /// Gets and sets the property ExhaustDate. 
        /// <para>
        /// The date the credit balance reached zero, as Unix epoch seconds.
        /// </para>
        /// </summary>
        public DateTime? ExhaustDate { get; set; }

        /// <summary>
        /// Checks to see if the ExhaustDate property is set.
        /// </summary>
        internal bool IsSetExhaustDate() => this.ExhaustDate.HasValue;

        /// <summary>
        /// Gets and sets the property InitialAmount. 
        /// <para>
        /// The initial amount of the credit when it was issued.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public Amount InitialAmount { get; set; }

        /// <summary>
        /// Checks to see if the InitialAmount property is set.
        /// </summary>
        internal bool IsSetInitialAmount() => this.InitialAmount != null;

        /// <summary>
        /// Gets and sets the property PurchaseTypeApplications. 
        /// <para>
        /// Restricts which purchase types this credit applies to. When <c>null</c> or omitted,
        /// the credit applies to all purchase types.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Max = 50)]
        public List<string> PurchaseTypeApplications { get; set; } = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Checks to see if the PurchaseTypeApplications property is set.
        /// </summary>
        internal bool IsSetPurchaseTypeApplications() => this.PurchaseTypeApplications != null && (this.PurchaseTypeApplications.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property RemainingAmount. 
        /// <para>
        /// The unused balance of the credit.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public Amount RemainingAmount { get; set; }

        /// <summary>
        /// Checks to see if the RemainingAmount property is set.
        /// </summary>
        internal bool IsSetRemainingAmount() => this.RemainingAmount != null;

        /// <summary>
        /// Gets and sets the property RuleName. 
        /// <para>
        /// The rule name within the Cost Category. Present only when <c>creditSharingType</c>
        /// is <c>COST_CATEGORY_RULE</c>.
        /// </para>
        /// </summary>
        public string RuleName { get; set; }

        /// <summary>
        /// Checks to see if the RuleName property is set.
        /// </summary>
        internal bool IsSetRuleName() => this.RuleName != null;

        /// <summary>
        /// Gets and sets the property ShareableAccounts. 
        /// <para>
        /// The Amazon Web Services account IDs entitled to apply this credit.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<string> ShareableAccounts { get; set; } = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Checks to see if the ShareableAccounts property is set.
        /// </summary>
        internal bool IsSetShareableAccounts() => this.ShareableAccounts != null && (this.ShareableAccounts.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property StartDate. 
        /// <para>
        /// The date the credit becomes valid, as Unix epoch seconds.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public DateTime? StartDate { get; set; }

        /// <summary>
        /// Checks to see if the StartDate property is set.
        /// </summary>
        internal bool IsSetStartDate() => this.StartDate.HasValue;
    }
}
