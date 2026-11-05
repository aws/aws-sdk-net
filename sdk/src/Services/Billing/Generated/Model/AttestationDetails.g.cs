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
    /// The details of an investment attestation submission, including the value being attested
    /// and how the resulting investment is distributed.
    /// </summary>
    public partial class AttestationDetails
    {
        /// <summary>
        /// Gets and sets the property AttestationValue. 
        /// <para>
        /// The value being attested, expressed as either a monetary amount or one or more quantities.
        /// Exactly one form is set.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public AttestationValue AttestationValue { get; set; }

        /// <summary>
        /// Checks to see if the AttestationValue property is set.
        /// </summary>
        internal bool IsSetAttestationValue() => this.AttestationValue != null;

        /// <summary>
        /// Gets and sets the property InvestmentDistributions. 
        /// <para>
        /// The distribution of the resulting investment across the eligible investment accounts
        /// on the contract. If you omit this value, the full investment is allocated to the single
        /// eligible investment account on the contract. This value is required when multiple
        /// investment accounts are eligible. When you provide this value, the sum of all distributions
        /// must equal the resulting monetary investment value (the attested amount, or the value
        /// computed from the attested quantities using the investment multipliers). The list
        /// contains at most 200 distributions.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Max = 200)]
        public List<InvestmentDistribution> InvestmentDistributions { get; set; } = AWSConfigs.InitializeCollections ? new List<InvestmentDistribution>() : null;

        /// <summary>
        /// Checks to see if the InvestmentDistributions property is set.
        /// </summary>
        internal bool IsSetInvestmentDistributions() => this.InvestmentDistributions != null && (this.InvestmentDistributions.Count > 0 || !AWSConfigs.InitializeCollections);
    }
}
