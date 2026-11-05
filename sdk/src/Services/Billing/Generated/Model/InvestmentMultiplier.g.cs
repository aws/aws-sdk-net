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
    /// A multiplier used to convert attestation input into an investment value.
    /// </summary>
    public partial class InvestmentMultiplier
    {
        /// <summary>
        /// Gets and sets the property InvestmentAttestationInputUnit. 
        /// <para>
        /// The unit of the attestation input that the multiplier applies to, such as <c>workloads
        /// migrated</c>. This value is 1–1000 characters. The terms of the contract define this
        /// value.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 1000)]
        public string InvestmentAttestationInputUnit { get; set; }

        /// <summary>
        /// Checks to see if the InvestmentAttestationInputUnit property is set.
        /// </summary>
        internal bool IsSetInvestmentAttestationInputUnit() => this.InvestmentAttestationInputUnit != null;

        /// <summary>
        /// Gets and sets the property MultiplierType. 
        /// <para>
        /// The type of the multiplier. A value of <c>PERCENTAGE</c> applies a percentage of a
        /// value. A value of <c>CURRENCY_AMOUNT</c> applies a currency amount per unit of attestation
        /// input. The terms of the contract define this value.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public MultiplierType MultiplierType { get; set; }

        /// <summary>
        /// Checks to see if the MultiplierType property is set.
        /// </summary>
        internal bool IsSetMultiplierType() => this.MultiplierType != null;

        /// <summary>
        /// Gets and sets the property Value. 
        /// <para>
        /// The multiplier value, expressed as a decimal string to preserve precision. The value
        /// is digits with an optional decimal point and is 1–1000 characters. The terms of the
        /// contract define this value.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 1000)]
        public string Value { get; set; }

        /// <summary>
        /// Checks to see if the Value property is set.
        /// </summary>
        internal bool IsSetValue() => this.Value != null;
    }
}
