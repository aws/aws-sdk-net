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
 * Do not modify this file. This file is generated from the bcm-pricing-calculator-2024-06-19.normal.json service model.
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
        private string _id;
        private CostAmount _monthlyPayment;
        private string _offeringId;
        private string _paymentOption;
        private PurchaseAgreementType _purchaseAgreementType;
        private string _region;
        private string _termLength;
        private CostAmount _upfrontPayment;
        private string _usageAccountId;

        /// <summary>
        /// Gets and sets the property Id. 
        /// <para>
        ///  The unique identifier of the commitment. 
        /// </para>
        /// </summary>
        [AWSProperty(Min=36, Max=36)]
        public string Id
        {
            get { return this._id; }
            set { this._id = value; }
        }

        // Check to see if Id property is set
        internal bool IsSetId()
        {
            return this._id != null;
        }

        /// <summary>
        /// Gets and sets the property MonthlyPayment. 
        /// <para>
        ///  The monthly payment amount for this commitment, if applicable. 
        /// </para>
        /// </summary>
        public CostAmount MonthlyPayment
        {
            get { return this._monthlyPayment; }
            set { this._monthlyPayment = value; }
        }

        // Check to see if MonthlyPayment property is set
        internal bool IsSetMonthlyPayment()
        {
            return this._monthlyPayment != null;
        }

        /// <summary>
        /// Gets and sets the property OfferingId. 
        /// <para>
        ///  The identifier of the specific offering associated with this commitment. 
        /// </para>
        /// </summary>
        [AWSProperty(Min=36, Max=36)]
        public string OfferingId
        {
            get { return this._offeringId; }
            set { this._offeringId = value; }
        }

        // Check to see if OfferingId property is set
        internal bool IsSetOfferingId()
        {
            return this._offeringId != null;
        }

        /// <summary>
        /// Gets and sets the property PaymentOption. 
        /// <para>
        ///  The payment option chosen for this commitment (e.g., All Upfront, Partial Upfront,
        /// No Upfront). 
        /// </para>
        /// </summary>
        public string PaymentOption
        {
            get { return this._paymentOption; }
            set { this._paymentOption = value; }
        }

        // Check to see if PaymentOption property is set
        internal bool IsSetPaymentOption()
        {
            return this._paymentOption != null;
        }

        /// <summary>
        /// Gets and sets the property PurchaseAgreementType. 
        /// <para>
        ///  The type of purchase agreement (e.g., Reserved Instance, Savings Plan). 
        /// </para>
        /// </summary>
        public PurchaseAgreementType PurchaseAgreementType
        {
            get { return this._purchaseAgreementType; }
            set { this._purchaseAgreementType = value; }
        }

        // Check to see if PurchaseAgreementType property is set
        internal bool IsSetPurchaseAgreementType()
        {
            return this._purchaseAgreementType != null;
        }

        /// <summary>
        /// Gets and sets the property Region. 
        /// <para>
        ///  The Amazon Web Services region associated with this commitment. 
        /// </para>
        /// </summary>
        public string Region
        {
            get { return this._region; }
            set { this._region = value; }
        }

        // Check to see if Region property is set
        internal bool IsSetRegion()
        {
            return this._region != null;
        }

        /// <summary>
        /// Gets and sets the property TermLength. 
        /// <para>
        ///  The length of the commitment term. 
        /// </para>
        /// </summary>
        public string TermLength
        {
            get { return this._termLength; }
            set { this._termLength = value; }
        }

        // Check to see if TermLength property is set
        internal bool IsSetTermLength()
        {
            return this._termLength != null;
        }

        /// <summary>
        /// Gets and sets the property UpfrontPayment. 
        /// <para>
        ///  The upfront payment amount for this commitment, if applicable. 
        /// </para>
        /// </summary>
        public CostAmount UpfrontPayment
        {
            get { return this._upfrontPayment; }
            set { this._upfrontPayment = value; }
        }

        // Check to see if UpfrontPayment property is set
        internal bool IsSetUpfrontPayment()
        {
            return this._upfrontPayment != null;
        }

        /// <summary>
        /// Gets and sets the property UsageAccountId. 
        /// <para>
        ///  The Amazon Web Services account ID associated with this commitment. 
        /// </para>
        /// </summary>
        [AWSProperty(Min=12, Max=12)]
        public string UsageAccountId
        {
            get { return this._usageAccountId; }
            set { this._usageAccountId = value; }
        }

        // Check to see if UsageAccountId property is set
        internal bool IsSetUsageAccountId()
        {
            return this._usageAccountId != null;
        }

    }
}