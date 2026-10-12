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

namespace Amazon.CostOptimizationHub.Model
{
    /// <summary>
    /// The preferred configuration for Reserved Instances and Savings Plans commitment-based
    /// discounts, consisting of a payment option and a commitment duration.
    /// </summary>
    public partial class PreferredCommitment
    {
        /// <summary>
        /// Gets and sets the property PaymentOption. 
        /// <para>
        /// The preferred upfront payment structure for commitments. If the value is null, it
        /// will default to <c>AllUpfront</c> (highest savings) where applicable.
        /// </para>
        /// </summary>
        public PaymentOption PaymentOption { get; set; }

        /// <summary>
        /// Checks to see if the PaymentOption property is set.
        /// </summary>
        internal bool IsSetPaymentOption() => this.PaymentOption != null;

        /// <summary>
        /// Gets and sets the property Term. 
        /// <para>
        /// The preferred length of the commitment period. If the value is null, it will default
        /// to <c>ThreeYears</c> (highest savings) where applicable.
        /// </para>
        /// </summary>
        public Term Term { get; set; }

        /// <summary>
        /// Checks to see if the Term property is set.
        /// </summary>
        internal bool IsSetTerm() => this.Term != null;
    }
}
