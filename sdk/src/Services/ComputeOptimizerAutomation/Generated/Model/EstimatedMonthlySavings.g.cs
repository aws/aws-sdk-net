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

namespace Amazon.ComputeOptimizerAutomation.Model
{
    /// <summary>
    /// Contains information about estimated monthly cost savings.
    /// </summary>
    public partial class EstimatedMonthlySavings
    {
        /// <summary>
        /// Gets and sets the property AfterDiscountSavings. 
        /// <para>
        ///  The estimated monthly savings after applying any discounts. 
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public double? AfterDiscountSavings { get; set; }

        /// <summary>
        /// Checks to see if the AfterDiscountSavings property is set.
        /// </summary>
        internal bool IsSetAfterDiscountSavings() => this.AfterDiscountSavings.HasValue;

        /// <summary>
        /// Gets and sets the property BeforeDiscountSavings. 
        /// <para>
        ///  The estimated monthly savings before applying any discounts. 
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public double? BeforeDiscountSavings { get; set; }

        /// <summary>
        /// Checks to see if the BeforeDiscountSavings property is set.
        /// </summary>
        internal bool IsSetBeforeDiscountSavings() => this.BeforeDiscountSavings.HasValue;

        /// <summary>
        /// Gets and sets the property Currency. 
        /// <para>
        ///  The currency of the estimated savings. 
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public string Currency { get; set; }

        /// <summary>
        /// Checks to see if the Currency property is set.
        /// </summary>
        internal bool IsSetCurrency() => this.Currency != null;

        /// <summary>
        /// Gets and sets the property SavingsEstimationMode. 
        /// <para>
        /// The mode used to calculate savings, either BeforeDiscount or AfterDiscount.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public SavingsEstimationMode SavingsEstimationMode { get; set; }

        /// <summary>
        /// Checks to see if the SavingsEstimationMode property is set.
        /// </summary>
        internal bool IsSetSavingsEstimationMode() => this.SavingsEstimationMode != null;
    }
}
