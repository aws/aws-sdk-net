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
 * Do not modify this file. This file is generated from the compute-optimizer-automation-2025-09-22.normal.json service model.
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
namespace Amazon.ComputeOptimizerAutomation.Model
{
    /// <summary>
    /// Contains information about estimated monthly cost savings.
    /// </summary>
    public partial class EstimatedMonthlySavings
    {
        private double? _afterDiscountSavings;
        private double? _beforeDiscountSavings;
        private string _currency;
        private SavingsEstimationMode _savingsEstimationMode;

        /// <summary>
        /// Gets and sets the property AfterDiscountSavings. 
        /// <para>
        ///  The estimated monthly savings after applying any discounts. 
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public double AfterDiscountSavings
        {
            get { return this._afterDiscountSavings.GetValueOrDefault(); }
            set { this._afterDiscountSavings = value; }
        }

        // Check to see if AfterDiscountSavings property is set
        internal bool IsSetAfterDiscountSavings()
        {
            return this._afterDiscountSavings.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property BeforeDiscountSavings. 
        /// <para>
        ///  The estimated monthly savings before applying any discounts. 
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public double BeforeDiscountSavings
        {
            get { return this._beforeDiscountSavings.GetValueOrDefault(); }
            set { this._beforeDiscountSavings = value; }
        }

        // Check to see if BeforeDiscountSavings property is set
        internal bool IsSetBeforeDiscountSavings()
        {
            return this._beforeDiscountSavings.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Currency. 
        /// <para>
        ///  The currency of the estimated savings. 
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string Currency
        {
            get { return this._currency; }
            set { this._currency = value; }
        }

        // Check to see if Currency property is set
        internal bool IsSetCurrency()
        {
            return this._currency != null;
        }

        /// <summary>
        /// Gets and sets the property SavingsEstimationMode. 
        /// <para>
        /// The mode used to calculate savings, either BeforeDiscount or AfterDiscount.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public SavingsEstimationMode SavingsEstimationMode
        {
            get { return this._savingsEstimationMode; }
            set { this._savingsEstimationMode = value; }
        }

        // Check to see if SavingsEstimationMode property is set
        internal bool IsSetSavingsEstimationMode()
        {
            return this._savingsEstimationMode != null;
        }

    }
}