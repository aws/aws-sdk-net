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

namespace Amazon.BCMPricingCalculator.Model
{
    /// <summary>
    /// Provides a summary of commitment-related information for a bill estimate.
    /// </summary>
    public partial class BillEstimateCommitmentSummary
    {
        /// <summary>
        /// Gets and sets the property Id. 
        /// <para>
        ///  The unique identifier of the commitment. 
        /// </para>
        /// </summary>
        [AWSProperty(Min = 36, Max = 36)]
        public string Id { get; set; }

        /// <summary>
        /// Checks to see if the Id property is set.
        /// </summary>
        internal bool IsSetId() => this.Id != null;

        /// <summary>
        /// Gets and sets the property MonthlyPayment. 
        /// <para>
        ///  The monthly payment amount for this commitment, if applicable. 
        /// </para>
        /// </summary>
        public CostAmount MonthlyPayment { get; set; }

        /// <summary>
        /// Checks to see if the MonthlyPayment property is set.
        /// </summary>
        internal bool IsSetMonthlyPayment() => this.MonthlyPayment != null;

        /// <summary>
        /// Gets and sets the property OfferingId. 
        /// <para>
        ///  The identifier of the specific offering associated with this commitment. 
        /// </para>
        /// </summary>
        [AWSProperty(Min = 36, Max = 36)]
        public string OfferingId { get; set; }

        /// <summary>
        /// Checks to see if the OfferingId property is set.
        /// </summary>
        internal bool IsSetOfferingId() => this.OfferingId != null;

        /// <summary>
        /// Gets and sets the property PaymentOption. 
        /// <para>
        ///  The payment option chosen for this commitment (e.g., All Upfront, Partial Upfront,
        /// No Upfront). 
        /// </para>
        /// </summary>
        public string PaymentOption { get; set; }

        /// <summary>
        /// Checks to see if the PaymentOption property is set.
        /// </summary>
        internal bool IsSetPaymentOption() => this.PaymentOption != null;

        /// <summary>
        /// Gets and sets the property PurchaseAgreementType. 
        /// <para>
        ///  The type of purchase agreement (e.g., Reserved Instance, Savings Plan). 
        /// </para>
        /// </summary>
        public PurchaseAgreementType PurchaseAgreementType { get; set; }

        /// <summary>
        /// Checks to see if the PurchaseAgreementType property is set.
        /// </summary>
        internal bool IsSetPurchaseAgreementType() => this.PurchaseAgreementType != null;

        /// <summary>
        /// Gets and sets the property Region. 
        /// <para>
        ///  The Amazon Web Services region associated with this commitment. 
        /// </para>
        /// </summary>
        public string Region { get; set; }

        /// <summary>
        /// Checks to see if the Region property is set.
        /// </summary>
        internal bool IsSetRegion() => this.Region != null;

        /// <summary>
        /// Gets and sets the property TermLength. 
        /// <para>
        ///  The length of the commitment term. 
        /// </para>
        /// </summary>
        public string TermLength { get; set; }

        /// <summary>
        /// Checks to see if the TermLength property is set.
        /// </summary>
        internal bool IsSetTermLength() => this.TermLength != null;

        /// <summary>
        /// Gets and sets the property UpfrontPayment. 
        /// <para>
        ///  The upfront payment amount for this commitment, if applicable. 
        /// </para>
        /// </summary>
        public CostAmount UpfrontPayment { get; set; }

        /// <summary>
        /// Checks to see if the UpfrontPayment property is set.
        /// </summary>
        internal bool IsSetUpfrontPayment() => this.UpfrontPayment != null;

        /// <summary>
        /// Gets and sets the property UsageAccountId. 
        /// <para>
        ///  The Amazon Web Services account ID associated with this commitment. 
        /// </para>
        /// </summary>
        [AWSProperty(Min = 12, Max = 12)]
        public string UsageAccountId { get; set; }

        /// <summary>
        /// Checks to see if the UsageAccountId property is set.
        /// </summary>
        internal bool IsSetUsageAccountId() => this.UsageAccountId != null;
    }
}
