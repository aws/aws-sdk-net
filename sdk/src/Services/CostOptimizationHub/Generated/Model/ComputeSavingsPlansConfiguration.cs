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
 * Do not modify this file. This file is generated from the cost-optimization-hub-2022-07-26.normal.json service model.
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
namespace Amazon.CostOptimizationHub.Model
{
    /// <summary>
    /// The Compute Savings Plans configuration used for recommendations.
    /// </summary>
    public partial class ComputeSavingsPlansConfiguration
    {
        private string _accountScope;
        private string _hourlyCommitment;
        private string _paymentOption;
        private string _term;

        /// <summary>
        /// Gets and sets the property AccountScope. 
        /// <para>
        /// The account scope for which you want recommendations. Amazon Web Services calculates
        /// recommendations including the management account and member accounts if the value
        /// is set to <c>PAYER</c>. If the value is <c>LINKED</c>, recommendations are calculated
        /// for individual member accounts only.
        /// </para>
        /// </summary>
        public string AccountScope
        {
            get { return this._accountScope; }
            set { this._accountScope = value; }
        }

        // Check to see if AccountScope property is set
        internal bool IsSetAccountScope()
        {
            return this._accountScope != null;
        }

        /// <summary>
        /// Gets and sets the property HourlyCommitment. 
        /// <para>
        /// The hourly commitment for the Savings Plans type.
        /// </para>
        /// </summary>
        public string HourlyCommitment
        {
            get { return this._hourlyCommitment; }
            set { this._hourlyCommitment = value; }
        }

        // Check to see if HourlyCommitment property is set
        internal bool IsSetHourlyCommitment()
        {
            return this._hourlyCommitment != null;
        }

        /// <summary>
        /// Gets and sets the property PaymentOption. 
        /// <para>
        /// The payment option for the commitment.
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
        /// Gets and sets the property Term. 
        /// <para>
        /// The Savings Plans recommendation term in years.
        /// </para>
        /// </summary>
        public string Term
        {
            get { return this._term; }
            set { this._term = value; }
        }

        // Check to see if Term property is set
        internal bool IsSetTerm()
        {
            return this._term != null;
        }

    }
}