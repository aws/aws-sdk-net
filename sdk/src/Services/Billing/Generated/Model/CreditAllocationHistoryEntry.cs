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
    /// A single entry in the credit allocation history, representing how a credit was applied
    /// to a specific service during a billing month.
    /// </summary>
    public partial class CreditAllocationHistoryEntry
    {
        private string _accountId;
        private string _appliedServiceName;
        private string _billingMonth;
        private Amount _creditAmount;
        private string _creditId;
        private string _description;
        private bool? _isEstimatedBill;

        /// <summary>
        /// Gets and sets the property AccountId. 
        /// <para>
        /// The Amazon Web Services account the credit was applied to.
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
        /// Gets and sets the property AppliedServiceName. 
        /// <para>
        /// The Amazon Web Services service the credit was applied to.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string AppliedServiceName
        {
            get { return this._appliedServiceName; }
            set { this._appliedServiceName = value; }
        }

        // Check to see if AppliedServiceName property is set
        internal bool IsSetAppliedServiceName()
        {
            return this._appliedServiceName != null;
        }

        /// <summary>
        /// Gets and sets the property BillingMonth. 
        /// <para>
        /// The billing month of the application in <c>YYYY-MM</c> format.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=7)]
        public string BillingMonth
        {
            get { return this._billingMonth; }
            set { this._billingMonth = value; }
        }

        // Check to see if BillingMonth property is set
        internal bool IsSetBillingMonth()
        {
            return this._billingMonth != null;
        }

        /// <summary>
        /// Gets and sets the property CreditAmount. 
        /// <para>
        /// The amount of credit applied. Negative values represent credits that reduced the bill.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public Amount CreditAmount
        {
            get { return this._creditAmount; }
            set { this._creditAmount = value; }
        }

        // Check to see if CreditAmount property is set
        internal bool IsSetCreditAmount()
        {
            return this._creditAmount != null;
        }

        /// <summary>
        /// Gets and sets the property CreditId. 
        /// <para>
        /// The identifier of the credit that was applied.
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
        /// Gets and sets the property Description. 
        /// <para>
        /// A human-readable description of the credit allocation.
        /// </para>
        /// </summary>
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
        /// Gets and sets the property IsEstimatedBill. 
        /// <para>
        ///  <c>true</c> when the entry was applied to an in-flight bill that has not yet been
        /// finalized.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public bool? IsEstimatedBill
        {
            get { return this._isEstimatedBill; }
            set { this._isEstimatedBill = value; }
        }

        // Check to see if IsEstimatedBill property is set
        internal bool IsSetIsEstimatedBill()
        {
            return this._isEstimatedBill.HasValue; 
        }

    }
}