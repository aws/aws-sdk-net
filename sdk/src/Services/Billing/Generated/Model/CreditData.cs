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
    /// Detailed information about an Amazon Web Services credit, including its identifier,
    /// type, monetary amounts, applicable products, sharing configuration, and current enabled
    /// status.
    /// </summary>
    public partial class CreditData
    {
        private bool? _accountHasCreditSharingEnabled;
        private string _accountId;
        private List<string> _applicableProductNames = AWSConfigs.InitializeCollections ? new List<string>() : null;
        private ApplicationType _applicationType;
        private string _costCategoryArn;
        private string _creditConsoleVisibility;
        private string _creditId;
        private CreditSharingType _creditSharingType;
        private CreditStatus _creditStatus;
        private string _creditType;
        private string _description;
        private DateTime? _endDate;
        private Amount _estimatedAmount;
        private DateTime? _exhaustDate;
        private Amount _initialAmount;
        private List<string> _purchaseTypeApplications = AWSConfigs.InitializeCollections ? new List<string>() : null;
        private Amount _remainingAmount;
        private string _ruleName;
        private List<string> _shareableAccounts = AWSConfigs.InitializeCollections ? new List<string>() : null;
        private DateTime? _startDate;

        /// <summary>
        /// Gets and sets the property AccountHasCreditSharingEnabled. 
        /// <para>
        /// Whether the owning account has account-level credit sharing turned on.
        /// </para>
        /// </summary>
        public bool? AccountHasCreditSharingEnabled
        {
            get { return this._accountHasCreditSharingEnabled; }
            set { this._accountHasCreditSharingEnabled = value; }
        }

        // Check to see if AccountHasCreditSharingEnabled property is set
        internal bool IsSetAccountHasCreditSharingEnabled()
        {
            return this._accountHasCreditSharingEnabled.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property AccountId. 
        /// <para>
        /// The Amazon Web Services account ID that owns the credit.
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
        /// Gets and sets the property ApplicableProductNames. 
        /// <para>
        /// The names of Amazon Web Services services this credit applies to.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min=0, Max=1000)]
        public List<string> ApplicableProductNames
        {
            get { return this._applicableProductNames; }
            set { this._applicableProductNames = value; }
        }

        // Check to see if ApplicableProductNames property is set
        internal bool IsSetApplicableProductNames()
        {
            return this._applicableProductNames != null && (this._applicableProductNames.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property ApplicationType. 
        /// <para>
        /// When the credit is applied during bill computation. Valid values: <c>BEFORE_CROSS_SERVICE_DISCOUNTS</c>,
        /// <c>AFTER_DISCOUNTS</c>.
        /// </para>
        /// </summary>
        public ApplicationType ApplicationType
        {
            get { return this._applicationType; }
            set { this._applicationType = value; }
        }

        // Check to see if ApplicationType property is set
        internal bool IsSetApplicationType()
        {
            return this._applicationType != null;
        }

        /// <summary>
        /// Gets and sets the property CostCategoryArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the Cost Category controlling the credit's sharing
        /// scope. Present only when <c>creditSharingType</c> is <c>COST_CATEGORY_RULE</c>.
        /// </para>
        /// </summary>
        public string CostCategoryArn
        {
            get { return this._costCategoryArn; }
            set { this._costCategoryArn = value; }
        }

        // Check to see if CostCategoryArn property is set
        internal bool IsSetCostCategoryArn()
        {
            return this._costCategoryArn != null;
        }

        /// <summary>
        /// Gets and sets the property CreditConsoleVisibility. 
        /// <para>
        /// The display configuration for the credit in the Amazon Web Services Billing console.
        /// </para>
        /// </summary>
        public string CreditConsoleVisibility
        {
            get { return this._creditConsoleVisibility; }
            set { this._creditConsoleVisibility = value; }
        }

        // Check to see if CreditConsoleVisibility property is set
        internal bool IsSetCreditConsoleVisibility()
        {
            return this._creditConsoleVisibility != null;
        }

        /// <summary>
        /// Gets and sets the property CreditId. 
        /// <para>
        /// The unique identifier for the credit.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=32)]
        public string CreditId
        {
            get { return this._creditId; }
            set { this._creditId = value; }
        }

        // Check to see if CreditId property is set
        internal bool IsSetCreditId()
        {
            return this._creditId != null;
        }

        /// <summary>
        /// Gets and sets the property CreditSharingType. 
        /// <para>
        /// The sharing configuration for the credit. Valid values: <c>DEFAULT</c>, <c>DISABLED</c>,
        /// <c>CUSTOM</c>, <c>COST_CATEGORY_RULE</c>.
        /// </para>
        /// </summary>
        public CreditSharingType CreditSharingType
        {
            get { return this._creditSharingType; }
            set { this._creditSharingType = value; }
        }

        // Check to see if CreditSharingType property is set
        internal bool IsSetCreditSharingType()
        {
            return this._creditSharingType != null;
        }

        /// <summary>
        /// Gets and sets the property CreditStatus. 
        /// <para>
        /// Whether the credit participates in billing runs. Valid values: <c>ENABLED</c>, <c>DISABLED</c>.
        /// </para>
        /// </summary>
        public CreditStatus CreditStatus
        {
            get { return this._creditStatus; }
            set { this._creditStatus = value; }
        }

        // Check to see if CreditStatus property is set
        internal bool IsSetCreditStatus()
        {
            return this._creditStatus != null;
        }

        /// <summary>
        /// Gets and sets the property CreditType. 
        /// <para>
        /// The type of credit. Examples: <c>Promotion</c>, <c>Refund</c>, <c>TrueUp</c>.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string CreditType
        {
            get { return this._creditType; }
            set { this._creditType = value; }
        }

        // Check to see if CreditType property is set
        internal bool IsSetCreditType()
        {
            return this._creditType != null;
        }

        /// <summary>
        /// Gets and sets the property Description. 
        /// <para>
        /// A human-readable description of the credit.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string Description
        {
            get { return this._description; }
            set { this._description = value; }
        }

        // Check to see if Description property is set
        internal bool IsSetDescription()
        {
            return this._description != null;
        }

        /// <summary>
        /// Gets and sets the property EndDate. 
        /// <para>
        /// The date the credit expires, as Unix epoch seconds.
        /// </para>
        /// </summary>
        public DateTime? EndDate
        {
            get { return this._endDate; }
            set { this._endDate = value; }
        }

        // Check to see if EndDate property is set
        internal bool IsSetEndDate()
        {
            return this._endDate.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property EstimatedAmount. 
        /// <para>
        /// The estimated remaining balance, including in-flight (open) bills that have not yet
        /// been finalized.
        /// </para>
        /// </summary>
        public Amount EstimatedAmount
        {
            get { return this._estimatedAmount; }
            set { this._estimatedAmount = value; }
        }

        // Check to see if EstimatedAmount property is set
        internal bool IsSetEstimatedAmount()
        {
            return this._estimatedAmount != null;
        }

        /// <summary>
        /// Gets and sets the property ExhaustDate. 
        /// <para>
        /// The date the credit balance reached zero, as Unix epoch seconds.
        /// </para>
        /// </summary>
        public DateTime? ExhaustDate
        {
            get { return this._exhaustDate; }
            set { this._exhaustDate = value; }
        }

        // Check to see if ExhaustDate property is set
        internal bool IsSetExhaustDate()
        {
            return this._exhaustDate.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property InitialAmount. 
        /// <para>
        /// The initial amount of the credit when it was issued.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public Amount InitialAmount
        {
            get { return this._initialAmount; }
            set { this._initialAmount = value; }
        }

        // Check to see if InitialAmount property is set
        internal bool IsSetInitialAmount()
        {
            return this._initialAmount != null;
        }

        /// <summary>
        /// Gets and sets the property PurchaseTypeApplications. 
        /// <para>
        /// Restricts which purchase types this credit applies to. When <c>null</c> or omitted,
        /// the credit applies to all purchase types.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min=0, Max=50)]
        public List<string> PurchaseTypeApplications
        {
            get { return this._purchaseTypeApplications; }
            set { this._purchaseTypeApplications = value; }
        }

        // Check to see if PurchaseTypeApplications property is set
        internal bool IsSetPurchaseTypeApplications()
        {
            return this._purchaseTypeApplications != null && (this._purchaseTypeApplications.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property RemainingAmount. 
        /// <para>
        /// The unused balance of the credit.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public Amount RemainingAmount
        {
            get { return this._remainingAmount; }
            set { this._remainingAmount = value; }
        }

        // Check to see if RemainingAmount property is set
        internal bool IsSetRemainingAmount()
        {
            return this._remainingAmount != null;
        }

        /// <summary>
        /// Gets and sets the property RuleName. 
        /// <para>
        /// The rule name within the Cost Category. Present only when <c>creditSharingType</c>
        /// is <c>COST_CATEGORY_RULE</c>.
        /// </para>
        /// </summary>
        public string RuleName
        {
            get { return this._ruleName; }
            set { this._ruleName = value; }
        }

        // Check to see if RuleName property is set
        internal bool IsSetRuleName()
        {
            return this._ruleName != null;
        }

        /// <summary>
        /// Gets and sets the property ShareableAccounts. 
        /// <para>
        /// The Amazon Web Services account IDs entitled to apply this credit.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<string> ShareableAccounts
        {
            get { return this._shareableAccounts; }
            set { this._shareableAccounts = value; }
        }

        // Check to see if ShareableAccounts property is set
        internal bool IsSetShareableAccounts()
        {
            return this._shareableAccounts != null && (this._shareableAccounts.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property StartDate. 
        /// <para>
        /// The date the credit becomes valid, as Unix epoch seconds.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public DateTime? StartDate
        {
            get { return this._startDate; }
            set { this._startDate = value; }
        }

        // Check to see if StartDate property is set
        internal bool IsSetStartDate()
        {
            return this._startDate.HasValue; 
        }

    }
}