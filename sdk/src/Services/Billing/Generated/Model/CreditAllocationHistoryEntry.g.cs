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
    /// A single entry in the credit allocation history, representing how a credit was applied
    /// to a specific service during a billing month.
    /// </summary>
    public partial class CreditAllocationHistoryEntry
    {
        /// <summary>
        /// Gets and sets the property AccountId. 
        /// <para>
        /// The Amazon Web Services account the credit was applied to.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public string AccountId { get; set; }

        /// <summary>
        /// Checks to see if the AccountId property is set.
        /// </summary>
        internal bool IsSetAccountId() => this.AccountId != null;

        /// <summary>
        /// Gets and sets the property AppliedServiceName. 
        /// <para>
        /// The Amazon Web Services service the credit was applied to.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public string AppliedServiceName { get; set; }

        /// <summary>
        /// Checks to see if the AppliedServiceName property is set.
        /// </summary>
        internal bool IsSetAppliedServiceName() => this.AppliedServiceName != null;

        /// <summary>
        /// Gets and sets the property BillingMonth. 
        /// <para>
        /// The billing month of the application in <c>YYYY-MM</c> format.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 7)]
        public string BillingMonth { get; set; }

        /// <summary>
        /// Checks to see if the BillingMonth property is set.
        /// </summary>
        internal bool IsSetBillingMonth() => this.BillingMonth != null;

        /// <summary>
        /// Gets and sets the property CreditAmount. 
        /// <para>
        /// The amount of credit applied. Negative values represent credits that reduced the bill.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public Amount CreditAmount { get; set; }

        /// <summary>
        /// Checks to see if the CreditAmount property is set.
        /// </summary>
        internal bool IsSetCreditAmount() => this.CreditAmount != null;

        /// <summary>
        /// Gets and sets the property CreditId. 
        /// <para>
        /// The identifier of the credit that was applied.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 32)]
        public string CreditId { get; set; }

        /// <summary>
        /// Checks to see if the CreditId property is set.
        /// </summary>
        internal bool IsSetCreditId() => this.CreditId != null;

        /// <summary>
        /// Gets and sets the property Description. 
        /// <para>
        /// A human-readable description of the credit allocation.
        /// </para>
        /// </summary>
        public string Description { get; set; }

        /// <summary>
        /// Checks to see if the Description property is set.
        /// </summary>
        internal bool IsSetDescription() => this.Description != null;

        /// <summary>
        /// Gets and sets the property IsEstimatedBill. 
        /// <para>
        ///  <c>true</c> when the entry was applied to an in-flight bill that has not yet been
        /// finalized.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public bool? IsEstimatedBill { get; set; }

        /// <summary>
        /// Checks to see if the IsEstimatedBill property is set.
        /// </summary>
        internal bool IsSetIsEstimatedBill() => this.IsEstimatedBill.HasValue;
    }
}
