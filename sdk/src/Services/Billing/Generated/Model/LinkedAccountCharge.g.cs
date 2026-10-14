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
    /// Enterprise Support charges for a linked account.
    /// </summary>
    public partial class LinkedAccountCharge
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
        /// Gets and sets the property AccountType. 
        /// <para>
        /// The type of account.
        /// </para>
        /// </summary>
        public string AccountType { get; set; }

        /// <summary>
        /// Checks to see if the AccountType property is set.
        /// </summary>
        internal bool IsSetAccountType() => this.AccountType != null;

        /// <summary>
        /// Gets and sets the property BillableSeconds. 
        /// <para>
        /// The number of billable seconds in the billing period based on when the account was
        /// subscribed to Enterprise Support.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public long? BillableSeconds { get; set; }

        /// <summary>
        /// Checks to see if the BillableSeconds property is set.
        /// </summary>
        internal bool IsSetBillableSeconds() => this.BillableSeconds.HasValue;

        /// <summary>
        /// Gets and sets the property LinkedTimePeriods. 
        /// <para>
        /// The time periods during which this account was linked.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Max = 500)]
        public List<EnterpriseSupportTimePeriod> LinkedTimePeriods { get; set; } = AWSConfigs.InitializeCollections ? new List<EnterpriseSupportTimePeriod>() : null;

        /// <summary>
        /// Checks to see if the LinkedTimePeriods property is set.
        /// </summary>
        internal bool IsSetLinkedTimePeriods() => this.LinkedTimePeriods != null && (this.LinkedTimePeriods.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property PayerAccountId. 
        /// <para>
        /// The payer account ID that is authorized to view Enterprise Support data for all accounts
        /// in its Support profile.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public string PayerAccountId { get; set; }

        /// <summary>
        /// Checks to see if the PayerAccountId property is set.
        /// </summary>
        internal bool IsSetPayerAccountId() => this.PayerAccountId != null;

        /// <summary>
        /// Gets and sets the property ProratedTotalSupportEligibleSpend. 
        /// <para>
        /// The prorated total support-eligible spend based on when the account was subscribed
        /// to Enterprise Support.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public string ProratedTotalSupportEligibleSpend { get; set; }

        /// <summary>
        /// Checks to see if the ProratedTotalSupportEligibleSpend property is set.
        /// </summary>
        internal bool IsSetProratedTotalSupportEligibleSpend() => this.ProratedTotalSupportEligibleSpend != null;

        /// <summary>
        /// Gets and sets the property SubscriptionTimePeriods. 
        /// <para>
        /// The subscription time periods for this account.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Max = 500)]
        public List<EnterpriseSupportTimePeriod> SubscriptionTimePeriods { get; set; } = AWSConfigs.InitializeCollections ? new List<EnterpriseSupportTimePeriod>() : null;

        /// <summary>
        /// Checks to see if the SubscriptionTimePeriods property is set.
        /// </summary>
        internal bool IsSetSubscriptionTimePeriods() => this.SubscriptionTimePeriods != null && (this.SubscriptionTimePeriods.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property SupportEligibleSpendByService. 
        /// <para>
        /// The support-eligible spend broken down by service.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Max = 200)]
        public List<ServiceLevelAccountUsage> SupportEligibleSpendByService { get; set; } = AWSConfigs.InitializeCollections ? new List<ServiceLevelAccountUsage>() : null;

        /// <summary>
        /// Checks to see if the SupportEligibleSpendByService property is set.
        /// </summary>
        internal bool IsSetSupportEligibleSpendByService() => this.SupportEligibleSpendByService != null && (this.SupportEligibleSpendByService.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property TotalSeconds. 
        /// <para>
        /// The total number of seconds in the billing period.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public long? TotalSeconds { get; set; }

        /// <summary>
        /// Checks to see if the TotalSeconds property is set.
        /// </summary>
        internal bool IsSetTotalSeconds() => this.TotalSeconds.HasValue;

        /// <summary>
        /// Gets and sets the property TotalSupportEligibleReservedInstanceSpend. 
        /// <para>
        /// The total support-eligible Reserved Instance spend for this account.
        /// </para>
        /// </summary>
        public string TotalSupportEligibleReservedInstanceSpend { get; set; }

        /// <summary>
        /// Checks to see if the TotalSupportEligibleReservedInstanceSpend property is set.
        /// </summary>
        internal bool IsSetTotalSupportEligibleReservedInstanceSpend() => this.TotalSupportEligibleReservedInstanceSpend != null;

        /// <summary>
        /// Gets and sets the property TotalSupportEligibleSavingsPlanSpend. 
        /// <para>
        /// The total support-eligible Savings Plan spend for this account.
        /// </para>
        /// </summary>
        public string TotalSupportEligibleSavingsPlanSpend { get; set; }

        /// <summary>
        /// Checks to see if the TotalSupportEligibleSavingsPlanSpend property is set.
        /// </summary>
        internal bool IsSetTotalSupportEligibleSavingsPlanSpend() => this.TotalSupportEligibleSavingsPlanSpend != null;

        /// <summary>
        /// Gets and sets the property TotalSupportEligibleSpend. 
        /// <para>
        /// The total support-eligible spend for this account.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public string TotalSupportEligibleSpend { get; set; }

        /// <summary>
        /// Checks to see if the TotalSupportEligibleSpend property is set.
        /// </summary>
        internal bool IsSetTotalSupportEligibleSpend() => this.TotalSupportEligibleSpend != null;
    }
}
