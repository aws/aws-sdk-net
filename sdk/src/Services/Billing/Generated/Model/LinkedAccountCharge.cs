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
    /// Enterprise Support charges for a linked account.
    /// </summary>
    public partial class LinkedAccountCharge
    {
        private string _accountId;
        private string _accountType;
        private long? _billableSeconds;
        private List<EnterpriseSupportTimePeriod> _linkedTimePeriods = AWSConfigs.InitializeCollections ? new List<EnterpriseSupportTimePeriod>() : null;
        private string _payerAccountId;
        private string _proratedTotalSupportEligibleSpend;
        private List<EnterpriseSupportTimePeriod> _subscriptionTimePeriods = AWSConfigs.InitializeCollections ? new List<EnterpriseSupportTimePeriod>() : null;
        private List<ServiceLevelAccountUsage> _supportEligibleSpendByService = AWSConfigs.InitializeCollections ? new List<ServiceLevelAccountUsage>() : null;
        private long? _totalSeconds;
        private string _totalSupportEligibleReservedInstanceSpend;
        private string _totalSupportEligibleSavingsPlanSpend;
        private string _totalSupportEligibleSpend;

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
        /// Gets and sets the property AccountType. 
        /// <para>
        /// The type of account.
        /// </para>
        /// </summary>
        public string AccountType
        {
            get { return this._accountType; }
            set { this._accountType = value; }
        }

        // Check to see if AccountType property is set
        internal bool IsSetAccountType()
        {
            return this._accountType != null;
        }

        /// <summary>
        /// Gets and sets the property BillableSeconds. 
        /// <para>
        /// The number of billable seconds in the billing period based on when the account was
        /// subscribed to Enterprise Support.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public long? BillableSeconds
        {
            get { return this._billableSeconds; }
            set { this._billableSeconds = value; }
        }

        // Check to see if BillableSeconds property is set
        internal bool IsSetBillableSeconds()
        {
            return this._billableSeconds.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property LinkedTimePeriods. 
        /// <para>
        /// The time periods during which this account was linked.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min=0, Max=500)]
        public List<EnterpriseSupportTimePeriod> LinkedTimePeriods
        {
            get { return this._linkedTimePeriods; }
            set { this._linkedTimePeriods = value; }
        }

        // Check to see if LinkedTimePeriods property is set
        internal bool IsSetLinkedTimePeriods()
        {
            return this._linkedTimePeriods != null && (this._linkedTimePeriods.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property PayerAccountId. 
        /// <para>
        /// The payer account ID that is authorized to view Enterprise Support data for all accounts
        /// in its Support profile.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string PayerAccountId
        {
            get { return this._payerAccountId; }
            set { this._payerAccountId = value; }
        }

        // Check to see if PayerAccountId property is set
        internal bool IsSetPayerAccountId()
        {
            return this._payerAccountId != null;
        }

        /// <summary>
        /// Gets and sets the property ProratedTotalSupportEligibleSpend. 
        /// <para>
        /// The prorated total support-eligible spend based on when the account was subscribed
        /// to Enterprise Support.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string ProratedTotalSupportEligibleSpend
        {
            get { return this._proratedTotalSupportEligibleSpend; }
            set { this._proratedTotalSupportEligibleSpend = value; }
        }

        // Check to see if ProratedTotalSupportEligibleSpend property is set
        internal bool IsSetProratedTotalSupportEligibleSpend()
        {
            return this._proratedTotalSupportEligibleSpend != null;
        }

        /// <summary>
        /// Gets and sets the property SubscriptionTimePeriods. 
        /// <para>
        /// The subscription time periods for this account.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min=0, Max=500)]
        public List<EnterpriseSupportTimePeriod> SubscriptionTimePeriods
        {
            get { return this._subscriptionTimePeriods; }
            set { this._subscriptionTimePeriods = value; }
        }

        // Check to see if SubscriptionTimePeriods property is set
        internal bool IsSetSubscriptionTimePeriods()
        {
            return this._subscriptionTimePeriods != null && (this._subscriptionTimePeriods.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property SupportEligibleSpendByService. 
        /// <para>
        /// The support-eligible spend broken down by service.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min=0, Max=50)]
        public List<ServiceLevelAccountUsage> SupportEligibleSpendByService
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
        /// Gets and sets the property TotalSeconds. 
        /// <para>
        /// The total number of seconds in the billing period.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public long? TotalSeconds
        {
            get { return this._totalSeconds; }
            set { this._totalSeconds = value; }
        }

        // Check to see if TotalSeconds property is set
        internal bool IsSetTotalSeconds()
        {
            return this._totalSeconds.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property TotalSupportEligibleReservedInstanceSpend. 
        /// <para>
        /// The total support-eligible Reserved Instance spend for this account.
        /// </para>
        /// </summary>
        public string TotalSupportEligibleReservedInstanceSpend
        {
            get { return this._totalSupportEligibleReservedInstanceSpend; }
            set { this._totalSupportEligibleReservedInstanceSpend = value; }
        }

        // Check to see if TotalSupportEligibleReservedInstanceSpend property is set
        internal bool IsSetTotalSupportEligibleReservedInstanceSpend()
        {
            return this._totalSupportEligibleReservedInstanceSpend != null;
        }

        /// <summary>
        /// Gets and sets the property TotalSupportEligibleSavingsPlanSpend. 
        /// <para>
        /// The total support-eligible Savings Plan spend for this account.
        /// </para>
        /// </summary>
        public string TotalSupportEligibleSavingsPlanSpend
        {
            get { return this._totalSupportEligibleSavingsPlanSpend; }
            set { this._totalSupportEligibleSavingsPlanSpend = value; }
        }

        // Check to see if TotalSupportEligibleSavingsPlanSpend property is set
        internal bool IsSetTotalSupportEligibleSavingsPlanSpend()
        {
            return this._totalSupportEligibleSavingsPlanSpend != null;
        }

        /// <summary>
        /// Gets and sets the property TotalSupportEligibleSpend. 
        /// <para>
        /// The total support-eligible spend for this account.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string TotalSupportEligibleSpend
        {
            get { return this._totalSupportEligibleSpend; }
            set { this._totalSupportEligibleSpend = value; }
        }

        // Check to see if TotalSupportEligibleSpend property is set
        internal bool IsSetTotalSupportEligibleSpend()
        {
            return this._totalSupportEligibleSpend != null;
        }

    }
}