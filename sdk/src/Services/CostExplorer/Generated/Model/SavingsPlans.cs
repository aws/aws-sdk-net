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
 * Do not modify this file. This file is generated from the ce-2017-10-25.normal.json service model.
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
namespace Amazon.CostExplorer.Model
{
    /// <summary>
    /// The Savings Plans commitment details.
    /// </summary>
    public partial class SavingsPlans
    {
        private string _instanceFamily;
        private string _offeringId;
        private PaymentOption _paymentOption;
        private string _region;
        private double? _savingsPlansCommitment;
        private SupportedSavingsPlansType _savingsPlansType;
        private TermInYears _termInYears;

        /// <summary>
        /// Gets and sets the property InstanceFamily. 
        /// <para>
        /// The instance family of the Savings Plans commitment.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=1024)]
        public string InstanceFamily
        {
            get { return this._instanceFamily; }
            set { this._instanceFamily = value; }
        }

        // Check to see if InstanceFamily property is set
        internal bool IsSetInstanceFamily()
        {
            return this._instanceFamily != null;
        }

        /// <summary>
        /// Gets and sets the property OfferingId. 
        /// <para>
        /// The unique ID that's used to distinguish Savings Plans commitments from one another.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=1024)]
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
        /// The payment option for the Savings Plans commitment.
        /// </para>
        /// </summary>
        public PaymentOption PaymentOption
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
        /// Gets and sets the property Region. 
        /// <para>
        /// The Region associated with the Savings Plans commitment.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=1024)]
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
        /// Gets and sets the property SavingsPlansCommitment. 
        /// <para>
        /// The Savings Plans commitment.
        /// </para>
        /// </summary>
        [AWSProperty(Max=5000)]
        public double? SavingsPlansCommitment
        {
            get { return this._savingsPlansCommitment; }
            set { this._savingsPlansCommitment = value; }
        }

        // Check to see if SavingsPlansCommitment property is set
        internal bool IsSetSavingsPlansCommitment()
        {
            return this._savingsPlansCommitment.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property SavingsPlansType. 
        /// <para>
        /// The Savings Plans type.
        /// </para>
        /// </summary>
        public SupportedSavingsPlansType SavingsPlansType
        {
            get { return this._savingsPlansType; }
            set { this._savingsPlansType = value; }
        }

        // Check to see if SavingsPlansType property is set
        internal bool IsSetSavingsPlansType()
        {
            return this._savingsPlansType != null;
        }

        /// <summary>
        /// Gets and sets the property TermInYears. 
        /// <para>
        /// The term that you want the Savings Plans commitment for.
        /// </para>
        /// </summary>
        public TermInYears TermInYears
        {
            get { return this._termInYears; }
            set { this._termInYears = value; }
        }

        // Check to see if TermInYears property is set
        internal bool IsSetTermInYears()
        {
            return this._termInYears != null;
        }

    }
}